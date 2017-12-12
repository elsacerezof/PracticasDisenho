using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///     Clase abstracta que especifica las operaciones que deberán implementar los 
    ///     loggers concretos
    /// </summary>
    public interface Logger
    {
        /// <summary>
        ///     Añade una cadena de caracteres al log actual
        /// </summary>
        /// <param name="s">
        ///     La cadena de caracteres que va a ser añadida.
        /// </param>
        void Write(String s);

        /// <summary>
        ///     Añade una cadena de caracteres al log actual y finaliza la línea.
        /// </summary>
        /// <param name="s">
        ///     La cadena de caracteres que va a ser añadida.
        /// </param>
        void WriteLine(String s);
    } // Logger

} // DepedencyInjection
