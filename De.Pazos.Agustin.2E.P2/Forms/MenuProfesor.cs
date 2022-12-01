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
    public partial class MenuProfesor : Form
    {
        Profesor _profe;
        BindingSource bindingSource;
        public MenuProfesor(Profesor unProfe)
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            _profe = unProfe;
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {

            List<Materia> aux = DaoMateria.GetMatariasProfesor(_profe.Id);
            bindingSource.DataSource = aux;
            dgv_Profesor.DataSource = bindingSource;
        }

        private void btn_NotaExamen_Click(object sender, EventArgs e)
        {
            NotaExamen notaExamen = new NotaExamen(_profe);
            notaExamen.ShowDialog();
        }

        private void btn_crearExamen_Click(object sender, EventArgs e)
        {
            List<Materia> aux = DaoMateria.GetMatariasProfesor(_profe.Id);
            if (aux is not null)
            {
                CrearExamenProfesor crearExamen = new CrearExamenProfesor(_profe);
                crearExamen.ShowDialog();
            }

        }

        private void btn_examen_Click(object sender, EventArgs e)
        {
            List<Examen> aux = DaoProfesor.GetExamenesProfesor(_profe.Id);
            if (aux.Count != 0)
            {
                bindingSource.DataSource = aux;
                dgv_Profesor.DataSource = bindingSource;
            }
            else
            {
                MessageBox.Show("No creo examenes");
            }
        }

        private void bnt_alumnos_Click(object sender, EventArgs e)
        {
            DataGridAlumnosProfesor dataGridAlumnosProfesor = new DataGridAlumnosProfesor(_profe);
            dataGridAlumnosProfesor.ShowDialog();
        }

        private void btn_materias_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = DaoMateria.GetMatariasProfesor(_profe.Id);
            dgv_Profesor.DataSource = bindingSource;
        }
    }
}
