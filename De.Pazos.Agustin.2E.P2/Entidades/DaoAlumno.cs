using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DaoAlumno
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static DaoAlumno()
        {
            _sqlConnection = new SqlConnection(@"
                Data Source = .;
                Database = Parcial;
                Trusted_Connection = True;
            "
            );

            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
            _sqlCommand.CommandType = System.Data.CommandType.Text;
        }

        public static int cantidadMateriasAlumno(int idAlumno)
        {
            int cantidadM = 0;
            try
            {

                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT COUNT(*) MateriasCursada FROM MateriaCursada WHERE idAlumno = @idAlumno AND estadoCursada = 0";

                _sqlCommand.Parameters.AddWithValue("@idAlumno", idAlumno);
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    cantidadM = (int)sqlDataReader[0];
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
            return cantidadM;
        }
        public static bool GetAlumnoActualizar(Alumno? alumno)
        {
            bool todoOk = false;
            int idAlumno = alumno!.Id;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT nombreMateriaC,notaPrimerParcial,notaSegundoParcial,asistencia,regularidad,estadoCursada,notaFinal FROM MateriaCursada inner join Usuario on Usuario.id = MateriaCursada.idAlumno WHERE idAlumno = @idAlumno";

                _sqlCommand.Parameters.AddWithValue("@idAlumno", idAlumno);
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    MateriaCursada nuevaMateria = (MateriaCursada)sqlDataReader;
                    if (nuevaMateria is not null)
                    {
                        alumno.HarcodearAlumnos(nuevaMateria);
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
            return todoOk;
        }

        public static List<Alumno> GetAlumno()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT * FROM Usuario inner join Roles on Usuario.idRol = Roles.id WHERE Roles.rol = 'Alumno'";

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Alumno alumno = (Alumno)sqlDataReader;
                    if (!(alumnos == alumno))
                    {
                        alumnos.Add(alumno);
                    }
                }
                //_sqlCommand.ExecuteNonQuery();

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

        public static bool DarAsistencia(string nombreMateria, int idAlumn)
        {
            bool todoOk = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"UPDATE MateriaCursada set MateriaCursada.asistencia = @asistencia  where idAlumno = @idAlumn and nombreMateriaC = @nombreMateria and estadoCursada = 0";
                _sqlCommand.Parameters.AddWithValue("@asistencia", 1);
                _sqlCommand.Parameters.AddWithValue("@idAlumn", idAlumn);
                _sqlCommand.Parameters.AddWithValue("@nombreMateria", nombreMateria);
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
        public static Alumno? GetAlumnoNombreCompleto(string nombreCompleto)
        {
            Alumno? alumno = null;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT * FROM Usuario WHERE CONCAT(nombre, ' ', apellido) = @nombre";
                _sqlCommand.Parameters.AddWithValue("@nombre", nombreCompleto);
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    alumno = (Alumno)sqlDataReader;
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
            GetAlumnoActualizar(alumno);
            return alumno;
        }

        
        public static List<Alumno> listaAlumnosCursandoMateria(string nombreMateria)
        {

            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT id, nombre, apellido, gmail, dni,pass FROM Materia m" +
                    $" inner join MateriaCursada mc " +
                    $"on mc.nombreMateriaC = m.nombreMateria inner join Usuario u on u.id = idAlumno " +
                    $"Where m.nombreMateria = @nombreMateria and mc.estadoCursada = 0";
                _sqlCommand.Parameters.AddWithValue("@nombreMateria", nombreMateria);

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Alumno alumno = (Alumno)sqlDataReader;
                    if (alumno is not null)
                    {
                        alumnos.Add(alumno);
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
            return alumnos;
        }
    }
}
