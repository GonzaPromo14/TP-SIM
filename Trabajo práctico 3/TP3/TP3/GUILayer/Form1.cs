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
using TP3.GUILayer;

namespace TP3
{
    public partial class Form1 : Form
    {
        Paginador paginador;
        GestorGraficos graficador;
        GestorCalculos gCalculos;

        Form2 ventana2;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.gCalculos = new GestorCalculos();
            this.graficador = new GestorGraficos(gCalculos); //le paso el gestorCalculos al graficador para que tenga los datos


        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cmbIntervalos.Enabled = true;
            button1.Enabled = true;
            btnPruebaKS.Enabled = (cmbDistribuciones.Text == "Poisson") ? false : true;            
            if (cmbDistribuciones.Text == "Uniforme")
            {
                if (int.Parse(txtA.Text) > int.Parse(txtB.Text))
                {
                    String aux = txtA.Text;
                    txtA.Text = txtB.Text;
                    txtB.Text = aux;
                }
            }
            Distribucion dist = new Distribucion(cmbDistribuciones.Text);
            grdNumeros.Rows.Clear();
            
            gCalculos.obtenerMuestras();

            graficador.graficar(chart1,dataGridFrecuencias);
            
            paginador = new Paginador(gCalculos.getValoresGenerados(), 10);
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = paginador.getCantPaginas() == 1 ? false : true;
            txtPagina.Enabled = paginador.getCantPaginas() == 1 ? false : true;
            btnIr.Enabled = paginador.getCantPaginas() == 1 ? false : true;
            paginador.obtenerPaginaActual(grdNumeros);
            lblPagina.Text = "Página " + paginador.getPaginaActual().ToString() + " de " + paginador.getCantPaginas();
            cmbIntervalos.Enabled = (cmbDistribuciones.Text == "Poisson") ? false : true;
        }


        //Setteo la distribucion en el gestor
        private void cmbDistribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTamanioMuestra.Enabled = true;
            button1.Enabled = false;
            validacionesDistribuciones();
            
            Distribucion dist = new Distribucion(cmbDistribuciones.Text);
            gCalculos.setDistribucion(dist);
            grdNumeros.Rows.Clear();
            if (cmbDistribuciones.Text == "Poisson") btnPruebaKS.Enabled = false;

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


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //VALIDADORES ####################################################################################


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



        private void enabledDistribucionUniforme(bool enabled)
        {
            groupUniforme.Enabled = enabled;
            lblCondicionUniforme.Enabled = enabled;

            lblValorA.Enabled = enabled;
            lblValorB.Enabled = enabled;
            txtA.Enabled = enabled;
            txtB.Enabled = enabled;
        }

        private void enabledDistribucionExponencial(bool enabled)
        {
            groupExponencial.Enabled = enabled;

            txtLamda.Enabled = enabled;
            lblLamda.Enabled = enabled;
        }

        private void enabledDistribucionPoisson(bool enabled)
        {
            groupPoisson.Enabled = enabled;

            txtLamdaPoisson.Enabled = enabled;
            lblLamdaPoisson.Enabled = enabled;
        }

        private void enabledDistribucionNormal(bool enabled)
        {
            groupNormal.Enabled = enabled;

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
                btnGenerar.Enabled = false;
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



        private void txtA_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                if(double.Parse(txtA.Text) > 0.00)
                {
                    gCalculos.setA(double.Parse(txtA.Text));
                btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
               
            }
            catch (FormatException)
            {
                if (txtA.Text != "" && txtA.Text != "-")
                {
                    
                    MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }
            

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(double.Parse(txtB.Text) > 0.00)
                {
                    gCalculos.setB(double.Parse(txtB.Text));
                btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
            }
            catch (FormatException)
            {
                if (txtB.Text != "" && txtB.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }

        }

        private void txtLamda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(double.Parse(txtLamda.Text) > 0.00)
                {
                    gCalculos.setLambda(double.Parse(txtLamda.Text));
                    btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
            }
            catch (FormatException)
            {
                if (txtLamda.Text != "" && txtLamda.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                btnGenerar.Enabled = false;
            }
        }

        private void txtLamdaPoisson_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(int.Parse(txtLamdaPoisson.Text) > 0)
                {
                    gCalculos.setLambda(int.Parse(txtLamdaPoisson.Text));
                    btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
            }
            catch (FormatException)
            {
                if (txtLamdaPoisson.Text != "" && txtLamdaPoisson.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido o numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }

        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(double.Parse(txtMedia.Text) > 0)
                {
                    gCalculos.setMedia(double.Parse(txtMedia.Text));
                    btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
            }
            catch (FormatException)
            {
                if (txtMedia.Text != "" && txtMedia.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }
        }

        private void txtDesvEstandar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                 if(double.Parse(txtDesvEstandar.Text) > 0)
                {
                    gCalculos.setDesviacion(double.Parse(txtDesvEstandar.Text));
                    btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
                
            }
            catch (FormatException)
            {
                if (txtDesvEstandar.Text != "" && txtDesvEstandar.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }
        }

        public void txtK_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(int.Parse(txtK.Text) > 0)
                {
                   btnGenerar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
            }
            catch (FormatException)
            {
                if (txtK.Text != "" && txtK.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido o numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }
        }


        private void txtTamanioMuestra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(int.Parse(txtTamanioMuestra.Text) > 0)
                {
                    gCalculos.setTamanioMuestra(int.Parse(txtTamanioMuestra.Text));
                    btnGenerar.Enabled = true;
                    cmbIntervalos.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Ingrese numero positivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGenerar.Enabled = false;
                }
                
                
            }
            catch (FormatException)
            {
                if (txtTamanioMuestra.Text != "" && txtTamanioMuestra.Text != "-")
                {
                    MessageBox.Show("Ingrese un valor válido o numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnGenerar.Enabled = false;
            }
        }

        private void cmbIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            gCalculos.actualizarIntervalos(int.Parse(cmbIntervalos.Text));
            //Grafico con los intervalos elegidos
            graficador.graficar(chart1, dataGridFrecuencias);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana2 = new Form2(gCalculos, cmbDistribuciones.Text);
            ventana2.Text = "Prueba CHI";
            ventana2.Show();
        }

        private void btnPruebaKS_Click(object sender, EventArgs e)
        {
            ventana2 = new Form2(gCalculos, cmbDistribuciones.Text);
            ventana2.Text = "Prueba KS";
            ventana2.comboKS();
            ventana2.Show();

        }
    }
}
