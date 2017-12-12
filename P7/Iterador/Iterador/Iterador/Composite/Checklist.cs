using Checklists.Iterador;
using Checklists.Visitante;
using System;
using System.Collections.Generic;

namespace Checklists.Composite
{

    /// <summary>
    ///     Clase que representa una lista de comprobación. La lista 
    ///     de comprobación contendrá diferentes items a ser comprobado.
    ///     Esos items pueden a su vez ser listas de comprobación 
    ///     anidadas.
    /// </summary>
    public class Checklist : ChecklistElement
    {
        #region Atributos y Propiedades

        /// <summary>
        ///     Elementos contenidos por la lista de comprobación.
        /// </summary>
        protected List<ChecklistElement> items = new List<ChecklistElement>();

        /// <summary>
        ///     Lista de elementos pertenecientes a la lista de comprobación. Estos
        ///     pueden ser tanto elementos simples como sublistas de comprobación.
        /// </summary>
        public List<ChecklistElement> Items
        {
            get
            {
                return items;
            } // get
        } // Items

        #endregion

        #region Constructores

        /// <summary>
        ///     Constructor de la clase lista de comprobación (checklist). 
        /// </summary>
        /// <param name="texto">
        ///     Título de la lista de comprobación.
        /// </param>
        /// <pre>texto != null</pre>
        public Checklist(String texto) : base(texto) {

        } // Checklist(String)

        #endregion

        #region InterfazPública

        /// <summary>
        ///   <see cref="ChecklistElement.GetEnumerator"/>     
        /// </summary>
        public override IEnumerator<ChecklistElement> GetEnumerator()
        {
            return new IteradorChecklist(this);
        } // GetEnumerator

        /// <summary>
        ///     <see cref="ChecklistElement.acceptPrinter(ChecklistPrinter)"/>
        /// </summary>
        public override String acceptPrinter(ChecklistPrinter printer)
        {
            return printer.visitChecklist(this);
        } // acceptPrinter

        #endregion

    } // class
}
