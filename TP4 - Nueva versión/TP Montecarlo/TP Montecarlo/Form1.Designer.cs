namespace TP_Montecarlo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProduccionDiaria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostoTorta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadSimulaciones = new System.Windows.Forms.TextBox();
            this.grdProbabilidadesDemandaTorta = new System.Windows.Forms.DataGridView();
            this.demandaTortas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadAcumuladaDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdProbabilidadesMulta = new System.Windows.Forms.DataGridView();
            this.multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadAcumuladaMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdSimulaciones = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lblPagina = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioFaltantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioATirar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multaGenerada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciaPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadPermiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProbabilidadesDemandaTorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProbabilidadesMulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSimulaciones)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de simulaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProduccionDiaria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMulta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCostoTorta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadSimulaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de datos";
            // 
            // txtProduccionDiaria
            // 
            this.txtProduccionDiaria.Location = new System.Drawing.Point(144, 133);
            this.txtProduccionDiaria.Name = "txtProduccionDiaria";
            this.txtProduccionDiaria.Size = new System.Drawing.Size(100, 20);
            this.txtProduccionDiaria.TabIndex = 9;
            this.txtProduccionDiaria.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Producción diaria";
            // 
            // txtMulta
            // 
            this.txtMulta.Location = new System.Drawing.Point(144, 107);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(100, 20);
            this.txtMulta.TabIndex = 7;
            this.txtMulta.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Costo de multa";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(144, 81);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.Text = "30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio de venta";
            // 
            // txtCostoTorta
            // 
            this.txtCostoTorta.Location = new System.Drawing.Point(144, 55);
            this.txtCostoTorta.Name = "txtCostoTorta";
            this.txtCostoTorta.Size = new System.Drawing.Size(100, 20);
            this.txtCostoTorta.TabIndex = 3;
            this.txtCostoTorta.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo por torta";
            // 
            // txtCantidadSimulaciones
            // 
            this.txtCantidadSimulaciones.Location = new System.Drawing.Point(144, 29);
            this.txtCantidadSimulaciones.Name = "txtCantidadSimulaciones";
            this.txtCantidadSimulaciones.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadSimulaciones.TabIndex = 1;
            this.txtCantidadSimulaciones.Text = "10000";
            this.txtCantidadSimulaciones.TextChanged += new System.EventHandler(this.txtCantidadSimulaciones_TextChanged);
            // 
            // grdProbabilidadesDemandaTorta
            // 
            this.grdProbabilidadesDemandaTorta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProbabilidadesDemandaTorta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demandaTortas,
            this.probabilidad,
            this.probabilidadAcumuladaDemanda});
            this.grdProbabilidadesDemandaTorta.Location = new System.Drawing.Point(769, 12);
            this.grdProbabilidadesDemandaTorta.Name = "grdProbabilidadesDemandaTorta";
            this.grdProbabilidadesDemandaTorta.RowHeadersVisible = false;
            this.grdProbabilidadesDemandaTorta.Size = new System.Drawing.Size(345, 166);
            this.grdProbabilidadesDemandaTorta.TabIndex = 3;
            // 
            // demandaTortas
            // 
            this.demandaTortas.HeaderText = "Demanda de tortas";
            this.demandaTortas.Name = "demandaTortas";
            // 
            // probabilidad
            // 
            this.probabilidad.HeaderText = "P()";
            this.probabilidad.Name = "probabilidad";
            // 
            // probabilidadAcumuladaDemanda
            // 
            this.probabilidadAcumuladaDemanda.HeaderText = "P(AC)";
            this.probabilidadAcumuladaDemanda.Name = "probabilidadAcumuladaDemanda";
            // 
            // grdProbabilidadesMulta
            // 
            this.grdProbabilidadesMulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProbabilidadesMulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.multa,
            this.probabilidadMulta,
            this.probabilidadAcumuladaMulta});
            this.grdProbabilidadesMulta.Location = new System.Drawing.Point(363, 12);
            this.grdProbabilidadesMulta.Name = "grdProbabilidadesMulta";
            this.grdProbabilidadesMulta.RowHeadersVisible = false;
            this.grdProbabilidadesMulta.Size = new System.Drawing.Size(351, 166);
            this.grdProbabilidadesMulta.TabIndex = 4;
            // 
            // multa
            // 
            this.multa.HeaderText = "Multa";
            this.multa.Name = "multa";
            // 
            // probabilidadMulta
            // 
            this.probabilidadMulta.HeaderText = "P()";
            this.probabilidadMulta.Name = "probabilidadMulta";
            // 
            // probabilidadAcumuladaMulta
            // 
            this.probabilidadAcumuladaMulta.HeaderText = "P(AC)";
            this.probabilidadAcumuladaMulta.Name = "probabilidadAcumuladaMulta";
            // 
            // grdSimulaciones
            // 
            this.grdSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dia,
            this.rndDemanda,
            this.demanda,
            this.vendidas,
            this.faltantes,
            this.promedioFaltantes,
            this.stock,
            this.sobrante,
            this.promedioATirar,
            this.rndMulta,
            this.multaGenerada,
            this.gananciaMulta,
            this.utilidadMulta,
            this.permiso,
            this.gananciaPermiso,
            this.utilidadPermiso});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSimulaciones.DefaultCellStyle = dataGridViewCellStyle15;
            this.grdSimulaciones.EnableHeadersVisualStyles = false;
            this.grdSimulaciones.Location = new System.Drawing.Point(12, 352);
            this.grdSimulaciones.Name = "grdSimulaciones";
            this.grdSimulaciones.RowHeadersVisible = false;
            this.grdSimulaciones.Size = new System.Drawing.Size(1102, 330);
            this.grdSimulaciones.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHasta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDesde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 83);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muestra de datos";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(144, 49);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 13;
            this.txtHasta.Text = "10000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(144, 23);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 11;
            this.txtDesde.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Desde";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(12, 290);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(258, 34);
            this.btnSimular.TabIndex = 7;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Location = new System.Drawing.Point(258, 706);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 31;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(12, 706);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 32;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(133, 711);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(73, 13);
            this.lblPagina.TabIndex = 33;
            this.lblPagina.Text = "Página 0 de 0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtD);
            this.groupBox3.Controls.Add(this.txtC);
            this.groupBox3.Controls.Add(this.txtB);
            this.groupBox3.Controls.Add(this.txtA);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(363, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 139);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.GhostWhite;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(198, 78);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 5;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.GhostWhite;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(198, 52);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.GhostWhite;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(198, 26);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 3;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "d) Utilidad promedio con permiso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "c) Utilidad promedio con multa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "a) Promedio de tortas faltantes";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.GhostWhite;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(198, 105);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 6;
            this.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "b) Promedio de tortas tiradas";
            // 
            // dia
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dia.DefaultCellStyle = dataGridViewCellStyle1;
            this.dia.HeaderText = "Día";
            this.dia.Name = "dia";
            // 
            // rndDemanda
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rndDemanda.DefaultCellStyle = dataGridViewCellStyle2;
            this.rndDemanda.HeaderText = "RND Demanda";
            this.rndDemanda.Name = "rndDemanda";
            // 
            // demanda
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.demanda.DefaultCellStyle = dataGridViewCellStyle3;
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            // 
            // vendidas
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vendidas.DefaultCellStyle = dataGridViewCellStyle4;
            this.vendidas.HeaderText = "Vendidas";
            this.vendidas.Name = "vendidas";
            // 
            // faltantes
            // 
            this.faltantes.HeaderText = "No surtidas";
            this.faltantes.Name = "faltantes";
            // 
            // promedioFaltantes
            // 
            this.promedioFaltantes.HeaderText = "Promedio No Surtidas";
            this.promedioFaltantes.Name = "promedioFaltantes";
            // 
            // stock
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stock.DefaultCellStyle = dataGridViewCellStyle5;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // sobrante
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sobrante.DefaultCellStyle = dataGridViewCellStyle6;
            this.sobrante.HeaderText = "Sobrante";
            this.sobrante.Name = "sobrante";
            // 
            // promedioATirar
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.promedioATirar.DefaultCellStyle = dataGridViewCellStyle7;
            this.promedioATirar.HeaderText = "Promedio a tirar por día";
            this.promedioATirar.Name = "promedioATirar";
            // 
            // rndMulta
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rndMulta.DefaultCellStyle = dataGridViewCellStyle8;
            this.rndMulta.HeaderText = "RND Multa";
            this.rndMulta.Name = "rndMulta";
            // 
            // multaGenerada
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.multaGenerada.DefaultCellStyle = dataGridViewCellStyle9;
            this.multaGenerada.HeaderText = "Multa";
            this.multaGenerada.Name = "multaGenerada";
            // 
            // gananciaMulta
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gananciaMulta.DefaultCellStyle = dataGridViewCellStyle10;
            this.gananciaMulta.HeaderText = "Ganancia con multa";
            this.gananciaMulta.Name = "gananciaMulta";
            // 
            // utilidadMulta
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.utilidadMulta.DefaultCellStyle = dataGridViewCellStyle11;
            this.utilidadMulta.HeaderText = "Utilidad promedio con multa";
            this.utilidadMulta.Name = "utilidadMulta";
            // 
            // permiso
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.permiso.DefaultCellStyle = dataGridViewCellStyle12;
            this.permiso.HeaderText = "Costo por permiso";
            this.permiso.Name = "permiso";
            // 
            // gananciaPermiso
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.gananciaPermiso.DefaultCellStyle = dataGridViewCellStyle13;
            this.gananciaPermiso.HeaderText = "Ganancia con Permiso";
            this.gananciaPermiso.Name = "gananciaPermiso";
            // 
            // utilidadPermiso
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.utilidadPermiso.DefaultCellStyle = dataGridViewCellStyle14;
            this.utilidadPermiso.HeaderText = "Utilidad promedio con permiso";
            this.utilidadPermiso.Name = "utilidadPermiso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grdSimulaciones);
            this.Controls.Add(this.grdProbabilidadesMulta);
            this.Controls.Add(this.grdProbabilidadesDemandaTorta);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Trabajo práctico 4 - Montecarlo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProbabilidadesDemandaTorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProbabilidadesMulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSimulaciones)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidadSimulaciones;
        private System.Windows.Forms.DataGridView grdProbabilidadesDemandaTorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandaTortas;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadAcumuladaDemanda;
        private System.Windows.Forms.DataGridView grdProbabilidadesMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadAcumuladaMulta;
        private System.Windows.Forms.DataGridView grdSimulaciones;
        private System.Windows.Forms.TextBox txtProduccionDiaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostoTorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioFaltantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioATirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn multaGenerada;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn permiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciaPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadPermiso;
    }
}

