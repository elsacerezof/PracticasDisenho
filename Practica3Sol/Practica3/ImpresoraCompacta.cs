using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class ImpresoraCompacta : Impresora
    {
        private int contador;

        public int Contador
        {
            get { return contador; }
            set { this.contador = value;}
        }

        public ImpresoraCompacta() {
            this.Contador = -1;
        }

        public string printArchivo(Archivo a)
        {
            this.Contador++;
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }
            this.Contador--;
            return space + "f " + a.Nombre +  System.Environment.NewLine;
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
            return space + "c " + c.Nombre + System.Environment.NewLine;
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
            foreach(IElto_Sistema_Archivos e in eltos)
            {
               todo= todo + e.acceptImpresora(this);
            }
            this.Contador--;
            return space + "d " + d.Nombre + System.Environment.NewLine + todo;
        }

        public string printEnlace(Enlace e)
        {
            this.Contador++;
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }
            this.Contador--;
            return space + "e " + e.Nombre + System.Environment.NewLine;
        }
    }
}
