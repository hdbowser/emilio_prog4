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
            DataTable dt = new DataTable();
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_listadoDias";
                Command.CommandTimeout = 0;
                Adapter = new SqlDataAdapter(Command);
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

            bool resultado = false;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();

                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_crearSeccion";
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
        public DataTable VerificarConflictosAula()
        {
            DataTable dtt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_verificarConflictosAula";
                Command.Parameters.AddWithValue("@seccionID", this.SeccionID);
                Command.Parameters.AddWithValue("@aulaID", this.AulaID);
                Command.Parameters.AddWithValue("@dia1", this.Dia1ID);
                Command.Parameters.AddWithValue("@dia2", this.Dia2ID);
                Command.Parameters.AddWithValue("@horaInicioDia1", this.HoraInicioDia1);
                Command.Parameters.AddWithValue("@horaInicioDia2", this.HoraInicioDia2);
                Command.Parameters.AddWithValue("@horaFinDia1", this.HoraFinDia1);
                Command.Parameters.AddWithValue("@horaFinDia2", this.HoraFinDia2);

                (new SqlDataAdapter(Command)).Fill(dtt);
                return dtt;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dtt;
        }

        public DataTable VerificarConflictosProfesor()
        {
            DataTable dtt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_verificarConflictosProfesor";
                Command.Parameters.AddWithValue("@seccionID", this.SeccionID);
                Command.Parameters.AddWithValue("@profesorID", this.ProfesorID);
                Command.Parameters.AddWithValue("@dia1", this.Dia1ID);
                Command.Parameters.AddWithValue("@dia2", this.Dia2ID);
                Command.Parameters.AddWithValue("@horaInicioDia1", this.HoraInicioDia1);
                Command.Parameters.AddWithValue("@horaInicioDia2", this.HoraInicioDia2);
                Command.Parameters.AddWithValue("@horaFinDia1", this.HoraFinDia1);
                Command.Parameters.AddWithValue("@horaFinDia2", this.HoraFinDia2);

                (new SqlDataAdapter(Command)).Fill(dtt);
                return dtt;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return dtt;
        }

        public DataTable Buscar()
        {

            DataTable dt = new DataTable();
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_buscarSecciones";
                Command.Parameters.AddWithValue("@asignaturaID", this.AsignaturaID);
                Command.CommandTimeout = 0;

                Adapter = new SqlDataAdapter(Command);
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

        public Seccion Detalle()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_detalleSeccion";
                Command.Parameters.AddWithValue("@seccionID", this.SeccionID);

                SqlDataReader reader;
                reader = Command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            this.CentroID = Convert.ToInt32(reader["CentroID"].ToString());
                            this.ProfesorID = Convert.ToInt32(reader["ProfesorID"].ToString());
                            this.AsignaturaID = Convert.ToInt32(reader["AsignaturaID"].ToString());
                            this.Capacidad = Convert.ToInt32(reader["Capacidad"].ToString());
                            this.AulaID = Convert.ToInt32(reader["AulaID"].ToString());
                            this.Dia1ID = Convert.ToInt32(reader["Dia1ID"].ToString());
                            this.HoraInicioDia1 = Convert.ToDateTime(reader["HoraInicioDia1"].ToString());
                            this.HoraFinDia1 = Convert.ToDateTime(reader["HoraFinDia1"].ToString());
                            this.Dia2ID = Convert.ToInt32(reader["Dia2ID"].ToString());
                            this.HoraInicioDia2 = Convert.ToDateTime(reader["HoraInicioDia2"].ToString());
                            this.HoraFinDia2 = Convert.ToDateTime(reader["HoraFinDia2"].ToString());
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

        public bool Actualizar()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_actualizarSeccion";
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.AddWithValue("@seccionID", this.SeccionID);
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

                if (Command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
