using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get { return duracion; }
        }
        public string NroDestino
        {
            get { return nroDestino; }
        }
        public string NroOrigen
        {
            get { return nroOrigen; }   
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Duracion: {duracion}");
            sb.AppendLine($"Numero de destino: {nroDestino}");
            sb.Append($"Numero de origen: {nroOrigen}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.Duracion - llamada2.Duracion);
        }


    }
}
