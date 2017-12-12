using Checklists.Composite;
using System;

namespace Checklists.Visitante
{
    /// <summary>
    ///     Clase abstracta que representa un visitante de impresión abstracto para
    ///     las listas de comprobación
    /// </summary>
    public abstract class ChecklistPrinter
    {
        /// <summary>
        ///     Método que devuelve una cadena resultado de imprimir en texto la 
        ///     la lista de comprobación que recibe como parámetro.
        /// </summary>
        /// <param name="c">
        ///     La lista de comprobación a imprimir.
        /// </param>
        /// <returns>
        ///     La cadena resultante de imprimir en texto la lista de comprobación
        ///     recibida como parámetro
        /// </returns>
        /// <pre>c != null</pre>
        public abstract String visitChecklist(Checklist c);

        /// <summary>
        ///     Método que devuelve una cadena resultado de imprimir en texto 
        ///     el item a ser comprobado que recibe como parámetro.
        /// </summary>
        /// <param name="item">
        ///     El elemento a ser comprobado que debe ser impreso.
        /// </param>
        /// <returns>
        ///     La cadena resultante de imprimir en texto el elemento a ser comprobado
        ///     recibido como parámetro
        /// </returns>
        /// <pre>item != null</pre>
        public abstract String visitChecklist(ItemToBeChecked item);

    } // ChecklistPrinter
}
