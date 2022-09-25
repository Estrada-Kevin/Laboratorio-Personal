using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzar_y_Atrapar
{
    public class MiClase
    {

        private int numero;
        public MiClase()
        {
            try
            {
                numero = DividirPorCero(1, 0);
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR 2 ", ex);
            }
        }

        public MiClase(int numero)
        {
            try
            {
                MiClase miclase = new MiClase();
            }
            catch (Exception ex)
            {
                throw new UnaExcepcion("ERROR 3 ", ex);
            }
        }


        public static int DividirPorCero(int dividendo, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("ERROR 1");
            }
            return dividendo/divisor;
        }


    }
}
