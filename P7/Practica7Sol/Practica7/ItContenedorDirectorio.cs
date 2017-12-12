using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class ItContenedorDirectorio : IEnumerator<IElto_Sistema_Archivos>
    {
        protected EstadoItDirectorio estado;
        protected IElto_Sistema_Archivos current;
        protected Directorio raiz = null;
        protected IEnumerator<IElto_Sistema_Archivos> childIterator = null;
        protected IEnumerator<IElto_Sistema_Archivos> currentIterator = null;
        protected Boolean isDone;

        public ItContenedorDirectorio(Directorio d) {

            raiz = d;
            current = null;
            estado = new EstadoCreatedDirectorio(this);
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

        public EstadoItDirectorio Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Directorio Raiz
        {
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
            Estado = new EstadoDoneDirectorio(this);

        }

        public bool MoveNext()
        {
            return Estado.MoveNext();
        }

        public void Reset()
        {
            Estado = new EstadoRootDirectorio(this);
        }

        public void First()
        {
            Estado = new EstadoCreatedDirectorio(this);
        }


    }
}
   