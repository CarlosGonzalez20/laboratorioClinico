
namespace clinica
{
    partial class SOLICITUD_DE_CITAS
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
            this.txtHor = new System.Windows.Forms.TextBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdIc = new System.Windows.Forms.RadioButton();
            this.rdAc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtIDcita = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaCitaMedica = new System.Windows.Forms.DateTimePicker();
            this.IDResultado = new System.Windows.Forms.ComboBox();
            this.IDPaciente = new System.Windows.Forms.ComboBox();
            this.IDMuestra = new System.Windows.Forms.ComboBox();
            this.IDExamenes = new System.Windows.Forms.ComboBox();
            this.IDMedicos = new System.Windows.Forms.ComboBox();
            this.IDClinica = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaCitaMedica);
            this.groupBox1.Controls.Add(this.txtHor);
            this.groupBox1.Controls.Add(this.txtMot);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Citas Medicas.";
            // 
            // txtHor
            // 
            this.txtHor.Location = new System.Drawing.Point(18, 143);
            this.txtHor.Name = "txtHor";
            this.txtHor.Size = new System.Drawing.Size(211, 22);
            this.txtHor.TabIndex = 9;
            // 
            // txtMot
            // 
            this.txtMot.Location = new System.Drawing.Point(18, 98);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(211, 22);
            this.txtMot.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdIc);
            this.groupBox3.Controls.Add(this.rdAc);
            this.groupBox3.Location = new System.Drawing.Point(18, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 91);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estatus de la cita.";
            // 
            // rdIc
            // 
            this.rdIc.AutoSize = true;
            this.rdIc.Location = new System.Drawing.Point(62, 57);
            this.rdIc.Name = "rdIc";
            this.rdIc.Size = new System.Drawing.Size(81, 21);
            this.rdIc.TabIndex = 1;
            this.rdIc.TabStop = true;
            this.rdIc.Text = "Inactivo.";
            this.rdIc.UseVisualStyleBackColor = true;
            // 
            // rdAc
            // 
            this.rdAc.AutoSize = true;
            this.rdAc.Location = new System.Drawing.Point(62, 30);
            this.rdAc.Name = "rdAc";
            this.rdAc.Size = new System.Drawing.Size(71, 21);
            this.rdAc.TabIndex = 0;
            this.rdAc.TabStop = true;
            this.rdAc.Text = "Activo.";
            this.rdAc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(18, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento.";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(103, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Eliminar.";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(6, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar.";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(103, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ingresar.";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de la cita programada.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivo de la cita.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.IDClinica);
            this.groupBox4.Controls.Add(this.IDMedicos);
            this.groupBox4.Controls.Add(this.IDExamenes);
            this.groupBox4.Controls.Add(this.IDMuestra);
            this.groupBox4.Controls.Add(this.IDPaciente);
            this.groupBox4.Controls.Add(this.IDResultado);
            this.groupBox4.Controls.Add(this.txtIDcita);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(286, 108);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(167, 367);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IDs";
            // 
            // txtIDcita
            // 
            this.txtIDcita.Location = new System.Drawing.Point(115, 38);
            this.txtIDcita.Name = "txtIDcita";
            this.txtIDcita.Size = new System.Drawing.Size(46, 22);
            this.txtIDcita.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "ID Cita";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "ID Clinica";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "ID Medicos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID Examenes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID Muestra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID Paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 405);
            this.dataGridView1.TabIndex = 2;
            // 
            // fechaCitaMedica
            // 
            this.fechaCitaMedica.Location = new System.Drawing.Point(18, 53);
            this.fechaCitaMedica.Name = "fechaCitaMedica";
            this.fechaCitaMedica.Size = new System.Drawing.Size(211, 22);
            this.fechaCitaMedica.TabIndex = 10;
            // 
            // IDResultado
            // 
            this.IDResultado.FormattingEnabled = true;
            this.IDResultado.Location = new System.Drawing.Point(45, 96);
            this.IDResultado.Name = "IDResultado";
            this.IDResultado.Size = new System.Drawing.Size(87, 24);
            this.IDResultado.TabIndex = 14;
            // 
            // IDPaciente
            // 
            this.IDPaciente.FormattingEnabled = true;
            this.IDPaciente.Location = new System.Drawing.Point(45, 143);
            this.IDPaciente.Name = "IDPaciente";
            this.IDPaciente.Size = new System.Drawing.Size(87, 24);
            this.IDPaciente.TabIndex = 15;
            // 
            // IDMuestra
            // 
            this.IDMuestra.FormattingEnabled = true;
            this.IDMuestra.Location = new System.Drawing.Point(45, 189);
            this.IDMuestra.Name = "IDMuestra";
            this.IDMuestra.Size = new System.Drawing.Size(87, 24);
            this.IDMuestra.TabIndex = 16;
            // 
            // IDExamenes
            // 
            this.IDExamenes.FormattingEnabled = true;
            this.IDExamenes.Location = new System.Drawing.Point(45, 239);
            this.IDExamenes.Name = "IDExamenes";
            this.IDExamenes.Size = new System.Drawing.Size(87, 24);
            this.IDExamenes.TabIndex = 17;
            // 
            // IDMedicos
            // 
            this.IDMedicos.FormattingEnabled = true;
            this.IDMedicos.Location = new System.Drawing.Point(45, 285);
            this.IDMedicos.Name = "IDMedicos";
            this.IDMedicos.Size = new System.Drawing.Size(87, 24);
            this.IDMedicos.TabIndex = 18;
            // 
            // IDClinica
            // 
            this.IDClinica.FormattingEnabled = true;
            this.IDClinica.Location = new System.Drawing.Point(45, 332);
            this.IDClinica.Name = "IDClinica";
            this.IDClinica.Size = new System.Drawing.Size(87, 24);
            this.IDClinica.TabIndex = 19;
            // 
            // SOLICITUD_DE_CITAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 512);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "SOLICITUD_DE_CITAS";
            this.Text = "SOLICITUD_DE_CITAS";
            this.Load += new System.EventHandler(this.SOLICITUD_DE_CITAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdIc;
        private System.Windows.Forms.RadioButton rdAc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHor;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDcita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fechaCitaMedica;
        private System.Windows.Forms.ComboBox IDClinica;
        private System.Windows.Forms.ComboBox IDMedicos;
        private System.Windows.Forms.ComboBox IDExamenes;
        private System.Windows.Forms.ComboBox IDMuestra;
        private System.Windows.Forms.ComboBox IDPaciente;
        private System.Windows.Forms.ComboBox IDResultado;
    }
}