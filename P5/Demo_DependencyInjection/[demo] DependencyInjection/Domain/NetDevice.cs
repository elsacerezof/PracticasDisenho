using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    ///     Representa cualquier dispositivo de red que pueda tener asociada una dirección física o de enlace de datos.
    /// </summary>

    public abstract class NetDevice
    {

        #region Atributos y Propiedades

        protected String macAdress;

        /// <summary>
        ///     Dirección física del router. Es utilizada por la capa de enlace de datos.
        ///     Inv: MacAdress != null
        /// </summary>
        public String MacAdress
        {
            set;
            get;
        } // MacAdress

        #endregion
               
        #region Constructores

        // Pre: macAdress != null
        public NetDevice(String macAdress)
        {
            this.macAdress = macAdress;
        } // NetDevice

        #endregion

        #region Métodos de Utilidad

        public override bool Equals(object obj)
        {
            bool result = false;

            if ((obj != null) && (obj is Router))
            {
                result = this.MacAdress.Equals(((Router)obj).MacAdress);
            } // if

            return result;
        } // Equals

        // Pre: MacAdress != null
        public override int GetHashCode()
        {
            return this.MacAdress.GetHashCode();
        } // GetHashCode

        #endregion

    } // class NetDevice

} // namespace
