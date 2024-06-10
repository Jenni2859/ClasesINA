namespace ClasesINA.Formularios
{
    partial class Principal3
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
            this.NewProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.priceUnit = new MaterialSkin.Controls.MaterialTextBox();
            this.Units = new MaterialSkin.Controls.MaterialSlider();
            this.TotalPrice = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.sale = new MaterialSkin.Controls.MaterialButton();
            this.DetailSale = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadesC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new MaterialSkin.Controls.MaterialButton();
            this.agrega = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.DetailSale)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProduct
            // 
            this.NewProduct.AnimateReadOnly = false;
            this.NewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewProduct.Depth = 0;
            this.NewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NewProduct.Hint = "Nombre del producto";
            this.NewProduct.LeadingIcon = null;
            this.NewProduct.Location = new System.Drawing.Point(83, 95);
            this.NewProduct.MaxLength = 50;
            this.NewProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.NewProduct.Multiline = false;
            this.NewProduct.Name = "NewProduct";
            this.NewProduct.Size = new System.Drawing.Size(333, 50);
            this.NewProduct.TabIndex = 11;
            this.NewProduct.Text = "";
            this.NewProduct.TrailingIcon = null;
            // 
            // priceUnit
            // 
            this.priceUnit.AnimateReadOnly = false;
            this.priceUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceUnit.Depth = 0;
            this.priceUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.priceUnit.Hint = "Precio unitario";
            this.priceUnit.LeadingIcon = null;
            this.priceUnit.Location = new System.Drawing.Point(83, 167);
            this.priceUnit.MaxLength = 50;
            this.priceUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.priceUnit.Multiline = false;
            this.priceUnit.Name = "priceUnit";
            this.priceUnit.Size = new System.Drawing.Size(333, 50);
            this.priceUnit.TabIndex = 12;
            this.priceUnit.Text = "";
            this.priceUnit.TrailingIcon = null;
            this.priceUnit.Leave += new System.EventHandler(this.priceUnit_Leave);
            // 
            // Units
            // 
            this.Units.Depth = 0;
            this.Units.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Units.Location = new System.Drawing.Point(465, 95);
            this.Units.MouseState = MaterialSkin.MouseState.HOVER;
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(333, 40);
            this.Units.TabIndex = 13;
            this.Units.Text = "Unidades";
            this.Units.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.Units_onValueChanged);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AnimateReadOnly = false;
            this.TotalPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TotalPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TotalPrice.Depth = 0;
            this.TotalPrice.HideSelection = true;
            this.TotalPrice.Hint = "0.0";
            this.TotalPrice.Location = new System.Drawing.Point(465, 167);
            this.TotalPrice.MaxLength = 32767;
            this.TotalPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.PasswordChar = '\0';
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalPrice.SelectedText = "";
            this.TotalPrice.SelectionLength = 0;
            this.TotalPrice.SelectionStart = 0;
            this.TotalPrice.ShortcutsEnabled = true;
            this.TotalPrice.Size = new System.Drawing.Size(333, 50);
            this.TotalPrice.TabIndex = 14;
            this.TotalPrice.TabStop = false;
            this.TotalPrice.Text = "0";
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TotalPrice.UseSystemPasswordChar = false;
            // 
            // sale
            // 
            this.sale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sale.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.sale.Depth = 0;
            this.sale.HighEmphasis = true;
            this.sale.Icon = null;
            this.sale.Location = new System.Drawing.Point(367, 243);
            this.sale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sale.MouseState = MaterialSkin.MouseState.HOVER;
            this.sale.Name = "sale";
            this.sale.NoAccentTextColor = System.Drawing.Color.Empty;
            this.sale.Size = new System.Drawing.Size(160, 36);
            this.sale.TabIndex = 15;
            this.sale.Text = "Procesar compra";
            this.sale.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sale.UseAccentColor = false;
            this.sale.UseVisualStyleBackColor = true;
            this.sale.Click += new System.EventHandler(this.sale_Click);
            // 
            // DetailSale
            // 
            this.DetailSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioU,
            this.UnidadesC,
            this.Total});
            this.DetailSale.Location = new System.Drawing.Point(59, 310);
            this.DetailSale.Name = "DetailSale";
            this.DetailSale.Size = new System.Drawing.Size(666, 150);
            this.DetailSale.TabIndex = 16;
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
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Eliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Eliminar.Depth = 0;
            this.Eliminar.HighEmphasis = true;
            this.Eliminar.Icon = null;
            this.Eliminar.Location = new System.Drawing.Point(754, 391);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Eliminar.Size = new System.Drawing.Size(88, 36);
            this.Eliminar.TabIndex = 17;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Eliminar.UseAccentColor = false;
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // agrega
            // 
            this.agrega.AutoSize = false;
            this.agrega.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agrega.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.agrega.Depth = 0;
            this.agrega.HighEmphasis = true;
            this.agrega.Icon = null;
            this.agrega.Location = new System.Drawing.Point(754, 343);
            this.agrega.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.agrega.MouseState = MaterialSkin.MouseState.HOVER;
            this.agrega.Name = "agrega";
            this.agrega.NoAccentTextColor = System.Drawing.Color.Empty;
            this.agrega.Size = new System.Drawing.Size(88, 36);
            this.agrega.TabIndex = 18;
            this.agrega.Text = "A";
            this.agrega.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.agrega.UseAccentColor = false;
            this.agrega.UseVisualStyleBackColor = true;
            // 
            // Principal3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 508);
            this.Controls.Add(this.agrega);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.DetailSale);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.priceUnit);
            this.Controls.Add(this.NewProduct);
            this.Name = "Principal3";
            this.Text = "Principal3";
            this.Load += new System.EventHandler(this.Principal3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox NewProduct;
        private MaterialSkin.Controls.MaterialTextBox priceUnit;
        private MaterialSkin.Controls.MaterialSlider Units;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 TotalPrice;
        private MaterialSkin.Controls.MaterialButton sale;
        private System.Windows.Forms.DataGridView DetailSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadesC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private MaterialSkin.Controls.MaterialButton Eliminar;
        private MaterialSkin.Controls.MaterialButton agrega;
    }
}