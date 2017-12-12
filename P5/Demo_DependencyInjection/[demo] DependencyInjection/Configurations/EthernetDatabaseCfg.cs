using System;
using Ninject.Modules;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///     Configuracion para las siguientes opciones
    ///     - Tecnología de Red  : Ethernet
    ///     - Sistema de Logging : Database
    /// </summary>
    public class EthernetDatabaseCfg : NinjectModule
    {
        public override void Load()
        {
            Bind<Logger>().To<DatabaseLogger>();
            Bind<DataLinkLayer>().To<EthernetDataLinker>();
        }
    } // class EthernetDatabaseLoggingConfiguration

} // namespace
