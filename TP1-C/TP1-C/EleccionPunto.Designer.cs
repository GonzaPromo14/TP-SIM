namespace TP1_C
{
    partial class frmEleccionPunto
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
            this.btnNumerosAleatorios = new System.Windows.Forms.Button();
            this.btnChiCuadrado = new System.Windows.Forms.Button();
            this.btnKolmoSmirnov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EleccionPunto_FormClosing);
            // 
            // btnNumerosAleatorios
            // 
            this.btnNumerosAleatorios.Location = new System.Drawing.Point(12, 12);
            this.btnNumerosAleatorios.Name = "btnNumerosAleatorios";
            this.btnNumerosAleatorios.Size = new System.Drawing.Size(156, 39);
            this.btnNumerosAleatorios.TabIndex = 0;
            this.btnNumerosAleatorios.Text = "Generación de numeros aleatorios";
            this.btnNumerosAleatorios.UseVisualStyleBackColor = true;
            this.btnNumerosAleatorios.Click += new System.EventHandler(this.btnNumerosAleatorios_Click);
            // 
            // btnChiCuadrado
            // 
            this.btnChiCuadrado.Location = new System.Drawing.Point(12, 57);
            this.btnChiCuadrado.Name = "btnChiCuadrado";
            this.btnChiCuadrado.Size = new System.Drawing.Size(156, 39);
            this.btnChiCuadrado.TabIndex = 1;
            this.btnChiCuadrado.Text = "ChiCuadrado";
            this.btnChiCuadrado.UseVisualStyleBackColor = true;
            this.btnChiCuadrado.Click += new System.EventHandler(this.btnChiCuadrado_Click);
            // 
            // btnKolmoSmirnov
            // 
            this.btnKolmoSmirnov.Location = new System.Drawing.Point(12, 102);
            this.btnKolmoSmirnov.Name = "btnKolmoSmirnov";
            this.btnKolmoSmirnov.Size = new System.Drawing.Size(156, 39);
            this.btnKolmoSmirnov.TabIndex = 2;
            this.btnKolmoSmirnov.Text = "Kolmogorov Smirnov";
            this.btnKolmoSmirnov.UseVisualStyleBackColor = true;
            this.btnKolmoSmirnov.Click += new System.EventHandler(this.btnKolmoSmirnov_Click);
            // 
            // frmEleccionPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 164);
            this.Controls.Add(this.btnKolmoSmirnov);
            this.Controls.Add(this.btnChiCuadrado);
            this.Controls.Add(this.btnNumerosAleatorios);
            this.Name = "frmEleccionPunto";
            this.Text = "EleccionPunto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumerosAleatorios;
        private System.Windows.Forms.Button btnChiCuadrado;
        private System.Windows.Forms.Button btnKolmoSmirnov;
    }
}