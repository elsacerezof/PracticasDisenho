using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    public class Enlace : IElto_Sistema_Archivos
    {
        private String nombre;
        private double TAMANHO=1;

        Enlazable destino;

        public Enlace(Enlazable e)
        {
            destino = e;
            nombre = e.Nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = destino.Nombre; }
        }

        
        public double Tamanho
        {
            get { return TAMANHO; }
            set { }
        }

        public double calculaTamanhoTotal()
        {
            return TAMANHO;
        }

        public int numArchivosCont()
        {
            return 0;
        }
    }
}
