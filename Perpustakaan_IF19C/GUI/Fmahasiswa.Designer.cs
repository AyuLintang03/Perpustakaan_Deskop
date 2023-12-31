namespace Perpustakaan_IF19C.GUI
{
    partial class Fmahasiswa
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
            this.TxtCariMahasiswa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListMahasiswa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdjk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNomerTelepon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtJurusan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAlamatMahasiswa = new System.Windows.Forms.TextBox();
            this.TxtNamaMahasiswa = new System.Windows.Forms.TextBox();
            this.TxtIDMahasiswa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListMahasiswa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCariMahasiswa
            // 
            this.TxtCariMahasiswa.Location = new System.Drawing.Point(801, 435);
            this.TxtCariMahasiswa.Name = "TxtCariMahasiswa";
            this.TxtCariMahasiswa.Size = new System.Drawing.Size(368, 26);
            this.TxtCariMahasiswa.TabIndex = 22;
            this.TxtCariMahasiswa.Text = "TxtCariMahasiswa";
            this.TxtCariMahasiswa.Click += new System.EventHandler(this.TxtCariMahasiswa_TextChanged);
            this.TxtCariMahasiswa.TextChanged += new System.EventHandler(this.TxtCariMahasiswa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cari Nama Mahasiswa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListMahasiswa);
            this.groupBox2.Location = new System.Drawing.Point(624, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 399);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ".:: List Data Mahasiswa::.";
            // 
            // ListMahasiswa
            // 
            this.ListMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListMahasiswa.Location = new System.Drawing.Point(11, 38);
            this.ListMahasiswa.Name = "ListMahasiswa";
            this.ListMahasiswa.RowTemplate.Height = 28;
            this.ListMahasiswa.Size = new System.Drawing.Size(671, 341);
            this.ListMahasiswa.TabIndex = 19;
            this.ListMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListMahasiswa_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdjk);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNomerTelepon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtJurusan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtAlamatMahasiswa);
            this.groupBox1.Controls.Add(this.TxtNamaMahasiswa);
            this.groupBox1.Controls.Add(this.TxtIDMahasiswa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 444);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Input Data Mahasiswa ::.";
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
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // TxtJurusan
            // 
            this.TxtJurusan.Location = new System.Drawing.Point(216, 142);
            this.TxtJurusan.Name = "TxtJurusan";
            this.TxtJurusan.Size = new System.Drawing.Size(368, 26);
            this.TxtJurusan.TabIndex = 14;
            this.TxtJurusan.Text = "TxtJurusan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jurusan";
            // 
            // TxtAlamatMahasiswa
            // 
            this.TxtAlamatMahasiswa.Location = new System.Drawing.Point(211, 285);
            this.TxtAlamatMahasiswa.Multiline = true;
            this.TxtAlamatMahasiswa.Name = "TxtAlamatMahasiswa";
            this.TxtAlamatMahasiswa.Size = new System.Drawing.Size(368, 148);
            this.TxtAlamatMahasiswa.TabIndex = 12;
            this.TxtAlamatMahasiswa.Text = "TxtAlamatMahasiswa";
            // 
            // TxtNamaMahasiswa
            // 
            this.TxtNamaMahasiswa.Location = new System.Drawing.Point(216, 96);
            this.TxtNamaMahasiswa.Name = "TxtNamaMahasiswa";
            this.TxtNamaMahasiswa.Size = new System.Drawing.Size(368, 26);
            this.TxtNamaMahasiswa.TabIndex = 11;
            this.TxtNamaMahasiswa.Text = "TxtNamaMahasiswa";
            // 
            // TxtIDMahasiswa
            // 
            this.TxtIDMahasiswa.Location = new System.Drawing.Point(216, 50);
            this.TxtIDMahasiswa.Name = "TxtIDMahasiswa";
            this.TxtIDMahasiswa.Size = new System.Drawing.Size(333, 26);
            this.TxtIDMahasiswa.TabIndex = 10;
            this.TxtIDMahasiswa.Text = "TxtIDMahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Mahasiswa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSimpan);
            this.panel2.Location = new System.Drawing.Point(352, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 171);
            this.panel2.TabIndex = 32;
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
            this.panel1.Controls.Add(this.BtnKeluar);
            this.panel1.Controls.Add(this.BtnHapus);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(11, 469);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 171);
            this.panel1.TabIndex = 31;
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
            // BtnHapus
            // 
            this.BtnHapus.Image = global::Perpustakaan_IF19C.Properties.Resources.outline_clear_black_24dp1;
            this.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHapus.Location = new System.Drawing.Point(11, 90);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(133, 61);
            this.BtnHapus.TabIndex = 2;
            this.BtnHapus.Text = "&Hapus";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_assignment_white_18dp;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(161, 12);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(133, 61);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "&Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
            // Fmahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCariMahasiswa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Fmahasiswa";
            this.Text = "Fmahasiswa";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListMahasiswa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCariMahasiswa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView ListMahasiswa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAlamatMahasiswa;
        private System.Windows.Forms.TextBox TxtNamaMahasiswa;
        private System.Windows.Forms.TextBox TxtIDMahasiswa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdjk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNomerTelepon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtJurusan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnBaru;
    }
}