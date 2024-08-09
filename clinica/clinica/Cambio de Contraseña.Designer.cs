
namespace clinica
{
    partial class Cambio_de_Contraseña
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
            this.usuario = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Cambiar = new MaterialSkin.Controls.MaterialButton();
            this.anterior = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.nuevacontra = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.confirmarcontra = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.Aleatoria = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
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
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usuario.HidePromptOnLeave = false;
            this.usuario.HideSelection = true;
            this.usuario.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.usuario.LeadingIcon = null;
            this.usuario.Location = new System.Drawing.Point(34, 120);
            this.usuario.Margin = new System.Windows.Forms.Padding(2);
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
            this.usuario.Size = new System.Drawing.Size(188, 48);
            this.usuario.SkipLiterals = true;
            this.usuario.TabIndex = 16;
            this.usuario.TabStop = false;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usuario.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.usuario.TrailingIcon = null;
            this.usuario.UseSystemPasswordChar = false;
            this.usuario.ValidatingType = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(32, 95);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "Usuario o Correo";
            // 
            // Cambiar
            // 
            this.Cambiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cambiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Cambiar.Depth = 0;
            this.Cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cambiar.HighEmphasis = true;
            this.Cambiar.Icon = null;
            this.Cambiar.Location = new System.Drawing.Point(34, 277);
            this.Cambiar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Cambiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cambiar.Name = "Cambiar";
            this.Cambiar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Cambiar.Size = new System.Drawing.Size(185, 36);
            this.Cambiar.TabIndex = 14;
            this.Cambiar.Text = "Cambiar Contraseña";
            this.Cambiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cambiar.UseAccentColor = false;
            this.Cambiar.UseVisualStyleBackColor = true;
            this.Cambiar.Click += new System.EventHandler(this.Cambiar_Click);
            // 
            // anterior
            // 
            this.anterior.AllowPromptAsInput = true;
            this.anterior.AnimateReadOnly = false;
            this.anterior.AsciiOnly = false;
            this.anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anterior.BeepOnError = false;
            this.anterior.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.anterior.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.anterior.Depth = 0;
            this.anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.anterior.HidePromptOnLeave = false;
            this.anterior.HideSelection = true;
            this.anterior.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.anterior.LeadingIcon = null;
            this.anterior.Location = new System.Drawing.Point(35, 209);
            this.anterior.Margin = new System.Windows.Forms.Padding(2);
            this.anterior.Mask = "";
            this.anterior.MaxLength = 32767;
            this.anterior.MouseState = MaterialSkin.MouseState.OUT;
            this.anterior.Name = "anterior";
            this.anterior.PasswordChar = '\0';
            this.anterior.PrefixSuffixText = null;
            this.anterior.PromptChar = '_';
            this.anterior.ReadOnly = false;
            this.anterior.RejectInputOnFirstFailure = false;
            this.anterior.ResetOnPrompt = true;
            this.anterior.ResetOnSpace = true;
            this.anterior.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.anterior.SelectedText = "";
            this.anterior.SelectionLength = 0;
            this.anterior.SelectionStart = 0;
            this.anterior.ShortcutsEnabled = true;
            this.anterior.Size = new System.Drawing.Size(188, 48);
            this.anterior.SkipLiterals = true;
            this.anterior.TabIndex = 17;
            this.anterior.TabStop = false;
            this.anterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.anterior.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.anterior.TrailingIcon = null;
            this.anterior.UseSystemPasswordChar = false;
            this.anterior.ValidatingType = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(31, 188);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Contaseña Anterior";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(262, 99);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(131, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "Nueva Contraseña";
            // 
            // nuevacontra
            // 
            this.nuevacontra.AllowPromptAsInput = true;
            this.nuevacontra.AnimateReadOnly = false;
            this.nuevacontra.AsciiOnly = false;
            this.nuevacontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nuevacontra.BeepOnError = false;
            this.nuevacontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nuevacontra.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nuevacontra.Depth = 0;
            this.nuevacontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nuevacontra.HidePromptOnLeave = false;
            this.nuevacontra.HideSelection = true;
            this.nuevacontra.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.nuevacontra.LeadingIcon = null;
            this.nuevacontra.Location = new System.Drawing.Point(265, 120);
            this.nuevacontra.Margin = new System.Windows.Forms.Padding(2);
            this.nuevacontra.Mask = "";
            this.nuevacontra.MaxLength = 32767;
            this.nuevacontra.MouseState = MaterialSkin.MouseState.OUT;
            this.nuevacontra.Name = "nuevacontra";
            this.nuevacontra.PasswordChar = '\0';
            this.nuevacontra.PrefixSuffixText = null;
            this.nuevacontra.PromptChar = '_';
            this.nuevacontra.ReadOnly = false;
            this.nuevacontra.RejectInputOnFirstFailure = false;
            this.nuevacontra.ResetOnPrompt = true;
            this.nuevacontra.ResetOnSpace = true;
            this.nuevacontra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevacontra.SelectedText = "";
            this.nuevacontra.SelectionLength = 0;
            this.nuevacontra.SelectionStart = 0;
            this.nuevacontra.ShortcutsEnabled = true;
            this.nuevacontra.Size = new System.Drawing.Size(188, 48);
            this.nuevacontra.SkipLiterals = true;
            this.nuevacontra.TabIndex = 19;
            this.nuevacontra.TabStop = false;
            this.nuevacontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nuevacontra.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.nuevacontra.TrailingIcon = null;
            this.nuevacontra.UseSystemPasswordChar = false;
            this.nuevacontra.ValidatingType = null;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(262, 188);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(202, 19);
            this.materialLabel4.TabIndex = 22;
            this.materialLabel4.Text = "Confirmar nueva contraseña";
            // 
            // confirmarcontra
            // 
            this.confirmarcontra.AllowPromptAsInput = true;
            this.confirmarcontra.AnimateReadOnly = false;
            this.confirmarcontra.AsciiOnly = false;
            this.confirmarcontra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmarcontra.BeepOnError = false;
            this.confirmarcontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmarcontra.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.confirmarcontra.Depth = 0;
            this.confirmarcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confirmarcontra.HidePromptOnLeave = false;
            this.confirmarcontra.HideSelection = true;
            this.confirmarcontra.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.confirmarcontra.LeadingIcon = null;
            this.confirmarcontra.Location = new System.Drawing.Point(266, 209);
            this.confirmarcontra.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarcontra.Mask = "";
            this.confirmarcontra.MaxLength = 32767;
            this.confirmarcontra.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmarcontra.Name = "confirmarcontra";
            this.confirmarcontra.PasswordChar = '\0';
            this.confirmarcontra.PrefixSuffixText = null;
            this.confirmarcontra.PromptChar = '_';
            this.confirmarcontra.ReadOnly = false;
            this.confirmarcontra.RejectInputOnFirstFailure = false;
            this.confirmarcontra.ResetOnPrompt = true;
            this.confirmarcontra.ResetOnSpace = true;
            this.confirmarcontra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmarcontra.SelectedText = "";
            this.confirmarcontra.SelectionLength = 0;
            this.confirmarcontra.SelectionStart = 0;
            this.confirmarcontra.ShortcutsEnabled = true;
            this.confirmarcontra.Size = new System.Drawing.Size(188, 48);
            this.confirmarcontra.SkipLiterals = true;
            this.confirmarcontra.TabIndex = 21;
            this.confirmarcontra.TabStop = false;
            this.confirmarcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.confirmarcontra.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.confirmarcontra.TrailingIcon = null;
            this.confirmarcontra.UseSystemPasswordChar = false;
            this.confirmarcontra.ValidatingType = null;
            // 
            // Aleatoria
            // 
            this.Aleatoria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Aleatoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aleatoria.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Aleatoria.Depth = 0;
            this.Aleatoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aleatoria.HighEmphasis = true;
            this.Aleatoria.Icon = null;
            this.Aleatoria.Location = new System.Drawing.Point(264, 277);
            this.Aleatoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Aleatoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.Aleatoria.Name = "Aleatoria";
            this.Aleatoria.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Aleatoria.Size = new System.Drawing.Size(268, 36);
            this.Aleatoria.TabIndex = 23;
            this.Aleatoria.Text = "Generar Contraseña Aleatoria";
            this.Aleatoria.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Aleatoria.UseAccentColor = false;
            this.Aleatoria.UseVisualStyleBackColor = true;
            this.Aleatoria.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Cambio_de_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.Aleatoria);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.confirmarcontra);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.nuevacontra);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.Cambiar);
            this.Name = "Cambio_de_Contraseña";
            this.Text = "Cambio_de_Contraseña";
            this.Load += new System.EventHandler(this.Cambio_de_Contraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox usuario;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton Cambiar;
        private MaterialSkin.Controls.MaterialMaskedTextBox anterior;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialMaskedTextBox nuevacontra;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialMaskedTextBox confirmarcontra;
        private MaterialSkin.Controls.MaterialButton Aleatoria;
    }
}