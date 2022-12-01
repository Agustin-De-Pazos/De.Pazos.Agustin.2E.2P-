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
    public partial class DataGridAlumnosProfesor : Form
    {
        BindingSource bindingSource;
        private Profesor _profe;
        public DataGridAlumnosProfesor(Profesor unProfe)
        {
            InitializeComponent();
            _profe = unProfe;
            bindingSource = new BindingSource();
        }

        private void cmb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string materiaCmb = (string)cmb_materia.SelectedItem;
            List<Alumno> aux = DaoProfesor.GetMateriasProfesorAlumno(_profe.Id, materiaCmb);

            bindingSource.DataSource = aux;
            dgv_alumnosProfe.DataSource = bindingSource;
        }

        private void DataGridAlumnosProfesor_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarProfesorMatCmB(_profe, cmb_materia);
        }
    }
}
