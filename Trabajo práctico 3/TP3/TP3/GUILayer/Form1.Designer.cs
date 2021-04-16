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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbDistribuciones = new System.Windows.Forms.ComboBox();
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
            this.txtTamanioMuestra = new System.Windows.Forms.TextBox();
            this.lblTamanioMuestra = new System.Windows.Forms.Label();
            this.lblLamda = new System.Windows.Forms.Label();
            this.txtLamda = new System.Windows.Forms.TextBox();
            this.lblLamdaPoisson = new System.Windows.Forms.Label();
            this.txtLamdaPoisson = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnIr = new System.Windows.Forms.Button();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesvEstandar = new System.Windows.Forms.TextBox();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblDesvEstandar = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.cmbMetodo = new System.Windows.Forms.ComboBox();
            this.lblMetodoConvolucion = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupUniforme = new System.Windows.Forms.GroupBox();
            this.groupExponencial = new System.Windows.Forms.GroupBox();
            this.groupPoisson = new System.Windows.Forms.GroupBox();
            this.groupNormal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridFrecuencias = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esperados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcumEsperado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupUniforme.SuspendLayout();
            this.groupExponencial.SuspendLayout();
            this.groupPoisson.SuspendLayout();
            this.groupNormal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).BeginInit();
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
            this.cmbDistribuciones.Location = new System.Drawing.Point(87, 14);
            this.cmbDistribuciones.Name = "cmbDistribuciones";
            this.cmbDistribuciones.Size = new System.Drawing.Size(100, 21);
            this.cmbDistribuciones.TabIndex = 0;
            this.cmbDistribuciones.Text = "Distribución";
            this.cmbDistribuciones.SelectedIndexChanged += new System.EventHandler(this.cmbDistribuciones_SelectedIndexChanged);
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Enabled = false;
            this.lblValorA.Location = new System.Drawing.Point(6, 28);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(81, 13);
            this.lblValorA.TabIndex = 3;
            this.lblValorA.Text = "Ingresar valor A";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Enabled = false;
            this.lblValorB.Location = new System.Drawing.Point(6, 54);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(81, 13);
            this.lblValorB.TabIndex = 4;
            this.lblValorB.Text = "Ingresar valor B";
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(106, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(76, 20);
            this.txtA.TabIndex = 5;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(106, 51);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(76, 20);
            this.txtB.TabIndex = 6;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // lblCondicionUniforme
            // 
            this.lblCondicionUniforme.AutoSize = true;
            this.lblCondicionUniforme.Enabled = false;
            this.lblCondicionUniforme.Location = new System.Drawing.Point(6, 84);
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
            this.grdNumeros.Location = new System.Drawing.Point(6, 73);
            this.grdNumeros.Name = "grdNumeros";
            this.grdNumeros.RowHeadersVisible = false;
            this.grdNumeros.Size = new System.Drawing.Size(347, 256);
            this.grdNumeros.TabIndex = 8;
            this.grdNumeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNumeros_CellContentClick);
            // 
            // numMuestra
            // 
            this.numMuestra.HeaderText = "N°";
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
            this.btnGenerar.Location = new System.Drawing.Point(6, 34);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtTamanioMuestra
            // 
            this.txtTamanioMuestra.Enabled = false;
            this.txtTamanioMuestra.Location = new System.Drawing.Point(309, 14);
            this.txtTamanioMuestra.Name = "txtTamanioMuestra";
            this.txtTamanioMuestra.Size = new System.Drawing.Size(90, 20);
            this.txtTamanioMuestra.TabIndex = 11;
            this.txtTamanioMuestra.Text = "1000";
            this.txtTamanioMuestra.TextChanged += new System.EventHandler(this.txtTamanioMuestra_TextChanged);
            // 
            // lblTamanioMuestra
            // 
            this.lblTamanioMuestra.AutoSize = true;
            this.lblTamanioMuestra.Location = new System.Drawing.Point(202, 17);
            this.lblTamanioMuestra.Name = "lblTamanioMuestra";
            this.lblTamanioMuestra.Size = new System.Drawing.Size(101, 13);
            this.lblTamanioMuestra.TabIndex = 12;
            this.lblTamanioMuestra.Text = "Tamaño de muestra";
            // 
            // lblLamda
            // 
            this.lblLamda.AutoSize = true;
            this.lblLamda.Enabled = false;
            this.lblLamda.Location = new System.Drawing.Point(6, 26);
            this.lblLamda.Name = "lblLamda";
            this.lblLamda.Size = new System.Drawing.Size(76, 13);
            this.lblLamda.TabIndex = 14;
            this.lblLamda.Text = "Ingresar lamda";
            // 
            // txtLamda
            // 
            this.txtLamda.Enabled = false;
            this.txtLamda.Location = new System.Drawing.Point(88, 25);
            this.txtLamda.Name = "txtLamda";
            this.txtLamda.Size = new System.Drawing.Size(76, 20);
            this.txtLamda.TabIndex = 15;
            this.txtLamda.TextChanged += new System.EventHandler(this.txtLamda_TextChanged);
            // 
            // lblLamdaPoisson
            // 
            this.lblLamdaPoisson.AutoSize = true;
            this.lblLamdaPoisson.Enabled = false;
            this.lblLamdaPoisson.Location = new System.Drawing.Point(6, 28);
            this.lblLamdaPoisson.Name = "lblLamdaPoisson";
            this.lblLamdaPoisson.Size = new System.Drawing.Size(76, 13);
            this.lblLamdaPoisson.TabIndex = 17;
            this.lblLamdaPoisson.Text = "Ingresar lamda";
            // 
            // txtLamdaPoisson
            // 
            this.txtLamdaPoisson.Enabled = false;
            this.txtLamdaPoisson.Location = new System.Drawing.Point(89, 25);
            this.txtLamdaPoisson.Name = "txtLamdaPoisson";
            this.txtLamdaPoisson.Size = new System.Drawing.Size(76, 20);
            this.txtLamdaPoisson.TabIndex = 18;
            this.txtLamdaPoisson.TextChanged += new System.EventHandler(this.txtLamdaPoisson_TextChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(278, 335);
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
            this.btnAnterior.Location = new System.Drawing.Point(6, 335);
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
            this.lblPagina.Location = new System.Drawing.Point(113, 340);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(73, 13);
            this.lblPagina.TabIndex = 27;
            this.lblPagina.Text = "Página 0 de 0";
            // 
            // btnIr
            // 
            this.btnIr.Enabled = false;
            this.btnIr.Location = new System.Drawing.Point(146, 375);
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
            this.txtPagina.Location = new System.Drawing.Point(69, 377);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(71, 20);
            this.txtPagina.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ir a página";
            // 
            // txtDesvEstandar
            // 
            this.txtDesvEstandar.Enabled = false;
            this.txtDesvEstandar.Location = new System.Drawing.Point(130, 51);
            this.txtDesvEstandar.Name = "txtDesvEstandar";
            this.txtDesvEstandar.Size = new System.Drawing.Size(76, 20);
            this.txtDesvEstandar.TabIndex = 35;
            this.txtDesvEstandar.TextChanged += new System.EventHandler(this.txtDesvEstandar_TextChanged);
            // 
            // txtMedia
            // 
            this.txtMedia.Enabled = false;
            this.txtMedia.Location = new System.Drawing.Point(130, 25);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(76, 20);
            this.txtMedia.TabIndex = 34;
            this.txtMedia.TextChanged += new System.EventHandler(this.txtMedia_TextChanged);
            // 
            // lblDesvEstandar
            // 
            this.lblDesvEstandar.AutoSize = true;
            this.lblDesvEstandar.Enabled = false;
            this.lblDesvEstandar.Location = new System.Drawing.Point(6, 51);
            this.lblDesvEstandar.Name = "lblDesvEstandar";
            this.lblDesvEstandar.Size = new System.Drawing.Size(118, 13);
            this.lblDesvEstandar.TabIndex = 33;
            this.lblDesvEstandar.Text = "Ingresar Desv Estándar";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Enabled = false;
            this.lblMedia.Location = new System.Drawing.Point(6, 25);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(77, 13);
            this.lblMedia.TabIndex = 32;
            this.lblMedia.Text = "Ingresar Media";
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Enabled = false;
            this.lblMetodo.Location = new System.Drawing.Point(6, 75);
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
            this.cmbMetodo.Location = new System.Drawing.Point(130, 75);
            this.cmbMetodo.Name = "cmbMetodo";
            this.cmbMetodo.Size = new System.Drawing.Size(76, 21);
            this.cmbMetodo.TabIndex = 37;
            this.cmbMetodo.Text = "Box - Muller";
            this.cmbMetodo.SelectedIndexChanged += new System.EventHandler(this.cmbMetodo_SelectedIndexChanged);
            // 
            // lblMetodoConvolucion
            // 
            this.lblMetodoConvolucion.AutoSize = true;
            this.lblMetodoConvolucion.Enabled = false;
            this.lblMetodoConvolucion.Location = new System.Drawing.Point(260, 25);
            this.lblMetodoConvolucion.Name = "lblMetodoConvolucion";
            this.lblMetodoConvolucion.Size = new System.Drawing.Size(120, 13);
            this.lblMetodoConvolucion.TabIndex = 38;
            this.lblMetodoConvolucion.Text = "Método de Convolución";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Enabled = false;
            this.lblK.Location = new System.Drawing.Point(260, 48);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(55, 13);
            this.lblK.TabIndex = 39;
            this.lblK.Text = "Ingresar K";
            // 
            // txtK
            // 
            this.txtK.Enabled = false;
            this.txtK.Location = new System.Drawing.Point(332, 48);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(48, 20);
            this.txtK.TabIndex = 40;
            this.txtK.Text = "12";
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
            this.cmbIntervalos.Location = new System.Drawing.Point(281, 36);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(72, 21);
            this.cmbIntervalos.TabIndex = 42;
            this.cmbIntervalos.Text = "Intervalos";
            this.cmbIntervalos.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalos_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(421, 169);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Observado";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Esperado";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(937, 407);
            this.chart1.TabIndex = 44;
            this.chart1.Text = "chart1";
            // 
            // groupUniforme
            // 
            this.groupUniforme.Controls.Add(this.lblValorA);
            this.groupUniforme.Controls.Add(this.lblValorB);
            this.groupUniforme.Controls.Add(this.txtA);
            this.groupUniforme.Controls.Add(this.txtB);
            this.groupUniforme.Controls.Add(this.lblCondicionUniforme);
            this.groupUniforme.Location = new System.Drawing.Point(21, 53);
            this.groupUniforme.Name = "groupUniforme";
            this.groupUniforme.Size = new System.Drawing.Size(188, 102);
            this.groupUniforme.TabIndex = 45;
            this.groupUniforme.TabStop = false;
            this.groupUniforme.Text = "Distribución uniforme";
            // 
            // groupExponencial
            // 
            this.groupExponencial.Controls.Add(this.lblLamda);
            this.groupExponencial.Controls.Add(this.txtLamda);
            this.groupExponencial.Location = new System.Drawing.Point(228, 53);
            this.groupExponencial.Name = "groupExponencial";
            this.groupExponencial.Size = new System.Drawing.Size(171, 102);
            this.groupExponencial.TabIndex = 46;
            this.groupExponencial.TabStop = false;
            this.groupExponencial.Text = "Distribución Exponencial";
            // 
            // groupPoisson
            // 
            this.groupPoisson.Controls.Add(this.lblLamdaPoisson);
            this.groupPoisson.Controls.Add(this.txtLamdaPoisson);
            this.groupPoisson.Location = new System.Drawing.Point(421, 53);
            this.groupPoisson.Name = "groupPoisson";
            this.groupPoisson.Size = new System.Drawing.Size(171, 102);
            this.groupPoisson.TabIndex = 47;
            this.groupPoisson.TabStop = false;
            this.groupPoisson.Text = "Distribución Poisson";
            // 
            // groupNormal
            // 
            this.groupNormal.Controls.Add(this.lblMedia);
            this.groupNormal.Controls.Add(this.txtMedia);
            this.groupNormal.Controls.Add(this.lblDesvEstandar);
            this.groupNormal.Controls.Add(this.lblMetodo);
            this.groupNormal.Controls.Add(this.lblMetodoConvolucion);
            this.groupNormal.Controls.Add(this.txtK);
            this.groupNormal.Controls.Add(this.txtDesvEstandar);
            this.groupNormal.Controls.Add(this.lblK);
            this.groupNormal.Controls.Add(this.cmbMetodo);
            this.groupNormal.Location = new System.Drawing.Point(614, 53);
            this.groupNormal.Name = "groupNormal";
            this.groupNormal.Size = new System.Drawing.Size(387, 102);
            this.groupNormal.TabIndex = 48;
            this.groupNormal.TabStop = false;
            this.groupNormal.Text = "Distribución Normal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Seleccionar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grdNumeros);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.cmbIntervalos);
            this.groupBox1.Controls.Add(this.lblPagina);
            this.groupBox1.Controls.Add(this.btnIr);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.txtPagina);
            this.groupBox1.Location = new System.Drawing.Point(21, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 407);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graficar";
            // 
            // dataGridFrecuencias
            // 
            this.dataGridFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Min,
            this.Max,
            this.Observados,
            this.ProbObs,
            this.AcumObs,
            this.Esperados,
            this.ProbEsp,
            this.AcumEsperado});
            this.dataGridFrecuencias.Location = new System.Drawing.Point(421, 587);
            this.dataGridFrecuencias.Name = "dataGridFrecuencias";
            this.dataGridFrecuencias.RowHeadersVisible = false;
            this.dataGridFrecuencias.Size = new System.Drawing.Size(937, 150);
            this.dataGridFrecuencias.TabIndex = 51;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // Min
            // 
            this.Min.HeaderText = "Li";
            this.Min.Name = "Min";
            // 
            // Max
            // 
            this.Max.HeaderText = "Ls";
            this.Max.Name = "Max";
            // 
            // Observados
            // 
            this.Observados.HeaderText = "Observados";
            this.Observados.Name = "Observados";
            // 
            // ProbObs
            // 
            this.ProbObs.HeaderText = "P(Oi)";
            this.ProbObs.Name = "ProbObs";
            // 
            // AcumObs
            // 
            this.AcumObs.HeaderText = "Acumulado (Oi)";
            this.AcumObs.Name = "AcumObs";
            // 
            // Esperados
            // 
            this.Esperados.HeaderText = "Esperados";
            this.Esperados.Name = "Esperados";
            // 
            // ProbEsp
            // 
            this.ProbEsp.HeaderText = "P(Ei)";
            this.ProbEsp.Name = "ProbEsp";
            // 
            // AcumEsperado
            // 
            this.AcumEsperado.HeaderText = "Acumulado (Ei)";
            this.AcumEsperado.Name = "AcumEsperado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seleccionar intervalo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dataGridFrecuencias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupExponencial);
            this.Controls.Add(this.lblTamanioMuestra);
            this.Controls.Add(this.txtTamanioMuestra);
            this.Controls.Add(this.cmbDistribuciones);
            this.Controls.Add(this.groupUniforme);
            this.Controls.Add(this.groupPoisson);
            this.Controls.Add(this.groupNormal);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Trabajo Práctico 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupUniforme.ResumeLayout(false);
            this.groupUniforme.PerformLayout();
            this.groupExponencial.ResumeLayout(false);
            this.groupExponencial.PerformLayout();
            this.groupPoisson.ResumeLayout(false);
            this.groupPoisson.PerformLayout();
            this.groupNormal.ResumeLayout(false);
            this.groupNormal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrecuencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDistribuciones;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblCondicionUniforme;
        private System.Windows.Forms.DataGridView grdNumeros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtTamanioMuestra;
        private System.Windows.Forms.Label lblTamanioMuestra;
        private System.Windows.Forms.Label lblLamda;
        private System.Windows.Forms.TextBox txtLamda;
        private System.Windows.Forms.Label lblLamdaPoisson;
        private System.Windows.Forms.TextBox txtLamdaPoisson;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDesvEstandar;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label lblDesvEstandar;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.ComboBox cmbMetodo;
        private System.Windows.Forms.Label lblMetodoConvolucion;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMuestra;
        private System.Windows.Forms.DataGridViewTextBoxColumn random;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.GroupBox groupUniforme;
        private System.Windows.Forms.GroupBox groupExponencial;
        private System.Windows.Forms.GroupBox groupPoisson;
        private System.Windows.Forms.GroupBox groupNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridFrecuencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esperados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcumEsperado;
        private System.Windows.Forms.Label label2;
    }
}

