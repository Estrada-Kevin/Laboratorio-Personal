using System;

namespace Estadistica_deportiva_mejorada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);

            DirectorTecnico dt1 = new DirectorTecnico(new DateTime(1997,02,28), 40240898, "juan");

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatosJugador());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatosJugador());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatosJugador());
            else
                Console.WriteLine("NO SE AGREGO \n" + j3.MostrarDatosJugador());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());

            else
                Console.WriteLine("NO SE AGREGO \n" + j4.MostrarDatosJugador());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(dt1.MostrarDatosDirector());
        }
    }
}
