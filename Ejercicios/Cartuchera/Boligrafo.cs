using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class Boligrafo: IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color
        {
            get { return colorTinta; }
            set { colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return tinta; }
            set { tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            colorTinta = color;
            tinta = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            char[] auxiliarTexto = texto.ToCharArray();
            for (int i = 0; i < auxiliarTexto.Length; i++)
            {
                tinta -= (float)0.3;
            }

            EscrituraWrapper escritura = new EscrituraWrapper(texto,colorTinta);

            return escritura;
        }
        public bool Recargar(int unidades)
        {
            if(unidades !=0)
            {
                tinta += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Es un boligrafo");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Nivel de tinta: {UnidadesDeEscritura.ToString("#.##")}");

            return sb.ToString();
        }
    }
}
