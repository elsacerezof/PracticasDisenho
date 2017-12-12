using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
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
            
        }

        #region Propiedades

        public override string Nombre
        {
            get{ return nombre; }
            set
            {
                if (value == null)
                {
                    throw new Exception();
                }
                this.nombre = value;
            }
        }

        public override double Tamanho
        {
            get{ return tamanho; }
            set{ this.tamanho = value; }
        }

        public IList<IElto_Sistema_Archivos> Elementos
        {
            get { return elementos; }
            set { this.elementos = value; }
        }

        #endregion


        #region Metodos

        public override double calculaTamanhoTotal()
        {
            double tam = 1;
            foreach (IElto_Sistema_Archivos e in elementos)
            {
                tam = tam + e.Tamanho;
            }

            return tam;
        }

        public override int numArchivosCont()
        {
            return elementos.Count;
        }

        public override IEnumerator<IElto_Sistema_Archivos> GetEnumerator()
        {
            return new ItContenedorDirectorio(this);
        }

        #endregion
    }
}
