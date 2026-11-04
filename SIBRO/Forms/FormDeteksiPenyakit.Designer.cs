namespace SIBRO.Forms
{
    partial class FormDeteksiPenyakit
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
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblPilih = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.lblSuhu = new System.Windows.Forms.Label();
            this.lblKelembaban = new System.Windows.Forms.Label();
            this.lblBerat = new System.Windows.Forms.Label();
            this.lblKondisi = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.pnlHasil = new System.Windows.Forms.Panel();
            this.lblPesan = new System.Windows.Forms.Label();
            this.dgvHasil = new System.Windows.Forms.DataGridView();
            this.rtbDetail = new System.Windows.Forms.RichTextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.grpData.SuspendLayout();
            this.pnlHasil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Deteksi Penyakit (Rule-Based)";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // grpData
            // 
            this.grpData.Text = "Data Monitoring Terbaru";
            this.grpData.Location = new System.Drawing.Point(20, 50);
            this.grpData.Size = new System.Drawing.Size(1010, 120);
            this.grpData.Name = "grpData";
            this.grpData.TabIndex = 1;
            this.grpData.Controls.Add(this.lblPilih);
            this.grpData.Controls.Add(this.cmbKandang);
            this.grpData.Controls.Add(this.lblSuhu);
            this.grpData.Controls.Add(this.lblKelembaban);
            this.grpData.Controls.Add(this.lblBerat);
            this.grpData.Controls.Add(this.lblKondisi);
            this.grpData.Controls.Add(this.lblTanggal);
            this.grpData.Controls.Add(this.btnAnalisis);
            // 
            // lblPilih
            // 
            this.lblPilih.AutoSize = true;
            this.lblPilih.Text = "Pilih Kandang";
            this.lblPilih.Location = new System.Drawing.Point(20, 28);
            this.lblPilih.Name = "lblPilih";
            this.lblPilih.TabIndex = 2;
            // 
            // cmbKandang
            // 
            this.cmbKandang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(20, 50);
            this.cmbKandang.Size = new System.Drawing.Size(220, 23);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.TabIndex = 3;
            this.cmbKandang.SelectedIndexChanged += new System.EventHandler(this.cmbKandang_SelectedIndexChanged);
            // 
            // lblSuhu
            // 
            this.lblSuhu.AutoSize = true;
            this.lblSuhu.Text = "Suhu: -";
            this.lblSuhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblSuhu.Location = new System.Drawing.Point(270, 30);
            this.lblSuhu.Name = "lblSuhu";
            this.lblSuhu.TabIndex = 4;
            // 
            // lblKelembaban
            // 
            this.lblKelembaban.AutoSize = true;
            this.lblKelembaban.Text = "Kelembaban: -";
            this.lblKelembaban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblKelembaban.Location = new System.Drawing.Point(270, 58);
            this.lblKelembaban.Name = "lblKelembaban";
            this.lblKelembaban.TabIndex = 5;
            // 
            // lblBerat
            // 
            this.lblBerat.AutoSize = true;
            this.lblBerat.Text = "Berat: -";
            this.lblBerat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblBerat.Location = new System.Drawing.Point(270, 86);
            this.lblBerat.Name = "lblBerat";
            this.lblBerat.TabIndex = 6;
            // 
            // lblKondisi
            // 
            this.lblKondisi.AutoSize = true;
            this.lblKondisi.Text = "Kondisi: -";
            this.lblKondisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblKondisi.Location = new System.Drawing.Point(460, 30);
            this.lblKondisi.Name = "lblKondisi";
            this.lblKondisi.TabIndex = 7;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Text = "Tanggal Input: -";
            this.lblTanggal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblTanggal.Location = new System.Drawing.Point(460, 58);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.TabIndex = 8;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnAnalisis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalisis.ForeColor = System.Drawing.Color.White;
            this.btnAnalisis.Text = "ANALISIS SEKARANG";
            this.btnAnalisis.UseVisualStyleBackColor = false;
            this.btnAnalisis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalisis.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnAnalisis.Location = new System.Drawing.Point(740, 28);
            this.btnAnalisis.Size = new System.Drawing.Size(240, 76);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.TabIndex = 9;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // pnlHasil
            // 
            this.pnlHasil.BackColor = System.Drawing.Color.White;
            this.pnlHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHasil.Location = new System.Drawing.Point(20, 180);
            this.pnlHasil.Size = new System.Drawing.Size(1010, 390);
            this.pnlHasil.Name = "pnlHasil";
            this.pnlHasil.TabIndex = 10;
            this.pnlHasil.Controls.Add(this.lblPesan);
            this.pnlHasil.Controls.Add(this.dgvHasil);
            this.pnlHasil.Controls.Add(this.rtbDetail);
            // 
            // lblPesan
            // 
            this.lblPesan.Text = "Pilih kandang lalu tekan ANALISIS SEKARANG.";
            this.lblPesan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPesan.Location = new System.Drawing.Point(12, 8);
            this.lblPesan.Size = new System.Drawing.Size(980, 28);
            this.lblPesan.Name = "lblPesan";
            this.lblPesan.TabIndex = 11;
            // 
            // dgvHasil
            // 
            this.dgvHasil.AllowUserToAddRows = false;
            this.dgvHasil.AllowUserToDeleteRows = false;
            this.dgvHasil.AllowUserToResizeRows = false;
            this.dgvHasil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHasil.BackgroundColor = System.Drawing.Color.White;
            this.dgvHasil.MultiSelect = false;
            this.dgvHasil.ReadOnly = true;
            this.dgvHasil.RowHeadersVisible = false;
            this.dgvHasil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHasil.Visible = false;
            this.dgvHasil.Location = new System.Drawing.Point(12, 42);
            this.dgvHasil.Size = new System.Drawing.Size(530, 335);
            this.dgvHasil.Name = "dgvHasil";
            this.dgvHasil.TabIndex = 12;
            this.dgvHasil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHasil_CellClick);
            this.dgvHasil.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvHasil_CellPainting);
            // 
            // rtbDetail
            // 
            this.rtbDetail.ReadOnly = true;
            this.rtbDetail.BackColor = System.Drawing.Color.White;
            this.rtbDetail.Text = "";
            this.rtbDetail.Location = new System.Drawing.Point(555, 42);
            this.rtbDetail.Size = new System.Drawing.Size(440, 335);
            this.rtbDetail.Name = "rtbDetail";
            this.rtbDetail.TabIndex = 13;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Text = "Simpan Hasil Deteksi";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(20, 582);
            this.btnSimpan.Size = new System.Drawing.Size(220, 40);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.TabIndex = 14;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnRiwayat.Text = "Lihat Riwayat Deteksi";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiwayat.Location = new System.Drawing.Point(250, 582);
            this.btnRiwayat.Size = new System.Drawing.Size(220, 40);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.TabIndex = 15;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // FormDeteksiPenyakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.pnlHasil);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnRiwayat);
            this.Name = "FormDeteksiPenyakit";
            this.Text = "Deteksi Penyakit";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasil)).EndInit();
            this.pnlHasil.ResumeLayout(false);
            this.pnlHasil.PerformLayout();
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
        private System.Windows.Forms.Label lblSuhu;
        private System.Windows.Forms.Label lblKelembaban;
        private System.Windows.Forms.Label lblBerat;
        private System.Windows.Forms.Label lblKondisi;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Panel pnlHasil;
        private System.Windows.Forms.Label lblPesan;
        private System.Windows.Forms.DataGridView dgvHasil;
        private System.Windows.Forms.RichTextBox rtbDetail;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnRiwayat;
    }
}
