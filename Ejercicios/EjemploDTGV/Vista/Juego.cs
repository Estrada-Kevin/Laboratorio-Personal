using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Juego
    {
        private int codigoJuego;
        private int codigoUsuario;
        private string genero;
        private string nombre;
        private double precio;

        public int CodigoJuego
        {
            get { return codigoJuego; }
        }
        public int CodigoUsuario
        {
            get { return codigoUsuario; }
        }
        public string Genero
        {
            get { return genero; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public double Precio
        {
            get { return precio; }
        }

        public Juego(string nombre, double precio, string genero, int codigoUsuario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.genero = genero;
            this.codigoUsuario = codigoUsuario;
        }
        public Juego(string nombre, double precio, string genero, int codigoJuego, int codigoUsuario):this(nombre,precio,genero,codigoUsuario)
        {
            this.codigoJuego = codigoJuego;
        }

        
    }
}
