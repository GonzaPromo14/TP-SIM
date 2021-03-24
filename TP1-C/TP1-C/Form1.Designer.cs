namespace TP1_C
{
    partial class frmPrincipal
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
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.grdNumeros = new System.Windows.Forms.DataGridView();
            this.colPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiguienteX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnMultiplicativo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMetodoElegido = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Ingresar variables";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xo";
            // 
            // txtXo
            // 
            this.txtXo.Enabled = false;
            this.txtXo.Location = new System.Drawing.Point(66, 96);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 20);
            this.txtXo.TabIndex = 5;
            this.txtXo.TextChanged += new System.EventHandler(this.txtXo_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Enabled = false;
            this.txtG.Location = new System.Drawing.Point(66, 119);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 6;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // txtK
            // 
            this.txtK.Enabled = false;
            this.txtK.Location = new System.Drawing.Point(66, 141);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 7;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(66, 163);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(43, 255);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(152, 23);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // grdNumeros
            // 
            this.grdNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPos,
            this.colFormula,
            this.colSiguienteX,
            this.colNumeroGenerado});
            this.grdNumeros.Location = new System.Drawing.Point(241, 77);
            this.grdNumeros.Name = "grdNumeros";
            this.grdNumeros.Size = new System.Drawing.Size(444, 288);
            this.grdNumeros.TabIndex = 10;
            // 
            // colPos
            // 
            this.colPos.HeaderText = "Posición";
            this.colPos.Name = "colPos";
            // 
            // colFormula
            // 
            this.colFormula.HeaderText = "a*Xi + c";
            this.colFormula.Name = "colFormula";
            // 
            // colSiguienteX
            // 
            this.colSiguienteX.HeaderText = "x(i+1)";
            this.colSiguienteX.Name = "colSiguienteX";
            // 
            // colNumeroGenerado
            // 
            this.colNumeroGenerado.HeaderText = "x(i+1)/m-1";
            this.colNumeroGenerado.Name = "colNumeroGenerado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Elegir método";
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(89, 4);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(75, 23);
            this.btnLineal.TabIndex = 12;
            this.btnLineal.Text = "Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.Location = new System.Drawing.Point(170, 4);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(83, 23);
            this.btnMultiplicativo.TabIndex = 13;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.Click += new System.EventHandler(this.btnMultiplicativo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.Location = new System.Drawing.Point(43, 284);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(152, 23);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(66, 189);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 15;
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(66, 215);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Método elegido:";
            // 
            // lblMetodoElegido
            // 
            this.lblMetodoElegido.AutoSize = true;
            this.lblMetodoElegido.Location = new System.Drawing.Point(418, 9);
            this.lblMetodoElegido.Name = "lblMetodoElegido";
            this.lblMetodoElegido.Size = new System.Drawing.Size(0, 13);
            this.lblMetodoElegido.TabIndex = 20;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(339, 36);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 21;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMetodoElegido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnMultiplicativo);
            this.Controls.Add(this.btnLineal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdNumeros);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtXo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Name = "frmPrincipal";
            this.Text = "Trabajo práctico 1 Simulación";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView grdNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiguienteX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroGenerado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnMultiplicativo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMetodoElegido;
        private System.Windows.Forms.Label lblError;
    }
}

