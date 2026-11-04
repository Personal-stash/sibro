using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SIBRO.Data;
using SIBRO.Models;

namespace SIBRO.Forms
{
    /// <summary>Halaman utama: statistik, grafik, dan navigasi ke semua fitur.</summary>
    public partial class FormDashboard : BaseForm
    {
        private static readonly Color WARNA_NAV = Color.FromArgb(27, 67, 50);
        private static readonly Color WARNA_NAV_AKTIF = Color.FromArgb(64, 145, 108);

        private readonly DashboardRepository _repo = new DashboardRepository();
        private readonly MonitoringRepository _monitoringRepo = new MonitoringRepository();
        private BaseForm _formAktif;

        public FormDashboard()
        {
            InitializeComponent();
            SiapkanGrafik();
        }

        protected override void MuatData()
        {
            TandaiNavigasi(btnNavDashboard);
            MuatDashboard();
        }

        // ------------------------------ Data dashboard ------------------------------

        private void MuatDashboard()
        {
            lblNilaiKandang.Text = _repo.GetTotalKandangAktif().ToString("N0");
            lblNilaiAyam.Text = _repo.GetTotalAyamTerpantau().ToString("N0");
            lblNilaiKritis.Text = _repo.GetKandangKritisHariIni().ToString("N0");
            lblNilaiDeteksi.Text = _repo.GetDeteksiBulanIni().ToString("N0");

            IsiGrafikSuhu(_repo.GetTrenSuhu7Hari());
            IsiGrafikKondisi(_repo.GetPerbandinganKondisi());

            GridHelper.Tampilkan(dgvTerbaru, _monitoringRepo.GetMonitoringTerbaruSemua(5),
                "NamaKandang|Kandang", "TanggalInput|Tanggal|dd/MM/yyyy", "WaktuInput|Waktu|hh\\:mm",
                "Suhu|Suhu (°C)|0.0", "Kelembaban|Kelembaban (%)|0.0", "BeratRata2|Berat (g)|0.0", "KondisiUmum|Kondisi");

            lblUpdate.Text = "Diperbarui: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void SiapkanGrafik()
        {
            // Nama "Default" sengaja dipakai karena Series otomatis merujuk ke nama tersebut.
            ChartArea areaSuhu = new ChartArea("Default");
            areaSuhu.AxisX.LabelStyle.Format = "dd/MM";
            areaSuhu.AxisX.IntervalType = DateTimeIntervalType.Days;
            areaSuhu.AxisX.Interval = 1;
            areaSuhu.AxisX.MajorGrid.LineColor = Color.Gainsboro;
            areaSuhu.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            areaSuhu.AxisY.Title = "Suhu (°C)";
            areaSuhu.AxisY.IsStartedFromZero = false;
            chartSuhu.ChartAreas.Add(areaSuhu);
            chartSuhu.Legends.Add(new Legend("Default") { Docking = Docking.Bottom });
            chartSuhu.Titles.Add("Tren Suhu 7 Hari Terakhir per Kandang");

            ChartArea areaKondisi = new ChartArea("Default");
            areaKondisi.AxisX.MajorGrid.Enabled = false;
            areaKondisi.AxisX.Interval = 1;
            areaKondisi.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            areaKondisi.AxisY.Interval = 1;
            areaKondisi.AxisY.Title = "Jumlah Kandang";
            chartKondisi.ChartAreas.Add(areaKondisi);
            chartKondisi.Titles.Add("Perbandingan Kondisi Kandang");
        }

        private void IsiGrafikSuhu(DataTable data)
        {
            chartSuhu.Series.Clear();
            foreach (DataRow baris in data.Rows)
            {
                string kandang = Convert.ToString(baris["nama_kandang"]);
                Series seri = chartSuhu.Series.FindByName(kandang);
                if (seri == null)
                {
                    seri = new Series(kandang);
                    seri.ChartType = SeriesChartType.Line;
                    seri.XValueType = ChartValueType.Date;
                    seri.BorderWidth = 2;
                    seri.MarkerStyle = MarkerStyle.Circle;
                    seri.MarkerSize = 6;
                    chartSuhu.Series.Add(seri);
                }
                seri.Points.AddXY(Convert.ToDateTime(baris["tanggal_input"]), Convert.ToDouble(baris["rata_suhu"]));
            }

            // Sumbu X selalu menampilkan 7 hari penuh, meskipun ada hari tanpa data.
            Axis sumbuX = chartSuhu.ChartAreas[0].AxisX;
            sumbuX.Minimum = DateTime.Today.AddDays(-6).ToOADate();
            sumbuX.Maximum = DateTime.Today.ToOADate();

            // Skala sumbu dihitung ulang karena grafik ini diisi ulang setiap refresh.
            chartSuhu.ChartAreas[0].RecalculateAxesScale();
        }

        private void IsiGrafikKondisi(DataTable data)
        {
            // Ketiga kondisi selalu ditampilkan, walaupun jumlahnya 0.
            Dictionary<string, int> jumlah = new Dictionary<string, int>
            {
                { Monitoring.KONDISI_NORMAL, 0 },
                { Monitoring.KONDISI_KURANG_BAIK, 0 },
                { Monitoring.KONDISI_KRITIS, 0 }
            };
            foreach (DataRow baris in data.Rows)
            {
                jumlah[Convert.ToString(baris["kondisi_umum"])] = Convert.ToInt32(baris["jumlah"]);
            }

            chartKondisi.Series.Clear();
            Series seri = new Series("Kondisi");
            seri.ChartType = SeriesChartType.Column;
            seri.IsValueShownAsLabel = true;
            seri["PointWidth"] = "0.6";
            chartKondisi.Series.Add(seri);

            TambahBatang(seri, Monitoring.KONDISI_NORMAL, jumlah, Color.SeaGreen);
            TambahBatang(seri, Monitoring.KONDISI_KURANG_BAIK, jumlah, Color.Goldenrod);
            TambahBatang(seri, Monitoring.KONDISI_KRITIS, jumlah, Color.IndianRed);

            // Batas sumbu Y mengikuti data terbesar agar batang tidak terpotong saat refresh.
            Axis sumbuY = chartKondisi.ChartAreas[0].AxisY;
            sumbuY.Minimum = 0;
            sumbuY.Maximum = jumlah.Values.Max() + 1;
        }

        private static void TambahBatang(Series seri, string kondisi, Dictionary<string, int> jumlah, Color warna)
        {
            int i = seri.Points.AddXY(kondisi, jumlah[kondisi]);
            seri.Points[i].Color = warna;
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if (!pnlDashboard.Visible) return;

            // Error tidak memunculkan pesan agar tidak muncul berulang setiap menit.
            try
            {
                MuatDashboard();
            }
            catch (Exception)
            {
                lblUpdate.Text = "Gagal memperbarui data pada " + DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void dgvTerbaru_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridHelper.WarnaiBarisMonitoring(dgvTerbaru, e);
        }

        /// <summary>Tidak ada baris terpilih otomatis, agar warna kondisi tetap terlihat.</summary>
        private void dgvTerbaru_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTerbaru.ClearSelection();
        }

        // ------------------------------ Navigasi ------------------------------

        /// <summary>Membuka form fitur di dalam area konten, menggantikan form sebelumnya.</summary>
        private void BukaForm(BaseForm form, Button tombol)
        {
            TutupFormAktif();
            pnlDashboard.Visible = false;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlKonten.Controls.Add(form);
            _formAktif = form;
            form.Show();

            TandaiNavigasi(tombol);
        }

        private void TutupFormAktif()
        {
            if (_formAktif == null) return;
            _formAktif.Close();
            _formAktif.Dispose();
            _formAktif = null;
        }

        private void TandaiNavigasi(Button aktif)
        {
            foreach (Control c in pnlNavigasi.Controls)
            {
                Button tombol = c as Button;
                if (tombol != null) tombol.BackColor = tombol == aktif ? WARNA_NAV_AKTIF : WARNA_NAV;
            }
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            TutupFormAktif();
            pnlDashboard.Visible = true;
            TandaiNavigasi(btnNavDashboard);
            JalankanAman(MuatDashboard);
        }

        private void btnNavKandang_Click(object sender, EventArgs e)
        {
            BukaForm(new FormKandang(), btnNavKandang);
        }

        private void btnNavAyam_Click(object sender, EventArgs e)
        {
            BukaForm(new FormAyam(), btnNavAyam);
        }

        private void btnNavMonitoring_Click(object sender, EventArgs e)
        {
            BukaForm(new FormInputMonitoring(), btnNavMonitoring);
        }

        private void btnNavDeteksi_Click(object sender, EventArgs e)
        {
            BukaForm(new FormDeteksiPenyakit(), btnNavDeteksi);
        }

        private void btnNavRekomendasi_Click(object sender, EventArgs e)
        {
            BukaForm(new FormRekomendasi(), btnNavRekomendasi);
        }

        private void btnNavLaporan_Click(object sender, EventArgs e)
        {
            BukaForm(new FormLaporan(), btnNavLaporan);
        }

        private void btnNavKeluar_Click(object sender, EventArgs e)
        {
            if (Konfirmasi("Yakin ingin keluar dari aplikasi?")) Close();
        }
    }
}
