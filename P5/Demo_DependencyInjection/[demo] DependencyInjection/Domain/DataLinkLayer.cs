using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///   Clase que representa una capa de enlace de datos
    /// </summary>
    public abstract class DataLinkLayer
    {

        #region Propiedades

        protected Logger logger { get; set; }

        #endregion

        /// <summary>
        ///     Envía un paquete de datos a través del nivel de enlace de datos    
        /// </summary>
        /// <param name="receiverMacAdress">
        ///     Dirección del nivel de datos del receptor
        /// </param>
        /// <param name="packet">
        ///     Paquete a enviar por el nivel de enlace de datos
        /// </param>
        public abstract void sendData(String receiverMacAdress, DataLinkPacket packet);

        /// <summary>
        ///     Recibe un paquete de datos a través del nivel de enlace de datos    
        /// </summary>
        /// <param name="senderMacAddress">
        ///     Dirección del nivel de datos del emisor
        /// </param>
        /// <param name="packet">
        ///     Paquete a enviar por el nivel de enlace de datos
        /// </param>
        public abstract void receiveData(String senderMacAdress, DataLinkPacket packet);

    } // class DataLinkLayer
} // namespace DependencyInjection
