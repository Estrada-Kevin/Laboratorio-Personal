using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_deportiva
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private Jugador()
        {
            partidosJugados = 0;
            totalGoles = 0;
            
        }

        public Jugador(int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre)
        {
            partidosJugados = totalPartidos;
            this.totalGoles=totalGoles;
        }

        public float PromedioGoles
        {
            get { return (float)totalGoles / (float)partidosJugados; }
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
        }

        public int TotalGoles
        {
            get { return totalGoles; }
        }

        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
        }

        public int Dni
        {
            get { return dni;}
            set { dni = value; }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Dni: {dni}");
            sb.AppendLine($"Total Partidos Jugados: {partidosJugados}");
            sb.AppendLine($"Goles totales: {totalGoles}");
            sb.AppendLine($"Promedio goles: {this.PromedioGoles}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
