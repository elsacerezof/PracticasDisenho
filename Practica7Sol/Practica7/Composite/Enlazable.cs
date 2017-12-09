using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class Enlazable : IElto_Sistema_Archivos
    {
        public abstract string Nombre { get; set; }
        public abstract double Tamanho { get; set; }

        public abstract double calculaTamanhoTotal();

        public abstract IEnumerator<IElto_Sistema_Archivos> GetEnumerator();

        public abstract int numArchivosCont();

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
