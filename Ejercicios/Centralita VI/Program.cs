using System;
using System.Threading;
using System.Threading.Tasks;

namespace Centralita_VI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Centralita c = new Centralita();
            Task tarea1 = Task.Run(c.GenerarLlamada);
            tarea1.Wait();
            
            
            

        }

    }

}
