using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class Enlace : IElto_Sistema_Archivos
    {
        private String nombre;
        private double tamanho;

        Enlazable destino;

        public Enlace(Enlazable e)
        {
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

        public IEnumerator<IElto_Sistema_Archivos> GetEnumerator()
        {
            return new ItHojaEnlace(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ItHojaEnlace(this);
            
        }
    }
}
