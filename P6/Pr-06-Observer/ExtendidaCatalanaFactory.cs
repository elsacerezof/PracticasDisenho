using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class ExtendidaCatalanaFactory : ImpresoraFactory
    {
        private ExtendidaCatalanaFactory() {}

        public override Impresora createImpresora()
        {
           return new ImpresoraExtendida(new Internacional_catalanaStr());
        }

        public static void init()
        {
            theInstance = new ExtendidaCatalanaFactory();
        }
    }
}
