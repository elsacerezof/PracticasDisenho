using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Enlace : IElto_Sistema_Archivos
    {
        private String nombre;
        private double tamanho;

        Enlazable destino;

        public Enlace(Enlazable e)
        {

            if (e.GetType() == typeof(Enlace))
            {
                throw new Exception();
            }

            destino = e;
            nombre = e.Nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null)
                {
                    throw new Exception();
                }
                this.nombre = value;
            }
        }

        public double Tamanho
        {
            get { return tamanho; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                this.tamanho = value;
            }
        }

        public double calculaTamanhoTotal()
        {
            return 1.0;
        }

        public int numArchivosCont()
        {
            return 0;
        }

        public string acceptImpresora(Impresora a)
        {
           return a.printEnlace(this);
        }
    }
}
