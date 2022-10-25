using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relojero
{
    public partial class Hora : Form
    {
        public Hora()
        {
            InitializeComponent();
            
        }
       
        /// <summary>
        /// Ejercicio punto (3-i) usa una estructura iterativa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Hora_Load(object sender, EventArgs e)
        {
            while(true)
            {
                lblHora3_1.Text = "Ejercicio 3-i - Hora y Fecha actual: " + await RetornarFechaYHora();
            }
        }

        private async Task<string> RetornarFechaYHora()
        {
            string auxiliar = await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return DateTime.Now.ToString("F");
            });
            return auxiliar;
        }

        /// <summary>
        /// Ejercicio punto (3-ii) usa el controlador ticker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void Timer_3_2_Tick(object sender, EventArgs e)
        {
            AsignarHora();
        }
        public void AsignarHora()
        {
            DateTime hora = DateTime.Now;
            lblHora3_2.Text = "Ejercicio 3-ii - Hora y Fecha actual: " + hora.ToString("F");
        }

        //ambos al mismo tiempo es el punto 3-iii

    }
}
