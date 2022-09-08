using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float auxiliar=0;
            if(tipo == TipoLlamada.Local || tipo==TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {
                    if(item is Local listaLocal)
                    {
                        auxiliar += listaLocal.CostoLlamada;
                    }
                }
            }
            else if(tipo == TipoLlamada.Provincial || tipo==TipoLlamada.Todas)
            {
                foreach (Llamada item in listaDeLlamadas)
                {

                    if(item is Provincial listaPronvincial)
                    {
                        auxiliar += listaPronvincial.CostoLlamada;
                    }
                }
            }
            
            return auxiliar;
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Razon social: {razonSocial}");
            sb.AppendLine($"Ganancias por llamadas locales: {GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamadas provinciales: {GananciasPorProvincial}");
            sb.AppendLine($"Ganancias totales: {GananciasPorTotal}\n");
            foreach (Llamada item in listaDeLlamadas)
            {
                if(item is Local listaLocal)
                {
                    sb.AppendLine(listaLocal.Mostrar()) ;
                }
                else if (item is Provincial listaProvincial)
                {
                    sb.AppendLine(listaProvincial.Mostrar()) ;
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
