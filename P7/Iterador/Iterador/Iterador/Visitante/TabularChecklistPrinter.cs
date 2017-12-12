using Checklists.Composite;
using System;
using System.Text;

namespace Checklists.Visitante
{
    /// <summary>
    ///     Visitante de impresión para las listas de comprobación que las
    ///     imprime en formato árboreo estandarizado, tabulando ligeramente 
    ///     cada sublista dentro de una lista. 
    /// </summary>
    public class TabularChecklistPrinter : ChecklistPrinter
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Nivel de anidamiento actual del visitante de impresión
        /// </summary>
        protected int level = 0;

        #endregion

        #region Implementación del Visitante Abstracto

        /// <summary>
        ///     <see cref="ChecklistPrinter.visitChecklist(Checklist)"/>
        /// </summary>
        public override String visitChecklist(Checklist c)
        {
            StringBuilder result = new StringBuilder();

            // Imprimimos el titulo de la lista
            result.Append(generateTabs()).Append(c.Texto).Append("\n");
            // Procesamos los hijos
            this.level = this.level + 1;
            foreach(ChecklistElement ce in c.Items)
            {
                result.Append(ce.acceptPrinter(this));
            }
            this.level = this.level - 1;

            return result.ToString();
        } // visitChecklist

        /// <summary>
        ///     <see cref="ChecklistPrinter.visitChecklist(ItemToBeChecked)"/>
        /// </summary>
        public override string visitChecklist(ItemToBeChecked item)
        {
            return generateTabs() + item.Texto + "\n";
        }

        #region Métodos Privados Auxiliares

        /// <summary>
        ///     Genera una cadena con espacios en blanco correspondientes 
        ///     a tantas tabulaciones como corresponda al nivel de anidamiento
        ///     en el cual se encuentra el visitante.
        /// </summary>
        /// <returns>
        ///     La cadena con espacios en blanco correspondientes 
        ///     a tantas tabulaciones como corresponda al nivel de anidamiento
        ///     en el cual se encuentra el visitante.
        /// </returns>
        protected String generateTabs()
        {
            StringBuilder tabs = new StringBuilder();

            for (int i = 0; i < level; i++)
            {
                tabs.Append("  ");
            } // for

            return tabs.ToString();
        } // generateTabs

        #endregion

        #endregion


    }
}
