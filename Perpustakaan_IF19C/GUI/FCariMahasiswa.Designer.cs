namespace Perpustakaan_IF19C.GUI
{
    partial class FCariMahasiswa
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
            this.DataGridCariMahasiswa = new System.Windows.Forms.DataGridView();
            this.TxtCariMahasiswa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridCariMahasiswa);
            this.groupBox1.Controls.Add(this.TxtCariMahasiswa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 529);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Data Mahasiswa ::.";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DataGridCariMahasiswa
            // 
            this.DataGridCariMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCariMahasiswa.Location = new System.Drawing.Point(12, 110);
            this.DataGridCariMahasiswa.Name = "DataGridCariMahasiswa";
            this.DataGridCariMahasiswa.RowTemplate.Height = 28;
            this.DataGridCariMahasiswa.Size = new System.Drawing.Size(1173, 411);
            this.DataGridCariMahasiswa.TabIndex = 2;
            this.DataGridCariMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCariMahasiswa_CellClick);
            // 
            // TxtCariMahasiswa
            // 
            this.TxtCariMahasiswa.Location = new System.Drawing.Point(11, 70);
            this.TxtCariMahasiswa.Name = "TxtCariMahasiswa";
            this.TxtCariMahasiswa.Size = new System.Drawing.Size(1174, 26);
            this.TxtCariMahasiswa.TabIndex = 1;
            this.TxtCariMahasiswa.TextChanged += new System.EventHandler(this.TxtCariMahasiswa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan ID/Nama Mahasiswa :";
            // 
            // FCariMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 533);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCariMahasiswa";
            this.Text = "FCariMahasiswa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariMahasiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridCariMahasiswa;
        private System.Windows.Forms.TextBox TxtCariMahasiswa;
        private System.Windows.Forms.Label label1;
    }
}