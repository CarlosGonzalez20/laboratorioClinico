
namespace clinica
{
    partial class Laboratorio
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
            this.Horario = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dir = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.eliminarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.buscarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.modificarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.ingresarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.estatusPaciente = new System.Windows.Forms.GroupBox();
            this.estadoInactivo = new System.Windows.Forms.RadioButton();
            this.estatusActivo = new System.Windows.Forms.RadioButton();
            this.Fechaasignacion = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDlab = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoLab = new System.Windows.Forms.DataGridView();
            this.clinica = new System.Windows.Forms.ComboBox();
            this.Personal = new System.Windows.Forms.ComboBox();
            this.Examenes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.estatusPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoLab)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Examenes);
            this.groupBox1.Controls.Add(this.Personal);
            this.groupBox1.Controls.Add(this.clinica);
            this.groupBox1.Controls.Add(this.Horario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Dir);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.estatusPaciente);
            this.groupBox1.Controls.Add(this.Fechaasignacion);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.IDlab);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 240);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Laboratorio";
            // 
            // Horario
            // 
            this.Horario.Location = new System.Drawing.Point(23, 136);
            this.Horario.Name = "Horario";
            this.Horario.Size = new System.Drawing.Size(91, 20);
            this.Horario.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Horario";
            // 
            // Dir
            // 
            this.Dir.Location = new System.Drawing.Point(396, 42);
            this.Dir.Name = "Dir";
            this.Dir.Size = new System.Drawing.Size(173, 20);
            this.Dir.TabIndex = 66;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.eliminarPaciente);
            this.groupBox4.Controls.Add(this.buscarPaciente);
            this.groupBox4.Controls.Add(this.modificarPaciente);
            this.groupBox4.Controls.Add(this.ingresarPaciente);
            this.groupBox4.Location = new System.Drawing.Point(288, 120);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(212, 110);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mantenimiento";
            // 
            // eliminarPaciente
            // 
            this.eliminarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarPaciente.Depth = 0;
            this.eliminarPaciente.HighEmphasis = true;
            this.eliminarPaciente.Icon = null;
            this.eliminarPaciente.Location = new System.Drawing.Point(114, 60);
            this.eliminarPaciente.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.eliminarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarPaciente.Name = "eliminarPaciente";
            this.eliminarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarPaciente.Size = new System.Drawing.Size(88, 36);
            this.eliminarPaciente.TabIndex = 6;
            this.eliminarPaciente.Text = "eliminar";
            this.eliminarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarPaciente.UseAccentColor = false;
            this.eliminarPaciente.UseVisualStyleBackColor = true;
            this.eliminarPaciente.Click += new System.EventHandler(this.eliminarPaciente_Click);
            // 
            // buscarPaciente
            // 
            this.buscarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarPaciente.Depth = 0;
            this.buscarPaciente.HighEmphasis = true;
            this.buscarPaciente.Icon = null;
            this.buscarPaciente.Location = new System.Drawing.Point(9, 20);
            this.buscarPaciente.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buscarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarPaciente.Name = "buscarPaciente";
            this.buscarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarPaciente.Size = new System.Drawing.Size(77, 36);
            this.buscarPaciente.TabIndex = 5;
            this.buscarPaciente.Text = "buscar";
            this.buscarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarPaciente.UseAccentColor = false;
            this.buscarPaciente.UseVisualStyleBackColor = true;
            this.buscarPaciente.Click += new System.EventHandler(this.buscarPaciente_Click);
            // 
            // modificarPaciente
            // 
            this.modificarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarPaciente.Depth = 0;
            this.modificarPaciente.HighEmphasis = true;
            this.modificarPaciente.Icon = null;
            this.modificarPaciente.Location = new System.Drawing.Point(9, 60);
            this.modificarPaciente.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.modificarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarPaciente.Name = "modificarPaciente";
            this.modificarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarPaciente.Size = new System.Drawing.Size(99, 36);
            this.modificarPaciente.TabIndex = 4;
            this.modificarPaciente.Text = "modificar";
            this.modificarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarPaciente.UseAccentColor = false;
            this.modificarPaciente.UseVisualStyleBackColor = true;
            this.modificarPaciente.Click += new System.EventHandler(this.modificarPaciente_Click);
            // 
            // ingresarPaciente
            // 
            this.ingresarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarPaciente.Depth = 0;
            this.ingresarPaciente.HighEmphasis = true;
            this.ingresarPaciente.Icon = null;
            this.ingresarPaciente.Location = new System.Drawing.Point(111, 20);
            this.ingresarPaciente.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ingresarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarPaciente.Name = "ingresarPaciente";
            this.ingresarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarPaciente.Size = new System.Drawing.Size(91, 36);
            this.ingresarPaciente.TabIndex = 3;
            this.ingresarPaciente.Text = "Ingresar";
            this.ingresarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarPaciente.UseAccentColor = false;
            this.ingresarPaciente.UseVisualStyleBackColor = true;
            this.ingresarPaciente.Click += new System.EventHandler(this.ingresarPaciente_Click);
            // 
            // estatusPaciente
            // 
            this.estatusPaciente.Controls.Add(this.estadoInactivo);
            this.estatusPaciente.Controls.Add(this.estatusActivo);
            this.estatusPaciente.Location = new System.Drawing.Point(130, 128);
            this.estatusPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.estatusPaciente.Name = "estatusPaciente";
            this.estatusPaciente.Padding = new System.Windows.Forms.Padding(2);
            this.estatusPaciente.Size = new System.Drawing.Size(119, 81);
            this.estatusPaciente.TabIndex = 47;
            this.estatusPaciente.TabStop = false;
            this.estatusPaciente.Text = "Estado";
            // 
            // estadoInactivo
            // 
            this.estadoInactivo.AutoSize = true;
            this.estadoInactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoInactivo.Location = new System.Drawing.Point(34, 49);
            this.estadoInactivo.Margin = new System.Windows.Forms.Padding(2);
            this.estadoInactivo.Name = "estadoInactivo";
            this.estadoInactivo.Size = new System.Drawing.Size(63, 17);
            this.estadoInactivo.TabIndex = 40;
            this.estadoInactivo.TabStop = true;
            this.estadoInactivo.Text = "Inactivo";
            this.estadoInactivo.UseVisualStyleBackColor = true;
            // 
            // estatusActivo
            // 
            this.estatusActivo.AutoSize = true;
            this.estatusActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estatusActivo.Location = new System.Drawing.Point(34, 27);
            this.estatusActivo.Margin = new System.Windows.Forms.Padding(2);
            this.estatusActivo.Name = "estatusActivo";
            this.estatusActivo.Size = new System.Drawing.Size(55, 17);
            this.estatusActivo.TabIndex = 39;
            this.estatusActivo.TabStop = true;
            this.estatusActivo.Text = "Activo";
            this.estatusActivo.UseVisualStyleBackColor = true;
            // 
            // Fechaasignacion
            // 
            this.Fechaasignacion.Location = new System.Drawing.Point(207, 42);
            this.Fechaasignacion.Margin = new System.Windows.Forms.Padding(2);
            this.Fechaasignacion.Name = "Fechaasignacion";
            this.Fechaasignacion.Size = new System.Drawing.Size(169, 20);
            this.Fechaasignacion.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(393, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Fecha de Asignación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Identificación de Examenes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Identificación de la Clínica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Identificación del Personal";
            // 
            // IDlab
            // 
            this.IDlab.Location = new System.Drawing.Point(23, 42);
            this.IDlab.Name = "IDlab";
            this.IDlab.Size = new System.Drawing.Size(173, 20);
            this.IDlab.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Identificación_Laboratorio";
            // 
            // infoLab
            // 
            this.infoLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoLab.Location = new System.Drawing.Point(606, 76);
            this.infoLab.Margin = new System.Windows.Forms.Padding(2);
            this.infoLab.Name = "infoLab";
            this.infoLab.RowHeadersWidth = 51;
            this.infoLab.RowTemplate.Height = 24;
            this.infoLab.Size = new System.Drawing.Size(347, 240);
            this.infoLab.TabIndex = 5;
            // 
            // clinica
            // 
            this.clinica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clinica.FormattingEnabled = true;
            this.clinica.Location = new System.Drawing.Point(208, 87);
            this.clinica.Margin = new System.Windows.Forms.Padding(2);
            this.clinica.Name = "clinica";
            this.clinica.Size = new System.Drawing.Size(168, 21);
            this.clinica.TabIndex = 50;
            this.clinica.SelectedIndexChanged += new System.EventHandler(this.clinica_SelectedIndexChanged);
            // 
            // Personal
            // 
            this.Personal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Personal.FormattingEnabled = true;
            this.Personal.Location = new System.Drawing.Point(23, 88);
            this.Personal.Margin = new System.Windows.Forms.Padding(2);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(173, 21);
            this.Personal.TabIndex = 69;
            // 
            // Examenes
            // 
            this.Examenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Examenes.FormattingEnabled = true;
            this.Examenes.Location = new System.Drawing.Point(396, 87);
            this.Examenes.Margin = new System.Windows.Forms.Padding(2);
            this.Examenes.Name = "Examenes";
            this.Examenes.Size = new System.Drawing.Size(173, 21);
            this.Examenes.TabIndex = 70;
            // 
            // Laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 336);
            this.Controls.Add(this.infoLab);
            this.Controls.Add(this.groupBox1);
            this.Name = "Laboratorio";
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Laboratorio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.estatusPaciente.ResumeLayout(false);
            this.estatusPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoLab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox Horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Dir;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton eliminarPaciente;
        private MaterialSkin.Controls.MaterialButton buscarPaciente;
        private MaterialSkin.Controls.MaterialButton modificarPaciente;
        private MaterialSkin.Controls.MaterialButton ingresarPaciente;
        private System.Windows.Forms.GroupBox estatusPaciente;
        private System.Windows.Forms.RadioButton estadoInactivo;
        private System.Windows.Forms.RadioButton estatusActivo;
        private System.Windows.Forms.DateTimePicker Fechaasignacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox IDlab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView infoLab;
        private System.Windows.Forms.ComboBox clinica;
        private System.Windows.Forms.ComboBox Examenes;
        private System.Windows.Forms.ComboBox Personal;
    }
}