namespace TP3
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
            this.cmbDistribuciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDistribucionUniforme = new System.Windows.Forms.Label();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblCondicionUniforme = new System.Windows.Forms.Label();
            this.grdNumeros = new System.Windows.Forms.DataGridView();
            this.numMuestra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtTamanioMuestra = new System.Windows.Forms.TextBox();
            this.lblTamanioMuestra = new System.Windows.Forms.Label();
            this.lblDistribucionExponencial = new System.Windows.Forms.Label();
            this.lblLamda = new System.Windows.Forms.Label();
            this.txtLamda = new System.Windows.Forms.TextBox();
            this.lblDistribucionPoisson = new System.Windows.Forms.Label();
            this.lblLamdaPoisson = new System.Windows.Forms.Label();
            this.txtLamdaPoisson = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDistribucionNormal = new System.Windows.Forms.Label();
            this.txtDesvEstandar = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblDesvEstandar = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodoConvolucion = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDistribuciones
            // 
            this.cmbDistribuciones.FormattingEnabled = true;
            this.cmbDistribuciones.Items.AddRange(new object[] {
            "Uniforme",
            "Exponencial",
            "Poisson",
            "Normal"});
            this.cmbDistribuciones.Location = new System.Drawing.Point(107, 12);
            this.cmbDistribuciones.Name = "cmbDistribuciones";
            this.cmbDistribuciones.Size = new System.Drawing.Size(121, 21);
            this.cmbDistribuciones.TabIndex = 0;
            this.cmbDistribuciones.SelectedIndexChanged += new System.EventHandler(this.cmbDistribuciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elegir distribución";
            // 
            // lblDistribucionUniforme
            // 
            this.lblDistribucionUniforme.AutoSize = true;
            this.lblDistribucionUniforme.Enabled = false;
            this.lblDistribucionUniforme.Location = new System.Drawing.Point(12, 64);
            this.lblDistribucionUniforme.Name = "lblDistribucionUniforme";
            this.lblDistribucionUniforme.Size = new System.Drawing.Size(105, 13);
            this.lblDistribucionUniforme.TabIndex = 2;
            this.lblDistribucionUniforme.Text = "Distribución uniforme";
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Enabled = false;
            this.lblValorA.Location = new System.Drawing.Point(12, 88);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(81, 13);
            this.lblValorA.TabIndex = 3;
            this.lblValorA.Text = "Ingresar valor A";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Enabled = false;
            this.lblValorB.Location = new System.Drawing.Point(12, 114);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(81, 13);
            this.lblValorB.TabIndex = 4;
            this.lblValorB.Text = "Ingresar valor B";
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(99, 85);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(99, 111);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 6;
            // 
            // lblCondicionUniforme
            // 
            this.lblCondicionUniforme.AutoSize = true;
            this.lblCondicionUniforme.Enabled = false;
            this.lblCondicionUniforme.Location = new System.Drawing.Point(12, 137);
            this.lblCondicionUniforme.Name = "lblCondicionUniforme";
            this.lblCondicionUniforme.Size = new System.Drawing.Size(163, 13);
            this.lblCondicionUniforme.TabIndex = 7;
            this.lblCondicionUniforme.Text = "*El valor A debe ser menor que B";
            // 
            // grdNumeros
            // 
            this.grdNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numMuestra,
            this.random,
            this.valor});
            this.grdNumeros.Location = new System.Drawing.Point(12, 213);
            this.grdNumeros.Name = "grdNumeros";
            this.grdNumeros.Size = new System.Drawing.Size(347, 256);
            this.grdNumeros.TabIndex = 8;
            this.grdNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNumeros_CellContentClick);
            // 
            // numMuestra
            // 
            this.numMuestra.HeaderText = "Muestra";
            this.numMuestra.Name = "numMuestra";
            // 
            // random
            // 
            this.random.HeaderText = "RND";
            this.random.Name = "random";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor con distribución";
            this.valor.Name = "valor";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(26, 169);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape6,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(981, 542);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 575;
            this.lineShape5.X2 = 575;
            this.lineShape5.Y1 = 51;
            this.lineShape5.Y2 = 158;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 386;
            this.lineShape4.X2 = 386;
            this.lineShape4.Y1 = 52;
            this.lineShape4.Y2 = 159;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 191;
            this.lineShape3.X2 = 191;
            this.lineShape3.Y1 = 51;
            this.lineShape3.Y2 = 158;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 2;
            this.lineShape2.X2 = 981;
            this.lineShape2.Y1 = 160;
            this.lineShape2.Y2 = 160;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -6;
            this.lineShape1.X2 = 982;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 50;
            // 
            // txtTamanioMuestra
            // 
            this.txtTamanioMuestra.Location = new System.Drawing.Point(379, 12);
            this.txtTamanioMuestra.Name = "txtTamanioMuestra";
            this.txtTamanioMuestra.Size = new System.Drawing.Size(90, 20);
            this.txtTamanioMuestra.TabIndex = 11;
            this.txtTamanioMuestra.Text = "10";
            this.txtTamanioMuestra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTamanioMuestra
            // 
            this.lblTamanioMuestra.AutoSize = true;
            this.lblTamanioMuestra.Location = new System.Drawing.Point(272, 16);
            this.lblTamanioMuestra.Name = "lblTamanioMuestra";
            this.lblTamanioMuestra.Size = new System.Drawing.Size(101, 13);
            this.lblTamanioMuestra.TabIndex = 12;
            this.lblTamanioMuestra.Text = "Tamaño de muestra";
            // 
            // lblDistribucionExponencial
            // 
            this.lblDistribucionExponencial.AutoSize = true;
            this.lblDistribucionExponencial.Enabled = false;
            this.lblDistribucionExponencial.Location = new System.Drawing.Point(200, 64);
            this.lblDistribucionExponencial.Name = "lblDistribucionExponencial";
            this.lblDistribucionExponencial.Size = new System.Drawing.Size(122, 13);
            this.lblDistribucionExponencial.TabIndex = 13;
            this.lblDistribucionExponencial.Text = "Distribución exponencial";
            // 
            // lblLamda
            // 
            this.lblLamda.AutoSize = true;
            this.lblLamda.Enabled = false;
            this.lblLamda.Location = new System.Drawing.Point(200, 88);
            this.lblLamda.Name = "lblLamda";
            this.lblLamda.Size = new System.Drawing.Size(76, 13);
            this.lblLamda.TabIndex = 14;
            this.lblLamda.Text = "Ingresar lamda";
            // 
            // txtLamda
            // 
            this.txtLamda.Enabled = false;
            this.txtLamda.Location = new System.Drawing.Point(287, 85);
            this.txtLamda.Name = "txtLamda";
            this.txtLamda.Size = new System.Drawing.Size(76, 20);
            this.txtLamda.TabIndex = 15;
            // 
            // lblDistribucionPoisson
            // 
            this.lblDistribucionPoisson.AutoSize = true;
            this.lblDistribucionPoisson.Enabled = false;
            this.lblDistribucionPoisson.Location = new System.Drawing.Point(400, 64);
            this.lblDistribucionPoisson.Name = "lblDistribucionPoisson";
            this.lblDistribucionPoisson.Size = new System.Drawing.Size(101, 13);
            this.lblDistribucionPoisson.TabIndex = 16;
            this.lblDistribucionPoisson.Text = "Distribución poisson";
            // 
            // lblLamdaPoisson
            // 
            this.lblLamdaPoisson.AutoSize = true;
            this.lblLamdaPoisson.Enabled = false;
            this.lblLamdaPoisson.Location = new System.Drawing.Point(400, 88);
            this.lblLamdaPoisson.Name = "lblLamdaPoisson";
            this.lblLamdaPoisson.Size = new System.Drawing.Size(76, 13);
            this.lblLamdaPoisson.TabIndex = 17;
            this.lblLamdaPoisson.Text = "Ingresar lamda";
            // 
            // txtLamdaPoisson
            // 
            this.txtLamdaPoisson.Enabled = false;
            this.txtLamdaPoisson.Location = new System.Drawing.Point(482, 88);
            this.txtLamdaPoisson.Name = "txtLamdaPoisson";
            this.txtLamdaPoisson.Size = new System.Drawing.Size(76, 20);
            this.txtLamdaPoisson.TabIndex = 18;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(284, 475);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(12, 475);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 20;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(119, 480);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(73, 13);
            this.lblPagina.TabIndex = 27;
            this.lblPagina.Text = "Página 0 de 0";
            // 
            // btnIr
            // 
            this.btnIr.Enabled = false;
            this.btnIr.Location = new System.Drawing.Point(152, 515);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(46, 23);
            this.btnIr.TabIndex = 30;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // txtPagina
            // 
            this.txtPagina.Enabled = false;
            this.txtPagina.Location = new System.Drawing.Point(75, 517);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(71, 20);
            this.txtPagina.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ir a página";
            // 
            // lblDistribucionNormal
            // 
            this.lblDistribucionNormal.AutoSize = true;
            this.lblDistribucionNormal.Enabled = false;
            this.lblDistribucionNormal.Location = new System.Drawing.Point(583, 64);
            this.lblDistribucionNormal.Name = "lblDistribucionNormal";
            this.lblDistribucionNormal.Size = new System.Drawing.Size(96, 13);
            this.lblDistribucionNormal.TabIndex = 31;
            this.lblDistribucionNormal.Text = "Distribución normal";
            // 
            // txtDesvEstandar
            // 
            this.txtDesvEstandar.Enabled = false;
            this.txtDesvEstandar.Location = new System.Drawing.Point(710, 108);
            this.txtDesvEstandar.Name = "txtDesvEstandar";
            this.txtDesvEstandar.Size = new System.Drawing.Size(76, 20);
            this.txtDesvEstandar.TabIndex = 35;
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(710, 82);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(76, 20);
            this.txtMedia.TabIndex = 34;
            // 
            // lblDesvEstandar
            // 
            this.lblDesvEstandar.AutoSize = true;
            this.lblDesvEstandar.Enabled = false;
            this.lblDesvEstandar.Location = new System.Drawing.Point(583, 111);
            this.lblDesvEstandar.Name = "lblDesvEstandar";
            this.lblDesvEstandar.Size = new System.Drawing.Size(118, 13);
            this.lblDesvEstandar.TabIndex = 33;
            this.lblDesvEstandar.Text = "Ingresar Desv Estándar";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Enabled = false;
            this.lblMedia.Location = new System.Drawing.Point(583, 85);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(77, 13);
            this.lblMedia.TabIndex = 32;
            this.lblMedia.Text = "Ingresar Media";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Enabled = false;
            this.lblMetodo.Location = new System.Drawing.Point(583, 137);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(43, 13);
            this.lblMetodo.TabIndex = 36;
            this.lblMetodo.Text = "Método";
            // 
            // cmbMetodo
            // 
            this.cmbMetodo.Enabled = false;
            this.cmbMetodo.FormattingEnabled = true;
            this.cmbMetodo.Items.AddRange(new object[] {
            "Box - Muller",
            "Convolución"});
            this.cmbMetodo.Location = new System.Drawing.Point(665, 134);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(121, 21);
            this.cmbMetodo.TabIndex = 37;
            this.cmbMetodo.Text = "Box - Muller";
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // lblMetodoConvolucion
            // 
            this.lblMetodoConvolucion.AutoSize = true;
            this.lblMetodoConvolucion.Enabled = false;
            this.lblMetodoConvolucion.Location = new System.Drawing.Point(814, 64);
            this.lblMetodoConvolucion.Name = "lblMetodoConvolucion";
            this.lblMetodoConvolucion.Size = new System.Drawing.Size(120, 13);
            this.lblMetodoConvolucion.TabIndex = 38;
            this.lblMetodoConvolucion.Text = "Método de Convolución";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Enabled = false;
            this.lblK.Location = new System.Drawing.Point(814, 88);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(55, 13);
            this.lblK.TabIndex = 39;
            this.lblK.Text = "Ingresar K";
            // 
            // txtK
            // 
            this.txtK.Enabled = false;
            this.txtK.Location = new System.Drawing.Point(875, 85);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(76, 20);
            this.txtK.TabIndex = 40;
            this.txtK.Text = "12";
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 386;
            this.lineShape6.X2 = 386;
            this.lineShape6.Y1 = 159;
            this.lineShape6.Y2 = 546;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Chi cuadrado";
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.Enabled = false;
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmbIntervalos.Location = new System.Drawing.Point(238, 166);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(121, 21);
            this.cmbIntervalos.TabIndex = 42;
            this.cmbIntervalos.Text = "Intervalos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDesde});
            this.dataGridView1.Location = new System.Drawing.Point(421, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 43;
            // 
            // colDesde
            // 
            this.colDesde.HeaderText = "Desde";
            this.colDesde.Name = "colDesde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblMetodoConvolucion);
            this.Controls.Add(this.cmbMetodo);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.txtDesvEstandar);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblDesvEstandar);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblDistribucionNormal);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtLamdaPoisson);
            this.Controls.Add(this.lblLamdaPoisson);
            this.Controls.Add(this.lblDistribucionPoisson);
            this.Controls.Add(this.txtLamda);
            this.Controls.Add(this.lblLamda);
            this.Controls.Add(this.lblDistribucionExponencial);
            this.Controls.Add(this.lblTamanioMuestra);
            this.Controls.Add(this.txtTamanioMuestra);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.grdNumeros);
            this.Controls.Add(this.lblCondicionUniforme);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Controls.Add(this.lblDistribucionUniforme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDistribuciones);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDistribuciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDistribucionUniforme;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblCondicionUniforme;
        private System.Windows.Forms.DataGridView grdNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtTamanioMuestra;
        private System.Windows.Forms.Label lblTamanioMuestra;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Label lblDistribucionExponencial;
        private System.Windows.Forms.Label lblLamda;
        private System.Windows.Forms.TextBox txtLamda;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.Label lblDistribucionPoisson;
        private System.Windows.Forms.Label lblLamdaPoisson;
        private System.Windows.Forms.TextBox txtLamdaPoisson;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn random;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.Label lblDistribucionNormal;
        private System.Windows.Forms.TextBox txtDesvEstandar;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblDesvEstandar;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label lblMetodoConvolucion;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtK;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesde;
    }
}

