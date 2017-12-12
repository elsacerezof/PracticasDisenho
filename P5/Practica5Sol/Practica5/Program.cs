using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {


            //d Raiz
            //  d Directorio Vacio
            //  d Directorio Con Archivo Unico
            //      f foto001.jpg
            //  d Directorio Con Archivo Comprimido Simple
            //      f foto002.jpg
            //      e foto001.jpg
            //      c ccSimple.zip
            //          d Directorio Vacio En Archivo Comprimido
            //          f foto003.jpg
            //          e foto001.jpg
            //  d Directorio con Directorio Anidado
            //      f foto004.jpg
            //      e ccSimple.zip
            //      e Directorio Vacio
            //      d Directorio con Archivo Comprimido Complejo
            //          f foto005
            //          f foto006
            //          c ccComplejo.zip
            //              c ccAnidada.zip
            //                  f foto007.jpg
            //              f foto008.jpg 
            /*
            Directorio draiz = new Directorio("Raíz ñññ");

            TipoOrtografiaStr to = new CatalanaStr();
            Impresora i = new ImpresoraCompacta(to);
            Console.WriteLine(draiz.acceptImpresora(i));

            Console.ReadLine();
            */
            Directorio draiz = new Directorio("Raiz");
            Directorio duno = new Directorio("Directorio Vacio");
            Directorio ddos = new Directorio("Directorio Con Archivo Unico");
            draiz.Elementos.Add(duno);
            draiz.Elementos.Add(ddos);

            Archivo funo = new Archivo("foto001.jpg", 10.0);
            ddos.Elementos.Add(funo);

            Directorio dtres = new Directorio("ññññ áááá Con Archivo Comprimido Simple");
            draiz.Elementos.Add(dtres);
            Archivo fdos = new Archivo("foto002.jpg", 20.0);
            Enlace euno = new Enlace(funo);
            Comprimido cuno = new Comprimido("ccSimple.zip");
            dtres.Elementos.Add(fdos);
            dtres.Elementos.Add(euno);
            dtres.Elementos.Add(cuno);

            Directorio dcuatro = new Directorio("Directorio Vacio En Archivo Comprimido");
            Archivo ftres = new Archivo("foto003.jpg", 30.0);
            Enlace edos = new Enlace(funo);
            cuno.EltosComp.Add(dcuatro);
            cuno.EltosComp.Add(ftres);
            cuno.EltosComp.Add(edos);

            Directorio dcinco = new Directorio("Directorio con Directorio Anidado");
            draiz.Elementos.Add(dcinco);
            Archivo fcuatro = new Archivo("foto004.jpg", 30.0);
            Enlace etres = new Enlace(cuno);
            Enlace ecuatro = new Enlace(duno);
            Directorio dseis = new Directorio("Directorio con Archivo Comprimido Complejo");
            dcinco.Elementos.Add(fcuatro);
            dcinco.Elementos.Add(etres);
            dcinco.Elementos.Add(ecuatro);
            dcinco.Elementos.Add(dseis);

            Archivo fcinco = new Archivo("foto005.jpg", 30.0);
            Archivo fseis = new Archivo("foto006.jpg", 30.0);
            Comprimido cdos = new Comprimido("ccComplejo.zip");
            dseis.Elementos.Add(fcinco);
            dseis.Elementos.Add(fseis);
            dseis.Elementos.Add(cdos);

            Comprimido ctres = new Comprimido("ccAnidada.zip");
            Archivo fsiete = new Archivo("foto00.jpg", 30.0);
            Archivo focho = new Archivo("foto008.jpg", 30.0);
            ctres.EltosComp.Add(fsiete);
            cdos.EltosComp.Add(ctres);
            cdos.EltosComp.Add(focho);

            
            BasicaFactory.init();
            BotonMagico.print(draiz);
            EstandarFactory.init();
            BotonMagico.print(draiz);
            ExtendidaGallegaFactory.init();
            BotonMagico.print(draiz);
            ExtendidaCatalanaFactory.init();
            BotonMagico.print(draiz);

            Console.WriteLine("Sitema archivos en abierta");
            AbiertaFactory.init();
            ImpresoraFactory afac = AbiertaFactory.getInstance();
            afac.setProtoType(new YourOcreStr());
            BotonMagico.print(draiz);

            

            Console.ReadLine();
        }
    }
}
