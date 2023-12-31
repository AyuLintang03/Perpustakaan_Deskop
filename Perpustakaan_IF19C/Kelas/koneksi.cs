using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Perpustakaan_IF19C.Kelas
{
    class koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection(@"AYULINTANG\SQLEXPRESS; Database=Perpustakaan; Trusted_Connection=True");
            return conn;
        }
    }
}
