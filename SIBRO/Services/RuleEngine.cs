using System;
using System.Collections.Generic;
using System.Linq;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Services
{
    /// <summary>
    /// Sistem pakar berbasis aturan (rule-based). Setiap penyakit punya method sendiri.
    /// Jika beberapa aturan cocok, nilai tertinggi yang dipakai karena aturan diperiksa
    /// dari persentase terbesar. Hasilnya perkiraan awal, bukan diagnosis dokter hewan.
    /// </summary>
    public class RuleEngine : IDeteksi
    {
        public const string NEWCASTLE = "Newcastle Disease";
        public const string CRD = "Chronic Respiratory Disease (CRD)";
        public const string GUMBORO = "Gumboro (IBD)";
        public const string COCCIDIOSIS = "Coccidiosis";
        public const string AVIAN_INFLUENZA = "Avian Influenza (ringan)";

        private const double AMBANG_MINIMUM = 30;

        private readonly Func<int, int?> _getUmurKandang;
        private readonly Func<string, Penyakit> _getPenyakit;

        /// <summary>Constructor normal: data umur dan penyakit diambil dari database.</summary>
        public RuleEngine()
        {
            AyamRepository ayamRepo = new AyamRepository();
            PenyakitRepository penyakitRepo = new PenyakitRepository();

            _getUmurKandang = idKandang =>
            {
                Ayam ayam = ayamRepo.GetAyamTerbaruByKandang(idKandang);
                return ayam == null ? (int?)null : ayam.UmurSekarang;
            };
            _getPenyakit = penyakitRepo.GetPenyakitByNama;
        }

        /// <summary>Constructor dengan sumber data sendiri, berguna untuk pengujian tanpa database.</summary>
        public RuleEngine(Func<int, int?> getUmurKandang, Func<string, Penyakit> getPenyakit)
        {
            _getUmurKandang = getUmurKandang;
            _getPenyakit = getPenyakit;
        }

        public double DeteksiNewcastle(Monitoring m)
        {
            if (m.Suhu > 39 && m.Kelembaban > 80 && m.KondisiUmum == Monitoring.KONDISI_KRITIS) return 85;
            if (m.Suhu > 38 && m.KondisiUmum == Monitoring.KONDISI_KURANG_BAIK) return 60;
            return 0;
        }

        public double DeteksiCRD(Monitoring m)
        {
            if (m.Suhu < 20 && m.Kelembaban > 75) return 75;
            if (m.Suhu < 22 && m.KondisiUmum != Monitoring.KONDISI_NORMAL) return 50;
            return 0;
        }

        public double DeteksiGumboro(Monitoring m)
        {
            if (m.Kelembaban > 85 && HitungPenurunanBerat(m) > 10) return 70;
            if (m.KondisiUmum == Monitoring.KONDISI_KRITIS && m.Kelembaban > 80) return 65;
            return 0;
        }

        public double DeteksiCoccidiosis(Monitoring m)
        {
            if (m.Kelembaban > 80 && m.Suhu >= 25 && m.Suhu <= 32 && m.KondisiUmum != Monitoring.KONDISI_NORMAL) return 70;
            return 0;
        }

        public double DeteksiAvianInfluenza(Monitoring m)
        {
            if (m.Suhu > 40 && m.KondisiUmum == Monitoring.KONDISI_KRITIS) return 90;
            if (m.Suhu > 39 && m.Kelembaban > 85) return 70;
            return 0;
        }

        /// <summary>
        /// Persentase berat di bawah normal sesuai umur. Bernilai 0 jika umur tidak
        /// diketahui atau berat tidak diisi, agar tidak menghasilkan alarm palsu.
        /// </summary>
        private double HitungPenurunanBerat(Monitoring m)
        {
            int? umur = _getUmurKandang(m.IdKandang);
            if (umur == null || m.BeratRata2 <= 0) return 0;

            double normal = StandarBerat.GetBeratNormal(umur.Value);
            return (normal - m.BeratRata2) / normal * 100;
        }

        /// <summary>Menjalankan semua aturan; mengembalikan hasil di atas 30%, tertinggi lebih dulu.</summary>
        public List<HasilDeteksi> Analisis(Monitoring data)
        {
            if (data == null) throw new ArgumentNullException("data");

            Dictionary<string, double> skor = new Dictionary<string, double>
            {
                { NEWCASTLE, DeteksiNewcastle(data) },
                { CRD, DeteksiCRD(data) },
                { GUMBORO, DeteksiGumboro(data) },
                { COCCIDIOSIS, DeteksiCoccidiosis(data) },
                { AVIAN_INFLUENZA, DeteksiAvianInfluenza(data) }
            };

            return skor.Where(s => s.Value > AMBANG_MINIMUM)
                       .OrderByDescending(s => s.Value)
                       .Select(s => BuatHasil(data, s.Key, s.Value))
                       .ToList();
        }

        private HasilDeteksi BuatHasil(Monitoring data, string namaPenyakit, double persentase)
        {
            Penyakit penyakit = _getPenyakit(namaPenyakit);
            if (penyakit == null)
            {
                throw new InvalidOperationException(
                    "Data penyakit \"" + namaPenyakit + "\" tidak ada di tbl_penyakit. Jalankan ulang Database/sibro_db.sql.");
            }

            return new HasilDeteksi
            {
                IdKandang = data.IdKandang,
                IdMonitoring = data.IdMonitoring,
                IdPenyakit = penyakit.IdPenyakit,
                NamaKandang = data.NamaKandang,
                NamaPenyakit = penyakit.NamaPenyakit,
                TingkatBahaya = penyakit.TingkatBahaya,
                PersentaseKemungkinan = persentase
            };
        }

        public string GetRekomendasiPenanganan(string namaPenyakit)
        {
            Penyakit penyakit = _getPenyakit(namaPenyakit);
            return penyakit == null ? "Data penanganan tidak ditemukan." : penyakit.Penanganan;
        }
    }
}
