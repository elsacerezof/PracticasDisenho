using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class Comprimido : Enlazable
    {
        #region Atributos

        private String nombre;
        private double tamanho;
        private IList<IElto_Sistema_Archivos> eltosComp;

        #endregion

        public Comprimido(String nom)
        {
            Nombre = nom;
            eltosComp = new List<IElto_Sistema_Archivos>();
        }

        #region Propiedades

        public override string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public override double Tamanho
        {
            get { return tamanho; }
            set { this.tamanho = value; }
        }

        public IList<IElto_Sistema_Archivos> EltosComp
        {
            get { return eltosComp; }
            set { this.eltosComp = value; }
        }

       

        #endregion

        #region Metodos

        public override double calculaTamanhoTotal()
        {
            double tam = 0;
            foreach (IElto_Sistema_Archivos e in eltosComp) {
                tam = tam + e.Tamanho;
            }
            return tam * 0.3;
        }

        public override int numArchivosCont()
        {
            return eltosComp.Count;
        }

       
        public override IEnumerator<IElto_Sistema_Archivos> GetEnumerator()
        {
            return new ItContenedorComprimido(this);
        }


        #endregion
    }
}
