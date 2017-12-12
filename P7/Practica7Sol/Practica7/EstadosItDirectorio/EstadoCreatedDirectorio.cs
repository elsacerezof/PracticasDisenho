using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoCreatedDirectorio : EstadoItDirectorio
    {

        public EstadoCreatedDirectorio(ItContenedorDirectorio context) : base(context){
            context.IsDone = false;
        }


        public override bool MoveNext()
        {
            bool val = false;
            Context.Current = Context.Raiz;
            Context.Estado = new EstadoRootDirectorio(context);
            val = true;

            return val;
        }
    }
}
