using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzar_y_Atrapar
{
    public class OtraClase
    {

        public static void instanciarClase()
        {
            
            try
            {
                MiClase miClase = new MiClase(11);
            }
            catch (Exception ex)
            {
                throw new MiExcepcion("ERROR 4 " + ex.Message, ex.InnerException );
            }
        }
    }
}
