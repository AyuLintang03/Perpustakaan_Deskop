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
    public partial class FCetakPengembalian : Form
    {
        private DataSet ds;
        private SqlDataAdapter da;
        Kelas.koneksi konn = new Kelas.koneksi();
        public FCetakPengembalian()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = konn.GetConn();
            conn.Open();
            da = new SqlDataAdapter("SELECT * FROM View_pengembalian WHERE id_pengembalian = '" +
                Fpengembalian.ObjPengembalian.TxtIDPengembalian.Text+"'",conn);
             ds = new DataSet();
            da.Fill(ds, "View_pengembalian");
            Laporan.CetakPengembalian myReport = new Laporan.CetakPengembalian();
            myReport.SetDataSource(ds);
            crystalReportViewer1.ReportSource = myReport;
            crystalReportViewer1.Refresh();
        }
    }
}