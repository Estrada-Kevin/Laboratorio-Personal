using System;

namespace Torneo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Capos");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Escuadra");

            EquipoFutbol equipoFutbol1 = new EquipoFutbol("Boca", new DateTime(1997,2,28));
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("River", new DateTime(1997,3,21));
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("San Lorenzo", new DateTime(1997, 11, 16));

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Laro", new DateTime(1900, 5, 12));
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("Tito", new DateTime(1956, 2, 21));
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Male", new DateTime(1939, 7, 18));

            _ = torneoFutbol + equipoFutbol1;
            _ = torneoFutbol + equipoFutbol2;
            _ = torneoFutbol + equipoFutbol3;
            

            _ = torneoBasquet + equipoBasquet1;
            _ = torneoBasquet + equipoBasquet2;
            _ = torneoBasquet + equipoBasquet3;

            Console.WriteLine(torneoFutbol.Mostrar() + torneoFutbol.JugarPartido + torneoFutbol.JugarPartido + torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.Mostrar() + torneoBasquet.JugarPartido + torneoBasquet.JugarPartido + torneoBasquet.JugarPartido);

        }
    }
}
