
namespace TP5_Sistema_Colas
{
    partial class FormCamiones
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Camion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnteriorPagina = new System.Windows.Forms.Button();
            this.btnSiguientePagina = new System.Windows.Forms.Button();
            this.lblPaginaCamiones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Camion,
            this.estado,
            this.horaLlegada,
            this.horaSalida,
            this.tiempoEspera,
            this.zonas});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // Camion
            // 
            this.Camion.HeaderText = "Camion";
            this.Camion.Name = "Camion";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // horaLlegada
            // 
            this.horaLlegada.HeaderText = "Hora llegada";
            this.horaLlegada.Name = "horaLlegada";
            // 
            // horaSalida
            // 
            this.horaSalida.HeaderText = "Hora salida";
            this.horaSalida.Name = "horaSalida";
            // 
            // tiempoEspera
            // 
            this.tiempoEspera.HeaderText = "Tiempo de espera en cola";
            this.tiempoEspera.Name = "tiempoEspera";
            // 
            // zonas
            // 
            this.zonas.HeaderText = "Pasó por zonas";
            this.zonas.Name = "zonas";
            // 
            // btnAnteriorPagina
            // 
            this.btnAnteriorPagina.Location = new System.Drawing.Point(13, 289);
            this.btnAnteriorPagina.Name = "btnAnteriorPagina";
            this.btnAnteriorPagina.Size = new System.Drawing.Size(75, 23);
            this.btnAnteriorPagina.TabIndex = 14;
            this.btnAnteriorPagina.Text = "Anterior";
            this.btnAnteriorPagina.UseVisualStyleBackColor = true;
            this.btnAnteriorPagina.Click += new System.EventHandler(this.btnAnteriorPagina_Click);
            // 
            // btnSiguientePagina
            // 
            this.btnSiguientePagina.Location = new System.Drawing.Point(638, 289);
            this.btnSiguientePagina.Name = "btnSiguientePagina";
            this.btnSiguientePagina.Size = new System.Drawing.Size(75, 23);
            this.btnSiguientePagina.TabIndex = 15;
            this.btnSiguientePagina.Text = "Siguiente";
            this.btnSiguientePagina.UseVisualStyleBackColor = true;
            this.btnSiguientePagina.Click += new System.EventHandler(this.btnSiguientePagina_Click);
            // 
            // lblPaginaCamiones
            // 
            this.lblPaginaCamiones.AutoSize = true;
            this.lblPaginaCamiones.Location = new System.Drawing.Point(322, 294);
            this.lblPaginaCamiones.Name = "lblPaginaCamiones";
            this.lblPaginaCamiones.Size = new System.Drawing.Size(73, 13);
            this.lblPaginaCamiones.TabIndex = 16;
            this.lblPaginaCamiones.Text = "Página 0 de 0";
            // 
            // FormCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 324);
            this.Controls.Add(this.lblPaginaCamiones);
            this.Controls.Add(this.btnSiguientePagina);
            this.Controls.Add(this.btnAnteriorPagina);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCamiones";
            this.Text = "FormCamiones";
            this.Load += new System.EventHandler(this.FormCamiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonas;
        private System.Windows.Forms.Button btnAnteriorPagina;
        private System.Windows.Forms.Button btnSiguientePagina;
        private System.Windows.Forms.Label lblPaginaCamiones;
    }
}