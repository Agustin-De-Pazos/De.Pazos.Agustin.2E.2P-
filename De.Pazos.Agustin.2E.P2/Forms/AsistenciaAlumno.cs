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
    public partial class AsistenciaAlumno : Form
    {
        private Alumno _unAlumno;
        public AsistenciaAlumno(Alumno unAlumno)
        {
            InitializeComponent();
            _unAlumno = unAlumno;
        }

        private void btn_asistencia_Click(object sender, EventArgs e)
        {
            if (cmb_materia.SelectedItem is not null)
            {
                if (_unAlumno.DarAsistencia((string)cmb_materia.SelectedItem))
                {
                    if (DaoAlumno.DarAsistencia((string)cmb_materia.SelectedItem, _unAlumno.Id))
                    {
                        MessageBox.Show($"Asistencia: {cmb_materia.SelectedItem}  cargada con exito");
                    }

                }
                else
                {
                    MessageBox.Show($"No esta cursando {cmb_materia.SelectedItem}");
                }
            }
            this.Close();
        }

        private void AsistenciaAlumno_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarMateriasDelAlumnoCursando(_unAlumno, cmb_materia);
        }
    }
}
