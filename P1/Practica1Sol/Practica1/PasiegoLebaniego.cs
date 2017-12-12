using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class PasiegoLebaniego : IPasiego, ILebaniego
    {
        public TipoContexto contexto;
        public Pasiego pasiego;
        public Lebaniego lebaniego;

        public PasiegoLebaniego()
        {
            pasiego = new Pasiego();
            lebaniego = new Lebaniego();
        }

        public string HacerCocido()
        {
            String mensaje = "";
            if (contexto.Equals(TipoContexto.LIEBANA))
            {
                mensaje = lebaniego.HacerCocido();
            }
            else if (contexto.Equals(TipoContexto.PAS))
            {
                mensaje = pasiego.HacerCocido();
            }
            return mensaje;
        }

        public string HacerOrujo()
        {
            return (lebaniego.HacerOrujo());
        }

        public string HacerQuesada()
        {
            return (pasiego.HacerQuesada());
        }

        public string HacerSobaos()
        {
            return (pasiego.HacerSobaos());
        }

        public void setContexto(TipoContexto contextType)
        {
            contexto = contextType;
        }
    }
}
