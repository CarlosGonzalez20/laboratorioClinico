
namespace clinica
{
    partial class Especialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Especialidad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusc = new MaterialSkin.Controls.MaterialButton();
            this.btnMod = new MaterialSkin.Controls.MaterialButton();
            this.btnElim = new MaterialSkin.Controls.MaterialButton();
            this.btnIng = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNo = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtNom = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtDes = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEsta = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusc);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.btnElim);
            this.groupBox1.Controls.Add(this.btnIng);
            this.groupBox1.Location = new System.Drawing.Point(269, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 163);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // btnBusc
            // 
            this.btnBusc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBusc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBusc.Depth = 0;
            this.btnBusc.HighEmphasis = true;
            this.btnBusc.Icon = null;
            this.btnBusc.Location = new System.Drawing.Point(206, 99);
            this.btnBusc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBusc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBusc.Size = new System.Drawing.Size(77, 36);
            this.btnBusc.TabIndex = 3;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBusc.UseAccentColor = false;
            this.btnBusc.UseVisualStyleBackColor = true;
            // 
            // btnMod
            // 
            this.btnMod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMod.Depth = 0;
            this.btnMod.HighEmphasis = true;
            this.btnMod.Icon = null;
            this.btnMod.Location = new System.Drawing.Point(51, 99);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMod.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMod.Name = "btnMod";
            this.btnMod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMod.Size = new System.Drawing.Size(99, 36);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "Modificar";
            this.btnMod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMod.UseAccentColor = false;
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnElim
            // 
            this.btnElim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnElim.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnElim.Depth = 0;
            this.btnElim.HighEmphasis = true;
            this.btnElim.Icon = null;
            this.btnElim.Location = new System.Drawing.Point(206, 38);
            this.btnElim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnElim.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnElim.Name = "btnElim";
            this.btnElim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnElim.Size = new System.Drawing.Size(88, 36);
            this.btnElim.TabIndex = 1;
            this.btnElim.Text = "Eliminar";
            this.btnElim.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnElim.UseAccentColor = false;
            this.btnElim.UseVisualStyleBackColor = true;
            // 
            // btnIng
            // 
            this.btnIng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIng.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnIng.Depth = 0;
            this.btnIng.HighEmphasis = true;
            this.btnIng.Icon = null;
            this.btnIng.Location = new System.Drawing.Point(51, 38);
            this.btnIng.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIng.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIng.Name = "btnIng";
            this.btnIng.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnIng.Size = new System.Drawing.Size(91, 36);
            this.btnIng.TabIndex = 0;
            this.btnIng.Text = "Ingresar";
            this.btnIng.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnIng.UseAccentColor = false;
            this.btnIng.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(519, 386);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 26;
            this.materialLabel4.Text = "Estado: ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(456, 302);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(209, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Descripción De Especialidad: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(481, 120);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(159, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Número Especialidad: ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(481, 212);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Nombre Especialidad: ";
            // 
            // txtNo
            // 
            this.txtNo.AllowPromptAsInput = true;
            this.txtNo.AnimateReadOnly = false;
            this.txtNo.AsciiOnly = false;
            this.txtNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNo.BeepOnError = false;
            this.txtNo.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNo.Depth = 0;
            this.txtNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNo.HidePromptOnLeave = false;
            this.txtNo.HideSelection = true;
            this.txtNo.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNo.LeadingIcon = null;
            this.txtNo.Location = new System.Drawing.Point(702, 120);
            this.txtNo.Mask = "";
            this.txtNo.MaxLength = 32767;
            this.txtNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNo.Name = "txtNo";
            this.txtNo.PasswordChar = '\0';
            this.txtNo.PrefixSuffixText = null;
            this.txtNo.PromptChar = '_';
            this.txtNo.ReadOnly = false;
            this.txtNo.RejectInputOnFirstFailure = false;
            this.txtNo.ResetOnPrompt = true;
            this.txtNo.ResetOnSpace = true;
            this.txtNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNo.SelectedText = "";
            this.txtNo.SelectionLength = 0;
            this.txtNo.SelectionStart = 0;
            this.txtNo.ShortcutsEnabled = true;
            this.txtNo.Size = new System.Drawing.Size(250, 48);
            this.txtNo.SkipLiterals = true;
            this.txtNo.TabIndex = 28;
            this.txtNo.TabStop = false;
            this.txtNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNo.TrailingIcon = null;
            this.txtNo.UseSystemPasswordChar = false;
            this.txtNo.ValidatingType = null;
            // 
            // txtNom
            // 
            this.txtNom.AllowPromptAsInput = true;
            this.txtNom.AnimateReadOnly = false;
            this.txtNom.AsciiOnly = false;
            this.txtNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNom.BeepOnError = false;
            this.txtNom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.HidePromptOnLeave = false;
            this.txtNom.HideSelection = true;
            this.txtNom.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtNom.LeadingIcon = null;
            this.txtNom.Location = new System.Drawing.Point(702, 212);
            this.txtNom.Mask = "";
            this.txtNom.MaxLength = 32767;
            this.txtNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.PrefixSuffixText = null;
            this.txtNom.PromptChar = '_';
            this.txtNom.ReadOnly = false;
            this.txtNom.RejectInputOnFirstFailure = false;
            this.txtNom.ResetOnPrompt = true;
            this.txtNom.ResetOnSpace = true;
            this.txtNom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNom.SelectedText = "";
            this.txtNom.SelectionLength = 0;
            this.txtNom.SelectionStart = 0;
            this.txtNom.ShortcutsEnabled = true;
            this.txtNom.Size = new System.Drawing.Size(250, 48);
            this.txtNom.SkipLiterals = true;
            this.txtNom.TabIndex = 29;
            this.txtNom.TabStop = false;
            this.txtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNom.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNom.TrailingIcon = null;
            this.txtNom.UseSystemPasswordChar = false;
            this.txtNom.ValidatingType = null;
            // 
            // txtDes
            // 
            this.txtDes.AllowPromptAsInput = true;
            this.txtDes.AnimateReadOnly = false;
            this.txtDes.AsciiOnly = false;
            this.txtDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDes.BeepOnError = false;
            this.txtDes.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDes.Depth = 0;
            this.txtDes.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDes.HidePromptOnLeave = false;
            this.txtDes.HideSelection = true;
            this.txtDes.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtDes.LeadingIcon = null;
            this.txtDes.Location = new System.Drawing.Point(702, 302);
            this.txtDes.Mask = "";
            this.txtDes.MaxLength = 32767;
            this.txtDes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDes.Name = "txtDes";
            this.txtDes.PasswordChar = '\0';
            this.txtDes.PrefixSuffixText = null;
            this.txtDes.PromptChar = '_';
            this.txtDes.ReadOnly = false;
            this.txtDes.RejectInputOnFirstFailure = false;
            this.txtDes.ResetOnPrompt = true;
            this.txtDes.ResetOnSpace = true;
            this.txtDes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDes.SelectedText = "";
            this.txtDes.SelectionLength = 0;
            this.txtDes.SelectionStart = 0;
            this.txtDes.ShortcutsEnabled = true;
            this.txtDes.Size = new System.Drawing.Size(250, 48);
            this.txtDes.SkipLiterals = true;
            this.txtDes.TabIndex = 30;
            this.txtDes.TabStop = false;
            this.txtDes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDes.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtDes.TrailingIcon = null;
            this.txtDes.UseSystemPasswordChar = false;
            this.txtDes.ValidatingType = null;
            // 
            // txtEsta
            // 
            this.txtEsta.AllowPromptAsInput = true;
            this.txtEsta.AnimateReadOnly = false;
            this.txtEsta.AsciiOnly = false;
            this.txtEsta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEsta.BeepOnError = false;
            this.txtEsta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEsta.Depth = 0;
            this.txtEsta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEsta.HidePromptOnLeave = false;
            this.txtEsta.HideSelection = true;
            this.txtEsta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEsta.LeadingIcon = null;
            this.txtEsta.Location = new System.Drawing.Point(702, 374);
            this.txtEsta.Mask = "";
            this.txtEsta.MaxLength = 32767;
            this.txtEsta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEsta.Name = "txtEsta";
            this.txtEsta.PasswordChar = '\0';
            this.txtEsta.PrefixSuffixText = null;
            this.txtEsta.PromptChar = '_';
            this.txtEsta.ReadOnly = false;
            this.txtEsta.RejectInputOnFirstFailure = false;
            this.txtEsta.ResetOnPrompt = true;
            this.txtEsta.ResetOnSpace = true;
            this.txtEsta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEsta.SelectedText = "";
            this.txtEsta.SelectionLength = 0;
            this.txtEsta.SelectionStart = 0;
            this.txtEsta.ShortcutsEnabled = true;
            this.txtEsta.Size = new System.Drawing.Size(250, 48);
            this.txtEsta.SkipLiterals = true;
            this.txtEsta.TabIndex = 31;
            this.txtEsta.TabStop = false;
            this.txtEsta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEsta.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEsta.TrailingIcon = null;
            this.txtEsta.UseSystemPasswordChar = false;
            this.txtEsta.ValidatingType = null;
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 734);
            this.Controls.Add(this.txtEsta);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnBusc;
        private MaterialSkin.Controls.MaterialButton btnMod;
        private MaterialSkin.Controls.MaterialButton btnElim;
        private MaterialSkin.Controls.MaterialButton btnIng;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNo;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNom;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDes;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEsta;
    }
}