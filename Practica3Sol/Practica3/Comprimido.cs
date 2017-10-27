using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public class Comprimido : IElto_Sistema_Archivos
    {
        #region Atributos

        private String nombre;
        private double tamanho;
        private IList<IElto_Sistema_Archivos> eltosComp = new List<IElto_Sistema_Archivos>();

        #endregion

        public Comprimido(String nom)
        {
            Nombre = nom;
        }

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public double Tamanho
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

        public double calculaTamanhoTotal()
        {
            double tam = 0;
            foreach (IElto_Sistema_Archivos e in eltosComp)
            {
                tam = tam + e.Tamanho;
            }
            return tam * 0.3;
        }

        public int numArchivosCont()
        {
            return eltosComp.Count;
        }

        public String acceptImpresora(Impresora a)
        {
            return a.printComprimido(this);
        }


        #endregion
    }
}
