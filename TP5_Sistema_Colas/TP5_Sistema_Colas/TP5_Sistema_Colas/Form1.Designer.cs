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
            this.media1 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.btnCamiones = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.colNumeroSimulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrarRnd = new System.Windows.Forms.Button();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de simulaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
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
            this.txtHasta.Location = new System.Drawing.Point(50, 69);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 7;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(50, 46);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 7;
            // 
            // txtCantSimulaciones
            // 
            this.txtCantSimulaciones.Location = new System.Drawing.Point(139, 24);
            this.txtCantSimulaciones.Name = "txtCantSimulaciones";
            this.txtCantSimulaciones.Size = new System.Drawing.Size(100, 20);
            this.txtCantSimulaciones.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvSimulaciones
            // 
            this.dgvSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroSimulacion,
            this.colEvento,
            this.colReloj});
            this.dgvSimulaciones.EnableHeadersVisualStyles = false;
            this.dgvSimulaciones.Location = new System.Drawing.Point(12, 168);
            this.dgvSimulaciones.Name = "dgvSimulaciones";
            this.dgvSimulaciones.Size = new System.Drawing.Size(1346, 291);
            this.dgvSimulaciones.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Camiones en predio";
            // 
            // txtCamiones
            // 
            this.txtCamiones.Location = new System.Drawing.Point(880, 35);
            this.txtCamiones.Name = "txtCamiones";
            this.txtCamiones.ReadOnly = true;
            this.txtCamiones.Size = new System.Drawing.Size(58, 20);
            this.txtCamiones.TabIndex = 9;
            this.txtCamiones.Text = "0";
            // 
            // media1
            // 
            this.media1.AutoSize = true;
            this.media1.Location = new System.Drawing.Point(774, 68);
            this.media1.Name = "media1";
            this.media1.Size = new System.Drawing.Size(73, 13);
            this.media1.TabIndex = 10;
            this.media1.Text = "Media Zona 1";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(880, 65);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(58, 20);
            this.txtMedia.TabIndex = 11;
            this.txtMedia.Text = "0";
            // 
            // btnCamiones
            // 
            this.btnCamiones.Location = new System.Drawing.Point(839, 107);
            this.btnCamiones.Name = "btnCamiones";
            this.btnCamiones.Size = new System.Drawing.Size(99, 29);
            this.btnCamiones.TabIndex = 12;
            this.btnCamiones.Text = "Ver camiones";
            this.btnCamiones.UseVisualStyleBackColor = true;
            this.btnCamiones.Click += new System.EventHandler(this.btnCamiones_Click);
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
            this.button2.Location = new System.Drawing.Point(12, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Ocultar RND";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // btnMostrarRnd
            // 
            this.btnMostrarRnd.Location = new System.Drawing.Point(144, 142);
            this.btnMostrarRnd.Name = "btnMostrarRnd";
            this.btnMostrarRnd.Size = new System.Drawing.Size(127, 23);
            this.btnMostrarRnd.TabIndex = 17;
            this.btnMostrarRnd.Text = "Mostrar RND";
            this.btnMostrarRnd.UseVisualStyleBackColor = true;
            // 
            // dgvFinal
            // 
            this.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvFinal.EnableHeadersVisualStyles = false;
            this.dgvFinal.Location = new System.Drawing.Point(12, 515);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.Size = new System.Drawing.Size(1346, 104);
            this.dgvFinal.TabIndex = 18;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgvFinal);
            this.Controls.Add(this.btnMostrarRnd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnCamiones);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.media1);
            this.Controls.Add(this.txtCamiones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSimulaciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TP5 Sistemas de colas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
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
        private System.Windows.Forms.Label media1;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Button btnCamiones;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReloj;
        private System.Windows.Forms.Button btnMostrarRnd;
        private System.Windows.Forms.DataGridView dgvFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

