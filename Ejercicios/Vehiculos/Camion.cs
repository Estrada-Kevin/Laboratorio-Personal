using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color, int pesoCarga ): base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
