using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public interface Impresora
    {
        //deberían llamarse todos print, solo se deben diferenciar en el parametro
        String printArchivo(Archivo a);
        String printComprimido(Comprimido c);
        String printDirectorio(Directorio d);
        String printEnlace(Enlace e);
       
    }
}
