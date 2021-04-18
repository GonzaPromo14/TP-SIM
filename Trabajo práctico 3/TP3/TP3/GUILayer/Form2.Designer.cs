
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
            this.lblPasaPrueba = new System.Windows.Forms.Label();
            this.txtValorTabulado = new System.Windows.Forms.TextBox();
            this.txtValorCalculado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGradosDeLibertad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).BeginInit();
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
            this.dataGridFrecuencias.Location = new System.Drawing.Point(12, 174);
            this.dataGridFrecuencias.Name = "dataGridFrecuencias";
            this.dataGridFrecuencias.RowHeadersVisible = false;
            this.dataGridFrecuencias.Size = new System.Drawing.Size(1032, 150);
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
            this.label1.Location = new System.Drawing.Point(52, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Valor tabulado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Valor calculado";
            // 
            // lblPasaPrueba
            // 
            this.lblPasaPrueba.AutoSize = true;
            this.lblPasaPrueba.Location = new System.Drawing.Point(116, 410);
            this.lblPasaPrueba.Name = "lblPasaPrueba";
            this.lblPasaPrueba.Size = new System.Drawing.Size(0, 13);
            this.lblPasaPrueba.TabIndex = 55;
            // 
            // txtValorTabulado
            // 
            this.txtValorTabulado.Location = new System.Drawing.Point(133, 350);
            this.txtValorTabulado.Name = "txtValorTabulado";
            this.txtValorTabulado.Size = new System.Drawing.Size(100, 20);
            this.txtValorTabulado.TabIndex = 56;
            // 
            // txtValorCalculado
            // 
            this.txtValorCalculado.Location = new System.Drawing.Point(133, 372);
            this.txtValorCalculado.Name = "txtValorCalculado";
            this.txtValorCalculado.Size = new System.Drawing.Size(100, 20);
            this.txtValorCalculado.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Nivel de confianza";
            // 
            // lblGradosDeLibertad
            // 
            this.lblGradosDeLibertad.AutoSize = true;
            this.lblGradosDeLibertad.Location = new System.Drawing.Point(57, 79);
            this.lblGradosDeLibertad.Name = "lblGradosDeLibertad";
            this.lblGradosDeLibertad.Size = new System.Drawing.Size(99, 13);
            this.lblGradosDeLibertad.TabIndex = 59;
            this.lblGradosDeLibertad.Text = "Grados de libertad: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.lblGradosDeLibertad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorCalculado);
            this.Controls.Add(this.txtValorTabulado);
            this.Controls.Add(this.lblPasaPrueba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridFrecuencias);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblPasaPrueba;
        private System.Windows.Forms.TextBox txtValorTabulado;
        private System.Windows.Forms.TextBox txtValorCalculado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGradosDeLibertad;
    }
}