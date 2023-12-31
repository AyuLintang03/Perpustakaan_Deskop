using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//1.tambahkan library sqlserver
using System.Data.SqlClient;


namespace Perpustakaan_IF19C.GUI
{
    public partial class FBuku : Form
    {
        //2. import kelas koneksi.cs yang berasal dari folder kelas menjadi onbjek ---> konn
        Kelas.koneksi konn = new Kelas.koneksi();
        //3. tambahkan beberapa variabel yang digunakan untuk proses CRUD
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //4. Membuat Prosedur bersih
        void bersih()
        {
            txtid_buku.Clear();
            txtjudul_buku.Clear();
            txtpenulis.Clear();
            txtpenerbit.Clear();
            txttahun.Clear();
            txtstok.Clear();
            txtcaribuku.Clear();
        }

        void atur_tombol(Boolean status)
        {
            BtnEdit.Enabled = status;
            BtnHapus.Enabled = status;
        }

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
                ListBuku.DataSource = ds;
                ListBuku.DataMember = "buku";
                ListBuku.Refresh();
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

        public FBuku()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_buku();
        }

        private void FBuku_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            bersih();
            txtid_buku.Focus();
            atur_tombol(false);
            BtnSimpan.Enabled = true;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (txtid_buku.Text.Trim()==""||txtjudul_buku.Text.Trim()==""||txtpenulis.Text.Trim()==""||
                txtpenerbit.Text.Trim()==""|| txttahun.Text.Trim()==""||txtstok.Text.Trim()=="")
            {
                //tampilkan pesan bahwa data belum lengkap
                MessageBox.Show("Data belum lengkap, lengkapi data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //mempersiapkan sqlconnection
                SqlConnection conn = konn.GetConn();
                try
                {
                    //mempersiapkan sqlcommqnd yang akan dieksekusi
                    cmd = new SqlCommand("EXECUTE simpan_buku'" + txtid_buku.Text + "','" + txtjudul_buku.Text + "','"
                        + txtpenulis.Text + "','" + txtpenerbit.Text + "','" + txttahun.Text +"','"+txtstok.Text+"'", conn);
                    //membuka koneksi databse
                    conn.Open();
                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    refresh_buku();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void ListBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnSimpan.Enabled = false;
                atur_tombol(true);
                DataGridViewRow row = this.ListBuku.Rows[e.RowIndex];
                txtid_buku.Text = row.Cells["id_buku"].Value.ToString();
                txtjudul_buku.Text = row.Cells["judul_buku"].Value.ToString();
                txtpenulis.Text = row.Cells["penulis"].Value.ToString();
                txtpenerbit.Text = row.Cells["penerbit"].Value.ToString();
                txttahun.Text = row.Cells["tahun"].Value.ToString();
                txtstok.Text = row.Cells["stok"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (txtid_buku.Text.Trim() == "" || txtjudul_buku.Text.Trim() == "" || txtpenulis.Text.Trim() == "" ||
                txtpenerbit.Text.Trim() == "" || txttahun.Text.Trim() == "" || txtstok.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_buku'" + txtid_buku.Text+"','" + txtjudul_buku.Text + "','" + txtpenulis.Text + "','" 
                        + txtpenerbit.Text + "','" + txttahun.Text + "','" + txtstok.Text +"'", conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    refresh_buku();
                    //memanggil prosedur atur_tombol
                    atur_tombol(false);
                    BtnSimpan.Enabled = true;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data buku ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_buku '" + txtid_buku.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data buku berhasil dihapus", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                refresh_buku();
                //memanggil prosedure atur_tombol
                atur_tombol(false);
                BtnSimpan.Enabled = true;
            }
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcaribuku_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("EXECUTE cari_buku '" + txtcaribuku.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "buku");
            ListBuku.DataSource = ds;
            ListBuku.DataMember = "buku";
            ListBuku.Refresh();
            conn.Close();
        }
    }
}
