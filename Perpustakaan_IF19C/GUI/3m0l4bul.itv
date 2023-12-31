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
    public partial class FCariPeminjaman : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        public string idpjm,tglpinjam,tglkembali,idmhs, nama, jurusan,idptgs,namaptgs,idbuku,judulbuku,penerbit,stok,pinjam;
        Kelas.koneksi konn = new Kelas.koneksi();

        void refresh_peminjaman()
        {
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM view_peminjaman", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "view_peminjaman");
                DataGridCariPeminjaman.DataSource = ds;
                DataGridCariPeminjaman.DataMember = "view_peminjaman";
                DataGridCariPeminjaman.Refresh();
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
        public FCariPeminjaman()
        {
            InitializeComponent();
            TxtCariPeminjaman.Clear();
            refresh_peminjaman();

        }

        private void TxtCariPeminjaman_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM view_peminjaman WHERE id_peminjaman Like '%" + TxtCariPeminjaman.Text + "%'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "view_peminjaman");
            DataGridCariPeminjaman.DataSource = ds;
            DataGridCariPeminjaman.DataMember = "view_peminjaman";
            DataGridCariPeminjaman.Refresh();
            conn.Close();
        }

        private void DataGridCariPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataGridCariPeminjaman.Rows[e.RowIndex];
                idpjm = row.Cells["id_peminjaman"].Value.ToString();
                tglpinjam = row.Cells["tanggal_pinjam"].Value.ToString();
                tglkembali = row.Cells["tanggal_dikembalikan"].Value.ToString();
                idmhs = row.Cells["id_mhs"].Value.ToString();
                nama = row.Cells["nama"].Value.ToString();
                jurusan = row.Cells["jurusan"].Value.ToString();
                idptgs = row.Cells["id_petugas"].Value.ToString();
                namaptgs = row.Cells["nama_petugas"].Value.ToString();
                idbuku = row.Cells["id_buku"].Value.ToString();
                judulbuku = row.Cells["judul_buku"].Value.ToString();
                penerbit = row.Cells["penerbit"].Value.ToString();
                stok = row.Cells["stok"].Value.ToString();
                pinjam = row.Cells["jumlah_buku_dipinjam"].Value.ToString();
                
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public string ambil_id_peminjaman
        {
            get
            {
                return idpjm;
            }
        }

        public string ambil_tglpinjam
        {
            get
            {
                return tglpinjam;
            }
        }
        public string ambil_tglkembali
        {
            get
            {
                return tglkembali;
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
        public string ambil_id_buku
        {
            get
            {
                return idbuku;
            }
        }
        public string ambil_judul_buku
        {
            get
            {
                return judulbuku;
            }
        }
        public string ambil_stok_buku
        {
            get
            {
                return stok;
            }
        }


    }
}
