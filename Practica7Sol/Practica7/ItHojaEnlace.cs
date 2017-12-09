using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    public class ItHojaEnlace : IEnumerator<IElto_Sistema_Archivos>
    {
        protected EstadoItEnlace estado;
        protected IElto_Sistema_Archivos current;
        protected Enlace raiz;
        protected Boolean isDone;

        public ItHojaEnlace(Enlace e)
        {

            raiz = e;
            current = null;
            estado = new EstadoCreatedEnlace(this);
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

        public EstadoItEnlace Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Enlace Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }


        public void Dispose()
        {
            Estado = new EstadoDoneEnlace(this);

        }


        public void Reset()
        {
            Estado = new EstadoRootEnlace(this);
        }

        public void First()
        {
            Estado = new EstadoCreatedEnlace(this);
        }

        public bool MoveNext()
        {
            return Estado.MoveNext();
        }
    }
}
