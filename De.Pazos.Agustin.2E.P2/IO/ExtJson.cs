using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace IO
{
    public class ExtJson<T> : Archivo, IArchivo<T>
            where T : class
    {
        protected override string Extension { get => ".json"; }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                streamWriter.Write(json);
            }
        }
    }
}
