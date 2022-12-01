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
    public partial class CambiarRegularidadAlumnoAdmin : Form
    {
        public CambiarRegularidadAlumnoAdmin()
        {
            InitializeComponent();
        }

        private void btn_cambiarEstadoMateriaA_Click(object sender, EventArgs e)
        {
            if (cmb_materia.SelectedItem is not null && cmb_elegirAlumno.SelectedItem is not null && (string)cmb_cambiarEstadoRyL.SelectedItem is not null)
            {
                if (Dao.CambiarRegularidadAdmin((string)cmb_materia.SelectedItem, (string)cmb_elegirAlumno.SelectedItem, cmb_cambiarEstadoRyL.SelectedIndex))
                {
                    MessageBox.Show("Canbiado correctamente");
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }


        private void CambiarRegularidadAlumnoAdmin_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarMateriasProfesores(cmb_materia);
            if (cmb_materia.Items.Count != 0)
                cmb_materia.SelectedIndex = 0;
        }

        private void cmb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Biblioteca.FiltrarAlumnosCursandoMateriaCmb(cmb_materia, cmb_elegirAlumno, lbl_hayAlumnos);
        }
    }
}
