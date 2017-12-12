using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
   public class Archivo : Enlazable
    {

        #region Atributos

        private String nombre;
        private double tamanho;

        #endregion   

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value;}
        }

        public double Tamanho
        {
            get { return tamanho; }
            set { this.tamanho = value; }
        }

        #endregion

        #region Metodos

        public Archivo(String nom, double tam)
        {
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
