using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Calculador
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException()
        {
        }

        public ParametrosVaciosException(string message) : base(message)
        {
        }

        public ParametrosVaciosException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public override string Message
        {
            get { return "Error: no se ingresaron datos"; }
        }
    }
}
