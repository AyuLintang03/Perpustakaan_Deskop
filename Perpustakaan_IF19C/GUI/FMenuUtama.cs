using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_IF19C.GUI
{
    public partial class FMenuUtama : Form
    {
        public static FMenuUtama mdiobj;
        FAboutProgrammer aboutprog;
        Fmahasiswa mhs;
        FPetugas pts;
        FBuku bk;
        Fpengembalian pbl;
        FPeminjaman pmn;
        //2. Membuat prosedure event form closed

        void AboutProgrammerClosed(Object sender, FormClosedEventArgs e)
        {
            aboutprog = null;
        }

        void mahasiswaClosed(Object sender, FormClosedEventArgs e)
        {
            mhs = null;
        }
        void PetugasClosed(Object sender, FormClosedEventArgs e)
        {
            pts = null;
        }
        void BukuClosed(Object sender, FormClosedEventArgs e)
        {
            bk = null;
        }
       
        void peminjamanClosed(Object sender, FormClosedEventArgs e)
        {
            pmn = null;
        }

        void pengembalianClosed(Object sender, FormClosedEventArgs e)
        {
            pbl = null;
        }

        public FMenuUtama()
        {
            InitializeComponent();
        }

        private void FMenuUtama_Load(object sender, EventArgs e)
        {
            MenuMaster.Enabled = false;
            MenuBuku.Enabled = false;
            submenu_logout.Enabled = false;
            Submenu_login.Enabled = false;
            ToolBuku.Enabled = false;
            ToolPengembalian.Enabled = false;
            ToolPeminjaman.Enabled = false;
            submenu_mahasiswa.Enabled = false;
            ToolMahasiswa.Enabled = false;

            //Memberikan nilai untuk var mdiobj adalah FmenuUtama
            mdiobj = this;
            //Menampilkan form login
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        private void submenu_Petugas_Click(object sender, EventArgs e)
        {
            if (pts == null)
            {
                pts = new FPetugas();
                pts.MdiParent = this;
                pts.FormClosed += new FormClosedEventHandler(PetugasClosed);
                pts.Show();
            }
            else
            {
                pts.Activate();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void submenu_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Keluar dari Aplikasi Penjualan ?", "Konfimasi",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ToolExit_Click(object sender, EventArgs e)
        {
            //Membuat Kode dari event click pada menu exit
            submenu_exit_Click(sender, e);
        }

        private void submenu_mahasiswa_Click(object sender, EventArgs e)
        {
            if (mhs == null)
            {
               mhs = new Fmahasiswa();
                mhs.MdiParent = this;
                mhs.FormClosed += new FormClosedEventHandler(mahasiswaClosed);
                mhs.Show();
            }
            else
            {
                mhs.Activate();
            }
        }

        private void ToolMahasiswa_Click(object sender, EventArgs e)
        {
            //Memanggil mahasiswa di menu mahasiswa
            submenu_mahasiswa_Click(sender, e);
        }

        private void submenu_Buku_Click(object sender, EventArgs e)
        {
            if (bk == null)
            {
                bk = new FBuku();
                bk.MdiParent = this;
                bk.FormClosed += new FormClosedEventHandler(BukuClosed);
                bk.Show();
            }
            else
            {
                bk.Activate();
            }
        }

        private void ToolBuku_Click(object sender, EventArgs e)
        {
            //Memanggil Buku di menu Buku
            submenu_Buku_Click(sender, e);
        }

        private void submenu_peminjaman_Click(object sender, EventArgs e)
        {
            if (pmn == null)
            {
                pmn = new FPeminjaman();
                pmn.MdiParent = this;
                pmn.FormClosed += new FormClosedEventHandler(peminjamanClosed);
                pmn.Show();
            }
            else
            {
                pmn.Activate();
            }
        }

        private void ToolPeminjaman_Click(object sender, EventArgs e)
        {
            //Memanggil Peminjaman di menu Buku
            submenu_peminjaman_Click(sender, e);
        }

         

        private void submenu_pengembalian_Click(object sender, EventArgs e)
        {
               if (pbl == null)
            {
                pbl = new Fpengembalian();
                pbl.MdiParent = this;
                pbl.FormClosed += new FormClosedEventHandler(pengembalianClosed);
                pbl.Show();
            }
            else
            {
                pbl.Activate();
            }
                }

        private void ToolPengembalian_Click(object sender, EventArgs e)
        {
            submenu_pengembalian_Click(sender, e);
        }

        

        private void submenu_about_Click(object sender, EventArgs e)
        {
            if (aboutprog == null)
            {
                aboutprog = new FAboutProgrammer();
                aboutprog.MdiParent = this;
                aboutprog.FormClosed += new FormClosedEventHandler(AboutProgrammerClosed);
                aboutprog.Show();
            }
            else
            {
                aboutprog.Activate();
            }
        }

        private void Submenu_login_Click(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            login.ShowDialog();
        }

        private void submenu_logout_Click(object sender, EventArgs e)
        {
            MenuMaster.Enabled = false;
            MenuBuku.Enabled = false;
            submenu_logout.Enabled = false;
            Submenu_login.Enabled = false;
            ToolBuku.Enabled = false;
            ToolPeminjaman.Enabled = false;
            ToolPengembalian.Enabled = false;
        }

        

        
    }
}
