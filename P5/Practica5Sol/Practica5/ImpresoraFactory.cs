using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public abstract class ImpresoraFactory
    {
        public TipoOrtografiaStr protoStr;
        public static ImpresoraFactory theInstance;

        public abstract Impresora createImpresora();

        protected ImpresoraFactory() { }
  

        public static ImpresoraFactory getInstance()
        {
            return theInstance;
        }

        public void setProtoType(TipoOrtografiaStr to) {

            protoStr =(TipoOrtografiaStr) to.Clone();
        }

       
    }
}
