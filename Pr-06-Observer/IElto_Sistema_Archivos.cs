using Pr_06_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    public abstract class IElto_Sistema_Archivos
    {
        protected String nombre;
        protected double tamanho;
        protected ISet<EltoSistObserver> observers;
        protected IList<IElto_Sistema_Archivos> elementos;

        public String Nombre
        {
            get { return nombre; }
            set
            {
                this.nombre = value;
                notify();
            }
        }
        public abstract double Tamanho { get; set; }
        public ISet<EltoSistObserver> Observers { get { return observers; } set { observers = value; } }

        public IList<IElto_Sistema_Archivos> Elementos
        {
            get { return elementos; }
            set { this.elementos = value; }
        }

        public abstract double calculaTamanhoTotal();
        public abstract int numArchivosCont();
        public abstract String acceptImpresora(Impresora a);

        public void registerObserver(EltoSistObserver obs)
        {
            Observers.Add(obs);
        }

        public void removeObserver(EltoSistObserver obs)
        {
            Observers.Remove(obs);
        }

        protected void notify()
        {

            foreach (EltoSistObserver i in Observers)
            {
                
                    i.update(this);
                

            }

        }
        
    }
}

