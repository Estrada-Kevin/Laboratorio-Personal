using PersonaCDRUPruebas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PersonaCDRUForm
{
    public partial class CDRU : Form
    {
        PersonaDAO personaDAO;
        
        public CDRU()
        {
            personaDAO = new PersonaDAO();
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            LeerYRefrescarLista();
            
        }

        private void lstbxPersonas_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxPersonas.SelectedItem is not null)
            {
                Persona personaAuxiliar = lstbxPersonas.SelectedItem as Persona;
                txtNombre.Text = personaAuxiliar.Nombre;
                txtApellido.Text = personaAuxiliar.Apellido;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Persona personaAuxiliar = lstbxPersonas.SelectedItem as Persona;
            if (personaAuxiliar is not null && (txtNombre != null && txtApellido != null))
            {
                personaDAO.Modificar(personaAuxiliar.Id, txtNombre.Text, txtApellido.Text);
                LimpiarBotones();
                LeerYRefrescarLista();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtNombre != null && txtApellido != null)
            {
                personaDAO.Guardar(new Persona(txtNombre.Text, txtApellido.Text));
                LimpiarBotones();
                LeerYRefrescarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Persona personaAuxiliar = lstbxPersonas.SelectedItem as Persona;
            if(personaAuxiliar is not null)
            {
                personaDAO.Borrar(personaAuxiliar.Id);
                
            }
            LimpiarBotones();
            LeerYRefrescarLista();
        }
        private void LeerYRefrescarLista()
        {
            List<Persona> personas = personaDAO.Leer();
            lstbxPersonas.DataSource = null;
            if (lstbxPersonas.Items.Count <= personas.Count)
            {
                lstbxPersonas.DataSource = personas;
            }
        }

        private void LimpiarBotones()
        {
            txtNombre.Clear();
            txtApellido.Clear();
        }
    }
}
