using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using System.IO;
namespace IO
{
    public abstract class Archivo
    {
        protected abstract string Extension { get; }

        public bool ValidarArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new ArchivoInCorrectoExcepcion("El archivo no se encontro");
            }
            return true;
        }

        public bool ValidarExtension(string ruta)
        {
            if (Path.GetExtension(ruta) != this.Extension)
            {
                throw new ArchivoInCorrectoExcepcion($"El archivo no tiene la extensión {this.Extension}");
            }

            return true;
        }
    }
}
