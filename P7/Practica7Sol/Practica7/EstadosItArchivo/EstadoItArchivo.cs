using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class EstadoItArchivo
    {
        protected ItHojaArchivo context;
        public ItHojaArchivo Context
        {
            get { return context; }
            set { context = value; }
        }

        public EstadoItArchivo(ItHojaArchivo context)
        {
            this.context = context;
        }

        public abstract bool MoveNext();


    }
}
