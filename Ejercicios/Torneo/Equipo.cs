using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    public class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public string Nombre
        {
            get { return nombre; }
        }
        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }


         public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre del equipo: {nombre} Fundado el {fechaCreacion.ToString("dd/MM/yyyy")}");
            return sb.ToString();
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1 is not null && e2 is not null)
            {
                if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

    }
}
