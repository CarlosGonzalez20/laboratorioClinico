
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
            this.salario = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarCargo = new MaterialSkin.Controls.MaterialButton();
            this.modificarEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.eliminarCargo = new MaterialSkin.Controls.MaterialButton();
            this.ingresarTipo = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioActivo = new System.Windows.Forms.RadioButton();
            this.radioInactivo = new System.Windows.Forms.RadioButton();
            this.tipoEmpleados = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(16, 225);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(187, 20);
            this.salario.TabIndex = 14;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(16, 168);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(187, 20);
            this.Descripcion.TabIndex = 13;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(169, 79);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(34, 20);
            this.id.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Salario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarCargo);
            this.groupBox1.Controls.Add(this.modificarEmpleado);
            this.groupBox1.Controls.Add(this.eliminarCargo);
            this.groupBox1.Controls.Add(this.ingresarTipo);
            this.groupBox1.Location = new System.Drawing.Point(217, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(148, 233);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento";
            // 
            // buscarCargo
            // 
            this.buscarCargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarCargo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarCargo.Depth = 0;
            this.buscarCargo.HighEmphasis = true;
            this.buscarCargo.Icon = null;
            this.buscarCargo.Location = new System.Drawing.Point(38, 135);
            this.buscarCargo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buscarCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarCargo.Name = "buscarCargo";
            this.buscarCargo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarCargo.Size = new System.Drawing.Size(77, 36);
            this.buscarCargo.TabIndex = 3;
            this.buscarCargo.Text = "Buscar";
            this.buscarCargo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarCargo.UseAccentColor = false;
            this.buscarCargo.UseVisualStyleBackColor = true;
            // 
            // modificarEmpleado
            // 
            this.modificarEmpleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarEmpleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarEmpleado.Depth = 0;
            this.modificarEmpleado.HighEmphasis = true;
            this.modificarEmpleado.Icon = null;
            this.modificarEmpleado.Location = new System.Drawing.Point(38, 185);
            this.modificarEmpleado.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.modificarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarEmpleado.Name = "modificarEmpleado";
            this.modificarEmpleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarEmpleado.Size = new System.Drawing.Size(99, 36);
            this.modificarEmpleado.TabIndex = 2;
            this.modificarEmpleado.Text = "Modificar";
            this.modificarEmpleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarEmpleado.UseAccentColor = false;
            this.modificarEmpleado.UseVisualStyleBackColor = true;
            // 
            // eliminarCargo
            // 
            this.eliminarCargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarCargo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarCargo.Depth = 0;
            this.eliminarCargo.HighEmphasis = true;
            this.eliminarCargo.Icon = null;
            this.eliminarCargo.Location = new System.Drawing.Point(38, 84);
            this.eliminarCargo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.eliminarCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarCargo.Name = "eliminarCargo";
            this.eliminarCargo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarCargo.Size = new System.Drawing.Size(88, 36);
            this.eliminarCargo.TabIndex = 1;
            this.eliminarCargo.Text = "Eliminar";
            this.eliminarCargo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarCargo.UseAccentColor = false;
            this.eliminarCargo.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(257, 233);
            this.dataGridView1.TabIndex = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioActivo);
            this.groupBox2.Controls.Add(this.radioInactivo);
            this.groupBox2.Location = new System.Drawing.Point(76, 266);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(97, 67);
            this.groupBox2.TabIndex = 65;
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
            // tipoEmpleados
            // 
            this.tipoEmpleados.Location = new System.Drawing.Point(16, 126);
            this.tipoEmpleados.Name = "tipoEmpleados";
            this.tipoEmpleados.Size = new System.Drawing.Size(187, 20);
            this.tipoEmpleados.TabIndex = 66;
            // 
            // tipoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 371);
            this.Controls.Add(this.tipoEmpleados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tipoEmpleado";
            this.Text = "Tipo De Empleado";
            this.Load += new System.EventHandler(this.tipoEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton buscarCargo;
        private MaterialSkin.Controls.MaterialButton modificarEmpleado;
        private MaterialSkin.Controls.MaterialButton eliminarCargo;
        private MaterialSkin.Controls.MaterialButton ingresarTipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioActivo;
        private System.Windows.Forms.RadioButton radioInactivo;
        private System.Windows.Forms.TextBox tipoEmpleados;
    }
}
