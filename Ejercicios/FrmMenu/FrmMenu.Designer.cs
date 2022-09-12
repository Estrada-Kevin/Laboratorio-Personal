namespace FrmMenu
{
    partial class FrmMenu
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
            this.btn_GenerarLlamada = new System.Windows.Forms.Button();
            this.btn_FacturacionTotal = new System.Windows.Forms.Button();
            this.btn_FacturacionLocal = new System.Windows.Forms.Button();
            this.btn_FacturacionProvincial = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GenerarLlamada
            // 
            this.btn_GenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.btn_GenerarLlamada.Name = "btn_GenerarLlamada";
            this.btn_GenerarLlamada.Size = new System.Drawing.Size(214, 57);
            this.btn_GenerarLlamada.TabIndex = 0;
            this.btn_GenerarLlamada.Text = "Generar Llamada";
            this.btn_GenerarLlamada.UseVisualStyleBackColor = true;
            this.btn_GenerarLlamada.Click += new System.EventHandler(this.btn_GenerarLlamada_Click);
            // 
            // btn_FacturacionTotal
            // 
            this.btn_FacturacionTotal.Location = new System.Drawing.Point(12, 75);
            this.btn_FacturacionTotal.Name = "btn_FacturacionTotal";
            this.btn_FacturacionTotal.Size = new System.Drawing.Size(214, 57);
            this.btn_FacturacionTotal.TabIndex = 1;
            this.btn_FacturacionTotal.Text = "Facturación Total";
            this.btn_FacturacionTotal.UseVisualStyleBackColor = true;
            this.btn_FacturacionTotal.Click += new System.EventHandler(this.btn_FacturacionTotal_Click);
            // 
            // btn_FacturacionLocal
            // 
            this.btn_FacturacionLocal.Location = new System.Drawing.Point(12, 138);
            this.btn_FacturacionLocal.Name = "btn_FacturacionLocal";
            this.btn_FacturacionLocal.Size = new System.Drawing.Size(214, 57);
            this.btn_FacturacionLocal.TabIndex = 2;
            this.btn_FacturacionLocal.Text = "Facturación Local";
            this.btn_FacturacionLocal.UseVisualStyleBackColor = true;
            this.btn_FacturacionLocal.Click += new System.EventHandler(this.btn_FacturacionLocal_Click);
            // 
            // btn_FacturacionProvincial
            // 
            this.btn_FacturacionProvincial.Location = new System.Drawing.Point(12, 201);
            this.btn_FacturacionProvincial.Name = "btn_FacturacionProvincial";
            this.btn_FacturacionProvincial.Size = new System.Drawing.Size(214, 57);
            this.btn_FacturacionProvincial.TabIndex = 3;
            this.btn_FacturacionProvincial.Text = "Facturación Provincial";
            this.btn_FacturacionProvincial.UseVisualStyleBackColor = true;
            this.btn_FacturacionProvincial.Click += new System.EventHandler(this.btn_FacturacionProvincial_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(12, 264);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(214, 57);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 331);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_FacturacionProvincial);
            this.Controls.Add(this.btn_FacturacionLocal);
            this.Controls.Add(this.btn_FacturacionTotal);
            this.Controls.Add(this.btn_GenerarLlamada);
            this.Name = "FrmMenu";
            this.Text = "Central Telefónica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerarLlamada;
        private System.Windows.Forms.Button btn_FacturacionTotal;
        private System.Windows.Forms.Button btn_FacturacionLocal;
        private System.Windows.Forms.Button btn_FacturacionProvincial;
        private System.Windows.Forms.Button btn_Salir;
    }
}
