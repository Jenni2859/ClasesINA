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
            this.CantidadVehiculo = new System.Windows.Forms.Label();
            this.ASC = new System.Windows.Forms.Button();
            this.DESC = new System.Windows.Forms.Button();
            this.Copia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Marcas = new System.Windows.Forms.ComboBox();
            this.Ver = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBuscaM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.tabPage1.Size = new System.Drawing.Size(558, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principiante";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage2.Controls.Add(this.Ver);
            this.tabPage2.Controls.Add(this.Marcas);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Copia);
            this.tabPage2.Controls.Add(this.DESC);
            this.tabPage2.Controls.Add(this.ASC);
            this.tabPage2.Controls.Add(this.CantidadVehiculo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.RegistrarV);
            this.tabPage2.Controls.Add(this.NameMarca);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
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
            // CantidadVehiculo
            // 
            this.CantidadVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CantidadVehiculo.Location = new System.Drawing.Point(152, 148);
            this.CantidadVehiculo.Name = "CantidadVehiculo";
            this.CantidadVehiculo.Size = new System.Drawing.Size(33, 30);
            this.CantidadVehiculo.TabIndex = 5;
            this.CantidadVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CantidadVehiculo.Click += new System.EventHandler(this.CantidadVehiculo_Click);
            // 
            // ASC
            // 
            this.ASC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ASC.Location = new System.Drawing.Point(258, 83);
            this.ASC.Name = "ASC";
            this.ASC.Size = new System.Drawing.Size(100, 30);
            this.ASC.TabIndex = 6;
            this.ASC.Text = "Ascendente";
            this.ASC.UseVisualStyleBackColor = false;
            this.ASC.Click += new System.EventHandler(this.ASC_Click);
            // 
            // DESC
            // 
            this.DESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DESC.Location = new System.Drawing.Point(258, 111);
            this.DESC.Name = "DESC";
            this.DESC.Size = new System.Drawing.Size(100, 29);
            this.DESC.TabIndex = 7;
            this.DESC.Text = "Descendente";
            this.DESC.UseVisualStyleBackColor = false;
            this.DESC.Click += new System.EventHandler(this.DESC_Click);
            // 
            // Copia
            // 
            this.Copia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Copia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Copia.Location = new System.Drawing.Point(258, 138);
            this.Copia.Name = "Copia";
            this.Copia.Size = new System.Drawing.Size(100, 32);
            this.Copia.TabIndex = 8;
            this.Copia.Text = "Copiar";
            this.Copia.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ordenar";
            // 
            // Marcas
            // 
            this.Marcas.FormattingEnabled = true;
            this.Marcas.Location = new System.Drawing.Point(364, 64);
            this.Marcas.Name = "Marcas";
            this.Marcas.Size = new System.Drawing.Size(174, 21);
            this.Marcas.TabIndex = 10;
            // 
            // Ver
            // 
            this.Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Ver.Location = new System.Drawing.Point(477, 164);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(75, 23);
            this.Ver.TabIndex = 11;
            this.Ver.Text = "Ver Marcas";
            this.Ver.UseVisualStyleBackColor = false;
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtBuscaM);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(558, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Busqueda";
            // 
            // txtBuscaM
            // 
            this.txtBuscaM.Location = new System.Drawing.Point(278, 27);
            this.txtBuscaM.Name = "txtBuscaM";
            this.txtBuscaM.Size = new System.Drawing.Size(132, 20);
            this.txtBuscaM.TabIndex = 0;
            this.txtBuscaM.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ingrese el nombre de la marca a buscar";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Image = global::ClasesINA.Properties.Resources.icons8_híbrido_100;
            this.label4.Location = new System.Drawing.Point(38, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 50);
            this.label4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Image = global::ClasesINA.Properties.Resources.loupe_217655__1_;
            this.button1.Location = new System.Drawing.Point(416, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 45);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button ASC;
        private System.Windows.Forms.Button DESC;
        private System.Windows.Forms.Button Copia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Marcas;
        private System.Windows.Forms.Button Ver;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscaM;
        private System.Windows.Forms.Button button1;
    }
}