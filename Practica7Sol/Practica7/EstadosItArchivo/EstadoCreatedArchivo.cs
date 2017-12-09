using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoCreatedArchivo : EstadoItArchivo
    {
        public EstadoCreatedArchivo(ItHojaArchivo context) : base(context){
            context.IsDone = false;
        }


        public override bool MoveNext()
        {
            bool val = false;
            Context.Current = Context.Raiz;
            Context.Estado = new EstadoRootArchivo(context);
            val = true;

            return val;
        }
    }
}
