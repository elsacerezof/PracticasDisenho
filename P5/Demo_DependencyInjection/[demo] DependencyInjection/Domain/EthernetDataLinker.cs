using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///     Implementación del nivel de enlace para la tecnología Ethernet
    /// </summary>
    public class EthernetDataLinker : DataLinkLayer
    {
        public override void receiveData(string senderMacAdress, DataLinkPacket packet)
        {
            throw new NotImplementedException();
        }

        public override void sendData(string receiverMacAdress, DataLinkPacket packet)
        {
            throw new NotImplementedException();
        }
    } // class EthernetDataLinker

} // namespace
