using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class ImpresoraExtendida : Impresora
    {
        public int contador;
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

        public ImpresoraExtendida(TipoOrtografiaStr to)
        {
            contador = -1;
            this.To = to;
        }

        public string printArchivo(Archivo a)
        {
            String result = null;
            this.Contador++;
            string space = printTabulaciones();
            this.Contador--;
            if (to == null)
            {
                result = space + "f " + a.Nombre + System.Environment.NewLine;

            }
            else {
                result = space + "f " + To.muestraNombre(a.Nombre) + System.Environment.NewLine;
            }
            return result;
        }

        public string printComprimido(Comprimido c)
        {
            String result = null;
            this.Contador++;
            string space = printTabulaciones();
            IList<IElto_Sistema_Archivos> eltos = c.Elementos;
            String todo = null;
            foreach (IElto_Sistema_Archivos e in eltos)
            {
                todo = todo + e.acceptImpresora(this);
            }
            this.Contador--;
            if (To == null)
            {
                result= space + "c " + c.Nombre+ System.Environment.NewLine + todo;
            }
            else
            {
                result= space + "c " + To.muestraNombre(c.Nombre) + System.Environment.NewLine + todo;
            }
            return result;
        }

        public string printDirectorio(Directorio d)
        {
            String result = null;
            this.Contador++;
            string space = printTabulaciones();
            IList<IElto_Sistema_Archivos> eltos = d.Elementos;
            String todo = null;
            foreach (IElto_Sistema_Archivos e in eltos)
            {
                todo = todo + e.acceptImpresora(this);
            }
            this.Contador--;
            if (To == null)
            {
                result = space + "d" + d.Nombre + System.Environment.NewLine + todo;
            }
            else {
                result= space + "d " + To.muestraNombre(d.Nombre) + System.Environment.NewLine + todo;

            }
            return result;
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
            String result = null;
            this.Contador++;
            string space = printTabulaciones();
            this.Contador--;
            if (To == null)
            {

                result = space + "e " + e.Nombre + System.Environment.NewLine;
            }
            else {
                result= space + "e " + To.muestraNombre(e.Nombre) + System.Environment.NewLine;
            }
            return result;
        }
    }
}