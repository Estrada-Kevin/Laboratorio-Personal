using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_deportiva_mejorada
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento;}
            set { fechaNacimiento = value; }
        }


        public DirectorTecnico (DateTime fechaNacimiento, long dni, string nombre) : base (dni, nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatosDirector()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToString("dd/MM/yyyy")}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if(dt1.Nombre == dt2.Nombre && dt1.fechaNacimiento==dt2.fechaNacimiento)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }

    }
}
