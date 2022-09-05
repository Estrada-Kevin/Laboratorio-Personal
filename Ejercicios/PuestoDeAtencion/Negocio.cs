using System.Collections.Generic;

namespace PuestoDeAtencion
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set { _ = this + value; }
        }    

        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }

            return false;
        }

       public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count>0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count;  }
        }

    }
}
