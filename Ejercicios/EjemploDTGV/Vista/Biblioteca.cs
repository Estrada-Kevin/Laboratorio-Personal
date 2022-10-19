using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public class Biblioteca
    {
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;

        public Biblioteca(string usuario, string genero, string juego, int codigoJuego)
        {
            this.usuario = usuario;
            this.genero = genero;
            this.juego = juego;
            this.codigoJuego = codigoJuego;
        }

        public string Usuario
        {
            get { return usuario; }
        }
        public string Juego
        {
            get { return juego; }
        }
        public string Genero
        {
            get { return genero; }
        }

        public int CodigoJuego
        {
            get { return codigoJuego; }
        }
       
    }
}
