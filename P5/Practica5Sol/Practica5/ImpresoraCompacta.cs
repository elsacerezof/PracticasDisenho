using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class ImpresoraCompacta : Impresora
    {
        private int contador;
        private TipoOrtografiaStr to;

        public int Contador
        {
            get { return contador; }
            set { this.contador = value; }
        }

        public TipoOrtografiaStr To
        {
            get { return to; }
            set { this.to = value; }
        }

        public ImpresoraCompacta(TipoOrtografiaStr to)
        {
            this.Contador = -1;
            this.To = to;
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
            return space + "f " + To.muestraNombre(a.Nombre) + System.Environment.NewLine;
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
            foreach (IElto_Sistema_Archivos e in eltos)
            {
                todo = todo + e.acceptImpresora(this);
            }
            this.Contador--;
            return space + "d " + To.muestraNombre(d.Nombre) + System.Environment.NewLine + todo;
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
            return space + "e " + To.muestraNombre(e.Nombre) + System.Environment.NewLine;
        }

    }
}
