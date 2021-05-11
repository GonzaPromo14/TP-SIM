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

            if (!validarInputs()) return;

            grdSimulaciones.Rows.Clear();
            Random r = new Random();
            long cantidadDiasAMostrar = long.Parse(txtHasta.Text) - long.Parse(txtDesde.Text);

            gestorCalculos.inicializarParametrosCalculos(
                double.Parse(txtCostoTorta.Text),
                double.Parse(txtPrecioVenta.Text),
                double.Parse(txtMulta.Text),
                int.Parse(txtProduccionDiaria.Text),
                int.Parse(txtCantidadSimulaciones.Text),
                double.Parse(txtDesde.Text),
                double.Parse(txtHasta.Text),
                cantidadDiasAMostrar
                );
            int cantidadSimulaciones = int.Parse(txtCantidadSimulaciones.Text);
            gestorCalculos.generarSimulacion(cantidadSimulaciones, grdSimulaciones);

            txtA.Text = Truncador.Truncar(gestorCalculos.getResultadoSimulación(cantidadDiasAMostrar, 6)).ToString();
            txtB.Text = "$" + Truncador.Truncar(gestorCalculos.getResultadoSimulación(cantidadDiasAMostrar, 10)).ToString();
            txtC.Text = "$" + Truncador.Truncar(gestorCalculos.getResultadoSimulación(cantidadDiasAMostrar, 13)).ToString();


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

        //######################################################## VALIDACIONES ########################################################
        private bool validarInputs()
        {
            bool cantidad = validarCantidad();
            bool desde = validarDesde();
            bool hasta = validarHasta();
            bool costo = validarCosto();
            bool precio = validarPrecio();
            bool multa = validarMulta();

            return (cantidad && desde && hasta && costo && precio && multa);
        }


        private bool validarCantidad()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCantidadSimulaciones.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solo números positivos en el campo 'Cantidad de simulaciones'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidadSimulaciones.Text = "";
                return false;
            }
            return true;
        }

        private bool validarDesde()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDesde.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solo números positivos en el campo 'Desde'","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesde.Text = "";
                return false;
            }
            return true;
        }

        private bool validarHasta()
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtHasta.Text, "[^0-9]"))
            {
                MessageBox.Show("Ingrese solo números positivos en el campo 'Hasta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHasta.Text = "";
                return false;
            }
            try
            {
                if (int.Parse(txtHasta.Text) < int.Parse(txtDesde.Text))
                {
                    MessageBox.Show("El valor 'Hasta' no puede ser menor a 'Desde'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHasta.Text = "";
                    return false;
                }
            }
            catch(System.FormatException e) { }
            return true;
        }

        private bool validarCosto()
        {
            double costo = -1;
            try
            {
                costo = double.Parse(txtCostoTorta.Text);
            }
            catch (System.FormatException e) { };

            if (costo<0)
            {
                MessageBox.Show("Ingrese un número positivo en el campo 'Costo por torta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoTorta.Text = "";
                return false;
            }
            return true;
        }

        private bool validarPrecio()
        {
            double precio = -1;
            try
            {
                precio = double.Parse(txtPrecioVenta.Text);
            }
            catch (System.FormatException e) { };

            if (precio < 0)
            {
                MessageBox.Show("Ingrese un número positivo en el campo 'Precio de venta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoTorta.Text = "";
                return false;
            }
            return true;
        }

        private bool validarMulta()
        {
            double multa = -1;
            try
            {
                multa = double.Parse(txtPrecioVenta.Text);
            }
            catch (System.FormatException e) { };

            if (multa < 0)
            {
                MessageBox.Show("Ingrese un número positivo en el campo 'Costo de multa'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCostoTorta.Text = "";
                return false;
            }
            return true;
        }
    }
}
