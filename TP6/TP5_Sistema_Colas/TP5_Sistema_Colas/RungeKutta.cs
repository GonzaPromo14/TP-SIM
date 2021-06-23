using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5_Sistema_Colas.Entidades;

namespace TP5_Sistema_Colas
{
    public partial class RungeKutta : Form
    {

        Paginador paginador;
        GestorRungeKutta gestorRKProximaPurga;
        public RungeKutta()
        {
            InitializeComponent();
        }

        private void RungeKutta_Load(object sender, EventArgs e)
        {
            this.gestorRKProximaPurga = new GestorRungeKutta(
                (decimal)0.01,
                decimal.Parse(txtAlfa.Text),
                decimal.Parse(txtEInicial.Text),
                decimal.Parse(txtEFinal.Text),
                true
            );
            grdRungeKuttaProxPurga.Rows.Clear();
            gestorRKProximaPurga.cargaRK();
            this.paginador = new Paginador(gestorRKProximaPurga.getRk(), 10);
            paginador.obtenerPaginaActual(gestorRKProximaPurga.getRk(), grdRungeKuttaProxPurga);
            txtTFinal.Text = gestorRKProximaPurga.lastTf().ToString();
            lblPaginaCamiones.Text = "Página 1 de " + paginador.getCantPaginas();
            btnAnteriorPagina.Enabled = false;
            btnSiguientePagina.Enabled = (paginador.getCantPaginas() > 1 && !paginador.esUltimaPagina()) ? true : false;
        }

        private void btnAnteriorPagina_Click(object sender, EventArgs e)
        {
            grdRungeKuttaProxPurga.Rows.Clear();
            paginador.obtenerPaginaAnterior(gestorRKProximaPurga.getRk(), grdRungeKuttaProxPurga);
            lblPaginaCamiones.Text = "Página " + paginador.getPaginaActual() + " de " + paginador.getCantPaginas();
            btnSiguientePagina.Enabled = paginador.getCantPaginas() > 1 ? true : false;
            btnAnteriorPagina.Enabled = (paginador.getCantPaginas() > 1 && !paginador.esPaginaPrimera()) ? true : false;
        }

        private void btnSiguientePagina_Click(object sender, EventArgs e)
        {
            grdRungeKuttaProxPurga.Rows.Clear();
            paginador.obtenerPaginaSiguiente(gestorRKProximaPurga.getRk(), grdRungeKuttaProxPurga);
            lblPaginaCamiones.Text = "Página " + paginador.getPaginaActual() + " de " + paginador.getCantPaginas();
            btnAnteriorPagina.Enabled = paginador.getCantPaginas() > 1 ? true : false;
            btnSiguientePagina.Enabled = (paginador.getCantPaginas() > 1 && !paginador.esUltimaPagina()) ? true : false;
        }
    }
}
