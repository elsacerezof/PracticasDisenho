using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Lebaniego : ILebaniego
    {
        public string HacerCocido()
        {
            return "Haciendo un rico cocido lebaniego";
        }

        public string HacerOrujo()
        {
            return "Intentando permanecer sobrio en el proceso de elaboración de orujo";
        }
    }
    
}
