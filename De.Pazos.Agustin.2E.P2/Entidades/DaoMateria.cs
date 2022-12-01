using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DaoMateria
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static DaoMateria()
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


        public static List<Materia> GetListMaterias()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = $"SELECT idMateria,nombreMateria,cuatrimestre,correlativas,estadoProfesor,id,nombre,apellido,dni,pass,gmail " +
                    $"FROM Materia inner join Usuario on Materia.idProfesor = Usuario.id";
                _sqlConnection.Open();
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Materia materia = (Materia)sqlDataReader;
                    materias.Add(materia);
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
            return materias;
        }
        public static List<string> GetNombreMateriasSinAsignar()
        {
            List<string> nombresMaterias = new List<string>();
            string aux;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT nombreMateria FROM Materia WHERE Materia.idProfesor is null";
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    aux = sqlDataReader["nombreMateria"].ToString() ?? "";
                    if (aux is not null)
                    {
                        nombresMaterias.Add(aux);
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
            return nombresMaterias;
        }


        public static List<string> GetNombreMateriasConProfesor()
        {
            List<string> nombresMaterias = new List<string>();
            string aux;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT nombreMateria FROM Materia WHERE Materia.idProfesor is not null";
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    aux = sqlDataReader["nombreMateria"].ToString() ?? "";
                    if (aux is not null)
                    {
                        nombresMaterias.Add(aux);
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
            return nombresMaterias;
        }

        public static bool ModificarEstadoProfesor(string nombreMateria, string nombreCompleto)//REVISAR
        {
            bool todoOk = false;
            int idProfesor = 0;
            idProfesor = DaoProfesor.GetIdProfesorPorNombre(nombreCompleto);
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"UPDATE Materia set Materia.idProfesor = @idProfesor where nombreMateria = @nombre";
                _sqlCommand.Parameters.AddWithValue("@idProfesor", idProfesor);
                _sqlCommand.Parameters.AddWithValue("@nombre", nombreMateria);
                _sqlCommand.ExecuteNonQuery();
                _sqlCommand.Parameters.Clear();
                _sqlCommand.CommandText = $"UPDATE Materia set Materia.estadoProfesor = @estadoProfesor where nombreMateria = @nombre";
                _sqlCommand.Parameters.AddWithValue("@estadoProfesor", 1);
                _sqlCommand.Parameters.AddWithValue("@nombre", nombreMateria);
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

        public static List<Materia> CargarDatosmateriasAlumno(Alumno a)
        {
            List<Materia> materias;
            materias = DaoMateria.GetListMaterias();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = $"SELECT * FROM Materia inner join MateriaCursada on Materia.nombreMateria = MateriaCursada.NombreMateriaC Where MateriaCursada.estadoCursada = 0";
                _sqlConnection.Open();
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    foreach (Materia item in materias)
                    {
                        if (item.Nombre == sqlDataReader["nombreMateria"].ToString() && a.Id == (int)sqlDataReader["idAlumno"])
                        {
                            _ = item + a;
                        }
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
            return materias;
        }

        public static bool AgregarMateriaCAlumnoInscripto(string nombreMateria, int idAlumno)
        {
            bool todoOk = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"INSERT INTO MateriaCursada (idAlumno,nombreMateriaC,notaPrimerParcial,notaSegundoParcial,asistencia,regularidad,estadoCursada,notaFinal) VALUES (@idAlumno,@nombreMateriaC,@notaPrimerParcial,@notaSegundoParcial,@asistencia,@regularidad,@estadoCursada,@notaFinal)";
                _sqlCommand.Parameters.AddWithValue("@idAlumno", idAlumno);
                _sqlCommand.Parameters.AddWithValue("@nombreMateriaC", nombreMateria);
                _sqlCommand.Parameters.AddWithValue("@notaPrimerParcial", 0);
                _sqlCommand.Parameters.AddWithValue("@notaSegundoParcial", 0);
                _sqlCommand.Parameters.AddWithValue("@asistencia", 0);
                _sqlCommand.Parameters.AddWithValue("@regularidad", 1);
                _sqlCommand.Parameters.AddWithValue("@estadoCursada", 0);
                _sqlCommand.Parameters.AddWithValue("@notaFinal", 0);
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
        public static List<Materia> GetMatariasProfesor(int idProfesor)
        {

            List<Materia> materias = new List<Materia>();
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT * FROM Materia inner join Usuario on Usuario.id = Materia.idProfesor Where idProfesor = @idProfe";
                _sqlCommand.Parameters.AddWithValue("@idProfe", idProfesor);

                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Materia materia = (Materia)sqlDataReader;
                    if (materia is not null)
                    {
                        materias.Add(materia);
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
            return materias;
        }
    }
}
