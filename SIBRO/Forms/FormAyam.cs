using System;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>Kelola data ayam per kandang.</summary>
    public partial class FormAyam : BaseForm
    {
        private readonly AyamRepository _repo = new AyamRepository();
        private int _idTerpilih;

        public FormAyam()
        {
            InitializeComponent();
            dtpTanggal.MaxDate = DateTime.Today;
        }

        protected override void MuatData()
        {
            IsiComboKandang(cmbKandang, false);
            GridHelper.Tampilkan(dgvAyam, _repo.GetAllAyam(),
                "IdAyam|ID", "NamaKandang|Kandang", "JumlahAyam|Jumlah (ekor)", "UmurHari|Umur Saat Masuk (hari)",
                "UmurSekarang|Umur Sekarang (hari)", "JenisAyam|Jenis Ayam", "TanggalMasuk|Tanggal Masuk|dd/MM/yyyy");
            dgvAyam.Columns["IdAyam"].FillWeight = 35;
            BersihkanInput();
        }

        private void BersihkanInput()
        {
            _idTerpilih = 0;
            txtJumlah.Clear();
            txtUmur.Clear();
            txtJenis.Clear();
            dtpTanggal.Value = DateTime.Today;
            dgvAyam.ClearSelection();
        }

        /// <summary>Membaca dan memvalidasi input, termasuk batas kapasitas kandang.</summary>
        private Ayam BacaInput()
        {
            int jumlah, umur;
            if (!int.TryParse(txtJumlah.Text.Trim(), out jumlah))
            {
                Peringatan("Jumlah ayam wajib diisi dengan angka bulat.");
                txtJumlah.Focus();
                return null;
            }
            if (!int.TryParse(txtUmur.Text.Trim(), out umur))
            {
                Peringatan("Umur wajib diisi dengan angka bulat.");
                txtUmur.Focus();
                return null;
            }

            Ayam a = new Ayam(_idTerpilih, IdKandangTerpilih(cmbKandang), jumlah, umur, txtJenis.Text.Trim(), dtpTanggal.Value.Date);
            string kesalahan = a.Validasi();
            if (kesalahan != string.Empty)
            {
                Peringatan(kesalahan);
                return null;
            }

            Kandang kandang = (Kandang)cmbKandang.SelectedItem;
            int totalLain = _repo.GetTotalAyamByKandang(a.IdKandang, a.IdAyam);
            if (totalLain + a.JumlahAyam > kandang.Kapasitas)
            {
                Peringatan(string.Format("Melebihi kapasitas {0}. Kapasitas {1} ekor, sudah terisi {2} ekor.",
                    kandang.NamaKandang, kandang.Kapasitas, totalLain));
                return null;
            }
            return a;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            JalankanAman(() =>
            {
                Ayam a = BacaInput();
                if (a == null) return;

                Kandang kandang = (Kandang)cmbKandang.SelectedItem;
                if (kandang.Status != Kandang.STATUS_AKTIF)
                {
                    Peringatan("Kandang berstatus Nonaktif, ayam baru tidak bisa ditambahkan.");
                    return;
                }

                _repo.InsertAyam(a);
                MuatData();
                Info("Data ayam berhasil ditambahkan.");
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_idTerpilih == 0)
            {
                Peringatan("Pilih dulu data ayam pada tabel.");
                return;
            }

            JalankanAman(() =>
            {
                Ayam a = BacaInput();
                if (a == null) return;

                _repo.UpdateAyam(a);
                MuatData();
                Info("Data ayam berhasil diperbarui.");
            });
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_idTerpilih == 0)
            {
                Peringatan("Pilih dulu data ayam pada tabel.");
                return;
            }
            if (!Konfirmasi("Yakin ingin menghapus data ayam ini?")) return;

            JalankanAman(() =>
            {
                _repo.DeleteAyam(_idTerpilih);
                MuatData();
                Info("Data ayam berhasil dihapus.");
            });
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            JalankanAman(MuatData);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BersihkanInput();
        }

        private void dgvAyam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Ayam a = dgvAyam.Rows[e.RowIndex].DataBoundItem as Ayam;
            if (a == null) return;

            _idTerpilih = a.IdAyam;
            cmbKandang.SelectedValue = a.IdKandang;
            txtJumlah.Text = a.JumlahAyam.ToString();
            txtUmur.Text = a.UmurHari.ToString();
            txtJenis.Text = a.JenisAyam;
            dtpTanggal.Value = a.TanggalMasuk;
        }
    }
}
