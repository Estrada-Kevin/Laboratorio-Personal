using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorDigitos
{
    public static class Contador
    {
        public static int ContarCantidadDeDigitos(this long numero)
        {
            string auxiliar = numero.ToString();
            return auxiliar.Count();
        }
    }
}
