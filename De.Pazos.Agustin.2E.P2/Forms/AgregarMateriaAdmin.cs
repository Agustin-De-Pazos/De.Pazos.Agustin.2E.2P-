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
    public partial class AgregarMateriaAdmin : Form
    {
        public AgregarMateriaAdmin()
        {
            InitializeComponent();
        }

        private void btn_agregarMateria_Click(object sender, EventArgs e)
        {
            if (txt_materiaAlta.Text != "")
            {
                if (!Dao.ValidarMateria(txt_materiaAlta.Text))
                {
                    if (DaoMateria.AgregarMateria(txt_materiaAlta.Text, cmb_altaCuatrimestre.SelectedIndex))
                    {
                        MessageBox.Show("Agregado");
                    }
                }
                else
                {
                    MessageBox.Show("YA existe");
                }
            }
            else
            {
                MessageBox.Show("Ingrese nombre de la materia");
            }

        }

        private void AgregarMateriaAdmin_Load(object sender, EventArgs e)
        {
            cmb_altaCuatrimestre.SelectedIndex = 0;
        }
    }
}
