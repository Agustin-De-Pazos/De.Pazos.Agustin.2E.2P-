using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class InscripcionAlumMaterias : Form
    {
        Alumno _alumno;
        public InscripcionAlumMaterias(Alumno alumno)
        {
            InitializeComponent();
            _alumno = alumno;
            //materiaList = DaoMaterias.CargarDatosmateriasAlumno(_alumno);
        }

        private void btn_inscripcion_Click(object sender, EventArgs e)
        {
            Materia? aux = Materia.UnaMateria((string)cmb_materias.SelectedItem, _alumno);
            string mensaje = Alumno.InscribirseMateria(_alumno, aux);
            MessageBox.Show(mensaje);

            this.Close();
        }

        private void InscripcionAlumMaterias_Load(object sender, EventArgs e)
        {
            if (!Biblioteca.CargarMateriasProfeAsignado(cmb_materias))
            {
                cmb_materias.SelectedIndex = 0;
            }
        }
    }
}
