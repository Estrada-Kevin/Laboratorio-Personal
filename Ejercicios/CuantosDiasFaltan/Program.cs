using System;

namespace CuantosDiasFaltan
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Estaciones.Estanciones Verano = Estaciones.Estanciones.Verano;
            Estaciones.Estanciones Primavera = Estaciones.Estanciones.Primavera;
            Estaciones.Estanciones Otonio = Estaciones.Estanciones.Otonio;
            Estaciones.Estanciones Invierno = Estaciones.Estanciones.Invierno;

            string stringVerano = Verano.ObtenerPlacaCronicaTv();
            string stringPrimavera = Primavera.ObtenerPlacaCronicaTv();
            string stringOtonio = Otonio.ObtenerPlacaCronicaTv();
            string stringInvierno = Invierno.ObtenerPlacaCronicaTv();

            Console.WriteLine(stringVerano);
            Console.WriteLine(stringPrimavera);
            Console.WriteLine(stringOtonio);
            Console.WriteLine(stringInvierno);



            //Console.WriteLine(Estaciones.ObtenerPlacaCronicaTv(Estaciones.Estanciones.Verano));
            //Console.WriteLine(Estaciones.ObtenerPlacaCronicaTv(Estaciones.Estanciones.Otonio));
            //Console.WriteLine(Estaciones.ObtenerPlacaCronicaTv(Estaciones.Estanciones.Invierno));
            //Console.WriteLine(Estaciones.ObtenerPlacaCronicaTv(Estaciones.Estanciones.Primavera));

        }

    }
}
