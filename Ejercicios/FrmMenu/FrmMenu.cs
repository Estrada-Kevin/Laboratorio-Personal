using Centralita_III;
using System;
using System.Windows.Forms;

namespace FrmMenu
{
    public partial class FrmMenu : Form
    {
        private Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita();
        }

        private void btn_GenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(centralita);
            frmLlamador.Show();
        }

        private void btn_FacturacionTotal_Click(object sender, EventArgs e)
        {
            if(centralita.Llamadas.Count <= 0)
            {
                MessageBox.Show("No hay llamadas");
            }
            else
            {
                FrmMostrar frmMostrar = new FrmMostrar(centralita);
                frmMostrar.Show();
            }
        }

        private void btn_FacturacionLocal_Click(object sender, EventArgs e)
        {

            Centralita centralitaAuxiliar = new Centralita();
            if (centralita.Llamadas.Count <= 0)
            {
                MessageBox.Show("No hay llamadas locales");
            }
            else
            {
                foreach (Llamada item in centralita.Llamadas)
                {
                    if (item is Local listaLocal)
                    {
                        centralitaAuxiliar += item;
                    }
                }
                FrmMostrar frmMostrar = new FrmMostrar(centralitaAuxiliar);
                frmMostrar.Show();
            }


        }

        private void btn_FacturacionProvincial_Click(object sender, EventArgs e)
        {

            Centralita centralitaAuxiliar = new Centralita();
            if(centralita.Llamadas.Count <= 0)
            {
                MessageBox.Show("No hay llamadas provinciales");
            }
            else
            {
                foreach (Llamada item in centralita.Llamadas)
                {
                    if (item is Provincial listaProvincial)
                    {
                        centralitaAuxiliar += item;
                    }
                }
                FrmMostrar frmMostrar = new FrmMostrar(centralitaAuxiliar);
                frmMostrar.Show();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
