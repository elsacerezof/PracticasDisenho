using Pr_06_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Directorio : Enlazable
    {


        public Directorio(String nom)
        {
            Observers = new HashSet<EltoSistObserver>();
            Nombre = nom;
            elementos = new List<IElto_Sistema_Archivos>();
            tamanho = calculaTamanhoTotal();

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

        public override String acceptImpresora(Impresora a)
        {
            return a.printDirectorio(this);
        }

       


        #endregion
    }
}
