using Pr_06_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Comprimido : Enlazable
    {
       

        public Comprimido(String nom)
        {
            Observers = new HashSet<EltoSistObserver>();
            elementos = new List<IElto_Sistema_Archivos>();
            Nombre = nom;
        }

        #region Propiedades

       

        public override double Tamanho
        {
            get { return tamanho; }
            set { this.tamanho = value; }
        }

        #endregion

        #region Metodos

        public override double calculaTamanhoTotal()
        {
            double tam = 0;
            foreach (IElto_Sistema_Archivos e in Elementos)
            {
                tam = tam + e.Tamanho;
            }
            return tam * 0.3;
        }

        public override int numArchivosCont()
        {
            return Elementos.Count;
        }

        public override String acceptImpresora(Impresora a)
        {
            return a.printComprimido(this);
        }

        #endregion
    }
}
