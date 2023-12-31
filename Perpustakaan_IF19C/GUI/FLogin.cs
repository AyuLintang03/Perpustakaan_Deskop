using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Perpustakaan_IF19C.GUI
{
    public partial class FLogin : Form
    {
        private SqlCommand cmd;
        Kelas.koneksi konn = new Kelas.koneksi();
        public FLogin()
        {

            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select * from tbl_login where username ='" + txtusername.Text + "'and password = '" + txtpassword.Text + "'", conn);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();

            if (reader.Read())
            //jika user dan password benar
            {
                MessageBox.Show("Login Berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FMenuUtama.mdiobj.MenuMaster.Enabled = true;
                FMenuUtama.mdiobj.MenuBuku.Enabled = true;
                FMenuUtama.mdiobj.submenu_logout.Enabled = true;
                FMenuUtama.mdiobj.Submenu_login.Enabled = false;
                FMenuUtama.mdiobj.submenu_mahasiswa.Enabled = true;
                FMenuUtama.mdiobj.submenu_petugas.Enabled = true;
                FMenuUtama.mdiobj.ToolBuku.Enabled = true;
                FMenuUtama.mdiobj.ToolPengembalian.Enabled = true;
                FMenuUtama.mdiobj.ToolPeminjaman.Enabled = true;
                FMenuUtama.mdiobj.ToolMahasiswa.Enabled = true;
                this.Close();
            }

            else //jika user atau password salah
            {
                MessageBox.Show("Username atau Password salah !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
            }
            conn.Close();
        }

        private void BtnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

          private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnLogin_Click(sender, e);
            }
        }
    }
}
