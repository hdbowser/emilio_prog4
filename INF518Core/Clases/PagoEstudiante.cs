using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class PagoEstudiante : MantenimientoBase
    {
        public int PagoID { get; set; }
        public int EstudianteID { get; set; }
        public string NombreEstudiante { get; set; }
        public decimal MontoAPagar { get; set; }
        public decimal MontoRecibido { get; set; }
        public decimal Devuelta { get; set; }

        public bool Registrar()
        {
            bool r = false;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_registrarPagoEstudiante";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@estudianteID", this.EstudianteID);
                Command.Parameters.AddWithValue("@montoAPagar", this.MontoAPagar);
                Command.Parameters.AddWithValue("@montoRecibido", this.MontoRecibido);
                Command.Parameters.AddWithValue("@devuelta", this.Devuelta);

                if (Command.ExecuteNonQuery() > 0)
                {
                    r = true;
                }
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
                r = false;
            }
            finally
            {
                Connection.Close();
            }
            return r;
        }
    }


}
