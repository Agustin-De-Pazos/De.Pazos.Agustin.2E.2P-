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
    public partial class AsignarProfesorMateriaAdmin : Form
    {
        public AsignarProfesorMateriaAdmin()
        {
            InitializeComponent();
        }


        private void btn_altaProfesorMat_Click_1(object sender, EventArgs e)
        {
            //Profesor auxProfesor;
            //Materia aux;
            if (this.cmb_profesorAltaMateria.SelectedItem is not null && this.cmb_profesorAlta.SelectedItem is not null)
            {
                if (DaoMateria.ModificarEstadoProfesor((string)cmb_profesorAltaMateria.SelectedItem, (string)cmb_profesorAlta.SelectedItem))
                {
                    MessageBox.Show("Base de datos Cargada");
                }
                //CARGAR PROGRAMA
                //aux = DataBase.GetMateria(cmb_profesorAltaMateria.SelectedItem.ToString());

                //if (DataBase.AsignarProfeMateria(aux, this.cmb_profesorAlta.SelectedItem.ToString()) == 1)
                //{
                //    auxProfesor = (Profesor)DataBase.GetProfesorStringNombreApellido(DataBase.GetListaProfes(), (string)cmb_profesorAlta.SelectedItem); ;

                //    Dao.AgregarProfesorMateria(DataBase.GetMateria(cmb_profesorAltaMateria.ToString()));
                //}
                //else if (aux.Estado == EStadoProfe.Ocupado)
                //{
                //    MessageBox.Show("Ya hay un profesor asigando");
                //}
                //else
                //{
                //    MessageBox.Show("No existe la materia");
                //}
            }
        }

        private void AsignarProfesorMateriaAdmin_Load(object sender, EventArgs e)
        {
            Biblioteca.CargarProfesorCmB(cmb_profesorAlta);
            Biblioteca.CargarMaterias(cmb_profesorAltaMateria);
        }
    }
}
