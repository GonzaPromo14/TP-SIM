
namespace TP5_Sistema_Colas
{
    partial class FormZonas
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
            this.dgvZonas = new System.Windows.Forms.DataGridView();
            this.colZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempoTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantCamiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZonas
            // 
            this.dgvZonas.AllowUserToAddRows = false;
            this.dgvZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colZona,
            this.colEstado,
            this.colCola,
            this.colMedias,
            this.colTiempoTrabajo,
            this.colCantCamiones});
            this.dgvZonas.Location = new System.Drawing.Point(12, 12);
            this.dgvZonas.Name = "dgvZonas";
            this.dgvZonas.Size = new System.Drawing.Size(776, 228);
            this.dgvZonas.TabIndex = 0;
            this.dgvZonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZonas_CellContentClick);
            // 
            // colZona
            // 
            this.colZona.HeaderText = "Zona";
            this.colZona.Name = "colZona";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colCola
            // 
            this.colCola.HeaderText = "Camiones en zona";
            this.colCola.Name = "colCola";
            // 
            // colMedias
            // 
            this.colMedias.HeaderText = "Media llegadas";
            this.colMedias.Name = "colMedias";
            // 
            // colTiempoTrabajo
            // 
            this.colTiempoTrabajo.HeaderText = "Tiempo trabajado";
            this.colTiempoTrabajo.Name = "colTiempoTrabajo";
            // 
            // colCantCamiones
            // 
            this.colCantCamiones.HeaderText = "Cantidad de camiones que atendió";
            this.colCantCamiones.Name = "colCantCamiones";
            // 
            // FormZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.dgvZonas);
            this.Name = "FormZonas";
            this.Text = "FormZonas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempoTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantCamiones;
    }
}