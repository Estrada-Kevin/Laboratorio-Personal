using Centralita_II;
using System;
using System.Windows.Forms;


namespace FrmMenu
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            cmb_Franja.Enabled = false;
            cmb_Franja.DataSource = Enum.GetValues(typeof(Franja));
        }

        public Centralita Centralita
        {
            get { return centralita; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "9";

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!(txt_Destino.Text.Contains("*")))
            {
                txt_Destino.Text += "*";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            txt_Destino.Text += "0";

        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            if (!(txt_Destino.Text.Contains("#")))
            {
                txt_Destino.Text += "#";

            }

            if (txt_Destino.Text.StartsWith("#"))
            {
                cmb_Franja.Enabled = true;
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Destino.Clear();
            txt_Origen.Clear();
            cmb_Franja.Enabled = false;
        }

        private void txt_Origen_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '*'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '*') && (((TextBox)sender).Text.IndexOf('*') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_Llamar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Franja franjas;
            Enum.TryParse<Franja>(cmb_Franja.SelectedValue.ToString(), out franjas);
            Llamada l1;

            if (txt_Destino.Text.StartsWith("#") && txt_Origen.Text != "")
            {
                l1 = new Provincial(txt_Origen.Text, franjas, r.Next(1, 50), txt_Destino.Text);
                _ = centralita + l1;
            }
            
            
            if (txt_Destino.Text != "" && txt_Origen.Text != "")
            {
                l1 = new Local(txt_Origen.Text, r.Next(1, 50), txt_Destino.Text, CostoRandom());
                _ = centralita + l1;
            }

            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public float CostoRandom()
        {
            Random rand = new Random();
            double min = 1;
            double max = 5.56;
            double range = max - min;
            float f = 0;

            double muestra = rand.NextDouble();
            double escalado = (muestra * range) + min;
            f = (float)(Math.Round(escalado, 2));

            return f;
        }

    }
}
