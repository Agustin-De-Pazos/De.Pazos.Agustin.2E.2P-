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
    public partial class NotaExamen : Form
    {
        Profesor _unProfesor;
        public NotaExamen(Profesor profesor)
        {
            InitializeComponent();
            _unProfesor = profesor;
        }

        private void NotaExamen_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarProfesorMatCmB(_unProfesor, cmb_materia);
            //Biblioteca.cargarMateriasProfesor(cmb_materia, _unProfesor);
            if (cmb_materia.Items.Count != 0)
            {
                cmb_materia.SelectedIndex = 0;
                cmb_notaPrimerParcial.SelectedIndex = 0;
                cmb_notaSegundoParcial.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No tiene materias asiganadas");
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? mensaje = "ERROR";
            if (cmb_alumnos.SelectedItem is not null && cmb_materia.SelectedItem is not null && cmb_notaPrimerParcial.SelectedItem is not null && cmb_notaSegundoParcial.SelectedItem is not null)
            {
                mensaje = Profesor.CierreDeNotas(cmb_materia.SelectedItem.ToString() ?? "", cmb_alumnos.SelectedItem.ToString() ?? "",
                int.Parse(cmb_notaPrimerParcial.SelectedItem.ToString() ?? ""),
                int.Parse(cmb_notaSegundoParcial.SelectedItem.ToString() ?? ""));
            }

            MessageBox.Show(mensaje);
            this.Close();
        }

        private void cmb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Biblioteca.FiltrarAlumnosCursandoMateriaCmb(cmb_materia, cmb_alumnos, lbl_hayAlumnos);
        }
    }
}
