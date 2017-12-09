using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class EstadoItEnlace
    {
        protected ItHojaEnlace context;
        public ItHojaEnlace Context
        {
            get { return context; }
            set { context = value; }
        }

        public EstadoItEnlace(ItHojaEnlace context)
        {
            this.context = context;
        }

        public abstract bool MoveNext();

    }
}
