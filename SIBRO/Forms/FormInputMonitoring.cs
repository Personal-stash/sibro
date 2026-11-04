using System;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>Input kondisi harian kandang dan riwayat singkatnya.</summary>
    public partial class FormInputMonitoring : BaseForm
    {
        private readonly MonitoringRepository _repo = new MonitoringRepository();
        private int _idTerpilih;
        private TimeSpan _waktuTerpilih;

        public FormInputMonitoring()
        {
            InitializeComponent();
            dtpTanggal.MaxDate = DateTime.Today;
            lblWaktu.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        protected override void MuatData()
        {
            IsiComboKandang(cmbKandang, false);
            GridHelper.Tampilkan(dgvRiwayat, _repo.GetAllMonitoring(),
                "IdMonitoring|ID", "NamaKandang|Kandang", "TanggalInput|Tanggal|dd/MM/yyyy", "WaktuInput|Waktu|hh\\:mm",
                "Suhu|Suhu (°C)|0.0", "Kelembaban|Kelembaban (%)|0.0", "BeratRata2|Berat (g)|0.0",
                "KondisiUmum|Kondisi", "Catatan|Catatan");
            dgvRiwayat.Columns["IdMonitoring"].FillWeight = 35;
            BersihkanInput();
        }

        private void BersihkanInput()
        {
            _idTerpilih = 0;
            nudSuhu.Value = 30;
            nudKelembaban.Value = 60;
            nudBerat.Value = 0;
            cmbKondisi.SelectedItem = Monitoring.KONDISI_NORMAL;
            txtCatatan.Clear();
            dtpTanggal.Value = DateTime.Today;
            dgvRiwayat.ClearSelection();
        }

        /// <summary>Membaca dan memvalidasi input. Data baru memakai jam saat ini; saat edit, jam lama dipertahankan.</summary>
        private Monitoring BacaInput()
        {
            // NumericUpDown selalu punya nilai, kecuali pengguna mengosongkan teksnya secara manual.
            if (string.IsNullOrWhiteSpace(nudSuhu.Text) || string.IsNullOrWhiteSpace(nudKelembaban.Text))
            {
                Peringatan("Suhu dan kelembaban wajib diisi.");
                return null;
            }

            TimeSpan waktu = _idTerpilih == 0 ? DateTime.Now.TimeOfDay : _waktuTerpilih;
            Monitoring m = new Monitoring(IdKandangTerpilih(cmbKandang), (double)nudSuhu.Value, (double)nudKelembaban.Value,
                (double)nudBerat.Value, Convert.ToString(cmbKondisi.SelectedItem), txtCatatan.Text.Trim(), dtpTanggal.Value.Date, waktu);
            m.IdMonitoring = _idTerpilih;

            string kesalahan = m.Validasi();
            if (kesalahan != string.Empty)
            {
                Peringatan(kesalahan);
                return null;
            }
            return m;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Monitoring m = BacaInput();
            if (m == null) return;

            Kandang kandang = (Kandang)cmbKandang.SelectedItem;
            if (kandang.Status != Kandang.STATUS_AKTIF)
            {
                Peringatan("Kandang berstatus Nonaktif, data monitoring baru tidak bisa disimpan.");
                return;
            }

            // Simpan selalu membuat data baru; perubahan data lama lewat tombol Edit.
            m.IdMonitoring = 0;
            m.WaktuInput = DateTime.Now.TimeOfDay;

            JalankanAman(() =>
            {
                _repo.InsertMonitoring(m);
                MuatData();
                Info("Data monitoring berhasil disimpan.");
            });
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_idTerpilih == 0)
            {
                Peringatan("Pilih dulu data monitoring pada tabel.");
                return;
            }

            Monitoring m = BacaInput();
            if (m == null) return;

            JalankanAman(() =>
            {
                _repo.UpdateMonitoring(m);
                MuatData();
                Info("Data monitoring berhasil diperbarui.");
            });
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (_idTerpilih == 0)
            {
                Peringatan("Pilih dulu data monitoring pada tabel.");
                return;
            }
            if (!Konfirmasi("Yakin ingin menghapus data monitoring ini?")) return;

            JalankanAman(() =>
            {
                _repo.DeleteMonitoring(_idTerpilih);
                MuatData();
                Info("Data monitoring berhasil dihapus.");
            });
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            BersihkanInput();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            JalankanAman(MuatData);
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            using (FormRiwayatMonitoring riwayat = new FormRiwayatMonitoring())
            {
                riwayat.ShowDialog();
            }
        }

        private void tmrJam_Tick(object sender, EventArgs e)
        {
            lblWaktu.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dgvRiwayat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Monitoring m = dgvRiwayat.Rows[e.RowIndex].DataBoundItem as Monitoring;
            if (m == null) return;

            _idTerpilih = m.IdMonitoring;
            _waktuTerpilih = m.WaktuInput;
            cmbKandang.SelectedValue = m.IdKandang;
            SetNilai(nudSuhu, m.Suhu);
            SetNilai(nudKelembaban, m.Kelembaban);
            SetNilai(nudBerat, m.BeratRata2);
            cmbKondisi.SelectedItem = m.KondisiUmum;
            txtCatatan.Text = m.Catatan;
            dtpTanggal.Value = m.TanggalInput;
        }

        private void dgvRiwayat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridHelper.WarnaiBarisMonitoring(dgvRiwayat, e);
        }
    }
}
