using DependencyInjection.Configurations;
using Ninject;
using Ninject.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos un inyector usando una cofiguración determinada
            IKernel injector = new StandardKernel(new WifiPlainFile());

            // A continuación creamos objetos utilizando dicho inyector
            // Las dependencias se calculan y construyen automáticamente
            // Obsverad que no hay referencias a clases concretas, sólo abstractas
            DataLinkLayer capaEnlace = injector.Get<DataLinkLayer>();

            // Si los constructores requieren parámetros, se los podemos pasar mediante pares clave-valor
            // donde clave es el nombre del constructor y argument es el nombre del argumento
            Node pcDespacho = injector.Get<Node>(new ConstructorArgument("macAdress", "PcDespacho"));
            Node portatil = injector.Get<Node>(new ConstructorArgument("macAdress", "Portatil"));
            Router routerTrabajo = injector.Get<Router>(new ConstructorArgument("macAdress", "Router Trabajo"));

            Console.Out.WriteLine("Pulse INTRO para continuar");
            Console.In.ReadLine();


        } //Main
    } // class Program 
} // namespace
