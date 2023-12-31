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
    public partial class FCariBuku : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idb,jb,p,s,jp,penulis,tahun;
        //3. import kelas koneksi.cs yang berasal dari folder kelas menjadi obat --> konn
        Kelas.koneksi konn = new Kelas.koneksi();
        void refresh_buku()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM buku", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "buku");
                DataGridCariBuku.DataSource = ds;
                DataGridCariBuku.DataMember = "buku";
                DataGridCariBuku.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public FCariBuku()
        {
            InitializeComponent();
            TxtCariBuku.Clear();
            refresh_buku();
        }

        private void TxtCariBuku_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM buku WHERE id_buku Like '%" + TxtCariBuku.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "buku");
            DataGridCariBuku.DataSource = ds;
            DataGridCariBuku.DataMember = "buku";
            DataGridCariBuku.Refresh();
            conn.Close();
        }

        private void DataGridCariBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataGridCariBuku.Rows[e.RowIndex];
                idb = row.Cells["id_buku"].Value.ToString();
                jb = row.Cells["judul_buku"].Value.ToString();
                p = row.Cells["penerbit"].Value.ToString();
                penulis = row.Cells["penulis"].Value.ToString();
                tahun = row.Cells["tahun"].Value.ToString();
                s = row.Cells["stok"].Value.ToString();
                this.Close();//menutup from cari pelanggan
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }
        public string ambil_id_buku
        {
            get
            {
                return idb;
            }
        }

        public string ambil_judul_buku
        {
            get
            {
                return jb;
            }
        }

        public string ambil_penerbit_buku
        {
            get
            {
                return p;
            }
        }

        public string ambil_pennulis_buku
        {
            get
            {
                return penulis;
            }
        }

        public string ambil_tahun_buku
        {
            get
            {
                return tahun;
            }
        }

        public string ambil_stok_buku
        {
            get
            {
                return s;
            }
        }
    }
}
