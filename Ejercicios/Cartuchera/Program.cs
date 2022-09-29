using System;
using System.Collections.Generic;

namespace Cartuchera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsoleColor colorOriginal = Console.ForegroundColor;

            //Lapiz miLapiz = new Lapiz(10);
            //Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            //EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            //Console.ForegroundColor = eLapiz.color;
            //Console.WriteLine(eLapiz.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miLapiz);

            //EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            //Console.ForegroundColor = eBoligrafo.color;
            //Console.WriteLine(eBoligrafo.texto);
            //Console.ForegroundColor = colorOriginal;
            //Console.WriteLine(miBoligrafo);

            Console.WriteLine("_____________________Parte 2_____________________");
            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();
            CartucheraSimple cartucheraSimple = new CartucheraSimple();

            List<Lapiz> listaLapiz = new List<Lapiz>();
            List<Boligrafo> listaBoligrafo = new List<Boligrafo>();

            List<IAcciones> listaAcciones = new List<IAcciones>();

            Lapiz lapiz1 = new Lapiz(5);
            Boligrafo boligrafo1 = new Boligrafo(5, ConsoleColor.Red);
            listaAcciones.Add(lapiz1);
            listaAcciones.Add(boligrafo1);

            Boligrafo boligrafo2 = new Boligrafo(5, ConsoleColor.Red);
            Lapiz lapiz2 = new Lapiz(5);
            listaLapiz.Add(lapiz2);
            listaBoligrafo.Add(boligrafo2);


            bool auxiliar;

            do
            {
                auxiliar = cartucheraMultiuso.RecorrerElementos(listaAcciones);
                Console.WriteLine(auxiliar);
            } while (auxiliar);
            

            Console.WriteLine();
            Console.WriteLine("SEPARADOR");
            Console.WriteLine();

            do
            {
                auxiliar = cartucheraSimple.RecorrerElementos(listaBoligrafo, listaLapiz);
                Console.WriteLine(auxiliar);

            } while (auxiliar);

        }
    }
}
