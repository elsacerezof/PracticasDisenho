using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Child iterator sera la lista del padre
            //curret iterator sera la lista 

            Directorio d1 = new Directorio("D1");
                Archivo a1 = new Archivo("A1", 100);
                d1.Elementos.Add(a1);
                Comprimido c1 = new Comprimido("C1");
                    Directorio d2 = new Directorio("D2");
                        Archivo a2 = new Archivo("A2", 100);
                        Archivo a3 = new Archivo("A3", 100);
                        Archivo a4 = new Archivo("A4", 100);
                        d2.Elementos.Add(a2);
                        d2.Elementos.Add(a3);
                        d2.Elementos.Add(a4);
                    c1.EltosComp.Add(d2);
                    Archivo a5 = new Archivo("A5", 100);
                    c1.EltosComp.Add(a5);
                d1.Elementos.Add(c1);
                Enlace e1 = new Enlace(a5);
                d1.Elementos.Add(e1);


            IEnumerator<IElto_Sistema_Archivos> it = d1.GetEnumerator();

            while (it.MoveNext()) {

                Console.WriteLine(it.Current.Nombre);
                
            }
            Console.ReadLine();

        }
    }
}
