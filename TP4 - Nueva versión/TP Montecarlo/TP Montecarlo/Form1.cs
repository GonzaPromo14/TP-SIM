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
        Paginador p;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestorCalculos = new GestorCalculos();
            gestorCalculos.llenarGrillas(grdProbabilidadesDemandaTorta, grdProbabilidadesMulta);

            //colores//

            grdSimulaciones.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);
            grdSimulaciones.Columns[7].DefaultCellStyle.BackColor = Color.FromArgb(217, 225, 242);

            grdSimulaciones.Columns[6].HeaderCell.Style.BackColor = Color.FromArgb(244, 176, 132);
            grdSimulaciones.Columns[6].DefaultCellStyle.BackColor = Color.FromArgb(252, 228, 214);


            grdSimulaciones.Columns[8].HeaderCell.Style.BackColor = Color.FromArgb(226, 239, 218);
            grdSimulaciones.Columns[9].HeaderCell.Style.BackColor = Color.FromArgb(226, 239, 218);
            grdSimulaciones.Columns[10].HeaderCell.Style.BackColor = Color.FromArgb(169, 208, 142);
            grdSimulaciones.Columns[10].DefaultCellStyle.BackColor = Color.FromArgb(226, 239, 218);


            grdSimulaciones.Columns[11].HeaderCell.Style.BackColor = Color.FromArgb(255, 242, 204);
            grdSimulaciones.Columns[12].HeaderCell.Style.BackColor = Color.FromArgb(255, 242, 204);
            grdSimulaciones.Columns[13].HeaderCell.Style.BackColor = Color.FromArgb(255, 217, 102);
            grdSimulaciones.Columns[13].DefaultCellStyle.BackColor = Color.FromArgb(255, 242, 204);



            foreach (DataGridViewColumn col in grdSimulaciones.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            grdSimulaciones.Rows.Clear();
            Random r = new Random();
            long cantidadDiasAMostrar = long.Parse(txtHasta.Text) - long.Parse(txtDesde.Text);

            gestorCalculos.inicializarParametrosCalculos(
                int.Parse(txtCostoTorta.Text),
                int.Parse(txtPrecioVenta.Text),
                int.Parse(txtMulta.Text),
                int.Parse(txtProduccionDiaria.Text),
                int.Parse(txtCantidadSimulaciones.Text),
                double.Parse(txtDesde.Text),
                double.Parse(txtHasta.Text),
                cantidadDiasAMostrar
                );
            int cantidadSimulaciones = int.Parse(txtCantidadSimulaciones.Text);
            gestorCalculos.generarSimulacion(cantidadSimulaciones, grdSimulaciones);
            p = new Paginador(gestorCalculos.getSimulaciones(), 10);
            p.obtenerPaginaActual(grdSimulaciones);
            btnSiguiente.Enabled = p.getCantPaginas() == 1 ? false : true;
            lblPagina.Text = "Página " + p.getPaginaActual().ToString() + " de " + p.getCantPaginas();
            txtTotal.Text = gestorCalculos.totalFinal().ToString();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            grdSimulaciones.Rows.Clear();
            btnAnterior.Enabled = true;
            p.obtenerPaginaSiguiente(grdSimulaciones);
            if (p.esUltimaPagina())
            {
                btnSiguiente.Enabled = false;
            }
            lblPagina.Text = "Página " + p.getPaginaActual().ToString() + " de " + p.getCantPaginas().ToString();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            grdSimulaciones.Rows.Clear();
            btnSiguiente.Enabled = true;
            p.obtenerPaginaAnterior(grdSimulaciones);
            if (p.esPaginaPrimera())
            {
                btnAnterior.Enabled = false;
            }
            lblPagina.Text = "Página " + p.getPaginaActual().ToString() + " de " + p.getCantPaginas().ToString();

        }

        private void txtCantidadSimulaciones_TextChanged(object sender, EventArgs e)
        {
            txtHasta.Text = txtCantidadSimulaciones.Text;
        }
    }
}
