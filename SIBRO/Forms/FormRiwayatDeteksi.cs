using System;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>Riwayat deteksi penyakit dan pembaruan status penanganan.</summary>
    public partial class FormRiwayatDeteksi : BaseForm
    {
        private readonly PenyakitRepository _repo = new PenyakitRepository();

        public FormRiwayatDeteksi()
        {
            InitializeComponent();
        }

        protected override void MuatData()
        {
            IsiComboKandang(cmbKandang, true);
            ResetFilter();
        }

        /// <summary>Filter awal: semua kandang, 30 hari terakhir.</summary>
        private void ResetFilter()
        {
            cmbKandang.SelectedIndex = 0;
            dtpSampai.Value = DateTime.Today;
            dtpDari.Value = DateTime.Today.AddDays(-30);
            TerapkanFilter();
        }

        private void TerapkanFilter()
        {
            if (dtpDari.Value.Date > dtpSampai.Value.Date)
            {
                Peringatan("Tanggal awal tidak boleh setelah tanggal akhir.");
                return;
            }

            GridHelper.Tampilkan(dgvRiwayat, _repo.GetRiwayatDeteksiFilter(IdKandangTerpilih(cmbKandang), dtpDari.Value, dtpSampai.Value),
                "IdDeteksi|ID", "NamaKandang|Kandang", "NamaPenyakit|Penyakit", "PersentaseKemungkinan|Kemungkinan (%)|0",
                "TingkatBahaya|Tingkat Bahaya", "TanggalDeteksi|Tanggal Deteksi|dd/MM/yyyy HH:mm", "StatusPenanganan|Status Penanganan");
            dgvRiwayat.Columns["IdDeteksi"].FillWeight = 35;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            JalankanAman(TerapkanFilter);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            JalankanAman(ResetFilter);
        }

        private void dgvRiwayat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            HasilDeteksi h = dgvRiwayat.Rows[e.RowIndex].DataBoundItem as HasilDeteksi;
            if (h != null) cmbStatus.SelectedItem = h.StatusPenanganan;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            HasilDeteksi h = dgvRiwayat.CurrentRow == null ? null : dgvRiwayat.CurrentRow.DataBoundItem as HasilDeteksi;
            if (h == null)
            {
                Peringatan("Pilih dulu data pada tabel.");
                return;
            }
            if (cmbStatus.SelectedItem == null)
            {
                Peringatan("Pilih status penanganan.");
                return;
            }

            JalankanAman(() =>
            {
                _repo.UpdateStatusPenanganan(h.IdDeteksi, Convert.ToString(cmbStatus.SelectedItem));
                TerapkanFilter();
                Info("Status penanganan berhasil diperbarui.");
            });
        }
    }
}
