using System.Text;

namespace Segui_participando
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return escuderia; }
            set { escuderia = value; }
        }

        public short Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Cantidad De Combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }


    }
}
