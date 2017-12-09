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

        #region Atributos

        private String nombre;
        private double tamanho;
        private List<EltoSistObserver> observers;
        

        #endregion

        public Archivo(String nom, double tam)
        {
           
            observers = new List<EltoSistObserver>();
            Nombre = nom;
            Tamanho = tam;
        }

        #region Propiedades

        public override string Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre=value;
                notify();
                
            }
        }

        
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

        public override IList<EltoSistObserver> Observers
        {
            get
            {
                return observers;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override IList<IElto_Sistema_Archivos> Elementos
        {
            get
            {
                return null;
            }

            set
            {
                
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


        protected override void notify()
        {
            
            foreach (EltoSistObserver i in Observers)
            {
                if (Nombre != i.Nombre)
                {
                    i.updateEnlace(this);
                }

            }

        }

        public override void registerObserver(EltoSistObserver obs)
        {
            Observers.Add(obs);
        }

        public override void removeObserver(EltoSistObserver obs)
        {
            throw new NotImplementedException();
        }

        

        #endregion
    }
}
