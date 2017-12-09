﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoInProgressDirectorio : EstadoItDirectorio
    {

        public EstadoInProgressDirectorio(ItContenedorDirectorio context) : base(context)
        {
            context.IsDone = false;
        }



        public override bool MoveNext()
        {
            bool val = true;

            if (Context.CurrentIterator.MoveNext())
            {
                Context.Current = Context.CurrentIterator.Current;

            }
            else
            {
                if (Context.ChildIterator.MoveNext())
                {
                    Context.CurrentIterator = Context.ChildIterator.Current.GetEnumerator();
                    Context.CurrentIterator.MoveNext();
                    Context.Current = Context.CurrentIterator.Current;
                }
                else
                {
                    Context.Dispose();
                    Context.Estado = new EstadoDoneDirectorio(Context);
                    Context.Estado.Context = Context;
                    val = false;
                }
            }
            return val;
        }
    }
}
