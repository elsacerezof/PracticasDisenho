using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Archivo : Enlazable
    {

        #region Atributos

        private String nombre;
        private double tamanho;

        #endregion

        public Archivo(String nom, double tam)
        {
            if (nom == null || tam < 0)
            {
                throw new Exception();
            }

            Nombre = nom;
            Tamanho = tam;
        }

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

        public double calculaTamanhoTotal()
        {
            return tamanho;
        }

        public int numArchivosCont()
        {
            return 0;
        }

        public String acceptImpresora(Impresora a) {

            return a.printArchivo(this);
        }

        #endregion
    }
}
