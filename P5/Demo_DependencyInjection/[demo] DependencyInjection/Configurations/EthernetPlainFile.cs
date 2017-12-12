using System;
using Ninject.Modules;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Configurations
{

    /// <summary>
    ///     Configuracion para las siguientes opciones
    ///     - Tecnología de Red  : Ethernet
    ///     - Sistema de Logging : Database
    /// </summary>
    public class EthernetPlainFile : NinjectModule
    {
        public override void Load()
        {
            Bind<Logger>().To<PlainFileLogger>();
            Bind<DataLinkLayer>().To<EthernetDataLinker>();
        }


    } // class EthernetPlainFile

} // namespace
