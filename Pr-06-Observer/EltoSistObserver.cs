using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_Observer
{
    public interface EltoSistObserver
    {
        void update(IElto_Sistema_Archivos elto);
    }
}
