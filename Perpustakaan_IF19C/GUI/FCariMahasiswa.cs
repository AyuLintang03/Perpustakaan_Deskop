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
    public partial class FCariMahasiswa : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idmhs, nama, jurusan;
        //3. import kelas koneksi.cs yang berasal dari folder kelas menjadi obat --> konn
        Kelas.koneksi konn = new Kelas.koneksi();

        void refresh_mahasiswa()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM mahasiswa", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "mahasiswa");
                DataGridCariMahasiswa.DataSource = ds;
                DataGridCariMahasiswa.DataMember = "mahasiswa";
                DataGridCariMahasiswa.Refresh();
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
        public FCariMahasiswa()
        {
            InitializeComponent();
            TxtCariMahasiswa.Clear();
            refresh_mahasiswa();
        }

        private void TxtCariMahasiswa_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM mahasiswa WHERE id_mhs Like '%" + TxtCariMahasiswa.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "mahasiswa");
            DataGridCariMahasiswa.DataSource = ds;
            DataGridCariMahasiswa.DataMember = "mahasiswa";
            DataGridCariMahasiswa.Refresh();
            conn.Close();
        }

        private void DataGridCariMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataGridCariMahasiswa.Rows[e.RowIndex];
                idmhs = row.Cells["id_mhs"].Value.ToString();
                nama = row.Cells["nama"].Value.ToString();
                jurusan = row.Cells["jurusan"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public string ambil_id_mahasiswa
        {
            get
            {
                return idmhs;
            }
        }

        public string ambil_nama_mahasiswa
        {
            get
            {
                return nama;
            }
        }

        public string ambil_jurusan_mahasiswa
        {
            get
            {
                return jurusan;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
