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
        public bool Inactivo { get; set; }

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

        public bool Registrar()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_crearAsignatura";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
                Command.Parameters.AddWithValue("@carreraID", this.CarreraID);
                Command.Parameters.AddWithValue("@codigo", this.Codigo);
                Command.Parameters.AddWithValue("@creditos", this.Creditos);
                Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
                if (Command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return false;
        }
        public Asignatura Detalle()
        {
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                this.Command.CommandType = CommandType.StoredProcedure;
                this.Command.CommandText = "sp_detalleAsignatura";
                this.Command.Parameters.AddWithValue("@asignaturaID", this.AsignaturaID);

                SqlDataReader reader = Command.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    if (reader.Read())
                    {
                        this.Descripcion = reader["Descripcion"].ToString();
                        this.CarreraID = Convert.ToInt32(reader["CarreraID"].ToString());
                        this.Creditos = Convert.ToInt32(reader["Creditos"].ToString());
                        this.Observaciones = reader["Observaciones"].ToString();
                        this.Codigo = reader["Codigo"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return this;
        }

        public bool Actualizar()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_actualizarAsignatura";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@asignaturaID", this.AsignaturaID);
                Command.Parameters.AddWithValue("@descripcion", this.Descripcion);
                Command.Parameters.AddWithValue("@carreraID", this.CarreraID);
                Command.Parameters.AddWithValue("@codigo", this.Codigo);
                Command.Parameters.AddWithValue("@creditos", this.Creditos);
                Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
                if (Command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return false;
        }

    }
}
