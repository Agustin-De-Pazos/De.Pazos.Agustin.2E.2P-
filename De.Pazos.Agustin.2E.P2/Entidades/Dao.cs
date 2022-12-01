using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region SCRIPT TABLAS CAMBIAR
        /*CREATE TABLE [dbo].[Usuario](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [idRol] [int] NOT NULL,
    [nombre] [varchar](50) NOT NULL,
    [apellido] [varchar](50) NOT NULL,
    [dni] [int] NOT NULL,
    [pass] [varchar](50) NOT NULL,
    [gmail] [varchar](50) NOT NULL
    CONSTRAINT [PK_Usuario2] PRIMARY KEY CLUSTERED 
    (
    [id] ASC
    )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]

    CREATE TABLE [dbo].[Roles](
    [id] [int] NOT NULL,
    [rol] [varchar](50) NOT NULL);

    CREATE TABLE [dbo].[MateriaCursada](
    [idAlumno] [int] NOT NULL,
    [nombreMateriaC] [varchar](50) NOT NULL,
    [notaPrimerParcial] [int] NULL,
    [notaSegundoParcial] [int] NULL,
    [asistencia] [int] NOT NULL,
    [regularidad] [int] NOT NULL,
    [estadoCursada] [int] NOT NULL,
    [notaFinal] [int] NULL)


    CREATE TABLE [dbo].[Materia](
    [idMateria] [int] IDENTITY(1,1) NOT NULL,
    [nombre] [varchar](50) NOT NULL,
    [cuatrimestre] [int] NOT NULL,
    [correlativas] [varchar](50) NULL,
    [estadoProfesor] [int] NULL,
    [idProfesor] [int] NULL);

    CREATE TABLE [dbo].[Examen](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [fecha] [date] NOT NULL,
    [nombre] [varchar](50) NOT NULL,
    [materia] [varchar](50) NOT NULL,
    [idProfesor] [int] NOT NULL)*/
    #endregion// CAMBIAR

    public static class Dao
    {
        private static SqlConnection _sqlConnection;
        private static SqlCommand _sqlCommand;
        static Dao()
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
        /// Actualiza la regularidad de un alumno pasada por parametros
        /// </summary>
        public static bool CambiarRegularidadAdmin(string nombreMateria, string nombreAlumnoCompleto, int regularidad)
        {
            Alumno? alumno = null;
            bool todoOk = false;
            try
            {
                alumno = DaoAlumno.GetAlumnoNombreCompleto(nombreAlumnoCompleto);
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = "UPDATE MateriaCursada set regularidad = @regularidad FROM MateriaCursada m inner join Usuario u on u.id = m.idAlumno WHERE nombreMateriaC = @nombreMateria and estadoCursada = 0 and u.id = @id";

                _sqlCommand.Parameters.AddWithValue("@regularidad", regularidad);
                _sqlCommand.Parameters.AddWithValue("@nombreMateria", nombreMateria);
                _sqlCommand.Parameters.AddWithValue("@id", alumno!.Id);
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
        /// Agrega una materia
        /// </summary>

        public static int AddMateria(string nombre, int cuatrimestre)
        {
            int filas = 0;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = "INSERT INTO personas (nombre, cuatrimestre) VALUES(@nombre, @cuatrimestre)";

                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);

                filas = _sqlCommand.ExecuteNonQuery();
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
            return filas;
        }
        /// <summary>
        /// Agrega un profesor a la materia pasada por parametros
        /// </summary>
        public static bool AgregarProfesorMateria(Materia materia)
        {
            bool retorno = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"UPDATE  productos SET idProfesor = @idProfesor, estadoProfesor = @estadoProfesor WHERE id = @id";
                _sqlCommand.Parameters.AddWithValue("@idProfesor", materia.Profesor.Id);
                _sqlCommand.Parameters.AddWithValue("@estadoProfesor", materia.Estado.GetType());
                retorno = true;
                _sqlCommand.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return retorno;
        }
        /// <summary>
        /// Agrega un usuario con los datos pasados por parametros
        /// </summary>
        public static bool AgregarUsuario(string nombre,string apellido,string gmail, string pass,int permisos,int dni)
        {
            bool retorno = false;
            try
            {
                permisos++;
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"INSERT INTO Usuario (nombre,apellido,gmail,pass,dni,idRol) VALUES (@nombre,@apellido,@gmail,@pass,@dni,@idRol)";
                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                _sqlCommand.Parameters.AddWithValue("@gmail", gmail);
                _sqlCommand.Parameters.AddWithValue("@pass", pass);
                _sqlCommand.Parameters.AddWithValue("@dni", dni);
                _sqlCommand.Parameters.AddWithValue("@idRol", permisos);
                _sqlCommand.ExecuteNonQuery();
                retorno = true;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _sqlConnection.Close();
            }
            return retorno;
        }

        /// <summary>
        /// Retorna el maximo id de los usuarios creados
        /// </summary>
        public static int GetMaxIdUsuario()
        {

            int idMax = 1;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"SELECT id FROM Usuario WHERE id = (SELECT MAX(id) FROM Usuario)";
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    idMax = Convert.ToInt32(sqlDataReader["id"]);
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
            return idMax;
        }


        /// <summary>
        /// Verifica que el usuario pasado por parametros no exista
        /// </summary>
        /// <returns> Retorna true si existe, False no existe </returns>
        public static bool ValidarUsuario(string gmail, string apellido, int dni)
        {
            bool todoOk = false;
            try
            {
                if(gmail != "" && apellido != "" && dni != 0)
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlCommand.CommandText = $"SELECT * FROM Usuario WHERE Usuario.gmail = @gmail or Usuario.dni = @dni or Usuario.apellido = @apellido";
                    _sqlConnection.Open();
                    _sqlCommand.Parameters.AddWithValue("@gmail", gmail);
                    _sqlCommand.Parameters.AddWithValue("@apellido", apellido);
                    _sqlCommand.Parameters.AddWithValue("@dni", dni);
                    SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader["gmail"].ToString() == gmail ||
                        sqlDataReader["apellido"].ToString() == apellido ||
                         (int)sqlDataReader["dni"] == dni)
                        {
                            todoOk = true;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Valores nulos");
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
        /// <summary>
        /// 
        /// </summary>
        public static bool ValidarMateria(string nombre)//VALIDA MATERIA QUE NO EXISTA
        {
            bool todoOk = false;
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = $"SELECT nombreMateria FROM Materia WHERE nombreMateria = @nombre";
                _sqlConnection.Open();
                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["nombreMateria"].ToString() == nombre)
                    {
                        todoOk = true;
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
        public static bool AgregarMateria(string nombre, int cuatrimestre)//AGREGA MATERIA
        {
            bool todoOk = false;
            try
            {
                _sqlCommand.Parameters.Clear();
                _sqlConnection.Open();
                _sqlCommand.CommandText = $"INSERT INTO Materia (nombreMateria,cuatrimestre,correlativas,estadoProfesor) VALUES (@nombre,@cuatrimestre,'No',0)";
                _sqlCommand.Parameters.AddWithValue("@nombre", nombre);
                _sqlCommand.Parameters.AddWithValue("@cuatrimestre", cuatrimestre);
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


        public static List<Admin> GetAdmin()
        {
            List<Admin> admins = new List<Admin>();
            try
            {
                _sqlCommand.Parameters.Clear();

                _sqlCommand.CommandText = $"SELECT Usuario.id, apellido,nombre,gmail,dni,pass,idAdmin FROM Usuario inner join " +
                    $"Admin on Usuario.id = Admin.idUsuario";
                _sqlConnection.Open();
                SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Admin admin = (Admin)sqlDataReader;
                    admins.Add(admin);
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
            return admins;
        }
        /// <summary>
        /// Devuelve el usuario existente, si no existe retorna null
        /// </summary>
        /// <param name="gmail"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static Usuario? UsuarioLogin(string gmail, string pass)
        {

            //aux = DataBase.ValidarUsuario(txt_usuario.Text, txt_contraseña.Text);
            Usuario? usuario = null;
            try
            {
                if (gmail != "" && pass != "")
                {
                    _sqlCommand.Parameters.Clear();
                    _sqlConnection.Open();
                    _sqlCommand.CommandText = $"SELECT * FROM Usuario inner join Roles on Usuario.idRol = Roles.id WHERE Usuario.pass = @pass and Usuario.gmail = @gmail";
                    _sqlCommand.Parameters.AddWithValue("@gmail", gmail);
                    _sqlCommand.Parameters.AddWithValue("@pass", pass);

                    SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
                    //aux = ;
                    while (sqlDataReader.Read())
                    {
                        if (sqlDataReader["rol"].ToString() == "Admin")
                        {
                            usuario = (Admin)sqlDataReader;
                        }
                        else if (sqlDataReader["rol"].ToString() == "Profesor")
                        {
                            usuario = (Profesor)sqlDataReader;
                        }
                        else if (sqlDataReader["rol"].ToString() == "Alumno")
                        {
                            usuario = (Alumno)sqlDataReader;
                        }
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
            return usuario;
        }
    }
}
