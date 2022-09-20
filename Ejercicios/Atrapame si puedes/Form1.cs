using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculador;


namespace Atrapame_si_puedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        { 
            try
            {
                ChequearParametrosVacios();
                float dividendo = int.Parse(txt_Kilometros.Text);
                float divisor = int.Parse(txt_Litros.Text);
                float auxiliar = Calculador.Calculador.Calcular(dividendo, divisor);
                rtxt_Historial.Text += auxiliar.ToString("0.##")+ "\n";
            }
            catch (FormatException )
            {
                MessageBox.Show("Error, solo ingrese numeros");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error, no se puede dividir por 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChequearParametrosVacios()
        {
            if (txt_Kilometros.Text == "" || txt_Litros.Text == "")
            {
                throw new ParametrosVaciosException();
            }

        }
    }
}
