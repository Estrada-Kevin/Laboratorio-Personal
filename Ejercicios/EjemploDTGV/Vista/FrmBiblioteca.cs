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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefrescarBiblioteca();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDAO.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtgvBiblioteca.SelectedRows.Count>0)
                {
                    Biblioteca bibliotecaAuxiliar = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
                    JuegoDAO.Eliminar(bibliotecaAuxiliar.CodigoJuego);
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAlta alta = new FrmAlta();
                if(alta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtgvBiblioteca.SelectedRows.Count>0)
                {
                    Biblioteca bibliotecaAuxiliar = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
                    FrmAlta alta = new FrmAlta(bibliotecaAuxiliar.CodigoJuego);

                    if(alta.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarBiblioteca();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
