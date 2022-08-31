using System;

namespace Colecciones_NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random r = new Random();
            Console.WriteLine("Array original: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-100,100);
                Console.WriteLine("{0} : {1}", i , array[i]);
            }

            Array.Sort(array, Program.OrdenarDescendente);
            Console.WriteLine("\nArray Positivo ordenado decrecientemente");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Console.WriteLine("{0} : {1}", i, array[i]);
                }
            }


            Array.Sort(array);
            Console.WriteLine("\nArray Negativo ordenado crecientemente: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 )
                {
                    Console.WriteLine("{0} : {1}", i, array[i]);
                }
            }

            

        }
        public static int OrdenarDescendente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
}
