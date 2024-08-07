
namespace clinica
{
    partial class tipoEmpleado
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
            this.sal = new System.Windows.Forms.TextBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.eliminarTipo = new MaterialSkin.Controls.MaterialButton();
            this.buscarTipo = new MaterialSkin.Controls.MaterialButton();
            this.modificarTipo = new MaterialSkin.Controls.MaterialButton();
            this.ingresarTipo = new MaterialSkin.Controls.MaterialButton();
            this.infoTipo = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.TextBox();
            this.estatusPaciente = new System.Windows.Forms.GroupBox();
            this.estadoInactivo = new System.Windows.Forms.RadioButton();
            this.estatusActivo = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTipo)).BeginInit();
            this.estatusPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // sal
            // 
            this.sal.Location = new System.Drawing.Point(6, 228);
            this.sal.Name = "sal";
            this.sal.Size = new System.Drawing.Size(187, 20);
            this.sal.TabIndex = 14;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(6, 171);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(187, 20);
            this.desc.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(157, 79);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(74, 20);
            this.ID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Salario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.eliminarTipo);
            this.groupBox3.Controls.Add(this.buscarTipo);
            this.groupBox3.Controls.Add(this.modificarTipo);
            this.groupBox3.Controls.Add(this.ingresarTipo);
            this.groupBox3.Location = new System.Drawing.Point(236, 79);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(133, 275);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mantenimiento";
            // 
            // eliminarTipo
            // 
            this.eliminarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarTipo.Depth = 0;
            this.eliminarTipo.HighEmphasis = true;
            this.eliminarTipo.Icon = null;
            this.eliminarTipo.Location = new System.Drawing.Point(18, 83);
            this.eliminarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.eliminarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarTipo.Name = "eliminarTipo";
            this.eliminarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarTipo.Size = new System.Drawing.Size(88, 36);
            this.eliminarTipo.TabIndex = 6;
            this.eliminarTipo.Text = "eliminar";
            this.eliminarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarTipo.UseAccentColor = false;
            this.eliminarTipo.UseVisualStyleBackColor = true;
            this.eliminarTipo.Click += new System.EventHandler(this.eliminarTipo_Click);
            // 
            // buscarTipo
            // 
            this.buscarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarTipo.Depth = 0;
            this.buscarTipo.HighEmphasis = true;
            this.buscarTipo.Icon = null;
            this.buscarTipo.Location = new System.Drawing.Point(18, 140);
            this.buscarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buscarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarTipo.Name = "buscarTipo";
            this.buscarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarTipo.Size = new System.Drawing.Size(77, 36);
            this.buscarTipo.TabIndex = 5;
            this.buscarTipo.Text = "buscar";
            this.buscarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarTipo.UseAccentColor = false;
            this.buscarTipo.UseVisualStyleBackColor = true;
            this.buscarTipo.Click += new System.EventHandler(this.buscarTipo_Click);
            // 
            // modificarTipo
            // 
            this.modificarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarTipo.Depth = 0;
            this.modificarTipo.HighEmphasis = true;
            this.modificarTipo.Icon = null;
            this.modificarTipo.Location = new System.Drawing.Point(18, 195);
            this.modificarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.modificarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarTipo.Name = "modificarTipo";
            this.modificarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarTipo.Size = new System.Drawing.Size(99, 36);
            this.modificarTipo.TabIndex = 4;
            this.modificarTipo.Text = "modificar";
            this.modificarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarTipo.UseAccentColor = false;
            this.modificarTipo.UseVisualStyleBackColor = true;
            // 
            // ingresarTipo
            // 
            this.ingresarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarTipo.Depth = 0;
            this.ingresarTipo.HighEmphasis = true;
            this.ingresarTipo.Icon = null;
            this.ingresarTipo.Location = new System.Drawing.Point(18, 25);
            this.ingresarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ingresarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarTipo.Name = "ingresarTipo";
            this.ingresarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarTipo.Size = new System.Drawing.Size(91, 36);
            this.ingresarTipo.TabIndex = 3;
            this.ingresarTipo.Text = "Ingresar";
            this.ingresarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarTipo.UseAccentColor = false;
            this.ingresarTipo.UseVisualStyleBackColor = true;
            this.ingresarTipo.Click += new System.EventHandler(this.ingresarTipo_Click);
            // 
            // infoTipo
            // 
            this.infoTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTipo.Location = new System.Drawing.Point(387, 79);
            this.infoTipo.Name = "infoTipo";
            this.infoTipo.Size = new System.Drawing.Size(383, 275);
            this.infoTipo.TabIndex = 63;
            // 
            // Tipo
            // 
            this.Tipo.Location = new System.Drawing.Point(6, 132);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(187, 20);
            this.Tipo.TabIndex = 64;
            // 
            // estatusPaciente
            // 
            this.estatusPaciente.Controls.Add(this.estadoInactivo);
            this.estatusPaciente.Controls.Add(this.estatusActivo);
            this.estatusPaciente.Location = new System.Drawing.Point(47, 273);
            this.estatusPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.estatusPaciente.Name = "estatusPaciente";
            this.estatusPaciente.Padding = new System.Windows.Forms.Padding(2);
            this.estatusPaciente.Size = new System.Drawing.Size(119, 81);
            this.estatusPaciente.TabIndex = 65;
            this.estatusPaciente.TabStop = false;
            this.estatusPaciente.Text = "Estatus";
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
            // tipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 371);
            this.Controls.Add(this.estatusPaciente);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.infoTipo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sal);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tipoEmpleado";
            this.Text = "Tipo De Empleado";
            this.Load += new System.EventHandler(this.tipoEmpleado_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTipo)).EndInit();
            this.estatusPaciente.ResumeLayout(false);
            this.estatusPaciente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sal;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton eliminarTipo;
        private MaterialSkin.Controls.MaterialButton buscarTipo;
        private MaterialSkin.Controls.MaterialButton modificarTipo;
        private MaterialSkin.Controls.MaterialButton ingresarTipo;
        private System.Windows.Forms.DataGridView infoTipo;
        private System.Windows.Forms.TextBox Tipo;
        private System.Windows.Forms.GroupBox estatusPaciente;
        private System.Windows.Forms.RadioButton estadoInactivo;
        private System.Windows.Forms.RadioButton estatusActivo;
    }
}