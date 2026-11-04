using System;

namespace SIBRO.Models
{
    /// <summary>Model untuk tabel tbl_kandang.</summary>
    public class Kandang : BaseEntity
    {
        public const string STATUS_AKTIF = "Aktif";
        public const string STATUS_NONAKTIF = "Nonaktif";

        public int IdKandang { get; set; }
        public string NamaKandang { get; set; }
        public int Kapasitas { get; set; }
        public string Lokasi { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public Kandang()
        {
            Status = STATUS_AKTIF;
            CreatedAt = DateTime.Now;
        }

        public Kandang(int idKandang, string namaKandang, int kapasitas, string lokasi, string status)
            : this()
        {
            IdKandang = idKandang;
            NamaKandang = namaKandang;
            Kapasitas = kapasitas;
            Lokasi = lokasi;
            Status = status;
        }

        public override string Validasi()
        {
            if (string.IsNullOrWhiteSpace(NamaKandang)) return "Nama kandang tidak boleh kosong.";
            if (Kapasitas <= 0) return "Kapasitas harus lebih dari 0.";
            if (string.IsNullOrWhiteSpace(Lokasi)) return "Lokasi tidak boleh kosong.";
            if (Status != STATUS_AKTIF && Status != STATUS_NONAKTIF) return "Status harus dipilih.";
            return string.Empty;
        }

        public override string ToString()
        {
            return NamaKandang;
        }
    }
}
