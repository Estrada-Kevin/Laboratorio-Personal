using System;

namespace ContadorDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            long.TryParse(Console.ReadLine(), out long numero);
            Console.WriteLine($"Número de:         {numero.ContarCantidadDeDigitos()} dígitos");
        }
    }
}
