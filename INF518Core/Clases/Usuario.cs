using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Usuario : MantenimientoBase
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public int TipoUsuarioID { get; set; }
        public string TipoUsuario { get; set; }
        public string Permisos { get; set; }
        public string Observaciones { get; set; }
        public bool Inactivo { get; set; }

        public Usuario()
        {
            this.UsuarioID = 0;
        }

        public Usuario ValidarLogin()
        {
            try
            {
                Connection.Open();
                this.Command.CommandType = CommandType.StoredProcedure;
                this.Command.Parameters.AddWithValue("@usuario", this.NombreUsuario);
                this.Command.Parameters.AddWithValue("@password", this.Password);
                this.Command.CommandText = "sp_validarLogin";

                SqlDataReader reader;
                reader = Command.ExecuteReader();

                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            this.UsuarioID = Convert.ToInt32(reader["UsuarioID"].ToString());
                            this.Nombre = reader["Nombre"].ToString();
                            this.NombreUsuario = reader["Usuario"].ToString();
                            this.TipoUsuario = reader["TipoUsuario"].ToString();
                            this.Permisos = reader["Permisos"].ToString();
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

        public bool Registrar()
        {
            bool status = false;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_crearUsuario";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@nombre", this.Nombre);
                Command.Parameters.AddWithValue("@nombreUsuario", this.NombreUsuario);
                Command.Parameters.AddWithValue("@password", this.Password);
                Command.Parameters.AddWithValue("@tipoUsuarioID", this.TipoUsuarioID);
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
            }
            finally
            {
                Connection.Close();
            }
            return status;
        }

        public bool Actualizar()
        {
            bool status = false;

            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_actualizarUsuario";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@usuarioID", this.UsuarioID);
                Command.Parameters.AddWithValue("@nombre", this.Nombre);
                Command.Parameters.AddWithValue("@nombreUsuario", this.NombreUsuario);
                Command.Parameters.AddWithValue("@tipoUsuarioID", this.TipoUsuarioID);
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
            }
            finally
            {
                Connection.Close();
            }
            return status;
        }

        public DataTable Buscar(string busquedsa)
        {
            DataTable dt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_buscarUsuarios";
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

        public Usuario Detalle()
        {
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                this.Command.CommandType = CommandType.StoredProcedure;
                this.Command.CommandText = "sp_detalleUsuario";
                this.Command.Parameters.AddWithValue("@usuarioID", this.UsuarioID);

                SqlDataReader reader = Command.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    if (reader.Read())
                    {
                        this.Nombre = reader["Nombre"].ToString();
                        this.NombreUsuario = reader["Usuario"].ToString();
                        this.TipoUsuarioID = Convert.ToInt32(reader["TipoUsuarioID"]);
                        this.Observaciones = reader["Observaciones"].ToString();
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

        public bool CambiarPassword()
        {
            bool status = false;

            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_cambiarPasswordUsario";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@usuarioID", this.UsuarioID);
                Command.Parameters.AddWithValue("@password", this.Password);
                if (Command.ExecuteNonQuery() > 0)
                {
                    status = true;
                }
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
            return status;
        }
    }
}
