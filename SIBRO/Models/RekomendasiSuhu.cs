using System;

namespace SIBRO.Models
{
    /// <summary>Model untuk tabel tbl_rekomendasi_suhu.</summary>
    public class RekomendasiSuhu : BaseEntity
    {
        public const string STATUS_OPTIMAL = "Optimal";
        public const string STATUS_PANAS = "Terlalu Panas";
        public const string STATUS_DINGIN = "Terlalu Dingin";
        public const string STATUS_LEMBAP = "Terlalu Lembap";
        public const string STATUS_KERING = "Terlalu Kering";

        public int IdRekomendasi { get; set; }
        public int UmurHariMin { get; set; }
        public int UmurHariMax { get; set; }
        public double SuhuIdealMin { get; set; }
        public double SuhuIdealMax { get; set; }
        public double KelembabanIdealMin { get; set; }
        public double KelembabanIdealMax { get; set; }
        public string Keterangan { get; set; }

        public string CekStatusSuhu(double suhuAktual)
        {
            if (suhuAktual > SuhuIdealMax) return STATUS_PANAS;
            if (suhuAktual < SuhuIdealMin) return STATUS_DINGIN;
            return STATUS_OPTIMAL;
        }

        public string CekStatusKelembaban(double kelembabanAktual)
        {
            if (kelembabanAktual > KelembabanIdealMax) return STATUS_LEMBAP;
            if (kelembabanAktual < KelembabanIdealMin) return STATUS_KERING;
            return STATUS_OPTIMAL;
        }

        public override string Validasi()
        {
            if (UmurHariMin > UmurHariMax) return "Rentang umur tidak valid.";
            if (SuhuIdealMin > SuhuIdealMax) return "Rentang suhu tidak valid.";
            if (KelembabanIdealMin > KelembabanIdealMax) return "Rentang kelembaban tidak valid.";
            return string.Empty;
        }
    }
}
