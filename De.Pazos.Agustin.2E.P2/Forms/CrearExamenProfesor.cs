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
    public partial class CrearExamenProfesor : Form
    {
        Profesor _profe;
        public CrearExamenProfesor(Profesor profesor)
        {
            _profe = profesor;
            InitializeComponent();
        }



        private void CrearExamenProfesor_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarMateriasProfeAsignado(cmb_nombreMateria);
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (_profe.NuevoExamen(dtp_fechaExamen.Value, (string)cmb_nombreMateria.SelectedItem, txt_nombreExamen.Text))
            {
                MessageBox.Show("Examen Creado");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            this.Close();
        }
    }
}
