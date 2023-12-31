namespace Perpustakaan_IF19C.GUI
{
    partial class FPeminjaman
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtIDPeminjaman = new System.Windows.Forms.TextBox();
            this.DtpTanggalPengembalian = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpTanggalPeminjaman = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBrowseMahasiswa = new System.Windows.Forms.Button();
            this.TxtJurusan = new System.Windows.Forms.TextBox();
            this.TxtNamaMahasiswa = new System.Windows.Forms.TextBox();
            this.TxtIDMahasiswa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnBrowserPetugas = new System.Windows.Forms.Button();
            this.TxtNamaPetugas = new System.Windows.Forms.TextBox();
            this.TxtIDPetugas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnTambah = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TxtBukudiPinjam = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Txtstok = new System.Windows.Forms.TextBox();
            this.TxtJudulBuku = new System.Windows.Forms.TextBox();
            this.TxtIDBuku = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DataGridPeminjaman = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPeminjaman)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtIDPeminjaman);
            this.groupBox1.Controls.Add(this.DtpTanggalPengembalian);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpTanggalPeminjaman);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peminjaman";
            // 
            // TxtIDPeminjaman
            // 
            this.TxtIDPeminjaman.Location = new System.Drawing.Point(173, 38);
            this.TxtIDPeminjaman.Name = "TxtIDPeminjaman";
            this.TxtIDPeminjaman.Size = new System.Drawing.Size(235, 26);
            this.TxtIDPeminjaman.TabIndex = 27;
            // 
            // DtpTanggalPengembalian
            // 
            this.DtpTanggalPengembalian.CustomFormat = "MM/dd/yyyy";
            this.DtpTanggalPengembalian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTanggalPengembalian.Location = new System.Drawing.Point(173, 117);
            this.DtpTanggalPengembalian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpTanggalPengembalian.Name = "DtpTanggalPengembalian";
            this.DtpTanggalPengembalian.Size = new System.Drawing.Size(235, 26);
            this.DtpTanggalPengembalian.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Kembali";
            // 
            // DtpTanggalPeminjaman
            // 
            this.DtpTanggalPeminjaman.CustomFormat = "MM/dd/yyyy";
            this.DtpTanggalPeminjaman.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTanggalPeminjaman.Location = new System.Drawing.Point(173, 74);
            this.DtpTanggalPeminjaman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpTanggalPeminjaman.Name = "DtpTanggalPeminjaman";
            this.DtpTanggalPeminjaman.Size = new System.Drawing.Size(235, 26);
            this.DtpTanggalPeminjaman.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Pinjam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Peminjaman";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBrowseMahasiswa);
            this.groupBox2.Controls.Add(this.TxtJurusan);
            this.groupBox2.Controls.Add(this.TxtNamaMahasiswa);
            this.groupBox2.Controls.Add(this.TxtIDMahasiswa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(2, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 153);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mahasiswa";
            // 
            // BtnBrowseMahasiswa
            // 
            this.BtnBrowseMahasiswa.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_search_black_18dp;
            this.BtnBrowseMahasiswa.Location = new System.Drawing.Point(415, 32);
            this.BtnBrowseMahasiswa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBrowseMahasiswa.Name = "BtnBrowseMahasiswa";
            this.BtnBrowseMahasiswa.Size = new System.Drawing.Size(47, 30);
            this.BtnBrowseMahasiswa.TabIndex = 27;
            this.BtnBrowseMahasiswa.UseVisualStyleBackColor = true;
            this.BtnBrowseMahasiswa.Click += new System.EventHandler(this.BtnBrowseMahasiswa_Click);
            // 
            // TxtJurusan
            // 
            this.TxtJurusan.Location = new System.Drawing.Point(173, 111);
            this.TxtJurusan.Name = "TxtJurusan";
            this.TxtJurusan.Size = new System.Drawing.Size(235, 26);
            this.TxtJurusan.TabIndex = 26;
            // 
            // TxtNamaMahasiswa
            // 
            this.TxtNamaMahasiswa.Location = new System.Drawing.Point(173, 72);
            this.TxtNamaMahasiswa.Name = "TxtNamaMahasiswa";
            this.TxtNamaMahasiswa.Size = new System.Drawing.Size(235, 26);
            this.TxtNamaMahasiswa.TabIndex = 25;
            // 
            // TxtIDMahasiswa
            // 
            this.TxtIDMahasiswa.Location = new System.Drawing.Point(173, 34);
            this.TxtIDMahasiswa.Name = "TxtIDMahasiswa";
            this.TxtIDMahasiswa.Size = new System.Drawing.Size(235, 26);
            this.TxtIDMahasiswa.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Jurusan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nama Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID Mahasiswa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnBrowserPetugas);
            this.groupBox3.Controls.Add(this.TxtNamaPetugas);
            this.groupBox3.Controls.Add(this.TxtIDPetugas);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(2, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 116);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Petugas";
            // 
            // BtnBrowserPetugas
            // 
            this.BtnBrowserPetugas.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_search_black_18dp;
            this.BtnBrowserPetugas.Location = new System.Drawing.Point(415, 32);
            this.BtnBrowserPetugas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBrowserPetugas.Name = "BtnBrowserPetugas";
            this.BtnBrowserPetugas.Size = new System.Drawing.Size(47, 30);
            this.BtnBrowserPetugas.TabIndex = 28;
            this.BtnBrowserPetugas.UseVisualStyleBackColor = true;
            this.BtnBrowserPetugas.Click += new System.EventHandler(this.BtnBrowserPetugas_Click);
            // 
            // TxtNamaPetugas
            // 
            this.TxtNamaPetugas.Location = new System.Drawing.Point(173, 72);
            this.TxtNamaPetugas.Name = "TxtNamaPetugas";
            this.TxtNamaPetugas.Size = new System.Drawing.Size(235, 26);
            this.TxtNamaPetugas.TabIndex = 25;
            // 
            // TxtIDPetugas
            // 
            this.TxtIDPetugas.Location = new System.Drawing.Point(173, 34);
            this.TxtIDPetugas.Name = "TxtIDPetugas";
            this.TxtIDPetugas.Size = new System.Drawing.Size(235, 26);
            this.TxtIDPetugas.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nama Petugas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID Petugas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnHapus);
            this.groupBox4.Controls.Add(this.BtnTambah);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.TxtBukudiPinjam);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.Txtstok);
            this.groupBox4.Controls.Add(this.TxtJudulBuku);
            this.groupBox4.Controls.Add(this.TxtIDBuku);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(2, 455);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(481, 198);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buku";
            // 
            // BtnHapus
            // 
            this.BtnHapus.Image = global::Perpustakaan_IF19C.Properties.Resources.outline_clear_black_24dp;
            this.BtnHapus.Location = new System.Drawing.Point(415, 144);
            this.BtnHapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(47, 34);
            this.BtnHapus.TabIndex = 30;
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnTambah
            // 
            this.BtnTambah.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_control_point_black_18dp;
            this.BtnTambah.Location = new System.Drawing.Point(415, 97);
            this.BtnTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTambah.Name = "BtnTambah";
            this.BtnTambah.Size = new System.Drawing.Size(49, 37);
            this.BtnTambah.TabIndex = 29;
            this.BtnTambah.UseVisualStyleBackColor = true;
            this.BtnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Perpustakaan_IF19C.Properties.Resources.baseline_search_black_18dp;
            this.button2.Location = new System.Drawing.Point(415, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 30);
            this.button2.TabIndex = 29;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnBrowseBuku_Click);
            // 
            // TxtBukudiPinjam
            // 
            this.TxtBukudiPinjam.Location = new System.Drawing.Point(173, 148);
            this.TxtBukudiPinjam.Name = "TxtBukudiPinjam";
            this.TxtBukudiPinjam.Size = new System.Drawing.Size(235, 26);
            this.TxtBukudiPinjam.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Buku di Pinjam";
            // 
            // Txtstok
            // 
            this.Txtstok.Location = new System.Drawing.Point(173, 111);
            this.Txtstok.Name = "Txtstok";
            this.Txtstok.Size = new System.Drawing.Size(235, 26);
            this.Txtstok.TabIndex = 26;
            // 
            // TxtJudulBuku
            // 
            this.TxtJudulBuku.Location = new System.Drawing.Point(173, 72);
            this.TxtJudulBuku.Name = "TxtJudulBuku";
            this.TxtJudulBuku.Size = new System.Drawing.Size(235, 26);
            this.TxtJudulBuku.TabIndex = 25;
            // 
            // TxtIDBuku
            // 
            this.TxtIDBuku.Location = new System.Drawing.Point(173, 34);
            this.TxtIDBuku.Name = "TxtIDBuku";
            this.TxtIDBuku.Size = new System.Drawing.Size(235, 26);
            this.TxtIDBuku.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Stok";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Judul Buku";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "ID Buku";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DataGridPeminjaman);
            this.groupBox5.Location = new System.Drawing.Point(489, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(778, 488);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detail Peminjaman";
            // 
            // DataGridPeminjaman
            // 
            this.DataGridPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPeminjaman.Location = new System.Drawing.Point(6, 25);
            this.DataGridPeminjaman.Name = "DataGridPeminjaman";
            this.DataGridPeminjaman.RowTemplate.Height = 28;
            this.DataGridPeminjaman.Size = new System.Drawing.Size(764, 456);
            this.DataGridPeminjaman.TabIndex = 0;
            this.DataGridPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridPeminjaman_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnKeluar);
            this.panel1.Controls.Add(this.BtnSimpan);
            this.panel1.Controls.Add(this.BtnBaru);
            this.panel1.Location = new System.Drawing.Point(530, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 72);
            this.panel1.TabIndex = 1;
            // 
            // BtnKeluar
            // 
            this.BtnKeluar.Image = global::Perpustakaan_IF19C.Properties.Resources.exit32;
            this.BtnKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnKeluar.Location = new System.Drawing.Point(546, 6);
            this.BtnKeluar.Name = "BtnKeluar";
            this.BtnKeluar.Size = new System.Drawing.Size(132, 58);
            this.BtnKeluar.TabIndex = 2;
            this.BtnKeluar.Text = "&Keluar";
            this.BtnKeluar.UseVisualStyleBackColor = true;
            this.BtnKeluar.Click += new System.EventHandler(this.BtnKeluar_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Image = global::Perpustakaan_IF19C.Properties.Resources.save32;
            this.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSimpan.Location = new System.Drawing.Point(287, 6);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(131, 58);
            this.BtnSimpan.TabIndex = 1;
            this.BtnSimpan.Text = "&Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnBaru
            // 
            this.BtnBaru.Image = global::Perpustakaan_IF19C.Properties.Resources.edit32;
            this.BtnBaru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBaru.Location = new System.Drawing.Point(18, 6);
            this.BtnBaru.Name = "BtnBaru";
            this.BtnBaru.Size = new System.Drawing.Size(127, 58);
            this.BtnBaru.TabIndex = 0;
            this.BtnBaru.Text = "&Baru";
            this.BtnBaru.UseVisualStyleBackColor = true;
            this.BtnBaru.Click += new System.EventHandler(this.BtnBaru_Click);
            // 
            // FPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1307, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FPeminjaman";
            this.Text = "FPeminjaman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPeminjaman)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpTanggalPeminjaman;
        private System.Windows.Forms.DateTimePicker DtpTanggalPengembalian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtJurusan;
        private System.Windows.Forms.TextBox TxtNamaMahasiswa;
        private System.Windows.Forms.TextBox TxtIDMahasiswa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtNamaPetugas;
        private System.Windows.Forms.TextBox TxtIDPetugas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtBukudiPinjam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txtstok;
        private System.Windows.Forms.TextBox TxtJudulBuku;
        private System.Windows.Forms.TextBox TxtIDBuku;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBaru;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnBrowseMahasiswa;
        private System.Windows.Forms.Button BtnBrowserPetugas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnTambah;
        private System.Windows.Forms.Button BtnHapus;
        public System.Windows.Forms.DataGridView DataGridPeminjaman;
        public System.Windows.Forms.TextBox TxtIDPeminjaman;
    }
}