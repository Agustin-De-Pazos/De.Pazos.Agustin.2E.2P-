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
    public partial class AgregarUsuarioAdmin : Form
    {
        public AgregarUsuarioAdmin()
        {
            InitializeComponent();
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            int aux;
            Usuario? auxU;
            if (ValidoIngresoAlta())
            {
                aux = int.Parse(txt_altaDni.Text);

                if (!Dao.ValidarUsuario(txt_GmailAlta.Text, txt_altaApellido.Text, aux))
                {
                        if (Dao.AgregarUsuario(txt_altaNombre.Text, txt_altaApellido.Text, txt_GmailAlta.Text,
                            txt_contraseñaAtla.Text, cmb_usuarioALTA.SelectedIndex, aux))
                        {
                            MessageBox.Show("Base de datos cargada");
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                }
                else
                {
                    MessageBox.Show("Ya existe");
                }
            }
            else
            {
                MessageBox.Show("Campos mal ingresados");
            }
        }

        private bool ValidoIngresoAlta()
        {
            bool todOk = false;
            if (Validacion.SoloLetrasMinusculaNoNull(txt_altaApellido.Text) &&
                Validacion.SoloLetrasMinusculaNoNull(txt_altaNombre.Text) &&
                txt_GmailAlta.Text is not null && txt_contraseñaAtla.Text is not null &&
                Validacion.SoloNumeros(txt_altaDni.Text))
            {
                todOk = true;
            }
            return todOk;
        }

        private void AgregarUsuarioAdmin_Load(object sender, EventArgs e)
        {
            cmb_usuarioALTA.SelectedIndex = 0;
        }
    }
}
