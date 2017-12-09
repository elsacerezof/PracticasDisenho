using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class BasicaFactory : ImpresoraFactory
    {
        protected BasicaFactory() { }

        public override Impresora createImpresora()
        {
            return new ImpresoraCompacta(new Internacional_gallegaStr());
        }

        public static void init()
        {
            theInstance = new BasicaFactory();
        }

    }    
}
