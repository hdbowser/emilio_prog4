using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WFP1_2019
{
    public class BDcomun
    {
        public static  SqlConnection OptenerConexion()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=INF518;User ID=sa; Password=12345;");
            conn.Open();

            return conn;


        }

    }
}
