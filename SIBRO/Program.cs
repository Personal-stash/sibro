using System;
using System.Windows.Forms;
using SIBRO.Forms;

namespace SIBRO
{
    internal static class Program
    {
        /// <summary>Alur aplikasi: Login dulu, jika berhasil baru Dashboard terbuka.</summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Jaring pengaman: error tak terduga ditampilkan sebagai pesan, aplikasi tidak langsung tertutup.
            Application.ThreadException += (pengirim, e) =>
                MessageBox.Show(e.Exception.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);

            using (FormLogin login = new FormLogin())
            {
                if (login.ShowDialog() != DialogResult.OK) return;
            }

            Application.Run(new FormDashboard());
        }
    }
}
