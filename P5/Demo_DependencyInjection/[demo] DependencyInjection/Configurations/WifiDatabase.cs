using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Configurations
{
    /// <summary>
    ///    Configuracion para las siguientes opciones
    ///     - Tecnología de Red  : Wifi
    ///     - Sistema de Logging : Database
    /// </summary>
    public class WifiDatabase : NinjectModule
    {
        public override void Load()
        {
            Bind<Logger>().To<DatabaseLogger>();
            Bind<DataLinkLayer>().To<WifiDataLinker>();
        }
    } // class WifiDatabase

} // namespace 
