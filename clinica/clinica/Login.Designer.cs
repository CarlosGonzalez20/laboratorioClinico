namespace clinica
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
            this.ingresar = new MaterialSkin.Controls.MaterialButton();
            this.tipoUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.areaUsuario = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.usuario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.contraseña = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.cambiarContraseña = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ingresar
            // 
            this.ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresar.Depth = 0;
            this.ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ingresar.HighEmphasis = true;
            this.ingresar.Icon = null;
            this.ingresar.Location = new System.Drawing.Point(196, 343);
            this.ingresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresar.Name = "ingresar";
            this.ingresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresar.Size = new System.Drawing.Size(91, 36);
            this.ingresar.TabIndex = 7;
            this.ingresar.Text = "Ingresar";
            this.ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresar.UseAccentColor = false;
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.AutoResize = false;
            this.tipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoUsuario.Depth = 0;
            this.tipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tipoUsuario.DropDownHeight = 174;
            this.tipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoUsuario.DropDownWidth = 121;
            this.tipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tipoUsuario.FormattingEnabled = true;
            this.tipoUsuario.IntegralHeight = false;
            this.tipoUsuario.ItemHeight = 43;
            this.tipoUsuario.Location = new System.Drawing.Point(346, 141);
            this.tipoUsuario.MaxDropDownItems = 4;
            this.tipoUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(242, 49);
            this.tipoUsuario.StartIndex = 0;
            this.tipoUsuario.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(343, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(111, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Tipo de usuario";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(343, 223);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Área";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // areaUsuario
            // 
            this.areaUsuario.AutoResize = false;
            this.areaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.areaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.areaUsuario.Depth = 0;
            this.areaUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.areaUsuario.DropDownHeight = 174;
            this.areaUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areaUsuario.DropDownWidth = 121;
            this.areaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.areaUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.areaUsuario.FormattingEnabled = true;
            this.areaUsuario.IntegralHeight = false;
            this.areaUsuario.ItemHeight = 43;
            this.areaUsuario.Location = new System.Drawing.Point(346, 258);
            this.areaUsuario.MaxDropDownItems = 4;
            this.areaUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.areaUsuario.Name = "areaUsuario";
            this.areaUsuario.Size = new System.Drawing.Size(242, 49);
            this.areaUsuario.StartIndex = 0;
            this.areaUsuario.TabIndex = 10;
            this.areaUsuario.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(34, 111);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Usuario o Correo";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // usuario
            // 
            this.usuario.AllowPromptAsInput = true;
            this.usuario.AnimateReadOnly = false;
            this.usuario.AsciiOnly = false;
            this.usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usuario.BeepOnError = false;
            this.usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usuario.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.usuario.Depth = 0;
            this.usuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usuario.HidePromptOnLeave = false;
            this.usuario.HideSelection = true;
            this.usuario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.usuario.LeadingIcon = null;
            this.usuario.Location = new System.Drawing.Point(37, 142);
            this.usuario.Mask = "";
            this.usuario.MaxLength = 32767;
            this.usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.usuario.Name = "usuario";
            this.usuario.PasswordChar = '\0';
            this.usuario.PrefixSuffixText = null;
            this.usuario.PromptChar = '_';
            this.usuario.ReadOnly = false;
            this.usuario.RejectInputOnFirstFailure = false;
            this.usuario.ResetOnPrompt = true;
            this.usuario.ResetOnSpace = true;
            this.usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usuario.SelectedText = "";
            this.usuario.SelectionLength = 0;
            this.usuario.SelectionStart = 0;
            this.usuario.ShortcutsEnabled = true;
            this.usuario.Size = new System.Drawing.Size(250, 48);
            this.usuario.SkipLiterals = true;
            this.usuario.TabIndex = 13;
            this.usuario.TabStop = false;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.usuario.TrailingIcon = null;
            this.usuario.UseSystemPasswordChar = false;
            this.usuario.ValidatingType = null;
            // 
            // contraseña
            // 
            this.contraseña.AllowPromptAsInput = true;
            this.contraseña.AnimateReadOnly = false;
            this.contraseña.AsciiOnly = false;
            this.contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contraseña.BeepOnError = false;
            this.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.contraseña.Depth = 0;
            this.contraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.contraseña.HidePromptOnLeave = false;
            this.contraseña.HideSelection = true;
            this.contraseña.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.contraseña.LeadingIcon = null;
            this.contraseña.Location = new System.Drawing.Point(37, 258);
            this.contraseña.Mask = "";
            this.contraseña.MaxLength = 32767;
            this.contraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '\0';
            this.contraseña.PrefixSuffixText = null;
            this.contraseña.PromptChar = '_';
            this.contraseña.ReadOnly = false;
            this.contraseña.RejectInputOnFirstFailure = false;
            this.contraseña.ResetOnPrompt = true;
            this.contraseña.ResetOnSpace = true;
            this.contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contraseña.SelectedText = "";
            this.contraseña.SelectionLength = 0;
            this.contraseña.SelectionStart = 0;
            this.contraseña.ShortcutsEnabled = true;
            this.contraseña.Size = new System.Drawing.Size(250, 48);
            this.contraseña.SkipLiterals = true;
            this.contraseña.TabIndex = 15;
            this.contraseña.TabStop = false;
            this.contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contraseña.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.contraseña.TrailingIcon = null;
            this.contraseña.UseSystemPasswordChar = false;
            this.contraseña.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(34, 227);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Contraseña";
            // 
            // cambiarContraseña
            // 
            this.cambiarContraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cambiarContraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cambiarContraseña.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cambiarContraseña.Depth = 0;
            this.cambiarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cambiarContraseña.HighEmphasis = true;
            this.cambiarContraseña.Icon = null;
            this.cambiarContraseña.Location = new System.Drawing.Point(346, 343);
            this.cambiarContraseña.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cambiarContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.cambiarContraseña.Name = "cambiarContraseña";
            this.cambiarContraseña.NoAccentTextColor = System.Drawing.Color.Empty;
            this.cambiarContraseña.Size = new System.Drawing.Size(185, 36);
            this.cambiarContraseña.TabIndex = 16;
            this.cambiarContraseña.Text = "Cambiar contraseña";
            this.cambiarContraseña.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cambiarContraseña.UseAccentColor = false;
            this.cambiarContraseña.UseVisualStyleBackColor = true;
            this.cambiarContraseña.Click += new System.EventHandler(this.cambiarContraseña_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 430);
            this.Controls.Add(this.cambiarContraseña);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.areaUsuario);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.ingresar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ingresar;
        private MaterialSkin.Controls.MaterialComboBox tipoUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox areaUsuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMaskedTextBox usuario;
        private MaterialSkin.Controls.MaterialMaskedTextBox contraseña;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton cambiarContraseña;
    }
}