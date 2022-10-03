namespace CalculadoraUnitaria
{
    public class CalculadoraPrueba
    {
        ///Hay distintas versiones del método Add debido a que el ejercicio pedía ir complejizando poco a poco el metodo.
        public static int Add(string numeros)
        {
            string[] auxiliar = numeros.Split(',');
            int resultado = 0;
            for (int i = 0; i < 2; i++)
            {
                resultado += int.Parse(auxiliar[i]);
            }
            return resultado;
        }

        public static int AddV2(string numeros)
        {
            string[] auxiliar = numeros.Split(',');
            int resultado = 0;
            for (int i = 0; i < auxiliar.Length; i++)
            {
                resultado += int.Parse(auxiliar[i]);
            }
            return resultado;
        }

        public static int AddV3(string numeros)
        {
            string[] auxiliar = numeros.Split('\n', ',');
            int resultado = 0;
            for (int i = 0; i < auxiliar.Length; i++)
            {
                resultado += int.Parse(auxiliar[i]);
            }
            return resultado;
        }

        public static int AddV4(string numeros)
        {
            char[] charAuxiliar = new char[numeros.Length];
            char delimitadorExtra = ' ';
            if (numeros.StartsWith("//"))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    charAuxiliar[i] = numeros[i];

                }
                delimitadorExtra = charAuxiliar[2];
            }

            string[] auxiliar = numeros.Split('\n', ',', delimitadorExtra);
            int resultado = 0;
            for (int i = 0; i < auxiliar.Length; i++)
            {
                int.TryParse(auxiliar[i], out int isNumber);
                resultado += isNumber;
            }
            return resultado;
        }

        public static int AddV5(string numeros)
        {

            char[] charAuxiliar = new char[numeros.Length];
            char delimitadorExtra = ' ';
            if (numeros.StartsWith("//"))
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    charAuxiliar[i] = numeros[i];

                }
                delimitadorExtra = charAuxiliar[2];
            }

            string[] auxiliar = numeros.Split('\n', ',', delimitadorExtra);
            int resultado = 0;
            for (int i = 0; i < auxiliar.Length; i++)
            {
                int.TryParse(auxiliar[i], out int isNumber);
                if (isNumber < 0)
                {
                    throw new NegativoNoPermitidoException($"{isNumber}");
                }
                resultado += isNumber;
            }
            return resultado;
        }
    }
}
