using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Entidades
{
    public class Materia
    {
        private int _id;
        private string? nombre;
        private ECuatrimestre cuatrimestre;
        private Profesor? profesor;
        private List<Alumno> alumnos;
        private string? correlativas;
        private EStadoProfe estado;

        public Materia()
        {
            alumnos = new List<Alumno>();
        }
        
        public Materia(string nombre, ECuatrimestre cuatrimestre) : this()
        {
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.estado = EStadoProfe.Libre;
            this.correlativas = "No";
        }

        public Materia(int id, string nombre, ECuatrimestre cuatrimestre, Profesor profesor, string correlativas, EStadoProfe estado) : this()
        {
            _id = id;
            this.nombre = nombre;
            this.cuatrimestre = cuatrimestre;
            this.profesor = profesor;
            this.correlativas = correlativas;
            this.estado = estado;
        }
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => nombre!; set => nombre = value; }
        public ECuatrimestre Cuatrimestre {get => cuatrimestre; set => cuatrimestre = value;}
        public Profesor Profesor { get => profesor!; set => profesor = value; }

        public string Correlativas { get => correlativas!; set => correlativas = value; }
        public EStadoProfe Estado { get => estado; set => estado = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }

        //public Materia(string nombre, ECuatrimestre cuatrimestre,EStadoProfe estado):this()
        //{
        //    this.nombre = nombre;
        //    this.cuatrimestre = cuatrimestre;
        //    this.estado = estado;
        //} 




        public static bool operator +(Materia m, Alumno a)
        {
            bool todOk = false;
            if (!(m == a))
            {
                m.alumnos.Add(a);
                todOk = true;
            }
            return todOk;
        }
        public static bool operator -(Materia m, Alumno a)
        {
            bool todOk = false;
            if (m == a)
            {
                m.alumnos.Remove(a);
                todOk = true;
            }
            return todOk;
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            bool ok = false;
            foreach (Alumno item in m.alumnos)
            {
                if (item == a)
                {
                    ok = true;
                    break;
                }
            }

            return ok;
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }


        public static List<Alumno> GetListaAlumno(Materia unaMateria)
        {
            List<Alumno> listaAlumno = new List<Alumno>();
            if (unaMateria.alumnos is not null)
            {
                listaAlumno = unaMateria.alumnos.ToList();
            }
            return listaAlumno;
        }
        public static explicit operator Materia(SqlDataReader v)
        {
            Materia nuevo = new Materia(
            Convert.ToInt32(v["idMateria"]),
            v["nombreMateria"].ToString() ?? "",
            (ECuatrimestre)Convert.ToInt32(v["cuatrimestre"]),
            (Profesor)v,
            v["correlativas"].ToString() ?? "",
            (EStadoProfe)Convert.ToInt32(v["estadoProfesor"]));

            return nuevo;
        }
        public static Materia? UnaMateria(string nombre, Alumno unAlumno)
        {
            List<Materia> materia;
            Materia? aux = null;
            materia = DaoMateria.CargarDatosmateriasAlumno(unAlumno);

            if (materia is not null && nombre != "")
            {
                foreach (Materia item in materia)
                {
                    if (item.nombre == nombre)
                    {
                        aux = item;
                        break;
                    }
                }
            }
            return aux;
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
