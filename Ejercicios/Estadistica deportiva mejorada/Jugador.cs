using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_deportiva_mejorada
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;
        public int PartidosJugados
        {
            get { return partidosJugados; }
            set { partidosJugados = value; }
        }

        public float PromedioGoles
        {
            get { return (float)totalGoles / (float) partidosJugados; }
        }

        public int TotalGoles
        {
            get { return totalGoles; }
            set { totalGoles = value; }
        }

        public Jugador(int dni, string nombre) : base(dni,nombre)
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            partidosJugados = totalPartidos;
        }

        public string MostrarDatosJugador()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Goles Totales: {totalGoles}");
            sb.AppendLine($"Promedio Goles: {PromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
