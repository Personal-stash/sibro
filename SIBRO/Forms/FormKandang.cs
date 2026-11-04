using System;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>Kelola data kandang: tambah, edit, hapus.</summary>
    public partial class FormKandang : BaseForm
    {
        private readonly KandangRepository _repo = new KandangRepository();
        private readonly AyamRepository _ayamRepo = new AyamRepository();
        private int _idTerpilih;

        public FormKandang()
        {
            InitializeComponent();
        }

        protected override void MuatData()
        {
            GridHelper.Tampilkan(dgvKandang, _repo.GetAllKandang(),
                "IdKandang|ID", "NamaKandang|Nama Kandang", "Kapasitas|Kapasitas", "Lokasi|Lokasi",
                "Status|Status", "CreatedAt|Dibuat|dd/MM/yyyy HH:mm");
            dgvKandang.Columns["IdKandang"].FillWeight = 35;
            BersihkanInput();
        }

        private void BersihkanInput()
        {
            _idTerpilih = 0;
            txtNama.Clear();
            txtKapasitas.Clear();
            txtLokasi.Clear();
            cmbStatus.SelectedItem = Kandang.STATUS_AKTIF;
            dgvKandang.ClearSelection();
            txtNama.Focus();
        }

        /// <summary>Membaca dan memvalidasi input. Mengembalikan null jika ada yang salah.</summary>
        private Kandang BacaInput()
        {
            int kapasitas;
            if (!int.TryParse(txtKapasitas.Text.Trim(), out kapasitas))
            {
                Peringatan("Kapasitas wajib diisi dengan angka bulat.");
                txtKapasitas.Focus();
                return null;
            }

            Kandang k = new Kandang(_idTerpilih, txtNama.Text.Trim(), kapasitas, txtLokasi.Text.Trim(),
                Convert.ToString(cmbStatus.SelectedItem));

            string kesalahan = k.Validasi();
            if (kesalahan != string.Empty)
            {
                Peringatan(kesalahan);
                return null;
            }
            return k;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Kandang k = BacaInput();
            if (k == null) return;

            JalankanAman(() =>
            {
                _repo.InsertKandang(k);
                MuatData();
                Info("Data kandang berhasil ditambahkan.");
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_idTerpilih == 0)
            {
                Peringatan("Pilih dulu data kandang pada tabel.");
                return;
            }

            Kandang k = BacaInput();
            if (k == null) return;

            JalankanAman(() =>
            {
                int totalAyam = _ayamRepo.GetTotalAyamByKandang(k.IdKandang, 0);
                if (k.Kapasitas < totalAyam)
                {
                    Peringatan("Kapasitas tidak boleh lebih kecil dari jumlah ayam saat ini (" + totalAyam + " ekor).");
                    return;
                }
                _repo.UpdateKandang(k);
                MuatData();
                Info("Data kandang berhasil diperbarui.");
            });
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_idTerpilih == 0)
            {
                Peringatan("Pilih dulu data kandang pada tabel.");
                return;
            }
            if (!Konfirmasi("Yakin ingin menghapus kandang \"" + txtNama.Text + "\"?")) return;

            JalankanAman(() =>
            {
                _repo.DeleteKandang(_idTerpilih);
                MuatData();
                Info("Data kandang berhasil dihapus.");
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

        private void dgvKandang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Kandang k = dgvKandang.Rows[e.RowIndex].DataBoundItem as Kandang;
            if (k == null) return;

            _idTerpilih = k.IdKandang;
            txtNama.Text = k.NamaKandang;
            txtKapasitas.Text = k.Kapasitas.ToString();
            txtLokasi.Text = k.Lokasi;
            cmbStatus.SelectedItem = k.Status;
        }
    }
}
