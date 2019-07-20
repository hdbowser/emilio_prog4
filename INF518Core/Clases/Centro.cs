using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Centro : MantenimientoBase
    {
        public int CentroID { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public string WebSite { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }

        public DataTable Buscar(string busquedsa)
        {
            DataTable dt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_buscarCentros";
                Command.Parameters.AddWithValue("@busqueda", busquedsa);
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

        public bool Registrar()
        {
            bool status = false;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_crearCentro";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@nombre", this.Nombre);
                Command.Parameters.AddWithValue("@nombreCorto", this.NombreCorto);
                Command.Parameters.AddWithValue("@webSite", this.WebSite);
                Command.Parameters.AddWithValue("@telefono", this.Telefono);
                Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
                if (Command.ExecuteNonQuery() > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
                status = false;
            }
            finally
            {
                Connection.Close();
            }
            return status;
        }
    }
}
