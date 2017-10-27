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
        private double tamanho;

        IElto_Sistema_Archivos destino;

        public Enlace(IElto_Sistema_Archivos e)
        {

            if (e.GetType() == typeof(Enlace))
            {
                throw new Exception();
            }

            destino = e;
            nombre = e.Nombre;
            tamanho = 1.0;
        }

        /**
         * Preguntar si cambiando nombre del destion se tiene que cambiar el del enlace
         * 
         * Preguntar si hay que restringir que si se hace set del nombre del enlace se debe 
         * comprobar que sea el mismo que el del destino.
         */
   
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /**
         * Preguntar si sirven los set en el caso de nombre y tamaño
         */
        public double Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        public double calculaTamanhoTotal()
        {
            return tamanho;
        }

        public int numArchivosCont()
        {
            return 0;
        }
    }
}
