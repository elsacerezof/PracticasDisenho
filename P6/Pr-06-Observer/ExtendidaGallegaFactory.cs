using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class ExtendidaGallegaFactory : ImpresoraFactory
    {
        private ExtendidaGallegaFactory() { }

        public override Impresora createImpresora()
        {
            return new ImpresoraExtendida(new Internacional_gallegaStr());
        }

        public static void init()
        {
            theInstance = new ExtendidaGallegaFactory();
        }
    }
}
