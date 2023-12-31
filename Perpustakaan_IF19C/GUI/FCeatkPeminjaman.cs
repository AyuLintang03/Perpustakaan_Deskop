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
using CrystalDecisions.CrystalReports.Engine;

namespace Perpustakaan_IF19C.GUI
{
    public partial class FCeatkPeminjaman : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;

        //3. import kelas koneksi.cs
        Kelas.koneksi konn = new Kelas.koneksi();
        public FCeatkPeminjaman()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM view_peminjaman WHERE id_peminjaman = '" +
                FPeminjaman.ObjPeminjaman.TxtIDPeminjaman.Text + "'", conn);
            ds = new DataSet();
            da.Fill(ds, "view_peminjaman");
            //memanggil REPORT CetakKwitansi yang ada package laporan
            Laporan.CetakPeminjaman myReport = new Laporan.CetakPeminjaman();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            crystalReportViewer1.Refresh();
        }
    }
}
