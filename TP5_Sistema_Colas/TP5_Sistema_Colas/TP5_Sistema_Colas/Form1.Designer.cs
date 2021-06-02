namespace TP5_Sistema_Colas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtCantSimulaciones = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvSimulaciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCamiones = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMostrarRnd = new System.Windows.Forms.Button();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExceso = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPorcInsInadeciadas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colNumeroSimulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstalacionesInadecuadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorcentajeInad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de simulaciones ------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde ------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta -------------------------------------";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.txtCantSimulaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de datos";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(159, 69);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 7;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(159, 46);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 7;
            // 
            // txtCantSimulaciones
            // 
            this.txtCantSimulaciones.Location = new System.Drawing.Point(159, 24);
            this.txtCantSimulaciones.Name = "txtCantSimulaciones";
            this.txtCantSimulaciones.Size = new System.Drawing.Size(100, 20);
            this.txtCantSimulaciones.TabIndex = 6;
            this.txtCantSimulaciones.Text = "500";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "SIMULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSimulaciones
            // 
            this.dgvSimulaciones.AllowUserToAddRows = false;
            this.dgvSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroSimulacion,
            this.colEvento,
            this.colReloj,
            this.ColInstalacionesInadecuadas,
            this.colPorcentaje});
            this.dgvSimulaciones.EnableHeadersVisualStyles = false;
            this.dgvSimulaciones.Location = new System.Drawing.Point(12, 168);
            this.dgvSimulaciones.Name = "dgvSimulaciones";
            this.dgvSimulaciones.RowHeadersVisible = false;
            this.dgvSimulaciones.Size = new System.Drawing.Size(1346, 291);
            this.dgvSimulaciones.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Camiones en predio ----------------";
            // 
            // txtCamiones
            // 
            this.txtCamiones.Location = new System.Drawing.Point(159, 46);
            this.txtCamiones.Name = "txtCamiones";
            this.txtCamiones.ReadOnly = true;
            this.txtCamiones.Size = new System.Drawing.Size(155, 20);
            this.txtCamiones.TabIndex = 9;
            this.txtCamiones.Text = "0";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(12, 465);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 13;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(1283, 465);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 14;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(738, 470);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(73, 13);
            this.lblPagina.TabIndex = 15;
            this.lblPagina.Text = "Página 0 de 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 662);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ocultar columnas ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMostrarRnd
            // 
            this.btnMostrarRnd.Location = new System.Drawing.Point(12, 662);
            this.btnMostrarRnd.Name = "btnMostrarRnd";
            this.btnMostrarRnd.Size = new System.Drawing.Size(127, 27);
            this.btnMostrarRnd.TabIndex = 17;
            this.btnMostrarRnd.Text = "Mostrar columnas";
            this.btnMostrarRnd.UseVisualStyleBackColor = true;
            this.btnMostrarRnd.Click += new System.EventHandler(this.btnMostrarRnd_Click);
            // 
            // dgvFinal
            // 
            this.dgvFinal.AllowUserToAddRows = false;
            this.dgvFinal.AllowUserToResizeColumns = false;
            this.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.colPorcentajeInad});
            this.dgvFinal.EnableHeadersVisualStyles = false;
            this.dgvFinal.Location = new System.Drawing.Point(12, 515);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.RowHeadersVisible = false;
            this.dgvFinal.Size = new System.Drawing.Size(1346, 104);
            this.dgvFinal.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Primer exceso de capacidad ---";
            // 
            // txtExceso
            // 
            this.txtExceso.Location = new System.Drawing.Point(159, 24);
            this.txtExceso.Multiline = true;
            this.txtExceso.Name = "txtExceso";
            this.txtExceso.ReadOnly = true;
            this.txtExceso.Size = new System.Drawing.Size(155, 20);
            this.txtExceso.TabIndex = 20;
            this.txtExceso.Text = "-";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(309, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Resumen de zonas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSemana);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtExceso);
            this.groupBox2.Controls.Add(this.txtCamiones);
            this.groupBox2.Location = new System.Drawing.Point(323, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 124);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metricas";
            // 
            // lblPorcInsInadeciadas
            // 
            this.lblPorcInsInadeciadas.AutoSize = true;
            this.lblPorcInsInadeciadas.ForeColor = System.Drawing.Color.Red;
            this.lblPorcInsInadeciadas.Location = new System.Drawing.Point(970, 36);
            this.lblPorcInsInadeciadas.Name = "lblPorcInsInadeciadas";
            this.lblPorcInsInadeciadas.Size = new System.Drawing.Size(13, 13);
            this.lblPorcInsInadeciadas.TabIndex = 24;
            this.lblPorcInsInadeciadas.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Porcentaje de simulaciones donde hay exceso de capacidad:";
            // 
            // colNumeroSimulacion
            // 
            this.colNumeroSimulacion.HeaderText = "Número";
            this.colNumeroSimulacion.Name = "colNumeroSimulacion";
            // 
            // colEvento
            // 
            this.colEvento.HeaderText = "Evento";
            this.colEvento.Name = "colEvento";
            // 
            // colReloj
            // 
            this.colReloj.HeaderText = "Reloj";
            this.colReloj.Name = "colReloj";
            // 
            // ColInstalacionesInadecuadas
            // 
            this.ColInstalacionesInadecuadas.HeaderText = "Instalaciones Inadecuadas";
            this.ColInstalacionesInadecuadas.Name = "ColInstalacionesInadecuadas";
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.HeaderText = "Porcentaje de inadecuación";
            this.colPorcentaje.Name = "colPorcentaje";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Evento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Reloj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Instalaciones inadecuadas";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // colPorcentajeInad
            // 
            this.colPorcentajeInad.HeaderText = "Porcentaje de inadecuación";
            this.colPorcentajeInad.Name = "colPorcentajeInad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Aumentar capacidad a partir de la semana: ";
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.ForeColor = System.Drawing.Color.Red;
            this.lblSemana.Location = new System.Drawing.Point(572, 49);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(13, 13);
            this.lblSemana.TabIndex = 25;
            this.lblSemana.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPorcInsInadeciadas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvFinal);
            this.Controls.Add(this.btnMostrarRnd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dgvSimulaciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TP5 Sistemas de colas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtCantSimulaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvSimulaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCamiones;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMostrarRnd;
        private System.Windows.Forms.DataGridView dgvFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExceso;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPorcInsInadeciadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstalacionesInadecuadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentajeInad;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.Label label7;
    }
}

