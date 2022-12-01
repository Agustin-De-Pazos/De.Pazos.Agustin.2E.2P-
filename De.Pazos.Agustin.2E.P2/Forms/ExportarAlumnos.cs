using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using IO;

namespace Forms
{
    public partial class ExportarAlumnos : Form
    {
        private SaveFileDialog saveFileDialog;
        private static string rutaArchivo;
        private ExtJson<List<Alumno>> extJson;
        private ExtCsv<string> extCsv;
        private string? ultimoArchivo;
        public ExportarAlumnos()
        {
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV|*.csv|Archivo JSON|*.json";
            extJson = new ExtJson<List<Alumno>>();
            extCsv = new ExtCsv<string>();
        }

        //static ExportarAlumnos() HARCODEAR PATH
        //{
        //    string nombreArchivo = "alumnos.json";
        //    string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    rutaArchivo = Path.Combine(rutaEscritorio, nombreArchivo);
        //}
        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo!;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }
        private void ExportarAlumnos_Load(object sender, EventArgs e)
        {
            if(!Biblioteca.CargarMateriasProfesores(cmb_materias))
            {
                MessageBox.Show("No hay materias");
                this.Close();
            }
            else
            {
                cmb_materias.SelectedIndex = 0;
            }
        }

        private void btn_csv_Click(object sender, EventArgs e)
        {
            try
            {
                List<Alumno> alumnos;
                alumnos = DaoAlumno.listaAlumnosCursandoMateria((string)cmb_materias.SelectedItem);
                ultimoArchivo = SeleccionarUbicacionGuardado();
                StringBuilder sb = new StringBuilder();
                foreach (var item in alumnos)
                {
                    sb.AppendLine($"{item.Nombre},{item.Apellido},{item.Gmail},{item.Dni}");
                }
                extCsv.GuardarComo(UltimoArchivo, sb.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}, no se exportaron los datos.");
            }
        }

        private void btn_json_Click(object sender, EventArgs e)
        {
            try
            { 
                List<Alumno> alumnos;
                alumnos = DaoAlumno.listaAlumnosCursandoMateria((string)cmb_materias.SelectedItem);
                ultimoArchivo = SeleccionarUbicacionGuardado();

                extJson.GuardarComo(UltimoArchivo, alumnos);

            }
            catch(Exception msj)
            {
                MessageBox.Show($"{msj.Message}");
            }
        }

        private string SeleccionarUbicacionGuardado()
        {
            string retorno = string.Empty;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                retorno = saveFileDialog.FileName;
            }
            return retorno;
        }
    }
}
