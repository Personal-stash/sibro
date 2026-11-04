namespace SIBRO.Forms
{
    partial class FormRekomendasi
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblJudul = new System.Windows.Forms.Label();
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblPilih = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.lblSuhuAktual = new System.Windows.Forms.Label();
            this.lblKelembabanAktual = new System.Windows.Forms.Label();
            this.lblUmur = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlRekomendasi = new System.Windows.Forms.Panel();
            this.lblJudulSuhu = new System.Windows.Forms.Label();
            this.lblSuhuIdeal = new System.Windows.Forms.Label();
            this.lblJudulKelembaban = new System.Windows.Forms.Label();
            this.lblKelembabanIdeal = new System.Windows.Forms.Label();
            this.lblStatusSuhu = new System.Windows.Forms.Label();
            this.lblStatusKelembaban = new System.Windows.Forms.Label();
            this.lblIndikator = new System.Windows.Forms.Label();
            this.pgbSuhu = new System.Windows.Forms.ProgressBar();
            this.lblJudulPesan = new System.Windows.Forms.Label();
            this.rtbPesan = new System.Windows.Forms.RichTextBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.grpData.SuspendLayout();
            this.pnlRekomendasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Rekomendasi Suhu Otomatis";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Text = "Data Terbaru Kandang";
            this.grpData.Location = new System.Drawing.Point(20, 50);
            this.grpData.Size = new System.Drawing.Size(1010, 95);
            this.grpData.Name = "grpData";
            this.grpData.TabIndex = 1;
            this.grpData.Controls.Add(this.lblPilih);
            this.grpData.Controls.Add(this.cmbKandang);
            this.grpData.Controls.Add(this.lblSuhuAktual);
            this.grpData.Controls.Add(this.lblKelembabanAktual);
            this.grpData.Controls.Add(this.lblUmur);
            this.grpData.Controls.Add(this.lblUpdate);
            this.grpData.Controls.Add(this.btnRefresh);
            // 
            // lblPilih
            // 
            this.lblPilih.AutoSize = true;
            this.lblPilih.Text = "Pilih Kandang";
            this.lblPilih.Location = new System.Drawing.Point(20, 24);
            this.lblPilih.Name = "lblPilih";
            this.lblPilih.TabIndex = 2;
            // 
            // cmbKandang
            // 
            this.cmbKandang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(20, 46);
            this.cmbKandang.Size = new System.Drawing.Size(220, 23);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.TabIndex = 3;
            this.cmbKandang.SelectedIndexChanged += new System.EventHandler(this.cmbKandang_SelectedIndexChanged);
            // 
            // lblSuhuAktual
            // 
            this.lblSuhuAktual.AutoSize = true;
            this.lblSuhuAktual.Text = "Suhu Aktual: -";
            this.lblSuhuAktual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblSuhuAktual.Location = new System.Drawing.Point(270, 30);
            this.lblSuhuAktual.Name = "lblSuhuAktual";
            this.lblSuhuAktual.TabIndex = 4;
            // 
            // lblKelembabanAktual
            // 
            this.lblKelembabanAktual.AutoSize = true;
            this.lblKelembabanAktual.Text = "Kelembaban Aktual: -";
            this.lblKelembabanAktual.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblKelembabanAktual.Location = new System.Drawing.Point(270, 58);
            this.lblKelembabanAktual.Name = "lblKelembabanAktual";
            this.lblKelembabanAktual.TabIndex = 5;
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Text = "Umur Ayam: -";
            this.lblUmur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblUmur.Location = new System.Drawing.Point(520, 30);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.TabIndex = 6;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Text = "Diperbarui: -";
            this.lblUpdate.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblUpdate.Location = new System.Drawing.Point(520, 58);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.TabIndex = 7;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(840, 36);
            this.btnRefresh.Size = new System.Drawing.Size(140, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlRekomendasi
            // 
            this.pnlRekomendasi.BackColor = System.Drawing.Color.White;
            this.pnlRekomendasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRekomendasi.Location = new System.Drawing.Point(20, 155);
            this.pnlRekomendasi.Size = new System.Drawing.Size(1010, 467);
            this.pnlRekomendasi.Name = "pnlRekomendasi";
            this.pnlRekomendasi.TabIndex = 9;
            this.pnlRekomendasi.Controls.Add(this.lblJudulSuhu);
            this.pnlRekomendasi.Controls.Add(this.lblSuhuIdeal);
            this.pnlRekomendasi.Controls.Add(this.lblJudulKelembaban);
            this.pnlRekomendasi.Controls.Add(this.lblKelembabanIdeal);
            this.pnlRekomendasi.Controls.Add(this.lblStatusSuhu);
            this.pnlRekomendasi.Controls.Add(this.lblStatusKelembaban);
            this.pnlRekomendasi.Controls.Add(this.lblIndikator);
            this.pnlRekomendasi.Controls.Add(this.pgbSuhu);
            this.pnlRekomendasi.Controls.Add(this.lblJudulPesan);
            this.pnlRekomendasi.Controls.Add(this.rtbPesan);
            // 
            // lblJudulSuhu
            // 
            this.lblJudulSuhu.AutoSize = true;
            this.lblJudulSuhu.Text = "Suhu Ideal";
            this.lblJudulSuhu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblJudulSuhu.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblJudulSuhu.Location = new System.Drawing.Point(30, 20);
            this.lblJudulSuhu.Name = "lblJudulSuhu";
            this.lblJudulSuhu.TabIndex = 10;
            // 
            // lblSuhuIdeal
            // 
            this.lblSuhuIdeal.AutoSize = true;
            this.lblSuhuIdeal.Text = "- °C";
            this.lblSuhuIdeal.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblSuhuIdeal.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblSuhuIdeal.Location = new System.Drawing.Point(28, 44);
            this.lblSuhuIdeal.Name = "lblSuhuIdeal";
            this.lblSuhuIdeal.TabIndex = 11;
            // 
            // lblJudulKelembaban
            // 
            this.lblJudulKelembaban.AutoSize = true;
            this.lblJudulKelembaban.Text = "Kelembaban Ideal";
            this.lblJudulKelembaban.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblJudulKelembaban.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblJudulKelembaban.Location = new System.Drawing.Point(520, 20);
            this.lblJudulKelembaban.Name = "lblJudulKelembaban";
            this.lblJudulKelembaban.TabIndex = 12;
            // 
            // lblKelembabanIdeal
            // 
            this.lblKelembabanIdeal.AutoSize = true;
            this.lblKelembabanIdeal.Text = "- %";
            this.lblKelembabanIdeal.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblKelembabanIdeal.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblKelembabanIdeal.Location = new System.Drawing.Point(518, 44);
            this.lblKelembabanIdeal.Name = "lblKelembabanIdeal";
            this.lblKelembabanIdeal.TabIndex = 13;
            // 
            // lblStatusSuhu
            // 
            this.lblStatusSuhu.AutoSize = true;
            this.lblStatusSuhu.Text = "Status Suhu: -";
            this.lblStatusSuhu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatusSuhu.Location = new System.Drawing.Point(30, 110);
            this.lblStatusSuhu.Name = "lblStatusSuhu";
            this.lblStatusSuhu.TabIndex = 14;
            // 
            // lblStatusKelembaban
            // 
            this.lblStatusKelembaban.AutoSize = true;
            this.lblStatusKelembaban.Text = "Status Kelembaban: -";
            this.lblStatusKelembaban.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatusKelembaban.Location = new System.Drawing.Point(520, 110);
            this.lblStatusKelembaban.Name = "lblStatusKelembaban";
            this.lblStatusKelembaban.TabIndex = 15;
            // 
            // lblIndikator
            // 
            this.lblIndikator.AutoSize = true;
            this.lblIndikator.Text = "Kesesuaian suhu: -";
            this.lblIndikator.Location = new System.Drawing.Point(30, 150);
            this.lblIndikator.Name = "lblIndikator";
            this.lblIndikator.TabIndex = 16;
            // 
            // pgbSuhu
            // 
            this.pgbSuhu.Location = new System.Drawing.Point(30, 172);
            this.pgbSuhu.Size = new System.Drawing.Size(950, 24);
            this.pgbSuhu.Name = "pgbSuhu";
            this.pgbSuhu.TabIndex = 17;
            // 
            // lblJudulPesan
            // 
            this.lblJudulPesan.AutoSize = true;
            this.lblJudulPesan.Text = "Pesan Rekomendasi";
            this.lblJudulPesan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJudulPesan.Location = new System.Drawing.Point(30, 210);
            this.lblJudulPesan.Name = "lblJudulPesan";
            this.lblJudulPesan.TabIndex = 18;
            // 
            // rtbPesan
            // 
            this.rtbPesan.ReadOnly = true;
            this.rtbPesan.BackColor = System.Drawing.Color.White;
            this.rtbPesan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.rtbPesan.Text = "";
            this.rtbPesan.Location = new System.Drawing.Point(30, 234);
            this.rtbPesan.Size = new System.Drawing.Size(950, 210);
            this.rtbPesan.Name = "rtbPesan";
            this.rtbPesan.TabIndex = 19;
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 30000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // FormRekomendasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.pnlRekomendasi);
            this.Name = "FormRekomendasi";
            this.Text = "Rekomendasi Suhu";
            this.pnlRekomendasi.ResumeLayout(false);
            this.pnlRekomendasi.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblPilih;
        private System.Windows.Forms.ComboBox cmbKandang;
        private System.Windows.Forms.Label lblSuhuAktual;
        private System.Windows.Forms.Label lblKelembabanAktual;
        private System.Windows.Forms.Label lblUmur;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlRekomendasi;
        private System.Windows.Forms.Label lblJudulSuhu;
        private System.Windows.Forms.Label lblSuhuIdeal;
        private System.Windows.Forms.Label lblJudulKelembaban;
        private System.Windows.Forms.Label lblKelembabanIdeal;
        private System.Windows.Forms.Label lblStatusSuhu;
        private System.Windows.Forms.Label lblStatusKelembaban;
        private System.Windows.Forms.Label lblIndikator;
        private System.Windows.Forms.ProgressBar pgbSuhu;
        private System.Windows.Forms.Label lblJudulPesan;
        private System.Windows.Forms.RichTextBox rtbPesan;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}
