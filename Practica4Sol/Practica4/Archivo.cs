using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Archivo : Enlazable
    {

        #region Atributos

        private String nombre;
        private double tamanho;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="tam"></param>
        /// <pre>nom!=null</pre>
        /// <pre>tam>=0</pre>
        public Archivo(String nom, double tam)
        {
            Nombre = nom;
            tamanho = tam;
        }

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
            }
        }

        public double Tamanho
        {
            get { return tamanho; }
            
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
