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
            this.Unidades = new MaterialSkin.Controls.MaterialSlider();
            this.Compra = new MaterialSkin.Controls.MaterialButton();
            this.TotalPrecio = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.Elimina = new MaterialSkin.Controls.MaterialButton();
            this.DetalleCompra = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.precio = new MaterialSkin.Controls.MaterialTextBox();
            this.Producto = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCompra)).BeginInit();
            this.SuspendLayout();
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
            this.Unidades.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.Unidades_onValueChanged);
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
            // DetalleCompra
            // 
            this.DetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioU,
            this.UnidadesC,
            this.Total});
            this.DetalleCompra.Location = new System.Drawing.Point(65, 330);
            this.DetalleCompra.Name = "DetalleCompra";
            this.DetalleCompra.Size = new System.Drawing.Size(691, 150);
            this.DetalleCompra.TabIndex = 7;
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
            // precio
            // 
            this.precio.AnimateReadOnly = false;
            this.precio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precio.Depth = 0;
            this.precio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.precio.Hint = "Precio unitario";
            this.precio.LeadingIcon = null;
            this.precio.Location = new System.Drawing.Point(357, 112);
            this.precio.MaxLength = 50;
            this.precio.MouseState = MaterialSkin.MouseState.OUT;
            this.precio.Multiline = false;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(208, 50);
            this.precio.TabIndex = 9;
            this.precio.Text = "";
            this.precio.TrailingIcon = null;
            this.precio.Leave += new System.EventHandler(this.precio_Leave);
            // 
            // Producto
            // 
            this.Producto.AnimateReadOnly = false;
            this.Producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Producto.Depth = 0;
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Producto.Hint = "Nombre del producto";
            this.Producto.LeadingIcon = null;
            this.Producto.Location = new System.Drawing.Point(65, 111);
            this.Producto.MaxLength = 50;
            this.Producto.MouseState = MaterialSkin.MouseState.OUT;
            this.Producto.Multiline = false;
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(250, 50);
            this.Producto.TabIndex = 10;
            this.Producto.Text = "";
            this.Producto.TrailingIcon = null;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 544);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.DetalleCompra);
            this.Controls.Add(this.Elimina);
            this.Controls.Add(this.TotalPrecio);
            this.Controls.Add(this.Compra);
            this.Controls.Add(this.Unidades);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSlider Unidades;
        private MaterialSkin.Controls.MaterialButton Compra;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TotalPrecio;
        private MaterialSkin.Controls.MaterialButton Elimina;
        private System.Windows.Forms.DataGridView DetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox precio;
        private MaterialSkin.Controls.MaterialTextBox Producto;
    }
}