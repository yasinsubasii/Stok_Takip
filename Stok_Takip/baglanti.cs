using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Takip
{
    class baglanti
    {
        public SqlConnection baglantim()
        {
            SqlConnection con = new SqlConnection(@"Server=DESKTOP-TNVMV0L\YASIN;Integrated Security=true; Database=MayaStok");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            return con;

        }
    }
}
