﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        public Local(string origen, float duracion, string destino, float costo):base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada1, float costo):this(llamada1.NroOrigen, llamada1.Duracion, llamada1.NroDestino, costo)
        {

        }

        private float CalcularCosto()
        {
            return Duracion * costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada Local.");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {CostoLlamada}\n");

            return sb.ToString();
        }
    }
}
