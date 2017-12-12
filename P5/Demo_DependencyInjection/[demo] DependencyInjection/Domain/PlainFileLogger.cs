using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///     Mantiene un registro de operaciones o log utilizando un fichero de texto plano
    /// </summary>
    public class PlainFileLogger : Logger
    {
        public void Write(string s)
        {
            throw new NotImplementedException();
        } // Write

        public void WriteLine(string s)
        {
            throw new NotImplementedException();
        } // WriteLine

    } // PlainLoggerFile

} // namespace
