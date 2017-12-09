using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class AbiertaFactory : ImpresoraFactory
    {
        protected AbiertaFactory() { }
        public override Impresora createImpresora()
        {
            return new ImpresoraExtendida(protoStr);
        }

        public static void init()
        {
            theInstance = new AbiertaFactory();
        }
    }
}
