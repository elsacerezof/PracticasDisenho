using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoRootDirectorio : EstadoItDirectorio
    {
        public EstadoRootDirectorio(ItContenedorDirectorio context) : base(context)
        {
            context.Current = context.Raiz;
            context.IsDone = false;

        }



        public override bool MoveNext()
        {
            bool val = false;
            if (Context.Raiz.numArchivosCont() == 0)
            {
                Context.Dispose();

            }
            else
            {
                Context.ChildIterator = Context.Raiz.Elementos.GetEnumerator();
                //val = Context.MoveNext();
                Context.ChildIterator.MoveNext();
                Context.Current = Context.ChildIterator.Current;
                Context.CurrentIterator = Context.ChildIterator.Current.GetEnumerator();
                val=Context.CurrentIterator.MoveNext();
                Context.Estado = new EstadoInProgressDirectorio(context);

            }
            Context.Estado.Context = Context;

            return val;

        }
    }
}
