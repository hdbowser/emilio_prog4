using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using INF518Core.Clases;
using System.Data.Sql;

namespace INF518Core.Inscripcion
{
    public class Mantenimiento : MantenimientoBase
    {

        public Estudiante GetEstudianteInfo(int ID)
        {
            Estudiante item = new Estudiante();
            string sql = string.Format("SELECT ID, Nombre, Apellido, Cedula, FechaNacimiento, Matricula, IDTipoEstudiante, EstadoCivil, TelefonoCasa, TelefonoMovil, Email, Observaciones FROM tblEstudiantes WHERE ID={0}", ID);
            SqlDataReader reader;
            try
            {
                Connection.Open();
                Command.CommandText = sql;
                Command.CommandType = CommandType.Text;
                reader = Command.ExecuteReader(); //Devuelve un SQlDaatReader
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item.ID = ID;
                        item.Nombre = reader["Nombre"].ToString();
                        item.Apellido = reader["Apellido"].ToString();
                        item.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        //reader.GetDateTime(0)
                        item.Cedula = reader.GetString(3);
                        item.Matricula = reader["Matricula"].ToString();
                        item.IDTipodeEstudiante = Convert.ToInt16(reader["IDTipoEstudiante"].ToString());
                        item.EstadoCivil = reader["EstadoCivil"].ToString();
                        item.TelefonoCasa = reader["TelefonoCasa"].ToString();
                        item.TelefonoMovil = reader["TelefonoMovil"].ToString();
                        item.TelefonoMovil = reader["TelefonoMovil"].ToString();
                        item.Email = reader["Email"].ToString();
                        item.Observaciones = reader["Observaciones"].ToString();
                       // item.IDCarrera = Convert.ToInt16( reader["IDCarrera"].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex; //temporal
            }
            finally
            {
                Connection.Close();
            }

            return item;
        }

        public Profesor getListadoProfesor(int iD)
        {
            throw new NotImplementedException();
        }

        public void GuardarEstudiante()
        {
            throw new NotImplementedException();
        }

        public void GuardarEstudianteSP(Estudiante item)
        {
            Command.CommandText = "tblEstudiantes_sp_Guardar";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@ID", item.ID);
            Command.Parameters.AddWithValue("@Nombre", item.Nombre);
            Command.Parameters.AddWithValue("@Apellido", item.Apellido);
            Command.Parameters.AddWithValue("@FechaNacimiento", item.FechaNacimiento);
            Command.Parameters.AddWithValue("@Cedula", item.Cedula);
            Command.Parameters.Add("@retVal", SqlDbType.Int);
            Command.Parameters["@retVal"].Direction = ParameterDirection.Output;
            try
            {
                Connection.Open();
                Command.ExecuteNonQuery();
                if (Command.Parameters["@retVal"].Value.ToString() == "0")
                {
                    Error.ID = 1;
                    Error.Mensaje= "NO";
                }
            }
            catch(Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
            }
            finally
            {
                Connection.Close();
            }
        }

        

        public bool GuardarEstudiante(Estudiante item)
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            if (item.ID == 0)
            {
                sql.Append("INSERT INTO tblEstudiantes ");
                sql.Append(" (Cedula, FechaNacimiento, Nombre, Apellido) ");
                sql.AppendFormat(" VALUES ('{0}','{1}','{2}','{3}'); ",
                    item.Cedula,
                    item.FechaNacimiento,
                    item.Nombre,
                    item.Apellido
                    );
            }
            if(item.ID>0)
            {
                sql.Append("UPDATE tblEstudiantes SET ");
                sql.AppendFormat("Nombre='{0}'", item.Nombre);
                sql.AppendFormat(" ,Apellido='{0}'", item.Apellido);
                sql.AppendFormat(" ,Cedula='{0}'", item.Cedula);
                sql.AppendFormat(" ,FechaNacimiento='{0}'", item.FechaNacimiento);
                sql.AppendFormat(" WHERE ID={0}", item.ID);
            }
            try
            {
                Connection.Open();
                Command.CommandText = sql.ToString();
                Command.CommandType = CommandType.Text;
                if (Command.ExecuteNonQuery() > 0)
                    r = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Connection.Close();
            }
            return r;
        }

       


        public DataTable getListadoPersonas(string filtro)
        {
            DataTable dt = new DataTable();
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT ID, Nombre, Apellido, Cedula, FechaNacimiento [Fecha] ");
            sql.Append(" FROM tblEstudiantes ");
            if (filtro.Trim().Length > 0)
            {
                sql.Append(" WHERE ");
                sql.Append(filtro);
            }
            sql.Append(" ORDER BY ID, Nombre, Apellido, Cedula");
            Command.CommandText = sql.ToString();//cambiar esto por una tabla existente
            Command.CommandType = CommandType.Text;
            Adapter = new SqlDataAdapter(Command);
            try
            {
                Connection.Open();
                Adapter.Fill(dt); //se asigna todo al datatable
            }
            catch(Exception ex)
            {
                throw ex; //esto es temporal
            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }
        public DataTable getListadoProfesor(string filtro)
        {
            DataTable dt = new DataTable();
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT ID, Nombre, Apellido, Cedula, FechaNacimiento [Fecha] ");
            sql.Append(" FROM tblProfesor ");
            if (filtro.Trim().Length > 0)
            {
                sql.Append(" WHERE ");
                sql.Append(filtro);
            }
            sql.Append(" ORDER BY ID, Nombre, Apellido, Cedula");
            Command.CommandText = sql.ToString();//cambiar esto por una tabla existente
            Command.CommandType = CommandType.Text;
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
        public Profesor GetProfesorInfo(int ID)
        {
            Profesor item = new Profesor();
            string sql = string.Format("SELECT ID, Nombre, Apellido, Cedula, FechaNacimiento, EstadoCivil, TelefonoCasa, TelefonoMovil, Email, Observaciones FROM tblProfesor WHERE ID={0}", ID);
            SqlDataReader reader;
            try
            {
                Connection.Open();
                Command.CommandText = sql;
                Command.CommandType = CommandType.Text;
                reader = Command.ExecuteReader(); //Devuelve un SQlDaatReader
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        item.ID = ID;
                        item.Nombre = reader["Nombre"].ToString();
                        item.Apellido = reader["Apellido"].ToString();
                        item.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        //reader.GetDateTime(0)
                        item.Cedula = reader.GetString(3);
                        item.EstadoCivil = reader["EstadoCivil"].ToString();
                        item.TelefonoCasa = reader["TelefonoCasa"].ToString();
                        item.TelefonoMovil = reader["TelefonoMovil"].ToString();
                        item.TelefonoMovil = reader["TelefonoMovil"].ToString();
                        item.Email = reader["Email"].ToString();
                        item.Observaciones = reader["Observaciones"].ToString();
                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; //temporal
            }
            finally
            {
                Connection.Close();
            }

            return item;
        }

        public void Actualizar(int ID )
        {
            try
            {   
               
                Connection.Open();
                string sql = string.Format("UPDATE tblEstudiantes set Nombre = @Nombre   WHERE ID={0}", ID);

            }
            catch (Exception e)
            {
                
            }
            finally
            {
                Connection.Close();
            }

        }


    }

   

  
}
