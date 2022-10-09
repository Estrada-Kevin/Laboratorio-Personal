using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_IV
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }

    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }
        public float Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public string NroDestino
        {
            get { return nroDestino; }
            set { nroDestino = value; }
        }
        public string NroOrigen
        {
            get { return nroOrigen; }
            set { nroOrigen = value; }
        }

        public Llamada()
        {

        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        protected virtual string Mostrar()
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

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.nroOrigen == l2.nroOrigen)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
