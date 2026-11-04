namespace SIBRO.Forms
{
    partial class FormKandang
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKapasitas = new System.Windows.Forms.TextBox();
            this.txtLokasi = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvKandang = new System.Windows.Forms.DataGridView();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Text = "Data Kandang";
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblJudul.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.lblJudul.Location = new System.Drawing.Point(20, 12);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.TabIndex = 0;
            // 
            // grpInput
            // 
            this.grpInput.Text = "Input Data Kandang";
            this.grpInput.Location = new System.Drawing.Point(20, 50);
            this.grpInput.Size = new System.Drawing.Size(1010, 150);
            this.grpInput.Name = "grpInput";
            this.grpInput.TabIndex = 1;
            this.grpInput.Controls.Add(this.lblInput0);
            this.grpInput.Controls.Add(this.lblInput1);
            this.grpInput.Controls.Add(this.lblInput2);
            this.grpInput.Controls.Add(this.lblInput3);
            this.grpInput.Controls.Add(this.txtNama);
            this.grpInput.Controls.Add(this.txtKapasitas);
            this.grpInput.Controls.Add(this.txtLokasi);
            this.grpInput.Controls.Add(this.cmbStatus);
            this.grpInput.Controls.Add(this.btnTambah);
            this.grpInput.Controls.Add(this.btnEdit);
            this.grpInput.Controls.Add(this.btnHapus);
            this.grpInput.Controls.Add(this.btnRefresh);
            this.grpInput.Controls.Add(this.btnClear);
            // 
            // lblInput0
            // 
            this.lblInput0.AutoSize = true;
            this.lblInput0.Text = "Nama Kandang";
            this.lblInput0.Location = new System.Drawing.Point(20, 28);
            this.lblInput0.Name = "lblInput0";
            this.lblInput0.TabIndex = 2;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Text = "Kapasitas (ekor)";
            this.lblInput1.Location = new System.Drawing.Point(270, 28);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.TabIndex = 3;
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Text = "Lokasi";
            this.lblInput2.Location = new System.Drawing.Point(470, 28);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.TabIndex = 4;
            // 
            // lblInput3
            // 
            this.lblInput3.AutoSize = true;
            this.lblInput3.Text = "Status";
            this.lblInput3.Location = new System.Drawing.Point(780, 28);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(20, 50);
            this.txtNama.Size = new System.Drawing.Size(230, 23);
            this.txtNama.Name = "txtNama";
            this.txtNama.TabIndex = 6;
            // 
            // txtKapasitas
            // 
            this.txtKapasitas.Location = new System.Drawing.Point(270, 50);
            this.txtKapasitas.Size = new System.Drawing.Size(180, 23);
            this.txtKapasitas.Name = "txtKapasitas";
            this.txtKapasitas.TabIndex = 7;
            // 
            // txtLokasi
            // 
            this.txtLokasi.Location = new System.Drawing.Point(470, 50);
            this.txtLokasi.Size = new System.Drawing.Size(290, 23);
            this.txtLokasi.Name = "txtLokasi";
            this.txtLokasi.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
                "Aktif",
                "Nonaktif"});
            this.cmbStatus.Location = new System.Drawing.Point(780, 50);
            this.cmbStatus.Size = new System.Drawing.Size(200, 23);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.TabIndex = 9;
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
            this.btnTambah.TabIndex = 10;
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
            this.btnEdit.TabIndex = 11;
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
            this.btnHapus.TabIndex = 12;
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
            this.btnRefresh.TabIndex = 13;
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
            this.btnClear.TabIndex = 14;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvKandang
            // 
            this.dgvKandang.AllowUserToAddRows = false;
            this.dgvKandang.AllowUserToDeleteRows = false;
            this.dgvKandang.AllowUserToResizeRows = false;
            this.dgvKandang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKandang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKandang.MultiSelect = false;
            this.dgvKandang.ReadOnly = true;
            this.dgvKandang.RowHeadersVisible = false;
            this.dgvKandang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKandang.Location = new System.Drawing.Point(20, 212);
            this.dgvKandang.Size = new System.Drawing.Size(1010, 410);
            this.dgvKandang.Name = "dgvKandang";
            this.dgvKandang.TabIndex = 15;
            this.dgvKandang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKandang_CellClick);
            // 
            // FormKandang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 640);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.dgvKandang);
            this.Name = "FormKandang";
            this.Text = "Data Kandang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKandang)).EndInit();
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
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKapasitas;
        private System.Windows.Forms.TextBox txtLokasi;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvKandang;
    }
}
