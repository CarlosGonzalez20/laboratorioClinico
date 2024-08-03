
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
            this.salarios = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infoTipo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarTipo = new MaterialSkin.Controls.MaterialButton();
            this.modificarTipo = new MaterialSkin.Controls.MaterialButton();
            this.eliminarTipo = new MaterialSkin.Controls.MaterialButton();
            this.ingresarTipo = new MaterialSkin.Controls.MaterialButton();
            this.idTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoEmpleados = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioActivo = new System.Windows.Forms.RadioButton();
            this.radioInactivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.infoTipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // salarios
            // 
            this.salarios.Location = new System.Drawing.Point(16, 226);
            this.salarios.Name = "salarios";
            this.salarios.Size = new System.Drawing.Size(154, 20);
            this.salarios.TabIndex = 14;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(16, 169);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(154, 20);
            this.Descripcion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Salario";
            // 
            // infoTipo
            // 
            this.infoTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTipo.Location = new System.Drawing.Point(344, 100);
            this.infoTipo.Margin = new System.Windows.Forms.Padding(2);
            this.infoTipo.Name = "infoTipo";
            this.infoTipo.RowHeadersWidth = 51;
            this.infoTipo.RowTemplate.Height = 24;
            this.infoTipo.Size = new System.Drawing.Size(364, 233);
            this.infoTipo.TabIndex = 65;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarTipo);
            this.groupBox1.Controls.Add(this.modificarTipo);
            this.groupBox1.Controls.Add(this.eliminarTipo);
            this.groupBox1.Controls.Add(this.ingresarTipo);
            this.groupBox1.Location = new System.Drawing.Point(192, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(148, 233);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // buscarTipo
            // 
            this.buscarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarTipo.Depth = 0;
            this.buscarTipo.HighEmphasis = true;
            this.buscarTipo.Icon = null;
            this.buscarTipo.Location = new System.Drawing.Point(38, 135);
            this.buscarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buscarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarTipo.Name = "buscarTipo";
            this.buscarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarTipo.Size = new System.Drawing.Size(77, 36);
            this.buscarTipo.TabIndex = 3;
            this.buscarTipo.Text = "Buscar";
            this.buscarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarTipo.UseAccentColor = false;
            this.buscarTipo.UseVisualStyleBackColor = true;
            this.buscarTipo.Click += new System.EventHandler(this.buscarTipo_Click);
            // 
            // modificarTipo
            // 
            this.modificarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarTipo.Depth = 0;
            this.modificarTipo.HighEmphasis = true;
            this.modificarTipo.Icon = null;
            this.modificarTipo.Location = new System.Drawing.Point(38, 185);
            this.modificarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.modificarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarTipo.Name = "modificarTipo";
            this.modificarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarTipo.Size = new System.Drawing.Size(99, 36);
            this.modificarTipo.TabIndex = 2;
            this.modificarTipo.Text = "Modificar";
            this.modificarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarTipo.UseAccentColor = false;
            this.modificarTipo.UseVisualStyleBackColor = true;
            // 
            // eliminarTipo
            // 
            this.eliminarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarTipo.Depth = 0;
            this.eliminarTipo.HighEmphasis = true;
            this.eliminarTipo.Icon = null;
            this.eliminarTipo.Location = new System.Drawing.Point(38, 84);
            this.eliminarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.eliminarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarTipo.Name = "eliminarTipo";
            this.eliminarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarTipo.Size = new System.Drawing.Size(88, 36);
            this.eliminarTipo.TabIndex = 1;
            this.eliminarTipo.Text = "Eliminar";
            this.eliminarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarTipo.UseAccentColor = false;
            this.eliminarTipo.UseVisualStyleBackColor = true;
            this.eliminarTipo.Click += new System.EventHandler(this.eliminarTipo_Click);
            // 
            // ingresarTipo
            // 
            this.ingresarTipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarTipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarTipo.Depth = 0;
            this.ingresarTipo.HighEmphasis = true;
            this.ingresarTipo.Icon = null;
            this.ingresarTipo.Location = new System.Drawing.Point(38, 31);
            this.ingresarTipo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ingresarTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarTipo.Name = "ingresarTipo";
            this.ingresarTipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarTipo.Size = new System.Drawing.Size(91, 36);
            this.ingresarTipo.TabIndex = 0;
            this.ingresarTipo.Text = "Ingresar";
            this.ingresarTipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarTipo.UseAccentColor = false;
            this.ingresarTipo.UseVisualStyleBackColor = true;
            this.ingresarTipo.Click += new System.EventHandler(this.ingresarTipo_Click);
            // 
            // idTipo
            // 
            this.idTipo.Location = new System.Drawing.Point(138, 82);
            this.idTipo.Name = "idTipo";
            this.idTipo.Size = new System.Drawing.Size(32, 20);
            this.idTipo.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID";
            // 
            // tipoEmpleados
            // 
            this.tipoEmpleados.Location = new System.Drawing.Point(16, 130);
            this.tipoEmpleados.Name = "tipoEmpleados";
            this.tipoEmpleados.Size = new System.Drawing.Size(154, 20);
            this.tipoEmpleados.TabIndex = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioActivo);
            this.groupBox2.Controls.Add(this.radioInactivo);
            this.groupBox2.Location = new System.Drawing.Point(37, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(97, 67);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // radioActivo
            // 
            this.radioActivo.AutoSize = true;
            this.radioActivo.Location = new System.Drawing.Point(23, 16);
            this.radioActivo.Name = "radioActivo";
            this.radioActivo.Size = new System.Drawing.Size(55, 17);
            this.radioActivo.TabIndex = 62;
            this.radioActivo.TabStop = true;
            this.radioActivo.Text = "Activo";
            this.radioActivo.UseVisualStyleBackColor = true;
            // 
            // radioInactivo
            // 
            this.radioInactivo.AutoSize = true;
            this.radioInactivo.Location = new System.Drawing.Point(23, 40);
            this.radioInactivo.Name = "radioInactivo";
            this.radioInactivo.Size = new System.Drawing.Size(63, 17);
            this.radioInactivo.TabIndex = 61;
            this.radioInactivo.TabStop = true;
            this.radioInactivo.Text = "Inactivo";
            this.radioInactivo.UseVisualStyleBackColor = true;
            // 
            // tipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tipoEmpleados);
            this.Controls.Add(this.idTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoTipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salarios);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label2);
            this.Name = "tipoEmpleado";
            this.Text = "Tipo Empleado";
            this.Load += new System.EventHandler(this.tipoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoTipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salarios;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView infoTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton buscarTipo;
        private MaterialSkin.Controls.MaterialButton modificarTipo;
        private MaterialSkin.Controls.MaterialButton eliminarTipo;
        private MaterialSkin.Controls.MaterialButton ingresarTipo;
        private System.Windows.Forms.TextBox idTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tipoEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioActivo;
        private System.Windows.Forms.RadioButton radioInactivo;
    }
}