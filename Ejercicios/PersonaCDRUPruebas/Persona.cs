using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaCDRUPruebas
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona(string nombre, string apellido) : this(0, nombre, apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Id
        {
            get { return id; }
        }

        public override string ToString()
        {
            return $"ID: {Id} Nombre: {Nombre} Apellido: {Apellido}\n";
        }
    }
}
