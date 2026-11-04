using System;
using System.Collections.Generic;
using System.Data;
using SIBRO.Models;

namespace SIBRO.Data
{
    /// <summary>Operasi database untuk tbl_monitoring.</summary>
    public class MonitoringRepository : BaseRepository
    {
        private const string SELECT_MONITORING =
            "SELECT m.*, k.nama_kandang FROM tbl_monitoring m " +
            "INNER JOIN tbl_kandang k ON k.id_kandang = m.id_kandang ";

        private const string URUT_TERBARU = "ORDER BY m.tanggal_input DESC, m.waktu_input DESC, m.id_monitoring DESC ";

        private Monitoring MapMonitoring(IDataRecord r)
        {
            return new Monitoring
            {
                IdMonitoring = Convert.ToInt32(r["id_monitoring"]),
                IdKandang = Convert.ToInt32(r["id_kandang"]),
                Suhu = Convert.ToDouble(r["suhu"]),
                Kelembaban = Convert.ToDouble(r["kelembaban"]),
                BeratRata2 = Convert.ToDouble(r["berat_rata2"]),
                KondisiUmum = Convert.ToString(r["kondisi_umum"]),
                Catatan = Convert.ToString(r["catatan"]),
                TanggalInput = Convert.ToDateTime(r["tanggal_input"]),
                WaktuInput = (TimeSpan)r["waktu_input"],
                NamaKandang = Convert.ToString(r["nama_kandang"])
            };
        }

        public List<Monitoring> GetAllMonitoring()
        {
            return AmbilBanyak(SELECT_MONITORING + URUT_TERBARU, MapMonitoring);
        }

        public List<Monitoring> GetMonitoringByKandang(int idKandang)
        {
            return AmbilBanyak(SELECT_MONITORING + "WHERE m.id_kandang = @id " + URUT_TERBARU, MapMonitoring, P("@id", idKandang));
        }

        public List<Monitoring> GetMonitoringByTanggal(DateTime tgl)
        {
            return AmbilBanyak(SELECT_MONITORING + "WHERE m.tanggal_input = @tgl " + URUT_TERBARU, MapMonitoring, P("@tgl", tgl.Date));
        }

        /// <summary>Filter riwayat. idKandang = 0 berarti semua kandang.</summary>
        public List<Monitoring> GetMonitoringFilter(int idKandang, DateTime dari, DateTime sampai)
        {
            return AmbilBanyak(
                SELECT_MONITORING + "WHERE (@id = 0 OR m.id_kandang = @id) AND m.tanggal_input BETWEEN @dari AND @sampai " + URUT_TERBARU,
                MapMonitoring, P("@id", idKandang), P("@dari", dari.Date), P("@sampai", sampai.Date));
        }

        /// <summary>Mengambil 1 data terbaru sebuah kandang, atau null jika belum ada.</summary>
        public Monitoring GetMonitoringTerbaru(int idKandang)
        {
            return AmbilSatu(SELECT_MONITORING + "WHERE m.id_kandang = @id " + URUT_TERBARU + "LIMIT 1", MapMonitoring, P("@id", idKandang));
        }

        /// <summary>Mengambil sejumlah data terbaru dari semua kandang (untuk dashboard).</summary>
        public List<Monitoring> GetMonitoringTerbaruSemua(int jumlah)
        {
            return AmbilBanyak(SELECT_MONITORING + URUT_TERBARU + "LIMIT @jumlah", MapMonitoring, P("@jumlah", jumlah));
        }

        public bool InsertMonitoring(Monitoring m)
        {
            return Jalankan(
                "INSERT INTO tbl_monitoring (id_kandang, suhu, kelembaban, berat_rata2, kondisi_umum, catatan, tanggal_input, waktu_input) " +
                "VALUES (@kandang, @suhu, @kelembaban, @berat, @kondisi, @catatan, @tanggal, @waktu)",
                P("@kandang", m.IdKandang), P("@suhu", m.Suhu), P("@kelembaban", m.Kelembaban), P("@berat", m.BeratRata2),
                P("@kondisi", m.KondisiUmum), P("@catatan", m.Catatan), P("@tanggal", m.TanggalInput.Date), P("@waktu", m.WaktuInput)) > 0;
        }

        public bool UpdateMonitoring(Monitoring m)
        {
            return Jalankan(
                "UPDATE tbl_monitoring SET id_kandang = @kandang, suhu = @suhu, kelembaban = @kelembaban, berat_rata2 = @berat, " +
                "kondisi_umum = @kondisi, catatan = @catatan, tanggal_input = @tanggal, waktu_input = @waktu WHERE id_monitoring = @id",
                P("@kandang", m.IdKandang), P("@suhu", m.Suhu), P("@kelembaban", m.Kelembaban), P("@berat", m.BeratRata2),
                P("@kondisi", m.KondisiUmum), P("@catatan", m.Catatan), P("@tanggal", m.TanggalInput.Date), P("@waktu", m.WaktuInput),
                P("@id", m.IdMonitoring)) > 0;
        }

        public bool DeleteMonitoring(int id)
        {
            return Jalankan("DELETE FROM tbl_monitoring WHERE id_monitoring = @id", P("@id", id)) > 0;
        }
    }
}
