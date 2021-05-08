using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Montecarlo
{
    public partial class Form1 : Form
    {
        GestorCalculos gestorCalculos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestorCalculos = new GestorCalculos();
            gestorCalculos.llenarGrillas(grdProbabilidadesDemandaTorta, grdProbabilidadesMulta);
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            gestorCalculos.inicializarParametrosCalculos(
                int.Parse(txtCostoTorta.Text),
                int.Parse(txtPrecioVenta.Text),
                int.Parse(txtMulta.Text),
                int.Parse(txtProduccionDiaria.Text)
                );
            int cantidadSimulaciones = int.Parse(txtCantidadSimulaciones.Text);
            gestorCalculos.generarSimulacion(cantidadSimulaciones, grdSimulaciones);
        }
    }
}
