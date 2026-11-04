namespace SIBRO.Forms
{
    partial class FormRiwayatMonitoring
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
            this.lblFilter0 = new System.Windows.Forms.Label();
            this.lblFilter1 = new System.Windows.Forms.Label();
            this.lblFilter2 = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.dtpDari = new System.Windows.Forms.DateTimePicker();
            this.dtpSampai = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRataSuhu = new System.Windows.Forms.Label();
            this.lblRataKelembaban = new System.Windows.Forms.Label();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Riwayat Monitoring";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Text = "Filter";
            this.grpFilter.Location = new System.Drawing.Point(20, 50);
            this.grpFilter.Size = new System.Drawing.Size(1010, 85);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.TabIndex = 1;
            this.grpFilter.Controls.Add(this.lblFilter0);
            this.grpFilter.Controls.Add(this.lblFilter1);
            this.grpFilter.Controls.Add(this.lblFilter2);
            this.grpFilter.Controls.Add(this.cmbKandang);
            this.grpFilter.Controls.Add(this.dtpDari);
            this.grpFilter.Controls.Add(this.dtpSampai);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.btnReset);
            this.grpFilter.Controls.Add(this.btnExport);
            // 
            // lblFilter0
            // 
            this.lblFilter0.AutoSize = true;
            this.lblFilter0.Text = "Kandang";
            this.lblFilter0.Location = new System.Drawing.Point(20, 22);
            this.lblFilter0.Name = "lblFilter0";
            this.lblFilter0.TabIndex = 2;
            // 
            // lblFilter1
            // 
            this.lblFilter1.AutoSize = true;
            this.lblFilter1.Text = "Dari Tanggal";
            this.lblFilter1.Location = new System.Drawing.Point(240, 22);
            this.lblFilter1.Name = "lblFilter1";
            this.lblFilter1.TabIndex = 3;
            // 
            // lblFilter2
            // 
            this.lblFilter2.AutoSize = true;
            this.lblFilter2.Text = "Sampai Tanggal";
            this.lblFilter2.Location = new System.Drawing.Point(410, 22);
            this.lblFilter2.Name = "lblFilter2";
            this.lblFilter2.TabIndex = 4;
            // 
            // cmbKandang
            // 
            this.cmbKandang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(20, 44);
            this.cmbKandang.Size = new System.Drawing.Size(200, 23);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.TabIndex = 5;
            // 
            // dtpDari
            // 
            this.dtpDari.CustomFormat = "dd/MM/yyyy";
            this.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDari.Location = new System.Drawing.Point(240, 44);
            this.dtpDari.Size = new System.Drawing.Size(150, 23);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.TabIndex = 6;
            // 
            // dtpSampai
            // 
            this.dtpSampai.CustomFormat = "dd/MM/yyyy";
            this.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSampai.Location = new System.Drawing.Point(410, 44);
            this.dtpSampai.Size = new System.Drawing.Size(150, 23);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.TabIndex = 7;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Location = new System.Drawing.Point(590, 40);
            this.btnFilter.Size = new System.Drawing.Size(100, 32);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Text = "Reset Filter";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(700, 40);
            this.btnReset.Size = new System.Drawing.Size(110, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.TabIndex = 9;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Text = "Export ke CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Location = new System.Drawing.Point(820, 40);
            this.btnExport.Size = new System.Drawing.Size(160, 32);
            this.btnExport.Name = "btnExport";
            this.btnExport.TabIndex = 10;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Text = "Total Record: 0";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 145);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.TabIndex = 11;
            // 
            // lblRataSuhu
            // 
            this.lblRataSuhu.AutoSize = true;
            this.lblRataSuhu.Text = "Rata-rata Suhu: -";
            this.lblRataSuhu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRataSuhu.Location = new System.Drawing.Point(260, 145);
            this.lblRataSuhu.Name = "lblRataSuhu";
            this.lblRataSuhu.TabIndex = 12;
            // 
            // lblRataKelembaban
            // 
            this.lblRataKelembaban.AutoSize = true;
            this.lblRataKelembaban.Text = "Rata-rata Kelembaban: -";
            this.lblRataKelembaban.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRataKelembaban.Location = new System.Drawing.Point(560, 145);
            this.lblRataKelembaban.Name = "lblRataKelembaban";
            this.lblRataKelembaban.TabIndex = 13;
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.AllowUserToResizeRows = false;
            this.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayat.BackgroundColor = System.Drawing.Color.White;
            this.dgvRiwayat.MultiSelect = false;
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.RowHeadersVisible = false;
            this.dgvRiwayat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRiwayat.Location = new System.Drawing.Point(20, 175);
            this.dgvRiwayat.Size = new System.Drawing.Size(1010, 447);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.TabIndex = 14;
            this.dgvRiwayat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRiwayat_CellFormatting);
            this.dgvRiwayat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRiwayat_DataBindingComplete);
            // 
            // FormRiwayatMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRataSuhu);
            this.Controls.Add(this.lblRataKelembaban);
            this.Controls.Add(this.dgvRiwayat);
            this.Name = "FormRiwayatMonitoring";
            this.Text = "Riwayat Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblFilter0;
        private System.Windows.Forms.Label lblFilter1;
        private System.Windows.Forms.Label lblFilter2;
        private System.Windows.Forms.ComboBox cmbKandang;
        private System.Windows.Forms.DateTimePicker dtpDari;
        private System.Windows.Forms.DateTimePicker dtpSampai;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRataSuhu;
        private System.Windows.Forms.Label lblRataKelembaban;
        private System.Windows.Forms.DataGridView dgvRiwayat;
    }
}
