using Checklists.Composite;
using Checklists.Visitante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checklists
{
    class Program
    {
        static void Main(string[] args)
        {
            Checklist disenho = new Checklist("Aprobar diseño");
            Checklist primerParcial = new Checklist("Primer Parcial");
            Checklist segundoParcial = new Checklist("Segundo Parcial");

            ItemToBeChecked pr00 = new ItemToBeChecked("Práctica 1.01");
            ItemToBeChecked pr01 = new ItemToBeChecked("Práctica 1.02");
            ItemToBeChecked pr02 = new ItemToBeChecked("Práctica 1.03");
            ItemToBeChecked pr03 = new ItemToBeChecked("Práctica 1.04");
            ItemToBeChecked pr04 = new ItemToBeChecked("Práctica 1.05");
            ItemToBeChecked pr05 = new ItemToBeChecked("Práctica 1.06");
            ItemToBeChecked pr06 = new ItemToBeChecked("Práctica 1.07");

            ItemToBeChecked pool = new ItemToBeChecked("Practica 2.01");
            ItemToBeChecked dominio = new ItemToBeChecked("Practica 2.02");
            ItemToBeChecked persistencia = new ItemToBeChecked("Practica 2.03");
            ItemToBeChecked lazyFetch = new ItemToBeChecked("Practica 2.04");
            ItemToBeChecked servicio = new ItemToBeChecked("Practica 2.05");

            primerParcial.Items.Add(pr00);
            primerParcial.Items.Add(pr01);
            primerParcial.Items.Add(pr02);
            primerParcial.Items.Add(pr03);
            primerParcial.Items.Add(pr04);
            primerParcial.Items.Add(pr05);
            primerParcial.Items.Add(pr06);

            segundoParcial.Items.Add(pool);
            segundoParcial.Items.Add(dominio);
            segundoParcial.Items.Add(persistencia);
            segundoParcial.Items.Add(lazyFetch);
            segundoParcial.Items.Add(servicio);

            disenho.Items.Add(primerParcial);
            disenho.Items.Add(segundoParcial);

            Console.Out.WriteLine("--------------------------------------");
            Console.Out.WriteLine("           Antes de renombrar         ");
            Console.Out.WriteLine("--------------------------------------");

            String salidaSinPrefijo = disenho.acceptPrinter(new TabularChecklistPrinter());
            Console.Out.WriteLine(salidaSinPrefijo);

            foreach (ChecklistElement ce in disenho)
            {
                ce.Texto = "[Done]" + ce.Texto;
            }

            Console.Out.WriteLine("--------------------------------------");
            Console.Out.WriteLine("          Después de renombrar        ");
            Console.Out.WriteLine("--------------------------------------");

            String salidaConPrefijo = disenho.acceptPrinter(new TabularChecklistPrinter());
            Console.Out.WriteLine(salidaConPrefijo);

            Console.Out.WriteLine("Pulse una tecla para continuar");
            Console.In.ReadLine();

        } // main
    } // Program
} 
