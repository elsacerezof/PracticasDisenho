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
    public class DirectorioTests
    {
        [TestMethod()]
        public void DirectorioTest()
        {
            Directorio d = new Directorio("prueba");
            String nombre = d.Nombre;
            Assert.IsTrue(nombre.Equals("prueba"));

            try
            {
                d.Nombre = null;
                Assert.Fail();
            }
            catch (Exception e) { };

            
            try
            {
                Directorio d1 = new Directorio(null);
                Assert.Fail();
            }
            catch (Exception e) { };
        }

        [TestMethod()]
        public void calculaTamanhoTotalTest()
        {
            Directorio d = new Directorio("prueba");
            Assert.IsTrue(d.calculaTamanhoTotal() == 1.0);
            Archivo e1 = new Archivo("Archivo1", 200.0);
            Archivo e2 = new Archivo("Archivo2", 100.0);
            d.Elementos.Add(e1);
            d.Elementos.Add(e2);
            Assert.IsTrue(d.calculaTamanhoTotal() == 301.0);
            
        }

        [TestMethod()]
        public void numArchivosContTest()
        {
            Directorio d = new Directorio("prueba");
            Assert.IsTrue(d.numArchivosCont() == 0);
            Archivo e1 = new Archivo("Archivo1", 200.0);
            Archivo e2 = new Archivo("Archivo2", 100.0);
            d.Elementos.Add(e1);
            d.Elementos.Add(e2);
            Assert.IsTrue(d.numArchivosCont() == 2);

        }
    }
}