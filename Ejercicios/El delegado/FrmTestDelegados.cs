using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_delegado
{
    public partial class FrmTestDelegados : Form
    {

        public delegate void DelegadoTextBox(string nombre);
        private DelegadoTextBox delegadoTextBox;
        public FrmTestDelegados(DelegadoTextBox delegadoActualizarNombre)
        {
            InitializeComponent();
            delegadoTextBox = delegadoActualizarNombre;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(delegadoTextBox is not null)
            {
                delegadoTextBox.Invoke(txtNombre.Text);
            }
            
        }
    }
}
