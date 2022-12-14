using System;

namespace Segui_participando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Competencia formulaUno = new Competencia(10, 5, TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            MotoCross moto = new MotoCross(9, "El VELOCIN", 300);
            _ = formulaUno + moto;
            for (int i = 0; i < 9; i++)
            {
                autos[i] = new AutoF1((short)i, r.Next(1, 5).ToString());
                if (formulaUno + autos[i])
                {
                    Console.WriteLine("Se agregó el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                }
                else
                {
                    Console.WriteLine("No se agregó ya que no hay más lugares: {0}", autos[i].MostrarDatos());
                }
            }

            Console.WriteLine();
            Console.WriteLine("<--------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatosCompetencia());
        }
    }
}
