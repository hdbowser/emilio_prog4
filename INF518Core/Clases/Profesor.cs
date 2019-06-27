using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Profesor : MantenimientoBase
    {
        public int ProfesorID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoMovil { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public bool Inactivo { get; set; }

        public bool GuardaProfesor()
        {
            bool resultado = false;
            Command.CommandText = "sp_crearProfesor";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@nombre", this.Nombre);
            Command.Parameters.AddWithValue("@apellido", this.Apellido);
            Command.Parameters.AddWithValue("@cedula", this.Cedula);
            Command.Parameters.AddWithValue("@sexo", this.Sexo);
            Command.Parameters.AddWithValue("@fechaNacimiento", this.FechaNacimiento);
            Command.Parameters.AddWithValue("@estadoCivil", this.EstadoCivil);
            Command.Parameters.AddWithValue("@telefonoCasa", this.TelefonoCasa);
            Command.Parameters.AddWithValue("@telefonoMovil", this.TelefonoMovil);
            Command.Parameters.AddWithValue("@email", this.Email);
            Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
            try
            {
                Connection.Open();
                if (Command.ExecuteNonQuery() > 0)
                {
                    resultado = true;
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
            return resultado;
        }

        public DataTable BuscarProfesores(string busquedsa)
        {
            DataTable dt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_buscarProfesores";
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

    }


}
