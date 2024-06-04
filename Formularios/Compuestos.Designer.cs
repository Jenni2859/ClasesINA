namespace ClasesINA.Formularios
{
    partial class Compuestos
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
            this.label1 = new System.Windows.Forms.Label();
            this.Imprimir = new System.Windows.Forms.Button();
            this.CBsexo = new System.Windows.Forms.ComboBox();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(133, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores compuestos: son valores individuales que componen a un mismo objeto";
            // 
            // Imprimir
            // 
            this.Imprimir.BackColor = System.Drawing.Color.SpringGreen;
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Imprimir.Location = new System.Drawing.Point(179, 113);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(463, 65);
            this.Imprimir.TabIndex = 1;
            this.Imprimir.Text = "Imprimir por consola los valores compuestos";
            this.Imprimir.UseVisualStyleBackColor = false;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // CBsexo
            // 
            this.CBsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CBsexo.FormattingEnabled = true;
            this.CBsexo.Location = new System.Drawing.Point(179, 207);
            this.CBsexo.Name = "CBsexo";
            this.CBsexo.Size = new System.Drawing.Size(157, 32);
            this.CBsexo.TabIndex = 2;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLlenar.Location = new System.Drawing.Point(342, 207);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(175, 34);
            this.btnLlenar.TabIndex = 3;
            this.btnLlenar.Text = "Llenar ComboBox";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // Compuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.CBsexo);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.label1);
            this.Name = "Compuestos";
            this.Text = "Compuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.ComboBox CBsexo;
        private System.Windows.Forms.Button btnLlenar;
    }
}