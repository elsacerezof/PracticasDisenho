using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
   public class Archivo : IElto_Sistema_Archivos
    {

        #region Atributos

        private String nombre;
        private double tamanho;

        #endregion   

        #region Propiedades

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

        #endregion

        #region Metodos

        public Archivo(String nom, double tam)
        {
            if (nom == null || tam < 0)
            {
                throw new Exception();
            }

            Nombre = nom;
            Tamanho = tam;
        }

        public double calculaTamanhoTotal()
        {
            return tamanho;
        }

        public int numArchivosCont()
        {
            return 0;
        }

        #endregion
    }
}
