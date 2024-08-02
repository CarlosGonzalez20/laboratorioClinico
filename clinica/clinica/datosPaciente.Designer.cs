﻿
namespace clinica
{
    partial class datosPaciente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.expedienteNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tipoSangrePaciente = new System.Windows.Forms.ComboBox();
            this.nombresPaciente = new System.Windows.Forms.TextBox();
            this.telefonoPaciente = new System.Windows.Forms.TextBox();
            this.direccionPaciente = new System.Windows.Forms.TextBox();
            this.sexoPaciente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contraseñaPaciente = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.estatusPaciente = new System.Windows.Forms.GroupBox();
            this.estadoInactivo = new System.Windows.Forms.RadioButton();
            this.estatusActivo = new System.Windows.Forms.RadioButton();
            this.fechaIngPaciente = new System.Windows.Forms.DateTimePicker();
            this.fechaNacPaciente = new System.Windows.Forms.DateTimePicker();
            this.medicamentosPaciente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.alergiasPaciente = new System.Windows.Forms.TextBox();
            this.seguroPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.correoPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidosPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.documentoIdentificacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.telefonoEmergencias = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.relacionEmergencias = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nombreEmergencias = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eliminarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.buscarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.modificarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.ingresarPaciente = new MaterialSkin.Controls.MaterialButton();
            this.infoPacientes = new System.Windows.Forms.DataGridView();
            this.tipoUsuario = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.estatusPaciente.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // expedienteNo
            // 
            this.expedienteNo.Location = new System.Drawing.Point(20, 48);
            this.expedienteNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.expedienteNo.Name = "expedienteNo";
            this.expedienteNo.Size = new System.Drawing.Size(79, 22);
            this.expedienteNo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expediente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombres";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha de nacimiento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(837, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Sexo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(593, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Tipo de sangre";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(94, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 17;
            // 
            // tipoSangrePaciente
            // 
            this.tipoSangrePaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoSangrePaciente.FormattingEnabled = true;
            this.tipoSangrePaciente.Location = new System.Drawing.Point(597, 102);
            this.tipoSangrePaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoSangrePaciente.Name = "tipoSangrePaciente";
            this.tipoSangrePaciente.Size = new System.Drawing.Size(100, 24);
            this.tipoSangrePaciente.TabIndex = 19;
            // 
            // nombresPaciente
            // 
            this.nombresPaciente.Location = new System.Drawing.Point(275, 48);
            this.nombresPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombresPaciente.Name = "nombresPaciente";
            this.nombresPaciente.Size = new System.Drawing.Size(287, 22);
            this.nombresPaciente.TabIndex = 20;
            // 
            // telefonoPaciente
            // 
            this.telefonoPaciente.Location = new System.Drawing.Point(20, 103);
            this.telefonoPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonoPaciente.Name = "telefonoPaciente";
            this.telefonoPaciente.Size = new System.Drawing.Size(115, 22);
            this.telefonoPaciente.TabIndex = 21;
            // 
            // direccionPaciente
            // 
            this.direccionPaciente.Location = new System.Drawing.Point(141, 103);
            this.direccionPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccionPaciente.Name = "direccionPaciente";
            this.direccionPaciente.Size = new System.Drawing.Size(255, 22);
            this.direccionPaciente.TabIndex = 22;
            // 
            // sexoPaciente
            // 
            this.sexoPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexoPaciente.FormattingEnabled = true;
            this.sexoPaciente.Location = new System.Drawing.Point(840, 46);
            this.sexoPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sexoPaciente.Name = "sexoPaciente";
            this.sexoPaciente.Size = new System.Drawing.Size(100, 24);
            this.sexoPaciente.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipoUsuario);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.contraseñaPaciente);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.estatusPaciente);
            this.groupBox1.Controls.Add(this.fechaIngPaciente);
            this.groupBox1.Controls.Add(this.fechaNacPaciente);
            this.groupBox1.Controls.Add(this.medicamentosPaciente);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.alergiasPaciente);
            this.groupBox1.Controls.Add(this.seguroPaciente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.correoPaciente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.apellidosPaciente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tipoSangrePaciente);
            this.groupBox1.Controls.Add(this.expedienteNo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nombresPaciente);
            this.groupBox1.Controls.Add(this.sexoPaciente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.direccionPaciente);
            this.groupBox1.Controls.Add(this.documentoIdentificacion);
            this.groupBox1.Controls.Add(this.telefonoPaciente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(20, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(957, 301);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // contraseñaPaciente
            // 
            this.contraseñaPaciente.Location = new System.Drawing.Point(20, 267);
            this.contraseñaPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseñaPaciente.Name = "contraseñaPaciente";
            this.contraseñaPaciente.Size = new System.Drawing.Size(115, 22);
            this.contraseñaPaciente.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 248);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 17);
            this.label20.TabIndex = 43;
            this.label20.Text = "Contraseña";
            // 
            // estatusPaciente
            // 
            this.estatusPaciente.Controls.Add(this.estadoInactivo);
            this.estatusPaciente.Controls.Add(this.estatusActivo);
            this.estatusPaciente.Location = new System.Drawing.Point(789, 138);
            this.estatusPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusPaciente.Name = "estatusPaciente";
            this.estatusPaciente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.estatusPaciente.Size = new System.Drawing.Size(159, 100);
            this.estatusPaciente.TabIndex = 42;
            this.estatusPaciente.TabStop = false;
            this.estatusPaciente.Text = "Estatus del Paciente";
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
            // fechaIngPaciente
            // 
            this.fechaIngPaciente.Location = new System.Drawing.Point(565, 214);
            this.fechaIngPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaIngPaciente.Name = "fechaIngPaciente";
            this.fechaIngPaciente.Size = new System.Drawing.Size(209, 22);
            this.fechaIngPaciente.TabIndex = 41;
            // 
            // fechaNacPaciente
            // 
            this.fechaNacPaciente.Location = new System.Drawing.Point(565, 158);
            this.fechaNacPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaNacPaciente.Name = "fechaNacPaciente";
            this.fechaNacPaciente.Size = new System.Drawing.Size(209, 22);
            this.fechaNacPaciente.TabIndex = 40;
            // 
            // medicamentosPaciente
            // 
            this.medicamentosPaciente.Location = new System.Drawing.Point(20, 214);
            this.medicamentosPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medicamentosPaciente.Name = "medicamentosPaciente";
            this.medicamentosPaciente.Size = new System.Drawing.Size(528, 22);
            this.medicamentosPaciente.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(563, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Fecha de registro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Medicamentos que consume";
            // 
            // alergiasPaciente
            // 
            this.alergiasPaciente.Location = new System.Drawing.Point(20, 158);
            this.alergiasPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alergiasPaciente.Name = "alergiasPaciente";
            this.alergiasPaciente.Size = new System.Drawing.Size(528, 22);
            this.alergiasPaciente.TabIndex = 32;
            // 
            // seguroPaciente
            // 
            this.seguroPaciente.Location = new System.Drawing.Point(703, 103);
            this.seguroPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seguroPaciente.Name = "seguroPaciente";
            this.seguroPaciente.Size = new System.Drawing.Size(245, 22);
            this.seguroPaciente.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Alergias";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(700, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 17);
            this.label13.TabIndex = 35;
            this.label13.Text = "Proveedor de seguro";
            // 
            // correoPaciente
            // 
            this.correoPaciente.Location = new System.Drawing.Point(405, 103);
            this.correoPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.correoPaciente.Name = "correoPaciente";
            this.correoPaciente.Size = new System.Drawing.Size(185, 22);
            this.correoPaciente.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Correo Electrónico";
            // 
            // apellidosPaciente
            // 
            this.apellidosPaciente.Location = new System.Drawing.Point(565, 48);
            this.apellidosPaciente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellidosPaciente.Name = "apellidosPaciente";
            this.apellidosPaciente.Size = new System.Drawing.Size(268, 22);
            this.apellidosPaciente.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellidos";
            // 
            // documentoIdentificacion
            // 
            this.documentoIdentificacion.Location = new System.Drawing.Point(125, 48);
            this.documentoIdentificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.documentoIdentificacion.Name = "documentoIdentificacion";
            this.documentoIdentificacion.Size = new System.Drawing.Size(140, 22);
            this.documentoIdentificacion.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "No. Identificación";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.telefonoEmergencias);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.relacionEmergencias);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.nombreEmergencias);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(20, 393);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(581, 135);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de contacto de emergencia";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // telefonoEmergencias
            // 
            this.telefonoEmergencias.Location = new System.Drawing.Point(271, 97);
            this.telefonoEmergencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonoEmergencias.Name = "telefonoEmergencias";
            this.telefonoEmergencias.Size = new System.Drawing.Size(115, 22);
            this.telefonoEmergencias.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(268, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 27;
            this.label19.Text = "Teléfono";
            // 
            // relacionEmergencias
            // 
            this.relacionEmergencias.Location = new System.Drawing.Point(20, 97);
            this.relacionEmergencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relacionEmergencias.Name = "relacionEmergencias";
            this.relacionEmergencias.Size = new System.Drawing.Size(245, 22);
            this.relacionEmergencias.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 17);
            this.label17.TabIndex = 25;
            this.label17.Text = "Relación con el Paciente";
            // 
            // nombreEmergencias
            // 
            this.nombreEmergencias.Location = new System.Drawing.Point(20, 47);
            this.nombreEmergencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreEmergencias.Name = "nombreEmergencias";
            this.nombreEmergencias.Size = new System.Drawing.Size(543, 22);
            this.nombreEmergencias.TabIndex = 24;
            this.nombreEmergencias.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Nombre Completo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eliminarPaciente);
            this.groupBox2.Controls.Add(this.buscarPaciente);
            this.groupBox2.Controls.Add(this.modificarPaciente);
            this.groupBox2.Controls.Add(this.ingresarPaciente);
            this.groupBox2.Location = new System.Drawing.Point(649, 393);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(301, 135);
            this.groupBox2.TabIndex = 35;
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
            this.eliminarPaciente.Location = new System.Drawing.Point(185, 82);
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
            this.buscarPaciente.Location = new System.Drawing.Point(31, 33);
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
            this.modificarPaciente.Location = new System.Drawing.Point(31, 82);
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
            this.ingresarPaciente.Location = new System.Drawing.Point(185, 33);
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
            this.ingresarPaciente.Click += new System.EventHandler(this.ingresarPaciente_Click);
            // 
            // infoPacientes
            // 
            this.infoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoPacientes.Location = new System.Drawing.Point(20, 546);
            this.infoPacientes.Name = "infoPacientes";
            this.infoPacientes.RowHeadersWidth = 51;
            this.infoPacientes.RowTemplate.Height = 24;
            this.infoPacientes.Size = new System.Drawing.Size(957, 316);
            this.infoPacientes.TabIndex = 36;
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tipoUsuario.FormattingEnabled = true;
            this.tipoUsuario.Location = new System.Drawing.Point(165, 265);
            this.tipoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(100, 24);
            this.tipoUsuario.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Tipo de usuario";
            // 
            // datosPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 884);
            this.Controls.Add(this.infoPacientes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "datosPaciente";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.Text = "Datos del Paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.estatusPaciente.ResumeLayout(false);
            this.estatusPaciente.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox expedienteNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox tipoSangrePaciente;
        private System.Windows.Forms.TextBox nombresPaciente;
        private System.Windows.Forms.TextBox telefonoPaciente;
        private System.Windows.Forms.TextBox direccionPaciente;
        private System.Windows.Forms.ComboBox sexoPaciente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox apellidosPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox documentoIdentificacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox seguroPaciente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox medicamentosPaciente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox alergiasPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox correoPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox relacionEmergencias;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox nombreEmergencias;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox telefonoEmergencias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox estatusPaciente;
        private System.Windows.Forms.RadioButton estadoInactivo;
        private System.Windows.Forms.RadioButton estatusActivo;
        private System.Windows.Forms.DateTimePicker fechaIngPaciente;
        private System.Windows.Forms.DateTimePicker fechaNacPaciente;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton eliminarPaciente;
        private MaterialSkin.Controls.MaterialButton buscarPaciente;
        private MaterialSkin.Controls.MaterialButton modificarPaciente;
        private MaterialSkin.Controls.MaterialButton ingresarPaciente;
        private System.Windows.Forms.DataGridView infoPacientes;
        private System.Windows.Forms.TextBox contraseñaPaciente;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox tipoUsuario;
        private System.Windows.Forms.Label label11;
    }
}

