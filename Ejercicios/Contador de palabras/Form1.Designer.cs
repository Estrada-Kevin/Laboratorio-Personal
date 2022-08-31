namespace Contador_de_palabras
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
            this.rtxt_Palabras = new System.Windows.Forms.RichTextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_Palabras
            // 
            this.rtxt_Palabras.Location = new System.Drawing.Point(0, 0);
            this.rtxt_Palabras.Name = "rtxt_Palabras";
            this.rtxt_Palabras.Size = new System.Drawing.Size(436, 359);
            this.rtxt_Palabras.TabIndex = 0;
            this.rtxt_Palabras.Text = "";
            this.rtxt_Palabras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxt_Palabras_KeyDown);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(0, 367);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(120, 28);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "button1";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 407);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rtxt_Palabras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_Palabras;
        private System.Windows.Forms.Button btn_Calcular;
    }
}
