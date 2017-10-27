using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class CatalanaStr : TipoOrtografiaStr
    {
        public string muestraNombre(string nombre)
        {
            String resultado = nombre.Replace("Ñ", "Ny");

            return resultado.Replace("ñ", "ny");

        }
    }
}
