using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Configurations
{
    /// <summary>
    ///     Configuracion para las siguientes opciones
    ///     - Tecnología de Red  : Wifi
    ///     - Sistema de Logging : PlainFile
    /// </summary>
    public class WifiPlainFile : NinjectModule
    {
        public override void Load()
        {
            Bind<Logger>().To<PlainFileLogger>();
            Bind<DataLinkLayer>().To<WifiDataLinker>();
        }  // Load

    } // WifiPlain File
}
