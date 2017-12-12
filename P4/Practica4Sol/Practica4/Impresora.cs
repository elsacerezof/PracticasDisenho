using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public interface Impresora
    {
        
        String printArchivo(Archivo a);
        String printComprimido(Comprimido c);
        String printDirectorio(Directorio d);
        String printEnlace(Enlace e);

       
    }
}
