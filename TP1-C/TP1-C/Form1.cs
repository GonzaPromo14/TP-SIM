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
    public partial class frmPrincipal : Form
    {

        Metodo metodoElegido = new Metodo();
        Semilla sem;
        int valoresAGenerar = 24;
        int cantItemsPorPag = 10;
        int paginaActual = 1;
        Semilla[] valoresGeneradosParaGrilla;

        //Con array
        SemillaArray semillaArray = new SemillaArray(20);

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private bool datosValidos()
        {
            int validacionEntero;
            bool esNumero;
            esNumero = Int32.TryParse(txtXo.Text, out validacionEntero);
            if (!esNumero)
            {
                lblError.Text = "El valor Xo es incorrecto";
                return false;
            }
            esNumero = Int32.TryParse(txtC.Text, out validacionEntero);
            if (!esNumero)
            {
                lblError.Text = "El valor C es incorrecto";
                return false;
            }
            esNumero = Int32.TryParse(txtA.Text, out validacionEntero);
            if (!esNumero)
            {
                lblError.Text = "El valor A es incorrecto";
                return false;
            }
            esNumero = Int32.TryParse(txtM.Text, out validacionEntero);
            if (!esNumero)
            {
                lblError.Text = "El valor M es incorrecto";
                return false;
            }
            lblError.Text = "";
            return true;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            bool validacion = datosValidos();
            if (validacion)
            {
                semillaArray.clear();
                double semilla = Double.Parse(txtXo.Text);
                double c = Double.Parse(txtC.Text);
                double a = Double.Parse(txtA.Text);
                double m = Double.Parse(txtM.Text);
                valoresGeneradosParaGrilla = new Semilla[valoresAGenerar];
                sem = new Semilla(semilla, c, a, m);
                grdNumeros.Rows.Clear();
                for (int i = 0; i <= valoresAGenerar; i++)
                {
                    if (i == 0)
                    {
                        lblSemillaInicial.Text = "Semilla inicial: " + sem.getValorSemilla().ToString();
                    }
                    else
                    {
                        sem.sumarIteracion();
                        double axic = sem.calcularAxic();
                        double siguienteSemilla = axic % m;
                        double valorAleatorioGenerado = siguienteSemilla / (m - 1);
                        valorAleatorioGenerado = Math.Truncate(valorAleatorioGenerado * 10000)/10000;
                        sem.setValorSemilla(siguienteSemilla);
                        semillaArray.add(new Semilla(sem.getValorSemilla(), c, a, m, i, valorAleatorioGenerado));
                    }
                }
                paginaActual = 1;
                llenarGrilla(paginaActual, cantItemsPorPag);
                btnProximo.Enabled = true;
                btnSiguiente.Enabled = true;
                btnAnterior.Enabled = false;
                btnIr.Enabled = true;
                txtPagina.Enabled = true;
                lblPagina.Text = "Página 1 de " + calcularValorTotalPaginas().ToString();
                
            }
            
        }
        

        private void btnLineal_Click(object sender, EventArgs e)
        {
            btnMultiplicativo.Enabled = true;
            btnLineal.Enabled = false;
            metodoElegido.setLineal(true);
            btnProximo.Enabled = false;
            lblMetodoElegido.Text = "Lineal";
            txtXo.Enabled = true;
            txtG.Enabled = true;
            txtK.Enabled = true;
            txtC.Text = "";
            txtC.Enabled = true;
            txtA.Enabled = true;
            txtM.Enabled = true;
            btnGenerar.Enabled = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnMultiplicativo_Click(object sender, EventArgs e)
        {
            btnLineal.Enabled = true;
            btnMultiplicativo.Enabled = false;
            metodoElegido.setLineal(false);
            btnProximo.Enabled = false;
            lblMetodoElegido.Text = "Multiplicativo";
            txtXo.Enabled = true;
            txtG.Enabled = true;
            txtK.Enabled = true;
            txtA.Enabled = true;
            txtM.Enabled = true;
            txtC.Text = 0.ToString();
            txtC.Enabled = false;
            btnGenerar.Enabled = true;
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            int validacionEntero;
            bool esNumero;
            if (txtK.Text != ""){
                esNumero = Int32.TryParse(txtK.Text, out validacionEntero);
                if (esNumero)
                {
                    if (metodoElegido.isLineal())
                    {
                        txtA.Text = (1 + (4 * Int32.Parse(txtK.Text))).ToString();
                    }
                    else
                    {
                        txtA.Text = (3 + (8 * Int32.Parse(txtK.Text))).ToString();
                    }
                }
            }
            else
            {
                txtA.Text = "";
            }
            
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            if (txtG.Text != "")
            {
                int validacionEntero;
                bool esNumero;
                esNumero = Int32.TryParse(txtG.Text, out validacionEntero);
                if (esNumero)
                {
                   txtM.Text = (Math.Pow(2, Int32.Parse(txtG.Text))).ToString();
                }
            }
            else
            {
                txtM.Text = "";
            }
        }

        private void txtXo_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            sem.sumarIteracion();
            double axic = (sem.getValorSemilla() * sem.getA()) + sem.getC();
            double siguienteSemilla = axic % sem.getM();
            double valorAleatorioGenerado = siguienteSemilla / (sem.getM() - 1);
            valorAleatorioGenerado = Math.Truncate(valorAleatorioGenerado * 10000) / 10000;
            sem.setValorSemilla(siguienteSemilla);
            semillaArray.add(new Semilla(siguienteSemilla, sem.getC(), sem.getA(), sem.getM(), sem.getIteracion(), valorAleatorioGenerado));
            llenarGrilla(calcularValorTotalPaginas(), cantItemsPorPag);
            lblPagina.Text = "Página " + calcularValorTotalPaginas().ToString() + " de " + calcularValorTotalPaginas().ToString();
            btnSiguiente.Enabled = false;
            btnAnterior.Enabled = true;
            paginaActual = calcularValorTotalPaginas();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void llenarGrilla(int pagina, int cantItemsPorPag)
        {
            grdNumeros.Rows.Clear();
            int final = (pagina * cantItemsPorPag);
            int inicio = final - cantItemsPorPag;
            for (int i = inicio; i<final; i++)
            {
                if (i >= semillaArray.size())
                {
                    break;
                }
                grdNumeros.Rows.Add(semillaArray.get(i).convertirStringData());
            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (txtPagina.Text != "")
            {
                if (Int32.TryParse(txtPagina.Text, out int result))
                {
                    int paginaMoverse = Int32.Parse(txtPagina.Text);
                    if (paginaMoverse <= calcularValorTotalPaginas())
                    {
                        lblErrorPagina.Text = "";
                        lblPagina.Text = "Página " + paginaMoverse.ToString() + " de " + calcularValorTotalPaginas().ToString();
                        llenarGrilla(paginaMoverse, cantItemsPorPag);
                        paginaActual = paginaMoverse;
                        btnAnterior.Enabled = true;
                        btnSiguiente.Enabled = true;
                        if (paginaMoverse == 1)
                        {
                            btnAnterior.Enabled = false;
                            btnSiguiente.Enabled = true;
                        }
                        if (paginaMoverse == calcularValorTotalPaginas())
                        {
                            btnAnterior.Enabled = true;
                            btnSiguiente.Enabled = false;
                        }
                    }
                    else
                    {
                        lblErrorPagina.Text = "* Ingresó una página mayor a la esperada";
                        lblErrorPagina.ForeColor = Color.Red;
                    }

                }
                else
                {
                    lblErrorPagina.Text = "* Ingrese un valor válido";
                    lblErrorPagina.ForeColor = Color.Red;
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            btnAnterior.Enabled = true;
            paginaActual++;
            if (paginaActual == calcularValorTotalPaginas())
            {
                btnSiguiente.Enabled = false;
            }
            lblPagina.Text = "Página " + paginaActual.ToString() + " de " + calcularValorTotalPaginas().ToString();
            llenarGrilla(paginaActual, cantItemsPorPag);
            lblErrorPagina.Text = "";
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            paginaActual--;
            btnSiguiente.Enabled = true;
            if (paginaActual == 1)
            {
                btnAnterior.Enabled = false;
            }
            lblPagina.Text = "Página " + paginaActual.ToString() + " de " + calcularValorTotalPaginas().ToString();
            llenarGrilla(paginaActual, cantItemsPorPag);
            lblErrorPagina.Text = "";
        }

        private int calcularValorTotalPaginas()
        {
            int cantPaginas = semillaArray.size() / cantItemsPorPag;
            double resto = semillaArray.size() % cantItemsPorPag;
            if (resto != 0)
            {
                cantPaginas++;
                return cantPaginas;
            }
            return cantPaginas;
        }

        
    }
}
