namespace ClasesINA.NewFolder1
{
    partial class Constantes
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
            this.lblConstante = new System.Windows.Forms.Label();
            this.lblValorConstante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConstante
            // 
            this.lblConstante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblConstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblConstante.Location = new System.Drawing.Point(81, 113);
            this.lblConstante.Name = "lblConstante";
            this.lblConstante.Size = new System.Drawing.Size(410, 43);
            this.lblConstante.TabIndex = 0;
            this.lblConstante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorConstante
            // 
            this.lblValorConstante.BackColor = System.Drawing.Color.Yellow;
            this.lblValorConstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblValorConstante.Location = new System.Drawing.Point(81, 51);
            this.lblValorConstante.Name = "lblValorConstante";
            this.lblValorConstante.Size = new System.Drawing.Size(410, 59);
            this.lblValorConstante.TabIndex = 1;
            this.lblValorConstante.Text = "Mostrar valor de la constante";
            this.lblValorConstante.UseVisualStyleBackColor = false;
            this.lblValorConstante.Click += new System.EventHandler(this.lblValorConstante_Click);
            // 
            // Constantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValorConstante);
            this.Controls.Add(this.lblConstante);
            this.Name = "Constantes";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConstante;
        private System.Windows.Forms.Button lblValorConstante;
    }
}