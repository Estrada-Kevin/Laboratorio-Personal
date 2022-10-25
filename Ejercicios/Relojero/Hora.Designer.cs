namespace Relojero
{
    partial class Hora
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
            this.lblHora3_1 = new System.Windows.Forms.Label();
            this.lblHora3_2 = new System.Windows.Forms.Label();
            this.Timer_3_2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHora3_1
            // 
            this.lblHora3_1.AutoSize = true;
            this.lblHora3_1.Location = new System.Drawing.Point(12, 9);
            this.lblHora3_1.Name = "lblHora3_1";
            this.lblHora3_1.Size = new System.Drawing.Size(71, 15);
            this.lblHora3_1.TabIndex = 1;
            this.lblHora3_1.Text = "Ejercicio 3-1";
            // 
            // lblHora3_2
            // 
            this.lblHora3_2.AutoSize = true;
            this.lblHora3_2.Location = new System.Drawing.Point(12, 33);
            this.lblHora3_2.Name = "lblHora3_2";
            this.lblHora3_2.Size = new System.Drawing.Size(71, 15);
            this.lblHora3_2.TabIndex = 2;
            this.lblHora3_2.Text = "Ejercicio 3-2";
            // 
            // Timer_3_2
            // 
            this.Timer_3_2.Enabled = true;
            this.Timer_3_2.Interval = 1000;
            this.Timer_3_2.Tick += new System.EventHandler(this.Timer_3_2_Tick);
            // 
            // Hora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 61);
            this.Controls.Add(this.lblHora3_2);
            this.Controls.Add(this.lblHora3_1);
            this.Name = "Hora";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHora3_1;
        private System.Windows.Forms.Label lblHora3_2;
        private System.Windows.Forms.Timer Timer_3_2;
    }
}
