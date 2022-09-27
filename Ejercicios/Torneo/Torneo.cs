using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    public class Torneo<T>
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        private Torneo()
        {
            equipos = new List<T>();
        }

        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public List<T> Equipos
        {
            get { return equipos; } 
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string JugarPartido
        {
            get 
            {
                Random random = new Random();
                T equipo1;
                T equipo2;

                do
                {
                    equipo1 = equipos[random.Next(0, equipos.Count)];
                    equipo2 = equipos[random.Next(0, equipos.Count)];
                } while (equipo1 == equipo2);

                return CalcularPartido(equipo1, equipo2);
            }
        }

        public static bool operator ==(Torneo<T> t, T e)
        {
            if(t.equipos is not null)
            {
                foreach (T item in t.equipos)
                {
                    if(item == e)
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public static bool operator !=(Torneo<T> t, T e)
        {
            return !(t == e);
        }


        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if(t.equipos is not null)
            {
                if(t!=e)
                {
                    t.equipos.Add(e);
                }
            }
            return t;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos: ");
            sb.AppendLine($"Torneo {Nombre}");
            foreach (T item in equipos)
            {
                sb.AppendLine($"{item.Ficha()}");
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random random = new Random();
            return $"{equipo1.Nombre} {random.Next(0,10)} - {random.Next(0,10)} {equipo2.Nombre}\n";



        }


    }
}
