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
    public class ComprimidoTests
    {
        [TestMethod()]
        public void ComprimidoTest()
        {
            Comprimido c = new Comprimido("prueba");
            String nombre = c.Nombre;
            Assert.IsTrue(nombre.Equals("prueba"));

            try
            {
                c.Nombre = null;
                Assert.Fail();
            }
            catch (Exception e) { };

            try
            {
                Comprimido c1 = new Comprimido(null);
                Assert.Fail();
            }
            catch (Exception e) { };
        }

        [TestMethod()]
        public void calculaTamanhoTotalTest()
        {
            Comprimido d = new Comprimido("prueba");
            Assert.IsTrue(d.calculaTamanhoTotal() == 0.0);

            Archivo e1 = new Archivo("Archivo1", 200.0);
            Archivo e2 = new Archivo("Archivo2", 100.0);
            d.EltosComp.Add(e1);
            d.EltosComp.Add(e2);
            Assert.IsTrue(d.calculaTamanhoTotal() == 300.0 * 0.3);
        }

                
       [TestMethod()]
        public void numArchivosContTest()
        {
            Comprimido d = new Comprimido("prueba");
            Assert.IsTrue(d.numArchivosCont() == 0);
            Archivo e1 = new Archivo("Archivo1", 200.0);
            Archivo e2 = new Archivo("Archivo2", 100.0);
            d.EltosComp.Add(e1);
            d.EltosComp.Add(e2);
            Assert.IsTrue(d.numArchivosCont() == 2);
        }
    }
}