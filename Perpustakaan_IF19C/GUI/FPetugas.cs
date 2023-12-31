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
    public partial class FPetugas : Form
    {
        Kelas.koneksi konn = new Kelas.koneksi();
        //3. tambahkan beberapa variabel yang digunakan untuk proses CRUD
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        //4. Membuat Prosedur bersih
        void bersih()
        {
            TxtIDPetugas.Clear();
            TxtNamaPetugas.Clear();
            TxtJabatan.Clear();
            TxtNomerTelepon.Clear();
            cmdjk.Text = "Jenis Kelamin";
            TxtAlamatPetugas.Clear();
            TxtCariPetugas.Clear();
        }

        void atur_tombol(Boolean status)
        {
           
            Btnedit.Enabled = status;
            BtnHapus.Enabled = status;
        }
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
                ListCariPetugas.DataSource = ds;
                ListCariPetugas.DataMember = "petugas";
                ListCariPetugas.Refresh();

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
        public FPetugas()
        {
            InitializeComponent();
            bersih();
            atur_tombol(false);
            refresh_petugas();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            bersih();
            TxtIDPetugas.Focus();
            atur_tombol(false);
            BtnSimpan.Enabled = true;

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (TxtIDPetugas.Text.Trim()==""||TxtNamaPetugas.Text.Trim()==""||TxtJabatan.Text.Trim()==""||TxtNomerTelepon.Text.Trim()==""||
                cmdjk.Text.Trim()==""||TxtAlamatPetugas.Text.Trim()=="")
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
                    cmd = new SqlCommand("EXECUTE simpan_petugas'" + TxtIDPetugas.Text + "','" + TxtNamaPetugas.Text + "','"
                        + TxtJabatan.Text + "','" + TxtNomerTelepon.Text + "','" + cmdjk.Text + "','" + TxtAlamatPetugas.Text + "'", conn);
                    //membuka koneksi databse
                    conn.Open();
                    //menjalankan perintah query
                    cmd.ExecuteNonQuery();
                    //menampilkan pesan berhasil disimpan
                    MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    refresh_petugas();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void ListCariPetugas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BtnSimpan.Enabled = false;
                atur_tombol(true);
                DataGridViewRow row = this.ListCariPetugas.Rows[e.RowIndex];
                TxtIDPetugas.Text = row.Cells["id_petugas"].Value.ToString();
                TxtNamaPetugas.Text = row.Cells["nama_petugas"].Value.ToString();
                TxtJabatan.Text = row.Cells["jabatan"].Value.ToString();
                TxtNomerTelepon.Text = row.Cells["no_telp"].Value.ToString();
                cmdjk.Text = row.Cells["jk_petugas"].Value.ToString();
                TxtAlamatPetugas.Text = row.Cells["alamat"].Value.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            if (TxtIDPetugas.Text.Trim() == ""||TxtNamaPetugas.Text.Trim() == ""||TxtJabatan.Text.Trim() == ""||
                TxtNomerTelepon.Text.Trim() == ""||cmdjk.Text.Trim() == ""||TxtAlamatPetugas.Text.Trim() == "")
            {
                MessageBox.Show("Data belum lengkap, lengkapi data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection conn = konn.GetConn();
                try
                {
                    cmd = new SqlCommand("EXECUTE ubah_petugas '" +TxtIDPetugas.Text + "','" + TxtNamaPetugas.Text + "','" + TxtJabatan.Text + "','"
                        + TxtNomerTelepon.Text + "','" + TxtAlamatPetugas.Text + "'", conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil diubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    refresh_petugas();
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
            if (MessageBox.Show("Yakin ingin menghapus data petugas ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.GetConn();
                cmd = new SqlCommand("EXECUTE hapus_petugas '" + TxtIDPetugas.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data petugas berhasil dihapus", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bersih();
                refresh_petugas();
                //memanggil prosedure atur_tombol
                atur_tombol(false);
                BtnSimpan.Enabled = true;
            }
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCariPetugas_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            cmd = new SqlCommand("EXECUTE cari_petugas '" + TxtCariPetugas.Text + "'", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "petugas");
            ListCariPetugas.DataSource = ds;
            ListCariPetugas.DataMember = "petugas";
            ListCariPetugas.Refresh();
            conn.Close();

        }
    }
}
