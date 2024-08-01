
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
            this.label5 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(16, 196);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(187, 20);
            this.Descripcion.TabIndex = 15;
            // 
            // idCargo
            // 
            this.idCargo.Location = new System.Drawing.Point(171, 84);
            this.idCargo.Name = "idCargo";
            this.idCargo.Size = new System.Drawing.Size(32, 20);
            this.idCargo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Estatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buscarCargo);
            this.groupBox1.Controls.Add(this.modificarEmpleado);
            this.groupBox1.Controls.Add(this.eliminarCargo);
            this.groupBox1.Controls.Add(this.ingresarCargo);
            this.groupBox1.Location = new System.Drawing.Point(208, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(148, 233);
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
            // ingresarCargo
            // 
            this.ingresarCargo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarCargo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarCargo.Depth = 0;
            this.ingresarCargo.HighEmphasis = true;
            this.ingresarCargo.Icon = null;
            this.ingresarCargo.Location = new System.Drawing.Point(38, 31);
            this.ingresarCargo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.cargos.Location = new System.Drawing.Point(16, 144);
            this.cargos.Name = "cargos";
            this.cargos.Size = new System.Drawing.Size(187, 20);
            this.cargos.TabIndex = 59;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 60;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioInactivo
            // 
            this.radioInactivo.AutoSize = true;
            this.radioInactivo.Location = new System.Drawing.Point(128, 279);
            this.radioInactivo.Name = "radioInactivo";
            this.radioInactivo.Size = new System.Drawing.Size(63, 17);
            this.radioInactivo.TabIndex = 61;
            this.radioInactivo.TabStop = true;
            this.radioInactivo.Text = "Inactivo";
            this.radioInactivo.UseVisualStyleBackColor = true;
            // 
            // radioActivo
            // 
            this.radioActivo.AutoSize = true;
            this.radioActivo.Location = new System.Drawing.Point(26, 279);
            this.radioActivo.Name = "radioActivo";
            this.radioActivo.Size = new System.Drawing.Size(55, 17);
            this.radioActivo.TabIndex = 62;
            this.radioActivo.TabStop = true;
            this.radioActivo.Text = "Activo";
            this.radioActivo.UseVisualStyleBackColor = true;
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 331);
            this.Controls.Add(this.radioActivo);
            this.Controls.Add(this.radioInactivo);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cargos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.idCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cargo";
            this.Text = "Cargo De Empleado";
            this.Load += new System.EventHandler(this.Cargo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox idCargo;
        private System.Windows.Forms.Label label5;
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
    }
}
