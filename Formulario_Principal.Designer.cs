namespace ClasesINA
{
    partial class Formulario_Principal
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
            this.AbreConstantes = new System.Windows.Forms.Button();
            this.AbreCompuestos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbreConstantes
            // 
            this.AbreConstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbreConstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.AbreConstantes.Location = new System.Drawing.Point(164, 83);
            this.AbreConstantes.Name = "AbreConstantes";
            this.AbreConstantes.Size = new System.Drawing.Size(162, 53);
            this.AbreConstantes.TabIndex = 0;
            this.AbreConstantes.Text = "Constantes";
            this.AbreConstantes.UseVisualStyleBackColor = false;
            this.AbreConstantes.Click += new System.EventHandler(this.AbreConstantes_Click);
            // 
            // AbreCompuestos
            // 
            this.AbreCompuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbreCompuestos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AbreCompuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.AbreCompuestos.Location = new System.Drawing.Point(383, 85);
            this.AbreCompuestos.Name = "AbreCompuestos";
            this.AbreCompuestos.Size = new System.Drawing.Size(284, 49);
            this.AbreCompuestos.TabIndex = 1;
            this.AbreCompuestos.Text = "Valores Compuestos";
            this.AbreCompuestos.UseVisualStyleBackColor = false;
            this.AbreCompuestos.Click += new System.EventHandler(this.AbreCompuestos_Click);
            // 
            // Formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AbreCompuestos);
            this.Controls.Add(this.AbreConstantes);
            this.Name = "Formulario_Principal";
            this.Text = "Formulario_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbreConstantes;
        private System.Windows.Forms.Button AbreCompuestos;
    }
}