namespace ClasesINA.Formularios
{
    partial class CreaCuentas
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
            this.txtNewUsuario = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtNewContrasennia = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtConfirmContrasennia = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label1 = new System.Windows.Forms.Label();
            this.NewUser = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtNewUsuario
            // 
            this.txtNewUsuario.AnimateReadOnly = false;
            this.txtNewUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNewUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewUsuario.Depth = 0;
            this.txtNewUsuario.HideSelection = true;
            this.txtNewUsuario.Hint = "Usuario a Crear";
            this.txtNewUsuario.Location = new System.Drawing.Point(124, 125);
            this.txtNewUsuario.MaxLength = 32767;
            this.txtNewUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewUsuario.Name = "txtNewUsuario";
            this.txtNewUsuario.PasswordChar = '\0';
            this.txtNewUsuario.ReadOnly = false;
            this.txtNewUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewUsuario.SelectedText = "";
            this.txtNewUsuario.SelectionLength = 0;
            this.txtNewUsuario.SelectionStart = 0;
            this.txtNewUsuario.ShortcutsEnabled = true;
            this.txtNewUsuario.Size = new System.Drawing.Size(315, 49);
            this.txtNewUsuario.TabIndex = 0;
            this.txtNewUsuario.TabStop = false;
            this.txtNewUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewUsuario.UseSystemPasswordChar = false;
            // 
            // txtNewContrasennia
            // 
            this.txtNewContrasennia.AnimateReadOnly = false;
            this.txtNewContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNewContrasennia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNewContrasennia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewContrasennia.Depth = 0;
            this.txtNewContrasennia.HideSelection = true;
            this.txtNewContrasennia.Hint = "Contraseña";
            this.txtNewContrasennia.Location = new System.Drawing.Point(124, 198);
            this.txtNewContrasennia.MaxLength = 32767;
            this.txtNewContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNewContrasennia.Name = "txtNewContrasennia";
            this.txtNewContrasennia.PasswordChar = '\0';
            this.txtNewContrasennia.ReadOnly = false;
            this.txtNewContrasennia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewContrasennia.SelectedText = "";
            this.txtNewContrasennia.SelectionLength = 0;
            this.txtNewContrasennia.SelectionStart = 0;
            this.txtNewContrasennia.ShortcutsEnabled = true;
            this.txtNewContrasennia.Size = new System.Drawing.Size(315, 49);
            this.txtNewContrasennia.TabIndex = 1;
            this.txtNewContrasennia.TabStop = false;
            this.txtNewContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewContrasennia.UseSystemPasswordChar = false;
            // 
            // txtConfirmContrasennia
            // 
            this.txtConfirmContrasennia.AnimateReadOnly = false;
            this.txtConfirmContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConfirmContrasennia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConfirmContrasennia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmContrasennia.Depth = 0;
            this.txtConfirmContrasennia.HideSelection = true;
            this.txtConfirmContrasennia.Hint = "Confirmar contraseña";
            this.txtConfirmContrasennia.Location = new System.Drawing.Point(124, 274);
            this.txtConfirmContrasennia.MaxLength = 32767;
            this.txtConfirmContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConfirmContrasennia.Name = "txtConfirmContrasennia";
            this.txtConfirmContrasennia.PasswordChar = '\0';
            this.txtConfirmContrasennia.ReadOnly = false;
            this.txtConfirmContrasennia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmContrasennia.SelectedText = "";
            this.txtConfirmContrasennia.SelectionLength = 0;
            this.txtConfirmContrasennia.SelectionStart = 0;
            this.txtConfirmContrasennia.ShortcutsEnabled = true;
            this.txtConfirmContrasennia.Size = new System.Drawing.Size(315, 49);
            this.txtConfirmContrasennia.TabIndex = 2;
            this.txtConfirmContrasennia.TabStop = false;
            this.txtConfirmContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmContrasennia.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(120, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Creación de Cuenta";
            // 
            // NewUser
            // 
            this.NewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.NewUser.Depth = 0;
            this.NewUser.HighEmphasis = true;
            this.NewUser.Icon = null;
            this.NewUser.Location = new System.Drawing.Point(281, 332);
            this.NewUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NewUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.NewUser.Name = "NewUser";
            this.NewUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.NewUser.Size = new System.Drawing.Size(158, 36);
            this.NewUser.TabIndex = 4;
            this.NewUser.Text = "Crear cuenta";
            this.NewUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NewUser.UseAccentColor = false;
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // CreaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmContrasennia);
            this.Controls.Add(this.txtNewContrasennia);
            this.Controls.Add(this.txtNewUsuario);
            this.Name = "CreaCuentas";
            this.Text = "CreaCuentas";
            this.Load += new System.EventHandler(this.CreaCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNewUsuario;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtNewContrasennia;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtConfirmContrasennia;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton NewUser;
    }
}