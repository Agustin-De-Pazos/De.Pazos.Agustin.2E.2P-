using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Alumno : Usuario
    {
        private List<MateriaCursada> _materiasCursadas;

        public Alumno(int id, string gmail, string nombre, string apellido, int dni, string pass) : base(id, gmail, nombre, apellido, dni, pass)
        {
            _materiasCursadas = new List<MateriaCursada>();
        }
        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Alumno;
            }

        }


        public static bool CambiarEstado(Alumno unAlumno, eRegularidad regularidad, string nombreMateria)
        {
            bool todoOk = false;
            foreach (MateriaCursada item in unAlumno._materiasCursadas)
            {
                if (item.Nombre == nombreMateria && item.Estado == eEstadoCursada.Cursando)
                {
                    todoOk = true;
                    item.Regularidad = regularidad;
                }
            }
            return todoOk;
        }


        public void HarcodearAlumnos(MateriaCursada m)
        {
            this._materiasCursadas.Add(m);
        }

        public List<MateriaCursada> GetMateriasCursada()
        {
            return _materiasCursadas;
        }
        public static string InscribirseMateria(Alumno unAlumno, Materia? unaMateria)
        {
            string mensaje = "ERROR";
            if (unaMateria is not null)
            {
                if (!(unaMateria == unAlumno))
                {
                    if (unaMateria.Correlativas != "No")
                    {
                        foreach (MateriaCursada item in unAlumno._materiasCursadas)
                        {
                            if (item.Estado == eEstadoCursada.Aprobo && item.Nombre == unaMateria.Nombre)
                            {
                                mensaje = $"Aprobo la materia con: {unaMateria.Profesor.Nombre}";
                            }
                            if (item.Estado == eEstadoCursada.Aprobo && item.Nombre == unaMateria.Correlativas)
                            {
                                if (AddMateriaListAlumnoAddMateriaCursando(unaMateria, unAlumno))
                                {
                                    mensaje = "Materia inscripta";
                                    break;
                                }
                            }
                            else
                            {
                                mensaje = "No aprobo la correlativa";
                            }
                        }
                    }
                    else
                    {
                        if (!unAlumno.AproboMateria(unaMateria.Nombre))
                        {
                            mensaje = "Materia inscripta";
                        }
                        else
                        {
                            mensaje = "Aprobo Materia";
                        }
                    }
                }
                else
                {
                    mensaje = "Ya esta inscripto";
                }
            }
            if (mensaje == "Materia inscripta")
            {
                if (!DaoMateria.AgregarMateriaCAlumnoInscripto(unaMateria!.Nombre, unAlumno.Id))
                {
                    mensaje = "no se pudo cargar en la base de datos";
                }
            }
            return mensaje;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            bool ok = false;
            if (a1.Gmail == a2.Gmail)
            {
                ok = true;
            }
            return ok;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public MateriaCursada? GetMateriaCursada(string unaMateria)
        {
            MateriaCursada? aux = null;
            if (unaMateria is not null)
            {
                foreach (MateriaCursada item in _materiasCursadas)
                {
                    if (item.Estado == eEstadoCursada.Cursando && item.Nombre == unaMateria)
                    {
                        aux = item;
                        break;
                    }
                }
            }
            return aux;
        }
        public List<MateriaCursada> GetListMateriasCursadas()
        {
            return _materiasCursadas;
        }
        public bool DarAsistencia(string nombreMateria)
        {
            bool todoOk = false;
            MateriaCursada? materiaCursada;
            materiaCursada = GetMateriaCursada(nombreMateria);
            if (materiaCursada is not null && materiaCursada.Estado == eEstadoCursada.Cursando)
            {
                materiaCursada.Asistencia = eAsistencia.Presente;
                todoOk = true;
            }
            return todoOk;
        }

        public static bool AddMateriaListAlumnoAddMateriaCursando(Materia unaMateria, Alumno unAlumno)
        {
            MateriaCursada aux;
            bool todoOk = false;
            if (unaMateria + unAlumno)
            {
                aux = new(unaMateria.Nombre, eEstadoCursada.Cursando, eRegularidad.Regular);
                unAlumno._materiasCursadas.Add(aux);
                todoOk = true;
            }
            return todoOk;
        }

        public bool AproboMateria(string nombreMateria)
        {
            bool todoOk = false;
            foreach (MateriaCursada item in _materiasCursadas)
            {
                if (item.Estado == eEstadoCursada.Aprobo && item.Nombre == nombreMateria)
                {
                    todoOk = true;
                    break;
                }
            }
            return todoOk;
        }
        public static explicit operator Alumno(SqlDataReader v)
        {
            Alumno nuevo = new Alumno(
            Convert.ToInt32(v["id"]),
            v["gmail"].ToString() ?? "",
            v["nombre"].ToString() ?? "",
            v["apellido"].ToString() ?? "",
            Convert.ToInt32(v["dni"]),
            v["pass"].ToString() ?? "");

            return nuevo;
        }

        public static bool operator ==(List<Alumno> alumnos, Alumno a)
        {
            bool ok = false;
            foreach (Alumno item in alumnos)
            {
                if ((Usuario)item == a)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public static bool operator !=(List<Alumno> u, Alumno a)
        {
            return !(u == a);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }

}