using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Estudiante : MantenimientoBase
    {
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public int TipodeEstudianteID { get; set; }
        public string Matricula { get; set; }
        public char Sexo { get; set; }
        public char EstadoCivil { get; set; }
        public string TelefonoCasa { get; set; }
        public string TelefonoMovil{ get; set; }
        public string Email { get; set; }
        public string Observaciones { get; set; }
        public int CarreraID { get; set; }
        public double Balance { get; set; }
        public bool Inacivo { get; set; }

        public bool Matricular()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_matricularEstudiante";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@nombre", this.Nombre);
                Command.Parameters.AddWithValue("@apellido", this.Apellido);
                Command.Parameters.AddWithValue("@fechaNacimiento", this.FechaNacimiento);
                Command.Parameters.AddWithValue("@cedula", this.Cedula);
                Command.Parameters.AddWithValue("@tipoEstudianteID", this.TipodeEstudianteID);
                Command.Parameters.AddWithValue("@sexo", this.Sexo);
                Command.Parameters.AddWithValue("@estadoCivil", this.EstadoCivil);
                Command.Parameters.AddWithValue("@telefonoCasa", this.TelefonoCasa);
                Command.Parameters.AddWithValue("@telefonoMovil", this.TelefonoMovil);
                Command.Parameters.AddWithValue("@email", this.Email);
                Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
                Command.Parameters.AddWithValue("@CarreraID", this.CarreraID);

                if (Command.ExecuteNonQuery() > 0)
                {
                    Connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return false;
        }

        public DataTable Buscar(string busquedsa)
        {
            DataTable dt = new DataTable();
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_buscarEstudiantes";
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
        public Estudiante Detalle()
        {
            try
            {
                this.Connection.Open();
                this.Command = Connection.CreateCommand();
                this.Command.CommandType = CommandType.StoredProcedure;
                this.Command.CommandText = "sp_detalleEstudiante";
                this.Command.Parameters.AddWithValue("@estudianteID", this.EstudianteID);

                SqlDataReader reader = Command.ExecuteReader();

                if (reader != null && reader.HasRows)
                {
                    if (reader.Read())
                    {
                        this.Nombre = reader["Nombre"].ToString();
                        this.Apellido = reader["Apellido"].ToString();
                        this.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"].ToString());
                        this.Sexo = Convert.ToChar(reader["Sexo"]);
                        this.Cedula = reader["Cedula"].ToString();
                        this.TipodeEstudianteID = Convert.ToInt32(reader["TipoEstudianteID"].ToString());
                        this.Sexo = Convert.ToChar(reader["Sexo"].ToString());
                        this.EstadoCivil = Convert.ToChar(reader["EstadoCivil"].ToString());
                        this.TelefonoCasa = reader["TelefonoCasa"].ToString();
                        this.TelefonoMovil = reader["TelefonoMovil"].ToString();
                        this.Email = reader["Email"].ToString();
                        this.Observaciones = reader["Observaciones"].ToString();
                        this.Matricula = reader["Matricula"].ToString();
                        this.CarreraID = Convert.ToInt32(reader["CarreraID"].ToString());
                        this.Balance = Convert.ToDouble(reader["Balance"].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                this.Connection.Close();
            }
            return this;
        }

        public bool Actualizar()
        {
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandText = "sp_actualizarEstudiante";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@estudianteID", this.EstudianteID);
                Command.Parameters.AddWithValue("@nombre", this.Nombre);
                Command.Parameters.AddWithValue("@apellido", this.Apellido);
                Command.Parameters.AddWithValue("@fechaNacimiento", this.FechaNacimiento);
                Command.Parameters.AddWithValue("@cedula", this.Cedula);
                Command.Parameters.AddWithValue("@tipoEstudianteID", this.TipodeEstudianteID);
                Command.Parameters.AddWithValue("@sexo", this.Sexo);
                Command.Parameters.AddWithValue("@estadoCivil", this.EstadoCivil);
                Command.Parameters.AddWithValue("@telefonoCasa", this.TelefonoCasa);
                Command.Parameters.AddWithValue("@telefonoMovil", this.TelefonoMovil);
                Command.Parameters.AddWithValue("@email", this.Email);
                Command.Parameters.AddWithValue("@observaciones", this.Observaciones);
                Command.Parameters.AddWithValue("@CarreraID", this.CarreraID);

                if (Command.ExecuteNonQuery() > 0)
                {
                    Connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Error.ID = 1; // 1: hay un error
                Error.Mensaje = ex.Message; //el mensaje de error
                return false;
            }
            finally
            {
                Connection.Close();
            }
            return false;
        }


        public Inscripcion VerificarInscripcionExistente()
        {
            Inscripcion ins = new Inscripcion();
            try
            {
                Connection.Open();
                Command = Connection.CreateCommand();
                Command.CommandType = CommandType.StoredProcedure;
                Command.CommandText = "sp_verificarInscipcionExistente";
                Command.Parameters.AddWithValue("@estudianteID", this.EstudianteID);
                SqlDataReader reader;
                reader = Command.ExecuteReader();
                if (reader != null)
                {
                    if (reader.HasRows)
                    {
                        if (reader.Read())
                        {
                            ins.InscripcionID = Convert.ToInt32(reader["InscripcionID"].ToString());
                            ins.EstudianteID = this.EstudianteID;
                            ins.Fecha = Convert.ToDateTime(reader["Fecha"].ToString());
                            ins.NombareEstudiante = this.Nombre + " " + this.Apellido;
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
            return ins;
        }

    }
}
