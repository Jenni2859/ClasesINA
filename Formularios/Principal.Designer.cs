namespace ClasesINA.Formularios
{
    partial class Principal
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
            this.Producto = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.precio = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.Unidades = new MaterialSkin.Controls.MaterialSlider();
            this.Compra = new MaterialSkin.Controls.MaterialButton();
            this.TotalPrecio = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.Elimina = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Producto
            // 
            this.Producto.AnimateReadOnly = false;
            this.Producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Producto.Depth = 0;
            this.Producto.HideSelection = true;
            this.Producto.Hint = "Nombre del producto";
            this.Producto.Location = new System.Drawing.Point(65, 112);
            this.Producto.MaxLength = 32767;
            this.Producto.MouseState = MaterialSkin.MouseState.OUT;
            this.Producto.Name = "Producto";
            this.Producto.PasswordChar = '\0';
            this.Producto.ReadOnly = false;
            this.Producto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Producto.SelectedText = "";
            this.Producto.SelectionLength = 0;
            this.Producto.SelectionStart = 0;
            this.Producto.ShortcutsEnabled = true;
            this.Producto.Size = new System.Drawing.Size(250, 50);
            this.Producto.TabIndex = 0;
            this.Producto.TabStop = false;
            this.Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Producto.UseSystemPasswordChar = false;
            // 
            // precio
            // 
            this.precio.AnimateReadOnly = false;
            this.precio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.precio.Depth = 0;
            this.precio.HideSelection = true;
            this.precio.Hint = "Precio unitario";
            this.precio.Location = new System.Drawing.Point(333, 112);
            this.precio.MaxLength = 32767;
            this.precio.MouseState = MaterialSkin.MouseState.OUT;
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.ReadOnly = false;
            this.precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.precio.SelectedText = "";
            this.precio.SelectionLength = 0;
            this.precio.SelectionStart = 0;
            this.precio.ShortcutsEnabled = true;
            this.precio.Size = new System.Drawing.Size(250, 50);
            this.precio.TabIndex = 1;
            this.precio.TabStop = false;
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.precio.UseSystemPasswordChar = false;
            // 
            // Unidades
            // 
            this.Unidades.Depth = 0;
            this.Unidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Unidades.Location = new System.Drawing.Point(608, 122);
            this.Unidades.MouseState = MaterialSkin.MouseState.HOVER;
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(263, 40);
            this.Unidades.TabIndex = 2;
            this.Unidades.Text = "Unidades";
            // 
            // Compra
            // 
            this.Compra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Compra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Compra.Depth = 0;
            this.Compra.HighEmphasis = true;
            this.Compra.Icon = null;
            this.Compra.Location = new System.Drawing.Point(65, 263);
            this.Compra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Compra.MouseState = MaterialSkin.MouseState.HOVER;
            this.Compra.Name = "Compra";
            this.Compra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Compra.Size = new System.Drawing.Size(160, 36);
            this.Compra.TabIndex = 3;
            this.Compra.Text = "Procesar compra";
            this.Compra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Compra.UseAccentColor = false;
            this.Compra.UseVisualStyleBackColor = true;
            this.Compra.Click += new System.EventHandler(this.Compra_Click);
            // 
            // TotalPrecio
            // 
            this.TotalPrecio.AnimateReadOnly = false;
            this.TotalPrecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TotalPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TotalPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalPrecio.Depth = 0;
            this.TotalPrecio.HideSelection = true;
            this.TotalPrecio.Hint = "0.0";
            this.TotalPrecio.Location = new System.Drawing.Point(65, 185);
            this.TotalPrecio.MaxLength = 32767;
            this.TotalPrecio.MouseState = MaterialSkin.MouseState.OUT;
            this.TotalPrecio.Name = "TotalPrecio";
            this.TotalPrecio.PasswordChar = '\0';
            this.TotalPrecio.ReadOnly = true;
            this.TotalPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalPrecio.SelectedText = "";
            this.TotalPrecio.SelectionLength = 0;
            this.TotalPrecio.SelectionStart = 0;
            this.TotalPrecio.ShortcutsEnabled = true;
            this.TotalPrecio.Size = new System.Drawing.Size(250, 50);
            this.TotalPrecio.TabIndex = 4;
            this.TotalPrecio.TabStop = false;
            this.TotalPrecio.Text = "0";
            this.TotalPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TotalPrecio.UseSystemPasswordChar = false;
            // 
            // Elimina
            // 
            this.Elimina.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Elimina.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Elimina.Depth = 0;
            this.Elimina.HighEmphasis = true;
            this.Elimina.Icon = null;
            this.Elimina.Location = new System.Drawing.Point(783, 330);
            this.Elimina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Elimina.MouseState = MaterialSkin.MouseState.HOVER;
            this.Elimina.Name = "Elimina";
            this.Elimina.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Elimina.Size = new System.Drawing.Size(88, 36);
            this.Elimina.TabIndex = 6;
            this.Elimina.Text = "Eliminar";
            this.Elimina.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Elimina.UseAccentColor = false;
            this.Elimina.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioU,
            this.UnidadesC,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(65, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre producto";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioU
            // 
            this.PrecioU.HeaderText = "Precio Unitario";
            this.PrecioU.Name = "PrecioU";
            // 
            // UnidadesC
            // 
            this.UnidadesC.HeaderText = "Unidades Compradas";
            this.UnidadesC.Name = "UnidadesC";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total a pagar";
            this.Total.Name = "Total";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(783, 378);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(88, 36);
            this.materialButton1.TabIndex = 8;
            this.materialButton1.Text = "A";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 544);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.TotalPrecio);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.Unidades);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.Producto);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 Producto;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 precio;
        private MaterialSkin.Controls.MaterialSlider Unidades;
        private MaterialSkin.Controls.MaterialButton Compra;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TotalPrecio;
        private MaterialSkin.Controls.MaterialButton Elimina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}