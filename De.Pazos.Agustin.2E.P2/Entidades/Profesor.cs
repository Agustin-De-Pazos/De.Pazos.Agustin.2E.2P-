using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Entidades
{
    public class Profesor : Usuario
    {
        private List<Examen> _examenes;

        public Profesor(int id, string gmail, string nombre, string apellido, int dni, string pass) : base(id, gmail, nombre, apellido, dni, pass)
        {
            _examenes = new List<Examen>();
        }

        public override EPermisos Permisos
        {
            get
            {
                return EPermisos.Profesor;
            }

        }

        public List<Examen> Examenes { get => _examenes; set => _examenes = value; }

        public bool NuevoExamen(DateTime fecha, string nombre, string nombreMateria)
        {
            bool todoOk = false;
            if (fecha >= DateTime.Now && nombre is not null && nombreMateria is not null)
            {
                DaoProfesor.CrearExamen(fecha, nombre, nombreMateria, this.Id);
                todoOk = true;
            }
            return todoOk;
        }
        public override string ToString()
        {
            return Nombre;
        }
        public List<Examen> ListaExamen()
        {
            return _examenes.ToList();
        }
        public static string? CierreDeNotas(string nombreMateria, string nombreAlumno, int primerNota, int segundaNota)
        {
            string? mensaje = null;
            Alumno? unAlumno;
            int notaFinal = 0;
            MateriaCursada? materiaEnCurso;
            if (nombreMateria is not null && nombreAlumno is not null)
            {
                unAlumno = DaoAlumno.GetAlumnoNombreCompleto(nombreAlumno);
                //DaoAlumno.GetAlumnoActualizar()
                if (unAlumno is not null)
                {
                    materiaEnCurso = unAlumno.GetMateriaCursada(nombreMateria);

                    if (materiaEnCurso!.Regularidad == eRegularidad.Regular)
                    {
                        if (materiaEnCurso.Asistencia == eAsistencia.Presente)
                        {
                            if (primerNota > 6 && segundaNota > 6)
                            {
                                //_ = unaMateria - unAlumno;
                                //materiaEnCurso.Estado = eEstadoCursada.Aprobo;
                                //materiaEnCurso.NotaPrimerParcial = primerNota;
                                //materiaEnCurso.NotaSegundoParcial = segundaNota;
                                mensaje = "Calificado exitosamente (Aprobo)";

                            }
                            else
                            {
                                //_ = unaMateria - unAlumno;
                                //materiaEnCurso.Estado = eEstadoCursada.Desaprobo;
                                //materiaEnCurso.NotaPrimerParcial = primerNota;
                                //materiaEnCurso.NotaSegundoParcial = segundaNota;
                                mensaje = "Calificado exitosamente (Desaprobo)";
                            }
                        }
                        else
                        {
                            //_ = unaMateria - unAlumno;
                            //materiaEnCurso.Estado = eEstadoCursada.Desaprobo;
                            //materiaEnCurso.Regularidad = eRegularidad.Libre;
                            //materiaEnCurso.NotaPrimerParcial = primerNota;
                            //materiaEnCurso.NotaSegundoParcial = segundaNota;
                            mensaje = "Desaprobo: quedo libre";
                        }

                    }
                    else
                    {
                        //_ = unaMateria - unAlumno;
                        //materiaEnCurso.Estado = eEstadoCursada.Desaprobo;
                        //materiaEnCurso.NotaPrimerParcial = primerNota;
                        //materiaEnCurso.NotaSegundoParcial = segundaNota;
                        mensaje = "Desaprobo: quedo libre";
                    }

                }
                if (primerNota > 0 || segundaNota > 0)
                {
                    notaFinal = CalcularPromedio(primerNota, segundaNota);
                }
                if (DaoProfesor.modificarMateria(primerNota, segundaNota, notaFinal, nombreMateria, mensaje ?? "", unAlumno!.Id) == 0)
                {
                    mensaje = $"No se pudo guardar en la base de datos";
                }
            }
            else
            {
                mensaje = "Datos mal ingresados";
            }
            return mensaje;
        }


        public static explicit operator Profesor(SqlDataReader v)
        {
            Profesor nuevo = new Profesor(
            Convert.ToInt32(v["id"]),
            v["gmail"].ToString() ?? "",
            v["nombre"].ToString() ?? "",
            v["apellido"].ToString() ?? "",
            Convert.ToInt32(v["dni"]),
            v["pass"].ToString() ?? "");

            return nuevo;
        }
        public static bool operator ==(List<Profesor> profesores, Profesor p)
        {
            bool ok = false;
            foreach (Profesor item in profesores)
            {
                if ((Usuario)item == p)
                {
                    ok = true;
                }
            }
            return ok;
        }
        public static int CalcularPromedio(int nota1, int nota2)
        {
            return (nota1 + nota2) / 2;
        }
        public static bool operator !=(List<Profesor> p, Profesor a)
        {
            return !(p == a);
        }
    }
}
