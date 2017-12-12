
using Practica5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_06_Observer
{
    static class Program
    {
        static IElto_Sistema_Archivos crearSistemaEjemplo()
        {
            Directorio dRaiz = new Directorio("Raiz");

            Directorio dVacio = new Directorio("Directorio Vacio");

            dRaiz.Elementos.Add(dVacio);
            
            Directorio dUnico = new Directorio("Directorio Con Archivo Unico");
            Archivo f01 = new Archivo("foto001.jpg", 200);
            dUnico.Elementos.Add(f01);
            dRaiz.Elementos.Add(dUnico);

            Directorio d01 = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo f02 = new Archivo("foto003.jpg", 200);
            Enlace e01 = new Enlace(f01);

            Comprimido ccSimple = new Comprimido("ccSimple.zip");
            ccSimple.Elementos.Add(d01);
            ccSimple.Elementos.Add(f02);
            ccSimple.Elementos.Add(e01);
            ccSimple.Elementos.Add(d01);

            Directorio dComprimido = new Directorio("Directorio Con Archivo Comprimido Simple");

            Archivo f03 = new Archivo("foto002.jpg", 200);
            Enlace e02 = new Enlace(f01);

            dComprimido.Elementos.Add(f03);
            dComprimido.Elementos.Add(e02);
            dComprimido.Elementos.Add(ccSimple);

            dRaiz.Elementos.Add(dComprimido);

            Archivo f04 = new Archivo("foto007.jpg", 200);
            Comprimido ccAnidada = new Comprimido("ccAnidada.zip");
            ccAnidada.Elementos.Add(f04);
            Archivo f05 = new Archivo("foto008.jpg", 200);

            Comprimido ccCompuesto = new Comprimido("ccComplejo.zip");
            ccCompuesto.Elementos.Add(ccAnidada);
            ccCompuesto.Elementos.Add(f05);

            Archivo f06 = new Archivo("foto005", 200);
            Archivo f07 = new Archivo("foto006", 200);

            Directorio dComprimidoCompuesto = new Directorio("Directorio con Archivo Comprimido Complejo");
            dComprimidoCompuesto.Elementos.Add(f06);
            dComprimidoCompuesto.Elementos.Add(f07);
            dComprimidoCompuesto.Elementos.Add(ccCompuesto);

            Archivo f08 = new Archivo("foto004.jpg", 200);
            Enlace e03 = new Enlace(ccSimple);
            Enlace e04 = new Enlace(dVacio);

            Directorio dMultinivel = new Directorio("Directorio con Directorio Anidado");

            dMultinivel.Elementos.Add(f08);
            dMultinivel.Elementos.Add(e03);
            dMultinivel.Elementos.Add(e04);
            dMultinivel.Elementos.Add(dComprimidoCompuesto);

            dRaiz.Elementos.Add(dMultinivel);

            return dRaiz;
        } // crearSistemaEjemplo

        /// <summary>
        ///     Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicializamos los aspectos básicos del sistema 
            // de ventanas
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos un nuevo gestor de multiformularios
            MultiWindowRunner runner = new MultiWindowRunner();

            // Creamos un sistema de ficheros ejemplo
            IElto_Sistema_Archivos fs = crearSistemaEjemplo();

            // Creamos un nuevo visor de sistema de archivos Sparrow
            FileExplorerView fev = new FileExplorerView(runner);
            fev.SparrowFileSystem = fs;

            // Creamos un nuevo editor de nombres para los 
            // elementos del sistema de archivos Sparrow anterior
            FileNameEditor fne = new FileNameEditor(runner);
            fne.SparrowFileSystem = fs;

            // Registramos ambos formularios en el gestor de formularios
            runner.registerForm(fne);
            runner.registerForm(fev);

            // Ejecutamos los formularios
            runner.run();
        } // main
    } // Program
}
