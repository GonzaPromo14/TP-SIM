﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3.DataLayer;


namespace TP3
{
    public partial class Form1 : Form
    {
        Paginador paginador;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmbDistribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            validacionesDistribuciones();
        }

        private void enabledDistribucionUniforme(bool enabled)
        {
            lblCondicionUniforme.Enabled = enabled;
            lblDistribucionUniforme.Enabled = enabled;
            lblValorA.Enabled = enabled;
            lblValorB.Enabled = enabled;
            txtA.Enabled = enabled;
            txtB.Enabled = enabled;
        }

        private void enabledDistribucionExponencial(bool enabled)
        {
            lblDistribucionExponencial.Enabled = enabled;
            txtLamda.Enabled = enabled;
            lblLamda.Enabled = enabled;
        }

        private void enabledDistribucionPoisson(bool enabled)
        {
            lblDistribucionPoisson.Enabled = enabled;
            txtLamdaPoisson.Enabled = enabled;
            lblLamdaPoisson.Enabled = enabled;
        }

        private void enabledDistribucionNormal(bool enabled)
        {
            lblDistribucionNormal.Enabled = enabled;
            lblMedia.Enabled = enabled;
            lblDesvEstandar.Enabled = enabled;
            txtDesvEstandar.Enabled = enabled;
            txtMedia.Enabled = enabled;
            cmbMetodo.Enabled = enabled;
            lblMetodo.Enabled = enabled;
        }

        private void validacionesDistribuciones()
        {
            if (cmbDistribuciones.Text != "")
            {
                btnGenerar.Enabled = true;
            }
            if (cmbDistribuciones.Text == "Uniforme")
            {
                enabledDistribucionExponencial(false);
                enabledDistribucionUniforme(true);
                enabledDistribucionPoisson(false);
                enabledDistribucionNormal(false);

            }
            if (cmbDistribuciones.Text == "Exponencial")
            {
                enabledDistribucionExponencial(true);
                enabledDistribucionUniforme(false);
                enabledDistribucionPoisson(false);
                enabledDistribucionNormal(false);

            }
            if (cmbDistribuciones.Text == "Poisson")
            {
                enabledDistribucionExponencial(false);
                enabledDistribucionUniforme(false);
                enabledDistribucionPoisson(true);
                enabledDistribucionNormal(false);

            }
            if (cmbDistribuciones.Text == "Normal")
            {
                enabledDistribucionExponencial(false);
                enabledDistribucionUniforme(false);
                enabledDistribucionPoisson(false);
                enabledDistribucionNormal(true);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            Distribucion dist = new Distribucion(cmbDistribuciones.Text, Int32.Parse(txtTamanioMuestra.Text));
            grdNumeros.Rows.Clear();
            Random r = new Random();
            List<ValorGenerado> generacionValores = new List<ValorGenerado>();



            switch (dist.getDistribucionElegida())
            {
                case "Uniforme":
                    for (int i = 1; i <= dist.getTamanioMuestra(); i++)
                    {
                        double numero = Math.Round(r.NextDouble(), 4);
                        double numeroGeneradoUniforme = dist.generarNumeroUniforme(numero, double.Parse(txtA.Text), double.Parse(txtB.Text));
                        generacionValores.Add(new ValorGenerado(i, numero, numeroGeneradoUniforme));
                    }
                    break;
                case "Exponencial":
                    for (int i = 1; i <= dist.getTamanioMuestra(); i++)
                    {
                        double numero = Math.Round(r.NextDouble(), 4);
                        double numeroGeneradoExponencial = dist.generarNumeroExponencial(numero, double.Parse(txtLamda.Text));
                        generacionValores.Add(new ValorGenerado(i, numero, numeroGeneradoExponencial));
                    }
                    break;
                case "Poisson":
                    for (int i = 1; i <= dist.getTamanioMuestra(); i++)
                    {
                        generacionValores.Add(new ValorGenerado(i, -1, dist.generarNumeroPoisson(r, double.Parse(txtLamdaPoisson.Text))));
                    }
                    break;
                case "Normal":
                    if (cmbMetodo.Text == "Box - Muller")
                    {
                        int tamanioMuestra = dist.getTamanioMuestra() % 2 == 0 ? dist.getTamanioMuestra() : dist.getTamanioMuestra() + 1;
                        for (int i = 1; i <= tamanioMuestra; i = i + 2)
                        {
                            double valorGenerado1 = r.NextDouble();
                            double valorGenerado2 = r.NextDouble();
                            double[] valoresGenerados = dist.generarNumeroNormalBoxMuller(valorGenerado1, valorGenerado2, double.Parse(txtMedia.Text), double.Parse(txtDesvEstandar.Text));
                            generacionValores.Add(new ValorGenerado(i, valorGenerado1, valoresGenerados[0]));
                            generacionValores.Add(new ValorGenerado(i + 1, valorGenerado2, valoresGenerados[1]));

                        }
                    }else
                    {
                        for (int i = 1; i<=dist.getTamanioMuestra(); i++)
                        {
                            generacionValores.Add(new ValorGenerado(i, -1, dist.generarNumeroNormalConvolucion(r, int.Parse(txtK.Text), double.Parse(txtMedia.Text), double.Parse(txtDesvEstandar.Text))));
                        }
                    }
                    
                    break;
            }
            paginador = new Paginador(generacionValores, 10);
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = paginador.getCantPaginas() == 1 ? false : true;
            txtPagina.Enabled = paginador.getCantPaginas() == 1 ? false : true;
            btnIr.Enabled = paginador.getCantPaginas() == 1 ? false : true;
            paginador.obtenerPaginaActual(grdNumeros);
            lblPagina.Text = "Página " + paginador.getPaginaActual().ToString() + " de " + paginador.getCantPaginas();
            cmbIntervalos.Enabled = true;
        }

        private void grdNumeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            grdNumeros.Rows.Clear();
            btnAnterior.Enabled = true;
            paginador.obtenerPaginaSiguiente(grdNumeros);
            if (paginador.esUltimaPagina())
            {
                btnSiguiente.Enabled = false;
            }
            lblPagina.Text = "Página " + paginador.getPaginaActual().ToString() + " de " + paginador.getCantPaginas();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            grdNumeros.Rows.Clear();
            btnSiguiente.Enabled = true;
            paginador.obtenerPaginaAnterior(grdNumeros);
            if (paginador.esPaginaPrimera())
            {
                btnAnterior.Enabled = false;
            }
            lblPagina.Text = "Página " + paginador.getPaginaActual().ToString() + " de " + paginador.getCantPaginas();

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            btnAnterior.Enabled = true;
            if (int.Parse(txtPagina.Text) >= paginador.getCantPaginas())
            {
                txtPagina.Text = paginador.getCantPaginas().ToString();
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = true;
            }
            if (int.Parse(txtPagina.Text) <= 0)
            {
                txtPagina.Text = 1.ToString();
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = false;
            }
            grdNumeros.Rows.Clear();
            paginador.irAPagina(grdNumeros, int.Parse(txtPagina.Text));
            lblPagina.Text = "Página " + paginador.getPaginaActual().ToString() + " de " + paginador.getCantPaginas();

        }

        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMetodo.Text == "Convolución")
            {
                lblMetodoConvolucion.Enabled = true;
                lblK.Enabled = true;
                txtK.Enabled = true;
            }
            else
            {
                lblMetodoConvolucion.Enabled = false;
                lblK.Enabled = false;
                txtK.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
