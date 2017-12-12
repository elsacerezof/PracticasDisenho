using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public interface IElto_Sistema_Archivos
    {
        String Nombre { get; set; }
        double Tamanho { get; }

        double calculaTamanhoTotal();
        int numArchivosCont();
        String acceptImpresora(Impresora a);
    }
}
