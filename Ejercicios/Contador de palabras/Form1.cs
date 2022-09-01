using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Contador_de_palabras
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> diccionario;
        List<string> palabra;
        public Form1()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
            palabra = new List<string>();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();
            List<KeyValuePair<string, int>> podio = obtenerPodio(contadorPalabras);
            mostrarPodio(podio);
        }


        public Dictionary<string, int> ObtenerContadorPalabras()
        {
            string texto = rtxt_Palabras.Text;
            string[] palabras = texto.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string item in palabras)
            {
                if (contadorPalabras.ContainsKey(item))
                {
                    contadorPalabras[item]++;
                }
                else
                {
                    contadorPalabras.Add(item, 1);
                }
            }

            return contadorPalabras;
        }

        private List<KeyValuePair<string, int>> obtenerPodio(Dictionary<string, int> contadorPalabras)
        {
            List<KeyValuePair<string, int>> podio = contadorPalabras.ToList(); //transforma el diccionario en una listas con KeyValuePair
            podio.Sort(compararCantidadRepeticiones);

            return podio;
        }

        private void mostrarPodio(List<KeyValuePair<string, int>> podio)
        {
            StringBuilder sb = new StringBuilder();

            if (podio.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras");
            }
            else
            {
                //foreach (KeyValuePair<string, int> item in podio)
                //{
                //    sb.AppendLine($"Palabra {item.Key} - Cantidad: {item.Value}");
                //}
                for (int i = 0; i < 3 && i<podio.Count; i++)
                {
                    KeyValuePair<string,int> item = podio[i];
                    sb.AppendLine($"Palabra {item.Key} - Cantidad: {item.Value}");
                }

            }
            MessageBox.Show(sb.ToString(), "Podio");


        }

        private int compararCantidadRepeticiones(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return segundoElemento.Value - primerElemento.Value;
        }

        private void rtxt_Palabras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }

    }
}
