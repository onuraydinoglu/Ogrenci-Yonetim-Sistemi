using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VTYS
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ASUS\\MSSQLSERVERR;Initial Catalog=otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
