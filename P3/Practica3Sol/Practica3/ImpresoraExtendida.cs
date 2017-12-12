using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ImpresoraExtendida : Impresora
    {
        public int contador;

        public int Contador
        {
            get { return contador; }
            set { this.contador = value; }
        }

        public ImpresoraExtendida()
        {
            contador = -1;
        }

        public string printArchivo(Archivo a)
        {
            this.Contador++;
            string space = printTabulaciones();
            this.Contador--;
            return space + "f " + a.Nombre + System.Environment.NewLine;
        }

        public string printComprimido(Comprimido c)
        {
            this.Contador++;
            string space = printTabulaciones();
            IList<IElto_Sistema_Archivos> eltos = c.EltosComp;
            String todo = null;
            foreach (IElto_Sistema_Archivos e in eltos)
            {
                todo = todo + e.acceptImpresora(this);
            }
            this.Contador--;
            return space + "c " + c.Nombre + System.Environment.NewLine + todo;
        }

        public string printDirectorio(Directorio d)
        {
            this.Contador++;
            string space = printTabulaciones();
            IList<IElto_Sistema_Archivos> eltos = d.Elementos;
            String todo = null;
            foreach (IElto_Sistema_Archivos e in eltos)
            {
                todo = todo + e.acceptImpresora(this);
            }
            this.Contador--;
            return space + "d " + d.Nombre + System.Environment.NewLine + todo;
        }

        private string printTabulaciones()
        {
            String space = null;
            for (int i = 0; i < this.Contador; i++)
            {
                space = space + " ";
            }

            return space;
        }

        public string printEnlace(Enlace e)
        {
            this.Contador++;
            string space = printTabulaciones();
            this.Contador--;
            return space + "e " + e.Nombre + System.Environment.NewLine;
        }
    }
}
