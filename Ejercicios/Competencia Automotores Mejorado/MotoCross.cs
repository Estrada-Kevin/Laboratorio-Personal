using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_Automotores_Mejorado
{
    public class MotoCross: VehiculoDeCarrera
    {
        private short cilindrada;

        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        public MotoCross(short numero, string escuderia) :base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada):this(numero,escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Cilindrada: {cilindrada}");
            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if(m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia && m1.cilindrada == m2.cilindrada)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }
    }
}
