using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class ItContenedorComprimido : IEnumerator<IElto_Sistema_Archivos>
    {
        protected EstadoItComprimido estado;
        protected IElto_Sistema_Archivos current;
        protected Comprimido raiz=null;
        protected IEnumerator<IElto_Sistema_Archivos> childIterator = null;
        protected IEnumerator<IElto_Sistema_Archivos> currentIterator = null;
        protected Boolean isDone;
      

        public ItContenedorComprimido(Comprimido c)
        {
            raiz = c;
            Current = null;
            estado = new EstadoCreatedComprimido(this);
            isDone = false;


        }

        public Boolean IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }
      
        public IElto_Sistema_Archivos Current
        {
            get { return current; }
            set { current = value; }
        }

        object IEnumerator.Current
        {
            get { return current; }
        }

        public EstadoItComprimido Estado {
            get { return estado; }
            set { estado = value; }
        }

        public Comprimido Raiz {
            get { return raiz; }
            set { raiz = value; }
        }

        public IEnumerator<IElto_Sistema_Archivos> ChildIterator
        {
            get { return childIterator; }
            set { childIterator = value; }
        }

        public IEnumerator<IElto_Sistema_Archivos> CurrentIterator
        {
            get { return currentIterator; }
            set { currentIterator = value; }
        }

        

        public void Dispose()
        {
            Estado=new EstadoDoneComprimido(this);

        }

        public bool MoveNext()
        {
            return Estado.MoveNext();
        }

        public void Reset()
        {
            Estado= new EstadoRootComprimido(this);
        }

        public void First() {
            Estado=new EstadoCreatedComprimido(this);
        }

       
    }
}
