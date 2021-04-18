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
        public Form2(GestorGraficos g, GestorCalculos gCalc)
        {
            InitializeComponent();
            this.gCalculos = gCalc;
            this.graficador = g;
            this.gPruebas = new GestorPruebas(gCalculos);
            gPruebas.actualizarIntervalos();
            gPruebas.llenarGrillaFrecuencias(dataGridFrecuencias);
            double valorCalculado = gPruebas.cAcumulada[gPruebas.cantNuevaIntervalos - 1];
            double valorTabulado = ChiSquared.InvCDF(8, 0.05);
            lblPasaPrueba.Text = (valorCalculado <= valorTabulado) ? "Pasa prueba" : "No pasa prueba";
            txtValorCalculado.Text = gPruebas.cAcumulada[gPruebas.cantNuevaIntervalos - 1].ToString();
            txtValorTabulado.Text = ChiSquared.InvCDF(gPruebas.cantNuevaIntervalos, 0.05).ToString();


            //graficador.llenarGrillaFrecuencias(dataGridFrecuencias);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
