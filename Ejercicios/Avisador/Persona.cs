using System.Text;

namespace Avisador
{
    public class Persona
    {
        public delegate void DelegadoString(string msg);
        public event DelegadoString EventoPersona;

        private string apellido;
        private string nombre;


        public string Apellido
        {
            get { return apellido; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public Persona(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            sb.AppendLine(Apellido);
            if (EventoPersona != null)
            {
                EventoPersona.Invoke(sb.ToString());
            }
            return sb.ToString();
        }


    }
}
