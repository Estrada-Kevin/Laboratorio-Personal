using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_Automotores
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short CantidadCompetidores):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = CantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------COMPETENCIA----------");
            sb.AppendLine($"Cantidad de vueltas en la competencia: {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            sb.AppendLine("-----------------------------");

            foreach (AutoF1 item in competidores)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c!=a)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                Random r = new Random();
                a.SetCantidadCombustible((short)(r.Next(15, 100)));
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool returnAux = false;
            if(c==a)
            {
                c.competidores.Remove(a);
                returnAux = true;
            }
            return returnAux;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if(item == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 item in c.competidores)
            {
                if (item == a)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
