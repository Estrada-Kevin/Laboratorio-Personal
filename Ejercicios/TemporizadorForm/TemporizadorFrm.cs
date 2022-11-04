using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TemporizadorForm
{
    public partial class TemporizadorFrm : Form
    {

        private Temporizador temporizador;

        public TemporizadorFrm()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.eventoTemporizador += AsignarHora;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTiempo();
        }

        public void AsignarHora() //handler 
        {
            if(lblFecha.InvokeRequired)
            {
                Action asignarHora = AsignarHora;
                lblFecha.Invoke(asignarHora);
            }
            else
            {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }
    }
}
