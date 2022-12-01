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
    public partial class MenuAlumno : Form
    {
        private Alumno _alumno;
        BindingSource bindingSource;
        public MenuAlumno(Alumno alumno)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            _alumno = alumno;
            DaoAlumno.GetAlumnoActualizar(_alumno);
        }

        private void MenuAlumno_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _alumno.GetMateriasCursada();
            dgv_alumno.DataSource = bindingSource;
        }



        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            AsistenciaAlumno asistencia = new AsistenciaAlumno(_alumno);
            asistencia.ShowDialog();
            this.Close();
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            if (DaoAlumno.cantidadMateriasAlumno(_alumno.Id) < 2)
            {
                InscripcionAlumMaterias inscripcionMateriaAlumno = new InscripcionAlumMaterias(_alumno);
                inscripcionMateriaAlumno.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ya esta inscripto a 2 materias");
            }
        }
    }
}
