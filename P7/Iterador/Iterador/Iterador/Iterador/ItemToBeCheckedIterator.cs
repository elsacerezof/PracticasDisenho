using Checklists.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Checklists.Iterador
{
    /// <summary>
    ///     Clase que representa un iterador sobre un elemento a ser comprobado 
    ///     que forma parte de una lista de comprobación
    /// </summary>
    public class IteradorItemtoBeChecked : IEnumerator<ChecklistElement>
    {

        #region itemToBeChecked

        /// <summary>
        ///     Elemento actual al que apunta el iterador. De inicio, antes de que 
        ///     se mueva el iterador por primera vez, su valor será nulo.
        /// </summary>
        protected ItemToBeChecked current = null;
        
        /// <summary>
        ///     Referencia al elemento sobre el que iterador el presente iterador
        /// </summary>
        protected ItemToBeChecked element = null;

        /// <summary>
        ///     Elemento actual apuntado por el iteador
        /// </summary>
        public ChecklistElement Current
        {
            get
            {
                return this.current;
            } // get
        } // ChecklistElement

        /// <summary>
        ///     <see cref="ItemToBeChecked.Current"/>
        ///     Este método se incluye por compatabilidad con las 
        ///     liberías no génericas del lenguaje
        /// </summary>
        object IEnumerator.Current
        {
            get
            {
                return this.current;
            } // get
        } // Current

        #endregion

        #region Constructores

        /// <summary>
        ///     Crear un nuevo iterador sobre el elemento de la lista de 
        ///     comprobación que se le pasa como parámetro.
        /// </summary>
        /// <param name="item">
        ///     El elemento de la lista de comprobación que se desea recorrer
        ///     mediante la creación del iterador.
        /// </param>
        /// <pre>item != null</pre>
        public IteradorItemtoBeChecked(ItemToBeChecked item)
        {
            this.element = item;
        } // IteradorItemtoBeChecked

        #endregion

        #region Interfaz Pública del Iterador

        /// <summary>
        ///     Libera los recursos utilizados por el iterador antes de que éste se destruya.
        /// </summary>
        public void Dispose() {}

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
            bool moved = false;

            // Si current apunta a nulo, es que el iterador nunca se ha movido,
            // por tanto, podemos moverlo.
            if (current == null)
            {
                // Accemos que el iterador apunte al elemento a recorrer.
                this.current = this.element;
                // E indicamos que nos hemos movido
                moved = true;
            } // if

            return moved;
        } // MoveNext

        /// <summary>
        ///     Devolvemos el iterador a su estado inicial
        /// </summary>
        public void Reset()
        {
            this.current = null;
        } // Reset

        #endregion
    } // class ItemToBeChecked
}
