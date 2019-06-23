using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using INF518Core.Clases;
 
namespace INF518Core
{
    public abstract class MantenimientoBase
    {
       public Response Error { get; set; }
       public SqlConnection Connection { get; set;  } //conexion a la base de datos
       public SqlCommand Command { get; set;  } //operaciones sql, queries
       public SqlDataAdapter Adapter { get; set;  } //permite llenar los DataTable
       public string CadenaConnection { get; set; }

      /// <summary>
      /// Constructor de la Clase
      /// </summary>
       public MantenimientoBase()
       {
            CadenaConnection = ConfigurationManager.ConnectionStrings["connStr"].ToString();
            Connection = new SqlConnection(CadenaConnection);
            Adapter = new SqlDataAdapter();
            Command = new SqlCommand();
            Command.Connection = Connection;
            Error = new Response();
        }

        protected SqlConnection GetConnection()
        {
            CadenaConnection = ConfigurationManager.ConnectionStrings["connStr"].ToString();
            return  new SqlConnection(CadenaConnection);
        }
    }
}
