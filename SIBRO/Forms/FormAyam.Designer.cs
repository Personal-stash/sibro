namespace SIBRO.Forms
{
    partial class FormAyam
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblInput0 = new System.Windows.Forms.Label();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblInput4 = new System.Windows.Forms.Label();
            this.cmbKandang = new System.Windows.Forms.ComboBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvAyam = new System.Windows.Forms.DataGridView();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAyam)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Data Ayam";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // grpInput
            // 
            this.grpInput.Text = "Input Data Ayam";
            this.grpInput.Location = new System.Drawing.Point(20, 50);
            this.grpInput.Size = new System.Drawing.Size(1010, 150);
            this.grpInput.Name = "grpInput";
            this.grpInput.TabIndex = 1;
            this.grpInput.Controls.Add(this.lblInput0);
            this.grpInput.Controls.Add(this.lblInput1);
            this.grpInput.Controls.Add(this.lblInput2);
            this.grpInput.Controls.Add(this.lblInput3);
            this.grpInput.Controls.Add(this.lblInput4);
            this.grpInput.Controls.Add(this.cmbKandang);
            this.grpInput.Controls.Add(this.txtJumlah);
            this.grpInput.Controls.Add(this.txtUmur);
            this.grpInput.Controls.Add(this.txtJenis);
            this.grpInput.Controls.Add(this.dtpTanggal);
            this.grpInput.Controls.Add(this.btnTambah);
            this.grpInput.Controls.Add(this.btnEdit);
            this.grpInput.Controls.Add(this.btnHapus);
            this.grpInput.Controls.Add(this.btnRefresh);
            this.grpInput.Controls.Add(this.btnClear);
            // 
            // lblInput0
            // 
            this.lblInput0.AutoSize = true;
            this.lblInput0.Text = "Kandang";
            this.lblInput0.Location = new System.Drawing.Point(20, 28);
            this.lblInput0.Name = "lblInput0";
            this.lblInput0.TabIndex = 2;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Text = "Jumlah (ekor)";
            this.lblInput1.Location = new System.Drawing.Point(220, 28);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.TabIndex = 3;
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Text = "Umur Saat Masuk (hari)";
            this.lblInput2.Location = new System.Drawing.Point(370, 28);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.TabIndex = 4;
            // 
            // lblInput3
            // 
            this.lblInput3.AutoSize = true;
            this.lblInput3.Text = "Jenis Ayam";
            this.lblInput3.Location = new System.Drawing.Point(540, 28);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.TabIndex = 5;
            // 
            // lblInput4
            // 
            this.lblInput4.AutoSize = true;
            this.lblInput4.Text = "Tanggal Masuk";
            this.lblInput4.Location = new System.Drawing.Point(790, 28);
            this.lblInput4.Name = "lblInput4";
            this.lblInput4.TabIndex = 6;
            // 
            // cmbKandang
            // 
            this.cmbKandang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKandang.FormattingEnabled = true;
            this.cmbKandang.Location = new System.Drawing.Point(20, 50);
            this.cmbKandang.Size = new System.Drawing.Size(180, 23);
            this.cmbKandang.Name = "cmbKandang";
            this.cmbKandang.TabIndex = 7;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(220, 50);
            this.txtJumlah.Size = new System.Drawing.Size(130, 23);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.TabIndex = 8;
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(370, 50);
            this.txtUmur.Size = new System.Drawing.Size(150, 23);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.TabIndex = 9;
            // 
            // txtJenis
            // 
            this.txtJenis.Location = new System.Drawing.Point(540, 50);
            this.txtJenis.Size = new System.Drawing.Size(230, 23);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.TabIndex = 10;
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggal.Location = new System.Drawing.Point(790, 50);
            this.dtpTanggal.Size = new System.Drawing.Size(190, 23);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.TabIndex = 11;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.Location = new System.Drawing.Point(20, 95);
            this.btnTambah.Size = new System.Drawing.Size(95, 32);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(125, 95);
            this.btnEdit.Size = new System.Drawing.Size(95, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.TabIndex = 13;
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
            this.btnHapus.Location = new System.Drawing.Point(230, 95);
            this.btnHapus.Size = new System.Drawing.Size(95, 32);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.TabIndex = 14;
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
            this.btnRefresh.Location = new System.Drawing.Point(335, 95);
            this.btnRefresh.Size = new System.Drawing.Size(95, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.TabIndex = 15;
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
            this.btnClear.Location = new System.Drawing.Point(440, 95);
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 16;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvAyam
            // 
            this.dgvAyam.AllowUserToAddRows = false;
            this.dgvAyam.AllowUserToDeleteRows = false;
            this.dgvAyam.AllowUserToResizeRows = false;
            this.dgvAyam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAyam.BackgroundColor = System.Drawing.Color.White;
            this.dgvAyam.MultiSelect = false;
            this.dgvAyam.ReadOnly = true;
            this.dgvAyam.RowHeadersVisible = false;
            this.dgvAyam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAyam.Location = new System.Drawing.Point(20, 212);
            this.dgvAyam.Size = new System.Drawing.Size(1010, 410);
            this.dgvAyam.Name = "dgvAyam";
            this.dgvAyam.TabIndex = 17;
            this.dgvAyam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAyam_CellClick);
            // 
            // FormAyam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.dgvAyam);
            this.Name = "FormAyam";
            this.Text = "Data Ayam";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAyam)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblInput0;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblInput3;
        private System.Windows.Forms.Label lblInput4;
        private System.Windows.Forms.ComboBox cmbKandang;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvAyam;
    }
}
