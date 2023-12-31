namespace Perpustakaan_IF19C.GUI
{
    partial class FPetugas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.Btnedit = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.TxtCariPetugas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListCariPetugas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdjk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNomerTelepon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtJabatan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAlamatPetugas = new System.Windows.Forms.TextBox();
            this.TxtNamaPetugas = new System.Windows.Forms.TextBox();
            this.TxtIDPetugas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCariPetugas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSimpan);
            this.panel2.Location = new System.Drawing.Point(362, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 171);
            this.panel2.TabIndex = 30;
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Image = global::Perpustakaan_IF19C.Properties.Resources.save32;
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(30, 53);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(164, 73);
            this.BtnSimpan.TabIndex = 3;
            this.BtnSimpan.Text = "&Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnHapus);
            this.panel1.Controls.Add(this.BtnKeluar);
            this.panel1.Controls.Add(this.Btnedit);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(21, 487);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 171);
            this.panel1.TabIndex = 29;
            // 
            // BtnHapus
            // 
            this.BtnHapus.Image = global::Perpustakaan_IF19C.Properties.Resources.outline_clear_black_24dp1;
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(11, 90);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(133, 61);
            this.BtnHapus.TabIndex = 4;
            this.BtnHapus.Text = "&Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Image = global::Perpustakaan_IF19C.Properties.Resources.enter32;
            this.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Location = new System.Drawing.Point(161, 90);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(133, 61);
            this.BtnKeluar.TabIndex = 3;
            this.BtnKeluar.Text = "&Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // Btnedit
            // 
            this.Btnedit.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_assignment_white_18dp;
            this.Btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnedit.Location = new System.Drawing.Point(161, 12);
            this.Btnedit.Name = "Btnedit";
            this.Btnedit.Size = new System.Drawing.Size(133, 61);
            this.Btnedit.TabIndex = 1;
            this.Btnedit.Text = "&Edit";
            this.Btnedit.UseVisualStyleBackColor = true;
            this.Btnedit.Click += new System.EventHandler(this.Btnedit_Click);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_add_black_18dp;
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(11, 12);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(133, 61);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "&Baru";
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // TxtCariPetugas
            // 
            this.TxtCariPetugas.Location = new System.Drawing.Point(879, 437);
            this.TxtCariPetugas.Name = "TxtCariPetugas";
            this.TxtCariPetugas.Size = new System.Drawing.Size(368, 26);
            this.TxtCariPetugas.TabIndex = 28;
            this.TxtCariPetugas.Text = "TxtCariPetugas";
            this.TxtCariPetugas.Click += new System.EventHandler(this.TxtCariPetugas_TextChanged);
            this.TxtCariPetugas.TextChanged += new System.EventHandler(this.TxtCariPetugas_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cari Nama Petugas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListCariPetugas);
            this.groupBox2.Location = new System.Drawing.Point(624, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 399);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".:: List Data Petugas::.";
            // 
            // ListCariPetugas
            // 
            this.ListCariPetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCariPetugas.Location = new System.Drawing.Point(11, 38);
            this.ListCariPetugas.Name = "ListCariPetugas";
            this.ListCariPetugas.RowTemplate.Height = 28;
            this.ListCariPetugas.Size = new System.Drawing.Size(671, 341);
            this.ListCariPetugas.TabIndex = 19;
            this.ListCariPetugas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCariPetugas_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdjk);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNomerTelepon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtJabatan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAlamatPetugas);
            this.groupBox1.Controls.Add(this.TxtNamaPetugas);
            this.groupBox1.Controls.Add(this.TxtIDPetugas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 444);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Input Data Petugas ::.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdjk
            // 
            this.cmdjk.FormattingEnabled = true;
            this.cmdjk.Items.AddRange(new object[] {
            "P",
            "L"});
            this.cmdjk.Location = new System.Drawing.Point(216, 231);
            this.cmdjk.Name = "cmdjk";
            this.cmdjk.Size = new System.Drawing.Size(198, 28);
            this.cmdjk.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Jenis Kelamin";
            // 
            // TxtNomerTelepon
            // 
            this.TxtNomerTelepon.Location = new System.Drawing.Point(216, 185);
            this.TxtNomerTelepon.Name = "TxtNomerTelepon";
            this.TxtNomerTelepon.Size = new System.Drawing.Size(368, 26);
            this.TxtNomerTelepon.TabIndex = 16;
            this.TxtNomerTelepon.Text = "TxtNomorTelepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nomer Telepon";
            // 
            // TxtJabatan
            // 
            this.TxtJabatan.Location = new System.Drawing.Point(216, 142);
            this.TxtJabatan.Name = "TxtJabatan";
            this.TxtJabatan.Size = new System.Drawing.Size(368, 26);
            this.TxtJabatan.TabIndex = 14;
            this.TxtJabatan.Text = "TxtJabatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jabatan";
            // 
            // TxtAlamatPetugas
            // 
            this.TxtAlamatPetugas.Location = new System.Drawing.Point(211, 285);
            this.TxtAlamatPetugas.Multiline = true;
            this.TxtAlamatPetugas.Name = "TxtAlamatPetugas";
            this.TxtAlamatPetugas.Size = new System.Drawing.Size(368, 148);
            this.TxtAlamatPetugas.TabIndex = 12;
            this.TxtAlamatPetugas.Text = "TxtAlamatPetugas";
            // 
            // TxtNamaPetugas
            // 
            this.TxtNamaPetugas.Location = new System.Drawing.Point(216, 96);
            this.TxtNamaPetugas.Name = "TxtNamaPetugas";
            this.TxtNamaPetugas.Size = new System.Drawing.Size(368, 26);
            this.TxtNamaPetugas.TabIndex = 11;
            this.TxtNamaPetugas.Text = "TxtNamaPetugas";
            // 
            // TxtIDPetugas
            // 
            this.TxtIDPetugas.Location = new System.Drawing.Point(216, 50);
            this.TxtIDPetugas.Name = "TxtIDPetugas";
            this.TxtIDPetugas.Size = new System.Drawing.Size(333, 26);
            this.TxtIDPetugas.TabIndex = 10;
            this.TxtIDPetugas.Text = "TxtIDPetugas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat Petugas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Petugas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Petugas";
            // 
            // FPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCariPetugas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FPetugas";
            this.Text = "FPetugas";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListCariPetugas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button Btnedit;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.TextBox TxtCariPetugas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ListCariPetugas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmdjk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNomerTelepon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtJabatan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAlamatPetugas;
        private System.Windows.Forms.TextBox TxtNamaPetugas;
        private System.Windows.Forms.TextBox TxtIDPetugas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHapus;

    }
}