using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class ImpresoraCompacta : Impresora
    {
        // Pablo: Si la superclase la cambias de interfaz a clase abstracta, todo lo relacionado con las tabulaciones
        //        lo puedes subir a las superclases.  
        private int contador;
        private TipoOrtografiaStr to;

        public int Contador
        {
            get { return contador; }
            set { this.contador = value;}
        }

        public TipoOrtografiaStr To
        {
            get { return to; }
            set { this.to = value; }
        }

        public ImpresoraCompacta(TipoOrtografiaStr to) {
            this.Contador = -1;
            this.To = to;
        }

        public string printArchivo(Archivo a)
        {
            this.Contador++;
            // Esto sácalo mejor a una función auxiliar. 
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }
            this.Contador--;
            return space + "f " + To.muestraNombre(a.Nombre) +  System.Environment.NewLine;
        }

        public string printComprimido(Comprimido c)
        {
            this.Contador++;
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }
            this.Contador--;
            return space + "c " + To.muestraNombre(c.Nombre) + System.Environment.NewLine;
        }

        public string printDirectorio(Directorio d)
        {
       
            this.Contador++;
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }
            IList<IElto_Sistema_Archivos> eltos = d.Elementos;
            String todo = null;
            // Pablo: Tienes un lío hecho con los incrementos de los tabularadores. De momento, tabula, pero poco.
            //        Si en el examen te pido que las tabulaciones sean exactamente de 4 caracteres, te formo el lío.
            //        Afortunadamente eso no va a pasar, pero mira como se puede hacer esto más fácil. Pista: 
            //        Inicializa el contador a cero en el constructor y cambia el lugar donde se incrementa el contador.
            foreach(IElto_Sistema_Archivos e in eltos)
            {
               todo= todo + e.acceptImpresora(this);
            }
            this.Contador--;
            return space + "d " + To.muestraNombre(d.Nombre) + System.Environment.NewLine + todo;
        }

        public string printEnlace(Enlace e)
        {
            // Pablo: Este trozo de código está duplicado cuatro veces. Esto debería dolerte.
            this.Contador++;
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }
            this.Contador--;
            return space + "e " + To.muestraNombre(e.Nombre) + System.Environment.NewLine;
        }

    }
}
