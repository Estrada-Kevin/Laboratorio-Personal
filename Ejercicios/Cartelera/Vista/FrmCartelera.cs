using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCartelera : Form
    {
        private static string rutaConfiguracion;

        public FrmCartelera()
        {
            InitializeComponent();
        }

        static FrmCartelera()
        {
            rutaConfiguracion = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "configuracion.json";
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = txtTitulo.Text;
        }

        private void rtxtMensaje_TextChanged(object sender, EventArgs e)
        {
            lblMensaje.Text = rtxtMensaje.Text;
        }

        private Color ElegirColor (Color colorActual)
        {
            colorDialog.Color = colorActual;
            colorDialog.ShowDialog();
            return colorDialog.Color;
        }

        private void btnColorPanel_Click(object sender, EventArgs e)
        {
            pnlCartel.BackColor = ElegirColor(pnlCartel.BackColor);
        }

        private void btnColorTitulo_Click(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = ElegirColor(lblTitulo.ForeColor);
        }

        private void btnColorMensaje_Click(object sender, EventArgs e)
        {
            lblMensaje.ForeColor = ElegirColor(lblMensaje.ForeColor);
        }
        private void FrmCartelera_Load(object sender, EventArgs e)
        {
            leerConfiguracion();
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

        private void btnImportarConfiguracion_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json files(*.json)|*.json";
            ofd.ShowDialog();
            CargarConfiguracion(ofd.FileName);
        }

        private void btnEliminarConfiguracion_Click(object sender, EventArgs e)
        {
            eliminarConfiguracion();
        }
        private void leerConfiguracion()
        {
            try
            {
                if (File.Exists(rutaConfiguracion))
                {
                    string jsonString = File.ReadAllText(rutaConfiguracion);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(jsonString);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo no se encuentra en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void GuardarConfiguracion()
        {
            try
            {
                Texto titulo = new Texto(lblTitulo.Text, lblTitulo.ForeColor.ToArgb());
                Texto mensaje = new Texto(lblMensaje.Text, lblMensaje.ForeColor.ToArgb());
                Cartel cartel = new Cartel(pnlCartel.BackColor.ToArgb(), titulo, mensaje);

                string jsonString = JsonSerializer.Serialize(cartel);
                File.WriteAllText(rutaConfiguracion, jsonString);
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo no se encuentra en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void CargarConfiguracion(string path)
        {
            try
            {
                if(File.Exists(path))
                {
                    string jsonString = File.ReadAllText(path);
                    Cartel cartel = JsonSerializer.Deserialize<Cartel>(jsonString);

                    pnlCartel.BackColor = Color.FromArgb(cartel.ColorARGB);

                    txtTitulo.Text = cartel.Titulo.Contenido;
                    lblTitulo.ForeColor = Color.FromArgb(cartel.Titulo.ColorARGB);

                    rtxtMensaje.Text = cartel.Mensaje.Contenido;
                    lblMensaje.ForeColor = Color.FromArgb(cartel.Mensaje.ColorARGB);
                }
            }
            catch (JsonException)
            {
                MessageBox.Show("El archivo no se encuentra en el formato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarConfiguracion()
        {
            DialogResult eliminar = MessageBox.Show("¿Está seguro que desea eliminar la configuración?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (eliminar == DialogResult.Yes)
            {
                if (File.Exists(rutaConfiguracion))
                {
                    File.Delete(rutaConfiguracion);
                }
                txtTitulo.Text = "Título";
                lblTitulo.ForeColor = Control.DefaultForeColor;

                rtxtMensaje.Text = "Mensaje";
                lblMensaje.ForeColor = Control.DefaultForeColor;

                pnlCartel.BackColor = Control.DefaultBackColor;
            }
        }
    }
}
