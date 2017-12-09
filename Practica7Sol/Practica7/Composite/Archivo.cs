using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica7
{
   public class Archivo : Enlazable
    {

        #region Atributos

        private String nombre;
        private double tamanho;

        #endregion   

        #region Propiedades

        public override string Nombre
        {
            get { return nombre; }
            set
            {
                if (value == null)
                {
                    throw new Exception();
                }
                this.nombre = value;
            }
        }

        
        public override double Tamanho
        {
            get { return tamanho; }
            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                this.tamanho = value;
            }
        }

       

        #endregion

        #region Metodos

        public Archivo(String nom, double tam)
        {
            if (nom == null || tam < 0)
            {
                throw new Exception();
            }

            Nombre = nom;
            Tamanho = tam;
        }

        public override double calculaTamanhoTotal()
        {
            return tamanho;
        }

        public override int numArchivosCont()
        {
            return 0;
        }

        public override IEnumerator<IElto_Sistema_Archivos> GetEnumerator()
        {
            return new ItHojaArchivo(this);

        }





        #endregion
    }
}
