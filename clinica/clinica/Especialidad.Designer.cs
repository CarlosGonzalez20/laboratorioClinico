
using System;

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
            this.txtNom = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtDes = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.cmbEspecialidad = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBusc);
            this.groupBox1.Controls.Add(this.btnMod);
            this.groupBox1.Controls.Add(this.btnElim);
            this.groupBox1.Controls.Add(this.btnIng);
            this.groupBox1.Location = new System.Drawing.Point(484, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 177);
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
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
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
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
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
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
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
            this.btnIng.Click += new System.EventHandler(this.btnIng_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(481, 134);
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
            // txtNom
            // 
            this.txtNom.AllowPromptAsInput = true;
            this.txtNom.AnimateReadOnly = false;
            this.txtNom.AsciiOnly = false;
            this.txtNom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNom.BeepOnError = false;
            this.txtNom.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            // txtEstado
            // 
            this.txtEstado.AllowPromptAsInput = true;
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.AsciiOnly = false;
            this.txtEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEstado.BeepOnError = false;
            this.txtEstado.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.HidePromptOnLeave = false;
            this.txtEstado.HideSelection = true;
            this.txtEstado.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(702, 386);
            this.txtEstado.Mask = "";
            this.txtEstado.MaxLength = 32767;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.PasswordChar = '\0';
            this.txtEstado.PrefixSuffixText = null;
            this.txtEstado.PromptChar = '_';
            this.txtEstado.ReadOnly = false;
            this.txtEstado.RejectInputOnFirstFailure = false;
            this.txtEstado.ResetOnPrompt = true;
            this.txtEstado.ResetOnSpace = true;
            this.txtEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEstado.SelectedText = "";
            this.txtEstado.SelectionLength = 0;
            this.txtEstado.SelectionStart = 0;
            this.txtEstado.ShortcutsEnabled = true;
            this.txtEstado.Size = new System.Drawing.Size(250, 48);
            this.txtEstado.SkipLiterals = true;
            this.txtEstado.TabIndex = 33;
            this.txtEstado.TabStop = false;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEstado.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEstado.TrailingIcon = null;
            this.txtEstado.UseSystemPasswordChar = false;
            this.txtEstado.ValidatingType = null;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.AutoResize = false;
            this.cmbEspecialidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEspecialidad.Depth = 0;
            this.cmbEspecialidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEspecialidad.DropDownHeight = 174;
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.DropDownWidth = 121;
            this.cmbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEspecialidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.IntegralHeight = false;
            this.cmbEspecialidad.ItemHeight = 43;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Seleccione un numero ",
            "100",
            "200",
            "300"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(702, 121);
            this.cmbEspecialidad.MaxDropDownItems = 4;
            this.cmbEspecialidad.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(250, 49);
            this.cmbEspecialidad.StartIndex = 0;
            this.cmbEspecialidad.TabIndex = 34;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1013, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(569, 338);
            this.dataGridView1.TabIndex = 35;
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 761);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void Especialidad_load(object sender, EventArgs e)
        {
           
        }

        private void cmbNo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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
        private MaterialSkin.Controls.MaterialMaskedTextBox txtNom;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtDes;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtEstado;
        private MaterialSkin.Controls.MaterialComboBox cmbEspecialidad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
