using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Pasiego : IPasiego
    {
        public string HacerCocido()
        {
            return "Haciendo un riquísimo cocido pasiego";
        }

        public string HacerQuesada()
        {
            return "Elaborando una quesada espectacular";
        }

        public string HacerSobaos()
        {
            return "Terminando de fabricar estos fantásticos sobaos";
        }
    }
}
