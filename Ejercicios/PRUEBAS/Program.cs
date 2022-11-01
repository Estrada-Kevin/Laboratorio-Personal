using System;

namespace PRUEBAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> multiplicarPorCinco = num => num * 5;


            int resultado = multiplicarPorCinco(7);
            Console.WriteLine(resultado);
        }
    }
}
