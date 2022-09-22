using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segui_participando
{
    public class CompetenciaNoDisponible : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        
        

        public string NombreClase
        {
            get { return nombreClase; }
        }
        public string NombreMetodo
        {
            get { return nombreMetodo; }
        }


        public CompetenciaNoDisponible(string mensaje, string clase, string metodo):base(mensaje)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public CompetenciaNoDisponible(string mensaje, string clase, string metodo, Exception innerException):base(mensaje,innerException)
        {
            nombreClase = clase;
            nombreMetodo=metodo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Excepcion del metodo: {NombreMetodo} de la clase: {NombreClase}");
            sb.AppendLine(Message);
            if(InnerException is not null)
            {
                sb.AppendLine(InnerException.ToString());
            }
            return sb.ToString();
        }
    }
}
