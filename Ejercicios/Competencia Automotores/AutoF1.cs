using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia_Automotores
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        public short GetCantidadCombustible()
        {
            return cantidadCombustible;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero del auto: {numero}");
            sb.AppendLine($"Escuderia: {escuderia }");
            sb.AppendLine($"Vueltas restantes: {GetVueltasRestantes()}");
            sb.AppendLine($"Combustible restante: {GetCantidadCombustible()}");

            return sb.ToString();
            
        }
    }
}
