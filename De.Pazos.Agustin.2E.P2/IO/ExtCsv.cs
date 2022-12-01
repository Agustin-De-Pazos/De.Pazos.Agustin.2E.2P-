using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Entidades;


namespace IO
{
    public class ExtCsv<T> : Archivo, IArchivo<T>                  
                    where T : class
    {   
        protected override string Extension { get => ".csv"; }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }
        //public static void Serializar(string ruta,StringBuilder sb)
        //{
        //    File.WriteAllText(ruta, sb.ToString());
        //} 
        public static void Serializar(string ruta,T contenido)
        {
             File.WriteAllText(ruta, contenido.ToString());
        }
    }
}
