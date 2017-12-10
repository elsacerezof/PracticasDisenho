using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoRootComprimido : EstadoItComprimido
    {

        public EstadoRootComprimido(ItContenedorComprimido context) : base(context)
        {
            context.Current = context.Raiz;
            context.IsDone = false;
          
        }

             

        public override bool MoveNext()
        {
            bool val = false;
            if (Context.Raiz.numArchivosCont() == 0)
            {
                // ¿Por qué? No hay necesidad de eliminar el iterador si 
                // llega a su fin.
                Context.Dispose();

            }else
            {
                // Aquí hay un poco de lío
                Context.ChildIterator = Context.Raiz.EltosComp.GetEnumerator();
                //val = Context.MoveNext();
                Context.ChildIterator.MoveNext();
                // Esta línea es errónea, a este iterador no queremos acceder
                // en realidad, aunque en este caso concreto te va a funcionar
                Context.Current = Context.ChildIterator.Current;
                Context.CurrentIterator = Context.ChildIterator.Current.GetEnumerator();
                // Esto devuelve siempre true. 
                val=Context.CurrentIterator.MoveNext();
                Context.Estado = new EstadoInProgressComprimido(context);

            }
            Context.Estado.Context = Context;

            return val;
            
        }

       
    }
}
