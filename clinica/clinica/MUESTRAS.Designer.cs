
namespace clinica
{
    partial class MUESTRAS
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EliminarMuestra = new System.Windows.Forms.Button();
            this.ModificarMuestra = new System.Windows.Forms.Button();
            this.IngInfMuestra = new System.Windows.Forms.Button();
            this.BuscarMuestra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdIc = new System.Windows.Forms.RadioButton();
            this.rdAc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDTmuestra = new System.Windows.Forms.TextBox();
            this.txtNomMuestra = new System.Windows.Forms.TextBox();
            this.txtDMuestra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDMuestra);
            this.groupBox1.Controls.Add(this.txtNomMuestra);
            this.groupBox1.Controls.Add(this.txtIDTmuestra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(16, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de muestras.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EliminarMuestra);
            this.groupBox3.Controls.Add(this.ModificarMuestra);
            this.groupBox3.Controls.Add(this.IngInfMuestra);
            this.groupBox3.Controls.Add(this.BuscarMuestra);
            this.groupBox3.Location = new System.Drawing.Point(21, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 116);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mantenimiento.";
            // 
            // EliminarMuestra
            // 
            this.EliminarMuestra.BackColor = System.Drawing.Color.DarkBlue;
            this.EliminarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarMuestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EliminarMuestra.Location = new System.Drawing.Point(110, 69);
            this.EliminarMuestra.Name = "EliminarMuestra";
            this.EliminarMuestra.Size = new System.Drawing.Size(84, 30);
            this.EliminarMuestra.TabIndex = 3;
            this.EliminarMuestra.Text = "Eliminar";
            this.EliminarMuestra.UseVisualStyleBackColor = false;
            this.EliminarMuestra.Click += new System.EventHandler(this.EliminarMuestra_Click);
            // 
            // ModificarMuestra
            // 
            this.ModificarMuestra.BackColor = System.Drawing.Color.DarkBlue;
            this.ModificarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarMuestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ModificarMuestra.Location = new System.Drawing.Point(20, 69);
            this.ModificarMuestra.Name = "ModificarMuestra";
            this.ModificarMuestra.Size = new System.Drawing.Size(84, 30);
            this.ModificarMuestra.TabIndex = 2;
            this.ModificarMuestra.Text = "Modificar";
            this.ModificarMuestra.UseVisualStyleBackColor = false;
            this.ModificarMuestra.Click += new System.EventHandler(this.ModificarMuestra_Click);
            // 
            // IngInfMuestra
            // 
            this.IngInfMuestra.BackColor = System.Drawing.Color.DarkBlue;
            this.IngInfMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IngInfMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngInfMuestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IngInfMuestra.Location = new System.Drawing.Point(110, 33);
            this.IngInfMuestra.Name = "IngInfMuestra";
            this.IngInfMuestra.Size = new System.Drawing.Size(84, 30);
            this.IngInfMuestra.TabIndex = 1;
            this.IngInfMuestra.Text = "Ingresar";
            this.IngInfMuestra.UseVisualStyleBackColor = false;
            this.IngInfMuestra.Click += new System.EventHandler(this.IngInfMuestra_Click);
            // 
            // BuscarMuestra
            // 
            this.BuscarMuestra.BackColor = System.Drawing.Color.DarkBlue;
            this.BuscarMuestra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarMuestra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarMuestra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuscarMuestra.Location = new System.Drawing.Point(20, 33);
            this.BuscarMuestra.Name = "BuscarMuestra";
            this.BuscarMuestra.Size = new System.Drawing.Size(84, 30);
            this.BuscarMuestra.TabIndex = 0;
            this.BuscarMuestra.Text = "Buscar";
            this.BuscarMuestra.UseVisualStyleBackColor = false;
            this.BuscarMuestra.Click += new System.EventHandler(this.BuscarMuestra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdIc);
            this.groupBox2.Controls.Add(this.rdAc);
            this.groupBox2.Location = new System.Drawing.Point(21, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadi de la muestra.";
            // 
            // rdIc
            // 
            this.rdIc.AutoSize = true;
            this.rdIc.Location = new System.Drawing.Point(59, 63);
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
            this.rdAc.Location = new System.Drawing.Point(59, 36);
            this.rdAc.Name = "rdAc";
            this.rdAc.Size = new System.Drawing.Size(71, 21);
            this.rdAc.TabIndex = 0;
            this.rdAc.TabStop = true;
            this.rdAc.Text = "Activo.";
            this.rdAc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID TiMuestra";
            // 
            // txtIDTmuestra
            // 
            this.txtIDTmuestra.Location = new System.Drawing.Point(9, 49);
            this.txtIDTmuestra.Name = "txtIDTmuestra";
            this.txtIDTmuestra.Size = new System.Drawing.Size(50, 22);
            this.txtIDTmuestra.TabIndex = 9;
            // 
            // txtNomMuestra
            // 
            this.txtNomMuestra.Location = new System.Drawing.Point(41, 143);
            this.txtNomMuestra.Name = "txtNomMuestra";
            this.txtNomMuestra.Size = new System.Drawing.Size(176, 22);
            this.txtNomMuestra.TabIndex = 10;
            // 
            // txtDMuestra
            // 
            this.txtDMuestra.Location = new System.Drawing.Point(41, 188);
            this.txtDMuestra.Name = "txtDMuestra";
            this.txtDMuestra.Size = new System.Drawing.Size(176, 22);
            this.txtDMuestra.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre De La Muestra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripcion De La Muestra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(611, 484);
            this.dataGridView1.TabIndex = 1;
            // 
            // MUESTRAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MUESTRAS";
            this.Text = "MUESTRAS";
            this.Load += new System.EventHandler(this.MUESTRAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdAc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button EliminarMuestra;
        private System.Windows.Forms.Button ModificarMuestra;
        private System.Windows.Forms.Button IngInfMuestra;
        private System.Windows.Forms.Button BuscarMuestra;
        private System.Windows.Forms.RadioButton rdIc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDMuestra;
        private System.Windows.Forms.TextBox txtNomMuestra;
        private System.Windows.Forms.TextBox txtIDTmuestra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}