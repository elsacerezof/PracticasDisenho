using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            PasiegoLebaniego pasiegoLebaniego = new PasiegoLebaniego();
            mensaje("COMIENZA LA DEMOSTRACIÓN DE CAPACIDADES DEL NUEVO SUPERHUMANO <<PASIEGOLEBANIEGO>>");

            mensaje("");
            mensaje("Fase 1: elaboración de cocidos");
            mensaje("");

            mensaje("El pasiegolebaniego viaja a Santo Toribio de Liébana");
            pasiegoLebaniego.setContexto(TipoContexto.LIEBANA);
            mensaje("¿Qué está haciendo ahora, señor pasiegolebaniego?");
            mensaje(pasiegoLebaniego.HacerCocido()); //Deberia hacer cocido lebaniego

            Console.WriteLine("");

            Console.WriteLine("Ahora, el pasiegolebaniego viaja a Vega de Pas");
            pasiegoLebaniego.setContexto(TipoContexto.PAS);
            Console.WriteLine("¿Qué está haciendo ahora, señor pasiegolebaniego?");
            Console.WriteLine(pasiegoLebaniego.HacerCocido()); //Deberia hacer cocido pasiego

            Console.WriteLine("");
            Console.WriteLine("Fase 2: elaboración de sobaos, quesada y orujo");
            Console.WriteLine("");

            Console.WriteLine("¿Qué está haciendo ahora, señor pasiegolebaniego?");
            Console.WriteLine(pasiegoLebaniego.HacerSobaos());
            Console.WriteLine("¿Y ahora?");
            Console.WriteLine(pasiegoLebaniego.HacerQuesada());
            Console.WriteLine("¿Y ahora?");
            Console.WriteLine(pasiegoLebaniego.HacerOrujo());
            Console.WriteLine("¿Y ahora?");
            Console.WriteLine("Ahora toca engullir lo producido, que cocinar cansa, mozo");



            Console.In.ReadLine();
        }
        static void mensaje(String str)
        {
            Console.WriteLine(str);
        }
    }
}
