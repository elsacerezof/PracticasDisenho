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
            // Aquí debería ser algo como protStr.Clone().
            // La instancia prototípica hay que clonarla.
            // Además la propiedad o atributo protoStr debería tenerla esta
            // clase, que es donde se usa, y no la superclase.
            return new ImpresoraExtendida(protoStr);
        }

        public static void init()
        {
            theInstance = new AbiertaFactory();
        }
    }
}
