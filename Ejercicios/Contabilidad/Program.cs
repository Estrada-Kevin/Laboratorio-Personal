using System;

namespace Contabilidad
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura,Recibo> contabilidad = new Contabilidad<Factura,Recibo>();
            Recibo recibo = new Recibo();
            Factura factura = new Factura(123);
            Factura factura2 = new Factura(321);

            _=contabilidad + recibo;
            _=contabilidad + factura;
            _=contabilidad + factura2;

            foreach (Documento item in contabilidad.egresos)
            {
                Console.WriteLine(item.Numero);
            }
            foreach(Documento item in contabilidad.ingresos)
            {
                Console.WriteLine(item.Numero);
            }

        }
    }
}
