using System;
using System.Collections.Generic;
using Centralita_IV;
namespace EntidadesDAO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Local local = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial provincial = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            List<Local> listaLocales = LocalDAO.Leer();
            List<Provincial> listaProvincial = ProvincialDAO.Leer();
            foreach (Local item in listaLocales)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("__________SEPARADOR__________\n");
            foreach (Provincial item in listaProvincial)
            {
                Console.WriteLine(item.ToString());
            }
            //LocalDAO.Guardar(local);
            //ProvincialDAO.Guardar(provincial);
        }
    }
}
