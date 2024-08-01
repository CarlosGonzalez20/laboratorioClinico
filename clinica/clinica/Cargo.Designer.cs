
namespace clinica
{
    partial class Cargo
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
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.idCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buscarCargo = new MaterialSkin.Controls.MaterialButton();
            this.modificarEmpleado = new MaterialSkin.Controls.MaterialButton();
            this.eliminarCargo = new MaterialSkin.Controls.MaterialButton();
            this.ingresarCargo = new MaterialSkin.Controls.MaterialButton();
            this.cargos = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioInactivo = new System.Windows.Forms.RadioButton();
            this.radioActivo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(21, 241);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(248, 22);
            this.Descripcion.TabIndex = 15;
            // 
            // idCargo
            // 
            this.idCargo.Location = new System.Drawing.Point(115, 117);
            this.idCargo.Margin = new System.Windows.Forms.Padding(4);
            this.idCargo.Name = "idCargo";
            this.idCargo.Size = new System.Drawing.Size(41, 22);
            this.idCargo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarCargo);
            this.groupBox1.Controls.Add(this.modificarEmpleado);
            this.groupBox1.Controls.Add(this.eliminarCargo);
            this.groupBox1.Controls.Add(this.ingresarCargo);
            this.groupBox1.Location = new System.Drawing.Point(277, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(197, 287);
            this.groupBox1.TabIndex = 58;
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
            this.buscarCargo.Location = new System.Drawing.Point(51, 166);
            this.buscarCargo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.modificarEmpleado.Location = new System.Drawing.Point(51, 228);
            this.modificarEmpleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.eliminarCargo.Location = new System.Drawing.Point(51, 103);
            this.eliminarCargo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // ingresarCargo
            // 
            this.ingresarCargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarCargo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarCargo.Depth = 0;
            this.ingresarCargo.HighEmphasis = true;
            this.ingresarCargo.Icon = null;
            this.ingresarCargo.Location = new System.Drawing.Point(51, 38);
            this.ingresarCargo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ingresarCargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarCargo.Name = "ingresarCargo";
            this.ingresarCargo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarCargo.Size = new System.Drawing.Size(91, 36);
            this.ingresarCargo.TabIndex = 0;
            this.ingresarCargo.Text = "Ingresar";
            this.ingresarCargo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarCargo.UseAccentColor = false;
            this.ingresarCargo.UseVisualStyleBackColor = true;
            this.ingresarCargo.Click += new System.EventHandler(this.ingresarPaciente_Click);
            // 
            // cargos
            // 
            this.cargos.Location = new System.Drawing.Point(21, 177);
            this.cargos.Margin = new System.Windows.Forms.Padding(4);
            this.cargos.Name = "cargos";
            this.cargos.Size = new System.Drawing.Size(248, 22);
            this.cargos.TabIndex = 59;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-20, -18);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 60;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioInactivo
            // 
            this.radioInactivo.AutoSize = true;
            this.radioInactivo.Location = new System.Drawing.Point(31, 49);
            this.radioInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.radioInactivo.Name = "radioInactivo";
            this.radioInactivo.Size = new System.Drawing.Size(77, 21);
            this.radioInactivo.TabIndex = 61;
            this.radioInactivo.TabStop = true;
            this.radioInactivo.Text = "Inactivo";
            this.radioInactivo.UseVisualStyleBackColor = true;
            // 
            // radioActivo
            // 
            this.radioActivo.AutoSize = true;
            this.radioActivo.Location = new System.Drawing.Point(31, 20);
            this.radioActivo.Margin = new System.Windows.Forms.Padding(4);
            this.radioActivo.Name = "radioActivo";
            this.radioActivo.Size = new System.Drawing.Size(67, 21);
            this.radioActivo.TabIndex = 62;
            this.radioActivo.TabStop = true;
            this.radioActivo.Text = "Activo";
            this.radioActivo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(526, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(343, 287);
            this.dataGridView1.TabIndex = 63;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioActivo);
            this.groupBox2.Controls.Add(this.radioInactivo);
            this.groupBox2.Location = new System.Drawing.Point(66, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 83);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cargos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.idCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cargo";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Cargo Personal Laboratorio";
            this.Load += new System.EventHandler(this.Cargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox idCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton buscarCargo;
        private MaterialSkin.Controls.MaterialButton modificarEmpleado;
        private MaterialSkin.Controls.MaterialButton eliminarCargo;
        private MaterialSkin.Controls.MaterialButton ingresarCargo;
        private System.Windows.Forms.TextBox cargos;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioInactivo;
        private System.Windows.Forms.RadioButton radioActivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
