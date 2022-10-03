using System;
using System.IO;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            Text = $"Compu de {Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion.Platform} {Environment.OSVersion.Version}";
            lblNombreMaquina.Text = $"Nombre de la máquina: {Environment.MachineName}";
            ConfigurarArquitectura();
            lblCantProcesadores.Text = $"Cant. procesadores lógicos {Environment.ProcessorCount}";
            lblDirectorioActual.Text = $"Identificación ejecutada en:{Environment.NewLine} {Environment.CurrentDirectory}";
            ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsMacOS())
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if(OperatingSystem.IsLinux())
            {
                picboxSistemaOperativo.Image= Properties.Resources.linux;
            }
            else
            {
                picboxSistemaOperativo.Image= Properties.Resources.windows;
            }
        }
        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura 32 bits";
            }
        }
        private void ConfigurarEspacioTotalYDisponible()
        {
            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                if(item.IsReady)
                {
                    double auxiliarEspacioTotal = item.TotalSize / 1024 / 1024 / 1024;
                    double auxiliarEspacioLibre = item.TotalFreeSpace / 1024 / 1024 / 1024;

                    lblEspacioTotal.Text = "Espacio total: " + auxiliarEspacioTotal + " Gigabytes";
                    lblEspacioDisponible.Text = "Espacio disponbile: " + auxiliarEspacioLibre + " Gigabytes";
                }
            }
        }
    }
}
