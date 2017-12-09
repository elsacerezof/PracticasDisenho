using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class BotonMagico
    {
        public static void print(IElto_Sistema_Archivos ie) {
            Console.WriteLine("Imprimiendo sistema de archivos");
            Impresora p = ImpresoraFactory.getInstance().createImpresora();
            Console.WriteLine(ie.acceptImpresora(p));


        }

    }
}
