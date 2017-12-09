using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica5;

namespace Pr_06_Observer
{
    /// <summary>
    ///     Clase utilizada para visualizar un elemento cualquiera del 
    ///     sistema de archivos Sparrow como nodo de un TreeView. 
    /// </summary>
    public class SparrowNode : TreeNode, EltoSistObserver
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Elemento del sistema de archivos visualizado por este nodo.
        /// </summary>
        /// <inv>(referencedElement != null)</inv>
        protected IElto_Sistema_Archivos referencedElement;

        /// <summary>
        ///     Elemento del sistema de archivos Sparrow referenciado por
        ///     el nodo.
        /// </summary>
        public IElto_Sistema_Archivos ReferencedElement
        {
            get
            {
                return referencedElement;
            }
        }

        public string Nombre
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        ///     Constructor de la clase
        /// </summary>
        /// <param name="sa">
        ///     Elemento del sistema de archivos Sparrow a visualizar
        /// </param>
        /// <pre>(sa != null)</pre>
        public SparrowNode(IElto_Sistema_Archivos sa) : base(sa.Nombre)
        {
            this.referencedElement = sa;
            this.Text = referencedElement.Nombre;
        } // SparrowNode

        public void updateEnlace(Enlazable e)
        {
            referencedElement = e;
        }

        

        #endregion

    } // class SparrowNode 
} // namespace
