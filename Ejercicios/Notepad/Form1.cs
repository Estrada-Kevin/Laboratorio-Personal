using System;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class notePad : Form
    {
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        public notePad()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
        }

        private void rtxt_Texto_TextChanged(object sender, EventArgs e)
        {
            ToolStripStatusLabel.Text = rtxt_Texto.Text.Length.ToString() + " caracteres";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (saveFileDialog.FileName != "")
                    {
                        File.WriteAllText(saveFileDialog.FileName + ".txt", rtxt_Texto.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error message: {ex.Message}\n\n" +
                    $"Detalles:\n\n{ex.StackTrace}");
                }
                
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(openFileDialog.FileName) || File.Exists(saveFileDialog.FileName + ".txt"))
            {
                if(openFileDialog.FileName != "")
                {
                    File.WriteAllText(openFileDialog.FileName, rtxt_Texto.Text);
                }
                else
                {
                    File.WriteAllText(saveFileDialog.FileName + ".txt", rtxt_Texto.Text);
                }
                
            }
            else
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName + ".txt", rtxt_Texto.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error message: {ex.Message}\n\n" +
                        $"Detalles:\n\n{ex.StackTrace}");
                    }
                }
            }
            
            
        }

    }
}
