using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///     Clase que represeta un Router dentro de una red de computadores
    /// </summary>
    public class Router : NetDevice
    {

        #region Dependencias con otros servicios que se van a invertir en el constructor

        /// <summary>
        ///     Servicio que se encarga de crear entradas con las operaciones del router
        ///     en un log de operaciones
        /// </summary>
        protected Logger logger;

        /// <summary>
        ///     Punto de acceso al nivel inferior de la red, que sería el nivel de enlace 
        ///     de datos. Se utiliza para mandar paquetes de datos a elementos conectados.
        /// </summary>
        protected DataLinkLayer downLayer;

        #endregion

        #region Atributos y propiedades que no es necesario invertir

        // Estos atributos no se invierten porque a diferencia de los otros variarán en tiempo de
        // ejecución y no tiene sentido, por tanto, invertirlas en el constructor

        /// <summary>
        ///   Lista de routers que representan puntos de acceso a otras redes con los cuales estoy conectado.
        ///   Inv: connectedNodes != null
        /// </summary>
        protected ISet<Router> network;

        /// <summary>
        ///    Lista de nodos o equipos que están conectados a este router.     
        ///    Inv: connectedNodes != null
        /// </summary>
        protected ISet<Node> connectedNodes;

        #endregion

        #region Constructor

        /// <summary>
        ///     Crea una nueva instancia de un Router
        /// </summary>
        /// <param name="dl">
        ///     Instancia de la capa de enlace de datos que utilzará el router para comunicarse con los nodos
        ///     de su red.
        /// </param>
        /// <param name="l">
        ///     Instancia de la clase encargada de realizar las operaciones de mantinimiento del registro de operaciones o log.
        /// </param>
        /// <param name="macAdress">
        ///     Dirección física o de enlaces de datos del router dentro de su red.  
        /// </param>
        /// Inv: (dl != null) && (l != null)
        [Inject]
        public Router(DataLinkLayer dl, Logger l, String macAdress) : base(macAdress)
        {
            this.logger = l;
            this.downLayer = dl;

            this.network = new HashSet<Router>();
            this.connectedNodes = new HashSet<Node>();
        } // Constructor Router

        #endregion
        
        #region Interfaz pública del método

        /// <summary>
        ///     Método encargardo de enroutar un mensaje.
        /// </summary>
        /// <param name="sender">
        ///     Emisor del mensaje.
        /// </param>
        /// <param name="receiver">
        ///     Receptor del mensaje.
        /// </param>
        /// <param name="message">
        ///     Mensaje enviado, que será un paquete a nivel de red.
        /// </param>
        public virtual void route(Node sender, Node receiver, NetPacket message)
        {
            // El método se deja vacío porque no es relevante para el propósito 
            // de la práctica
        } // route

        #endregion

    } // Router

} // namespace 
