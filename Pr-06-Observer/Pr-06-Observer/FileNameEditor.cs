using Pr04_Folders;
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
    /// 
    ///    Clase gráfica con apariencia escasamente profesional cuyo único 
    ///    objetivo es permitir la edición de los nombres de los elementos
    ///    del sistema de archivos Sparrow.
    ///    
    ///    Se compone de una matriz de datos con una única columna que 
    ///    muestra los nombres, alfabéticamente ordenados, de los diferentes
    ///    elementos que conforman un determinado sistema de archivos.
    /// 
    ///    Esta clase parcial contiene concretamente la lógica del 
    ///    formulario. Todo el código relativo a su apariencia gráfica 
    ///    se adjunta en otra clase parcial.
    ///
    /// </summary>
    public partial class FileNameEditor : Form
    {

        #region Atributos y Propiedades

        /// <summary>
        ///     Clase encargada de correr los formularios. Permite ejecutar
        ///     varios formularios de manera concurrente y cerrar la 
        ///     aplicación cuando se hayan cerrado todos. 
        /// </summary>
        protected MultiWindowRunner runner;

        /// <summary>
        ///     Nombre del último elemento editado.
        /// </summary>
        protected String changedElementName;

        /// <summary>
        ///     Diccionario con todos los nombres procedentes del sistema
        ///     de archivos. Se asume que el sistema de archivos no 
        ///     tiene elementos con nombres duplicados, a excepeción de los
        ///     enlaces.
        /// </summary>
        /// <inv>(elementos != null) &&
        ///      forAll(String s in elementos.Keys | elementos[s] != null)</inv>
        protected IDictionary<String, SistemaArchivo> elementos =
            new SortedDictionary<String, SistemaArchivo>();

        /// <summary>
        ///     Propiedad que permite asignar un sistema de archivos al 
        ///     control
        /// </summary>
        /// <pre>set: (value != null)</pre>
        public SistemaArchivo SparrowFileSystem
        {
            set
            {
                // Creamos el mapa de elementos con el nombre del 
                // elemento como clave. Esto hace que los elementos
                // con enlaces sólo aparezcan una vez, pero por 
                // contra impide que pueda haber archivos con el 
                // mismo nombre en diferentes directorios
                createDictorionary(value);
                // Una vez creado el diccionario, creamos las filas
                // del control gráfico, que es una rejilla de datos 
                // con una única columna
                createCells();
            }
        } // SistemaArchivo

        #endregion

        #region Constructores

        /// <summary>
        ///     Crear una nueva instancia del editor de nombres.
        /// </summary>
        /// <param name="runner">
        ///     Clase encargada de ejecutar y controlar el ciclo de
        ///     vida del formulario.
        /// </param>
        public FileNameEditor(MultiWindowRunner runner)
        {
            InitializeComponent();
            this.runner = runner;
        } // FileNameEditor

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
            this.runner.formClosed(this);
        } // onClose

        /// <summary>
        ///     Método que se invoca cuando termina de ejecutarse la 
        ///     edición de una celda del grid.
        /// </summary>
        /// <param name="sender">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.
        /// </param>
        /// <param name="e">
        ///     Parámetro que incluye información sobre el evento.
        /// </param>
        /// <pre>(e != Null) && 
        ///      (0 lt e.RowIndex this.gv_ElementsView.Rows.Count) &&
        ///      (elementos.ContainsKey(changedElement))</pre>
        private void onCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Averiguamos el nombre existente actualmente en la fila 
            // editada, que corresponderá al nuevo nombre del elemento       
            String newName = extractNameFromRow(e.RowIndex);

            // Accedemos al objeto cuyo nombre ha cambiado, teniendo
            // en cuenta que el nombre antiguo del elemento está 
            // almacenado en changedElementName. A continuación, 
            // cambiamos el nombre del elemento al nuevo elemento.
            this.elementos[changedElementName].Name = newName;

            // Creamos una nueva entrada en el diccionario de nombres
            // para el nuevo nombre y su correspondiente elemento.
            elementos[newName] = elementos[changedElementName];
            // Eliminamos del diccionario la entrada correspondiente 
            // al nombre viejo
            elementos.Remove(changedElementName);

            // Ordenamos la rejilla por la primera y única columna 
            // que posee
            this.gv_ElementsView.Sort(
                this.gv_ElementsView.Columns[0],
                ListSortDirection.Ascending);

        } // onCellEndEdit

        /// <summary>
        ///     Método que se invoca cuando comienza la edición de un nodo
        /// </summary>
        /// <param name="sender">
        ///     Este parámetro se incluye por conformidad con el
        ///     perfil de la operación a implementar, de acuerdo con las
        ///     especificaciones de la plataforma. No se utilizada para
        ///     nada en este caso concreto.
        /// </param>
        /// <param name="e">
        ///     Parámetro que incluye información sobre el evento.
        /// </param>
        /// <pre>(e != Null) && 
        ///      (0 lt e.RowIndex this.gv_ElementsView.Rows.Count)
        private void onCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.changedElementName = extractNameFromRow(e.RowIndex);
        } // onCellBeginEdit

        #endregion

        #region Métodos privados

        /// <summary>
        ///    Extrae el nombre asociado una determinada fila del control. 
        /// </summary>
        /// <param name="row">
        ///     La fila de la cual se debe extraer el nombre.
        /// </param>
        /// <returns>
        ///     El nombre asociado a la fila pasada como parámetro.
        /// </returns>
        /// <pre>(0 lt e.RowIndex this.gv_ElementsView.Rows.Count)</pre>
        private string extractNameFromRow(int row)
        {
            return this.gv_ElementsView.Rows[row].Cells[0].Value.ToString();
        } // extractNameFromRow

        /// <summary>
        ///   Introduce los nombres del sistema de archivos pasado como 
        ///   parámetro dentro del diccionario de nombres. 
        /// </summary>
        /// <param name="sa">
        ///   El sistema de archivos que se debe introducir en el 
        ///   diccionario de nombres de la clase.
        /// </param>
        private void createDictorionary(SistemaArchivo sa)
        {
            // Si el elemento no está en el diccionario lo
            // añadimos
            if (!elementos.ContainsKey(sa.Name))
            {
                this.elementos[sa.Name] = sa;
            }

            // Y a continuación procesamos de la misma forma 
            // todos sus hijos.
            foreach (SistemaArchivo s in sa.Archivos)
            {
                createDictorionary(s);
            } // foreach

        } // createDictionary.

        /// <summary>
        ///     Por cada entrada en el diccionario de nombres, se crea
        ///     una fila en la rejilla de datos con el correspondiente 
        ///     nombre.
        /// </summary>
        private void createCells()
        {
            // Para cada entrada en el diccionario
            foreach (String s in elementos.Keys)
            {
                // Creamos una celda de texto
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                // Le asignamos el nombre que corresponda
                cell.Value = s;
                // Creamos una fila para la matriz de datos
                DataGridViewRow row = new DataGridViewRow();
                // Añadimos la celda a la fila
                row.Cells.Add(cell);
                // Añadimos la fila a la matriz
                this.gv_ElementsView.Rows.Add(row);
            } // foreach
        } // createCells

        #endregion
    } // class

}
