using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Estudiante : MantenimientoBase
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public int IDTipodeEstudiante { get; set; }
        public string Matricula { get; set; }
        public char sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoMovil{ get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public bool Inacivo { get; set; }
        public int IDCarrera { get; set; }
        public double Balance { get; set; }
   
        public bool Matricular()
        {


            bool resultado = false;
            Command.CommandText = "sp_MatricularEstudiante";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@Nombre", this.Nombre);
            Command.Parameters.AddWithValue("@Apellido", this.Apellido);
            Command.Parameters.AddWithValue("@FechaNacimiento",this.FechaNacimiento);
            Command.Parameters.AddWithValue("@Cedula", this.Cedula);
            Command.Parameters.AddWithValue("@IDTipoEstudiante", this.IDTipodeEstudiante);
            Command.Parameters.AddWithValue("@Matricula", this.Matricula);
            Command.Parameters.AddWithValue("@Sexo",this.sexo);
            Command.Parameters.AddWithValue("@EstadoCivil",this.EstadoCivil);
            Command.Parameters.AddWithValue("@TelefonoCasa",this.TelefonoCasa);
            Command.Parameters.AddWithValue("@TelefonoMovil",this.TelefonoMovil);
            Command.Parameters.AddWithValue("@Email", this.Email);
            Command.Parameters.AddWithValue("@Observaciones",this.Observaciones);
            Command.Parameters.AddWithValue("@IDCarrera",this.IDCarrera);

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
