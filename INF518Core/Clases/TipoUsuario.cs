using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class TipoUsuario : MantenimientoBase
    {


        public TipoUsuario()
        {

        }

        public int TipoUsuarioID { get; set; }
        public string Nombre { get; set; }
        public double Permisos { get; set; }
        public double CostoInscripcion { get; set; }
        public string Observaciones { get; set; }

        public DataTable Listado()
        {
            //SqlCommand cmd = new SqlCommand();

            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "sp_buscarTiposUsuarios";
            Command.CommandTimeout = 0;

            DataTable dt = new DataTable();
            Adapter = new SqlDataAdapter(Command);
            try
            {
                Connection.Open();
                Adapter.Fill(dt); //se asigna todo al datatable
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }
    }

}
