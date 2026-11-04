using System;

namespace SIBRO.Models
{
    /// <summary>Model untuk tabel tbl_ayam.</summary>
    public class Ayam : BaseEntity
    {
        public int IdAyam { get; set; }
        public int IdKandang { get; set; }
        public int JumlahAyam { get; set; }

        /// <summary>Umur ayam saat masuk kandang (hari).</summary>
        public int UmurHari { get; set; }

        public string JenisAyam { get; set; }
        public DateTime TanggalMasuk { get; set; }

        /// <summary>Nama kandang hasil JOIN, hanya untuk ditampilkan.</summary>
        public string NamaKandang { get; set; }

        /// <summary>Umur hari ini, bertambah otomatis setiap hari sejak tanggal masuk.</summary>
        public int UmurSekarang
        {
            get { return UmurHari + Math.Max(0, (DateTime.Today - TanggalMasuk.Date).Days); }
        }

        public Ayam()
        {
            TanggalMasuk = DateTime.Today;
        }

        public Ayam(int idAyam, int idKandang, int jumlahAyam, int umurHari, string jenisAyam, DateTime tanggalMasuk)
        {
            IdAyam = idAyam;
            IdKandang = idKandang;
            JumlahAyam = jumlahAyam;
            UmurHari = umurHari;
            JenisAyam = jenisAyam;
            TanggalMasuk = tanggalMasuk;
        }

        public override string Validasi()
        {
            if (IdKandang <= 0) return "Kandang harus dipilih.";
            if (JumlahAyam <= 0) return "Jumlah ayam harus lebih dari 0.";
            if (UmurHari < 0) return "Umur tidak boleh negatif.";
            if (string.IsNullOrWhiteSpace(JenisAyam)) return "Jenis ayam tidak boleh kosong.";
            if (TanggalMasuk.Date > DateTime.Today) return "Tanggal masuk tidak boleh di masa depan.";
            return string.Empty;
        }
    }
}
