namespace Atrapame_si_puedes
{
    partial class Form1
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
            this.rtxt_Historial = new System.Windows.Forms.RichTextBox();
            this.lbl_Kilometros = new System.Windows.Forms.Label();
            this.lbl_Litros = new System.Windows.Forms.Label();
            this.txt_Kilometros = new System.Windows.Forms.TextBox();
            this.txt_Litros = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_Historial
            // 
            this.rtxt_Historial.Location = new System.Drawing.Point(199, 15);
            this.rtxt_Historial.Name = "rtxt_Historial";
            this.rtxt_Historial.ReadOnly = true;
            this.rtxt_Historial.Size = new System.Drawing.Size(195, 219);
            this.rtxt_Historial.TabIndex = 0;
            this.rtxt_Historial.Text = "";
            // 
            // lbl_Kilometros
            // 
            this.lbl_Kilometros.AutoSize = true;
            this.lbl_Kilometros.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Kilometros.Location = new System.Drawing.Point(12, 15);
            this.lbl_Kilometros.Name = "lbl_Kilometros";
            this.lbl_Kilometros.Size = new System.Drawing.Size(102, 25);
            this.lbl_Kilometros.TabIndex = 1;
            this.lbl_Kilometros.Text = "Kilometros";
            // 
            // lbl_Litros
            // 
            this.lbl_Litros.AutoSize = true;
            this.lbl_Litros.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Litros.Location = new System.Drawing.Point(12, 108);
            this.lbl_Litros.Name = "lbl_Litros";
            this.lbl_Litros.Size = new System.Drawing.Size(51, 25);
            this.lbl_Litros.TabIndex = 2;
            this.lbl_Litros.Text = "Litos";
            // 
            // txt_Kilometros
            // 
            this.txt_Kilometros.Location = new System.Drawing.Point(12, 49);
            this.txt_Kilometros.Name = "txt_Kilometros";
            this.txt_Kilometros.Size = new System.Drawing.Size(122, 23);
            this.txt_Kilometros.TabIndex = 3;
            // 
            // txt_Litros
            // 
            this.txt_Litros.Location = new System.Drawing.Point(12, 143);
            this.txt_Litros.Name = "txt_Litros";
            this.txt_Litros.Size = new System.Drawing.Size(122, 23);
            this.txt_Litros.TabIndex = 4;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(12, 182);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(122, 29);
            this.btn_Calcular.TabIndex = 5;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 239);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Litros);
            this.Controls.Add(this.txt_Kilometros);
            this.Controls.Add(this.lbl_Litros);
            this.Controls.Add(this.lbl_Kilometros);
            this.Controls.Add(this.rtxt_Historial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_Historial;
        private System.Windows.Forms.Label lbl_Kilometros;
        private System.Windows.Forms.Label lbl_Litros;
        private System.Windows.Forms.TextBox txt_Kilometros;
        private System.Windows.Forms.TextBox txt_Litros;
        private System.Windows.Forms.Button btn_Calcular;
    }
}
