using IO__notepad_;
using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class notePad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        PuntoJson<string> puntoJson;
        PuntoTxt puntoTxt;
        PuntoXml<string> puntoXml;
        public notePad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            puntoJson = new PuntoJson<string>();
            puntoXml = new PuntoXml<string>();
            puntoTxt = new PuntoTxt();
        }

        private void rtxt_Texto_TextChanged(object sender, EventArgs e)
        {
            ToolStripStatusLabel.Text = rtxt_Texto.Text.Length.ToString() + " caracteres";
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!File.Exists(saveFileDialog.FileName))
            {
                GuardarComo();
            }
            else
            {
                Guardar();
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (Path.GetExtension(openFileDialog.FileName))
                    {
                        case ".txt":
                            rtxt_Texto.Text = puntoTxt.Leer(openFileDialog.FileName);
                            break;
                        case ".json":
                            rtxt_Texto.Text = puntoJson.Leer(openFileDialog.FileName);
                            break;
                        case ".xml":
                            rtxt_Texto.Text = puntoXml.Leer(openFileDialog.FileName);
                            break;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al abrir archivo");
                }
            }
        }

        public void AbrirArchivo()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(openFileDialog.FileName);
                    rtxt_Texto.Text = sr.ReadToEnd().ToString();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Detalles:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Guardar()
        {
            try
            {
                switch (Path.GetExtension(saveFileDialog.FileName))
                {
                    case ".txt":
                        puntoTxt.Guardar(saveFileDialog.FileName, rtxt_Texto.Text);
                        break;
                    case ".json":
                        puntoJson.Guardar(saveFileDialog.FileName, rtxt_Texto.Text);
                        break;
                    case ".xml":
                        puntoXml.Guardar(saveFileDialog.FileName, rtxt_Texto.Text);
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar archivo");
            }
        }

        private void GuardarComo()
        {
            saveFileDialog.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (Path.GetExtension(saveFileDialog.FileName))
                    {
                        case ".txt":
                            puntoTxt.GuardarComo(saveFileDialog.FileName, rtxt_Texto.Text);
                            break;
                        case ".json":
                            puntoJson.GuardarComo(saveFileDialog.FileName, rtxt_Texto.Text);
                            break;
                        case ".xml":
                            puntoXml.GuardarComo(saveFileDialog.FileName, rtxt_Texto.Text);
                            break;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al guardar archivo");
                }
            }
        }
    }
}
