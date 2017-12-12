
+++++++++++++++++++++++++++++++++++++++++++++++++++++using Ninject;
using System;

namespace DependencyInjection
{
    /// <summary>
    ///     Clase que representa un nodo, como un tablet o un computador, conectado a una red.
    /// </summary>
    public class Node : NetDevice
    {
        #region Dependencias a Invertir

        /// <summary>
        ///     Capa de enlace de datos encargada de recibir los paequetes de datos a través de la red.
        /// </summary>
        protected DataLinkLayer dataLinkDaemon;

        #endregion

        #region Constructores

        /// <summary>
        ///     Crea un nuevo objeto de tipo Node
        /// </summary>
        /// <param name="linkDaemon">
        ///     Instancia de la capa de enlace de datos que se utilizará para el envío y recepción de datos. 
        /// </param>
        /// <param>
        ///     Dirección física del nodo dentro de la red. 
        /// </param>
        [Inject]
        public Node(DataLinkLayer linkDaemon, String macAdress) : base(macAdress)
        {
            this.dataLinkDaemon = linkDaemon;
        } // Node

        #endregion

    } // Node
} // namespace