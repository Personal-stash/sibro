namespace SIBRO.Models
{
    /// <summary>Model untuk tabel tbl_penyakit.</summary>
    public class Penyakit : BaseEntity
    {
        public int IdPenyakit { get; set; }
        public string NamaPenyakit { get; set; }
        public string Deskripsi { get; set; }
        public string Gejala { get; set; }
        public string Penanganan { get; set; }
        public string TingkatBahaya { get; set; }

        public override string Validasi()
        {
            if (string.IsNullOrWhiteSpace(NamaPenyakit)) return "Nama penyakit tidak boleh kosong.";
            return string.Empty;
        }

        public override string ToString()
        {
            return NamaPenyakit;
        }
    }
}
