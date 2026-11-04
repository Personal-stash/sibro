using System;
using System.Windows.Forms;

namespace SIBRO.Forms
{
    /// <summary>Halaman masuk. Akun masih ditulis di kode sesuai ketentuan tugas.</summary>
    public partial class FormLogin : BaseForm
    {
        private const string USERNAME = "admin";
        private const string PASSWORD = "sibro2024";
        private const int BATAS_PERCOBAAN = 3;

        private int _gagal;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == USERNAME && txtPassword.Text == PASSWORD)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            _gagal++;
            if (_gagal >= BATAS_PERCOBAAN)
            {
                MessageBox.Show(this, "Anda sudah 3 kali salah memasukkan akun. Aplikasi akan ditutup.",
                    "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            lblInfo.Text = string.Format("Username atau password salah. Sisa percobaan: {0}", BATAS_PERCOBAAN - _gagal);
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void chkTampilkan_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkTampilkan.Checked;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
