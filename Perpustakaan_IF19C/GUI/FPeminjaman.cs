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

    public partial class FPeminjaman : Form
    {
        public static FPeminjaman ObjPeminjaman;
        Kelas.koneksi konn = new Kelas.koneksi();
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        private void bersih()
        {
            TxtIDPeminjaman.Text = "";
            DtpTanggalPeminjaman.Value = DateTime.Now;
            DtpTanggalPengembalian.Value = DateTime.Now;
            TxtIDMahasiswa.Text = "";
            TxtNamaMahasiswa.Text = "";
            TxtJurusan.Text = "";
            TxtIDPetugas.Text = "";
            TxtNamaPetugas.Text = "";
            TxtIDBuku.Text = "";
            TxtJudulBuku.Text = "";
            Txtstok.Text = "";
            TxtBukudiPinjam.Text = "0";

        }

        private void awal()
        {
            bersih();
            DataGridPeminjaman.Enabled = false;
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM peminjaman order by id_peminjaman DESC", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "peminjaman");
                DataGridPeminjaman.DataSource = ds;
                DataGridPeminjaman.DataMember = "peminjaman";
                DataGridPeminjaman.Refresh();
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

        private void auto_number()
        {
            long hitung;
            String urut;
            SqlConnection conn = konn.GetConn(); 
            conn.Open();
            cmd = new SqlCommand("select id_peminjaman from peminjaman where id_peminjaman in(SELECT MAX(id_peminjaman)from peminjaman)order by id_peminjaman DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_peminjaman"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "P" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else{
                urut="P0001";
        }
            rd.Close();
            TxtIDPeminjaman.Text = urut;
            conn.Close();
    }
        private void simpan_masterpeminjaman()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("EXECUTE simpan_peminjaman '" + TxtIDPeminjaman.Text + "','" + DtpTanggalPeminjaman.Text + "','" +
                DtpTanggalPengembalian.Text + "','" + TxtIDMahasiswa.Text + "','" + TxtIDPetugas.Text + "','" + TxtIDBuku.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void simpan_detailpeminjaman()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("EXECUTE simpan_detailpeminjaman '" + TxtIDPeminjaman.Text + "','" + TxtIDBuku.Text + "','" +
                    TxtBukudiPinjam.Text+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void refresh_peminjaman()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from view_detailpeminjaman where id_peminjaman =  '" + TxtIDPeminjaman.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "view_detailpeminjaman");
                    DataGridPeminjaman.DataSource = ds;
                    DataGridPeminjaman.DataMember = "view_detailpeminjaman";
                    DataGridPeminjaman.Refresh();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void refreshpeminjaman()
        {
            refresh_peminjaman();
            TxtIDBuku.Clear();
            TxtJudulBuku.Clear();
            Txtstok.Text = "0";
            TxtBukudiPinjam.Text = "0";
        }

        
        public FPeminjaman()
        {
            InitializeComponent();
            ObjPeminjaman = this;
            awal();
        }

        

        private void BtnBrowseBuku_Click(object sender, EventArgs e)
        {
            FCariBuku caribuku = new FCariBuku();
            caribuku.ShowDialog();
            TxtIDBuku.Text = caribuku.ambil_id_buku;
            TxtJudulBuku.Text = caribuku.ambil_judul_buku;
            Txtstok.Text = caribuku.ambil_stok_buku;
        }

        private void BtnBrowseMahasiswa_Click(object sender, EventArgs e)
        {
            FCariMahasiswa carimhs = new FCariMahasiswa();
            carimhs.ShowDialog();
            TxtIDMahasiswa.Text = carimhs.ambil_id_mahasiswa;
            TxtNamaMahasiswa.Text = carimhs.ambil_nama_mahasiswa;
            TxtJurusan.Text = carimhs.ambil_jurusan_mahasiswa;
        }

        private void BtnBrowserPetugas_Click(object sender, EventArgs e)
        {
            FCariPetugas cariptgs = new FCariPetugas();
            cariptgs.ShowDialog();
            TxtIDPetugas.Text = cariptgs.ambil_id_petugas;
            TxtNamaPetugas.Text = cariptgs.ambil_nama_petugas;

        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            DtpTanggalPeminjaman.Focus();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            DataGridPeminjaman.Enabled = true;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if(TxtIDPeminjaman.Text.Trim()==""||DtpTanggalPeminjaman.Text.Trim()==""||DtpTanggalPengembalian.Text.Trim()==""||
                    TxtIDMahasiswa.Text.Trim()==""||TxtNamaMahasiswa.Text.Trim()==""||TxtJurusan.Text.Trim()==""||TxtIDPetugas.Text.Trim()==""||
                    TxtNamaPetugas.Text.Trim()==""||TxtIDBuku.Text.Trim()==""||TxtJudulBuku.Text.Trim()==""||Txtstok.Text.Trim()==""||
                    TxtBukudiPinjam.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap,Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from peminjaman where id_peminjaman = '" + TxtIDPeminjaman.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();
                        conn.Open();
                        cmd = new SqlCommand("select * from detail_peminjaman where id_peminjaman ='" + TxtIDPeminjaman.Text + "'and id_buku ='" + TxtIDBuku.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Data Buku" + TxtJudulBuku.Text + "Sudah Diinputkan, harap pilih buku yang lain", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            simpan_detailpeminjaman();
                        }
                    }
                    else
                    {
                        simpan_masterpeminjaman();
                        simpan_detailpeminjaman();
                    }
                    refreshpeminjaman();
                    

                }
            }
        }
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("EXECUTE hapus_detailpeminjaman '" + TxtIDPeminjaman.Text + "','" + TxtIDBuku.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT * from detail_peminjaman where id_peminjaman = '" + TxtIDPeminjaman.Text + "'", conn);
                cmd.ExecuteNonQuery();
             }
            refreshpeminjaman();
           
        }
        private void DataGridPeminjaman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DataGridPeminjaman.Rows[e.RowIndex];
            TxtIDBuku.Text = row.Cells["id_buku"].Value.ToString();
            TxtJudulBuku.Text = row.Cells["judul_buku"].Value.ToString();
            Txtstok.Text = row.Cells["stok"].Value.ToString();
            TxtBukudiPinjam.Text= row.Cells["jumlah_buku_dipinjam"].Value.ToString();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Peminjaman Selesai");
            FCeatkPeminjaman cp = new FCeatkPeminjaman();
            cp.Show();
            awal();
        }

       


    }
}
