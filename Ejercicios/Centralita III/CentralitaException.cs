using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_III
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return nombreClase; }
        }
        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }

        public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, Exception innerException, string clase, string metodo) : base(mensaje, innerException)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        
    }
}
