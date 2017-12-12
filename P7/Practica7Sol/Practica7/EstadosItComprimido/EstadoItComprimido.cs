using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public abstract class EstadoItComprimido
    {
        protected ItContenedorComprimido context;
        public ItContenedorComprimido Context
        {
            get { return context; }
            set { context = value; }
        }

        public EstadoItComprimido(ItContenedorComprimido context)
        {
            this.context = context;
        }

        public abstract bool MoveNext();

       

    }
}
