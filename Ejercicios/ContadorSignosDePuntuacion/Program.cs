using System;

namespace ContadorSignosDePuntuacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un texto: ");
            string textoAContar = Console.ReadLine();
            int cantidadDeSignosDePuntiacion = textoAContar.ContarSignosPuntuacion();
            Console.WriteLine($"El texto tiene: {cantidadDeSignosDePuntiacion} signos de puntuacion.");
        }
    }
}
