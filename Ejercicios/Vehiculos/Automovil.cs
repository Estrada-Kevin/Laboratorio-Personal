using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, int cantidadPasajeros,  short cantidadMarchas, Colores color, short cantidadPuertas ):base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
