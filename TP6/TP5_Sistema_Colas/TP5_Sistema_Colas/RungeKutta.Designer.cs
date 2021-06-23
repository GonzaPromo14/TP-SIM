namespace TP5_Sistema_Colas
{
    partial class RungeKutta
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
            this.grdRungeKuttaProxPurga = new System.Windows.Forms.DataGridView();
            this.colTInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colk1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.txtTFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPaginaCamiones = new System.Windows.Forms.Label();
            this.btnSiguientePagina = new System.Windows.Forms.Button();
            this.btnAnteriorPagina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRungeKuttaProxPurga)).BeginInit();
            this.SuspendLayout();
            // 
            // grdRungeKuttaProxPurga
            // 
            this.grdRungeKuttaProxPurga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRungeKuttaProxPurga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTInicial,
            this.colEInicial,
            this.colk1,
            this.colK2,
            this.colK3,
            this.colK4,
            this.colT1,
            this.colE1});
            this.grdRungeKuttaProxPurga.Location = new System.Drawing.Point(27, 137);
            this.grdRungeKuttaProxPurga.Name = "grdRungeKuttaProxPurga";
            this.grdRungeKuttaProxPurga.Size = new System.Drawing.Size(846, 150);
            this.grdRungeKuttaProxPurga.TabIndex = 0;
            // 
            // colTInicial
            // 
            this.colTInicial.HeaderText = "t";
            this.colTInicial.Name = "colTInicial";
            // 
            // colEInicial
            // 
            this.colEInicial.HeaderText = "E";
            this.colEInicial.Name = "colEInicial";
            // 
            // colk1
            // 
            this.colk1.HeaderText = "K1";
            this.colk1.Name = "colk1";
            // 
            // colK2
            // 
            this.colK2.HeaderText = "k2";
            this.colK2.Name = "colK2";
            // 
            // colK3
            // 
            this.colK3.HeaderText = "K3";
            this.colK3.Name = "colK3";
            // 
            // colK4
            // 
            this.colK4.HeaderText = "K4";
            this.colK4.Name = "colK4";
            // 
            // colT1
            // 
            this.colT1.HeaderText = "t+1";
            this.colT1.Name = "colT1";
            // 
            // colE1
            // 
            this.colE1.HeaderText = "E(t+1)";
            this.colE1.Name = "colE1";
            // 
            // txtEInicial
            // 
            this.txtEInicial.Location = new System.Drawing.Point(50, 9);
            this.txtEInicial.Name = "txtEInicial";
            this.txtEInicial.Size = new System.Drawing.Size(100, 20);
            this.txtEInicial.TabIndex = 1;
            this.txtEInicial.Text = "15";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ef";
            // 
            // txtEFinal
            // 
            this.txtEFinal.Location = new System.Drawing.Point(50, 35);
            this.txtEFinal.Name = "txtEFinal";
            this.txtEFinal.Size = new System.Drawing.Size(100, 20);
            this.txtEFinal.TabIndex = 4;
            this.txtEFinal.Text = "300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alfa";
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(50, 62);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(100, 20);
            this.txtAlfa.TabIndex = 6;
            this.txtAlfa.Text = "3";
            // 
            // txtTFinal
            // 
            this.txtTFinal.Enabled = false;
            this.txtTFinal.Location = new System.Drawing.Point(50, 99);
            this.txtTFinal.Name = "txtTFinal";
            this.txtTFinal.Size = new System.Drawing.Size(100, 20);
            this.txtTFinal.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tf";
            // 
            // lblPaginaCamiones
            // 
            this.lblPaginaCamiones.AutoSize = true;
            this.lblPaginaCamiones.Location = new System.Drawing.Point(414, 298);
            this.lblPaginaCamiones.Name = "lblPaginaCamiones";
            this.lblPaginaCamiones.Size = new System.Drawing.Size(73, 13);
            this.lblPaginaCamiones.TabIndex = 19;
            this.lblPaginaCamiones.Text = "Página 0 de 0";
            // 
            // btnSiguientePagina
            // 
            this.btnSiguientePagina.Location = new System.Drawing.Point(798, 293);
            this.btnSiguientePagina.Name = "btnSiguientePagina";
            this.btnSiguientePagina.Size = new System.Drawing.Size(75, 23);
            this.btnSiguientePagina.TabIndex = 18;
            this.btnSiguientePagina.Text = "Siguiente";
            this.btnSiguientePagina.UseVisualStyleBackColor = true;
            this.btnSiguientePagina.Click += new System.EventHandler(this.btnSiguientePagina_Click);
            // 
            // btnAnteriorPagina
            // 
            this.btnAnteriorPagina.Location = new System.Drawing.Point(27, 293);
            this.btnAnteriorPagina.Name = "btnAnteriorPagina";
            this.btnAnteriorPagina.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorPagina.TabIndex = 17;
            this.btnAnteriorPagina.Text = "Anterior";
            this.btnAnteriorPagina.UseVisualStyleBackColor = true;
            this.btnAnteriorPagina.Click += new System.EventHandler(this.btnAnteriorPagina_Click);
            // 
            // RungeKutta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.lblPaginaCamiones);
            this.Controls.Add(this.btnSiguientePagina);
            this.Controls.Add(this.btnAnteriorPagina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTFinal);
            this.Controls.Add(this.txtAlfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEInicial);
            this.Controls.Add(this.grdRungeKuttaProxPurga);
            this.Name = "RungeKutta";
            this.Text = "RungeKutta";
            this.Load += new System.EventHandler(this.RungeKutta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRungeKuttaProxPurga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdRungeKuttaProxPurga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colk1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colE1;
        private System.Windows.Forms.TextBox txtEInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.TextBox txtTFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaginaCamiones;
        private System.Windows.Forms.Button btnSiguientePagina;
        private System.Windows.Forms.Button btnAnteriorPagina;
    }
}