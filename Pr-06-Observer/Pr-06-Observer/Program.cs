using Pr04_Folders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_06_Observer
{
    static class Program
    {
        static SistemaArchivo crearSistemaEjemplo()
        {
            Directorio dRaiz = new Directorio("Raiz");

            Directorio dVacio = new Directorio("Directorio Vacio");

            dRaiz.anhadirElemento(dVacio);

            Directorio dUnico = new Directorio("Directorio Con Archivo Unico");
            Fichero f01 = new Fichero("foto001.jpg", 200);
            dUnico.anhadirElemento(f01);

            dRaiz.anhadirElemento(dUnico);

            Directorio d01 = new Directorio("Directorio Vacio En Archivo Comprimido");
            Fichero f02 = new Fichero("foto003.jpg", 200);
            EnlaceDirecto e01 = new EnlaceDirecto(f01);

            CarpetaComprimida ccSimple = new CarpetaComprimida("ccSimple.zip", d01);
            ccSimple.anhadirElemento(f02);
            ccSimple.anhadirElemento(e01);
            ccSimple.anhadirElemento(d01);

            Directorio dComprimido = new Directorio("Directorio Con Archivo Comprimido Simple");

            Fichero f03 = new Fichero("foto002.jpg", 200);
            EnlaceDirecto e02 = new EnlaceDirecto(f01);

            dComprimido.anhadirElemento(f03);
            dComprimido.anhadirElemento(e02);
            dComprimido.anhadirElemento(ccSimple);

            dRaiz.anhadirElemento(dComprimido);

            Fichero f04 = new Fichero("foto007.jpg", 200);
            CarpetaComprimida ccAnidada = new CarpetaComprimida("ccAnidada.zip", f04);
            Fichero f05 = new Fichero("foto008.jpg", 200);

            CarpetaComprimida ccCompuesto = new CarpetaComprimida("ccComplejo.zip", ccAnidada);
            ccCompuesto.anhadirElemento(f05);

            Fichero f06 = new Fichero("foto005", 200);
            Fichero f07 = new Fichero("foto006", 200);

            Directorio dComprimidoCompuesto = new Directorio("Directorio con Archivo Comprimido Complejo");
            dComprimidoCompuesto.anhadirElemento(f06);
            dComprimidoCompuesto.anhadirElemento(f07);
            dComprimidoCompuesto.anhadirElemento(ccCompuesto);

            Fichero f08 = new Fichero("foto004.jpg", 200);
            EnlaceDirecto e03 = new EnlaceDirecto(ccSimple);
            EnlaceDirecto e04 = new EnlaceDirecto(dVacio);

            Directorio dMultinivel = new Directorio("Directorio con Directorio Anidado");

            dMultinivel.anhadirElemento(f08);
            dMultinivel.anhadirElemento(e03);
            dMultinivel.anhadirElemento(e04);
            dMultinivel.anhadirElemento(dComprimidoCompuesto);

            dRaiz.anhadirElemento(dMultinivel);

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
            SistemaArchivo fs = crearSistemaEjemplo();

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
