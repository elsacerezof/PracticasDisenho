using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checklists.Composite;

namespace Checklists.Iterador
{
    /// <summary>
    ///     Clase que proporciona un iterador sobre una lista 
    ///     de comprobación (checklist) 
    /// </summary>
    public class IteradorChecklist : IEnumerator<ChecklistElement>
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Elemento actual al que apunta el iterador. Recuperable
        ///     a través de la propiedad Current. Cuando se crea el 
        ///     iterador y antes de su primer movimiento, su valor es 
        ///     null. Después de su último movimient, su valor es 
        ///     indefinido.
        /// </summary>
        /// <inv>(this.MoveNext() implies (current != null))</inv>
        protected ChecklistElement current = null;
        
        /// <summary>
        ///     Referencia al inicio de la lista de comprobación sobre 
        ///     la que este iterador itera.
        /// </summary>
        /// <inv>(theChecklist != null)</inv>
        protected Checklist theChecklist;

        /// <summary>
        ///     Iterador sobre la lista de hijos de la lista de 
        ///     comprobación.
        /// </summary>
        protected IEnumerator<ChecklistElement> childIterator   = null;

        /// <summary>
        ///     Iterador sobre el hijo de la lista de comprobación 
        ///     que estemos actualmente recorriendo.
        /// </summary>
        protected IEnumerator<ChecklistElement> currentIterator = null;

        /// <summary>
        ///     El elemento actualmente referenciado por el iterador
        /// </summary>
        public ChecklistElement Current
        {
            get
            {
                return current;
            } // get
        } // Current

        /// <summary>
        ///     <see cref="IteradorChecklist.Current"/>
        ///     Este método se añade aquí por compatibilidad con las versiones
        ///     no genéricas del lenguaje.
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return this.current;
            } // get
        } // IEnumerator.Current

        #endregion

        #region Constructores

        /// <summary>
        ///    Crea un nuevo iterador sobre la lista de comprobación pasada como 
        ///    parámetro.
        /// </summary>
        /// <param name="cl">
        ///     La lista de comprobación sobre la que iterará el iterador creado
        /// </param>
        public IteradorChecklist(Checklist cl)
        {
            this.theChecklist  = cl;
        } // IteradorChecklist

        #endregion

        #region Interfaz del Iterador

        /// <summary>
        ///     Libera los recursos utilizados por el iterador antes de que éste se destruya.
        /// </summary>
        public void Dispose() { }

        /// <summary>
        ///     Avanza el iterador si aún quedan elementos por recorrer, situando su propiedad
        ///     Current en el siguiente elemento
        /// </summary>
        /// <returns>
        ///     Devuelve verdadero si se ha podido avanzar el iterador. Devuelve false si el iterador 
        ///     ha finalizado y no quedan más elementos por recorrer. En caso de que devuelva falso, 
        ///     el valor de la propiedad Current queda indefinido.
        /// </returns>
        public bool MoveNext()
        {
            // Variable que guarda el resultado a devolver
            bool moved = false;

            // Si es la primera vez que nos movemos, current debe valer null
            if (current == null)
            {
                // En el caso del primer elemento, hacemos que el elemento actual apunte 
                // a la propia lista de comprobación e indicamos que nos hemos movido.
                current = theChecklist;
                moved  = true;
            }
            // Si es la segunda vez que nos movemos, tendremos que empezar a iterar por los
            // hijos, si los hubiere. En el caso del segundo movimiento, current es distinto
            // de null (comprobado en la rama anterior) y el iterador de los hijos no ha sido
            // aún creado. Es decir, el iterador de los hijos valdrá null
            else if (childIterator == null)
            {
                // Obtenemos un iterador para los hijos. 
                // NOTA: Items nunca puede ser null, en caso de no tener hijos, sería 
                // un conjunto vacío.
                childIterator = theChecklist.Items.GetEnumerator();
                // Intentamos avanzar el iterador de los hijos para colocarlo en el primer
                // hijo, ya que en el caso de que la lista no tenga hijos, este iterador
                // no se podría avanzar nunca
                if(childIterator.MoveNext())
                {
                    // Si hay algún hijo, colocamos el iterador de los hijos apuntando al 
                    // primer no del árbol correspondondiente a dicho hijo
                    iniatilizeIteratorOverChild();
                    // Además, indicamos que hemos tenido éxito y nos hemos movido.
                    moved = true;
                } // if
            }
            /// Si el iterador de hijos está inicializado es que ya estamos en la fase de movernos
            /// por los hijos. Por lo tanto, intentamos movernos al siguiente nodo del iterador 
            /// sobre los hijos actual. Si no estuviese inicializado, es porque la lista de 
            /// comprobación no tiene hijos y por tanto es imposible inicializar el iterador
            /// de hijos, por lo que currentIteraror permance a null, a pesar de ser childIterator
            /// distinto de null
            /// NOTA: Un truco para evitar estas comprobaciones sería crear un iterador nulo para
            /// el caso de que la lista no tenga hijos. El iterador nulo es un iterador que siempre
            /// devuelve false cuando se ejecuta el MoveNext().
            else if ((currentIterator != null) && (currentIterator.MoveNext())) {
                // Si hemos podido movernos, accedemos al elemento actual y hacemos que nuestra 
                // referencia current apunte a él
                current = currentIterator.Current;
                // Como nos hemos movido, lo señalamos
                moved = true;
            }
            /// Si el iterador de los hijos está inicializado, pero no nos podemos mover por 
            /// el iterador de los hijos, es porque el iterador del hijo actual se ha acabado e intentamos,
            /// por tanto, movernos al siguiente hijo. 
            else if (childIterator.MoveNext())
            {
                // Si hemos conseguido movernos al siguiente hijo, inicializamos el iterador para movernos 
                // por los nodos que correspondan al siguiente hijo.
                iniatilizeIteratorOverChild();
                // Como nos hemos movido, lo señalizamos.
                moved = true;
            } // if infernal

            return moved;

        } // MoveNext

        /// <summary>
        ///     Devolvemos el iterador a su estado inicial
        /// </summary>
        public void Reset()
        {
            current = null;
            childIterator = null;
        } // Reset

        #endregion

        #region Métodos privados de soporte

        /// <summary>
        ///     Asumiendo que hemos movido el iterador sobre el conjuntos de los 
        ///     a un nuevo hijos, creamos un nuevo iterador para recorrer dicho 
        ///     hijo y lo colocamos apuntando a dicho hijo.
        /// </summary>
        protected void iniatilizeIteratorOverChild()
        {
            // Creamos un iterador para recorrer el nuevo hijo. 
            // Puesto que nos hemos movido childIteraror.Current !!= null y 
            // currentIterator != null
            currentIterator = childIterator.Current.GetEnumerator();
            // Los iteradores sobre ChecklistElement siempre se pueden mover al
            // menos un elemento, por lo que lo movemos y lo situamos en el 
            // primer elemento.
            currentIterator.MoveNext();
            // Hacemos que nuestro atributo current apunte a la misma posición 
            // que el iterador sobre el hijo. 
            current = currentIterator.Current;
        } // moveToNextChildIterator

        #endregion  
    }
}
