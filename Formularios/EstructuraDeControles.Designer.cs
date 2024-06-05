﻿namespace ClasesINA.Formularios
{
    partial class EstructuraDeControles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIF = new System.Windows.Forms.Button();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonFor = new System.Windows.Forms.Button();
            this.dtDias = new System.Windows.Forms.DataGridView();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.buscaDia = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Restaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estructura de Control";
            // 
            // buttonIF
            // 
            this.buttonIF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonIF.Location = new System.Drawing.Point(74, 86);
            this.buttonIF.Name = "buttonIF";
            this.buttonIF.Size = new System.Drawing.Size(99, 57);
            this.buttonIF.TabIndex = 1;
            this.buttonIF.Text = "IF";
            this.buttonIF.UseVisualStyleBackColor = false;
            this.buttonIF.Click += new System.EventHandler(this.buttonIF_Click);
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonSwitch.Location = new System.Drawing.Point(131, 172);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(116, 61);
            this.buttonSwitch.TabIndex = 2;
            this.buttonSwitch.Text = "SWITCH";
            this.buttonSwitch.UseVisualStyleBackColor = false;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // buttonFor
            // 
            this.buttonFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonFor.Location = new System.Drawing.Point(192, 88);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(99, 55);
            this.buttonFor.TabIndex = 3;
            this.buttonFor.Text = "FOR";
            this.buttonFor.UseVisualStyleBackColor = false;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // dtDias
            // 
            this.dtDias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dias});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtDias.Location = new System.Drawing.Point(376, 62);
            this.dtDias.Name = "dtDias";
            this.dtDias.ReadOnly = true;
            this.dtDias.Size = new System.Drawing.Size(394, 163);
            this.dtDias.TabIndex = 4;
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias de la semana";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(375, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el día:";
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdd.Location = new System.Drawing.Point(500, 27);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(186, 26);
            this.txtAdd.TabIndex = 6;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Guardar.Location = new System.Drawing.Point(694, 25);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 31);
            this.Guardar.TabIndex = 7;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Eliminar.Location = new System.Drawing.Point(659, 231);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(110, 28);
            this.Eliminar.TabIndex = 8;
            this.Eliminar.Text = "Eliminar Día";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // buscaDia
            // 
            this.buscaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buscaDia.Location = new System.Drawing.Point(376, 230);
            this.buscaDia.Name = "buscaDia";
            this.buscaDia.Size = new System.Drawing.Size(151, 26);
            this.buscaDia.TabIndex = 9;
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Buscar.Location = new System.Drawing.Point(533, 231);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(91, 29);
            this.Buscar.TabIndex = 10;
            this.Buscar.Text = "Buscar Día";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Restaurar.Location = new System.Drawing.Point(376, 266);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(394, 28);
            this.Restaurar.TabIndex = 11;
            this.Restaurar.Text = "Restaurar Lista";
            this.Restaurar.UseVisualStyleBackColor = true;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // EstructuraDeControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Restaurar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.buscaDia);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtDias);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.buttonIF);
            this.Controls.Add(this.label1);
            this.Name = "EstructuraDeControles";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EstructuraDeControles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIF;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.DataGridView dtDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox buscaDia;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Restaurar;
    }
}