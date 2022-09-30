using System;

namespace Centralita_IV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Centralita c = new Centralita("Fede Center");


            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);
            Local l5 = new Local(l1, 2.65f);
            Provincial l6 = new Provincial("Lugano", Franja.Franja_2, 45, "Chilavert");
            _ = c + l1;
            _ = c + l2;
            _ = c + l3;
            _ = c + l4;
            _ = c + l5;
            _ = c + l6;

            Console.WriteLine("__________________ORDENANDO__________________");
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
        }
    }
}
