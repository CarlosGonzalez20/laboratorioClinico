
using System;
using System.Windows.Forms;

namespace clinica
{
    partial class Genero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Genero));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBusc = new MaterialSkin.Controls.MaterialButton();
            this.btnMod = new MaterialSkin.Controls.MaterialButton();
            this.btnElim = new MaterialSkin.Controls.MaterialButton();
            this.btnIng = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MTEstado = new MaterialSkin.Controls.MaterialLabel();
            this.txtNom = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.CmbGenero = new MaterialSkin.Controls.MaterialComboBox();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(121, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 177);
            this.groupBox1.TabIndex = 24;
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
            this.btnBusc.Location = new System.Drawing.Point(181, 115);
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
            this.btnMod.Location = new System.Drawing.Point(25, 115);
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
            this.btnElim.Location = new System.Drawing.Point(181, 45);
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
            this.btnIng.Location = new System.Drawing.Point(25, 45);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MTEstado
            // 
            this.MTEstado.AutoSize = true;
            this.MTEstado.Depth = 0;
            this.MTEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTEstado.Location = new System.Drawing.Point(92, 286);
            this.MTEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTEstado.Name = "MTEstado";
            this.MTEstado.Size = new System.Drawing.Size(54, 19);
            this.MTEstado.TabIndex = 20;
            this.MTEstado.Text = "Estado:";
            // 
            // txtNom
            // 
            this.txtNom.AnimateReadOnly = false;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.LeadingIcon = null;
            this.txtNom.Location = new System.Drawing.Point(206, 205);
            this.txtNom.MaxLength = 50;
            this.txtNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNom.Multiline = false;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(223, 50);
            this.txtNom.TabIndex = 19;
            this.txtNom.Text = "";
            this.txtNom.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(31, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Nombre Género:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(67, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "No.Género:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // CmbGenero
            // 
            this.CmbGenero.AutoResize = false;
            this.CmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbGenero.Depth = 0;
            this.CmbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbGenero.DropDownHeight = 174;
            this.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenero.DropDownWidth = 121;
            this.CmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.IntegralHeight = false;
            this.CmbGenero.ItemHeight = 43;
            this.CmbGenero.Items.AddRange(new object[] {
            "Seleccione un numero",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CmbGenero.Location = new System.Drawing.Point(206, 127);
            this.CmbGenero.MaxDropDownItems = 4;
            this.CmbGenero.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(223, 49);
            this.CmbGenero.StartIndex = 0;
            this.CmbGenero.TabIndex = 25;
            this.CmbGenero.SelectedIndexChanged += new System.EventHandler(this.CmbGenero_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(206, 274);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(223, 50);
            this.txtEstado.TabIndex = 26;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(790, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(557, 427);
            this.dataGridView1.TabIndex = 27;
            // 
            // Genero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 550);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MTEstado);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Genero";
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.Genero_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Genero_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnBusc;
        private MaterialSkin.Controls.MaterialButton btnMod;
        private MaterialSkin.Controls.MaterialButton btnElim;
        private MaterialSkin.Controls.MaterialButton btnIng;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel MTEstado;
        private MaterialSkin.Controls.MaterialTextBox txtNom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox CmbGenero;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private DataGridView dataGridView1;
    }
}
