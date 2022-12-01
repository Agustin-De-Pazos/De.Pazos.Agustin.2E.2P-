using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DaoProfesor
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static DaoProfesor()
        {
            _sqlConnection = new SqlConnection(@"
                Data Source = .;
                Database = Parcial;
                Trusted_Connection = True;
            ");

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        /// Retorna el id del profesor por su nombre completo
        /// </summary>
        public static int GetIdProfesorPorNombre(string nombreCompleto)
        {
            int aux = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT * FROM Usuario WHERE CONCAT(nombre, ' ', apellido) = @nombre";
                _sqlCommand.Parameters.AddWithValue("@nombre", nombreCompleto);
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    aux = Convert.ToInt32(sqlDataReader["id"]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return aux;
        }
        /// <summary>
        /// retorna una lista de profesores
        /// </summary>
        public static List<Profesor> GetProfesores()
        {
            List<Profesor> profesores = new List<Profesor>();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = $"SELECT * FROM Usuario inner join Roles on Usuario.idRol = Roles.id WHERE Roles.rol = 'Profesor'";
                _sqlConnection.Open();
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Profesor profesor = (Profesor)sqlDataReader;
                    if (!(profesores == profesor))
                    {
                        profesores.Add(profesor);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return profesores;
        }

        /// <summary>
        /// retorna una lista de nombre de materias que dicta el profesor pasado el id por parametro
        /// </summary>
        public static List<string> GetProfesorMaterias(int idProfe)
        {
            List<string> materiasNombre = new List<string>();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT nombreMateria FROM Materia inner join Usuario on Usuario.id = Materia.idProfesor WHERE idProfesor = @idProfe";
                _sqlCommand.Parameters.AddWithValue("@idProfe", idProfe);

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string aux = sqlDataReader["nombreMateria"].ToString() ?? "";
                    materiasNombre.Add(aux);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return materiasNombre;
        }
        public static List<Alumno> GetMateriasProfesorAlumno(int idProfe, string nombreMateria)
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT id,nombre,apellido,gmail,dni,pass FROM Materia inner join" +
                    $" MateriaCursada on MateriaCursada.nombreMateriaC = Materia.nombreMateria inner join" +
                    $" Usuario on Usuario.id = idAlumno Where Materia.nombreMateria = @nombreMateria and idProfesor = @idProfe and idRol = 2 and estadoCursada = 0";
                _sqlCommand.Parameters.AddWithValue("@idProfe", idProfe);
                _sqlCommand.Parameters.AddWithValue("@nombreMateria", nombreMateria);

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Alumno aux = (Alumno)sqlDataReader;
                    alumnos.Add(aux);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return alumnos;
        }
        /// <summary>
        /// REtorna una lista de nombre de materias de todos los profesores que asignado a alguna
        /// </summary>
        public static List<string> GetMateriasProfesores()
        {
            List<string> materiasNombre = new List<string>();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT nombreMateria FROM Materia inner join Usuario on Usuario.id = Materia.idProfesor";
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string aux = sqlDataReader["nombreMateria"].ToString() ?? "";
                    materiasNombre.Add(aux);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return materiasNombre;
        }

        public static int modificarMateria(int notaPrimerParcial, int notaSegundoParcial, int notaFinal, string nombreMateria, string mensaje, int id)
        {
            int modificaciones = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"UPDATE MateriaCursada set notaPrimerParcial = @notaPrimerParcial, notaSegundoParcial = @notaSegundoParcial, notaFinal = @notaFinal, estadoCursada = @estadoCursada, regularidad = @regularidad WHERE idAlumno = @idAlumno and nombreMateriaC = @nombreMateria and estadoCursada = 0";
                _sqlCommand.Parameters.AddWithValue("@nombreMateria", nombreMateria);
                _sqlCommand.Parameters.AddWithValue("@idAlumno", id);
                _sqlCommand.Parameters.AddWithValue("@notaPrimerParcial", notaPrimerParcial);
                _sqlCommand.Parameters.AddWithValue("@notaSegundoParcial", notaSegundoParcial);
                _sqlCommand.Parameters.AddWithValue("@notaFinal", notaFinal);
                

                if (mensaje == "Calificado exitosamente (Aprobo)")
                {
                    _sqlCommand.Parameters.AddWithValue("@estadoCursada", 1);
                    _sqlCommand.Parameters.AddWithValue("@regularidad", 1);
                }
                else if (mensaje == "Calificado exitosamente (Desaprobo)")
                {
                    _sqlCommand.Parameters.AddWithValue("@estadoCursada", 2);
                    _sqlCommand.Parameters.AddWithValue("@regularidad", 1);
                }
                else if (mensaje == "Desaprobo: quedo libre")
                {
                    _sqlCommand.Parameters.AddWithValue("@estadoCursada", 2);
                    _sqlCommand.Parameters.AddWithValue("@regularidad", 0);
                }
                
                modificaciones = _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }

            return modificaciones;
        }

        /// <summary>
        /// Crea un examen con los datos pasados por parametros
        /// </summary>
        public static bool CrearExamen(DateTime fecha, string nombreExamen, string nombreMateria, int idProfesor)
        {
            bool todoOk = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"INSERT INTO Examen (fecha,nombre,materia,idProfesor) VALUES (@fecha,@nombre,@materia,@idProfesor)";
                _sqlCommand.Parameters.AddWithValue("@fecha", fecha);
                _sqlCommand.Parameters.AddWithValue("@nombre", nombreExamen);
                _sqlCommand.Parameters.AddWithValue("@materia", nombreMateria);
                _sqlCommand.Parameters.AddWithValue("@idProfesor", idProfesor);
                _sqlCommand.ExecuteNonQuery();
                todoOk = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return todoOk;
        }

        /// <summary>
        /// retorna una lista de examenes por el id del profesor
        /// </summary>
        public static List<Examen> GetExamenesProfesor(int idProfe)
        {
            List<Examen> examenes = new List<Examen>();
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT * FROM Examen WHERE idProfesor = @idProfe";
                _sqlCommand.Parameters.AddWithValue("@idProfe", idProfe);

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Examen aux = (Examen)sqlDataReader;
                    examenes.Add(aux);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return examenes;
        }

        /// <summary>
        /// Retornar el id del profesor buscandolo por el nombre de la materia
        /// </summary>
        public static int GetIdProfesorMateria(string nombreMateria)
        {
            int aux = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT idProfesor FROM Materia m inner join Usuario u on m.idProfesor = u.id WHERE m.nombreMateria = @nombreMateria";
                _sqlCommand.Parameters.AddWithValue("@nombreMateria", nombreMateria);

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    aux = Convert.ToInt32(sqlDataReader["idProfesor"]);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (_sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return aux;
        }
    }
}
