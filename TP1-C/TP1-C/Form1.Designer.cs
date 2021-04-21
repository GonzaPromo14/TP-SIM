namespace TP1_C
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.grdNumeros = new System.Windows.Forms.DataGridView();
            this.colPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSiguienteX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroGenerado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLineal = new System.Windows.Forms.Button();
            this.btnMultiplicativo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMetodoElegido = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPagina = new System.Windows.Forms.TextBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.lblErrorPagina = new System.Windows.Forms.Label();
            this.lblSemillaInicial = new System.Windows.Forms.Label();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grillaFrecuencias = new System.Windows.Forms.DataGridView();
            this.btnRandom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblGradosLibertad = new System.Windows.Forms.Label();
            this.cmbPruebaBondad = new System.Windows.Forms.ComboBox();
            this.cmbConfianza = new System.Windows.Forms.ComboBox();
            this.colIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimiteInf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimiteSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrecEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcumulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadObservadaAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadEsperadaAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxProbabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRechazo = new System.Windows.Forms.Label();
            this.lblValorTabulado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFrecuencias)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "g";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xo";
            // 
            // txtXo
            // 
            this.txtXo.Enabled = false;
            this.txtXo.Location = new System.Drawing.Point(66, 96);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 20);
            this.txtXo.TabIndex = 5;
            this.txtXo.TextChanged += new System.EventHandler(this.txtXo_TextChanged);
            // 
            // txtG
            // 
            this.txtG.Enabled = false;
            this.txtG.Location = new System.Drawing.Point(66, 119);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 20);
            this.txtG.TabIndex = 6;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // txtK
            // 
            this.txtK.Enabled = false;
            this.txtK.Location = new System.Drawing.Point(66, 141);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 7;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(66, 163);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 8;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Location = new System.Drawing.Point(43, 255);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(152, 23);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar números";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // grdNumeros
            // 
            this.grdNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPos,
            this.colFormula,
            this.colSiguienteX,
            this.colNumeroGenerado});
            this.grdNumeros.Location = new System.Drawing.Point(259, 77);
            this.grdNumeros.Name = "grdNumeros";
            this.grdNumeros.Size = new System.Drawing.Size(444, 288);
            this.grdNumeros.TabIndex = 10;
            // 
            // colPos
            // 
            this.colPos.HeaderText = "Posición";
            this.colPos.Name = "colPos";
            // 
            // colFormula
            // 
            this.colFormula.HeaderText = "a*Xi + c";
            this.colFormula.Name = "colFormula";
            // 
            // colSiguienteX
            // 
            this.colSiguienteX.HeaderText = "x(i+1)";
            this.colSiguienteX.Name = "colSiguienteX";
            // 
            // colNumeroGenerado
            // 
            this.colNumeroGenerado.HeaderText = "x(i+1)/m-1";
            this.colNumeroGenerado.Name = "colNumeroGenerado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Elegir método";
            // 
            // btnLineal
            // 
            this.btnLineal.Location = new System.Drawing.Point(89, 4);
            this.btnLineal.Name = "btnLineal";
            this.btnLineal.Size = new System.Drawing.Size(75, 23);
            this.btnLineal.TabIndex = 12;
            this.btnLineal.Text = "Lineal";
            this.btnLineal.UseVisualStyleBackColor = true;
            this.btnLineal.Click += new System.EventHandler(this.btnLineal_Click);
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.Location = new System.Drawing.Point(170, 4);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(83, 23);
            this.btnMultiplicativo.TabIndex = 13;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            this.btnMultiplicativo.Click += new System.EventHandler(this.btnMultiplicativo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Enabled = false;
            this.btnProximo.Location = new System.Drawing.Point(43, 284);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(152, 23);
            this.btnProximo.TabIndex = 14;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(66, 189);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 15;
            // 
            // txtM
            // 
            this.txtM.Enabled = false;
            this.txtM.Location = new System.Drawing.Point(66, 215);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Método elegido:";
            // 
            // lblMetodoElegido
            // 
            this.lblMetodoElegido.AutoSize = true;
            this.lblMetodoElegido.Location = new System.Drawing.Point(449, 10);
            this.lblMetodoElegido.Name = "lblMetodoElegido";
            this.lblMetodoElegido.Size = new System.Drawing.Size(10, 13);
            this.lblMetodoElegido.TabIndex = 20;
            this.lblMetodoElegido.Text = "-";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(339, 36);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 21;
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(440, 376);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(73, 13);
            this.lblPagina.TabIndex = 22;
            this.lblPagina.Text = "Página 0 de 0";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(259, 371);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(29, 23);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(674, 371);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(29, 23);
            this.btnSiguiente.TabIndex = 24;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ir a página";
            // 
            // txtPagina
            // 
            this.txtPagina.Enabled = false;
            this.txtPagina.Location = new System.Drawing.Point(426, 405);
            this.txtPagina.Name = "txtPagina";
            this.txtPagina.Size = new System.Drawing.Size(71, 20);
            this.txtPagina.TabIndex = 26;
            // 
            // btnIr
            // 
            this.btnIr.Enabled = false;
            this.btnIr.Location = new System.Drawing.Point(503, 403);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(46, 23);
            this.btnIr.TabIndex = 27;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // lblErrorPagina
            // 
            this.lblErrorPagina.AutoSize = true;
            this.lblErrorPagina.Location = new System.Drawing.Point(500, 445);
            this.lblErrorPagina.Name = "lblErrorPagina";
            this.lblErrorPagina.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPagina.TabIndex = 28;
            // 
            // lblSemillaInicial
            // 
            this.lblSemillaInicial.AutoSize = true;
            this.lblSemillaInicial.Location = new System.Drawing.Point(532, 9);
            this.lblSemillaInicial.Name = "lblSemillaInicial";
            this.lblSemillaInicial.Size = new System.Drawing.Size(0, 13);
            this.lblSemillaInicial.TabIndex = 29;
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cmbIntervalos.Location = new System.Drawing.Point(54, 246);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(73, 21);
            this.cmbIntervalos.TabIndex = 30;
            this.cmbIntervalos.Text = "Intervalos";
            this.cmbIntervalos.SelectedIndexChanged += new System.EventHandler(this.cmbIntervalos_SelectedIndexChanged);
            // 
            // btnGraficar
            // 
            this.btnGraficar.Enabled = false;
            this.btnGraficar.Location = new System.Drawing.Point(160, 273);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(75, 23);
            this.btnGraficar.TabIndex = 31;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(716, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(570, 429);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // grillaFrecuencias
            // 
            this.grillaFrecuencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaFrecuencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIntervalo,
            this.colLimiteInf,
            this.colLimiteSup,
            this.colFrecObs,
            this.colFrecEsp,
            this.c,
            this.cAcumulado,
            this.probabilidadObservada,
            this.probabilidadEsperada,
            this.probabilidadObservadaAcumulada,
            this.probabilidadEsperadaAcumulada,
            this.diferencia,
            this.maxProbabilidad});
            this.grillaFrecuencias.Location = new System.Drawing.Point(18, 461);
            this.grillaFrecuencias.Name = "grillaFrecuencias";
            this.grillaFrecuencias.RowHeadersVisible = false;
            this.grillaFrecuencias.Size = new System.Drawing.Size(1268, 150);
            this.grillaFrecuencias.TabIndex = 33;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(259, 4);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 34;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbConfianza);
            this.groupBox1.Controls.Add(this.cmbPruebaBondad);
            this.groupBox1.Controls.Add(this.btnGraficar);
            this.groupBox1.Controls.Add(this.cmbIntervalos);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 328);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar variables";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(89, 36);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(77, 20);
            this.txtCantidad.TabIndex = 37;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblGradosLibertad
            // 
            this.lblGradosLibertad.AutoSize = true;
            this.lblGradosLibertad.Location = new System.Drawing.Point(15, 418);
            this.lblGradosLibertad.Name = "lblGradosLibertad";
            this.lblGradosLibertad.Size = new System.Drawing.Size(93, 13);
            this.lblGradosLibertad.TabIndex = 38;
            this.lblGradosLibertad.Text = "Grados de libertad";
            // 
            // cmbPruebaBondad
            // 
            this.cmbPruebaBondad.Enabled = false;
            this.cmbPruebaBondad.FormattingEnabled = true;
            this.cmbPruebaBondad.Items.AddRange(new object[] {
            "Chi cuadrado",
            "Kolmogorov"});
            this.cmbPruebaBondad.Location = new System.Drawing.Point(6, 273);
            this.cmbPruebaBondad.Name = "cmbPruebaBondad";
            this.cmbPruebaBondad.Size = new System.Drawing.Size(121, 21);
            this.cmbPruebaBondad.TabIndex = 39;
            this.cmbPruebaBondad.Text = "Prueba de bondad";
            this.cmbPruebaBondad.SelectedIndexChanged += new System.EventHandler(this.cmbPruebaBondad_SelectedIndexChanged);
            // 
            // cmbConfianza
            // 
            this.cmbConfianza.Enabled = false;
            this.cmbConfianza.FormattingEnabled = true;
            this.cmbConfianza.Items.AddRange(new object[] {
            "Chi cuadrado",
            "Kolmogorov"});
            this.cmbConfianza.Location = new System.Drawing.Point(54, 300);
            this.cmbConfianza.Name = "cmbConfianza";
            this.cmbConfianza.Size = new System.Drawing.Size(73, 21);
            this.cmbConfianza.TabIndex = 40;
            this.cmbConfianza.Text = "Confianza";
            this.cmbConfianza.SelectedIndexChanged += new System.EventHandler(this.cmbConfianza_SelectedIndexChanged);
            // 
            // colIntervalo
            // 
            this.colIntervalo.HeaderText = "Intervalo";
            this.colIntervalo.Name = "colIntervalo";
            // 
            // colLimiteInf
            // 
            this.colLimiteInf.HeaderText = "Li";
            this.colLimiteInf.Name = "colLimiteInf";
            // 
            // colLimiteSup
            // 
            this.colLimiteSup.HeaderText = "Ls";
            this.colLimiteSup.Name = "colLimiteSup";
            // 
            // colFrecObs
            // 
            this.colFrecObs.HeaderText = "Frecuencia observada";
            this.colFrecObs.Name = "colFrecObs";
            // 
            // colFrecEsp
            // 
            this.colFrecEsp.HeaderText = "Frecuencia esperada";
            this.colFrecEsp.Name = "colFrecEsp";
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.Name = "c";
            // 
            // cAcumulado
            // 
            this.cAcumulado.HeaderText = "C(AC)";
            this.cAcumulado.Name = "cAcumulado";
            // 
            // probabilidadObservada
            // 
            this.probabilidadObservada.HeaderText = "Po";
            this.probabilidadObservada.Name = "probabilidadObservada";
            // 
            // probabilidadEsperada
            // 
            this.probabilidadEsperada.HeaderText = "Pe";
            this.probabilidadEsperada.Name = "probabilidadEsperada";
            // 
            // probabilidadObservadaAcumulada
            // 
            this.probabilidadObservadaAcumulada.HeaderText = "Po(AC)";
            this.probabilidadObservadaAcumulada.Name = "probabilidadObservadaAcumulada";
            // 
            // probabilidadEsperadaAcumulada
            // 
            this.probabilidadEsperadaAcumulada.HeaderText = "Pe(AC)";
            this.probabilidadEsperadaAcumulada.Name = "probabilidadEsperadaAcumulada";
            // 
            // diferencia
            // 
            this.diferencia.HeaderText = "Diferencia";
            this.diferencia.Name = "diferencia";
            // 
            // maxProbabilidad
            // 
            this.maxProbabilidad.HeaderText = "MAX";
            this.maxProbabilidad.Name = "maxProbabilidad";
            // 
            // lblRechazo
            // 
            this.lblRechazo.AutoSize = true;
            this.lblRechazo.Location = new System.Drawing.Point(15, 631);
            this.lblRechazo.Name = "lblRechazo";
            this.lblRechazo.Size = new System.Drawing.Size(0, 13);
            this.lblRechazo.TabIndex = 39;
            // 
            // lblValorTabulado
            // 
            this.lblValorTabulado.AutoSize = true;
            this.lblValorTabulado.Location = new System.Drawing.Point(15, 439);
            this.lblValorTabulado.Name = "lblValorTabulado";
            this.lblValorTabulado.Size = new System.Drawing.Size(75, 13);
            this.lblValorTabulado.TabIndex = 40;
            this.lblValorTabulado.Text = "Valor tabulado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 749);
            this.Controls.Add(this.lblValorTabulado);
            this.Controls.Add(this.lblRechazo);
            this.Controls.Add(this.lblGradosLibertad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.grillaFrecuencias);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblSemillaInicial);
            this.Controls.Add(this.lblErrorPagina);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.txtPagina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMetodoElegido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnMultiplicativo);
            this.Controls.Add(this.btnLineal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdNumeros);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtXo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipal";
            this.Text = "Trabajo práctico 1 Simulación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNumeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaFrecuencias)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView grdNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiguienteX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroGenerado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLineal;
        private System.Windows.Forms.Button btnMultiplicativo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMetodoElegido;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPagina;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Label lblErrorPagina;
        private System.Windows.Forms.Label lblSemillaInicial;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView grillaFrecuencias;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbPruebaBondad;
        private System.Windows.Forms.Label lblGradosLibertad;
        private System.Windows.Forms.ComboBox cmbConfianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIntervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimiteInf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimiteSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrecEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcumulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadObservadaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadEsperadaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxProbabilidad;
        private System.Windows.Forms.Label lblRechazo;
        private System.Windows.Forms.Label lblValorTabulado;
    }
}

