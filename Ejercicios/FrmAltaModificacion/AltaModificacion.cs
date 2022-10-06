using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAltaModificacion
{
    public partial class AltaModificacion : Form
    {
        public AltaModificacion(string formularioTitulo, string objetoTxt, string btnConfirmarTxt)
        {
            InitializeComponent();
            Text = formularioTitulo;
            txtObjeto.Text = objetoTxt;
            btnConfirmar.Text = btnConfirmarTxt;
        }

        public string Objeto
        {
            get { return txtObjeto.Text; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ValidacionDeBtnConfirmar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                ValidacionDeBtnConfirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                ValidacionBtnCancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ValidacionBtnCancelar();
        }

        private void ValidacionDeBtnConfirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("Error: el texto esta vacío", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ValidacionBtnCancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
