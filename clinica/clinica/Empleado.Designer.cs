
namespace clinica
{
    partial class Empleado
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarempleado = new MaterialSkin.Controls.MaterialButton();
            this.buscarempleado = new MaterialSkin.Controls.MaterialButton();
            this.modificarempleado = new MaterialSkin.Controls.MaterialButton();
            this.ingresarempleado = new MaterialSkin.Controls.MaterialButton();
            this.dataempleado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clinica = new System.Windows.Forms.ComboBox();
            this.tipoempleado = new System.Windows.Forms.ComboBox();
            this.d_trabajo = new System.Windows.Forms.TextBox();
            this.h_trabajo = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estatusEmpleado = new System.Windows.Forms.GroupBox();
            this.estadoInactivo = new System.Windows.Forms.RadioButton();
            this.estatusActivo = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cui = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataempleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.estatusEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminarempleado);
            this.groupBox2.Controls.Add(this.buscarempleado);
            this.groupBox2.Controls.Add(this.modificarempleado);
            this.groupBox2.Controls.Add(this.ingresarempleado);
            this.groupBox2.Location = new System.Drawing.Point(1016, 201);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(169, 228);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento";
            // 
            // eliminarempleado
            // 
            this.eliminarempleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarempleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarempleado.Depth = 0;
            this.eliminarempleado.HighEmphasis = true;
            this.eliminarempleado.Icon = null;
            this.eliminarempleado.Location = new System.Drawing.Point(31, 82);
            this.eliminarempleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarempleado.Name = "eliminarempleado";
            this.eliminarempleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarempleado.Size = new System.Drawing.Size(88, 36);
            this.eliminarempleado.TabIndex = 6;
            this.eliminarempleado.Text = "eliminar";
            this.eliminarempleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarempleado.UseAccentColor = false;
            this.eliminarempleado.UseVisualStyleBackColor = true;
            this.eliminarempleado.Click += new System.EventHandler(this.eliminarempleado_Click);
            // 
            // buscarempleado
            // 
            this.buscarempleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarempleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarempleado.Depth = 0;
            this.buscarempleado.HighEmphasis = true;
            this.buscarempleado.Icon = null;
            this.buscarempleado.Location = new System.Drawing.Point(31, 131);
            this.buscarempleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buscarempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarempleado.Name = "buscarempleado";
            this.buscarempleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarempleado.Size = new System.Drawing.Size(77, 36);
            this.buscarempleado.TabIndex = 5;
            this.buscarempleado.Text = "BUSCAR";
            this.buscarempleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarempleado.UseAccentColor = false;
            this.buscarempleado.UseVisualStyleBackColor = true;
            this.buscarempleado.Click += new System.EventHandler(this.buscarempleado_Click);
            // 
            // modificarempleado
            // 
            this.modificarempleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarempleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarempleado.Depth = 0;
            this.modificarempleado.HighEmphasis = true;
            this.modificarempleado.Icon = null;
            this.modificarempleado.Location = new System.Drawing.Point(31, 183);
            this.modificarempleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.modificarempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarempleado.Name = "modificarempleado";
            this.modificarempleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarempleado.Size = new System.Drawing.Size(99, 36);
            this.modificarempleado.TabIndex = 4;
            this.modificarempleado.Text = "modificar";
            this.modificarempleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarempleado.UseAccentColor = false;
            this.modificarempleado.UseVisualStyleBackColor = true;
            this.modificarempleado.Click += new System.EventHandler(this.modificarempleado_Click);
            // 
            // ingresarempleado
            // 
            this.ingresarempleado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarempleado.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarempleado.Depth = 0;
            this.ingresarempleado.HighEmphasis = true;
            this.ingresarempleado.Icon = null;
            this.ingresarempleado.Location = new System.Drawing.Point(31, 34);
            this.ingresarempleado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ingresarempleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarempleado.Name = "ingresarempleado";
            this.ingresarempleado.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarempleado.Size = new System.Drawing.Size(91, 36);
            this.ingresarempleado.TabIndex = 3;
            this.ingresarempleado.Text = "Ingresar";
            this.ingresarempleado.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarempleado.UseAccentColor = false;
            this.ingresarempleado.UseVisualStyleBackColor = true;
            this.ingresarempleado.Click += new System.EventHandler(this.ingresarempleado_Click);
            // 
            // dataempleado
            // 
            this.dataempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataempleado.Location = new System.Drawing.Point(19, 354);
            this.dataempleado.Name = "dataempleado";
            this.dataempleado.RowHeadersWidth = 51;
            this.dataempleado.RowTemplate.Height = 24;
            this.dataempleado.Size = new System.Drawing.Size(967, 168);
            this.dataempleado.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clinica);
            this.groupBox1.Controls.Add(this.tipoempleado);
            this.groupBox1.Controls.Add(this.d_trabajo);
            this.groupBox1.Controls.Add(this.h_trabajo);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.estatusEmpleado);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cui);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(19, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(967, 248);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Empleados";
            // 
            // clinica
            // 
            this.clinica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clinica.FormattingEnabled = true;
            this.clinica.Location = new System.Drawing.Point(20, 102);
            this.clinica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clinica.Name = "clinica";
            this.clinica.Size = new System.Drawing.Size(138, 24);
            this.clinica.TabIndex = 49;
            // 
            // tipoempleado
            // 
            this.tipoempleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoempleado.FormattingEnabled = true;
            this.tipoempleado.Location = new System.Drawing.Point(339, 156);
            this.tipoempleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoempleado.Name = "tipoempleado";
            this.tipoempleado.Size = new System.Drawing.Size(141, 24);
            this.tipoempleado.TabIndex = 48;
            // 
            // d_trabajo
            // 
            this.d_trabajo.Location = new System.Drawing.Point(175, 158);
            this.d_trabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.d_trabajo.Name = "d_trabajo";
            this.d_trabajo.Size = new System.Drawing.Size(139, 22);
            this.d_trabajo.TabIndex = 47;
            // 
            // h_trabajo
            // 
            this.h_trabajo.Location = new System.Drawing.Point(20, 158);
            this.h_trabajo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.h_trabajo.Name = "h_trabajo";
            this.h_trabajo.Size = new System.Drawing.Size(138, 22);
            this.h_trabajo.TabIndex = 46;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(19, 211);
            this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(295, 22);
            this.email.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Correo Electrónico";
            // 
            // estatusEmpleado
            // 
            this.estatusEmpleado.Controls.Add(this.estadoInactivo);
            this.estatusEmpleado.Controls.Add(this.estatusActivo);
            this.estatusEmpleado.Location = new System.Drawing.Point(777, 50);
            this.estatusEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusEmpleado.Name = "estatusEmpleado";
            this.estatusEmpleado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusEmpleado.Size = new System.Drawing.Size(159, 100);
            this.estatusEmpleado.TabIndex = 42;
            this.estatusEmpleado.TabStop = false;
            this.estatusEmpleado.Text = "Estatus del Empleado";
            // 
            // estadoInactivo
            // 
            this.estadoInactivo.AutoSize = true;
            this.estadoInactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoInactivo.Location = new System.Drawing.Point(45, 60);
            this.estadoInactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoInactivo.Name = "estadoInactivo";
            this.estadoInactivo.Size = new System.Drawing.Size(77, 21);
            this.estadoInactivo.TabIndex = 40;
            this.estadoInactivo.TabStop = true;
            this.estadoInactivo.Text = "Inactivo";
            this.estadoInactivo.UseVisualStyleBackColor = true;
            // 
            // estatusActivo
            // 
            this.estatusActivo.AutoSize = true;
            this.estatusActivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estatusActivo.Location = new System.Drawing.Point(45, 33);
            this.estatusActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusActivo.Name = "estatusActivo";
            this.estatusActivo.Size = new System.Drawing.Size(67, 21);
            this.estatusActivo.TabIndex = 39;
            this.estatusActivo.TabStop = true;
            this.estatusActivo.Text = "Activo";
            this.estatusActivo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Horas de trabajo";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(176, 104);
            this.telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(140, 22);
            this.telefono.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "No Tipo de empleado\r\n";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(496, 156);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker2.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(172, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 17);
            this.label16.TabIndex = 43;
            this.label16.Text = "Dias de trabajo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 100);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(494, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha de ingreso";
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(474, 50);
            this.apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(268, 22);
            this.apellido.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellidos";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(784, 185);
            this.codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(152, 22);
            this.codigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codigo";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(176, 49);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(287, 22);
            this.nombre.TabIndex = 20;
            // 
            // sexo
            // 
            this.sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexo.FormattingEnabled = true;
            this.sexo.Location = new System.Drawing.Point(339, 100);
            this.sexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(139, 24);
            this.sexo.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombres";
            // 
            // cui
            // 
            this.cui.Location = new System.Drawing.Point(18, 50);
            this.cui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cui.Name = "cui";
            this.cui.Size = new System.Drawing.Size(140, 22);
            this.cui.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha de nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "CUI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. Clinica";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataempleado);
            this.Controls.Add(this.groupBox2);
            this.Name = "Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.Empleado_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataempleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.estatusEmpleado.ResumeLayout(false);
            this.estatusEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton eliminarempleado;
        private MaterialSkin.Controls.MaterialButton buscarempleado;
        private MaterialSkin.Controls.MaterialButton modificarempleado;
        private MaterialSkin.Controls.MaterialButton ingresarempleado;
        private System.Windows.Forms.DataGridView dataempleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox clinica;
        private System.Windows.Forms.ComboBox tipoempleado;
        private System.Windows.Forms.TextBox d_trabajo;
        private System.Windows.Forms.TextBox h_trabajo;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox estatusEmpleado;
        private System.Windows.Forms.RadioButton estadoInactivo;
        private System.Windows.Forms.RadioButton estatusActivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cui;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}