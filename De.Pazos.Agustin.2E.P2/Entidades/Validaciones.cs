using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validacion
    {
        public static bool SoloLetrasMinusculaNoNull(string aux)
        {
            bool todOK = true;

            if (aux is not null)
            {
                foreach (char item in aux)
                {
                    if (item < 97 || item > 122)
                    {
                        todOK = false;
                        break;
                    }
                }
                aux.ToUpper();
            }
            else
            {
                todOK = false;
            }
            return todOK;
        }

        public static bool SoloNumeros(string numeros)
        {
            bool todOk = false;
            if (numeros is not null && numeros != "")
            {
                todOk = true;
                foreach (var item in numeros)
                {
                    if (item < 48 || item > 57)
                    {
                        todOk = false;
                    }
                }
            }
            return todOk;
        }

    }
}
