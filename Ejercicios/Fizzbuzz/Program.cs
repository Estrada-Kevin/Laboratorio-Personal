using System;

namespace Fizzbuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string endGame = string.Empty;
            do
            {
                Console.Write("escriba un numero: ");
                int.TryParse(Console.ReadLine(), out int numero);
                endGame = numero.FizzBuzzGame();
                Console.WriteLine(endGame);
            } while (endGame != "FizzBuzz");
            Console.WriteLine("Ganaste!");
        }
    }
}
