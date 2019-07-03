using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Asignatura : MantenimientoBase
    {
        public int AsignaturaID { get; set; }
        public string Descripcion { get; set; }
        public int CarreraID { get; set; }
        public int Creditos { get; set; }
        public string Observaciones { get; set; }
        public string Codigo { get; set; }

        public DataTable Buscar(string busqueda)
        {
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "sp_buscarAsignaturas";
            Command.Parameters.AddWithValue("@busqueda", busqueda);
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
