using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
     public class ItHojaArchivo : IEnumerator<IElto_Sistema_Archivos>
    {
        protected EstadoItArchivo estado;
        protected IElto_Sistema_Archivos current;
        protected Archivo raiz = null;
        protected Boolean isDone;

        public ItHojaArchivo(Archivo d)
        {

            raiz = d;
            current = null;
            estado = new EstadoCreatedArchivo(this);
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

        public EstadoItArchivo Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Archivo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        
        public void Dispose()
        {
            
            Estado = new EstadoDoneArchivo(this);

        }

        
        public void Reset()
        {
            Estado = new EstadoRootArchivo(this);
        }

        public void First()
        {
            Estado = new EstadoCreatedArchivo(this);
        }

        public bool MoveNext()
        {
            return Estado.MoveNext();
        }
    }
}
