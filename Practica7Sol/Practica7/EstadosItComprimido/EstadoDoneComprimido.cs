using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class EstadoDoneComprimido : EstadoItComprimido
    {
        public EstadoDoneComprimido(ItContenedorComprimido context) : base(context)
        {
            Context.IsDone = true;
        }

       

        public override bool MoveNext()
        {
            return false;
        }

        
    }
}
