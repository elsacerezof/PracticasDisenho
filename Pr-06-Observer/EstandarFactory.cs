using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class EstandarFactory : ImpresoraFactory
    {
        private EstandarFactory() { }

        public override Impresora createImpresora()
        {
            return new ImpresoraExtendida(null);
        }

        public static void init()
        {
           theInstance= new EstandarFactory();
        }
    }
}
