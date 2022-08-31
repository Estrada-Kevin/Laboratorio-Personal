using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InsertadorDePalabras(rtxt_Palabras.Text);
            int count = rtxt_Palabras.Text.Split(' ').Count();
            MessageBox.Show($"Hay {count} palabras" );
        }

        public void InsertadorDePalabras(string texto)
        {
            char[] separacion = new char[] { ' ', ',', '.', ':', '\t' };
            palabra.AddRange(texto.Split(separacion, StringSplitOptions.RemoveEmptyEntries));

            foreach (string item in palabra)
            {
                if(!diccionario.ContainsKey(item) && item != " ")
                {
                    diccionario.Add(item, 1);
                }
                else
                {
                    diccionario[item] += 1;
                }
            }
        }

        private void rtxt_Palabras_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
