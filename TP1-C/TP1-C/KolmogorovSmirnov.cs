using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_C
{
    public partial class KolmogorovSmirnov : Form
    {
        GestorGraficos gGraficos = new GestorGraficos(false);

        double min = Double.MaxValue;
        double max = Double.MinValue;

        public KolmogorovSmirnov()
        {
            InitializeComponent();
        }
              

        //Si se cambia el intervalo seleccionado 
        private void cmbIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGraficar.Enabled = true;
            string i = cmbIntervalos.SelectedItem.ToString();
            gGraficos.setCantIntervalos(Convert.ToInt32(i));
            gGraficos.setIntervMedio();

            gGraficos.calcularPasos();
            gGraficos.calcularIntervalos();
            gGraficos.calcularIntervalosGrafico();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            gGraficos.graficar(chart1);

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEleccionPunto frmEleccion = new frmEleccionPunto();
            frmEleccion.Show();
        }

        private void KolmogorovSmirnov_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
