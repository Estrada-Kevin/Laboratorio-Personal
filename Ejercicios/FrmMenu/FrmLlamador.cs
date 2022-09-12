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
            Llamada l1;
            Random r = new Random();
            Franja franjas;
            Enum.TryParse<Franja>(cmb_Franja.SelectedValue.ToString(), out franjas);
            if (txt_Destino.Text.StartsWith("#"))
            {
                l1 = new Provincial(txt_Origen.Text, franjas, r.Next(1,50), txt_Destino.Text);

            }
            else
            {
                l1 = new Local(txt_Origen.Text, r.Next(), txt_Destino.Text, CostoRandom());
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLlamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        public float CostoRandom()
        {
            Random rand = new Random();
            double min = 1;
            double max = 5.56;
            double range = max - min;
            float f = 0;

            double sample = rand.NextDouble();
            double scaled = (sample * range) + min;
            f = (float)Math.Round(scaled, 2);



            return f;
        }

    }
}
