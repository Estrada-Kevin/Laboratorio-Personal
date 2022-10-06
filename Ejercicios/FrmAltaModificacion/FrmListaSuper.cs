using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FrmAltaModificacion
{
    public partial class FrmListaSuper : Form
    {
        List<string> listaSupermercado;
        static string ruta = string.Empty;
        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "listaSupermercado.xml";
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            toolTipConfig();
            mostrarLista();
            CargarArchivo();
        }

        private void mostrarLista()
        {
            foreach (string item in listaSupermercado)
            {
                lstObjetos.Text = item;
            }
        }

        private void toolTipConfig()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnAgregar, "Agregar objeto");
            toolTip.SetToolTip(btnEliminar, "Eliminar objeto");
            toolTip.SetToolTip(btnModificar, "Modificar objeto");
        }

        private void RefrescarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }

        private void AgregarElementoALaLista()
        {
            AltaModificacion frmModificacion = new AltaModificacion("Agregar objeto", string.Empty, "Agregar");
            frmModificacion.ShowDialog();
            if (frmModificacion.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmModificacion.Objeto);
                RefrescarLista();
                GuardarArchivo();
            }
        }

        private void EliminarElementoDeLaLista()
        {
            if (lstObjetos.SelectedItem is not null)
            {
                listaSupermercado.Remove(lstObjetos.SelectedItem.ToString());
                RefrescarLista();
                GuardarArchivo();
            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ModificarElementoDeLaLista()
        {
            if (lstObjetos.SelectedItem is not null)
            {
                AltaModificacion frmModificacion = new AltaModificacion("Modificar objeto", lstObjetos.SelectedItem.ToString(), "Modificar");
                frmModificacion.ShowDialog();
                if (frmModificacion.DialogResult == DialogResult.OK)
                {
                    listaSupermercado[listaSupermercado.IndexOf(lstObjetos.SelectedItem.ToString())] = frmModificacion.Objeto;
                    RefrescarLista();
                    GuardarArchivo();
                }
            }
            else
            {
                MessageBox.Show("No hay ningun elemento seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void CargarArchivo()
        {
            if (File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                    listaSupermercado = xmlSerializer.Deserialize(sr) as List<string>;
                    RefrescarLista();

                }
            }
        }

        private void GuardarArchivo()
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer serializer = new XmlSerializer(listaSupermercado.GetType());
                serializer.Serialize(sw, listaSupermercado);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElementoALaLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarElementoDeLaLista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarElementoDeLaLista();
        }
    }
}
