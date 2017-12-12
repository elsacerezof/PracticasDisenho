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
        
        Enlazable destino;

        public Enlace(Enlazable e)
        {
            Observers = new HashSet<EltoSistObserver>();

            destino = e;
            nombre = e.Nombre;
            e.registerObserver(this);
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

        public void update(IElto_Sistema_Archivos elto)
        {
            if (!elto.Nombre.Equals(this.Nombre))
            {
                Nombre = elto.Nombre;
            }
           
        }
    }
}
