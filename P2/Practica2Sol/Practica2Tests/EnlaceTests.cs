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
    public class EnlaceTests
    {
        [TestMethod()]
        public void EnlaceTest()
        {
            Archivo a = new Archivo("pruebaa", 100.0);
            Directorio d = new Directorio("pruebad");
            Comprimido c = new Comprimido("pruebac");

            Enlace e1 = new Enlace(a);
            Enlace e2 = new Enlace(d);
            Enlace e3 = new Enlace(c);

            Assert.IsTrue(e1.Nombre.Equals("pruebaa"));
            Assert.IsTrue(e2.Nombre.Equals("pruebad"));
            Assert.IsTrue(e3.Nombre.Equals("pruebac"));

            Enlace e4 = new Enlace(a);

            try
            {
                Enlace e5 = new Enlace(e4);
                Assert.Fail();
            }
            catch (Exception e) { };

            try
            {
                e1.Nombre = "otro";
                Assert.Fail();
            }
            catch (Exception e) { };


            try
            {
                e2.Nombre = "otro";
                Assert.Fail();
            }
            catch (Exception e) { };


            try
            {
                e3.Nombre = "otro";
                Assert.Fail();
            }
            catch (Exception e) { };


        }

        [TestMethod()]
        public void calculaTamanhoTotalTest()
        {
            Directorio d = new Directorio("prueba");
            Archivo a = new Archivo("pruebaa", 100.0);
            d.Elementos.Add(a);
            Enlace e1 = new Enlace(d);

            Assert.IsTrue(e1.calculaTamanhoTotal() == 1.0);
        }

        [TestMethod()]
        public void numArchivosContTest()
        {
            Directorio d = new Directorio("prueba");
            Archivo a = new Archivo("pruebaa", 100.0);
            d.Elementos.Add(a);
            Enlace e1 = new Enlace(d);

            Assert.IsTrue(e1.numArchivosCont() == 0);
        }
    }
}