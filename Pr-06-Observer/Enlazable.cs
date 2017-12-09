using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_Observer
{
    public abstract class Enlazable : IElto_Sistema_Archivos
    {
        public abstract IList<EltoSistObserver> Observers { get; set; }
        protected abstract void notify();
       

    }
}
