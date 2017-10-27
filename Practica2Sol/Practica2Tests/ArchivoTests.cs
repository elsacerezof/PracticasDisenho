using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Tests
{
    [TestClass()]
    public class ArchivoTests
    {
        [TestMethod()]
        public void ArchivoTest()
        {
            Archivo a = new Archivo("prueba", 20.0);
            String nombre = a.Nombre;
            double tamanho = a.Tamanho;
            Assert.IsTrue(tamanho == 20.0);
            Assert.IsTrue(nombre.Equals("prueba"));

            try {
                a.Nombre = null;
                Assert.Fail();
            } catch (Exception e) {};

            try {
                a.Tamanho = -2.0;
                Assert.Fail();
            }
            catch (Exception e) {};

            try
            {
                Archivo a1 = new Archivo(null, -3.0);
                Assert.Fail();
            }
            catch (Exception e) {};
          
        }

        [TestMethod()]
        public void calculaTamanhoTotalTest()
        {
            Archivo a = new Archivo("prueba", 20.0);
            Assert.IsTrue(a.calculaTamanhoTotal() == 20.0);

        }

        [TestMethod()]
        public void numArchivosContTest()
        {
            Archivo a = new Archivo("prueba", 20.0);
            Assert.IsTrue(a.numArchivosCont() == 0);
        }
    }
}