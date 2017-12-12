using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoRootEnlace : EstadoItEnlace
    {
        public EstadoRootEnlace(ItHojaEnlace context) : base(context)
        {
            context.Current = context.Raiz;
            context.IsDone = false;

        }



        public override bool MoveNext()
        {

            Context.Dispose();



            return false;

        }
    }
}
