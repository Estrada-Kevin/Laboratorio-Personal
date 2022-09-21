using Centralita_III;
using System;
using System.Windows.Forms;

namespace FrmMenu
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            rtxt_Mostrador.Text = centralita.ToString();
        }
    }
}
