using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class SparrowHelper
    {
        private SparrowHelper() { }

        public static List<IElto_Sistema_Archivos> BuscaElementos(Directorio raiz, string consulta)
        {
            List<IElto_Sistema_Archivos> lista = new List<IElto_Sistema_Archivos>();

            IEnumerator<IElto_Sistema_Archivos> it = raiz.GetEnumerator();

            while (it.MoveNext())
            {
                if (it.Current.Nombre.Contains(consulta))
                {
                    lista.Add(it.Current);
                }
            }
            return lista;
        }


        public static IElto_Sistema_Archivos BuscarPrimero(Directorio raiz, string consulta)
        {
            IEnumerator<IElto_Sistema_Archivos> it = raiz.GetEnumerator();
            IElto_Sistema_Archivos encontrado = null;

            while (it.MoveNext() && encontrado == null)
            {
                if (it.Current.Nombre.Contains(consulta))
                {
                    encontrado = it.Current;
                }
            }
            return encontrado;
        }
    }

}

