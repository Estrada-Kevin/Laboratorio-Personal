using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public static class Game
    {
        public static string FizzBuzzGame(this int numero)
        {
            string auxiliar = "Intente otra vez";
            if(numero % 3 == 0)
            {
                auxiliar = "Fizz";
            }
            if(numero % 5 == 0)
            {
                auxiliar = "Buzz";
            }
            if(numero % 3 == 0 && numero % 5 == 0)
            {
                auxiliar = "FizzBuzz";
            }
            return auxiliar;
        }
    }
}
