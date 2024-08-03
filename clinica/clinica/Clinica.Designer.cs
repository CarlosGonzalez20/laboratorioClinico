
using System;
using System.Windows.Forms;

namespace clinica
{
    partial class Clinica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MBBus = new MaterialSkin.Controls.MaterialButton();
            this.MBmod = new MaterialSkin.Controls.MaterialButton();
            this.MTElim = new MaterialSkin.Controls.MaterialButton();
            this.MBIng = new MaterialSkin.Controls.MaterialButton();
            this.txtEstado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCorreo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTelefono = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDir = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.MTCorreo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.MTTEL = new MaterialSkin.Controls.MaterialLabel();
            this.MTHA = new MaterialSkin.Controls.MaterialLabel();
            this.MTDirec = new MaterialSkin.Controls.MaterialLabel();
            this.MTNum_Especialidad = new MaterialSkin.Controls.MaterialLabel();
            this.txtNomCl = new MaterialSkin.Controls.MaterialTextBox();
            this.MLNom_Clinic = new MaterialSkin.Controls.MaterialLabel();
            this.txtArea = new MaterialSkin.Controls.MaterialTextBox();
            this.MLNum_Clinic = new MaterialSkin.Controls.MaterialLabel();
            this.txtHorario = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbClinica = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MBBus);
            this.groupBox1.Controls.Add(this.MBmod);
            this.groupBox1.Controls.Add(this.MTElim);
            this.groupBox1.Controls.Add(this.MBIng);
            this.groupBox1.Location = new System.Drawing.Point(625, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 208);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // MBBus
            // 
            this.MBBus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBBus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBBus.Depth = 0;
            this.MBBus.HighEmphasis = true;
            this.MBBus.Icon = null;
            this.MBBus.Location = new System.Drawing.Point(236, 126);
            this.MBBus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBBus.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBBus.Name = "MBBus";
            this.MBBus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBBus.Size = new System.Drawing.Size(77, 36);
            this.MBBus.TabIndex = 3;
            this.MBBus.Text = "Buscar";
            this.MBBus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBBus.UseAccentColor = false;
            this.MBBus.UseVisualStyleBackColor = true;
            // 
            // MBmod
            // 
            this.MBmod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBmod.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBmod.Depth = 0;
            this.MBmod.HighEmphasis = true;
            this.MBmod.Icon = null;
            this.MBmod.Location = new System.Drawing.Point(76, 126);
            this.MBmod.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBmod.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBmod.Name = "MBmod";
            this.MBmod.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBmod.Size = new System.Drawing.Size(99, 36);
            this.MBmod.TabIndex = 2;
            this.MBmod.Text = "Modificar";
            this.MBmod.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBmod.UseAccentColor = false;
            this.MBmod.UseVisualStyleBackColor = true;
            // 
            // MTElim
            // 
            this.MTElim.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MTElim.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MTElim.Depth = 0;
            this.MTElim.HighEmphasis = true;
            this.MTElim.Icon = null;
            this.MTElim.Location = new System.Drawing.Point(225, 51);
            this.MTElim.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MTElim.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTElim.Name = "MTElim";
            this.MTElim.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MTElim.Size = new System.Drawing.Size(88, 36);
            this.MTElim.TabIndex = 1;
            this.MTElim.Text = "Eliminar";
            this.MTElim.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MTElim.UseAccentColor = false;
            this.MTElim.UseVisualStyleBackColor = true;
            // 
            // MBIng
            // 
            this.MBIng.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBIng.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBIng.Depth = 0;
            this.MBIng.HighEmphasis = true;
            this.MBIng.Icon = null;
            this.MBIng.Location = new System.Drawing.Point(76, 51);
            this.MBIng.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBIng.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBIng.Name = "MBIng";
            this.MBIng.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBIng.Size = new System.Drawing.Size(91, 36);
            this.MBIng.TabIndex = 0;
            this.MBIng.Text = "Ingresar";
            this.MBIng.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBIng.UseAccentColor = false;
            this.MBIng.UseVisualStyleBackColor = true;
            this.MBIng.Click += new System.EventHandler(this.MBIng_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.AnimateReadOnly = false;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Depth = 0;
            this.txtEstado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstado.LeadingIcon = null;
            this.txtEstado.Location = new System.Drawing.Point(769, 314);
            this.txtEstado.MaxLength = 50;
            this.txtEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(200, 50);
            this.txtEstado.TabIndex = 52;
            this.txtEstado.Text = "";
            this.txtEstado.TrailingIcon = null;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AnimateReadOnly = false;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Depth = 0;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCorreo.LeadingIcon = null;
            this.txtCorreo.Location = new System.Drawing.Point(769, 205);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 50);
            this.txtCorreo.TabIndex = 51;
            this.txtCorreo.Text = "";
            this.txtCorreo.TrailingIcon = null;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AnimateReadOnly = false;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefono.LeadingIcon = null;
            this.txtTelefono.Location = new System.Drawing.Point(769, 107);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 50);
            this.txtTelefono.TabIndex = 50;
            this.txtTelefono.Text = "";
            this.txtTelefono.TrailingIcon = null;
            // 
            // txtDir
            // 
            this.txtDir.AnimateReadOnly = false;
            this.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDir.Depth = 0;
            this.txtDir.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDir.LeadingIcon = null;
            this.txtDir.Location = new System.Drawing.Point(345, 382);
            this.txtDir.MaxLength = 50;
            this.txtDir.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDir.Multiline = false;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(200, 50);
            this.txtDir.TabIndex = 49;
            this.txtDir.Text = "";
            this.txtDir.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(658, 333);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(58, 19);
            this.materialLabel1.TabIndex = 48;
            this.materialLabel1.Text = "Estado: ";
            // 
            // MTCorreo
            // 
            this.MTCorreo.AutoSize = true;
            this.MTCorreo.Depth = 0;
            this.MTCorreo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTCorreo.Location = new System.Drawing.Point(611, 236);
            this.MTCorreo.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTCorreo.Name = "MTCorreo";
            this.MTCorreo.Size = new System.Drawing.Size(133, 19);
            this.MTCorreo.TabIndex = 47;
            this.MTCorreo.Text = "Correo Electrónico:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(540, 149);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(5, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = " ";
            // 
            // MTTEL
            // 
            this.MTTEL.AutoSize = true;
            this.MTTEL.Depth = 0;
            this.MTTEL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTTEL.Location = new System.Drawing.Point(648, 119);
            this.MTTEL.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTTEL.Name = "MTTEL";
            this.MTTEL.Size = new System.Drawing.Size(68, 19);
            this.MTTEL.TabIndex = 45;
            this.MTTEL.Text = "Teléfono:";
            // 
            // MTHA
            // 
            this.MTHA.AutoSize = true;
            this.MTHA.Depth = 0;
            this.MTHA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTHA.Location = new System.Drawing.Point(126, 502);
            this.MTHA.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTHA.Name = "MTHA";
            this.MTHA.Size = new System.Drawing.Size(147, 19);
            this.MTHA.TabIndex = 44;
            this.MTHA.Text = "Horario de actividad:";
            // 
            // MTDirec
            // 
            this.MTDirec.AutoSize = true;
            this.MTDirec.Depth = 0;
            this.MTDirec.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTDirec.Location = new System.Drawing.Point(187, 400);
            this.MTDirec.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTDirec.Name = "MTDirec";
            this.MTDirec.Size = new System.Drawing.Size(71, 19);
            this.MTDirec.TabIndex = 43;
            this.MTDirec.Text = "Dirección:";
            // 
            // MTNum_Especialidad
            // 
            this.MTNum_Especialidad.AutoSize = true;
            this.MTNum_Especialidad.Depth = 0;
            this.MTNum_Especialidad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MTNum_Especialidad.Location = new System.Drawing.Point(64, 303);
            this.MTNum_Especialidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.MTNum_Especialidad.Name = "MTNum_Especialidad";
            this.MTNum_Especialidad.Size = new System.Drawing.Size(233, 19);
            this.MTNum_Especialidad.TabIndex = 42;
            this.MTNum_Especialidad.Text = "Número de Area de Especialidad:";
            // 
            // txtNomCl
            // 
            this.txtNomCl.AnimateReadOnly = false;
            this.txtNomCl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomCl.Depth = 0;
            this.txtNomCl.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomCl.LeadingIcon = null;
            this.txtNomCl.Location = new System.Drawing.Point(345, 195);
            this.txtNomCl.MaxLength = 50;
            this.txtNomCl.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNomCl.Multiline = false;
            this.txtNomCl.Name = "txtNomCl";
            this.txtNomCl.Size = new System.Drawing.Size(200, 50);
            this.txtNomCl.TabIndex = 41;
            this.txtNomCl.Text = "";
            this.txtNomCl.TrailingIcon = null;
            // 
            // MLNom_Clinic
            // 
            this.MLNom_Clinic.AutoSize = true;
            this.MLNom_Clinic.Depth = 0;
            this.MLNom_Clinic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MLNom_Clinic.Location = new System.Drawing.Point(135, 208);
            this.MLNom_Clinic.MouseState = MaterialSkin.MouseState.HOVER;
            this.MLNom_Clinic.Name = "MLNom_Clinic";
            this.MLNom_Clinic.Size = new System.Drawing.Size(138, 19);
            this.MLNom_Clinic.TabIndex = 40;
            this.MLNom_Clinic.Text = "Nombre de Clinica: ";
            // 
            // txtArea
            // 
            this.txtArea.AnimateReadOnly = false;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArea.Depth = 0;
            this.txtArea.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtArea.LeadingIcon = null;
            this.txtArea.Location = new System.Drawing.Point(345, 285);
            this.txtArea.MaxLength = 50;
            this.txtArea.MouseState = MaterialSkin.MouseState.OUT;
            this.txtArea.Multiline = false;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(200, 50);
            this.txtArea.TabIndex = 39;
            this.txtArea.Text = "";
            this.txtArea.TrailingIcon = null;
            // 
            // MLNum_Clinic
            // 
            this.MLNum_Clinic.AutoSize = true;
            this.MLNum_Clinic.Depth = 0;
            this.MLNum_Clinic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MLNum_Clinic.Location = new System.Drawing.Point(149, 119);
            this.MLNum_Clinic.MouseState = MaterialSkin.MouseState.HOVER;
            this.MLNum_Clinic.Name = "MLNum_Clinic";
            this.MLNum_Clinic.Size = new System.Drawing.Size(138, 19);
            this.MLNum_Clinic.TabIndex = 38;
            this.MLNum_Clinic.Text = "Número de Clinica: ";
            // 
            // txtHorario
            // 
            this.txtHorario.AnimateReadOnly = false;
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorario.Depth = 0;
            this.txtHorario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHorario.LeadingIcon = null;
            this.txtHorario.Location = new System.Drawing.Point(345, 480);
            this.txtHorario.MaxLength = 50;
            this.txtHorario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHorario.Multiline = false;
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(200, 50);
            this.txtHorario.TabIndex = 55;
            this.txtHorario.Text = "";
            this.txtHorario.TrailingIcon = null;
            // 
            // cmbClinica
            // 
            this.cmbClinica.AutoResize = false;
            this.cmbClinica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbClinica.Depth = 0;
            this.cmbClinica.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbClinica.DropDownHeight = 174;
            this.cmbClinica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClinica.DropDownWidth = 121;
            this.cmbClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbClinica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbClinica.FormattingEnabled = true;
            this.cmbClinica.IntegralHeight = false;
            this.cmbClinica.ItemHeight = 43;
            this.cmbClinica.Items.AddRange(new object[] {
            "Seleccione numero de clinica",
            "1",
            "2",
            "3"});
            this.cmbClinica.Location = new System.Drawing.Point(345, 116);
            this.cmbClinica.MaxDropDownItems = 4;
            this.cmbClinica.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbClinica.Name = "cmbClinica";
            this.cmbClinica.Size = new System.Drawing.Size(200, 49);
            this.cmbClinica.StartIndex = 0;
            this.cmbClinica.TabIndex = 56;
            this.cmbClinica.SelectedIndexChanged += new System.EventHandler(this.cmbClinica_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1072, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(712, 484);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 832);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbClinica);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.MTCorreo);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.MTTEL);
            this.Controls.Add(this.MTHA);
            this.Controls.Add(this.MTDirec);
            this.Controls.Add(this.MTNum_Especialidad);
            this.Controls.Add(this.txtNomCl);
            this.Controls.Add(this.MLNom_Clinic);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.MLNum_Clinic);
            this.Name = "Clinica";
            this.Text = "Clinica";
            this.Load += new System.EventHandler(this.Clinica_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

     

        private void cmbClinica_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton MBBus;
        private MaterialSkin.Controls.MaterialButton MBmod;
        private MaterialSkin.Controls.MaterialButton MTElim;
        private MaterialSkin.Controls.MaterialButton MBIng;
        private MaterialSkin.Controls.MaterialTextBox txtEstado;
        private MaterialSkin.Controls.MaterialTextBox txtCorreo;
        private MaterialSkin.Controls.MaterialTextBox txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox txtDir;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel MTCorreo;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel MTTEL;
        private MaterialSkin.Controls.MaterialLabel MTHA;
        private MaterialSkin.Controls.MaterialLabel MTDirec;
        private MaterialSkin.Controls.MaterialLabel MTNum_Especialidad;
        private MaterialSkin.Controls.MaterialTextBox txtNomCl;
        private MaterialSkin.Controls.MaterialLabel MLNom_Clinic;
        private MaterialSkin.Controls.MaterialTextBox txtArea;
        private MaterialSkin.Controls.MaterialLabel MLNum_Clinic;
        private MaterialSkin.Controls.MaterialTextBox txtHorario;
        private MaterialSkin.Controls.MaterialComboBox cmbClinica;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
