namespace Perpustakaan_IF19C.GUI
{
    partial class FCariBuku
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
            this.DataGridCariBuku = new System.Windows.Forms.DataGridView();
            this.TxtCariBuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridCariBuku);
            this.groupBox1.Controls.Add(this.TxtCariBuku);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 783);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Data Buku ::.";
            // 
            // DataGridCariBuku
            // 
            this.DataGridCariBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCariBuku.Location = new System.Drawing.Point(12, 110);
            this.DataGridCariBuku.Name = "DataGridCariBuku";
            this.DataGridCariBuku.RowTemplate.Height = 28;
            this.DataGridCariBuku.Size = new System.Drawing.Size(820, 667);
            this.DataGridCariBuku.TabIndex = 2;
            this.DataGridCariBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCariBuku_CellClick);
            // 
            // TxtCariBuku
            // 
            this.TxtCariBuku.Location = new System.Drawing.Point(11, 70);
            this.TxtCariBuku.Name = "TxtCariBuku";
            this.TxtCariBuku.Size = new System.Drawing.Size(821, 26);
            this.TxtCariBuku.TabIndex = 1;
            this.TxtCariBuku.TextChanged += new System.EventHandler(this.TxtCariBuku_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan ID/Nama Buku :";
            // 
            // FCariBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 452);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCariBuku";
            this.Text = "FCariBuku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariBuku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridCariBuku;
        private System.Windows.Forms.TextBox TxtCariBuku;
        private System.Windows.Forms.Label label1;

    }
}