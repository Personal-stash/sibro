using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using SIBRO.Services;

namespace SIBRO.Forms
{
    /// <summary>Laporan harian, mingguan, dan bulanan beserta ekspor dan cetak.</summary>
    public partial class FormLaporan : BaseForm
    {
        private readonly LaporanService _service = new LaporanService();

        private DataTable _data;
        private int _idKandangLaporan;
        private DateTime _dari;
        private DateTime _sampai;

        private string[] _barisCetak;
        private int _barisBerikutnya;

        public FormLaporan()
        {
            InitializeComponent();
        }

        protected override void MuatData()
        {
            IsiComboKandang(cmbKandang, false);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int idKandang = IdKandangTerpilih(cmbKandang);
            if (idKandang == 0)
            {
                Peringatan("Pilih kandang terlebih dahulu.");
                return;
            }

            JalankanAman(() =>
            {
                DateTime tanggal = dtpTanggal.Value.Date;
                if (rbHarian.Checked)
                {
                    _dari = tanggal;
                    _sampai = tanggal;
                    _data = _service.GetDataLaporanHarian(idKandang, tanggal);
                }
                else if (rbMingguan.Checked)
                {
                    _dari = tanggal;
                    _sampai = tanggal.AddDays(6);
                    _data = _service.GetDataLaporanMingguan(idKandang, tanggal);
                }
                else
                {
                    _dari = new DateTime(tanggal.Year, tanggal.Month, 1);
                    _sampai = _dari.AddMonths(1).AddDays(-1);
                    _data = _service.GetDataLaporanBulanan(idKandang, tanggal);
                }
                _idKandangLaporan = idKandang;

                dgvLaporan.DataSource = _data;
                TampilkanStatistik();
            });
        }

        private void TampilkanStatistik()
        {
            Dictionary<string, object> statistik = LaporanService.HitungStatistikPeriode(_data);
            lblPeriode.Text = string.Format("Periode: {0:dd/MM/yyyy} s.d. {1:dd/MM/yyyy} ({2} data)", _dari, _sampai, _data.Rows.Count);

            bool adaData = _data.Rows.Count > 0;
            lblRataSuhu.Text = adaData ? string.Format("Rata-rata Suhu: {0:0.0} °C", statistik["rata2_suhu"]) : "Rata-rata Suhu: -";
            lblRataKelembaban.Text = adaData ? string.Format("Rata-rata Kelembaban: {0:0.0} %", statistik["rata2_kelembaban"]) : "Rata-rata Kelembaban: -";
            lblKondisiDominan.Text = "Kondisi Dominan: " + statistik["kondisi_dominan"];
        }

        private bool LaporanSudahDibuat()
        {
            if (_data != null) return true;
            Peringatan("Klik Generate Laporan terlebih dahulu.");
            return false;
        }

        private string BuatPathDokumen(string ekstensi)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(folder, "Laporan_SIBRO_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ekstensi);
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (!LaporanSudahDibuat()) return;

            string path = BuatPathDokumen(".csv");
            if (_service.ExportLaporanCSV(_data, path)) Info("File berhasil disimpan:\n" + path);
            else Peringatan("File CSV gagal disimpan.");
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            if (!LaporanSudahDibuat()) return;

            string path = BuatPathDokumen(".txt");
            if (_service.ExportLaporanTXT(_idKandangLaporan, _dari, _sampai, path)) Info("File berhasil disimpan:\n" + path);
            else Peringatan("File TXT gagal disimpan.");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!LaporanSudahDibuat()) return;

            JalankanAman(() =>
            {
                _barisCetak = _service.BuatTeksLaporan(_idKandangLaporan, _dari, _sampai)
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                using (PrintDocument dokumen = new PrintDocument())
                using (PrintPreviewDialog pratinjau = new PrintPreviewDialog())
                {
                    dokumen.DocumentName = "Laporan SI BRO";
                    dokumen.BeginPrint += (s, ev) => _barisBerikutnya = 0;
                    dokumen.PrintPage += CetakHalaman;
                    pratinjau.Document = dokumen;
                    pratinjau.Width = 900;
                    pratinjau.Height = 650;
                    pratinjau.ShowDialog();
                }
            });
        }

        /// <summary>Mencetak baris demi baris; jika halaman penuh, lanjut ke halaman berikutnya.</summary>
        private void CetakHalaman(object sender, PrintPageEventArgs e)
        {
            using (Font huruf = new Font("Consolas", 9F))
            {
                float y = e.MarginBounds.Top;
                float tinggiBaris = huruf.GetHeight(e.Graphics);

                while (_barisBerikutnya < _barisCetak.Length && y + tinggiBaris <= e.MarginBounds.Bottom)
                {
                    e.Graphics.DrawString(_barisCetak[_barisBerikutnya], huruf, Brushes.Black, e.MarginBounds.Left, y);
                    y += tinggiBaris;
                    _barisBerikutnya++;
                }
            }
            e.HasMorePages = _barisBerikutnya < _barisCetak.Length;
        }
    }
}
