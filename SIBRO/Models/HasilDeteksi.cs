using System;

namespace SIBRO.Models
{
    /// <summary>Model untuk tabel tbl_hasil_deteksi.</summary>
    public class HasilDeteksi : BaseEntity
    {
        public const string STATUS_BELUM = "Belum Ditangani";
        public const string STATUS_PROSES = "Dalam Penanganan";
        public const string STATUS_SELESAI = "Selesai";

        public int IdDeteksi { get; set; }
        public int IdKandang { get; set; }
        public int IdMonitoring { get; set; }
        public int IdPenyakit { get; set; }
        public double PersentaseKemungkinan { get; set; }
        public DateTime TanggalDeteksi { get; set; }
        public string StatusPenanganan { get; set; }

        // Tiga kolom berikut hasil JOIN, hanya untuk ditampilkan.
        public string NamaKandang { get; set; }
        public string NamaPenyakit { get; set; }
        public string TingkatBahaya { get; set; }

        public HasilDeteksi()
        {
            TanggalDeteksi = DateTime.Now;
            StatusPenanganan = STATUS_BELUM;
        }

        public override string Validasi()
        {
            if (IdKandang <= 0) return "Kandang tidak valid.";
            if (IdMonitoring <= 0) return "Data monitoring tidak valid.";
            if (IdPenyakit <= 0) return "Data penyakit tidak valid.";
            if (PersentaseKemungkinan < 0 || PersentaseKemungkinan > 100) return "Persentase harus 0 sampai 100.";
            return string.Empty;
        }
    }
}
