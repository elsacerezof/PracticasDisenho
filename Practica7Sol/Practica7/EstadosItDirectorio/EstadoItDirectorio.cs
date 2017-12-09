using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class EstadoItDirectorio
    {
        protected ItContenedorDirectorio context;
        public ItContenedorDirectorio Context
        {
            get { return context; }
            set { context = value; }
        }

        public EstadoItDirectorio(ItContenedorDirectorio context)
        {
            this.context = context;
        }

        public abstract bool MoveNext();


    }
}
