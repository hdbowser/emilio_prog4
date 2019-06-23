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
        public string TipoUsuarioID { get; set; }
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
            return this;
        }
    }
}
