using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_06_Observer
{
    public interface EltoSistObserver
    {
        
        // Esta propiedad no la entiendo, no sé muy bie para que sirve. 
        // Nomalmente a los observadores no se les exige nada, más allá
        // de que tengan un método donde se puedan notificar los cambios 
        // de las clases observadas.
        String Nombre { get; set; }
        // Esta interfaz vale sólo para los enlaces pero los controles
        // necesitan observar cualquier elemento del sistema, por lo 
        // que habría que crear otra interfaz que permita pasar Enlaces
        // como parámetro.
        void updateEnlace(Enlazable elto);
    }
}
