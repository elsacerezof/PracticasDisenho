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

        #region Atributos

        private String nombre;
        private double tamanho;
        private IList<IElto_Sistema_Archivos> elementos;
        private IList<EltoSistObserver> observers;
        #endregion

        public Directorio(String nom)
        {
            observers = new List<EltoSistObserver>();
            Nombre = nom;
            elementos = new List<IElto_Sistema_Archivos>();
            tamanho = calculaTamanhoTotal();

        }

        #region Propiedades

        public override string Nombre
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
