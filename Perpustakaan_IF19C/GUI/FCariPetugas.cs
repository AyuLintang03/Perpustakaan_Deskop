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
    public partial class FCariPetugas : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idptgs,namaptgs;
        //3. import kelas koneksi.cs yang berasal dari folder kelas menjadi obat --> konn
        Kelas.koneksi konn = new Kelas.koneksi();
        void refresh_petugas()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM petugas", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "petugas");
                DataGridCariPetugas.DataSource = ds;
                DataGridCariPetugas.DataMember = "petugas";
                DataGridCariPetugas.Refresh();
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
        public FCariPetugas()
        {
            InitializeComponent();
            TxtCariPetugas.Clear();
            refresh_petugas();
        }

        private void TxtCariPetugas_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM petugas WHERE id_petugas Like '%" + TxtCariPetugas.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "petugas");
            DataGridCariPetugas.DataSource = ds;
            DataGridCariPetugas.DataMember = "petugas";
            DataGridCariPetugas.Refresh();
            conn.Close();
        }

        private void DataGridCariPetugas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataGridCariPetugas.Rows[e.RowIndex];
                idptgs= row.Cells["id_petugas"].Value.ToString();
                namaptgs = row.Cells["nama_petugas"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public string ambil_id_petugas
        {
            get
            {
                return idptgs;
            }
        }
        public string ambil_nama_petugas
        {
            get
            {
                return namaptgs;
            }
        }
    }
}
