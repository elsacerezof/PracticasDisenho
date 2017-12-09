using Pr_06_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public abstract class IElto_Sistema_Archivos
    {
        public abstract String Nombre { get; set; }
        public abstract double Tamanho { get; set; }
        public abstract IList<IElto_Sistema_Archivos> Elementos { get; set;}

        public abstract double calculaTamanhoTotal();
        public abstract int numArchivosCont();
        public abstract String acceptImpresora(Impresora a);
        public abstract void registerObserver(EltoSistObserver obs);
        public abstract void removeObserver(EltoSistObserver obs);



    }
}

