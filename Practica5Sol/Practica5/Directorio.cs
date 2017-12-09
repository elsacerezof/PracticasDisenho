using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Directorio : Enlazable
    {

        #region Atributos

        private String nombre;
        private double tamanho;
        private IList<IElto_Sistema_Archivos> elementos;

        #endregion

        public Directorio(String nom)
        {
            if (nom == null)
            {
                throw new Exception();
            }
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
            set { this.tamanho = value; }
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
            return elementos.Count;
        }

        public String acceptImpresora(Impresora a)
        {
            return a.printDirectorio(this);
        }


        #endregion
    }
}
