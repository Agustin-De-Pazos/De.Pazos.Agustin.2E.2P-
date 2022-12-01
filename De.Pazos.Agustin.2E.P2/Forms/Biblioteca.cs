using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public static class Biblioteca
    {
        public static void FiltrarAlumnosCursandoMateriaCmb(ComboBox materiaElegida, ComboBox cargarCmbAlumno, Label hayAlumnos)
        {
            bool todoOk = false;
            int idProfesor = 0;
            cargarCmbAlumno.Items.Clear();
            idProfesor = DaoProfesor.GetIdProfesorMateria((string)materiaElegida.SelectedItem);
            List<Alumno> listaAlumnos = DaoProfesor.GetMateriasProfesorAlumno(idProfesor, (string)materiaElegida.SelectedItem);
            if (listaAlumnos is not null)
            {
                foreach (Alumno item in listaAlumnos)
                {
                    cargarCmbAlumno.Items.Add($"{item.Nombre} {item.Apellido}");
                    todoOk = true;
                }
            }
            if (todoOk == false)
            {
                if (cargarCmbAlumno.SelectedItem is not null)
                {
                    cargarCmbAlumno.SelectedIndex = 0;
                }
                cargarCmbAlumno.Visible = false;
                hayAlumnos.Visible = true;
            }
            else
            {
                cargarCmbAlumno.Visible = true;
                hayAlumnos.Visible = false;
            }
        }
        public static bool CargarMateriasDelAlumnoCursando(Alumno unAlumno, ComboBox cmb_materia)
        {
            bool todoOk = false;
            List<MateriaCursada> listaMateriasCursada;
            listaMateriasCursada = unAlumno.GetMateriasCursada();
            foreach (MateriaCursada item in listaMateriasCursada)
            {
                if (item.Estado == eEstadoCursada.Cursando)
                {
                    cmb_materia.Items.Add(item.Nombre);
                }
            }
            return todoOk;
        }
        //public static void cargarMateriasProfesor(ComboBox cmb, Profesor unProfe)
        //{
        //    List<Materia> materias;
        //    materias = DataBase.GetListaMaterias();
        //    foreach (Materia item in materias)
        //    {
        //        if (item.Profesor is not null)
        //        {
        //            if (item.Profesor.Gmail == unProfe.Gmail)
        //            {
        //                cmb.Items.Add(item.Nombre);
        //            }
        //        }
        //    }
        //}
        public static void CargarMaterias(ComboBox cmb)
        {
            List<string> aux;
            aux = DaoMateria.GetNombreMateriasSinAsignar();
            if (aux != null)
            {
                foreach (string item in aux)
                {
                    cmb.Items.Add(item);
                }
            }
        }
        public static bool CargarMateriasProfesores(ComboBox cmb)
        {
            bool todoOk = false;
            List<string> aux;
            aux = DaoProfesor.GetMateriasProfesores();
            if (aux != null)
            {
                foreach (string item in aux)
                {
                    cmb.Items.Add(item);
                }
                todoOk = true;
            }
            return todoOk;
        }
        public static bool CargarMateriasProfeAsignado(ComboBox cmb)
        {

            bool todoOk = false;
            List<string> aux;
            aux = DaoMateria.GetNombreMateriasConProfesor();
            if (aux != null)
            {
                todoOk = true;
                foreach (string item in aux)
                {
                    cmb.Items.Add(item);
                }
            }
            return todoOk;
        }


        public static void CargarProfesorCmB(ComboBox cmb)
        {
            List<Profesor> aux;
            aux = DaoProfesor.GetProfesores();
            if (aux is not null)
            {
                foreach (Profesor item in aux)
                {
                    cmb.Items.Add($"{item.Nombre} {item.Apellido}");
                }
            }
        }
        public static void CargarProfesorMatCmB(Profesor unProfe, ComboBox cmb)
        {
            List<string> materiaList;
            materiaList = DaoProfesor.GetProfesorMaterias(unProfe.Id);
            foreach (string item in materiaList)
            {
                cmb.Items.Add(item);
            }
        }
    }
}
