using Pr_06_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public class Archivo : Enlazable
    {

       

        public Archivo(String nom, double tam)
        {
           
            Observers = new HashSet<EltoSistObserver>();
            Nombre = nom;
            Tamanho = tam;
        }

        #region Propiedades

        

        
        public override double Tamanho
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

        public override double calculaTamanhoTotal()
        {
            return tamanho;
        }

        public override int numArchivosCont()
        {
            return 0;
        }

        public override String acceptImpresora(Impresora a)
        {

            return a.printArchivo(this);
        }


       

       

        

        #endregion
    }
}
