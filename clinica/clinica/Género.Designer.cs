
namespace clinica
{
    partial class Género
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Género));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MTEstatus = new MaterialSkin.Controls.MaterialTextBox();
            this.MTEstado = new MaterialSkin.Controls.MaterialLabel();
            this.txtNom = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbGen = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MTEstatus
            // 
            this.MTEstatus.AnimateReadOnly = false;
            this.MTEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MTEstatus.Depth = 0;
            this.MTEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTEstatus.LeadingIcon = null;
            this.MTEstatus.Location = new System.Drawing.Point(182, 331);
            this.MTEstatus.MaxLength = 50;
            this.MTEstatus.MouseState = MaterialSkin.MouseState.OUT;
            this.MTEstatus.Multiline = false;
            this.MTEstatus.Name = "MTEstatus";
            this.MTEstatus.Size = new System.Drawing.Size(176, 50);
            this.MTEstatus.TabIndex = 12;
            this.MTEstatus.Text = "";
            this.MTEstatus.TrailingIcon = null;
            // 
            // MTEstado
            // 
            this.MTEstado.AutoSize = true;
            this.MTEstado.Depth = 0;
            this.MTEstado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTEstado.Location = new System.Drawing.Point(61, 345);
            this.MTEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTEstado.Name = "MTEstado";
            this.MTEstado.Size = new System.Drawing.Size(88, 19);
            this.MTEstado.TabIndex = 11;
            this.MTEstado.Text = "Estado Civil:";
            // 
            // txtNom
            // 
            this.txtNom.AnimateReadOnly = false;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.LeadingIcon = null;
            this.txtNom.Location = new System.Drawing.Point(182, 238);
            this.txtNom.MaxLength = 50;
            this.txtNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNom.Multiline = false;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 50);
            this.txtNom.TabIndex = 10;
            this.txtNom.Text = "";
            this.txtNom.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(51, 255);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Nombre Género:";
            // 
            // cmbGen
            // 
            this.cmbGen.AutoResize = false;
            this.cmbGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbGen.Depth = 0;
            this.cmbGen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbGen.DropDownHeight = 174;
            this.cmbGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGen.DropDownWidth = 121;
            this.cmbGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbGen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.IntegralHeight = false;
            this.cmbGen.ItemHeight = 43;
            this.cmbGen.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbGen.Location = new System.Drawing.Point(162, 156);
            this.cmbGen.MaxDropDownItems = 4;
            this.cmbGen.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(196, 49);
            this.cmbGen.StartIndex = 0;
            this.cmbGen.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(61, 175);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "No Género:";
            // 
            // Género
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MTEstatus);
            this.Controls.Add(this.MTEstado);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Género";
            this.Text = "Género";
            this.Load += new System.EventHandler(this.Género_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox MTEstatus;
        private MaterialSkin.Controls.MaterialLabel MTEstado;
        private MaterialSkin.Controls.MaterialTextBox txtNom;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cmbGen;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}