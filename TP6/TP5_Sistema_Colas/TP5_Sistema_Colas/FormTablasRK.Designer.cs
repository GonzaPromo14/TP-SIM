
namespace TP5_Sistema_Colas
{
    partial class FormTablasRK
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
            this.dgvRKInestale = new System.Windows.Forms.DataGridView();
            this.ColTInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempoK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColK2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempoK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColK3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTiempoK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColK4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRKPurga = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColL1L0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblT50 = new System.Windows.Forms.Label();
            this.lblT70 = new System.Windows.Forms.Label();
            this.lblT100 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRKInestale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRKPurga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRKInestale
            // 
            this.dgvRKInestale.AllowUserToDeleteRows = false;
            this.dgvRKInestale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRKInestale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTInicial,
            this.ColEInicial,
            this.ColK1,
            this.ColTiempoK2,
            this.ColEK2,
            this.ColK2,
            this.ColTiempoK3,
            this.ColEK3,
            this.ColK3,
            this.ColTiempoK4,
            this.ColEK4,
            this.ColK4});
            this.dgvRKInestale.Location = new System.Drawing.Point(12, 39);
            this.dgvRKInestale.Name = "dgvRKInestale";
            this.dgvRKInestale.ReadOnly = true;
            this.dgvRKInestale.Size = new System.Drawing.Size(964, 208);
            this.dgvRKInestale.TabIndex = 0;
            // 
            // ColTInicial
            // 
            this.ColTInicial.HeaderText = "t";
            this.ColTInicial.Name = "ColTInicial";
            this.ColTInicial.ReadOnly = true;
            // 
            // ColEInicial
            // 
            this.ColEInicial.HeaderText = "E";
            this.ColEInicial.Name = "ColEInicial";
            this.ColEInicial.ReadOnly = true;
            // 
            // ColK1
            // 
            this.ColK1.HeaderText = "K1";
            this.ColK1.Name = "ColK1";
            this.ColK1.ReadOnly = true;
            // 
            // ColTiempoK2
            // 
            this.ColTiempoK2.HeaderText = "t+h/2";
            this.ColTiempoK2.Name = "ColTiempoK2";
            this.ColTiempoK2.ReadOnly = true;
            // 
            // ColEK2
            // 
            this.ColEK2.HeaderText = "E+K1*h/2";
            this.ColEK2.Name = "ColEK2";
            this.ColEK2.ReadOnly = true;
            // 
            // ColK2
            // 
            this.ColK2.HeaderText = "K2";
            this.ColK2.Name = "ColK2";
            this.ColK2.ReadOnly = true;
            // 
            // ColTiempoK3
            // 
            this.ColTiempoK3.HeaderText = "t+h/2";
            this.ColTiempoK3.Name = "ColTiempoK3";
            this.ColTiempoK3.ReadOnly = true;
            // 
            // ColEK3
            // 
            this.ColEK3.HeaderText = "E+K2*h/2";
            this.ColEK3.Name = "ColEK3";
            this.ColEK3.ReadOnly = true;
            // 
            // ColK3
            // 
            this.ColK3.HeaderText = "K3";
            this.ColK3.Name = "ColK3";
            this.ColK3.ReadOnly = true;
            // 
            // ColTiempoK4
            // 
            this.ColTiempoK4.HeaderText = "t+h";
            this.ColTiempoK4.Name = "ColTiempoK4";
            this.ColTiempoK4.ReadOnly = true;
            // 
            // ColEK4
            // 
            this.ColEK4.HeaderText = "E+K3*h";
            this.ColEK4.Name = "ColEK4";
            this.ColEK4.ReadOnly = true;
            // 
            // ColK4
            // 
            this.ColK4.HeaderText = "K4";
            this.ColK4.Name = "ColK4";
            this.ColK4.ReadOnly = true;
            // 
            // dgvRKPurga
            // 
            this.dgvRKPurga.AllowUserToDeleteRows = false;
            this.dgvRKPurga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRKPurga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.ColL1L0});
            this.dgvRKPurga.Location = new System.Drawing.Point(12, 318);
            this.dgvRKPurga.Name = "dgvRKPurga";
            this.dgvRKPurga.ReadOnly = true;
            this.dgvRKPurga.Size = new System.Drawing.Size(964, 238);
            this.dgvRKPurga.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "t";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "L";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "K1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "t+h/2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "L+K1*h/2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "K2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "t+h/2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "L+K2*h/2";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "K3";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "t+h";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "L+K3*h";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "K4";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // ColL1L0
            // 
            this.ColL1L0.HeaderText = "L+1 - L";
            this.ColL1L0.Name = "ColL1L0";
            this.ColL1L0.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tabla Rugen Kutta de Inestabilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tabla Rugen Kutta de Purgacion:";
            // 
            // lblT50
            // 
            this.lblT50.AutoSize = true;
            this.lblT50.Location = new System.Drawing.Point(12, 250);
            this.lblT50.Name = "lblT50";
            this.lblT50.Size = new System.Drawing.Size(35, 13);
            this.lblT50.TabIndex = 4;
            this.lblT50.Text = "label3";
            // 
            // lblT70
            // 
            this.lblT70.AutoSize = true;
            this.lblT70.Location = new System.Drawing.Point(12, 263);
            this.lblT70.Name = "lblT70";
            this.lblT70.Size = new System.Drawing.Size(35, 13);
            this.lblT70.TabIndex = 5;
            this.lblT70.Text = "label4";
            // 
            // lblT100
            // 
            this.lblT100.AutoSize = true;
            this.lblT100.Location = new System.Drawing.Point(12, 276);
            this.lblT100.Name = "lblT100";
            this.lblT100.Size = new System.Drawing.Size(35, 13);
            this.lblT100.TabIndex = 6;
            this.lblT100.Text = "label5";
            // 
            // FormTablasRK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 568);
            this.Controls.Add(this.lblT100);
            this.Controls.Add(this.lblT70);
            this.Controls.Add(this.lblT50);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRKPurga);
            this.Controls.Add(this.dgvRKInestale);
            this.Name = "FormTablasRK";
            this.Text = "FormTablasRK";
            this.Load += new System.EventHandler(this.FormTablasRK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRKInestale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRKPurga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRKInestale;
        private System.Windows.Forms.DataGridView dgvRKPurga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempoK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColK2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempoK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColK3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTiempoK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColK4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColL1L0;
        private System.Windows.Forms.Label lblT50;
        private System.Windows.Forms.Label lblT70;
        private System.Windows.Forms.Label lblT100;
    }
}