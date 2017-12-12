using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    public class Directorio : Enlazable
    {

        #region Atributos

        private String nombre;
        private double tamanho;

        //Implementado con list pero mejor set ya que la
        //posicion de los elementos no es relevante
        private IList<IElto_Sistema_Archivos> elementos;

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nom"></param>
        /// <pre>nom !=null</pre>
        public Directorio(String nom)
        {
            Nombre = nom;
            elementos = new List<IElto_Sistema_Archivos>();
            tamanho = calculaTamanhoTotal();

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
            
        }

        public IList<IElto_Sistema_Archivos> Elementos
        {
            get { return elementos; }
            set { this.elementos = value; }
        }

        #endregion


        #region Metodos

        public double calculaTamanhoTotal()
        {
            double tam = 1;
            foreach (IElto_Sistema_Archivos e in elementos)
            {
                tam = tam + e.Tamanho;
            }

            return tam;
        }

        public int numArchivosCont()
        {
            int cuenta = 0;
            foreach(IElto_Sistema_Archivos e in Elementos){
                cuenta = 1 + e.numArchivosCont();  
            }
            return cuenta;
        }

        public String acceptImpresora(Impresora a)
        {
            return a.printDirectorio(this);
        }


        #endregion
    }
}
