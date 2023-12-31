namespace Perpustakaan_IF19C.GUI
{
    partial class FBuku
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid_buku = new System.Windows.Forms.TextBox();
            this.txtjudul_buku = new System.Windows.Forms.TextBox();
            this.txtpenulis = new System.Windows.Forms.TextBox();
            this.txtpenerbit = new System.Windows.Forms.TextBox();
            this.txttahun = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtcaribuku = new System.Windows.Forms.TextBox();
            this.ListBuku = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnKeluar = new System.Windows.Forms.Button();
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnBaru = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBuku)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ":: Input Data Buku ::";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(594, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 422);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ":: List Data Buku ::";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(3, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = ":: List Data Buku ::";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "id_buku";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "judul_buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "penulis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "penerbit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "tahun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "stok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cari Judul Buku";
            // 
            // txtid_buku
            // 
            this.txtid_buku.Location = new System.Drawing.Point(150, 57);
            this.txtid_buku.Name = "txtid_buku";
            this.txtid_buku.Size = new System.Drawing.Size(381, 39);
            this.txtid_buku.TabIndex = 9;
            this.txtid_buku.Text = "TxtIDBuku";
            // 
            // txtjudul_buku
            // 
            this.txtjudul_buku.Location = new System.Drawing.Point(151, 113);
            this.txtjudul_buku.Name = "txtjudul_buku";
            this.txtjudul_buku.Size = new System.Drawing.Size(381, 39);
            this.txtjudul_buku.TabIndex = 10;
            this.txtjudul_buku.Text = "TxtJudulBuku";
            // 
            // txtpenulis
            // 
            this.txtpenulis.Location = new System.Drawing.Point(150, 171);
            this.txtpenulis.Name = "txtpenulis";
            this.txtpenulis.Size = new System.Drawing.Size(381, 39);
            this.txtpenulis.TabIndex = 11;
            this.txtpenulis.Text = "TxtPenulis";
            // 
            // txtpenerbit
            // 
            this.txtpenerbit.Location = new System.Drawing.Point(150, 226);
            this.txtpenerbit.Name = "txtpenerbit";
            this.txtpenerbit.Size = new System.Drawing.Size(381, 39);
            this.txtpenerbit.TabIndex = 12;
            this.txtpenerbit.Text = "TxtPenerbit";
            // 
            // txttahun
            // 
            this.txttahun.Location = new System.Drawing.Point(151, 286);
            this.txttahun.Name = "txttahun";
            this.txttahun.Size = new System.Drawing.Size(381, 39);
            this.txttahun.TabIndex = 13;
            this.txttahun.Text = "TxtTahun";
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(150, 343);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(381, 39);
            this.txtstok.TabIndex = 14;
            this.txtstok.Text = "TxtStok";
            // 
            // txtcaribuku
            // 
            this.txtcaribuku.Location = new System.Drawing.Point(812, 343);
            this.txtcaribuku.Name = "txtcaribuku";
            this.txtcaribuku.Size = new System.Drawing.Size(381, 39);
            this.txtcaribuku.TabIndex = 15;
            this.txtcaribuku.Text = "TxtCariBuku";
            this.txtcaribuku.TextChanged += new System.EventHandler(this.txtcaribuku_TextChanged);
            // 
            // ListBuku
            // 
            this.ListBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBuku.Location = new System.Drawing.Point(604, 35);
            this.ListBuku.Name = "ListBuku";
            this.ListBuku.RowTemplate.Height = 28;
            this.ListBuku.Size = new System.Drawing.Size(589, 283);
            this.ListBuku.TabIndex = 16;
            this.ListBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBuku_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSimpan);
            this.panel2.Location = new System.Drawing.Point(353, 428);
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
            this.panel1.Location = new System.Drawing.Point(12, 428);
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
            // FBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ListBuku);
            this.Controls.Add(this.txtcaribuku);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txttahun);
            this.Controls.Add(this.txtpenerbit);
            this.Controls.Add(this.txtpenulis);
            this.Controls.Add(this.txtjudul_buku);
            this.Controls.Add(this.txtid_buku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FBuku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Data Buku ::";
            this.Load += new System.EventHandler(this.FBuku_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBuku)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid_buku;
        private System.Windows.Forms.TextBox txtjudul_buku;
        private System.Windows.Forms.TextBox txtpenulis;
        private System.Windows.Forms.TextBox txtpenerbit;
        private System.Windows.Forms.TextBox txttahun;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtcaribuku;
        private System.Windows.Forms.DataGridView ListBuku;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnKeluar;
        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnBaru;
    }
}