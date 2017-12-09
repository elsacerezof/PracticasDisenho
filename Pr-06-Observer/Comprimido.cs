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
        #region Atributos

        private String nombre;
        private double tamanho;
        private IList<IElto_Sistema_Archivos> elementos;
        private List<EltoSistObserver> observers;

        #endregion

        public Comprimido(String nom)
        {
            observers = new List<EltoSistObserver>();
            elementos = new List<IElto_Sistema_Archivos>();
            Nombre = nom;
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

        public override IList<IElto_Sistema_Archivos> Elementos
        {
            get { return elementos; }
            set { this.elementos = value; }
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

        protected override void notify()
        {
            throw new NotImplementedException();
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
