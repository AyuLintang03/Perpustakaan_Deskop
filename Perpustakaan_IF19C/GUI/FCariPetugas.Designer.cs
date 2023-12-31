namespace Perpustakaan_IF19C.GUI
{
    partial class FCariPetugas
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
            this.DataGridCariPetugas = new System.Windows.Forms.DataGridView();
            this.TxtCariPetugas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariPetugas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridCariPetugas);
            this.groupBox1.Controls.Add(this.TxtCariPetugas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 465);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".:: Data Petugas ::.";
            // 
            // DataGridCariPetugas
            // 
            this.DataGridCariPetugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCariPetugas.Location = new System.Drawing.Point(0, 116);
            this.DataGridCariPetugas.Name = "DataGridCariPetugas";
            this.DataGridCariPetugas.RowTemplate.Height = 28;
            this.DataGridCariPetugas.Size = new System.Drawing.Size(1041, 343);
            this.DataGridCariPetugas.TabIndex = 2;
            this.DataGridCariPetugas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCariPetugas_CellClick);
            // 
            // TxtCariPetugas
            // 
            this.TxtCariPetugas.Location = new System.Drawing.Point(11, 70);
            this.TxtCariPetugas.Name = "TxtCariPetugas";
            this.TxtCariPetugas.Size = new System.Drawing.Size(1036, 26);
            this.TxtCariPetugas.TabIndex = 1;
            this.TxtCariPetugas.TextChanged += new System.EventHandler(this.TxtCariPetugas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Berdasarkan ID/Nama Petugas :";
            // 
            // FCariPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCariPetugas";
            this.Text = "FCariPetugas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCariPetugas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridCariPetugas;
        private System.Windows.Forms.TextBox TxtCariPetugas;
        private System.Windows.Forms.Label label1;
    }
}