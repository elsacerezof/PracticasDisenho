using System.Collections.Generic;
using System.Windows.Forms;

namespace Pr_06_Observer
{
    /// <summary>
    ///     Clase que sirve para poder ejecutar diversos formularios de manera concurrente, 
    ///     controlando que la aplicación se cierre cuando se cierren todos los formularios.
    /// </summary>
    public class MultiWindowRunner
    {
        #region Atributos y Propiedades

        /// <summary>
        ///     Colección que almacena el conjunto de formularios que debe ser gestionado
        /// </summary>
        /// <inv>(forms != null) && (forms.All(f: Form | f != null))</inv>
        protected ISet<Form> forms = new HashSet<Form>();

        #endregion

        #region Constructores

        // Se utiliza el constructor vacío por defecto

        #endregion

        #region Métodos Públicos

        /// <summary>
        ///     Añade un formulario a la colección de formularios que deben ser controlados 
        ///     por esta clase. 
        /// </summary>
        /// <param name="f">
        ///     Un formulario Windows que se añadirá a la colección de formularios a ser gestionado
        /// </param>
        /// <pre>(f != null)</pre>
        /// <post>(forms.Contains(f))</post>
        public void registerForm(Form f)
        {
            forms.Add(f);
        } // registerForm

        /// <summary>
        ///     Notifica a la clase que un determinado formulario ha sido cerrado. La clase chequea si quedan 
        ///     formularios abiertos. Si no fuese así, es decir, todos los formularios de la aplicación se han 
        ///     cerrado ya, la clase cierra la aplicación.    
        /// </summary>
        /// <param name="f">El formulario que ha sido cerrado</param>
        /// <pre>true</pre>
        /// <post>((not forms.Contains(f)) && (forms.isEmpty() => Application.IsClosed()))</post>
        public void formClosed(Form f)
        {
            forms.Remove(f);
            if (forms.Count == 0) {
                Application.Exit();
            } // if
        } // formClosed

        /// <summary>
        ///     Inicia la aplicación, convirtiendo todos los formularios gestionados en visibles. 
        /// </summary>
        /// <pre>true</pre>
        /// <port>forms.All(f: Form | f.Visible) && (Application.IsRunning())</post>
        public void run()
        {
            foreach(Form f in forms)
            {
                f.Show();
            } // foreach
            Application.Run();
        } // run

        #endregion

    } // class MultiWindowRunner
} // namespace
