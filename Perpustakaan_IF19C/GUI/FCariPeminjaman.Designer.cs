namespace Perpustakaan_IF19C.GUI
{
    partial class FCariPeminjaman
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
            this.DataGridCariPeminjaman = new System.Windows.Forms.DataGridView();
            this.TxtCariPeminjaman = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariPeminjaman)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridCariPeminjaman);
            this.groupBox1.Controls.Add(this.TxtCariPeminjaman);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 529);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Data Peminjaman Buku ::.";
            // 
            // DataGridCariPeminjaman
            // 
            this.DataGridCariPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCariPeminjaman.Location = new System.Drawing.Point(12, 110);
            this.DataGridCariPeminjaman.Name = "DataGridCariPeminjaman";
            this.DataGridCariPeminjaman.RowTemplate.Height = 28;
            this.DataGridCariPeminjaman.Size = new System.Drawing.Size(1173, 411);
            this.DataGridCariPeminjaman.TabIndex = 2;
            this.DataGridCariPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCariPeminjaman_CellClick);
            // 
            // TxtCariPeminjaman
            // 
            this.TxtCariPeminjaman.Location = new System.Drawing.Point(11, 70);
            this.TxtCariPeminjaman.Name = "TxtCariPeminjaman";
            this.TxtCariPeminjaman.Size = new System.Drawing.Size(1174, 26);
            this.TxtCariPeminjaman.TabIndex = 1;
            this.TxtCariPeminjaman.TextChanged += new System.EventHandler(this.TxtCariPeminjaman_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan ID Peminjaman :";
            // 
            // FCariPeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 540);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCariPeminjaman";
            this.Text = "FCariPeminjaman";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariPeminjaman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridCariPeminjaman;
        private System.Windows.Forms.TextBox TxtCariPeminjaman;
        private System.Windows.Forms.Label label1;
    }
}