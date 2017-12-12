using Checklists.Iterador;
using Checklists.Visitante;
using System;
using System.Collections.Generic;

namespace Checklists.Composite
{
    /// <summary>
    ///     Un elemento simple perteneciente a una lista de comprobación.
    /// </summary>
    public class ItemToBeChecked : ChecklistElement
    {

        #region Constructores

        /// <summary>
        ///     Constructor de la clase elemento de lista de comprobación 
        ///     (item to be checked). 
        /// </summary>
        /// <param name="texto">
        ///     Texto del elemento de lista de comprobación.
        /// </param>
        /// <pre>texto != null</pre>
        public ItemToBeChecked(String texto) : base(texto)
        {

        } // ItemToBeChecked(String)

        #endregion

        #region Interfaz pública 

        /// <summary>
        ///     <see cref="ChecklistElement.acceptPrinter(ChecklistPrinter)"/> 
        /// </summary>
        public override String acceptPrinter(ChecklistPrinter printer)
        {
            return printer.visitChecklist(this);
        } // acceptPrinter

        /// <summary>
        ///     <see cref="ChecklistElement.GetEnumerator"/>
        /// </summary>
        public override IEnumerator<ChecklistElement> GetEnumerator()
        {
            return new IteradorItemtoBeChecked(this);
        } // GetEnumerator

        #endregion

    } // class
}
