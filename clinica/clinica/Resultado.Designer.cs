
namespace clinica
{
    partial class Resultado
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
            this.dataresultados = new System.Windows.Forms.DataGridView();
            this.Inac = new System.Windows.Forms.RadioButton();
            this.Act = new System.Windows.Forms.RadioButton();
            this.Est = new System.Windows.Forms.Label();
            this.medicamentos = new System.Windows.Forms.Label();
            this.Buscar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MedicamentoID = new System.Windows.Forms.ComboBox();
            this.ExamenMedico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataresultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataresultados
            // 
            this.dataresultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataresultados.Location = new System.Drawing.Point(48, 404);
            this.dataresultados.Name = "dataresultados";
            this.dataresultados.RowHeadersWidth = 51;
            this.dataresultados.RowTemplate.Height = 24;
            this.dataresultados.Size = new System.Drawing.Size(598, 150);
            this.dataresultados.TabIndex = 113;
            // 
            // Inac
            // 
            this.Inac.AutoSize = true;
            this.Inac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inac.Location = new System.Drawing.Point(713, 266);
            this.Inac.Name = "Inac";
            this.Inac.Size = new System.Drawing.Size(115, 33);
            this.Inac.TabIndex = 112;
            this.Inac.TabStop = true;
            this.Inac.Text = "Inactivo";
            this.Inac.UseVisualStyleBackColor = true;
            // 
            // Act
            // 
            this.Act.AutoSize = true;
            this.Act.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Act.Location = new System.Drawing.Point(713, 226);
            this.Act.Name = "Act";
            this.Act.Size = new System.Drawing.Size(98, 33);
            this.Act.TabIndex = 111;
            this.Act.TabStop = true;
            this.Act.Text = "Activo";
            this.Act.UseVisualStyleBackColor = true;
            // 
            // Est
            // 
            this.Est.AutoSize = true;
            this.Est.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Est.Location = new System.Drawing.Point(712, 181);
            this.Est.Name = "Est";
            this.Est.Size = new System.Drawing.Size(91, 29);
            this.Est.TabIndex = 110;
            this.Est.Text = "Estatus";
            // 
            // medicamentos
            // 
            this.medicamentos.AutoSize = true;
            this.medicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicamentos.Location = new System.Drawing.Point(63, 318);
            this.medicamentos.Name = "medicamentos";
            this.medicamentos.Size = new System.Drawing.Size(195, 25);
            this.medicamentos.TabIndex = 108;
            this.medicamentos.Text = "ID de medicamentos ";
            this.medicamentos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Buscar
            // 
            this.Buscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Buscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Buscar.Depth = 0;
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.HighEmphasis = true;
            this.Buscar.Icon = null;
            this.Buscar.Location = new System.Drawing.Point(712, 477);
            this.Buscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Buscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Buscar.Name = "Buscar";
            this.Buscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Buscar.Size = new System.Drawing.Size(77, 36);
            this.Buscar.TabIndex = 107;
            this.Buscar.Text = "Buscar";
            this.Buscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Buscar.UseAccentColor = false;
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(712, 429);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(91, 36);
            this.materialButton3.TabIndex = 106;
            this.materialButton3.Text = "Ingresar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 105;
            this.label3.Text = "ID de examen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 190);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 104;
            this.label2.Text = "Fecha entrega de resultados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.MedicamentoID);
            this.groupBox1.Controls.Add(this.ExamenMedico);
            this.groupBox1.Location = new System.Drawing.Point(48, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 283);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(306, 90);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 22);
            this.dateTimePicker1.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "ID Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(306, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 27);
            this.textBox1.TabIndex = 73;
            // 
            // MedicamentoID
            // 
            this.MedicamentoID.FormattingEnabled = true;
            this.MedicamentoID.Location = new System.Drawing.Point(306, 216);
            this.MedicamentoID.Name = "MedicamentoID";
            this.MedicamentoID.Size = new System.Drawing.Size(257, 24);
            this.MedicamentoID.TabIndex = 98;
            // 
            // ExamenMedico
            // 
            this.ExamenMedico.FormattingEnabled = true;
            this.ExamenMedico.Location = new System.Drawing.Point(306, 151);
            this.ExamenMedico.Name = "ExamenMedico";
            this.ExamenMedico.Size = new System.Drawing.Size(257, 24);
            this.ExamenMedico.TabIndex = 96;
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 596);
            this.Controls.Add(this.dataresultados);
            this.Controls.Add(this.Inac);
            this.Controls.Add(this.Act);
            this.Controls.Add(this.Est);
            this.Controls.Add(this.medicamentos);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.Load += new System.EventHandler(this.Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataresultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataresultados;
        private System.Windows.Forms.RadioButton Inac;
        private System.Windows.Forms.RadioButton Act;
        private System.Windows.Forms.Label Est;
        private System.Windows.Forms.Label medicamentos;
        private MaterialSkin.Controls.MaterialButton Buscar;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox MedicamentoID;
        private System.Windows.Forms.ComboBox ExamenMedico;
    }
}