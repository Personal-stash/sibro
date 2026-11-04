using System;

namespace SIBRO.Models
{
    /// <summary>Model untuk tabel tbl_monitoring.</summary>
    public class Monitoring : BaseEntity
    {
        public const string KONDISI_NORMAL = "Normal";
        public const string KONDISI_KURANG_BAIK = "Kurang Baik";
        public const string KONDISI_KRITIS = "Kritis";

        public int IdMonitoring { get; set; }
        public int IdKandang { get; set; }
        public double Suhu { get; set; }
        public double Kelembaban { get; set; }
        public double BeratRata2 { get; set; }
        public string KondisiUmum { get; set; }
        public string Catatan { get; set; }
        public DateTime TanggalInput { get; set; }
        public TimeSpan WaktuInput { get; set; }

        /// <summary>Nama kandang hasil JOIN, hanya untuk ditampilkan.</summary>
        public string NamaKandang { get; set; }

        public Monitoring()
        {
            KondisiUmum = KONDISI_NORMAL;
            TanggalInput = DateTime.Today;
            WaktuInput = DateTime.Now.TimeOfDay;
        }

        public Monitoring(int idKandang, double suhu, double kelembaban, double beratRata2,
            string kondisiUmum, string catatan, DateTime tanggalInput, TimeSpan waktuInput)
        {
            IdKandang = idKandang;
            Suhu = suhu;
            Kelembaban = kelembaban;
            BeratRata2 = beratRata2;
            KondisiUmum = kondisiUmum;
            Catatan = catatan;
            TanggalInput = tanggalInput;
            WaktuInput = waktuInput;
        }

        public override string Validasi()
        {
            if (IdKandang <= 0) return "Kandang harus dipilih.";
            if (Suhu < 15 || Suhu > 45) return "Suhu harus di antara 15 sampai 45 °C.";
            if (Kelembaban < 0 || Kelembaban > 100) return "Kelembaban harus di antara 0 sampai 100 %.";
            if (BeratRata2 < 0 || BeratRata2 > 5000) return "Berat rata-rata harus di antara 0 sampai 5000 gram.";
            if (string.IsNullOrWhiteSpace(KondisiUmum)) return "Kondisi umum harus dipilih.";
            if (TanggalInput.Date > DateTime.Today) return "Tanggal input tidak boleh di masa depan.";
            return string.Empty;
        }

        public override string ToString()
        {
            return string.Format("[{0:dd/MM/yyyy}] Kandang {1}: suhu {2:0.0} °C, kelembaban {3:0.0} %, berat {4:0.0} g, kondisi {5}",
                TanggalInput, string.IsNullOrEmpty(NamaKandang) ? IdKandang.ToString() : NamaKandang,
                Suhu, Kelembaban, BeratRata2, KondisiUmum);
        }
    }
}
