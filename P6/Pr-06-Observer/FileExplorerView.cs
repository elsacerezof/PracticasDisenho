
using Practica5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_06_Observer
{
    /// <summary>
    ///     Esta clase proporciona una interfaz gráfica para navegar
    ///     por el sistema de archivos Sparrow. Su diseño es simple:
    ///     A la izquierda se presenta en forma de árbol el sistema 
    ///     de archivos y a la derecha se muestra información del 
    ///     nodo que esté actualmente seleccionado.
    ///     
    ///     Esta clase parcial contiene concretamente la lógica del 
    ///     formulario. Todo el código relativo a su apariencia gráfica 
    ///     se adjunta en otra clase parcial.
    /// </summary>
    public partial class FileExplorerView : Form
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Contenedor utilizado para ejecutar varios formularios 
        ///     de manera concurrente.
        /// </summary>
        /// <inv>(runner != null)</inv>
        protected MultiWindowRunner runner;

        /// <summary>
        ///     Sistema de archivos visualizado por el formulario.
        /// </summary>
        private IElto_Sistema_Archivos sparrowFileSystem;

        /// <summary>
        ///     Sistema de archivos visualizado por el formulario.
        /// </summary>
        /// <pre>set: (value != null)</pre>
        public IElto_Sistema_Archivos SparrowFileSystem
        {
            get
            {
                return sparrowFileSystem;
            } // get
            set
            {
                this.sparrowFileSystem = value;
                // Generamos el árbol de directorios
                TreeNode root = SistemaArchivo2Node(value);
                // Añadimos el árbol generado al control gráfico
                this.FileSystemTreeViewer.Nodes.Add(root);
            } // set
        } // SparrowFileSystem

        #endregion

        #region Constructores

        /// <summary>
        ///     Constructor de la clase FileExploreerView
        /// </summary>
        /// <param name="runner">
        ///     Clase utilizada como contenedor para ejecutar 
        ///     diversos formularios de manera concurrente.
        /// </param>
        /// <pre>(runner != null)</pre>
        public FileExplorerView(MultiWindowRunner runner)
        {
            InitializeComponent();
            this.runner = runner;
        } // FileExplorerView

        #endregion

        #region Respuestas a eventos

        /// <summary>
        ///     Método invocado cuando se cierra el formulario. Este
        ///     método es automáticamente invocado por la plataforma
        ///     cuando se cierra el formulario. Este método notifica a
        ///     la clase MultiWindowRunner que el formulario actual 
        ///     se ha cerrado, de manera que cuando no existan más 
        ///     formularios abiertos, dicha clase cierre la aplicación.
        /// </summary>
        /// <param name="sender">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.
        /// </param>
        /// <param name="e">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.
        /// </param>
        private void onClose(object sender, FormClosedEventArgs e)
        {
            runner.formClosed(this);
        } // onClose

        /// <summary>
        ///     Método que se invoca siempre que se selecciona un nuevo nodo
        ///     en el árbol de directorios que se muestra en el formulario. 
        ///     El método recupera el nodo recuperado y lo añade al control 
        ///     encargada de visualizar la información sobre el elemento
        ///     actualmente seleccionado.
        /// </summary>
        /// <param name="sender">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.
        /// </param>
        /// <param name="e">
        ///     Objeto que contiene diversa información acerca del nodo 
        ///     seleccionado. En este caso se utiliza para recuperar el 
        ///     nodo seleccionado. 
        /// </param>
        /// <pre>(e != null) && (e.Node != null)</pre>
        private void onElementSelected(object sender, TreeViewEventArgs e)
        {
            // Este casting indeseable es causa de una mala implementación 
            // del control TreeView. Creando una clase genérica TreeView<T>
            // se podría haber evitado. Dicha clase pertenece a la biblioteca
            // de controles para aplicaciones de escritorio de .NET
            SparrowNode selected = (SparrowNode) e.Node;
            this.spv_ElementViewer.SparrowElement = selected.ReferencedElement;
        } // onElementSelected

        #endregion

        #region Métodos privados de soporte

        /// <summary>
        ///     Genera un árbol de nodos con la visualización del
        ///     sistema de archivos.
        /// </summary>
        /// <param name="fs">
        ///     El sistema de archivos que debe ser pasado a un árbol
        ///     de nodos.
        /// </param>
        /// <returns>
        ///     Un árbol de nodos correspondiente al sistema de archivos
        ///     pasado como parámetro.
        /// </returns>
        /// <pre>(fs != null)</pre>
        protected TreeNode SistemaArchivo2Node(IElto_Sistema_Archivos fs)
        {

            // Creamos el nodo raíz
            TreeNode result = new SparrowNode(fs);
            if (fs.Elementos != null) {
                // Añadimos los hijos al nodo raíz
                // Para ello iteramos sobre los hijos del raíz
                foreach (IElto_Sistema_Archivos s in fs.Elementos)
                {

                    // Construimos el árbol correspondiente al hijo actual
                    TreeNode newChild = SistemaArchivo2Node(s);
                    // Añadimos ese hijo a la colección de hijos del nodo 
                    // raíz
                    result.Nodes.Add(newChild);
                }
            } // foreach
        
            return result;

        } // SistemaArchivo2Node

        

        #endregion

    } // class FileEXplorerView

}
