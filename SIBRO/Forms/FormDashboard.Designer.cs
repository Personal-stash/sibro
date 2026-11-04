namespace SIBRO.Forms
{
    partial class FormDashboard
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
            this.pnlKonten = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlNavigasi = new System.Windows.Forms.Panel();
            this.lblJudulUtama = new System.Windows.Forms.Label();
            this.lblLogoNav = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavKandang = new System.Windows.Forms.Button();
            this.btnNavAyam = new System.Windows.Forms.Button();
            this.btnNavMonitoring = new System.Windows.Forms.Button();
            this.btnNavDeteksi = new System.Windows.Forms.Button();
            this.btnNavRekomendasi = new System.Windows.Forms.Button();
            this.btnNavLaporan = new System.Windows.Forms.Button();
            this.btnNavKeluar = new System.Windows.Forms.Button();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlKartuKandang = new System.Windows.Forms.Panel();
            this.lblNilaiKandang = new System.Windows.Forms.Label();
            this.lblJudulKandang = new System.Windows.Forms.Label();
            this.pnlKartuAyam = new System.Windows.Forms.Panel();
            this.lblNilaiAyam = new System.Windows.Forms.Label();
            this.lblJudulAyam = new System.Windows.Forms.Label();
            this.pnlKartuKritis = new System.Windows.Forms.Panel();
            this.lblNilaiKritis = new System.Windows.Forms.Label();
            this.lblJudulKritis = new System.Windows.Forms.Label();
            this.pnlKartuDeteksi = new System.Windows.Forms.Panel();
            this.lblNilaiDeteksi = new System.Windows.Forms.Label();
            this.lblJudulDeteksi = new System.Windows.Forms.Label();
            this.chartSuhu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartKondisi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTerbaru = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.dgvTerbaru = new System.Windows.Forms.DataGridView();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlKonten.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlNavigasi.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlKartuKandang.SuspendLayout();
            this.pnlKartuAyam.SuspendLayout();
            this.pnlKartuKritis.SuspendLayout();
            this.pnlKartuDeteksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKondisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerbaru)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKonten
            // 
            this.pnlKonten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKonten.Location = new System.Drawing.Point(190, 50);
            this.pnlKonten.Size = new System.Drawing.Size(1050, 640);
            this.pnlKonten.Name = "pnlKonten";
            this.pnlKonten.TabIndex = 0;
            this.pnlKonten.Controls.Add(this.pnlDashboard);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(190, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1050, 50);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Controls.Add(this.lblJudulUtama);
            // 
            // pnlNavigasi
            // 
            this.pnlNavigasi.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.pnlNavigasi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigasi.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigasi.Size = new System.Drawing.Size(190, 690);
            this.pnlNavigasi.Name = "pnlNavigasi";
            this.pnlNavigasi.TabIndex = 2;
            this.pnlNavigasi.Controls.Add(this.lblLogoNav);
            this.pnlNavigasi.Controls.Add(this.btnNavDashboard);
            this.pnlNavigasi.Controls.Add(this.btnNavKandang);
            this.pnlNavigasi.Controls.Add(this.btnNavAyam);
            this.pnlNavigasi.Controls.Add(this.btnNavMonitoring);
            this.pnlNavigasi.Controls.Add(this.btnNavDeteksi);
            this.pnlNavigasi.Controls.Add(this.btnNavRekomendasi);
            this.pnlNavigasi.Controls.Add(this.btnNavLaporan);
            this.pnlNavigasi.Controls.Add(this.btnNavKeluar);
            // 
            // lblJudulUtama
            // 
            this.lblJudulUtama.AutoSize = true;
            this.lblJudulUtama.Text = "SI BRO - Sistem Monitoring Ayam Broiler";
            this.lblJudulUtama.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudulUtama.ForeColor = System.Drawing.Color.White;
            this.lblJudulUtama.Location = new System.Drawing.Point(15, 10);
            this.lblJudulUtama.Name = "lblJudulUtama";
            this.lblJudulUtama.TabIndex = 3;
            // 
            // lblLogoNav
            // 
            this.lblLogoNav.Text = "SI BRO";
            this.lblLogoNav.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogoNav.ForeColor = System.Drawing.Color.White;
            this.lblLogoNav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogoNav.Location = new System.Drawing.Point(0, 8);
            this.lblLogoNav.Size = new System.Drawing.Size(190, 50);
            this.lblLogoNav.Name = "lblLogoNav";
            this.lblLogoNav.TabIndex = 4;
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Text = "Dashboard";
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.Location = new System.Drawing.Point(0, 70);
            this.btnNavDashboard.Size = new System.Drawing.Size(190, 44);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.TabIndex = 5;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnNavKandang
            // 
            this.btnNavKandang.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavKandang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKandang.ForeColor = System.Drawing.Color.White;
            this.btnNavKandang.Text = "Data Kandang";
            this.btnNavKandang.UseVisualStyleBackColor = false;
            this.btnNavKandang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKandang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavKandang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavKandang.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavKandang.FlatAppearance.BorderSize = 0;
            this.btnNavKandang.Location = new System.Drawing.Point(0, 116);
            this.btnNavKandang.Size = new System.Drawing.Size(190, 44);
            this.btnNavKandang.Name = "btnNavKandang";
            this.btnNavKandang.TabIndex = 6;
            this.btnNavKandang.Click += new System.EventHandler(this.btnNavKandang_Click);
            // 
            // btnNavAyam
            // 
            this.btnNavAyam.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavAyam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAyam.ForeColor = System.Drawing.Color.White;
            this.btnNavAyam.Text = "Data Ayam";
            this.btnNavAyam.UseVisualStyleBackColor = false;
            this.btnNavAyam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavAyam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavAyam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavAyam.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavAyam.FlatAppearance.BorderSize = 0;
            this.btnNavAyam.Location = new System.Drawing.Point(0, 162);
            this.btnNavAyam.Size = new System.Drawing.Size(190, 44);
            this.btnNavAyam.Name = "btnNavAyam";
            this.btnNavAyam.TabIndex = 7;
            this.btnNavAyam.Click += new System.EventHandler(this.btnNavAyam_Click);
            // 
            // btnNavMonitoring
            // 
            this.btnNavMonitoring.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavMonitoring.ForeColor = System.Drawing.Color.White;
            this.btnNavMonitoring.Text = "Monitoring";
            this.btnNavMonitoring.UseVisualStyleBackColor = false;
            this.btnNavMonitoring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavMonitoring.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavMonitoring.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavMonitoring.FlatAppearance.BorderSize = 0;
            this.btnNavMonitoring.Location = new System.Drawing.Point(0, 208);
            this.btnNavMonitoring.Size = new System.Drawing.Size(190, 44);
            this.btnNavMonitoring.Name = "btnNavMonitoring";
            this.btnNavMonitoring.TabIndex = 8;
            this.btnNavMonitoring.Click += new System.EventHandler(this.btnNavMonitoring_Click);
            // 
            // btnNavDeteksi
            // 
            this.btnNavDeteksi.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavDeteksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDeteksi.ForeColor = System.Drawing.Color.White;
            this.btnNavDeteksi.Text = "Deteksi Penyakit";
            this.btnNavDeteksi.UseVisualStyleBackColor = false;
            this.btnNavDeteksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDeteksi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavDeteksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDeteksi.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavDeteksi.FlatAppearance.BorderSize = 0;
            this.btnNavDeteksi.Location = new System.Drawing.Point(0, 254);
            this.btnNavDeteksi.Size = new System.Drawing.Size(190, 44);
            this.btnNavDeteksi.Name = "btnNavDeteksi";
            this.btnNavDeteksi.TabIndex = 9;
            this.btnNavDeteksi.Click += new System.EventHandler(this.btnNavDeteksi_Click);
            // 
            // btnNavRekomendasi
            // 
            this.btnNavRekomendasi.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavRekomendasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRekomendasi.ForeColor = System.Drawing.Color.White;
            this.btnNavRekomendasi.Text = "Rekomendasi Suhu";
            this.btnNavRekomendasi.UseVisualStyleBackColor = false;
            this.btnNavRekomendasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavRekomendasi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavRekomendasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRekomendasi.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavRekomendasi.FlatAppearance.BorderSize = 0;
            this.btnNavRekomendasi.Location = new System.Drawing.Point(0, 300);
            this.btnNavRekomendasi.Size = new System.Drawing.Size(190, 44);
            this.btnNavRekomendasi.Name = "btnNavRekomendasi";
            this.btnNavRekomendasi.TabIndex = 10;
            this.btnNavRekomendasi.Click += new System.EventHandler(this.btnNavRekomendasi_Click);
            // 
            // btnNavLaporan
            // 
            this.btnNavLaporan.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnNavLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLaporan.ForeColor = System.Drawing.Color.White;
            this.btnNavLaporan.Text = "Laporan";
            this.btnNavLaporan.UseVisualStyleBackColor = false;
            this.btnNavLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLaporan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLaporan.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavLaporan.FlatAppearance.BorderSize = 0;
            this.btnNavLaporan.Location = new System.Drawing.Point(0, 346);
            this.btnNavLaporan.Size = new System.Drawing.Size(190, 44);
            this.btnNavLaporan.Name = "btnNavLaporan";
            this.btnNavLaporan.TabIndex = 11;
            this.btnNavLaporan.Click += new System.EventHandler(this.btnNavLaporan_Click);
            // 
            // btnNavKeluar
            // 
            this.btnNavKeluar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnNavKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavKeluar.ForeColor = System.Drawing.Color.White;
            this.btnNavKeluar.Text = "Keluar";
            this.btnNavKeluar.UseVisualStyleBackColor = false;
            this.btnNavKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavKeluar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.btnNavKeluar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavKeluar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNavKeluar.FlatAppearance.BorderSize = 0;
            this.btnNavKeluar.Location = new System.Drawing.Point(0, 630);
            this.btnNavKeluar.Size = new System.Drawing.Size(190, 44);
            this.btnNavKeluar.Name = "btnNavKeluar";
            this.btnNavKeluar.TabIndex = 12;
            this.btnNavKeluar.Click += new System.EventHandler(this.btnNavKeluar_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Size = new System.Drawing.Size(1050, 640);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.TabIndex = 13;
            this.pnlDashboard.Controls.Add(this.pnlKartuKandang);
            this.pnlDashboard.Controls.Add(this.pnlKartuAyam);
            this.pnlDashboard.Controls.Add(this.pnlKartuKritis);
            this.pnlDashboard.Controls.Add(this.pnlKartuDeteksi);
            this.pnlDashboard.Controls.Add(this.chartSuhu);
            this.pnlDashboard.Controls.Add(this.chartKondisi);
            this.pnlDashboard.Controls.Add(this.lblTerbaru);
            this.pnlDashboard.Controls.Add(this.lblUpdate);
            this.pnlDashboard.Controls.Add(this.dgvTerbaru);
            // 
            // pnlKartuKandang
            // 
            this.pnlKartuKandang.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlKartuKandang.Location = new System.Drawing.Point(15, 10);
            this.pnlKartuKandang.Size = new System.Drawing.Size(245, 80);
            this.pnlKartuKandang.Name = "pnlKartuKandang";
            this.pnlKartuKandang.TabIndex = 14;
            this.pnlKartuKandang.Controls.Add(this.lblNilaiKandang);
            this.pnlKartuKandang.Controls.Add(this.lblJudulKandang);
            // 
            // lblNilaiKandang
            // 
            this.lblNilaiKandang.AutoSize = true;
            this.lblNilaiKandang.Text = "0";
            this.lblNilaiKandang.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNilaiKandang.ForeColor = System.Drawing.Color.White;
            this.lblNilaiKandang.Location = new System.Drawing.Point(10, 4);
            this.lblNilaiKandang.Name = "lblNilaiKandang";
            this.lblNilaiKandang.TabIndex = 15;
            // 
            // lblJudulKandang
            // 
            this.lblJudulKandang.AutoSize = true;
            this.lblJudulKandang.Text = "Total Kandang Aktif";
            this.lblJudulKandang.ForeColor = System.Drawing.Color.White;
            this.lblJudulKandang.Location = new System.Drawing.Point(12, 52);
            this.lblJudulKandang.Name = "lblJudulKandang";
            this.lblJudulKandang.TabIndex = 16;
            // 
            // pnlKartuAyam
            // 
            this.pnlKartuAyam.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.pnlKartuAyam.Location = new System.Drawing.Point(275, 10);
            this.pnlKartuAyam.Size = new System.Drawing.Size(245, 80);
            this.pnlKartuAyam.Name = "pnlKartuAyam";
            this.pnlKartuAyam.TabIndex = 17;
            this.pnlKartuAyam.Controls.Add(this.lblNilaiAyam);
            this.pnlKartuAyam.Controls.Add(this.lblJudulAyam);
            // 
            // lblNilaiAyam
            // 
            this.lblNilaiAyam.AutoSize = true;
            this.lblNilaiAyam.Text = "0";
            this.lblNilaiAyam.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNilaiAyam.ForeColor = System.Drawing.Color.White;
            this.lblNilaiAyam.Location = new System.Drawing.Point(10, 4);
            this.lblNilaiAyam.Name = "lblNilaiAyam";
            this.lblNilaiAyam.TabIndex = 18;
            // 
            // lblJudulAyam
            // 
            this.lblJudulAyam.AutoSize = true;
            this.lblJudulAyam.Text = "Total Ayam Terpantau";
            this.lblJudulAyam.ForeColor = System.Drawing.Color.White;
            this.lblJudulAyam.Location = new System.Drawing.Point(12, 52);
            this.lblJudulAyam.Name = "lblJudulAyam";
            this.lblJudulAyam.TabIndex = 19;
            // 
            // pnlKartuKritis
            // 
            this.pnlKartuKritis.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.pnlKartuKritis.Location = new System.Drawing.Point(535, 10);
            this.pnlKartuKritis.Size = new System.Drawing.Size(245, 80);
            this.pnlKartuKritis.Name = "pnlKartuKritis";
            this.pnlKartuKritis.TabIndex = 20;
            this.pnlKartuKritis.Controls.Add(this.lblNilaiKritis);
            this.pnlKartuKritis.Controls.Add(this.lblJudulKritis);
            // 
            // lblNilaiKritis
            // 
            this.lblNilaiKritis.AutoSize = true;
            this.lblNilaiKritis.Text = "0";
            this.lblNilaiKritis.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNilaiKritis.ForeColor = System.Drawing.Color.White;
            this.lblNilaiKritis.Location = new System.Drawing.Point(10, 4);
            this.lblNilaiKritis.Name = "lblNilaiKritis";
            this.lblNilaiKritis.TabIndex = 21;
            // 
            // lblJudulKritis
            // 
            this.lblJudulKritis.AutoSize = true;
            this.lblJudulKritis.Text = "Kandang Kritis Hari Ini";
            this.lblJudulKritis.ForeColor = System.Drawing.Color.White;
            this.lblJudulKritis.Location = new System.Drawing.Point(12, 52);
            this.lblJudulKritis.Name = "lblJudulKritis";
            this.lblJudulKritis.TabIndex = 22;
            // 
            // pnlKartuDeteksi
            // 
            this.pnlKartuDeteksi.BackColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.pnlKartuDeteksi.Location = new System.Drawing.Point(795, 10);
            this.pnlKartuDeteksi.Size = new System.Drawing.Size(245, 80);
            this.pnlKartuDeteksi.Name = "pnlKartuDeteksi";
            this.pnlKartuDeteksi.TabIndex = 23;
            this.pnlKartuDeteksi.Controls.Add(this.lblNilaiDeteksi);
            this.pnlKartuDeteksi.Controls.Add(this.lblJudulDeteksi);
            // 
            // lblNilaiDeteksi
            // 
            this.lblNilaiDeteksi.AutoSize = true;
            this.lblNilaiDeteksi.Text = "0";
            this.lblNilaiDeteksi.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNilaiDeteksi.ForeColor = System.Drawing.Color.White;
            this.lblNilaiDeteksi.Location = new System.Drawing.Point(10, 4);
            this.lblNilaiDeteksi.Name = "lblNilaiDeteksi";
            this.lblNilaiDeteksi.TabIndex = 24;
            // 
            // lblJudulDeteksi
            // 
            this.lblJudulDeteksi.AutoSize = true;
            this.lblJudulDeteksi.Text = "Deteksi Penyakit Bulan Ini";
            this.lblJudulDeteksi.ForeColor = System.Drawing.Color.White;
            this.lblJudulDeteksi.Location = new System.Drawing.Point(12, 52);
            this.lblJudulDeteksi.Name = "lblJudulDeteksi";
            this.lblJudulDeteksi.TabIndex = 25;
            // 
            // chartSuhu
            // 
            this.chartSuhu.Location = new System.Drawing.Point(15, 98);
            this.chartSuhu.Size = new System.Drawing.Size(650, 320);
            this.chartSuhu.Name = "chartSuhu";
            this.chartSuhu.TabIndex = 26;
            // 
            // chartKondisi
            // 
            this.chartKondisi.Location = new System.Drawing.Point(675, 98);
            this.chartKondisi.Size = new System.Drawing.Size(360, 320);
            this.chartKondisi.Name = "chartKondisi";
            this.chartKondisi.TabIndex = 27;
            // 
            // lblTerbaru
            // 
            this.lblTerbaru.AutoSize = true;
            this.lblTerbaru.Text = "5 Monitoring Terbaru";
            this.lblTerbaru.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTerbaru.Location = new System.Drawing.Point(15, 422);
            this.lblTerbaru.Name = "lblTerbaru";
            this.lblTerbaru.TabIndex = 28;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Text = "Diperbarui: -";
            this.lblUpdate.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblUpdate.Location = new System.Drawing.Point(860, 424);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.TabIndex = 29;
            // 
            // dgvTerbaru
            // 
            this.dgvTerbaru.AllowUserToAddRows = false;
            this.dgvTerbaru.AllowUserToDeleteRows = false;
            this.dgvTerbaru.AllowUserToResizeRows = false;
            this.dgvTerbaru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerbaru.BackgroundColor = System.Drawing.Color.White;
            this.dgvTerbaru.MultiSelect = false;
            this.dgvTerbaru.ReadOnly = true;
            this.dgvTerbaru.RowHeadersVisible = false;
            this.dgvTerbaru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerbaru.Location = new System.Drawing.Point(15, 444);
            this.dgvTerbaru.Size = new System.Drawing.Size(1020, 186);
            this.dgvTerbaru.Name = "dgvTerbaru";
            this.dgvTerbaru.TabIndex = 30;
            this.dgvTerbaru.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTerbaru_CellFormatting);
            this.dgvTerbaru.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTerbaru_DataBindingComplete);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 60000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1240, 690);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.pnlKonten);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlNavigasi);
            this.Name = "FormDashboard";
            this.Text = "SI BRO - Sistem Monitoring Ayam Broiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerbaru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKondisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuhu)).EndInit();
            this.pnlKartuDeteksi.ResumeLayout(false);
            this.pnlKartuDeteksi.PerformLayout();
            this.pnlKartuKritis.ResumeLayout(false);
            this.pnlKartuKritis.PerformLayout();
            this.pnlKartuAyam.ResumeLayout(false);
            this.pnlKartuAyam.PerformLayout();
            this.pnlKartuKandang.ResumeLayout(false);
            this.pnlKartuKandang.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlNavigasi.ResumeLayout(false);
            this.pnlNavigasi.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlKonten.ResumeLayout(false);
            this.pnlKonten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlKonten;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNavigasi;
        private System.Windows.Forms.Label lblJudulUtama;
        private System.Windows.Forms.Label lblLogoNav;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavKandang;
        private System.Windows.Forms.Button btnNavAyam;
        private System.Windows.Forms.Button btnNavMonitoring;
        private System.Windows.Forms.Button btnNavDeteksi;
        private System.Windows.Forms.Button btnNavRekomendasi;
        private System.Windows.Forms.Button btnNavLaporan;
        private System.Windows.Forms.Button btnNavKeluar;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlKartuKandang;
        private System.Windows.Forms.Label lblNilaiKandang;
        private System.Windows.Forms.Label lblJudulKandang;
        private System.Windows.Forms.Panel pnlKartuAyam;
        private System.Windows.Forms.Label lblNilaiAyam;
        private System.Windows.Forms.Label lblJudulAyam;
        private System.Windows.Forms.Panel pnlKartuKritis;
        private System.Windows.Forms.Label lblNilaiKritis;
        private System.Windows.Forms.Label lblJudulKritis;
        private System.Windows.Forms.Panel pnlKartuDeteksi;
        private System.Windows.Forms.Label lblNilaiDeteksi;
        private System.Windows.Forms.Label lblJudulDeteksi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuhu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKondisi;
        private System.Windows.Forms.Label lblTerbaru;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.DataGridView dgvTerbaru;
        private System.Windows.Forms.Timer tmrRefresh;
    }
}
