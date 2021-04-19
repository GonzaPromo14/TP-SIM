using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP3.DataLayer;

namespace TP3.GUILayer
{
    public partial class Form2 : Form
    {
        GestorGraficos graficador;
        GestorCalculos gCalculos;
        GestorPruebas gPruebas;
        public Form2(GestorGraficos g, GestorCalculos gCalc, String distribucion)
        {
            InitializeComponent();
            this.gCalculos = gCalc;
            this.graficador = g;
            this.gPruebas = new GestorPruebas(gCalculos, distribucion);
            lblHipotesis.Text = "Los números poseen una distribución " + distribucion;

            //graficador.llenarGrillaFrecuencias(dataGridFrecuencias);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cmbConfianza_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAceptarBondad.Enabled = true;
        }

        private void btnAceptarBondad_Click(object sender, EventArgs e)
        {
            gPruebas.actualizarIntervalos();
            gPruebas.llenarGrillaFrecuencias(dataGridFrecuencias);
            double gradosLibertad = gPruebas.calcularGradosLibertad();
            double valorCalculado = gPruebas.cAcumulada[gPruebas.cantNuevaIntervalos - 1];
            double confianza = double.Parse(cmbConfianza.Text);
            double valorTabulado = ChiSquared.InvCDF(gradosLibertad, double.Parse(cmbConfianza.Text));
            lblRechazo.Text = (valorCalculado <= valorTabulado) ? "No se rechaza la hipótesis nula" : "Se rechaza la hipótesis nula";
            txtValorCalculado.Text = Truncador.Truncar(valorCalculado).ToString();
            txtValorTabulado.Text = Truncador.Truncar(valorTabulado).ToString();
            txtGradosLibertad.Text = gradosLibertad.ToString();
            grbResultados.Visible = true;
            btnAceptarBondad.Enabled = false;
        }
    }
}
