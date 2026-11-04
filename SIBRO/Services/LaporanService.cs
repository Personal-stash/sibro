using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Services
{
    /// <summary>Mengambil data laporan dan mengekspornya ke file.</summary>
    public class LaporanService : BaseRepository
    {
        private const string NAMA_INSTITUSI = "PROGRAM STUDI INFORMATIKA";

        private DataTable GetDataPeriode(int idKandang, DateTime dari, DateTime sampai)
        {
            return AmbilTabel(
                "SELECT DATE_FORMAT(m.tanggal_input, '%d/%m/%Y') AS Tanggal, TIME_FORMAT(m.waktu_input, '%H:%i') AS Waktu, " +
                "k.nama_kandang AS Kandang, m.suhu AS Suhu, m.kelembaban AS Kelembaban, m.berat_rata2 AS Berat, " +
                "m.kondisi_umum AS Kondisi, m.catatan AS Catatan " +
                "FROM tbl_monitoring m INNER JOIN tbl_kandang k ON k.id_kandang = m.id_kandang " +
                "WHERE m.id_kandang = @id AND m.tanggal_input BETWEEN @dari AND @sampai " +
                "ORDER BY m.tanggal_input, m.waktu_input",
                P("@id", idKandang), P("@dari", dari.Date), P("@sampai", sampai.Date));
        }

        public DataTable GetDataLaporanHarian(int idKandang, DateTime tanggal)
        {
            return GetDataPeriode(idKandang, tanggal, tanggal);
        }

        /// <summary>Data 7 hari mulai dari tanggal mingguAwal.</summary>
        public DataTable GetDataLaporanMingguan(int idKandang, DateTime mingguAwal)
        {
            return GetDataPeriode(idKandang, mingguAwal, mingguAwal.AddDays(6));
        }

        /// <summary>Data satu bulan penuh dari bulan pada tanggal yang dipilih.</summary>
        public DataTable GetDataLaporanBulanan(int idKandang, DateTime tanggal)
        {
            DateTime awal = new DateTime(tanggal.Year, tanggal.Month, 1);
            return GetDataPeriode(idKandang, awal, awal.AddMonths(1).AddDays(-1));
        }

        /// <summary>Statistik keseluruhan: rata2_suhu, rata2_kelembaban, total_monitoring, total_deteksi.</summary>
        public Dictionary<string, object> GetSummaryStatistik(int idKandang)
        {
            Dictionary<string, object> hasil = new Dictionary<string, object>();
            DataTable tabel = AmbilTabel(
                "SELECT AVG(suhu) AS rata_suhu, AVG(kelembaban) AS rata_kelembaban, COUNT(*) AS total " +
                "FROM tbl_monitoring WHERE id_kandang = @id", P("@id", idKandang));

            hasil["rata2_suhu"] = KeDouble(tabel.Rows[0]["rata_suhu"]);
            hasil["rata2_kelembaban"] = KeDouble(tabel.Rows[0]["rata_kelembaban"]);
            hasil["total_monitoring"] = KeInt(tabel.Rows[0]["total"]);
            hasil["total_deteksi"] = KeInt(AmbilNilai("SELECT COUNT(*) FROM tbl_hasil_deteksi WHERE id_kandang = @id", P("@id", idKandang)));
            return hasil;
        }

        /// <summary>Statistik satu periode dari tabel laporan: rata2_suhu, rata2_kelembaban, kondisi_dominan.</summary>
        public static Dictionary<string, object> HitungStatistikPeriode(DataTable data)
        {
            Dictionary<string, object> hasil = new Dictionary<string, object>();
            List<DataRow> baris = data.Rows.Cast<DataRow>().ToList();

            hasil["rata2_suhu"] = baris.Count == 0 ? 0 : baris.Average(b => Convert.ToDouble(b["Suhu"]));
            hasil["rata2_kelembaban"] = baris.Count == 0 ? 0 : baris.Average(b => Convert.ToDouble(b["Kelembaban"]));
            hasil["kondisi_dominan"] = baris.Count == 0
                ? "-"
                : baris.GroupBy(b => Convert.ToString(b["Kondisi"])).OrderByDescending(g => g.Count()).First().Key;
            return hasil;
        }

        public bool ExportLaporanCSV(DataTable dt, string filePath)
        {
            try
            {
                StringBuilder isi = new StringBuilder();
                isi.AppendLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(k => FormatCsv(k.ColumnName))));
                foreach (DataRow baris in dt.Rows)
                {
                    isi.AppendLine(string.Join(",", baris.ItemArray.Select(FormatCsv)));
                }
                // UTF-8 dengan BOM agar simbol seperti ° terbaca benar di Excel.
                File.WriteAllText(filePath, isi.ToString(), new UTF8Encoding(true));
                return true;
            }
            catch (IOException) { return false; }
            catch (UnauthorizedAccessException) { return false; }
        }

        /// <summary>Angka memakai titik desimal; teks yang berisi koma atau kutip diapit tanda kutip.</summary>
        private static string FormatCsv(object nilai)
        {
            IFormattable angka = nilai as IFormattable;
            string teks = angka != null ? angka.ToString(null, CultureInfo.InvariantCulture) : Convert.ToString(nilai);
            if (teks.IndexOfAny(new[] { ',', '"', '\r', '\n' }) >= 0)
            {
                return "\"" + teks.Replace("\"", "\"\"") + "\"";
            }
            return teks;
        }

        public bool ExportLaporanTXT(int idKandang, DateTime dari, DateTime sampai, string filePath)
        {
            try
            {
                File.WriteAllText(filePath, BuatTeksLaporan(idKandang, dari, sampai), new UTF8Encoding(true));
                return true;
            }
            catch (IOException) { return false; }
            catch (UnauthorizedAccessException) { return false; }
            catch (MySqlException) { return false; }
        }

        /// <summary>Menyusun laporan formal. Teks yang sama dipakai untuk file TXT dan cetak.</summary>
        public string BuatTeksLaporan(int idKandang, DateTime dari, DateTime sampai)
        {
            Kandang kandang = new KandangRepository().GetKandangById(idKandang);
            DataTable data = GetDataPeriode(idKandang, dari, sampai);
            Dictionary<string, object> periode = HitungStatistikPeriode(data);
            Dictionary<string, object> keseluruhan = GetSummaryStatistik(idKandang);
            string garis = new string('=', 78);

            StringBuilder t = new StringBuilder();
            t.AppendLine(garis);
            t.AppendLine(NAMA_INSTITUSI);
            t.AppendLine("SI BRO - SISTEM MONITORING KONDISI AYAM BROILER");
            t.AppendLine("LAPORAN MONITORING KANDANG");
            t.AppendLine(garis);
            t.AppendLine("Kandang        : " + (kandang == null ? "-" : kandang.NamaKandang));
            t.AppendLine("Lokasi         : " + (kandang == null ? "-" : kandang.Lokasi));
            t.AppendLine(string.Format("Periode        : {0:dd/MM/yyyy} s.d. {1:dd/MM/yyyy}", dari, sampai));
            t.AppendLine(string.Format("Tanggal cetak  : {0:dd/MM/yyyy HH:mm}", DateTime.Now));
            t.AppendLine();
            t.AppendLine("RINGKASAN PERIODE");
            t.AppendLine("Jumlah data          : " + data.Rows.Count);
            t.AppendLine(string.Format("Rata-rata suhu       : {0:0.0} °C", periode["rata2_suhu"]));
            t.AppendLine(string.Format("Rata-rata kelembaban : {0:0.0} %", periode["rata2_kelembaban"]));
            t.AppendLine("Kondisi dominan      : " + periode["kondisi_dominan"]);
            t.AppendLine("Total deteksi kandang: " + keseluruhan["total_deteksi"] + " (sejak awal pencatatan)");
            t.AppendLine();
            t.AppendLine("RINCIAN DATA");
            t.AppendLine(string.Format("{0,-11}{1,-7}{2,7}{3,8}{4,9}  {5,-12}{6}", "Tanggal", "Waktu", "Suhu", "Lembap", "Berat", "Kondisi", "Catatan"));
            t.AppendLine(new string('-', 78));
            foreach (DataRow b in data.Rows)
            {
                string catatan = Convert.ToString(b["Catatan"]).Replace("\r", " ").Replace("\n", " ");
                if (catatan.Length > 22) catatan = catatan.Substring(0, 19) + "...";
                t.AppendLine(string.Format("{0,-11}{1,-7}{2,7:0.0}{3,8:0.0}{4,9:0.0}  {5,-12}{6}",
                    b["Tanggal"], b["Waktu"], Convert.ToDouble(b["Suhu"]), Convert.ToDouble(b["Kelembaban"]),
                    Convert.ToDouble(b["Berat"]), b["Kondisi"], catatan));
            }
            if (data.Rows.Count == 0) t.AppendLine("(Tidak ada data pada periode ini)");
            t.AppendLine(garis);
            return t.ToString();
        }
    }
}
