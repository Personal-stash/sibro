using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace SIBRO.Data
{
    /// <summary>
    /// Kelas induk semua repository (konsep inheritance).
    /// Kode buka koneksi dan jalankan query cukup ditulis sekali di sini.
    /// Semua nilai dikirim lewat parameter agar aman dari SQL Injection.
    /// </summary>
    public abstract class BaseRepository
    {
        protected static MySqlParameter P(string nama, object nilai)
        {
            return new MySqlParameter(nama, nilai ?? DBNull.Value);
        }

        protected List<T> AmbilBanyak<T>(string sql, Func<IDataRecord, T> map, params MySqlParameter[] parameter)
        {
            List<T> hasil = new List<T>();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameter);
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hasil.Add(map(reader));
                    }
                }
            }
            return hasil;
        }

        /// <summary>Mengambil satu baris pertama, atau null jika tidak ada.</summary>
        protected T AmbilSatu<T>(string sql, Func<IDataRecord, T> map, params MySqlParameter[] parameter) where T : class
        {
            List<T> hasil = AmbilBanyak(sql, map, parameter);
            return hasil.Count > 0 ? hasil[0] : null;
        }

        /// <summary>Menjalankan INSERT, UPDATE, atau DELETE. Mengembalikan jumlah baris terdampak.</summary>
        protected int Jalankan(string sql, params MySqlParameter[] parameter)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameter);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>Mengambil satu nilai, misalnya hasil COUNT atau SUM.</summary>
        protected object AmbilNilai(string sql, params MySqlParameter[] parameter)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameter);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        protected DataTable AmbilTabel(string sql, params MySqlParameter[] parameter)
        {
            DataTable tabel = new DataTable();
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddRange(parameter);
                adapter.Fill(tabel);
            }
            return tabel;
        }

        /// <summary>Mengubah nilai database ke int; NULL menjadi 0.</summary>
        protected int KeInt(object nilai)
        {
            return nilai == null || nilai == DBNull.Value ? 0 : Convert.ToInt32(nilai);
        }

        /// <summary>Mengubah nilai database ke double; NULL menjadi 0.</summary>
        protected double KeDouble(object nilai)
        {
            return nilai == null || nilai == DBNull.Value ? 0 : Convert.ToDouble(nilai);
        }
    }
}
