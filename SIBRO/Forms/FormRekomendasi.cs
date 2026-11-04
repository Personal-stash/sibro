using System;
using System.Drawing;
using System.Windows.Forms;
using SIBRO.Data;
using SIBRO.Models;
using SIBRO.Services;

namespace SIBRO.Forms
{
    /// <summary>Membandingkan kondisi aktual kandang dengan suhu dan kelembaban ideal menurut umur ayam.</summary>
    public partial class FormRekomendasi : BaseForm
    {
        private readonly MonitoringRepository _monitoringRepo = new MonitoringRepository();
        private readonly AyamRepository _ayamRepo = new AyamRepository();
        private readonly RekomendasiEngine _engine = new RekomendasiEngine();
        private bool _sedangMemuat;

        public FormRekomendasi()
        {
            InitializeComponent();
        }

        protected override void MuatData()
        {
            _sedangMemuat = true;
            IsiComboKandang(cmbKandang, false);
            _sedangMemuat = false;
            TampilkanRekomendasi();
        }

        private void cmbKandang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_sedangMemuat) JalankanAman(TampilkanRekomendasi);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            JalankanAman(TampilkanRekomendasi);
        }

        /// <summary>Refresh otomatis setiap 30 detik. Error tidak memunculkan pesan agar tidak berulang-ulang.</summary>
        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                TampilkanRekomendasi();
            }
            catch (Exception)
            {
                lblUpdate.Text = "Gagal memperbarui data otomatis pada " + DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void TampilkanRekomendasi()
        {
            lblUpdate.Text = "Diperbarui: " + DateTime.Now.ToString("HH:mm:ss");
            int idKandang = IdKandangTerpilih(cmbKandang);
            if (idKandang == 0)
            {
                KosongkanTampilan("Belum ada data kandang.");
                return;
            }

            Ayam ayam = _ayamRepo.GetAyamTerbaruByKandang(idKandang);
            Monitoring monitoring = _monitoringRepo.GetMonitoringTerbaru(idKandang);

            lblUmur.Text = ayam == null ? "Umur Ayam: -" : "Umur Ayam: " + ayam.UmurSekarang + " hari";
            lblSuhuAktual.Text = monitoring == null ? "Suhu Aktual: -" : string.Format("Suhu Aktual: {0:0.0} °C", monitoring.Suhu);
            lblKelembabanAktual.Text = monitoring == null ? "Kelembaban Aktual: -" : string.Format("Kelembaban Aktual: {0:0.0} %", monitoring.Kelembaban);

            if (ayam == null)
            {
                KosongkanTampilan("Kandang ini belum memiliki data ayam, sehingga umur belum diketahui.");
                return;
            }

            RekomendasiSuhu rek = _engine.GetRekomendasiByUmur(ayam.UmurSekarang);
            if (rek == null)
            {
                KosongkanTampilan("Data rekomendasi belum ada. Jalankan dulu file Database/sibro_db.sql.");
                return;
            }

            lblSuhuIdeal.Text = string.Format("{0:0.#} - {1:0.#} °C", rek.SuhuIdealMin, rek.SuhuIdealMax);
            lblKelembabanIdeal.Text = string.Format("{0:0.#} - {1:0.#} %", rek.KelembabanIdealMin, rek.KelembabanIdealMax);

            if (monitoring == null)
            {
                lblStatusSuhu.Text = "Status Suhu: belum ada data";
                lblStatusSuhu.ForeColor = Color.DimGray;
                lblStatusKelembaban.Text = "Status Kelembaban: belum ada data";
                pgbSuhu.Value = 0;
                lblIndikator.Text = "Kesesuaian suhu: -";
                rtbPesan.Text = "Belum ada data monitoring. Input data di menu Monitoring agar kondisi bisa dibandingkan.";
                return;
            }

            string status = rek.CekStatusSuhu(monitoring.Suhu);
            lblStatusSuhu.Text = "Status Suhu: " + status;
            lblStatusSuhu.ForeColor = WarnaStatus(status);
            lblStatusKelembaban.Text = "Status Kelembaban: " + rek.CekStatusKelembaban(monitoring.Kelembaban);

            int indikator = _engine.HitungIndikatorSuhu(monitoring.Suhu, rek);
            pgbSuhu.Value = indikator;
            lblIndikator.Text = "Kesesuaian suhu: " + indikator + " %";
            rtbPesan.Text = _engine.BuatPesan(monitoring.Suhu, monitoring.Kelembaban, ayam.UmurSekarang, rek);
        }

        private static Color WarnaStatus(string status)
        {
            if (status == RekomendasiSuhu.STATUS_PANAS) return Color.Firebrick;
            if (status == RekomendasiSuhu.STATUS_DINGIN) return Color.RoyalBlue;
            return Color.ForestGreen;
        }

        private void KosongkanTampilan(string pesan)
        {
            lblSuhuIdeal.Text = "- °C";
            lblKelembabanIdeal.Text = "- %";
            lblStatusSuhu.Text = "Status Suhu: -";
            lblStatusSuhu.ForeColor = Color.DimGray;
            lblStatusKelembaban.Text = "Status Kelembaban: -";
            lblIndikator.Text = "Kesesuaian suhu: -";
            pgbSuhu.Value = 0;
            rtbPesan.Text = pesan;
        }
    }
}
