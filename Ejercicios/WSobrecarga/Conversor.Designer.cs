namespace WSobrecarga
{
    partial class Conversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversor));
            this.lbl_Euro1 = new System.Windows.Forms.Label();
            this.lbl_Dolar1 = new System.Windows.Forms.Label();
            this.lbl_Peso1 = new System.Windows.Forms.Label();
            this.btn_ConvertEuro = new System.Windows.Forms.Button();
            this.btn_ConvertDolar = new System.Windows.Forms.Button();
            this.btn_ConvertPeso = new System.Windows.Forms.Button();
            this.btn_LockCotizacion = new System.Windows.Forms.Button();
            this.locker = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Cotizacion = new System.Windows.Forms.Label();
            this.txt_Euro = new System.Windows.Forms.TextBox();
            this.txt_Dolar = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.txt_CotizacionEuro = new System.Windows.Forms.TextBox();
            this.txt_CotizacionDolar = new System.Windows.Forms.TextBox();
            this.txt_CotizacionPeso = new System.Windows.Forms.TextBox();
            this.txt_EuroAEuro = new System.Windows.Forms.TextBox();
            this.txt_EuroADolar = new System.Windows.Forms.TextBox();
            this.txt_EuroAPeso = new System.Windows.Forms.TextBox();
            this.txt_DolarAEuro = new System.Windows.Forms.TextBox();
            this.txt_DolarADolar = new System.Windows.Forms.TextBox();
            this.txt_DolarAPeso = new System.Windows.Forms.TextBox();
            this.txt_PesoAEuro = new System.Windows.Forms.TextBox();
            this.txt_PesoADolar = new System.Windows.Forms.TextBox();
            this.txt_PesoAPeso = new System.Windows.Forms.TextBox();
            this.lbl_Euro2 = new System.Windows.Forms.Label();
            this.lbl_Dolar2 = new System.Windows.Forms.Label();
            this.lbl_Peso2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Euro1
            // 
            this.lbl_Euro1.AutoSize = true;
            this.lbl_Euro1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Euro1.Location = new System.Drawing.Point(34, 80);
            this.lbl_Euro1.Name = "lbl_Euro1";
            this.lbl_Euro1.Size = new System.Drawing.Size(41, 19);
            this.lbl_Euro1.TabIndex = 8;
            this.lbl_Euro1.Text = "Euro";
            // 
            // lbl_Dolar1
            // 
            this.lbl_Dolar1.AutoSize = true;
            this.lbl_Dolar1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dolar1.Location = new System.Drawing.Point(34, 124);
            this.lbl_Dolar1.Name = "lbl_Dolar1";
            this.lbl_Dolar1.Size = new System.Drawing.Size(46, 19);
            this.lbl_Dolar1.TabIndex = 14;
            this.lbl_Dolar1.Text = "Dolar";
            // 
            // lbl_Peso1
            // 
            this.lbl_Peso1.AutoSize = true;
            this.lbl_Peso1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Peso1.Location = new System.Drawing.Point(34, 170);
            this.lbl_Peso1.Name = "lbl_Peso1";
            this.lbl_Peso1.Size = new System.Drawing.Size(41, 19);
            this.lbl_Peso1.TabIndex = 20;
            this.lbl_Peso1.Text = "Peso";
            // 
            // btn_ConvertEuro
            // 
            this.btn_ConvertEuro.Location = new System.Drawing.Point(179, 75);
            this.btn_ConvertEuro.Name = "btn_ConvertEuro";
            this.btn_ConvertEuro.Size = new System.Drawing.Size(76, 23);
            this.btn_ConvertEuro.TabIndex = 10;
            this.btn_ConvertEuro.Text = "->";
            this.btn_ConvertEuro.UseVisualStyleBackColor = true;
            this.btn_ConvertEuro.Click += new System.EventHandler(this.btn_ConvertEuro_Click);
            // 
            // btn_ConvertDolar
            // 
            this.btn_ConvertDolar.Location = new System.Drawing.Point(179, 119);
            this.btn_ConvertDolar.Name = "btn_ConvertDolar";
            this.btn_ConvertDolar.Size = new System.Drawing.Size(76, 23);
            this.btn_ConvertDolar.TabIndex = 16;
            this.btn_ConvertDolar.Text = "->";
            this.btn_ConvertDolar.UseVisualStyleBackColor = true;
            this.btn_ConvertDolar.Click += new System.EventHandler(this.btn_ConvertDolar_Click);
            // 
            // btn_ConvertPeso
            // 
            this.btn_ConvertPeso.Location = new System.Drawing.Point(179, 165);
            this.btn_ConvertPeso.Name = "btn_ConvertPeso";
            this.btn_ConvertPeso.Size = new System.Drawing.Size(76, 23);
            this.btn_ConvertPeso.TabIndex = 22;
            this.btn_ConvertPeso.Text = "->";
            this.btn_ConvertPeso.UseVisualStyleBackColor = true;
            this.btn_ConvertPeso.Click += new System.EventHandler(this.btn_ConvertPeso_Click);
            // 
            // btn_LockCotizacion
            // 
            this.btn_LockCotizacion.AutoSize = true;
            this.btn_LockCotizacion.ImageIndex = 0;
            this.btn_LockCotizacion.ImageList = this.locker;
            this.btn_LockCotizacion.Location = new System.Drawing.Point(179, 23);
            this.btn_LockCotizacion.Name = "btn_LockCotizacion";
            this.btn_LockCotizacion.Size = new System.Drawing.Size(75, 31);
            this.btn_LockCotizacion.TabIndex = 1;
            this.btn_LockCotizacion.Text = "\r\n";
            this.btn_LockCotizacion.UseVisualStyleBackColor = true;
            this.btn_LockCotizacion.Click += new System.EventHandler(this.btn_LockCotizacion_Click);
            // 
            // locker
            // 
            this.locker.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.locker.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("locker.ImageStream")));
            this.locker.TransparentColor = System.Drawing.Color.Transparent;
            this.locker.Images.SetKeyName(0, "lock.jpg");
            this.locker.Images.SetKeyName(1, "unlock.png");
            // 
            // lbl_Cotizacion
            // 
            this.lbl_Cotizacion.AutoSize = true;
            this.lbl_Cotizacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cotizacion.Location = new System.Drawing.Point(82, 23);
            this.lbl_Cotizacion.Name = "lbl_Cotizacion";
            this.lbl_Cotizacion.Size = new System.Drawing.Size(78, 19);
            this.lbl_Cotizacion.TabIndex = 0;
            this.lbl_Cotizacion.Text = "Cotizacion";
            // 
            // txt_Euro
            // 
            this.txt_Euro.Location = new System.Drawing.Point(82, 76);
            this.txt_Euro.Name = "txt_Euro";
            this.txt_Euro.Size = new System.Drawing.Size(91, 23);
            this.txt_Euro.TabIndex = 9;
            // 
            // txt_Dolar
            // 
            this.txt_Dolar.Location = new System.Drawing.Point(81, 120);
            this.txt_Dolar.Name = "txt_Dolar";
            this.txt_Dolar.Size = new System.Drawing.Size(92, 23);
            this.txt_Dolar.TabIndex = 15;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(81, 166);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(92, 23);
            this.txt_Peso.TabIndex = 21;
            // 
            // txt_CotizacionEuro
            // 
            this.txt_CotizacionEuro.Location = new System.Drawing.Point(261, 22);
            this.txt_CotizacionEuro.Name = "txt_CotizacionEuro";
            this.txt_CotizacionEuro.ReadOnly = true;
            this.txt_CotizacionEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_CotizacionEuro.TabIndex = 2;
            // 
            // txt_CotizacionDolar
            // 
            this.txt_CotizacionDolar.Location = new System.Drawing.Point(367, 22);
            this.txt_CotizacionDolar.Name = "txt_CotizacionDolar";
            this.txt_CotizacionDolar.ReadOnly = true;
            this.txt_CotizacionDolar.Size = new System.Drawing.Size(100, 23);
            this.txt_CotizacionDolar.TabIndex = 3;
            // 
            // txt_CotizacionPeso
            // 
            this.txt_CotizacionPeso.Location = new System.Drawing.Point(473, 23);
            this.txt_CotizacionPeso.Name = "txt_CotizacionPeso";
            this.txt_CotizacionPeso.ReadOnly = true;
            this.txt_CotizacionPeso.Size = new System.Drawing.Size(100, 23);
            this.txt_CotizacionPeso.TabIndex = 4;
            // 
            // txt_EuroAEuro
            // 
            this.txt_EuroAEuro.Location = new System.Drawing.Point(261, 76);
            this.txt_EuroAEuro.Name = "txt_EuroAEuro";
            this.txt_EuroAEuro.ReadOnly = true;
            this.txt_EuroAEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_EuroAEuro.TabIndex = 11;
            // 
            // txt_EuroADolar
            // 
            this.txt_EuroADolar.Location = new System.Drawing.Point(367, 75);
            this.txt_EuroADolar.Name = "txt_EuroADolar";
            this.txt_EuroADolar.ReadOnly = true;
            this.txt_EuroADolar.Size = new System.Drawing.Size(100, 23);
            this.txt_EuroADolar.TabIndex = 12;
            // 
            // txt_EuroAPeso
            // 
            this.txt_EuroAPeso.Location = new System.Drawing.Point(473, 76);
            this.txt_EuroAPeso.Name = "txt_EuroAPeso";
            this.txt_EuroAPeso.ReadOnly = true;
            this.txt_EuroAPeso.Size = new System.Drawing.Size(100, 23);
            this.txt_EuroAPeso.TabIndex = 13;
            // 
            // txt_DolarAEuro
            // 
            this.txt_DolarAEuro.Location = new System.Drawing.Point(261, 120);
            this.txt_DolarAEuro.Name = "txt_DolarAEuro";
            this.txt_DolarAEuro.ReadOnly = true;
            this.txt_DolarAEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_DolarAEuro.TabIndex = 17;
            // 
            // txt_DolarADolar
            // 
            this.txt_DolarADolar.Location = new System.Drawing.Point(367, 120);
            this.txt_DolarADolar.Name = "txt_DolarADolar";
            this.txt_DolarADolar.ReadOnly = true;
            this.txt_DolarADolar.Size = new System.Drawing.Size(100, 23);
            this.txt_DolarADolar.TabIndex = 18;
            // 
            // txt_DolarAPeso
            // 
            this.txt_DolarAPeso.Location = new System.Drawing.Point(473, 120);
            this.txt_DolarAPeso.Name = "txt_DolarAPeso";
            this.txt_DolarAPeso.ReadOnly = true;
            this.txt_DolarAPeso.Size = new System.Drawing.Size(100, 23);
            this.txt_DolarAPeso.TabIndex = 19;
            // 
            // txt_PesoAEuro
            // 
            this.txt_PesoAEuro.Location = new System.Drawing.Point(261, 165);
            this.txt_PesoAEuro.Name = "txt_PesoAEuro";
            this.txt_PesoAEuro.ReadOnly = true;
            this.txt_PesoAEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_PesoAEuro.TabIndex = 23;
            // 
            // txt_PesoADolar
            // 
            this.txt_PesoADolar.Location = new System.Drawing.Point(367, 165);
            this.txt_PesoADolar.Name = "txt_PesoADolar";
            this.txt_PesoADolar.ReadOnly = true;
            this.txt_PesoADolar.Size = new System.Drawing.Size(100, 23);
            this.txt_PesoADolar.TabIndex = 24;
            // 
            // txt_PesoAPeso
            // 
            this.txt_PesoAPeso.Location = new System.Drawing.Point(473, 166);
            this.txt_PesoAPeso.Name = "txt_PesoAPeso";
            this.txt_PesoAPeso.ReadOnly = true;
            this.txt_PesoAPeso.Size = new System.Drawing.Size(100, 23);
            this.txt_PesoAPeso.TabIndex = 25;
            // 
            // lbl_Euro2
            // 
            this.lbl_Euro2.AutoSize = true;
            this.lbl_Euro2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Euro2.Location = new System.Drawing.Point(290, 52);
            this.lbl_Euro2.Name = "lbl_Euro2";
            this.lbl_Euro2.Size = new System.Drawing.Size(41, 19);
            this.lbl_Euro2.TabIndex = 5;
            this.lbl_Euro2.Text = "Euro";
            // 
            // lbl_Dolar2
            // 
            this.lbl_Dolar2.AutoSize = true;
            this.lbl_Dolar2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dolar2.Location = new System.Drawing.Point(395, 52);
            this.lbl_Dolar2.Name = "lbl_Dolar2";
            this.lbl_Dolar2.Size = new System.Drawing.Size(46, 19);
            this.lbl_Dolar2.TabIndex = 6;
            this.lbl_Dolar2.Text = "Dolar";
            // 
            // lbl_Peso2
            // 
            this.lbl_Peso2.AutoSize = true;
            this.lbl_Peso2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Peso2.Location = new System.Drawing.Point(502, 52);
            this.lbl_Peso2.Name = "lbl_Peso2";
            this.lbl_Peso2.Size = new System.Drawing.Size(41, 19);
            this.lbl_Peso2.TabIndex = 7;
            this.lbl_Peso2.Text = "Peso";
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 226);
            this.Controls.Add(this.lbl_Peso2);
            this.Controls.Add(this.lbl_Dolar2);
            this.Controls.Add(this.lbl_Euro2);
            this.Controls.Add(this.txt_PesoAPeso);
            this.Controls.Add(this.txt_PesoADolar);
            this.Controls.Add(this.txt_PesoAEuro);
            this.Controls.Add(this.txt_DolarAPeso);
            this.Controls.Add(this.txt_DolarADolar);
            this.Controls.Add(this.txt_DolarAEuro);
            this.Controls.Add(this.txt_EuroAPeso);
            this.Controls.Add(this.txt_EuroADolar);
            this.Controls.Add(this.txt_EuroAEuro);
            this.Controls.Add(this.txt_CotizacionPeso);
            this.Controls.Add(this.txt_CotizacionDolar);
            this.Controls.Add(this.txt_CotizacionEuro);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.txt_Dolar);
            this.Controls.Add(this.txt_Euro);
            this.Controls.Add(this.lbl_Cotizacion);
            this.Controls.Add(this.btn_LockCotizacion);
            this.Controls.Add(this.btn_ConvertPeso);
            this.Controls.Add(this.btn_ConvertDolar);
            this.Controls.Add(this.btn_ConvertEuro);
            this.Controls.Add(this.lbl_Peso1);
            this.Controls.Add(this.lbl_Dolar1);
            this.Controls.Add(this.lbl_Euro1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Conversor";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Euro1;
        private System.Windows.Forms.Label lbl_Dolar1;
        private System.Windows.Forms.Label lbl_Peso1;
        private System.Windows.Forms.Button btn_ConvertEuro;
        private System.Windows.Forms.Button btn_ConvertDolar;
        private System.Windows.Forms.Button btn_ConvertPeso;
        private System.Windows.Forms.Button btn_LockCotizacion;
        private System.Windows.Forms.Label lbl_Cotizacion;
        private System.Windows.Forms.TextBox txt_Euro;
        private System.Windows.Forms.TextBox txt_Dolar;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.TextBox txt_CotizacionEuro;
        private System.Windows.Forms.TextBox txt_CotizacionDolar;
        private System.Windows.Forms.TextBox txt_CotizacionPeso;
        private System.Windows.Forms.TextBox txt_EuroAEuro;
        private System.Windows.Forms.TextBox txt_EuroADolar;
        private System.Windows.Forms.TextBox txt_EuroAPeso;
        private System.Windows.Forms.TextBox txt_DolarAEuro;
        private System.Windows.Forms.TextBox txt_DolarADolar;
        private System.Windows.Forms.TextBox txt_DolarAPeso;
        private System.Windows.Forms.TextBox txt_PesoAEuro;
        private System.Windows.Forms.TextBox txt_PesoADolar;
        private System.Windows.Forms.TextBox txt_PesoAPeso;
        private System.Windows.Forms.Label lbl_Euro2;
        private System.Windows.Forms.Label lbl_Dolar2;
        private System.Windows.Forms.Label lbl_Peso2;
        private System.Windows.Forms.ImageList locker;
    }
}
