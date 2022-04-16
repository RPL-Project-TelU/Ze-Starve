namespace HalamanUtamaDonatur
{
    partial class HalamanUtamaDonatur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Donatur = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnAktivitasDonatur = new System.Windows.Forms.Button();
            this.BtnTambahAktivitas = new System.Windows.Forms.Button();
            this.LblAktivitasFoodshelter = new System.Windows.Forms.Label();
            this.LblTambahAktivitas = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.LblLogout = new System.Windows.Forms.Label();
            this.BtnPusatBantuan = new System.Windows.Forms.Button();
            this.BtnEditAkun = new System.Windows.Forms.Button();
            this.LblBantuan = new System.Windows.Forms.Label();
            this.LblEditAkun = new System.Windows.Forms.Label();
            this.Donatur.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Donatur
            // 
            this.Donatur.Controls.Add(this.tabPage1);
            this.Donatur.Controls.Add(this.tabPage2);
            this.Donatur.Location = new System.Drawing.Point(12, 8);
            this.Donatur.Name = "Donatur";
            this.Donatur.SelectedIndex = 0;
            this.Donatur.Size = new System.Drawing.Size(784, 437);
            this.Donatur.TabIndex = 0;
            this.Donatur.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnAktivitasDonatur);
            this.tabPage1.Controls.Add(this.BtnTambahAktivitas);
            this.tabPage1.Controls.Add(this.LblAktivitasFoodshelter);
            this.tabPage1.Controls.Add(this.LblTambahAktivitas);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnAktivitasDonatur
            // 
            this.BtnAktivitasDonatur.BackgroundImage = global::HalamanUtamaDonatur.Properties.Resources.logoZStarve01;
            this.BtnAktivitasDonatur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAktivitasDonatur.Location = new System.Drawing.Point(216, 31);
            this.BtnAktivitasDonatur.Name = "BtnAktivitasDonatur";
            this.BtnAktivitasDonatur.Size = new System.Drawing.Size(130, 131);
            this.BtnAktivitasDonatur.TabIndex = 23;
            this.BtnAktivitasDonatur.UseVisualStyleBackColor = true;
            this.BtnAktivitasDonatur.Click += new System.EventHandler(this.BtnAktivitasFoodshelter_Click);
            // 
            // BtnTambahAktivitas
            // 
            this.BtnTambahAktivitas.BackgroundImage = global::HalamanUtamaDonatur.Properties.Resources.Icon_Tambah;
            this.BtnTambahAktivitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTambahAktivitas.Location = new System.Drawing.Point(31, 31);
            this.BtnTambahAktivitas.Name = "BtnTambahAktivitas";
            this.BtnTambahAktivitas.Size = new System.Drawing.Size(130, 131);
            this.BtnTambahAktivitas.TabIndex = 21;
            this.BtnTambahAktivitas.UseVisualStyleBackColor = true;
            this.BtnTambahAktivitas.Click += new System.EventHandler(this.BtnTambahAktivitas_Click);
            // 
            // LblAktivitasFoodshelter
            // 
            this.LblAktivitasFoodshelter.BackColor = System.Drawing.SystemColors.Control;
            this.LblAktivitasFoodshelter.Location = new System.Drawing.Point(216, 160);
            this.LblAktivitasFoodshelter.Name = "LblAktivitasFoodshelter";
            this.LblAktivitasFoodshelter.Size = new System.Drawing.Size(130, 46);
            this.LblAktivitasFoodshelter.TabIndex = 22;
            this.LblAktivitasFoodshelter.Text = "Aktivitas Donatur";
            this.LblAktivitasFoodshelter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTambahAktivitas
            // 
            this.LblTambahAktivitas.BackColor = System.Drawing.SystemColors.Control;
            this.LblTambahAktivitas.Location = new System.Drawing.Point(31, 160);
            this.LblTambahAktivitas.Name = "LblTambahAktivitas";
            this.LblTambahAktivitas.Size = new System.Drawing.Size(130, 31);
            this.LblTambahAktivitas.TabIndex = 20;
            this.LblTambahAktivitas.Text = "Tambah Aktivitas";
            this.LblTambahAktivitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnLogout);
            this.tabPage2.Controls.Add(this.LblLogout);
            this.tabPage2.Controls.Add(this.BtnPusatBantuan);
            this.tabPage2.Controls.Add(this.BtnEditAkun);
            this.tabPage2.Controls.Add(this.LblBantuan);
            this.tabPage2.Controls.Add(this.LblEditAkun);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackgroundImage = global::HalamanUtamaDonatur.Properties.Resources.logout;
            this.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogout.Location = new System.Drawing.Point(413, 25);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(130, 131);
            this.BtnLogout.TabIndex = 30;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // LblLogout
            // 
            this.LblLogout.BackColor = System.Drawing.SystemColors.Control;
            this.LblLogout.Location = new System.Drawing.Point(413, 158);
            this.LblLogout.Name = "LblLogout";
            this.LblLogout.Size = new System.Drawing.Size(130, 31);
            this.LblLogout.TabIndex = 29;
            this.LblLogout.Text = "Logout";
            this.LblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPusatBantuan
            // 
            this.BtnPusatBantuan.BackgroundImage = global::HalamanUtamaDonatur.Properties.Resources.Statistik;
            this.BtnPusatBantuan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPusatBantuan.Location = new System.Drawing.Point(225, 25);
            this.BtnPusatBantuan.Name = "BtnPusatBantuan";
            this.BtnPusatBantuan.Size = new System.Drawing.Size(130, 131);
            this.BtnPusatBantuan.TabIndex = 27;
            this.BtnPusatBantuan.UseVisualStyleBackColor = true;
            this.BtnPusatBantuan.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEditAkun
            // 
            this.BtnEditAkun.BackgroundImage = global::HalamanUtamaDonatur.Properties.Resources.Edit;
            this.BtnEditAkun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditAkun.Location = new System.Drawing.Point(40, 25);
            this.BtnEditAkun.Name = "BtnEditAkun";
            this.BtnEditAkun.Size = new System.Drawing.Size(130, 131);
            this.BtnEditAkun.TabIndex = 28;
            this.BtnEditAkun.Click += new System.EventHandler(this.BtnEditAkun_Click);
            // 
            // LblBantuan
            // 
            this.LblBantuan.BackColor = System.Drawing.SystemColors.Control;
            this.LblBantuan.Location = new System.Drawing.Point(225, 158);
            this.LblBantuan.Name = "LblBantuan";
            this.LblBantuan.Size = new System.Drawing.Size(130, 31);
            this.LblBantuan.TabIndex = 26;
            this.LblBantuan.Text = "Pusat Bantuan";
            this.LblBantuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEditAkun
            // 
            this.LblEditAkun.BackColor = System.Drawing.SystemColors.Control;
            this.LblEditAkun.Location = new System.Drawing.Point(39, 158);
            this.LblEditAkun.Name = "LblEditAkun";
            this.LblEditAkun.Size = new System.Drawing.Size(130, 31);
            this.LblEditAkun.TabIndex = 25;
            this.LblEditAkun.Text = "Edit Akun";
            this.LblEditAkun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HalamanUtamaDonatur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 457);
            this.Controls.Add(this.Donatur);
            this.Name = "HalamanUtamaDonatur";
            this.Text = "Form1";
            this.Donatur.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl Donatur;
        private System.Windows.Forms.Button BtnAktivitasDonatur;
        private System.Windows.Forms.Label LblAktivitasFoodshelter;
        private System.Windows.Forms.Label LblTambahAktivitas;
        private System.Windows.Forms.Button BtnTambahAktivitas;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label LblLogout;
        private System.Windows.Forms.Button BtnPusatBantuan;
        private System.Windows.Forms.Button BtnEditAkun;
        private System.Windows.Forms.Label LblBantuan;
        private System.Windows.Forms.Label LblEditAkun;
    }
}

