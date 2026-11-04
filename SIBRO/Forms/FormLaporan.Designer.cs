namespace SIBRO.Forms
{
    partial class FormLaporan
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
            this.lblJudul = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.lblKandang = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.rbHarian = new System.Windows.Forms.RadioButton();
            this.rbMingguan = new System.Windows.Forms.RadioButton();
            this.rbBulanan = new System.Windows.Forms.RadioButton();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.pnlStatistik = new System.Windows.Forms.Panel();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.lblRataSuhu = new System.Windows.Forms.Label();
            this.lblRataKelembaban = new System.Windows.Forms.Label();
            this.lblKondisiDominan = new System.Windows.Forms.Label();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnExportTxt = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpFilter.SuspendLayout();
            this.pnlStatistik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Laporan Monitoring";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Text = "Pilih Laporan";
            this.grpFilter.Location = new System.Drawing.Point(20, 50);
            this.grpFilter.Size = new System.Drawing.Size(1010, 85);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.TabIndex = 1;
            this.grpFilter.Controls.Add(this.lblKandang);
            this.grpFilter.Controls.Add(this.cmbKandang);
            this.grpFilter.Controls.Add(this.rbHarian);
            this.grpFilter.Controls.Add(this.rbMingguan);
            this.grpFilter.Controls.Add(this.rbBulanan);
            this.grpFilter.Controls.Add(this.lblTanggal);
            this.grpFilter.Controls.Add(this.dtpTanggal);
            this.grpFilter.Controls.Add(this.btnGenerate);
            // 
            // lblKandang
            // 
            this.lblKandang.AutoSize = true;
            this.lblKandang.Text = "Kandang";
            this.lblKandang.Location = new System.Drawing.Point(20, 22);
            this.lblKandang.Name = "lblKandang";
            this.lblKandang.TabIndex = 2;
            // 
            // cmbKandang
            // 
            this.cmbKandang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(20, 44);
            this.cmbKandang.Size = new System.Drawing.Size(200, 23);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.TabIndex = 3;
            // 
            // rbHarian
            // 
            this.rbHarian.AutoSize = true;
            this.rbHarian.Text = "Harian";
            this.rbHarian.UseVisualStyleBackColor = true;
            this.rbHarian.Checked = true;
            this.rbHarian.TabStop = true;
            this.rbHarian.Location = new System.Drawing.Point(245, 45);
            this.rbHarian.Name = "rbHarian";
            this.rbHarian.TabIndex = 4;
            // 
            // rbMingguan
            // 
            this.rbMingguan.AutoSize = true;
            this.rbMingguan.Text = "Mingguan";
            this.rbMingguan.UseVisualStyleBackColor = true;
            this.rbMingguan.Location = new System.Drawing.Point(320, 45);
            this.rbMingguan.Name = "rbMingguan";
            this.rbMingguan.TabIndex = 5;
            // 
            // rbBulanan
            // 
            this.rbBulanan.AutoSize = true;
            this.rbBulanan.Text = "Bulanan";
            this.rbBulanan.UseVisualStyleBackColor = true;
            this.rbBulanan.Location = new System.Drawing.Point(415, 45);
            this.rbBulanan.Name = "rbBulanan";
            this.rbBulanan.TabIndex = 6;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Text = "Tanggal / Awal Minggu / Bulan";
            this.lblTanggal.Location = new System.Drawing.Point(510, 22);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.TabIndex = 7;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(510, 44);
            this.dtpTanggal.Size = new System.Drawing.Size(180, 23);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Text = "Generate Laporan";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(720, 36);
            this.btnGenerate.Size = new System.Drawing.Size(260, 38);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlStatistik
            // 
            this.pnlStatistik.BackColor = System.Drawing.Color.White;
            this.pnlStatistik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatistik.Location = new System.Drawing.Point(20, 145);
            this.pnlStatistik.Size = new System.Drawing.Size(1010, 60);
            this.pnlStatistik.Name = "pnlStatistik";
            this.pnlStatistik.TabIndex = 10;
            this.pnlStatistik.Controls.Add(this.lblPeriode);
            this.pnlStatistik.Controls.Add(this.lblRataSuhu);
            this.pnlStatistik.Controls.Add(this.lblRataKelembaban);
            this.pnlStatistik.Controls.Add(this.lblKondisiDominan);
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Text = "Periode: -";
            this.lblPeriode.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPeriode.Location = new System.Drawing.Point(12, 7);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.TabIndex = 11;
            // 
            // lblRataSuhu
            // 
            this.lblRataSuhu.AutoSize = true;
            this.lblRataSuhu.Text = "Rata-rata Suhu: -";
            this.lblRataSuhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRataSuhu.Location = new System.Drawing.Point(12, 31);
            this.lblRataSuhu.Name = "lblRataSuhu";
            this.lblRataSuhu.TabIndex = 12;
            // 
            // lblRataKelembaban
            // 
            this.lblRataKelembaban.AutoSize = true;
            this.lblRataKelembaban.Text = "Rata-rata Kelembaban: -";
            this.lblRataKelembaban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRataKelembaban.Location = new System.Drawing.Point(320, 31);
            this.lblRataKelembaban.Name = "lblRataKelembaban";
            this.lblRataKelembaban.TabIndex = 13;
            // 
            // lblKondisiDominan
            // 
            this.lblKondisiDominan.AutoSize = true;
            this.lblKondisiDominan.Text = "Kondisi Dominan: -";
            this.lblKondisiDominan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKondisiDominan.Location = new System.Drawing.Point(680, 31);
            this.lblKondisiDominan.Name = "lblKondisiDominan";
            this.lblKondisiDominan.TabIndex = 14;
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.AllowUserToAddRows = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AllowUserToResizeRows = false;
            this.dgvLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLaporan.BackgroundColor = System.Drawing.Color.White;
            this.dgvLaporan.MultiSelect = false;
            this.dgvLaporan.ReadOnly = true;
            this.dgvLaporan.RowHeadersVisible = false;
            this.dgvLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaporan.Location = new System.Drawing.Point(20, 215);
            this.dgvLaporan.Size = new System.Drawing.Size(1010, 360);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.TabIndex = 15;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.ForeColor = System.Drawing.Color.White;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportCsv.Location = new System.Drawing.Point(20, 585);
            this.btnExportCsv.Size = new System.Drawing.Size(150, 38);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.TabIndex = 16;
            this.btnExportCsv.Click += new System.EventHandler(this.btnExportCsv_Click);
            // 
            // btnExportTxt
            // 
            this.btnExportTxt.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnExportTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTxt.ForeColor = System.Drawing.Color.White;
            this.btnExportTxt.Text = "Export TXT";
            this.btnExportTxt.UseVisualStyleBackColor = false;
            this.btnExportTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportTxt.Location = new System.Drawing.Point(180, 585);
            this.btnExportTxt.Size = new System.Drawing.Size(150, 38);
            this.btnExportTxt.Name = "btnExportTxt";
            this.btnExportTxt.TabIndex = 17;
            this.btnExportTxt.Click += new System.EventHandler(this.btnExportTxt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Text = "Print Preview";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(340, 585);
            this.btnPrint.Size = new System.Drawing.Size(150, 38);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.pnlStatistik);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnExportTxt);
            this.Controls.Add(this.btnPrint);
            this.Name = "FormLaporan";
            this.Text = "Laporan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.pnlStatistik.ResumeLayout(false);
            this.pnlStatistik.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblKandang;
        private System.Windows.Forms.ComboBox cmbKandang;
        private System.Windows.Forms.RadioButton rbHarian;
        private System.Windows.Forms.RadioButton rbMingguan;
        private System.Windows.Forms.RadioButton rbBulanan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel pnlStatistik;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.Label lblRataSuhu;
        private System.Windows.Forms.Label lblRataKelembaban;
        private System.Windows.Forms.Label lblKondisiDominan;
        private System.Windows.Forms.DataGridView dgvLaporan;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnExportTxt;
        private System.Windows.Forms.Button btnPrint;
    }
}
