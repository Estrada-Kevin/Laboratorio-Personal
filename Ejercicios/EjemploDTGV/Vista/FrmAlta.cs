using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            nupPrecio.Maximum = 10000;
            lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juegoAuxiliar = JuegoDAO.LeerPorId(codigoJuego);

            txtNombre.Text = juegoAuxiliar.Nombre;
            txtGenero.Text = juegoAuxiliar.Genero;
            nupPrecio.Value = (decimal)juegoAuxiliar.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            try
            {
                cmbUsuarios.DataSource = UsuarioDAO.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text != "Modificar")
                {
                    
                    Juego juegoAuxiliar = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);
                    JuegoDAO.Guardar(juegoAuxiliar);
                }
                else
                {
                    Juego juegoAuxiliar = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, codigoJuego, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);
                    JuegoDAO.Modificar(juegoAuxiliar);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
