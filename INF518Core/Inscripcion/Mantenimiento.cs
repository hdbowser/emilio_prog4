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
            return new Estudiante();
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
       /* public Profesor GetProfesorInfo(int ID)
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
        }*/

        public void Actualizar(int ID )
        {
            try
            {   
               
                Connection.Open();
                string sql = string.Format("UPDATE tblEstudiantes set Nombre = @Nombre   WHERE ID={0}", ID);

            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                Connection.Close();
            }

        }


    }

   

  
}
