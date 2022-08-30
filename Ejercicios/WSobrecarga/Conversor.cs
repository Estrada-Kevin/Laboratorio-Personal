using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sobrecarga;

namespace WSobrecarga
{
    public partial class Conversor : Form
    {
        private int indice;
        Euro e1;
        Dolar d1;
        Peso p1;


        public Conversor()
        {
            InitializeComponent();
            indice = 0;

        }

        private void Conversor_Load(object sender, EventArgs e)
        {
            txt_CotizacionPeso.Text = Peso.GetCotizacion().ToString("0.###");
            txt_CotizacionDolar.Text = Dolar.GetCotizacion().ToString("0.###");
            txt_CotizacionEuro.Text = Euro.GetCotizacion().ToString("0.###");

        }

        private void btn_LockCotizacion_Click(object sender, EventArgs e)
        {
            #region indice 
            indice++;
            if (indice > 1)
            {
                indice = 0;
            }
            btn_LockCotizacion.ImageIndex = indice;
            #endregion

            if (indice == 0)
            {
                txt_CotizacionDolar.ReadOnly = true;
                txt_CotizacionEuro.ReadOnly = true;
                txt_CotizacionPeso.ReadOnly = true;

            }
            else if(indice == 1)
            {
                txt_CotizacionDolar.ReadOnly = false;
                txt_CotizacionEuro.ReadOnly = false;
                txt_CotizacionPeso.ReadOnly = false;

            }


        }

        private void btn_ConvertEuro_Click(object sender, EventArgs e)
        {
            double.TryParse(txt_Euro.Text, out double auxiliar);
            e1 = new Euro(auxiliar, Euro.GetCotizacion());
            txt_EuroAEuro.Text = e1.GetCantidad().ToString();
            txt_EuroADolar.Text = ((Dolar)e1).GetCantidad().ToString("0.##");
            txt_EuroAPeso.Text = ((Peso)e1).GetCantidad().ToString("0.##");
        }

        private void btn_ConvertDolar_Click(object sender, EventArgs e)
        {
            double.TryParse(txt_Dolar.Text, out double auxiliar);
            d1 = new Dolar(auxiliar);
            txt_DolarAEuro.Text = ((Euro)d1).GetCantidad().ToString("0.##");
            txt_DolarADolar.Text = d1.GetCantidad().ToString();
            txt_DolarAPeso.Text = ((Peso)d1).GetCantidad().ToString("0.##");
        }

        private void btn_ConvertPeso_Click(object sender, EventArgs e)
        {
            double.TryParse(txt_Peso.Text, out double auxiliar);
            p1 = new Peso(auxiliar);
            txt_PesoAEuro.Text = ((Euro)p1).GetCantidad().ToString("0.##");
            txt_PesoADolar.Text = ((Dolar)p1).GetCantidad().ToString("0.##");
            txt_PesoAPeso.Text = p1.GetCantidad().ToString();

        }

        private void txt_CotizacionDolar_Leave(object sender, EventArgs e)
        {
            if(txt_CotizacionDolar.Text != "1")
            {
                MessageBox.Show("La cotización del dolar debe ser igual a 1");
                txt_CotizacionDolar.Focus();
            }
        }

        private void txt_CotizacionEuro_Leave(object sender, EventArgs e)
        {
            if (txt_CotizacionEuro.ReadOnly == false)
            {
                
                double.TryParse(txt_CotizacionEuro.Text, out double auxiliar1);
                Euro.SetCotizacion(auxiliar1);
            }
        }

        private void txt_CotizacionPeso_Leave(object sender, EventArgs e)
        {
            if (txt_CotizacionEuro.ReadOnly == false)
            {
                double.TryParse(txt_CotizacionPeso.Text, out double auxiliar);
                Peso.SetCotizacion(auxiliar);
            }
        }
    }
    
}
