
namespace TP3.GUILayer
{
    partial class Form2
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
            this.dataGridFrecuencias = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esperados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumEsperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTabulado = new System.Windows.Forms.TextBox();
            this.txtValorCalculado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptarBondad = new System.Windows.Forms.Button();
            this.cmbConfianza = new System.Windows.Forms.ComboBox();
            this.lblGradosDeLibertad = new System.Windows.Forms.Label();
            this.txtGradosLibertad = new System.Windows.Forms.TextBox();
            this.lblRechazo = new System.Windows.Forms.Label();
            this.grbResultados = new System.Windows.Forms.GroupBox();
            this.lblHipotesis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFrecuencias
            // 
            this.dataGridFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Min,
            this.Max,
            this.Observados,
            this.ProbObs,
            this.AcumObs,
            this.Esperados,
            this.ProbEsp,
            this.AcumEsperado,
            this.c,
            this.cAc});
            this.dataGridFrecuencias.Location = new System.Drawing.Point(12, 129);
            this.dataGridFrecuencias.Name = "dataGridFrecuencias";
            this.dataGridFrecuencias.RowHeadersVisible = false;
            this.dataGridFrecuencias.Size = new System.Drawing.Size(565, 150);
            this.dataGridFrecuencias.TabIndex = 52;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // Min
            // 
            this.Min.HeaderText = "Li";
            this.Min.Name = "Min";
            // 
            // Max
            // 
            this.Max.HeaderText = "Ls";
            this.Max.Name = "Max";
            // 
            // Observados
            // 
            this.Observados.HeaderText = "Observados";
            this.Observados.Name = "Observados";
            // 
            // ProbObs
            // 
            this.ProbObs.HeaderText = "P(Oi)";
            this.ProbObs.Name = "ProbObs";
            // 
            // AcumObs
            // 
            this.AcumObs.HeaderText = "Acumulado (Oi)";
            this.AcumObs.Name = "AcumObs";
            // 
            // Esperados
            // 
            this.Esperados.HeaderText = "Esperados";
            this.Esperados.Name = "Esperados";
            // 
            // ProbEsp
            // 
            this.ProbEsp.HeaderText = "P(Ei)";
            this.ProbEsp.Name = "ProbEsp";
            // 
            // AcumEsperado
            // 
            this.AcumEsperado.HeaderText = "Acumulado (Ei)";
            this.AcumEsperado.Name = "AcumEsperado";
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            // 
            // cAc
            // 
            this.cAc.HeaderText = "C(AC)";
            this.cAc.Name = "cAc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Valor tabulado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Valor calculado";
            // 
            // txtValorTabulado
            // 
            this.txtValorTabulado.Enabled = false;
            this.txtValorTabulado.Location = new System.Drawing.Point(105, 32);
            this.txtValorTabulado.Name = "txtValorTabulado";
            this.txtValorTabulado.Size = new System.Drawing.Size(100, 20);
            this.txtValorTabulado.TabIndex = 56;
            // 
            // txtValorCalculado
            // 
            this.txtValorCalculado.Enabled = false;
            this.txtValorCalculado.Location = new System.Drawing.Point(105, 54);
            this.txtValorCalculado.Name = "txtValorCalculado";
            this.txtValorCalculado.Size = new System.Drawing.Size(100, 20);
            this.txtValorCalculado.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nivel de confianza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHipotesis);
            this.groupBox1.Controls.Add(this.cmbConfianza);
            this.groupBox1.Controls.Add(this.btnAceptarBondad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 100);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // btnAceptarBondad
            // 
            this.btnAceptarBondad.Enabled = false;
            this.btnAceptarBondad.Location = new System.Drawing.Point(189, 71);
            this.btnAceptarBondad.Name = "btnAceptarBondad";
            this.btnAceptarBondad.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBondad.TabIndex = 61;
            this.btnAceptarBondad.Text = "Aceptar";
            this.btnAceptarBondad.UseVisualStyleBackColor = true;
            this.btnAceptarBondad.Click += new System.EventHandler(this.btnAceptarBondad_Click);
            // 
            // cmbConfianza
            // 
            this.cmbConfianza.FormattingEnabled = true;
            this.cmbConfianza.Items.AddRange(new object[] {
            "0,995",
            "0,99",
            "0,975",
            "0,95",
            "0,9",
            "0,75",
            "0,25",
            "0,1",
            "0,05",
            "0,025",
            "0,01",
            "0,005"});
            this.cmbConfianza.Location = new System.Drawing.Point(107, 36);
            this.cmbConfianza.Name = "cmbConfianza";
            this.cmbConfianza.Size = new System.Drawing.Size(121, 21);
            this.cmbConfianza.TabIndex = 61;
            this.cmbConfianza.SelectedIndexChanged += new System.EventHandler(this.cmbConfianza_SelectedIndexChanged);
            // 
            // lblGradosDeLibertad
            // 
            this.lblGradosDeLibertad.AutoSize = true;
            this.lblGradosDeLibertad.Location = new System.Drawing.Point(6, 13);
            this.lblGradosDeLibertad.Name = "lblGradosDeLibertad";
            this.lblGradosDeLibertad.Size = new System.Drawing.Size(93, 13);
            this.lblGradosDeLibertad.TabIndex = 61;
            this.lblGradosDeLibertad.Text = "Grados de libertad";
            // 
            // txtGradosLibertad
            // 
            this.txtGradosLibertad.Enabled = false;
            this.txtGradosLibertad.Location = new System.Drawing.Point(105, 10);
            this.txtGradosLibertad.Name = "txtGradosLibertad";
            this.txtGradosLibertad.Size = new System.Drawing.Size(100, 20);
            this.txtGradosLibertad.TabIndex = 62;
            // 
            // lblRechazo
            // 
            this.lblRechazo.AutoSize = true;
            this.lblRechazo.Location = new System.Drawing.Point(6, 87);
            this.lblRechazo.Name = "lblRechazo";
            this.lblRechazo.Size = new System.Drawing.Size(0, 13);
            this.lblRechazo.TabIndex = 63;
            // 
            // grbResultados
            // 
            this.grbResultados.Controls.Add(this.lblGradosDeLibertad);
            this.grbResultados.Controls.Add(this.lblRechazo);
            this.grbResultados.Controls.Add(this.label1);
            this.grbResultados.Controls.Add(this.txtGradosLibertad);
            this.grbResultados.Controls.Add(this.label2);
            this.grbResultados.Controls.Add(this.txtValorTabulado);
            this.grbResultados.Controls.Add(this.txtValorCalculado);
            this.grbResultados.Location = new System.Drawing.Point(302, 12);
            this.grbResultados.Name = "grbResultados";
            this.grbResultados.Size = new System.Drawing.Size(266, 100);
            this.grbResultados.TabIndex = 64;
            this.grbResultados.TabStop = false;
            this.grbResultados.Visible = false;
            // 
            // lblHipotesis
            // 
            this.lblHipotesis.AutoSize = true;
            this.lblHipotesis.Location = new System.Drawing.Point(6, 17);
            this.lblHipotesis.Name = "lblHipotesis";
            this.lblHipotesis.Size = new System.Drawing.Size(182, 13);
            this.lblHipotesis.TabIndex = 62;
            this.lblHipotesis.Text = "Los números poseen una distribución";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 395);
            this.Controls.Add(this.grbResultados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridFrecuencias);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbResultados.ResumeLayout(false);
            this.grbResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFrecuencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esperados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumEsperado;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTabulado;
        private System.Windows.Forms.TextBox txtValorCalculado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbConfianza;
        private System.Windows.Forms.Button btnAceptarBondad;
        private System.Windows.Forms.Label lblGradosDeLibertad;
        private System.Windows.Forms.TextBox txtGradosLibertad;
        private System.Windows.Forms.Label lblRechazo;
        private System.Windows.Forms.Label lblHipotesis;
        private System.Windows.Forms.GroupBox grbResultados;
    }
}