namespace Perpustakaan_IF19C.GUI
{
    partial class FMenuUtama
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
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_petugas = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_mahasiswa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBuku = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_buku = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_peminjaman = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pengembalian = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_about = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolMahasiswa = new System.Windows.Forms.ToolStripButton();
            this.ToolBuku = new System.Windows.Forms.ToolStripButton();
            this.ToolPeminjaman = new System.Windows.Forms.ToolStripButton();
            this.ToolExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolPengembalian = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Submenu_login,
            this.submenu_logout,
            this.submenu_exit});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(50, 29);
            this.MenuFile.Text = "&File";
            this.MenuFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Submenu_login
            // 
            this.Submenu_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Submenu_login.Image = global::Perpustakaan_IF19C.Properties.Resources.Login;
            this.Submenu_login.Name = "Submenu_login";
            this.Submenu_login.Size = new System.Drawing.Size(153, 30);
            this.Submenu_login.Text = "Login";
            this.Submenu_login.Click += new System.EventHandler(this.Submenu_login_Click);
            // 
            // submenu_logout
            // 
            this.submenu_logout.Image = global::Perpustakaan_IF19C.Properties.Resources.Logout;
            this.submenu_logout.Name = "submenu_logout";
            this.submenu_logout.Size = new System.Drawing.Size(153, 30);
            this.submenu_logout.Text = "Logout";
            this.submenu_logout.Click += new System.EventHandler(this.submenu_logout_Click);
            // 
            // submenu_exit
            // 
            this.submenu_exit.Image = global::Perpustakaan_IF19C.Properties.Resources.Exit;
            this.submenu_exit.Name = "submenu_exit";
            this.submenu_exit.Size = new System.Drawing.Size(153, 30);
            this.submenu_exit.Text = "Exit";
            this.submenu_exit.Click += new System.EventHandler(this.submenu_exit_Click);
            // 
            // MenuMaster
            // 
            this.MenuMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_petugas,
            this.submenu_mahasiswa});
            this.MenuMaster.Name = "MenuMaster";
            this.MenuMaster.Size = new System.Drawing.Size(78, 29);
            this.MenuMaster.Text = "&Master";
            // 
            // submenu_petugas
            // 
            this.submenu_petugas.Image = global::Perpustakaan_IF19C.Properties.Resources.admin32;
            this.submenu_petugas.Name = "submenu_petugas";
            this.submenu_petugas.Size = new System.Drawing.Size(210, 30);
            this.submenu_petugas.Text = "Petugas";
            this.submenu_petugas.Click += new System.EventHandler(this.submenu_Petugas_Click);
            // 
            // submenu_mahasiswa
            // 
            this.submenu_mahasiswa.Image = global::Perpustakaan_IF19C.Properties.Resources.boy16;
            this.submenu_mahasiswa.Name = "submenu_mahasiswa";
            this.submenu_mahasiswa.Size = new System.Drawing.Size(210, 30);
            this.submenu_mahasiswa.Text = "Mahasiswa";
            this.submenu_mahasiswa.Click += new System.EventHandler(this.submenu_mahasiswa_Click);
            // 
            // MenuBuku
            // 
            this.MenuBuku.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_buku,
            this.submenu_peminjaman,
            this.submenu_pengembalian});
            this.MenuBuku.Name = "MenuBuku";
            this.MenuBuku.Size = new System.Drawing.Size(63, 29);
            this.MenuBuku.Text = "&Buku";
            this.MenuBuku.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // submenu_buku
            // 
            this.submenu_buku.Image = global::Perpustakaan_IF19C.Properties.Resources.Book;
            this.submenu_buku.Name = "submenu_buku";
            this.submenu_buku.Size = new System.Drawing.Size(210, 30);
            this.submenu_buku.Text = "Buku";
            this.submenu_buku.Click += new System.EventHandler(this.submenu_Buku_Click);
            // 
            // submenu_peminjaman
            // 
            this.submenu_peminjaman.Image = global::Perpustakaan_IF19C.Properties.Resources.new16;
            this.submenu_peminjaman.Name = "submenu_peminjaman";
            this.submenu_peminjaman.Size = new System.Drawing.Size(210, 30);
            this.submenu_peminjaman.Text = "Peminjaman";
            this.submenu_peminjaman.Click += new System.EventHandler(this.submenu_peminjaman_Click);
            // 
            // submenu_pengembalian
            // 
            this.submenu_pengembalian.Image = global::Perpustakaan_IF19C.Properties.Resources.new32;
            this.submenu_pengembalian.Name = "submenu_pengembalian";
            this.submenu_pengembalian.Size = new System.Drawing.Size(210, 30);
            this.submenu_pengembalian.Text = "&Pengembalian";
            this.submenu_pengembalian.Click += new System.EventHandler(this.submenu_pengembalian_Click);
            // 
            // MenuTools
            // 
            this.MenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_about});
            this.MenuTools.Name = "MenuTools";
            this.MenuTools.Size = new System.Drawing.Size(65, 29);
            this.MenuTools.Text = "&Tools";
            // 
            // submenu_about
            // 
            this.submenu_about.Image = global::Perpustakaan_IF19C.Properties.Resources.info32;
            this.submenu_about.Name = "submenu_about";
            this.submenu_about.Size = new System.Drawing.Size(146, 30);
            this.submenu_about.Text = "About";
            this.submenu_about.Click += new System.EventHandler(this.submenu_about_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuMaster,
            this.MenuBuku,
            this.MenuTools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ToolMahasiswa
            // 
            this.ToolMahasiswa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolMahasiswa.Image = global::Perpustakaan_IF19C.Properties.Resources.boy64;
            this.ToolMahasiswa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolMahasiswa.Name = "ToolMahasiswa";
            this.ToolMahasiswa.Size = new System.Drawing.Size(28, 28);
            this.ToolMahasiswa.Text = "ToolMahasiswa";
            this.ToolMahasiswa.ToolTipText = "Tampilan data mahasiswa";
            this.ToolMahasiswa.Click += new System.EventHandler(this.ToolMahasiswa_Click);
            // 
            // ToolBuku
            // 
            this.ToolBuku.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBuku.Image = global::Perpustakaan_IF19C.Properties.Resources.Book;
            this.ToolBuku.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBuku.Name = "ToolBuku";
            this.ToolBuku.Size = new System.Drawing.Size(28, 28);
            this.ToolBuku.Text = "toolStripButton1";
            this.ToolBuku.ToolTipText = "Tampilan data buku";
            this.ToolBuku.Click += new System.EventHandler(this.ToolBuku_Click);
            // 
            // ToolPeminjaman
            // 
            this.ToolPeminjaman.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolPeminjaman.Image = global::Perpustakaan_IF19C.Properties.Resources.new32;
            this.ToolPeminjaman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolPeminjaman.Name = "ToolPeminjaman";
            this.ToolPeminjaman.Size = new System.Drawing.Size(28, 28);
            this.ToolPeminjaman.Text = "toolStripButton1";
            this.ToolPeminjaman.ToolTipText = "Tampilan data peminjaman";
            this.ToolPeminjaman.Click += new System.EventHandler(this.ToolPeminjaman_Click);
            // 
            // ToolExit
            // 
            this.ToolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolExit.Image = global::Perpustakaan_IF19C.Properties.Resources.Exit;
            this.ToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolExit.Name = "ToolExit";
            this.ToolExit.Size = new System.Drawing.Size(28, 28);
            this.ToolExit.Text = "toolStripButton1";
            this.ToolExit.ToolTipText = "Keluar Aplikasi";
            this.ToolExit.Click += new System.EventHandler(this.ToolExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolMahasiswa,
            this.ToolBuku,
            this.ToolPeminjaman,
            this.ToolPengembalian,
            this.ToolExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1070, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolPengembalian
            // 
            this.ToolPengembalian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolPengembalian.Image = global::Perpustakaan_IF19C.Properties.Resources.new32;
            this.ToolPengembalian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolPengembalian.Name = "ToolPengembalian";
            this.ToolPengembalian.Size = new System.Drawing.Size(28, 28);
            this.ToolPengembalian.Text = "toolStripButton1";
            this.ToolPengembalian.ToolTipText = "Tampilan data peminjaman";
            this.ToolPengembalian.Click += new System.EventHandler(this.ToolPengembalian_Click);
            // 
            // FMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Perpustakaan_IF19C.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1070, 453);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenuUtama";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::Sistem Informasi Perpustakaan Kampus::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem MenuFile;
        public System.Windows.Forms.ToolStripMenuItem Submenu_login;
        public System.Windows.Forms.ToolStripMenuItem submenu_logout;
        public System.Windows.Forms.ToolStripMenuItem submenu_exit;
        public System.Windows.Forms.ToolStripMenuItem MenuMaster;
        public System.Windows.Forms.ToolStripMenuItem submenu_petugas;
        public System.Windows.Forms.ToolStripMenuItem submenu_mahasiswa;
        public System.Windows.Forms.ToolStripMenuItem MenuBuku;
        public System.Windows.Forms.ToolStripMenuItem submenu_buku;
        public System.Windows.Forms.ToolStripMenuItem submenu_peminjaman;
        public System.Windows.Forms.ToolStripMenuItem MenuTools;
        public System.Windows.Forms.ToolStripMenuItem submenu_about;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripButton ToolMahasiswa;
        public System.Windows.Forms.ToolStripButton ToolBuku;
        public System.Windows.Forms.ToolStripButton ToolPeminjaman;
        public System.Windows.Forms.ToolStripButton ToolExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem submenu_pengembalian;
        public System.Windows.Forms.ToolStripButton ToolPengembalian;

    }
}