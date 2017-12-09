using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoCreatedComprimido : EstadoItComprimido
    {
        public EstadoCreatedComprimido(ItContenedorComprimido context) : base(context){
            context.IsDone = false;
        }


        public override bool MoveNext()
        {
            bool val = false;
            Context.Current = Context.Raiz;
            Context.Estado = new EstadoRootComprimido(context);
            val = true;

            return val;
        }

        
    }
}
