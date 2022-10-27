using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simulador
{
    public class Caja
    {
        public delegate void DelegadoCliente(Caja caja, string cliente);

        static Random random;
        private Queue<string> clientesALaEspera;
        private DelegadoCliente delegadoClienteAtendido;
        private string nombreCaja;
        
        static Caja()
        {
            random = new Random();
        }

        public Caja(string nombreCaja,DelegadoCliente delegadoCaja)
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            delegadoClienteAtendido = delegadoCaja;
        }

        public string NombreCaja
        {
            get { return nombreCaja; }
        }

        public int CantidadClientesALaEspera
        {
            get { return clientesALaEspera.Count; }
        }

        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        public void AtenderClientes()
        {
            do
            {
                if(clientesALaEspera.Any())
                {
                    string auxiliar = clientesALaEspera.Dequeue();
                    delegadoClienteAtendido.Invoke(this,auxiliar);
                    Thread.Sleep(random.Next(1000, 5000));
                }
            } while (true);
        }

    }
}
