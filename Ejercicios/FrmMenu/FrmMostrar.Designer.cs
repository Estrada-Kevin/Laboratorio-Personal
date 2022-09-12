namespace FrmMenu
{
    partial class FrmMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxt_Mostrador = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxt_Mostrador
            // 
            this.rtxt_Mostrador.Location = new System.Drawing.Point(1, 1);
            this.rtxt_Mostrador.Name = "rtxt_Mostrador";
            this.rtxt_Mostrador.Size = new System.Drawing.Size(600, 376);
            this.rtxt_Mostrador.TabIndex = 0;
            this.rtxt_Mostrador.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 377);
            this.Controls.Add(this.rtxt_Mostrador);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.Load += new System.EventHandler(this.FrmMostrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_Mostrador;
    }
}