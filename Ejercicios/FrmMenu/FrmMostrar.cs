using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita_II;

namespace FrmMenu
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private TipoLlamada tipo;

        public TipoLlamada Tipo
        {
            get { return tipo; }
        }
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
            foreach (Llamada item in centralita.Llamadas)
            {
                if(item is Provincial listaProvincial)
                {
                    tipo = TipoLlamada.Provincial;
                }
                else if(item is Local listaLocal)
                {
                    tipo = TipoLlamada.Local;
                }
                else
                {
                    tipo = TipoLlamada.Todas;
                }
            }

        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (centralita is not null)
            {
                foreach (Llamada item in centralita.Llamadas)
                {
                    if (tipo == TipoLlamada.Provincial)
                    {
                        rtxt_Mostrador.Text = item.ToString();
                    }
                    else if (tipo == TipoLlamada.Local)
                    {
                        rtxt_Mostrador.Text = item.ToString();
                    }
                    else
                    {
                        rtxt_Mostrador.Text = item.ToString();
                    }
                }
            }
            
        }
    }
}
