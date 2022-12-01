
using Entidades;
using System;
using System.Runtime.Intrinsics.X86;

namespace Forms
{
    public partial class MenuPrincipal : Form
    {
        public delegate void DelegadoMessageBox(string str);//ENCAPSULO EL MESSAGEBOX
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            
            Usuario? aux;

            aux = Dao.UsuarioLogin(txt_usuario.Text.ToString(), txt_contraseña.Text.ToString());
            if (aux is not null)
            {
                switch (aux.Permisos)
                {
                    case EPermisos.Admin:
                        MenuAdmin admin = new MenuAdmin((Admin)aux);
                        admin.ShowDialog();
                        break;
                    case EPermisos.Alumno:
                        MenuAlumno alumno = new MenuAlumno((Alumno)aux);
                        alumno.ShowDialog();
                        break;
                    case EPermisos.Profesor:
                        MenuProfesor profesor = new MenuProfesor((Profesor)aux);
                        profesor.ShowDialog();
                        break;
                }
            }
            else
            {
                DelegadoMessageBox delegado = Notificar;
                Notificar("No Existe");
                //MessageBox.Show("No Existe");
            }
        }
        private void btn_adminH_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "admin@gmail.com";
            txt_contraseña.Text = "asdasd";
        }

        private void btn_profesorH_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "ernesto@gmail.com";
            txt_contraseña.Text = "asdasd1";
        }

        private void btn_alumnoH_Click(object sender, EventArgs e)
        {
            txt_usuario.Text = "depazosagustin@gmail.com";
            txt_contraseña.Text = "asdasd";
        }
        static void Notificar(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}