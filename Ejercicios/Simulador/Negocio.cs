using NameGenerator.Generators;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulador
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> listaCajas)
        {
            cajas = listaCajas;
            clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> tasks = new List<Task>();

            tasks.AddRange(AbrirCajas());
            tasks.Add(Task.Run(GenerarClientes));
            tasks.Add(Task.Run(AsignarCajas));

            return tasks;
        }

        public List<Task> AbrirCajas()
        {
            List<Task> hilos = new List<Task>();
            foreach (Caja item in cajas)
            {
                hilos.Add(item.IniciarAtencion());
            }
            return hilos;
        }

        public void GenerarClientes()
        {
            do
            {
                clientes.Enqueue(realNameGenerator.Generate());
                Thread.Sleep(1000);
            } while (true);
        }

        public void AsignarCajas()
        {
            do
            {
                Caja caja = cajas.OrderBy(c => c.CantidadClientesALaEspera).First();
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);
                }
            } while (true);
        }
    }
}
