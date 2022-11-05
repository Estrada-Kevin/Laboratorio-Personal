using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuantosDiasFaltan
{
    public static class Estaciones
    {   
        public enum Estanciones
        {
            Verano,
            Primavera,
            Invierno,
            Otonio
        }

        public static string ObtenerPlacaCronicaTv(this Estanciones estacion)
        {
            DateTime Verano = new DateTime(2022, 12, 21);
            DateTime Invierno = new DateTime(2023, 6, 21);
            DateTime Primavera = new DateTime(2023, 9, 23);
            DateTime Otonio = new DateTime(2023, 3, 20);

            switch (estacion)
            {
                case Estanciones.Verano:
                    TimeSpan diasVerano = Verano - DateTime.Now;
                    double diasParaVerano = diasVerano.TotalDays;
                    return "Faltan " + diasParaVerano.ToString("#.00") + " dias para verano";
                case Estanciones.Primavera:
                    TimeSpan diasPrimavera= Primavera - DateTime.Now;
                    double diasParaPrimavera = diasPrimavera.TotalDays;
                    return "Faltan " + diasParaPrimavera.ToString("#.00") + " dias para primavera";
                case Estanciones.Invierno:
                    TimeSpan diasInvierno = Invierno - DateTime.Now;
                    double diasParaInvierno = diasInvierno.TotalDays;
                    return "Faltan " + diasParaInvierno.ToString("#.00") + " dias para invierno";
                case Estanciones.Otonio:
                    TimeSpan diasOtonio = Otonio - DateTime.Now;
                    double diasParaOtonio = diasOtonio.TotalDays;
                    return "Faltan "+ diasParaOtonio.ToString("#.00") + " dias para otoño";
            }

            return "error";

        }
    }
}
