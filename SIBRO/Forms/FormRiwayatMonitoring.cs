using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;
using SIBRO.Services;

namespace SIBRO.Forms
{
    /// <summary>Riwayat monitoring dengan filter, ringkasan, dan ekspor CSV.</summary>
    public partial class FormRiwayatMonitoring : BaseForm
    {
        private readonly MonitoringRepository _repo = new MonitoringRepository();
        private readonly LaporanService _laporan = new LaporanService();
        private List<Monitoring> _data = new List<Monitoring>();

        public FormRiwayatMonitoring()
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

            _data = _repo.GetMonitoringFilter(IdKandangTerpilih(cmbKandang), dtpDari.Value, dtpSampai.Value);
            GridHelper.Tampilkan(dgvRiwayat, _data,
                "IdMonitoring|ID", "NamaKandang|Kandang", "TanggalInput|Tanggal|dd/MM/yyyy", "WaktuInput|Waktu|hh\\:mm",
                "Suhu|Suhu (°C)|0.0", "Kelembaban|Kelembaban (%)|0.0", "BeratRata2|Berat (g)|0.0",
                "KondisiUmum|Kondisi", "Catatan|Catatan");
            dgvRiwayat.Columns["IdMonitoring"].FillWeight = 35;

            lblTotal.Text = "Total Record: " + _data.Count;
            lblRataSuhu.Text = _data.Count == 0 ? "Rata-rata Suhu: -" : string.Format("Rata-rata Suhu: {0:0.0} °C", _data.Average(m => m.Suhu));
            lblRataKelembaban.Text = _data.Count == 0 ? "Rata-rata Kelembaban: -" : string.Format("Rata-rata Kelembaban: {0:0.0} %", _data.Average(m => m.Kelembaban));
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            JalankanAman(TerapkanFilter);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            JalankanAman(ResetFilter);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_data.Count == 0)
            {
                Peringatan("Tidak ada data untuk diekspor.");
                return;
            }

            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(folder, "Riwayat_Monitoring_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv");

            if (_laporan.ExportLaporanCSV(BuatTabelEkspor(), path))
            {
                Info("File berhasil disimpan:\n" + path);
            }
            else
            {
                Peringatan("File gagal disimpan. Pastikan folder Documents bisa ditulis.");
            }
        }

        private DataTable BuatTabelEkspor()
        {
            DataTable t = new DataTable();
            t.Columns.Add("ID", typeof(int));
            t.Columns.Add("Kandang", typeof(string));
            t.Columns.Add("Tanggal", typeof(string));
            t.Columns.Add("Waktu", typeof(string));
            t.Columns.Add("Suhu", typeof(double));
            t.Columns.Add("Kelembaban", typeof(double));
            t.Columns.Add("Berat", typeof(double));
            t.Columns.Add("Kondisi", typeof(string));
            t.Columns.Add("Catatan", typeof(string));

            foreach (Monitoring m in _data)
            {
                t.Rows.Add(m.IdMonitoring, m.NamaKandang, m.TanggalInput.ToString("dd/MM/yyyy"), m.WaktuInput.ToString(@"hh\:mm"),
                    m.Suhu, m.Kelembaban, m.BeratRata2, m.KondisiUmum, m.Catatan);
            }
            return t;
        }

        private void dgvRiwayat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridHelper.WarnaiBarisMonitoring(dgvRiwayat, e);
        }

        /// <summary>Tidak ada baris terpilih otomatis, agar warna kondisi tetap terlihat.</summary>
        private void dgvRiwayat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRiwayat.ClearSelection();
        }
    }
}
