﻿using System;

namespace Competencia_Automotores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            AutoF1 a1 = new AutoF1(1, "escu1");
            AutoF1 a2 = new AutoF1(4, "escu2");
            AutoF1 a3 = new AutoF1(5, "escu3");
            AutoF1 a4 = new AutoF1(1, "escu1");
            AutoF1 a5 = new AutoF1(2, "escu4");
            AutoF1 a6 = new AutoF1(6, "escu5");
            AutoF1 a7 = new AutoF1(7, "escu8");
            Competencia competencia = new Competencia(5, 5);



            if (competencia + a1)
            {
                Console.WriteLine(a1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }
            if (competencia + a2)
            {
                Console.WriteLine(a2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }
            if (competencia + a3)
            {
                Console.WriteLine(a3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }
            if (competencia + a4)
            {
                Console.WriteLine(a4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }
            if (competencia + a5)
            {
                Console.WriteLine(a5.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }
            if(competencia + a6)
            {
                Console.WriteLine(a6.MostrarDatos());
            }
            else
            {
                   Console.WriteLine("NO SE AGREGO\n");
            }
            if (competencia + a7)
            {
                Console.WriteLine(a6.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO\n");
            }


        }
    }
}
