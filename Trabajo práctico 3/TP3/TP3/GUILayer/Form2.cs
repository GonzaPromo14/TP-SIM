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
        //GestorGraficos graficador;
        GestorCalculos gCalculos;
        GestorPruebas gPruebas;
        Dictionary<double, double> confianzaKS = new Dictionary<double, double>();


        public Form2( GestorCalculos gCalc, String distribucion)
        {
            InitializeComponent();
            this.gCalculos = gCalc;
            //this.graficador = g;
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
            cmbConfianza.Enabled = false;
            gPruebas.actualizarIntervalos();

            if(this.Text == "Prueba CHI")
            {
                gPruebas.llenarGrillaFrecuenciasCHI(dataGridFrecuencias);
                double gradosLibertad = gPruebas.calcularGradosLibertad();
                double valorCalculado = gPruebas.cAcumulada[gPruebas.cantNuevaIntervalos - 1];
                double confianza = double.Parse(cmbConfianza.Text);

                double valorTabulado = ChiSquared.InvCDF(gradosLibertad, confianza);

                lblRechazo.Text = (valorCalculado <= valorTabulado) ? "No se rechaza la hipótesis nula" : "Se rechaza la hipótesis nula";
                txtValorCalculado.Text = Truncador.Truncar(valorCalculado).ToString();
                txtValorTabulado.Text = Truncador.Truncar(valorTabulado).ToString();
                txtGradosLibertad.Text = gradosLibertad.ToString();
                grbResultados.Visible = true;
                btnAceptarBondad.Enabled = false;

            }
            else
            {
                gPruebas.llenarGrillaFrecuenciasKS(dataGridFrecuencias);
                double gradosLibertad = gCalculos.getTamanioMuestra();
                double valorCalculado = gPruebas.KS[gPruebas.cantNuevaIntervalos - 1];
                double confianza = double.Parse(cmbConfianza.Text);

                double valorTabulado = confianzaKS[confianza] / Math.Sqrt(gradosLibertad);

                lblRechazo.Text = (valorCalculado <= valorTabulado) ? "No se rechaza la hipótesis nula" : "Se rechaza la hipótesis nula";
                txtValorCalculado.Text = Truncador.Truncar(valorCalculado).ToString();
                txtValorTabulado.Text = Truncador.Truncar(valorTabulado).ToString();
                txtGradosLibertad.Text = gradosLibertad.ToString();
                grbResultados.Visible = true;
                btnAceptarBondad.Enabled = false;
            }

        }
        
        public void comboKS()
        {   //agrego confianza para ks
            this.cmbConfianza.Items.Clear();
            double[] items = { 0.20, 0.10, 0.05, 0.02, 0.01, 0.005, 0.002, 0.001 };

            System.Object[] ItemObject = new System.Object[8];
            for (int i = 0; i < 8; i++)
            {
                ItemObject[i] = items[i];
            }
            this.cmbConfianza.Items.AddRange(ItemObject);

            //como aparece en el PDF para calcular ks
            confianzaKS[0.20] = 1.07;
            confianzaKS[0.10] = 1.22;
            confianzaKS[0.05] = 1.36;
            confianzaKS[0.02] = 1.52;
            confianzaKS[0.01] = 1.63;
            confianzaKS[0.005] = 1.73;
            confianzaKS[0.002] = 1.85;
            confianzaKS[0.001] = 1.95;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grbResultados_Enter(object sender, EventArgs e)
        {

        }
    }
}
