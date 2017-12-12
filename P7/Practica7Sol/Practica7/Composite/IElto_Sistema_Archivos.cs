using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public interface IElto_Sistema_Archivos : IEnumerable<IElto_Sistema_Archivos>
    {
        String Nombre { get; set; }
        double Tamanho { get; set; }
        double calculaTamanhoTotal();
        int numArchivosCont();
        

    }
}
