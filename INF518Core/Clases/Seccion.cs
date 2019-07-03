using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Seccion : MantenimientoBase
    {
        public int SeccionID { get; set; }
        public int CentroID { get; set; }
        public int ProfesorID { get; set; }
        public int AsignaturaID { get; set; }
        public int Capacidad { get; set; }
        public int AulaID { get; set; }
        public int Dia1ID { get; set; }
        public DateTime HoraInicioDia1 { get; set; }
        public DateTime HoraFinDia1 { get; set; }
        public int Dia2ID { get; set; }
        public DateTime HoraInicioDia2 { get; set; }
        public DateTime HoraFinDia2 { get; set; }
        public string Observaciones { get; set; }


        public DataTable ListadoDias()
        {
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = "sp_listadoDias";
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
                throw ex; //esto es temporal
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        public bool Registrar()
        {

            bool resultado = false;
            Command.CommandText = "sp_crearSeccion";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@centroID", this.CentroID);
            Command.Parameters.AddWithValue("@profesorID", this.ProfesorID);
            Command.Parameters.AddWithValue("@asignaturaID", this.AsignaturaID);
            Command.Parameters.AddWithValue("@capacidad", this.Capacidad);
            Command.Parameters.AddWithValue("@aulaID", this.AulaID);
            Command.Parameters.AddWithValue("@dia1ID", this.Dia1ID);
            Command.Parameters.AddWithValue("@dia2ID", this.Dia2ID);
            Command.Parameters.AddWithValue("@HoraInicioDia1", this.HoraInicioDia1);
            Command.Parameters.AddWithValue("@HoraFinDia1", this.HoraFinDia1);
            Command.Parameters.AddWithValue("@HoraInicioDia2", this.HoraInicioDia2);
            Command.Parameters.AddWithValue("@HoraFinDia2", this.HoraFinDia2);
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
          
    }
}
