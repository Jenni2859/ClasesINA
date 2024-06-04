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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.NameMarca = new System.Windows.Forms.TextBox();
            this.RegistrarV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadVehiculo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Imprimir.Location = new System.Drawing.Point(10, 6);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(463, 45);
            this.Imprimir.TabIndex = 1;
            this.Imprimir.Text = "Imprimir por consola los valores compuestos";
            this.Imprimir.UseVisualStyleBackColor = false;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // CBsexo
            // 
            this.CBsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CBsexo.FormattingEnabled = true;
            this.CBsexo.Location = new System.Drawing.Point(10, 57);
            this.CBsexo.Name = "CBsexo";
            this.CBsexo.Size = new System.Drawing.Size(157, 32);
            this.CBsexo.TabIndex = 2;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLlenar.Location = new System.Drawing.Point(173, 57);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(175, 34);
            this.btnLlenar.TabIndex = 3;
            this.btnLlenar.Text = "Llenar ComboBox";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(137, 140);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 219);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cyan;
            this.tabPage1.Controls.Add(this.Imprimir);
            this.tabPage1.Controls.Add(this.btnLlenar);
            this.tabPage1.Controls.Add(this.CBsexo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(558, 171);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principiante";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.Controls.Add(this.CantidadVehiculo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.RegistrarV);
            this.tabPage2.Controls.Add(this.NameMarca);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(558, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Avanzado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese el nombre de la marca del vehiculo";
            // 
            // NameMarca
            // 
            this.NameMarca.Location = new System.Drawing.Point(296, 29);
            this.NameMarca.Name = "NameMarca";
            this.NameMarca.Size = new System.Drawing.Size(159, 20);
            this.NameMarca.TabIndex = 1;
            // 
            // RegistrarV
            // 
            this.RegistrarV.BackColor = System.Drawing.Color.Yellow;
            this.RegistrarV.Location = new System.Drawing.Point(463, 27);
            this.RegistrarV.Name = "RegistrarV";
            this.RegistrarV.Size = new System.Drawing.Size(75, 23);
            this.RegistrarV.TabIndex = 2;
            this.RegistrarV.Text = "Registrar";
            this.RegistrarV.UseVisualStyleBackColor = false;
            this.RegistrarV.Click += new System.EventHandler(this.RegistrarV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(23, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad Vehiculos";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Image = global::ClasesINA.Properties.Resources.icons8_híbrido_100;
            this.label4.Location = new System.Drawing.Point(32, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 50);
            this.label4.TabIndex = 4;
            // 
            // CantidadVehiculo
            // 
            this.CantidadVehiculo.AutoSize = true;
            this.CantidadVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CantidadVehiculo.Location = new System.Drawing.Point(179, 157);
            this.CantidadVehiculo.Name = "CantidadVehiculo";
            this.CantidadVehiculo.Size = new System.Drawing.Size(51, 20);
            this.CantidadVehiculo.TabIndex = 5;
            this.CantidadVehiculo.Text = "label5";
            // 
            // Compuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Compuestos";
            this.Text = "Compuestos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.ComboBox CBsexo;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegistrarV;
        private System.Windows.Forms.TextBox NameMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CantidadVehiculo;
    }
}