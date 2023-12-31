﻿using System;
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
    public partial class Fpengembalian : Form
    {
        Kelas.koneksi konn = new Kelas.koneksi();
        private SqlCommand cmd;
        private SqlDataReader rd;
        private DataSet ds;
        private SqlDataAdapter da;

        private void bersih()
        {
            TxtIDPengembalian.Text = "";
            TxtIDPeminjaman.Text = "";
            DtpTanggalPeminjaman.Value = DateTime.Now;
            DtpTanggalPengembalian.Value = DateTime.Now;
            TxtIDMahasiswa.Text = "";
            TxtNamaMahasiswa.Text = "";
            TxtJurusan.Text = "";
            TxtIDBuku.Text = "";
            TxtJudulBuku.Text = "";
            Txtstok.Text = "";
            TxtBukudiKembalikan.Text = "0";
            TxtDenda.Text = "0";

        }

        private void awal()
        {
            bersih();
            DataGridPengembalian.Enabled = false;
            SqlConnection conn = konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM pengembalian order by id_pengembalian DESC", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "pengembalian");
                DataGridPengembalian.DataSource = ds;
                DataGridPengembalian.DataMember = "pengembalian";
                DataGridPengembalian.Refresh();
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
            cmd = new SqlCommand("select id_pengembalian from pengembalian where id_pengembalian in(SELECT MAX(id_pengembalian)from pengembalian)order by id_pengembalian DESC", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_pengembalian"].ToString().Length - 4, 4)) + 1;
                string joinstr = "0000" + hitung;
                urut = "K" + joinstr.Substring(joinstr.Length - 4, 4);
            }
            else
            {
                urut = "K0001";
            }
            rd.Close();
            TxtIDPengembalian.Text = urut;
            conn.Close();
        }

        private void simpan_masterpengembalian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("EXECUTE simpan_pengembalian'" +TxtIDPengembalian.Text+"','"+ TxtIDPeminjaman.Text + "','" + DtpTanggalPeminjaman.Text + "','" +
                DtpTanggalPengembalian.Text + "','" + TxtIDMahasiswa.Text + "','" + TxtIDBuku.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void simpan_detailpengembalian()
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("EXECUTE simpan_detailpengembalian '" + TxtIDPengembalian.Text + "','" + TxtIDBuku.Text + "','" +
                    TxtBukudiKembalikan.Text +"','"+TxtDenda.Text+ "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void refresh_pengembalian()
        {
            SqlConnection conn = konn.GetConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from view_detailpengembalian where id_pengembalian =  '" + TxtIDPengembalian.Text + "'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "view_detailpengembalian");
                    DataGridPengembalian.DataSource = ds;
                    DataGridPengembalian.DataMember = "view_detailpengembalian";
                    DataGridPengembalian.Refresh();
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
        }
        private void refreshpengembalian()
        {
            refresh_pengembalian();
            TxtIDBuku.Clear();
            TxtJudulBuku.Clear();
            Txtstok.Text = "0";
            TxtBukudiKembalikan.Text = "0";
            TxtDenda.Text = "0";
        }
        public Fpengembalian()
        {
            InitializeComponent();
            awal();
        }

        private void BtnBrowsePeminjaman_Click(object sender, EventArgs e)
        {
            FCariPeminjaman cpinjam = new FCariPeminjaman();
            cpinjam.ShowDialog();
            TxtIDPeminjaman.Text = cpinjam.ambil_id_peminjaman;
            DtpTanggalPeminjaman.Text = cpinjam.ambil_tglpinjam;
            DtpTanggalPengembalian.Text = cpinjam.ambil_tglkembali;
        }

        private void BtnBrowseMahasiswa_Click(object sender, EventArgs e)
        {
            FCariPeminjaman cmhs = new FCariPeminjaman();
            cmhs.ShowDialog();
            TxtIDMahasiswa.Text = cmhs.ambil_id_mahasiswa;
            TxtNamaMahasiswa.Text = cmhs.ambil_nama_mahasiswa;
            TxtJurusan.Text = cmhs.ambil_jurusan_mahasiswa;
        }

        private void BtnBrowserBuku_Click(object sender, EventArgs e)
        {
            FCariPeminjaman cbuku = new FCariPeminjaman();
            cbuku.ShowDialog();
            TxtIDBuku.Text = cbuku.ambil_id_buku;
            TxtJudulBuku.Text = cbuku.ambil_judul_buku;
            Txtstok.Text = cbuku.ambil_stok_buku;
        }

        private void BtnBaru_Click(object sender, EventArgs e)
        {
            awal();
            auto_number();
            DtpTanggalPengembalian.Focus();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            DataGridPengembalian.Enabled = true;
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                if (TxtIDPengembalian.Text.Trim() == "" || TxtIDPeminjaman.Text.Trim() == "" || DtpTanggalPeminjaman.Text.Trim() == "" || DtpTanggalPengembalian.Text.Trim() == "" ||
                    TxtIDMahasiswa.Text.Trim() == "" || TxtNamaMahasiswa.Text.Trim() == "" || TxtJurusan.Text.Trim() == ""  || TxtIDBuku.Text.Trim() == "" || TxtJudulBuku.Text.Trim() == "" || Txtstok.Text.Trim() == "" ||
                    TxtBukudiKembalikan.Text.Trim() == "" || TxtDenda.Text.Trim() == "")
                {
                    MessageBox.Show("Data Belum Lengkap,Lengkapi Data", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    conn.Open();
                    cmd = new SqlCommand("select * from pengembalian where id_pengembalian = '" + TxtIDPengembalian.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        conn.Close();
                        conn.Open();
                        cmd = new SqlCommand("select * from detail_pengembalian where id_pengembalian ='" + TxtIDPengembalian.Text + "'and id_buku ='" + TxtIDBuku.Text + "'", conn);
                        cmd.ExecuteNonQuery();
                        reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Data Buku" + TxtJudulBuku.Text + "Sudah Diinputkan, harap pilih buku yang lain", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            simpan_detailpengembalian();
                        }
                    }
                    else
                    {
                        simpan_masterpengembalian();
                        simpan_detailpengembalian();
                    }
                    refreshpengembalian();


                }
            }
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            {
                cmd = new SqlCommand("EXECUTE hapus_detailpengembalian '" + TxtIDPengembalian.Text + "','" + TxtIDBuku.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("SELECT * from detail_pengembalian where id_pengembalian = '" + TxtIDPengembalian.Text + "'", conn);
                cmd.ExecuteNonQuery();
            }
            refreshpengembalian();
        }

        private void DataGridPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DataGridPengembalian.Rows[e.RowIndex];
            TxtIDBuku.Text = row.Cells["id_buku"].Value.ToString();
            TxtJudulBuku.Text = row.Cells["judul_buku"].Value.ToString();
            Txtstok.Text = row.Cells["stok"].Value.ToString();
            TxtBukudiKembalikan.Text = row.Cells["jumlah_buku_dikembalikan"].Value.ToString();
            TxtDenda.Text = row.Cells["denda"].Value.ToString();
        }

        private void BtnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pengembalian Buku Selesai");
            awal();
        }

      
    }
}
