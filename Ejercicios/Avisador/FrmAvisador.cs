using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avisador
{
    public partial class FrmAvisador : Form
    {
        Persona persona;
        public FrmAvisador()
        {
            InitializeComponent();   
        }

        public void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (persona is null && (string.IsNullOrWhiteSpace(txtApellido.Text) == false && string.IsNullOrWhiteSpace(txtNombre.Text) == false))
            {
                persona = new Persona(txtApellido.Text, txtNombre.Text);
                persona.EventoPersona += NotificarCambio;

                txtApellido.Text = persona.Apellido;
                txtNombre.Text = persona.Nombre;
                lblNombreCompleto.Text = persona.Mostrar();
                btnActualizar.Text = "Actualizar";
                
            }
            else
            {
                persona = new Persona(txtApellido.Text, txtNombre.Text);
                persona.EventoPersona += NotificarCambio;


                txtApellido.Text = persona.Apellido;
                txtNombre.Text = persona.Nombre;
                lblNombreCompleto.Text = persona.Mostrar();
            }
        }

       
    }
}
