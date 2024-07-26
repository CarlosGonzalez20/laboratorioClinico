
namespace clinica
{
    partial class Medicina
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
            this.expedienteNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.estatusPaciente = new System.Windows.Forms.GroupBox();
            this.estadoInactivo = new System.Windows.Forms.RadioButton();
            this.estatusActivo = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.buscarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.modificarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.ingresarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estatusPaciente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // expedienteNo
            // 
            this.expedienteNo.Location = new System.Drawing.Point(30, 119);
            this.expedienteNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expedienteNo.Name = "expedienteNo";
            this.expedienteNo.Size = new System.Drawing.Size(86, 22);
            this.expedienteNo.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "No. Serie";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(30, 170);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(201, 22);
            this.textBox13.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 269);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 22);
            this.textBox1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cantidad";
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 213);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 24);
            this.comboBox2.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Proveedor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(137, 269);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Precio";
            // 
            // estatusPaciente
            // 
            this.estatusPaciente.Controls.Add(this.estadoInactivo);
            this.estatusPaciente.Controls.Add(this.estatusActivo);
            this.estatusPaciente.Location = new System.Drawing.Point(51, 363);
            this.estatusPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusPaciente.Name = "estatusPaciente";
            this.estatusPaciente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusPaciente.Size = new System.Drawing.Size(152, 100);
            this.estatusPaciente.TabIndex = 59;
            this.estatusPaciente.TabStop = false;
            this.estatusPaciente.Text = "Estatus";
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 324);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 22);
            this.textBox3.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Descripcion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(137, 119);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 22);
            this.textBox4.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 62;
            this.label5.Text = "No. Barra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminarPaciente);
            this.groupBox2.Controls.Add(this.buscarPaciente);
            this.groupBox2.Controls.Add(this.modificarPaciente);
            this.groupBox2.Controls.Add(this.ingresarPaciente);
            this.groupBox2.Location = new System.Drawing.Point(259, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 268);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento";
            // 
            // eliminarPaciente
            // 
            this.eliminarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.eliminarPaciente.Depth = 0;
            this.eliminarPaciente.HighEmphasis = true;
            this.eliminarPaciente.Icon = null;
            this.eliminarPaciente.Location = new System.Drawing.Point(27, 85);
            this.eliminarPaciente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarPaciente.Name = "eliminarPaciente";
            this.eliminarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.eliminarPaciente.Size = new System.Drawing.Size(88, 36);
            this.eliminarPaciente.TabIndex = 6;
            this.eliminarPaciente.Text = "eliminar";
            this.eliminarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.eliminarPaciente.UseAccentColor = false;
            this.eliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // buscarPaciente
            // 
            this.buscarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buscarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buscarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buscarPaciente.Depth = 0;
            this.buscarPaciente.HighEmphasis = true;
            this.buscarPaciente.Icon = null;
            this.buscarPaciente.Location = new System.Drawing.Point(27, 134);
            this.buscarPaciente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buscarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarPaciente.Name = "buscarPaciente";
            this.buscarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buscarPaciente.Size = new System.Drawing.Size(77, 36);
            this.buscarPaciente.TabIndex = 5;
            this.buscarPaciente.Text = "buscar";
            this.buscarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buscarPaciente.UseAccentColor = false;
            this.buscarPaciente.UseVisualStyleBackColor = true;
            // 
            // modificarPaciente
            // 
            this.modificarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.modificarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.modificarPaciente.Depth = 0;
            this.modificarPaciente.HighEmphasis = true;
            this.modificarPaciente.Icon = null;
            this.modificarPaciente.Location = new System.Drawing.Point(27, 187);
            this.modificarPaciente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.modificarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.modificarPaciente.Name = "modificarPaciente";
            this.modificarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.modificarPaciente.Size = new System.Drawing.Size(99, 36);
            this.modificarPaciente.TabIndex = 4;
            this.modificarPaciente.Text = "modificar";
            this.modificarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.modificarPaciente.UseAccentColor = false;
            this.modificarPaciente.UseVisualStyleBackColor = true;
            // 
            // ingresarPaciente
            // 
            this.ingresarPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ingresarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresarPaciente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ingresarPaciente.Depth = 0;
            this.ingresarPaciente.HighEmphasis = true;
            this.ingresarPaciente.Icon = null;
            this.ingresarPaciente.Location = new System.Drawing.Point(27, 33);
            this.ingresarPaciente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ingresarPaciente.MouseState = MaterialSkin.MouseState.HOVER;
            this.ingresarPaciente.Name = "ingresarPaciente";
            this.ingresarPaciente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ingresarPaciente.Size = new System.Drawing.Size(91, 36);
            this.ingresarPaciente.TabIndex = 3;
            this.ingresarPaciente.Text = "Ingresar";
            this.ingresarPaciente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ingresarPaciente.UseAccentColor = false;
            this.ingresarPaciente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(438, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 364);
            this.dataGridView1.TabIndex = 65;
            // 
            // Medicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.estatusPaciente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expedienteNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label10);
            this.Name = "Medicina";
            this.Text = "Medicina";
            this.Load += new System.EventHandler(this.Medicina_Load);
            this.estatusPaciente.ResumeLayout(false);
            this.estatusPaciente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expedienteNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox estatusPaciente;
        private System.Windows.Forms.RadioButton estadoInactivo;
        private System.Windows.Forms.RadioButton estatusActivo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton eliminarPaciente;
        private MaterialSkin.Controls.MaterialButton buscarPaciente;
        private MaterialSkin.Controls.MaterialButton modificarPaciente;
        private MaterialSkin.Controls.MaterialButton ingresarPaciente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}