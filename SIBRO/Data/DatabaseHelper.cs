using MySql.Data.MySqlClient;

namespace SIBRO.Data
{
    /// <summary>
    /// Satu-satunya tempat pengaturan koneksi database.
    /// Sesuaikan Uid dan Pwd jika MySQL Anda memakai password
    /// (bawaan XAMPP: user root tanpa password).
    /// </summary>
    public static class DatabaseHelper
    {
        private const string CONNECTION_STRING =
            "Server=localhost;Port=3306;Database=sibro_db;Uid=root;Pwd=;" +
            "CharSet=utf8mb4;SslMode=None;AllowPublicKeyRetrieval=True;";

        /// <summary>Membuat koneksi baru. Pemanggil yang membuka dan menutupnya.</summary>
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(CONNECTION_STRING);
        }
    }
}
