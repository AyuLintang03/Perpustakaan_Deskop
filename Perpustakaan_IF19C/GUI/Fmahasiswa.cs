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
    public partial class Fmahasiswa : Form
    {
       
        Kelas.koneksi konn = new Kelas.koneksi();
        //3. tambahkan beberapa variabel yang digunakan untuk proses CRUD
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //4. Membuat Prosedur bersih
        void bersih()
        {
            TxtIDMahasiswa.Clear();
            TxtNamaMahasiswa.Clear();
            TxtJurusan.Clear();
            TxtNomerTelepon.Clear();
            cmdjk.Text = "Jenis Kelamin";
            TxtAlamatMahasiswa.Clear();
            TxtCariMahasiswa.Clear();
        }

        void atur_tombol(Boolean status)
        {
            BtnEdit.Enabled = status;
            BtnHapus.Enabled = status;
        }
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
                ListMahasiswa.DataSource = ds;
                ListMahasiswa.DataMember = "mahasiswa";
                ListMahasiswa.Refresh();

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
        public Fmahasiswa()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_mahasiswa();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            bersih();
            TxtIDMahasiswa.Focus();
            atur_tombol(false);
            BtnSimpan.Enabled = true;
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (TxtIDMahasiswa.Text.Trim()==""||TxtNamaMahasiswa.Text.Trim()==""||TxtJurusan.Text.Trim()==""||TxtNomerTelepon.Text.Trim()==""||
                cmdjk.Text.Trim()==""||TxtAlamatMahasiswa.Text.Trim()=="")
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
                    cmd = new SqlCommand("EXECUTE simpan_mahasiswa'" + TxtIDMahasiswa.Text + "','" + TxtNamaMahasiswa.Text + "','"
                        + TxtJurusan.Text + "','" + TxtNomerTelepon.Text + "','" + cmdjk.Text + "','" + TxtAlamatMahasiswa.Text+ "'", conn);
                    //membuka koneksi databse
                    conn.Open();
                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    refresh_mahasiswa();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void ListMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               BtnSimpan.Enabled = false;
               atur_tombol(true);
               DataGridViewRow row = this.ListMahasiswa.Rows[e.RowIndex];
               TxtIDMahasiswa.Text = row.Cells["id_mhs"].Value.ToString();
               TxtNamaMahasiswa.Text = row.Cells["nama"].Value.ToString();
               TxtJurusan.Text = row.Cells["jurusan"].Value.ToString();
               TxtNomerTelepon.Text = row.Cells["no_telp"].Value.ToString();
               cmdjk.Text = row.Cells["jk_mhs"].Value.ToString();
               TxtAlamatMahasiswa.Text =row.Cells["alamat"].Value.ToString();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (TxtIDMahasiswa.Text.Trim() == "" || TxtNamaMahasiswa.Text.Trim() == "" || TxtJurusan.Text.Trim() == "" || TxtNomerTelepon.Text.Trim() == "" ||
                cmdjk.Text.Trim() == "" || TxtAlamatMahasiswa.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_mahasiswa'" + TxtIDMahasiswa.Text + "','" + TxtNamaMahasiswa.Text + "','"
                        + TxtJurusan.Text + "','" + TxtNomerTelepon.Text + "','" + cmdjk.Text + "','" + TxtAlamatMahasiswa.Text + "'", conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    refresh_mahasiswa();
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
            if (MessageBox.Show("Yakin ingin menghapus data mahasiswa ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_mahasiswa '" + TxtIDMahasiswa.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data mahasiswa berhasil dihapus", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                refresh_mahasiswa();
                //memanggil prosedure atur_tombol
                atur_tombol(false);
                BtnSimpan.Enabled = true;
            }

        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCariMahasiswa_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("EXECUTE cari_mahasiswa '" + TxtCariMahasiswa.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "mahasiswa");
            ListMahasiswa.DataSource = ds;
            ListMahasiswa.DataMember = "mahasiswa";
            ListMahasiswa.Refresh();
            conn.Close();

        }

    }
}
