﻿using System;
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
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.Show();
        }

        private void btn_FacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.Show();
        }

        private void btn_FacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita);
            frmMostrar.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
