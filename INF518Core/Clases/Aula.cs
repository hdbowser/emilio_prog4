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

        public DataTable Buscar(string _busqueda)
        {
            DataTable dt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_buscarAulas";
                Command.Parameters.AddWithValue("@busqueda", _busqueda ?? "");
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
                Command.CommandText = "sp_crearAula";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
                Command.Parameters.AddWithValue("@capacidad", this.Capacidad);
                Command.Parameters.AddWithValue("@centroID", this.CentroID);
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

        public Aula Detalle()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_detalleAula";
                Command.Parameters.AddWithValue("@aulaID", this.AulaID);

                SqlDataReader reader;
                reader = Command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            this.Capacidad = Convert.ToInt32(reader["Capacidad"].ToString());
                            this.Descripcion = reader["Descripcion"].ToString();
                            this.CentroID = Convert.ToInt32(reader["CentroID"].ToString());
                            this.Observaciones = reader["Observaciones"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return this;
        }
    }
}
