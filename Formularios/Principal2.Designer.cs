namespace ClasesINA.Formularios
{
    partial class Principal2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaciónToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarProductosToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaDeUsuarioToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // facturarProductosToolStripMenuItem
            // 
            this.facturarProductosToolStripMenuItem.Image = global::ClasesINA.Properties.Resources.factura;
            this.facturarProductosToolStripMenuItem.Name = "facturarProductosToolStripMenuItem";
            this.facturarProductosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturarProductosToolStripMenuItem.Text = "Facturar productos";
            this.facturarProductosToolStripMenuItem.Click += new System.EventHandler(this.facturarProductosToolStripMenuItem_Click);
            // 
            // crearCuentaDeUsuarioToolStripMenuItem
            // 
            this.crearCuentaDeUsuarioToolStripMenuItem.Image = global::ClasesINA.Properties.Resources.usuario;
            this.crearCuentaDeUsuarioToolStripMenuItem.Name = "crearCuentaDeUsuarioToolStripMenuItem";
            this.crearCuentaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.crearCuentaDeUsuarioToolStripMenuItem.Text = "Crear cuenta de usuario";
            this.crearCuentaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaDeUsuarioToolStripMenuItem_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSize = true;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 24);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(873, 483);
            this.Contenedor.TabIndex = 1;
            // 
            // Principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 507);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal2";
            this.Text = "Principal2";
            this.Load += new System.EventHandler(this.Principal2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Panel Contenedor;
    }
}