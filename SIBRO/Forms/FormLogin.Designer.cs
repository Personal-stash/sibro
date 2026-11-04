namespace SIBRO.Forms
{
    partial class FormLogin
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblSubjudul = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkTampilkan = new System.Windows.Forms.CheckBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 67, 50);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(420, 150);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblLogo);
            this.pnlHeader.Controls.Add(this.lblSubjudul);
            // 
            // lblLogo
            // 
            this.lblLogo.Text = "SI BRO";
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Location = new System.Drawing.Point(0, 28);
            this.lblLogo.Size = new System.Drawing.Size(420, 60);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.TabIndex = 1;
            // 
            // lblSubjudul
            // 
            this.lblSubjudul.Text = "Sistem Monitoring Ayam Broiler";
            this.lblSubjudul.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblSubjudul.ForeColor = System.Drawing.Color.FromArgb(216, 243, 220);
            this.lblSubjudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubjudul.Location = new System.Drawing.Point(0, 92);
            this.lblSubjudul.Size = new System.Drawing.Size(420, 26);
            this.lblSubjudul.Name = "lblSubjudul";
            this.lblSubjudul.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Text = "Username";
            this.lblUsername.Location = new System.Drawing.Point(60, 175);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(60, 197);
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Text = "Password";
            this.lblPassword.Location = new System.Drawing.Point(60, 235);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Location = new System.Drawing.Point(60, 257);
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.TabIndex = 6;
            // 
            // chkTampilkan
            // 
            this.chkTampilkan.AutoSize = true;
            this.chkTampilkan.Text = "Tampilkan password";
            this.chkTampilkan.UseVisualStyleBackColor = true;
            this.chkTampilkan.Location = new System.Drawing.Point(60, 287);
            this.chkTampilkan.Name = "chkTampilkan";
            this.chkTampilkan.TabIndex = 7;
            this.chkTampilkan.CheckedChanged += new System.EventHandler(this.chkTampilkan_CheckedChanged);
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.FromArgb(45, 106, 79);
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Text = "MASUK";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasuk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMasuk.Location = new System.Drawing.Point(60, 320);
            this.btnMasuk.Size = new System.Drawing.Size(300, 38);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.TabIndex = 8;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.Location = new System.Drawing.Point(60, 366);
            this.btnKeluar.Size = new System.Drawing.Size(300, 32);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.TabIndex = 9;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Text = "";
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Location = new System.Drawing.Point(20, 410);
            this.lblInfo.Size = new System.Drawing.Size(380, 40);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.TabIndex = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(420, 470);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.AcceptButton = this.btnMasuk;
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkTampilkan);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lblInfo);
            this.Name = "FormLogin";
            this.Text = "Login - SI BRO";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblSubjudul;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkTampilkan;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblInfo;
    }
}
