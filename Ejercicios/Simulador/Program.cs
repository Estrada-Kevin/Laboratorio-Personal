using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Simulador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja.DelegadoCliente delegadoClienteAtendido = (caja, cliente) =>
            {
                Console.WriteLine($"{DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - {caja.NombreCaja} - Atendiendo a {cliente}. Quedan {caja.CantidadClientesALaEspera} clientes en estas caja");
            };

            Caja caja1 = new Caja("Caja 01", delegadoClienteAtendido);
            Caja caja2 = new Caja("Caja 02", delegadoClienteAtendido);

            List<Caja> cajas = new List<Caja>()
            {
                caja1,
                caja2
            };

            Negocio negocio = new Negocio(cajas);
            Console.WriteLine("Asignando Cajas...");

            List<Task> hilos = negocio.ComenzarAtencion();
            Task.WaitAll(hilos.ToArray());
        }
    }
}
