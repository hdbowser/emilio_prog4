using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace INF518Core.Clases
{
    public class Inscripcion : MantenimientoBase
    {
        public int InscripcionID { get; set; }
        public int EstudianteID { get; set; }
        public string NombareEstudiante { get; set; }
        public DateTime Fecha { get; set; }

        public int Registrar()
        {
            int id = 0;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_registrarInscripcion";
                Command.Parameters.AddWithValue("@estudianteID", this.EstudianteID);

                SqlDataReader reader = Command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["ID"].ToString());
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

            return id;
        }

        public Inscripcion Deatlle()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_detalleInscripcion";
                Command.Parameters.AddWithValue("@inscripcionID", this.InscripcionID);

                SqlDataReader reader = Command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            this.EstudianteID = Convert.ToInt32(reader["EstudianteID"].ToString());
                            this.Fecha = Convert.ToDateTime(reader["Fecha"].ToString());
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

        public DataTable ListadoSecciones()
        {
            DataTable dtt = new DataTable();
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_listadoSeccionesInscripcion";
                Command.Parameters.AddWithValue("@inscripcionID", this.InscripcionID);
                Adapter.SelectCommand = Command;
                Adapter.Fill(dtt);
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

        public int VerificarAsignatura(int asignaturaID)
        {
            int id = 0;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_verificarAsignaturaInscripcion";
                Command.Parameters.AddWithValue("@inscripcionID", this.InscripcionID);
                Command.Parameters.AddWithValue("@asignaturaID", asignaturaID);

                SqlDataReader reader = Command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            id = Convert.ToInt32(reader["SeccionID"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                id = -1;
            }
            finally
            {
                Connection.Close();
            }

            return id;
        }

        public DataTable VerificarConflictosHorario(int seccionID)
        {
            DataTable dtt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_verificarConflictosHorariosInscripcion";
                Command.Parameters.AddWithValue("@inscripcionID", this.InscripcionID);
                Command.Parameters.AddWithValue("@seccionID", seccionID);
                Adapter.SelectCommand = Command;
                Adapter.Fill(dtt);
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

        public bool AgregarSeccion(int seccionID)
        {
            bool r = false;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_agregarSeccionAInscripcion";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@inscripcionID", this.InscripcionID);
                Command.Parameters.AddWithValue("@seccionID", seccionID);

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


        public bool EliminarSeccion(int seccionID)
        {
            bool r = false;
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_eliminarSeccionInscripcion";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@seccionID", seccionID);
                Command.Parameters.AddWithValue("@inscripcionID", this.InscripcionID);
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
