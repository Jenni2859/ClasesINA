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
            this.Abre_EstrControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbreConstantes
            // 
            this.AbreConstantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AbreConstantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.AbreConstantes.Location = new System.Drawing.Point(39, 110);
            this.AbreConstantes.Name = "AbreConstantes";
            this.AbreConstantes.Size = new System.Drawing.Size(204, 116);
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
            this.AbreCompuestos.Location = new System.Drawing.Point(268, 110);
            this.AbreCompuestos.Name = "AbreCompuestos";
            this.AbreCompuestos.Size = new System.Drawing.Size(252, 116);
            this.AbreCompuestos.TabIndex = 1;
            this.AbreCompuestos.Text = "Valores Compuestos";
            this.AbreCompuestos.UseVisualStyleBackColor = false;
            this.AbreCompuestos.Click += new System.EventHandler(this.AbreCompuestos_Click_1);
            // 
            // Abre_EstrControl
            // 
            this.Abre_EstrControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Abre_EstrControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.Abre_EstrControl.Location = new System.Drawing.Point(539, 110);
            this.Abre_EstrControl.Name = "Abre_EstrControl";
            this.Abre_EstrControl.Size = new System.Drawing.Size(211, 116);
            this.Abre_EstrControl.TabIndex = 2;
            this.Abre_EstrControl.Text = "Estructura de Control";
            this.Abre_EstrControl.UseVisualStyleBackColor = false;
            this.Abre_EstrControl.Click += new System.EventHandler(this.Abre_EstrControl_Click);
            // 
            // Formulario_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Abre_EstrControl);
            this.Controls.Add(this.AbreCompuestos);
            this.Controls.Add(this.AbreConstantes);
            this.Name = "Formulario_Principal";
            this.Text = "Formulario_Principal";
            this.Load += new System.EventHandler(this.Formulario_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbreConstantes;
        private System.Windows.Forms.Button AbreCompuestos;
        private System.Windows.Forms.Button Abre_EstrControl;
    }
}