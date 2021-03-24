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
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Multiplicativo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmEleccionPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 164);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChiCuadrado);
            this.Controls.Add(this.btnNumerosAleatorios);
            this.Name = "frmEleccionPunto";
            this.Text = "EleccionPunto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumerosAleatorios;
        private System.Windows.Forms.Button btnChiCuadrado;
        private System.Windows.Forms.Button button3;
    }
}