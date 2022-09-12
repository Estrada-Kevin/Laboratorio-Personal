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
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;   
        }


    }
}
