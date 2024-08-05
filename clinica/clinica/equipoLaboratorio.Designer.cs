
namespace clinica
{
    partial class equipoLaboratorio
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
            this.eliminarEquipo = new MaterialSkin.Controls.MaterialButton();
            this.buscarEquipo = new MaterialSkin.Controls.MaterialButton();
            this.modificarEquipo = new MaterialSkin.Controls.MaterialButton();
            this.ingresarEquipo = new MaterialSkin.Controls.MaterialButton();
            this.fechaActualizacion = new System.Windows.Forms.DateTimePicker();
            this.fechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.descripcionEquipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.equipoNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proveedorEquipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clinica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreEquipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadEquipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.estatusPaciente = new System.Windows.Forms.GroupBox();
            this.estatusInactivo = new System.Windows.Forms.RadioButton();
            this.estatusActivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estadoCambiar = new System.Windows.Forms.RadioButton();
            this.estadoBueno = new System.Windows.Forms.RadioButton();
            this.estadoExcelente = new System.Windows.Forms.RadioButton();
            this.infoEquipo = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.estatusPaciente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminarEquipo);
            this.groupBox2.Controls.Add(this.buscarEquipo);
            this.groupBox2.Controls.Add(this.modificarEquipo);
            this.groupBox2.Controls.Add(this.ingresarEquipo);
            this.groupBox2.Location = new System.Drawing.Point(21, 286);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(474, 95);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento";
            // 
            // eliminarEquipo
            // 
            this.eliminarEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarEquipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarEquipo.Depth = 0;
            this.eliminarEquipo.HighEmphasis = true;
            this.eliminarEquipo.Icon = null;
            this.eliminarEquipo.Location = new System.Drawing.Point(358, 33);
            this.eliminarEquipo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarEquipo.Name = "eliminarEquipo";
            this.eliminarEquipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarEquipo.Size = new System.Drawing.Size(88, 36);
            this.eliminarEquipo.TabIndex = 6;
            this.eliminarEquipo.Text = "eliminar";
            this.eliminarEquipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarEquipo.UseAccentColor = false;
            this.eliminarEquipo.UseVisualStyleBackColor = true;
            this.eliminarEquipo.Click += new System.EventHandler(this.eliminarEquipo_Click);
            // 
            // buscarEquipo
            // 
            this.buscarEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarEquipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarEquipo.Depth = 0;
            this.buscarEquipo.HighEmphasis = true;
            this.buscarEquipo.Icon = null;
            this.buscarEquipo.Location = new System.Drawing.Point(31, 33);
            this.buscarEquipo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buscarEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarEquipo.Name = "buscarEquipo";
            this.buscarEquipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarEquipo.Size = new System.Drawing.Size(77, 36);
            this.buscarEquipo.TabIndex = 5;
            this.buscarEquipo.Text = "buscar";
            this.buscarEquipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarEquipo.UseAccentColor = false;
            this.buscarEquipo.UseVisualStyleBackColor = true;
            this.buscarEquipo.Click += new System.EventHandler(this.buscarEquipo_Click);
            // 
            // modificarEquipo
            // 
            this.modificarEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarEquipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarEquipo.Depth = 0;
            this.modificarEquipo.HighEmphasis = true;
            this.modificarEquipo.Icon = null;
            this.modificarEquipo.Location = new System.Drawing.Point(240, 33);
            this.modificarEquipo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.modificarEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarEquipo.Name = "modificarEquipo";
            this.modificarEquipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarEquipo.Size = new System.Drawing.Size(99, 36);
            this.modificarEquipo.TabIndex = 4;
            this.modificarEquipo.Text = "modificar";
            this.modificarEquipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarEquipo.UseAccentColor = false;
            this.modificarEquipo.UseVisualStyleBackColor = true;
            this.modificarEquipo.Click += new System.EventHandler(this.modificarEquipo_Click);
            // 
            // ingresarEquipo
            // 
            this.ingresarEquipo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarEquipo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarEquipo.Depth = 0;
            this.ingresarEquipo.HighEmphasis = true;
            this.ingresarEquipo.Icon = null;
            this.ingresarEquipo.Location = new System.Drawing.Point(130, 33);
            this.ingresarEquipo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ingresarEquipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarEquipo.Name = "ingresarEquipo";
            this.ingresarEquipo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarEquipo.Size = new System.Drawing.Size(91, 36);
            this.ingresarEquipo.TabIndex = 3;
            this.ingresarEquipo.Text = "Ingresar";
            this.ingresarEquipo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarEquipo.UseAccentColor = false;
            this.ingresarEquipo.UseVisualStyleBackColor = true;
            this.ingresarEquipo.Click += new System.EventHandler(this.ingresarEquipo_Click);
            // 
            // fechaActualizacion
            // 
            this.fechaActualizacion.Location = new System.Drawing.Point(236, 242);
            this.fechaActualizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaActualizacion.Name = "fechaActualizacion";
            this.fechaActualizacion.Size = new System.Drawing.Size(209, 22);
            this.fechaActualizacion.TabIndex = 45;
            // 
            // fechaAdquisicion
            // 
            this.fechaAdquisicion.Location = new System.Drawing.Point(19, 242);
            this.fechaAdquisicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaAdquisicion.Name = "fechaAdquisicion";
            this.fechaAdquisicion.Size = new System.Drawing.Size(209, 22);
            this.fechaAdquisicion.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(234, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "Fecha de Actualización";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Fecha de adquisición";
            // 
            // descripcionEquipo
            // 
            this.descripcionEquipo.Location = new System.Drawing.Point(20, 194);
            this.descripcionEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcionEquipo.Name = "descripcionEquipo";
            this.descripcionEquipo.Size = new System.Drawing.Size(425, 22);
            this.descripcionEquipo.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Descripción";
            // 
            // equipoNo
            // 
            this.equipoNo.Location = new System.Drawing.Point(20, 97);
            this.equipoNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.equipoNo.Name = "equipoNo";
            this.equipoNo.Size = new System.Drawing.Size(102, 22);
            this.equipoNo.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Número equipo";
            // 
            // proveedorEquipo
            // 
            this.proveedorEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proveedorEquipo.FormattingEnabled = true;
            this.proveedorEquipo.Location = new System.Drawing.Point(128, 95);
            this.proveedorEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proveedorEquipo.Name = "proveedorEquipo";
            this.proveedorEquipo.Size = new System.Drawing.Size(100, 24);
            this.proveedorEquipo.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Proveedor";
            // 
            // clinica
            // 
            this.clinica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clinica.FormattingEnabled = true;
            this.clinica.Location = new System.Drawing.Point(234, 95);
            this.clinica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clinica.Name = "clinica";
            this.clinica.Size = new System.Drawing.Size(100, 24);
            this.clinica.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Clínica";
            // 
            // nombreEquipo
            // 
            this.nombreEquipo.Location = new System.Drawing.Point(21, 148);
            this.nombreEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreEquipo.Name = "nombreEquipo";
            this.nombreEquipo.Size = new System.Drawing.Size(424, 22);
            this.nombreEquipo.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Nombres";
            // 
            // cantidadEquipo
            // 
            this.cantidadEquipo.Location = new System.Drawing.Point(343, 97);
            this.cantidadEquipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantidadEquipo.Name = "cantidadEquipo";
            this.cantidadEquipo.Size = new System.Drawing.Size(102, 22);
            this.cantidadEquipo.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Cantidad";
            // 
            // estatusPaciente
            // 
            this.estatusPaciente.Controls.Add(this.estatusInactivo);
            this.estatusPaciente.Controls.Add(this.estatusActivo);
            this.estatusPaciente.Location = new System.Drawing.Point(530, 242);
            this.estatusPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusPaciente.Name = "estatusPaciente";
            this.estatusPaciente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusPaciente.Size = new System.Drawing.Size(159, 100);
            this.estatusPaciente.TabIndex = 58;
            this.estatusPaciente.TabStop = false;
            this.estatusPaciente.Text = "Estatus";
            // 
            // estatusInactivo
            // 
            this.estatusInactivo.AutoSize = true;
            this.estatusInactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estatusInactivo.Location = new System.Drawing.Point(45, 60);
            this.estatusInactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusInactivo.Name = "estatusInactivo";
            this.estatusInactivo.Size = new System.Drawing.Size(77, 21);
            this.estatusInactivo.TabIndex = 40;
            this.estatusInactivo.TabStop = true;
            this.estatusInactivo.Text = "Inactivo";
            this.estatusInactivo.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estadoCambiar);
            this.groupBox1.Controls.Add(this.estadoBueno);
            this.groupBox1.Controls.Add(this.estadoExcelente);
            this.groupBox1.Location = new System.Drawing.Point(530, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(159, 125);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado del equipo";
            // 
            // estadoCambiar
            // 
            this.estadoCambiar.AutoSize = true;
            this.estadoCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoCambiar.Location = new System.Drawing.Point(30, 85);
            this.estadoCambiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoCambiar.Name = "estadoCambiar";
            this.estadoCambiar.Size = new System.Drawing.Size(105, 21);
            this.estadoCambiar.TabIndex = 41;
            this.estadoCambiar.TabStop = true;
            this.estadoCambiar.Text = "Por cambiar";
            this.estadoCambiar.UseVisualStyleBackColor = true;
            this.estadoCambiar.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // estadoBueno
            // 
            this.estadoBueno.AutoSize = true;
            this.estadoBueno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoBueno.Location = new System.Drawing.Point(30, 60);
            this.estadoBueno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoBueno.Name = "estadoBueno";
            this.estadoBueno.Size = new System.Drawing.Size(70, 21);
            this.estadoBueno.TabIndex = 40;
            this.estadoBueno.TabStop = true;
            this.estadoBueno.Text = "Bueno";
            this.estadoBueno.UseVisualStyleBackColor = true;
            // 
            // estadoExcelente
            // 
            this.estadoExcelente.AutoSize = true;
            this.estadoExcelente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.estadoExcelente.Location = new System.Drawing.Point(30, 33);
            this.estadoExcelente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estadoExcelente.Name = "estadoExcelente";
            this.estadoExcelente.Size = new System.Drawing.Size(90, 21);
            this.estadoExcelente.TabIndex = 39;
            this.estadoExcelente.TabStop = true;
            this.estadoExcelente.Text = "Excelente";
            this.estadoExcelente.UseVisualStyleBackColor = true;
            // 
            // infoEquipo
            // 
            this.infoEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoEquipo.Location = new System.Drawing.Point(721, 79);
            this.infoEquipo.Name = "infoEquipo";
            this.infoEquipo.RowHeadersWidth = 51;
            this.infoEquipo.RowTemplate.Height = 24;
            this.infoEquipo.Size = new System.Drawing.Size(419, 302);
            this.infoEquipo.TabIndex = 60;
            // 
            // equipoLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 401);
            this.Controls.Add(this.infoEquipo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.estatusPaciente);
            this.Controls.Add(this.cantidadEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clinica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proveedorEquipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.equipoNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descripcionEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaActualizacion);
            this.Controls.Add(this.fechaAdquisicion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Name = "equipoLaboratorio";
            this.Text = "Equipo de Laboratorio";
            this.Load += new System.EventHandler(this.equipoLaboratorio_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.estatusPaciente.ResumeLayout(false);
            this.estatusPaciente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton eliminarEquipo;
        private MaterialSkin.Controls.MaterialButton buscarEquipo;
        private MaterialSkin.Controls.MaterialButton modificarEquipo;
        private MaterialSkin.Controls.MaterialButton ingresarEquipo;
        private System.Windows.Forms.DateTimePicker fechaActualizacion;
        private System.Windows.Forms.DateTimePicker fechaAdquisicion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox descripcionEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox equipoNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox proveedorEquipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox clinica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cantidadEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox estatusPaciente;
        private System.Windows.Forms.RadioButton estatusInactivo;
        private System.Windows.Forms.RadioButton estatusActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton estadoCambiar;
        private System.Windows.Forms.RadioButton estadoBueno;
        private System.Windows.Forms.RadioButton estadoExcelente;
        private System.Windows.Forms.DataGridView infoEquipo;
    }
}