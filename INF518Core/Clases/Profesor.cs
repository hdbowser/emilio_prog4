using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Profesor : MantenimientoBase
    {
        public int ID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoMovil { get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public bool Inactivo { get; set; }
        public bool Borrado  { get; set; }
        public bool BorradoPorID  { get; set; }
        public bool FechaBorrado  { get; set; }

        public bool GuardaProfesor()
        {
            bool resultado = false;
            Command.CommandText = "sp_GuardaProfesor";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Nombre", this.Nombre);
            Command.Parameters.AddWithValue("@Apellido", this.Apellido);
            Command.Parameters.AddWithValue("@Cedula", this.Cedula);
            Command.Parameters.AddWithValue("@Sexo", this.Sexo);
            Command.Parameters.AddWithValue("@FechaNacimiento", this.FechaNacimiento);
            Command.Parameters.AddWithValue("@EstadoCivil", this.EstadoCivil);
            Command.Parameters.AddWithValue("@TelefonoCasa", this.TelefonoCasa);
            Command.Parameters.AddWithValue("@TelefonoMovil", this.TelefonoMovil);
            Command.Parameters.AddWithValue("@Email", this.Email);
            Command.Parameters.AddWithValue("@Observaciones", this.Observaciones);

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
   

    }

   
}
