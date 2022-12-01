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
    public partial class MenuAdmin : Form
    {
        private Usuario unAdmin;
        public MenuAdmin(Usuario unAdmin)
        {
            InitializeComponent();
            this.unAdmin = unAdmin;
        }
        private void MenuAdmin_Load(object sender, EventArgs e)
        {

            lbl_bienvenidoAdmin.Text = $"Bienvenido: {unAdmin.Nombre}";
        }

        private void btn_formAgregarMateria_Click(object sender, EventArgs e)
        {
            AgregarMateriaAdmin agregarMateria = new AgregarMateriaAdmin();
            agregarMateria.ShowDialog();
        }

        private void btn_altaUsuario_Click_1(object sender, EventArgs e)
        {
            AgregarUsuarioAdmin agregarUsuario = new AgregarUsuarioAdmin();
            agregarUsuario.Show();
        }

        private void btn_altaProfesorMat_Click(object sender, EventArgs e)
        {
            AsignarProfesorMateriaAdmin asignarProfesorMateria = new AsignarProfesorMateriaAdmin();
            asignarProfesorMateria.ShowDialog();
        }
        private void btn_formAgregarMateria_Click_1(object sender, EventArgs e)
        {
            AgregarMateriaAdmin agregarMateriaAdmin = new AgregarMateriaAdmin();
            agregarMateriaAdmin.ShowDialog();
        }
        private void btn_cambiarEstadoMateriaA_Click(object sender, EventArgs e)
        {
            CambiarRegularidadAlumnoAdmin cambiarRegularidadAlumnoAdmin = new CambiarRegularidadAlumnoAdmin();
            cambiarRegularidadAlumnoAdmin.ShowDialog();
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            ExportarAlumnos exportarAlumnos = new ExportarAlumnos();
            exportarAlumnos.ShowDialog();
        }
    }
}
