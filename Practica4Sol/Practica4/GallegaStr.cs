using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class GallegaStr : TipoOrtografiaStr
    {
        public string muestraNombre(string nombre)
        {
            String resultado = nombre.Replace("Ñ", "Nh");

            return resultado.Replace("ñ", "nh");

                
        }
    }
}
