using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Aula : MantenimientoBase
    {
        public int AulaID { get; set; }
        public string Descripcion { get; set; }
        public int CentroID { get; set; }
        public int Capacidad { get; set; }
        public string Observaciones { get; set; }


        public DataTable Buscar(int idCentro)
        {
            DataTable dt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_listadoAulasPorCentro";
                Command.Parameters.AddWithValue("@centroID", idCentro);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = Command;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }
    }
}
