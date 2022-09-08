using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_Automotores_Mejorado
{
    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return competidores[i]; }
        }

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia (short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo): this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public string MostrarDatosCompetencia()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-----------Competencia-----------");
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadCompetidores}");
            sb.AppendLine($"Tipo de competencia: {tipo}");
            foreach (VehiculoDeCarrera item in competidores)
            {
                if(item.GetType()==typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)item).MostrarDatos());
                }
                else if(item.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine(((MotoCross)item).MostrarDatos());
                }
            }

            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if(c.Tipo == TipoCompetencia.F1 && v.GetType() == typeof(AutoF1) || c.Tipo == TipoCompetencia.MotoCross && v.GetType() == typeof(MotoCross))
            {
                if(c.competidores.Count >0)
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if(item == v)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            if (c.competidores.Count < c.cantidadCompetidores && c!=v)
            { 
                v.EnCompetencia = true;
                v.VueltasRestantes = c.cantidadVueltas;
                Random r = new Random();
                v.CantidadCombustible = (short)(r.Next(15, 100));
                c.competidores.Add(v);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if(c==v)
            {
                c.competidores.Remove(v);
                return true;
            }
            return false;
        }


    }
}
