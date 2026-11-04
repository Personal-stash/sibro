using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>
    /// Kelas induk semua form (inheritance). Berisi fungsi yang dipakai bersama:
    /// pesan, penanganan error, dan pengisian ComboBox kandang.
    /// Setiap form mengisi datanya sendiri dengan meng-override MuatData (polymorphism).
    /// </summary>
    public class BaseForm : Form
    {
        public BaseForm()
        {
            Font = new Font("Segoe UI", 9F);
            BackColor = Color.FromArgb(245, 247, 250);
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            JalankanAman(MuatData);
        }

        /// <summary>Dipanggil otomatis saat form dibuka. Di-override oleh form turunan.</summary>
        protected virtual void MuatData()
        {
        }

        /// <summary>Menjalankan aksi; jika gagal, error ditampilkan tanpa membuat aplikasi tertutup.</summary>
        protected void JalankanAman(Action aksi)
        {
            try
            {
                aksi();
            }
            catch (Exception ex)
            {
                TampilkanError(ex);
            }
        }

        protected void Info(string pesan)
        {
            MessageBox.Show(this, pesan, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void Peringatan(string pesan)
        {
            MessageBox.Show(this, pesan, "Periksa Kembali", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected bool Konfirmasi(string pesan)
        {
            return MessageBox.Show(this, pesan, "Konfirmasi", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
        }

        protected void TampilkanError(Exception ex)
        {
            MessageBox.Show(this, TerjemahkanError(ex), "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>Mengubah error teknis MySQL menjadi pesan yang mudah dipahami pengguna.</summary>
        private static string TerjemahkanError(Exception ex)
        {
            MySqlException mysql = ex as MySqlException ?? ex.InnerException as MySqlException;
            if (mysql == null) return ex.Message;

            switch (mysql.Number)
            {
                case 0:
                case 1042:
                    return "Tidak dapat terhubung ke MySQL. Pastikan server MySQL sudah berjalan (misalnya lewat XAMPP).";
                case 1045:
                    return "User atau password MySQL salah. Sesuaikan di file Data/DatabaseHelper.cs.";
                case 1049:
                    return "Database sibro_db belum ada. Jalankan dulu file Database/sibro_db.sql.";
                case 1146:
                    return "Tabel belum lengkap. Jalankan dulu file Database/sibro_db.sql.";
                case 1451:
                    return "Data tidak bisa dihapus karena masih dipakai oleh data lain.\n" +
                           "Hapus dulu data yang terkait, atau ubah status kandang menjadi Nonaktif.";
                default:
                    return "Kesalahan database: " + mysql.Message;
            }
        }

        /// <summary>
        /// Mengisi ComboBox dengan daftar kandang. Jika denganSemua = true,
        /// ditambahkan pilihan "Semua Kandang" dengan id 0 untuk keperluan filter.
        /// </summary>
        protected void IsiComboKandang(ComboBox combo, bool denganSemua)
        {
            List<Kandang> daftar = new KandangRepository().GetAllKandang();
            if (denganSemua)
            {
                daftar.Insert(0, new Kandang { IdKandang = 0, NamaKandang = "-- Semua Kandang --" });
            }
            combo.DataSource = null;
            combo.DisplayMember = "NamaKandang";
            combo.ValueMember = "IdKandang";
            combo.DataSource = daftar;
        }

        /// <summary>Id kandang yang dipilih, atau 0 jika belum ada pilihan.</summary>
        protected static int IdKandangTerpilih(ComboBox combo)
        {
            Kandang k = combo.SelectedItem as Kandang;
            return k == null ? 0 : k.IdKandang;
        }

        /// <summary>Mengisi NumericUpDown dengan aman meski nilainya di luar batas kontrol.</summary>
        protected static void SetNilai(NumericUpDown kontrol, double nilai)
        {
            decimal d = (decimal)nilai;
            kontrol.Value = Math.Min(kontrol.Maximum, Math.Max(kontrol.Minimum, d));
        }
    }
}
