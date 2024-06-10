namespace ClasesINA.Formularios
{
    partial class Login
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtContrasennia = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.linkLabel1);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.txtContrasennia);
            this.materialCard1.Controls.Add(this.txtUsuario);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(383, 136);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(388, 231);
            this.materialCard1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(179, 184);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Crear cuenta de Usuario";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(212, 137);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(91, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "Ingresar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtContrasennia
            // 
            this.txtContrasennia.AllowPromptAsInput = true;
            this.txtContrasennia.AnimateReadOnly = false;
            this.txtContrasennia.AsciiOnly = false;
            this.txtContrasennia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContrasennia.BeepOnError = false;
            this.txtContrasennia.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasennia.Depth = 0;
            this.txtContrasennia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasennia.HidePromptOnLeave = false;
            this.txtContrasennia.HideSelection = true;
            this.txtContrasennia.Hint = "Contraseña";
            this.txtContrasennia.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtContrasennia.LeadingIcon = null;
            this.txtContrasennia.Location = new System.Drawing.Point(131, 79);
            this.txtContrasennia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtContrasennia.Mask = "";
            this.txtContrasennia.MaxLength = 32767;
            this.txtContrasennia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasennia.Name = "txtContrasennia";
            this.txtContrasennia.PasswordChar = '*';
            this.txtContrasennia.PrefixSuffixText = null;
            this.txtContrasennia.PromptChar = '_';
            this.txtContrasennia.ReadOnly = false;
            this.txtContrasennia.RejectInputOnFirstFailure = false;
            this.txtContrasennia.ResetOnPrompt = true;
            this.txtContrasennia.ResetOnSpace = true;
            this.txtContrasennia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtContrasennia.SelectedText = "";
            this.txtContrasennia.SelectionLength = 0;
            this.txtContrasennia.SelectionStart = 0;
            this.txtContrasennia.ShortcutsEnabled = true;
            this.txtContrasennia.Size = new System.Drawing.Size(240, 48);
            this.txtContrasennia.SkipLiterals = true;
            this.txtContrasennia.TabIndex = 3;
            this.txtContrasennia.TabStop = false;
            this.txtContrasennia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContrasennia.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtContrasennia.TrailingIcon = null;
            this.txtContrasennia.UseSystemPasswordChar = false;
            this.txtContrasennia.ValidatingType = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.Hint = "Ingrese su usuario";
            this.txtUsuario.Location = new System.Drawing.Point(132, 17);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(240, 46);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(47, 32);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(55, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido(a) a Store Nice";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(2, 64, 2, 3);
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Load += new System.EventHandler(this.Login_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtContrasennia;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 txtUsuario;
    }
}