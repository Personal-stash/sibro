using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;
using SIBRO.Services;

namespace SIBRO.Forms
{
    /// <summary>Analisis kemungkinan penyakit dari data monitoring terbaru kandang.</summary>
    public partial class FormDeteksiPenyakit : BaseForm
    {
        private static readonly Color WARNA_AMAN = Color.FromArgb(198, 239, 206);
        private static readonly Color WARNA_WASPADA = Color.FromArgb(255, 235, 156);
        private static readonly Color WARNA_BAHAYA = Color.FromArgb(255, 199, 206);
        private static readonly Color WARNA_NETRAL = Color.White;
        private const double BATAS_KRITIS = 70;

        private readonly MonitoringRepository _monitoringRepo = new MonitoringRepository();
        private readonly PenyakitRepository _penyakitRepo = new PenyakitRepository();

        // Tipe variabelnya interface: mesin deteksi bisa diganti tanpa mengubah form ini.
        private readonly IDeteksi _mesin = new RuleEngine();

        private Monitoring _dataTerbaru;
        private List<HasilDeteksi> _hasil = new List<HasilDeteksi>();
        private bool _sedangMemuat;

        public FormDeteksiPenyakit()
        {
            InitializeComponent();
        }

        protected override void MuatData()
        {
            _sedangMemuat = true;
            IsiComboKandang(cmbKandang, false);
            _sedangMemuat = false;
            TampilkanDataTerbaru();
        }

        private void cmbKandang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_sedangMemuat) JalankanAman(TampilkanDataTerbaru);
        }

        private void TampilkanDataTerbaru()
        {
            BersihkanHasil();
            int idKandang = IdKandangTerpilih(cmbKandang);
            _dataTerbaru = idKandang == 0 ? null : _monitoringRepo.GetMonitoringTerbaru(idKandang);

            if (_dataTerbaru == null)
            {
                lblSuhu.Text = "Suhu: -";
                lblKelembaban.Text = "Kelembaban: -";
                lblBerat.Text = "Berat: -";
                lblKondisi.Text = "Kondisi: -";
                lblTanggal.Text = "Tanggal Input: -";
                lblPesan.Text = "Kandang ini belum memiliki data monitoring.";
                btnAnalisis.Enabled = false;
                return;
            }

            lblSuhu.Text = string.Format("Suhu: {0:0.0} °C", _dataTerbaru.Suhu);
            lblKelembaban.Text = string.Format("Kelembaban: {0:0.0} %", _dataTerbaru.Kelembaban);
            lblBerat.Text = string.Format("Berat: {0:0.0} g", _dataTerbaru.BeratRata2);
            lblKondisi.Text = "Kondisi: " + _dataTerbaru.KondisiUmum;
            lblTanggal.Text = string.Format("Tanggal Input: {0:dd/MM/yyyy} {1:hh\\:mm}", _dataTerbaru.TanggalInput, _dataTerbaru.WaktuInput);
            btnAnalisis.Enabled = true;
        }

        private void BersihkanHasil()
        {
            _hasil = new List<HasilDeteksi>();
            pnlHasil.BackColor = WARNA_NETRAL;
            lblPesan.Text = "Tekan ANALISIS SEKARANG untuk memeriksa kandang.";
            dgvHasil.DataSource = null;
            dgvHasil.Visible = false;
            rtbDetail.Clear();
            btnSimpan.Enabled = false;
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            if (_dataTerbaru == null) return;

            JalankanAman(() =>
            {
                _hasil = _mesin.Analisis(_dataTerbaru);

                if (_hasil.Count == 0)
                {
                    pnlHasil.BackColor = WARNA_AMAN;
                    lblPesan.Text = "Kondisi Normal: tidak ada penyakit yang terdeteksi.";
                    dgvHasil.Visible = false;
                    rtbDetail.Clear();
                    btnSimpan.Enabled = false;
                    return;
                }

                dgvHasil.Visible = true;
                GridHelper.Tampilkan(dgvHasil, _hasil,
                    "NamaPenyakit|Nama Penyakit", "PersentaseKemungkinan|Kemungkinan (%)",
                    "TingkatBahaya|Tingkat Bahaya", "StatusPenanganan|Status");

                bool kritis = _hasil.Max(h => h.PersentaseKemungkinan) >= BATAS_KRITIS;
                pnlHasil.BackColor = kritis ? WARNA_BAHAYA : WARNA_WASPADA;
                lblPesan.Text = (kritis ? "KRITIS: " : "WASPADA: ") + _hasil.Count + " kemungkinan penyakit terdeteksi.";

                TampilkanDetail(_hasil[0].NamaPenyakit);
                btnSimpan.Enabled = true;
            });
        }

        /// <summary>Menampilkan gejala dan penanganan pada RichTextBox.</summary>
        private void TampilkanDetail(string namaPenyakit)
        {
            Penyakit p = _penyakitRepo.GetPenyakitByNama(namaPenyakit);
            if (p == null) return;

            rtbDetail.Text = p.NamaPenyakit + " (bahaya: " + p.TingkatBahaya + ")\n\n" +
                             p.Deskripsi + "\n\n" +
                             "GEJALA\n" + p.Gejala + "\n\n" +
                             "PENANGANAN\n" + _mesin.GetRekomendasiPenanganan(namaPenyakit) + "\n\n" +
                             "Catatan: ini perkiraan dari data lingkungan kandang, bukan diagnosis. Konfirmasikan ke dokter hewan.";
        }

        private void dgvHasil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            HasilDeteksi h = dgvHasil.Rows[e.RowIndex].DataBoundItem as HasilDeteksi;
            if (h != null) JalankanAman(() => TampilkanDetail(h.NamaPenyakit));
        }

        /// <summary>Menggambar progress bar di dalam sel kolom Kemungkinan.</summary>
        private void dgvHasil_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvHasil.Columns[e.ColumnIndex].DataPropertyName != "PersentaseKemungkinan") return;

            double persen = Convert.ToDouble(e.Value);
            e.PaintBackground(e.CellBounds, true);

            Rectangle area = Rectangle.Inflate(e.CellBounds, -4, -4);
            using (SolidBrush latar = new SolidBrush(Color.Gainsboro))
            using (SolidBrush isi = new SolidBrush(persen >= BATAS_KRITIS ? Color.IndianRed : Color.Goldenrod))
            {
                e.Graphics.FillRectangle(latar, area);
                e.Graphics.FillRectangle(isi, area.X, area.Y, (int)(area.Width * persen / 100), area.Height);
            }
            TextRenderer.DrawText(e.Graphics, persen.ToString("0") + " %", dgvHasil.Font, area, Color.Black,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            e.Handled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            JalankanAman(() =>
            {
                foreach (HasilDeteksi h in _hasil)
                {
                    _penyakitRepo.SaveHasilDeteksi(h);
                }
                btnSimpan.Enabled = false;
                Info(_hasil.Count + " hasil deteksi berhasil disimpan.");
            });
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            using (FormRiwayatDeteksi riwayat = new FormRiwayatDeteksi())
            {
                riwayat.ShowDialog();
            }
        }
    }
}
