namespace SIBRO.Forms
{
    partial class FormInputMonitoring
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
            this.lblWaktu = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblInput0 = new System.Windows.Forms.Label();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblInput4 = new System.Windows.Forms.Label();
            this.lblInput5 = new System.Windows.Forms.Label();
            this.lblInput6 = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.nudSuhu = new System.Windows.Forms.NumericUpDown();
            this.nudKelembaban = new System.Windows.Forms.NumericUpDown();
            this.nudBerat = new System.Windows.Forms.NumericUpDown();
            this.cmbKondisi = new System.Windows.Forms.ComboBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.txtCatatan = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.tmrJam = new System.Windows.Forms.Timer(this.components);
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKelembaban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBerat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Input Monitoring Harian";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // lblWaktu
            // 
            this.lblWaktu.Text = "00:00:00";
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWaktu.ForeColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.lblWaktu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWaktu.Location = new System.Drawing.Point(830, 12);
            this.lblWaktu.Size = new System.Drawing.Size(200, 30);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.TabIndex = 1;
            // 
            // grpInput
            // 
            this.grpInput.Text = "Input Kondisi Kandang";
            this.grpInput.Location = new System.Drawing.Point(20, 50);
            this.grpInput.Size = new System.Drawing.Size(1010, 215);
            this.grpInput.Name = "grpInput";
            this.grpInput.TabIndex = 2;
            this.grpInput.Controls.Add(this.lblInput0);
            this.grpInput.Controls.Add(this.lblInput1);
            this.grpInput.Controls.Add(this.lblInput2);
            this.grpInput.Controls.Add(this.lblInput3);
            this.grpInput.Controls.Add(this.lblInput4);
            this.grpInput.Controls.Add(this.lblInput5);
            this.grpInput.Controls.Add(this.lblInput6);
            this.grpInput.Controls.Add(this.cmbKandang);
            this.grpInput.Controls.Add(this.nudSuhu);
            this.grpInput.Controls.Add(this.nudKelembaban);
            this.grpInput.Controls.Add(this.nudBerat);
            this.grpInput.Controls.Add(this.cmbKondisi);
            this.grpInput.Controls.Add(this.dtpTanggal);
            this.grpInput.Controls.Add(this.txtCatatan);
            this.grpInput.Controls.Add(this.btnSimpan);
            this.grpInput.Controls.Add(this.btnEdit);
            this.grpInput.Controls.Add(this.btnHapus);
            this.grpInput.Controls.Add(this.btnRefresh);
            this.grpInput.Controls.Add(this.btnClear);
            this.grpInput.Controls.Add(this.btnRiwayat);
            // 
            // lblInput0
            // 
            this.lblInput0.AutoSize = true;
            this.lblInput0.Text = "Kandang";
            this.lblInput0.Location = new System.Drawing.Point(20, 26);
            this.lblInput0.Name = "lblInput0";
            this.lblInput0.TabIndex = 3;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Text = "Suhu (°C)";
            this.lblInput1.Location = new System.Drawing.Point(220, 26);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.TabIndex = 4;
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Text = "Kelembaban (%)";
            this.lblInput2.Location = new System.Drawing.Point(360, 26);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.TabIndex = 5;
            // 
            // lblInput3
            // 
            this.lblInput3.AutoSize = true;
            this.lblInput3.Text = "Berat Rata-rata (gram)";
            this.lblInput3.Location = new System.Drawing.Point(500, 26);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.TabIndex = 6;
            // 
            // lblInput4
            // 
            this.lblInput4.AutoSize = true;
            this.lblInput4.Text = "Kondisi Umum";
            this.lblInput4.Location = new System.Drawing.Point(660, 26);
            this.lblInput4.Name = "lblInput4";
            this.lblInput4.TabIndex = 7;
            // 
            // lblInput5
            // 
            this.lblInput5.AutoSize = true;
            this.lblInput5.Text = "Tanggal Input";
            this.lblInput5.Location = new System.Drawing.Point(830, 26);
            this.lblInput5.Name = "lblInput5";
            this.lblInput5.TabIndex = 8;
            // 
            // lblInput6
            // 
            this.lblInput6.AutoSize = true;
            this.lblInput6.Text = "Catatan";
            this.lblInput6.Location = new System.Drawing.Point(20, 80);
            this.lblInput6.Name = "lblInput6";
            this.lblInput6.TabIndex = 9;
            // 
            // cmbKandang
            // 
            this.cmbKandang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(20, 48);
            this.cmbKandang.Size = new System.Drawing.Size(180, 23);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.TabIndex = 10;
            // 
            // nudSuhu
            // 
            this.nudSuhu.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            this.nudSuhu.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
            this.nudSuhu.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudSuhu.DecimalPlaces = 1;
            this.nudSuhu.Location = new System.Drawing.Point(220, 48);
            this.nudSuhu.Size = new System.Drawing.Size(120, 23);
            this.nudSuhu.Name = "nudSuhu";
            this.nudSuhu.TabIndex = 11;
            // 
            // nudKelembaban
            // 
            this.nudKelembaban.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.nudKelembaban.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudKelembaban.Location = new System.Drawing.Point(360, 48);
            this.nudKelembaban.Size = new System.Drawing.Size(120, 23);
            this.nudKelembaban.Name = "nudKelembaban";
            this.nudKelembaban.TabIndex = 12;
            // 
            // nudBerat
            // 
            this.nudBerat.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            this.nudBerat.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.nudBerat.Location = new System.Drawing.Point(500, 48);
            this.nudBerat.Size = new System.Drawing.Size(140, 23);
            this.nudBerat.Name = "nudBerat";
            this.nudBerat.TabIndex = 13;
            // 
            // cmbKondisi
            // 
            this.cmbKondisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKondisi.FormattingEnabled = true;
            this.cmbKondisi.Items.AddRange(new object[] {
                "Normal",
                "Kurang Baik",
                "Kritis"});
            this.cmbKondisi.Location = new System.Drawing.Point(660, 48);
            this.cmbKondisi.Size = new System.Drawing.Size(150, 23);
            this.cmbKondisi.Name = "cmbKondisi";
            this.cmbKondisi.TabIndex = 14;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(830, 48);
            this.dtpTanggal.Size = new System.Drawing.Size(150, 23);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.TabIndex = 15;
            // 
            // txtCatatan
            // 
            this.txtCatatan.Multiline = true;
            this.txtCatatan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCatatan.Location = new System.Drawing.Point(20, 102);
            this.txtCatatan.Size = new System.Drawing.Size(960, 50);
            this.txtCatatan.Name = "txtCatatan";
            this.txtCatatan.TabIndex = 16;
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Location = new System.Drawing.Point(20, 165);
            this.btnSimpan.Size = new System.Drawing.Size(95, 32);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.TabIndex = 17;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(125, 165);
            this.btnEdit.Size = new System.Drawing.Size(95, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.Location = new System.Drawing.Point(230, 165);
            this.btnHapus.Size = new System.Drawing.Size(95, 32);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(335, 165);
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(440, 165);
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 21;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRiwayat
            // 
            this.btnRiwayat.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.btnRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRiwayat.ForeColor = System.Drawing.Color.White;
            this.btnRiwayat.Text = "Riwayat dan Filter";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiwayat.Location = new System.Drawing.Point(830, 165);
            this.btnRiwayat.Size = new System.Drawing.Size(150, 32);
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.TabIndex = 22;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
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
            this.dgvRiwayat.Location = new System.Drawing.Point(20, 275);
            this.dgvRiwayat.Size = new System.Drawing.Size(1010, 347);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.TabIndex = 23;
            this.dgvRiwayat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRiwayat_CellClick);
            this.dgvRiwayat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRiwayat_CellFormatting);
            // 
            // tmrJam
            // 
            this.tmrJam.Enabled = true;
            this.tmrJam.Interval = 1000;
            this.tmrJam.Tick += new System.EventHandler(this.tmrJam_Tick);
            // 
            // FormInputMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblWaktu);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.dgvRiwayat);
            this.Name = "FormInputMonitoring";
            this.Text = "Input Monitoring Harian";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBerat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKelembaban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuhu)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblInput0;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblInput3;
        private System.Windows.Forms.Label lblInput4;
        private System.Windows.Forms.Label lblInput5;
        private System.Windows.Forms.Label lblInput6;
        private System.Windows.Forms.ComboBox cmbKandang;
        private System.Windows.Forms.NumericUpDown nudSuhu;
        private System.Windows.Forms.NumericUpDown nudKelembaban;
        private System.Windows.Forms.NumericUpDown nudBerat;
        private System.Windows.Forms.ComboBox cmbKondisi;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.TextBox txtCatatan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.Timer tmrJam;
    }
}
