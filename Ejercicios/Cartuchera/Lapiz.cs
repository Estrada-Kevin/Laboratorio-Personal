using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public class Lapiz: IAcciones
    {
        private float tamanioMina;
        

        public Lapiz(int unidades)
        {
            tamanioMina = unidades;
        }
        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura
        {
            get { return tamanioMina; }
            set { tamanioMina = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            char[] auxiliarTexto = texto.ToCharArray();
            for (int i = 0; i < auxiliarTexto.Length; i++)
            {
                tamanioMina -= (float)0.1;
            }
            EscrituraWrapper escritura = new EscrituraWrapper(texto, ConsoleColor.Gray);

            return escritura;
        }

        public bool Recargar(int unidades)
        {
            //throw new NotImplementedException();
            if (unidades != 0)
            {
                tamanioMina += unidades;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Es un lapiz");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Tamaño de mina: {UnidadesDeEscritura.ToString("#,##")}");

            return sb.ToString();
        }

    }
}
