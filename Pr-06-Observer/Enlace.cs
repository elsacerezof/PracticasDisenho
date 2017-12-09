using Pr_06_Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica5
{
    public class Enlace : IElto_Sistema_Archivos,EltoSistObserver
    {
        private String nombre;
        private double tamanho;
        private List<EltoSistObserver> observers;
        Enlazable destino;

        public Enlace(Enlazable e)
        {
            observers = new List<EltoSistObserver>();

            destino = e;
            nombre = e.Nombre;
            e.registerObserver(this);
        }

        public List<EltoSistObserver> Observers
        {
            get { return observers; }
            set
            {
               
                this.observers = value;
            }
        }
        public override IList<IElto_Sistema_Archivos> Elementos
        {
            get
            {
                return null;
            }
            set { }
        }

        public override string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                Destino.Nombre = value;
                
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

        
        public Enlazable Destino {
            get
            {
                return destino;    
            }
            set
            {
                destino = value;
            }
        }

       

        public override double calculaTamanhoTotal()
        {
            return 1.0;
        }

        public override int numArchivosCont()
        {
            return 0;
        }

        public override string acceptImpresora(Impresora a)
        {
            return a.printEnlace(this);
        }

        public override void registerObserver(EltoSistObserver e) {
            Observers.Add(e);
        }

        public override void removeObserver(EltoSistObserver e) {
            Observers.Remove(e);
        }

        

        public void updateEnlace(Enlazable elto)
        {
            
            Nombre = elto.Nombre;
        }

        
    }
}
