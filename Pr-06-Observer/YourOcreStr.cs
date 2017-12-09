using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class YourOcreStr : TipoOrtografiaStr
    {
        public string muestraNombre(string nombre)
        {
            String resultado = nombre;
            resultado = resultado.Replace("ñ", "ni");
            resultado = resultado.Replace("Ñ", "Ni");
            return resultado;

        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
