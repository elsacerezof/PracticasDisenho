using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Internacional_catalanaStr : TipoOrtografiaStr
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public string muestraNombre(string nombre)
        {
            String resultado = nombre;
            resultado = resultado.Replace("ñ", "ny");
            resultado = resultado.Replace("Ñ", "Ny");
            resultado = resultado.Replace("á", "a");
            resultado = resultado.Replace("Á", "A");
            resultado = resultado.Replace("é", "e");
            resultado = resultado.Replace("É", "E");
            resultado = resultado.Replace("í", "i");
            resultado = resultado.Replace("Í", "I");
            resultado = resultado.Replace("ó", "o");
            resultado = resultado.Replace("Ó", "O");
            resultado = resultado.Replace("ú", "u");
            resultado = resultado.Replace("Ú", "U");

            return resultado;

        }
    }
}
