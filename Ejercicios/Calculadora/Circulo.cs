using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    sealed class Circulo : Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override double CalcularPerimetro()
        {
            return Math.PI * this.radio * 2;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI + Math.Pow(this.radio, 2);
        }

        public override string Dibujar()
        {
            return "Dibujando Círculo...";
        }
    }
}
