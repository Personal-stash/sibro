namespace SIBRO.Models
{
    /// <summary>
    /// Kelas induk semua model (konsep inheritance).
    /// Setiap model wajib punya aturan validasinya sendiri (konsep polymorphism).
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>Mengembalikan pesan kesalahan, atau string kosong jika data valid.</summary>
        public abstract string Validasi();

        public bool IsValid()
        {
            return string.IsNullOrEmpty(Validasi());
        }
    }
}
