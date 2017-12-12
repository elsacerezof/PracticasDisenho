using Checklists.Visitante;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Checklists.Composite
{
    /// <summary>
    ///     Clase abstracta que ejerce de raíz para la aplicación patrón Composite
    ///     a las listas de comprobación. Representa cualquier elemento que pueda 
    ///     aparecer dentro de una lista de comprobación. 
    /// </summary>
    public abstract class ChecklistElement : IEnumerable<ChecklistElement>
    {
        #region Atributos y Propiedades

        /// <summary>
        ///     El texto asociado al elemento de la lista de comprobación.
        /// </summary>
        private String texto;

        /// <summary>
        ///     El texto asociado al elemento de la lista de comprobación.
        /// </summary>
        /// <pre>(set) (value != null)</pre>
        /// <inv>Texto != null</inv>
        public String Texto
        {
            get
            {
                return texto;
            } // get
            set
            {
                texto = value;
            } // set
        } // Texto

        #endregion

        #region Constructores

        /// <summary>
        ///     Constructor genérico para los elementos de una lista de comprobación
        /// </summary>
        /// <param name="texto">
        ///     El texto asociado al elemento de la lista de comprobación
        /// </param>
        /// <pre>(texto != null)</pre>
        public ChecklistElement(String texto)
        {
            this.Texto = texto;
        } // ChecklistElement(String)

        #endregion

        #region Interfaz Pública

        /// <summary>
        ///     Devuelve un iterador para recorrer elemento de la lista de comprobación.
        /// </summary>
        /// <returns>
        ///     Un iterador para recorrer elemento de la lista de comprobación.
        /// </returns>
        public abstract IEnumerator<ChecklistElement> GetEnumerator();

        /// <summary>
        ///     Devuelve un iterador para recorrer elemento de la lista de comprobación.
        /// </summary>
        /// <returns>
        ///     Un iterador para recorrer elemento de la lista de comprobación.
        /// </returns>
        /// NOTA: Esta función está aquí por compatibilidad con las versiones sin genéricos 
        /// de C#
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        } // IEnumerable.GetEnumerator

        /// <summary>
        ///     Genera una cadena de caracteres con la lista de comprobación
        ///     adecuadamente formateada conforme a las directrices del objeto
        ///     ChecklistPrinter pasado como parámetro.
        /// </summary>
        /// <param name="printer">
        ///     Una impresora de listas de comprobación con unas directrices 
        ///     de impresión concretas. 
        /// </param>
        /// <returns>
        ///     Una cadena de caracteres conteniendo la lista de comprobación 
        ///     adecuadamente formateada para su impresión.
        /// </returns>
        public abstract String acceptPrinter(ChecklistPrinter printer);

        #endregion

    } // class
}
