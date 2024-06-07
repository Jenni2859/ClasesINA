namespace ClasesINA.Formularios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtDias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estructura de Control";
            // 
            // buttonIF
            // 
            this.buttonIF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonIF.Location = new System.Drawing.Point(75, 138);
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
            this.buttonSwitch.Location = new System.Drawing.Point(132, 224);
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
            this.buttonFor.Location = new System.Drawing.Point(193, 140);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtDias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dias});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtDias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtDias.Location = new System.Drawing.Point(377, 114);
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
            this.label2.Location = new System.Drawing.Point(376, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el día:";
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdd.Location = new System.Drawing.Point(501, 79);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(186, 26);
            this.txtAdd.TabIndex = 6;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Guardar.Location = new System.Drawing.Point(695, 77);
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
            this.Eliminar.Location = new System.Drawing.Point(660, 283);
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
            this.buscaDia.Location = new System.Drawing.Point(377, 282);
            this.buscaDia.Name = "buscaDia";
            this.buscaDia.Size = new System.Drawing.Size(151, 26);
            this.buscaDia.TabIndex = 9;
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Buscar.Location = new System.Drawing.Point(534, 283);
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
            this.Restaurar.Location = new System.Drawing.Point(377, 318);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(394, 28);
            this.Restaurar.TabIndex = 11;
            this.Restaurar.Text = "Restaurar Lista";
            this.Restaurar.UseVisualStyleBackColor = true;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(193, 368);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.Hint = "Nombre completo";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(380, 355);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(166, 50);
            this.materialTextBox1.TabIndex = 13;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(581, 355);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(190, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 14;
            // 
            // EstructuraDeControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialButton1);
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
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}