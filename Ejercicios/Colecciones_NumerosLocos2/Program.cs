using System;
using System.Collections.Generic;

namespace Colecciones_NumerosLocos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> LNumeros = new List<int>();
            Queue<int> QNumerosPositivos= new Queue<int>();
            Stack<int> SNumerosNegativos = new Stack<int>();

            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                LNumeros.Add(r.Next(-100, 100));
            }

            Console.WriteLine("Numeros originales: ");
            foreach (int item in LNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNumeros ordenados descendientemente: ");
            LNumeros.Sort(OrdenDescendiente);
            foreach (int item in LNumeros)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nQueue positivos ordenados decrecientemente");
            foreach (int item in LNumeros)
            {
                if(item>0)
                {
                    Console.WriteLine(item);
                    QNumerosPositivos.Enqueue(item);
                }
                else if (item != 0)
                {
                    SNumerosNegativos.Push(item);
                }
            }

            Console.WriteLine("\nStack negativos ordenados crecientemente");
            foreach (int item in SNumerosNegativos)
            {
                Console.WriteLine(item);
            }

        }

        public static int OrdenDescendiente(int n1, int n2)
        {
            return n2 - n1;
        }
    }
    
}
