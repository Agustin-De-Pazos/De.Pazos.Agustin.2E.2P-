using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public interface IArchivo<T>
    {
        void GuardarComo(string ruta, T contenido);
    }
}
