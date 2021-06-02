
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Size = new System.Drawing.Size(700, 425);
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
            // FormCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCamiones";
            this.Text = "FormCamiones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn zonas;
    }
}