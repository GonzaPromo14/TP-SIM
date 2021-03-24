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
                double semilla = Double.Parse(txtXo.Text);
                double c = Double.Parse(txtC.Text);
                double a = Double.Parse(txtA.Text);
                double m = Double.Parse(txtM.Text);
                sem = new Semilla(semilla, c, a, m);
                grdNumeros.Rows.Clear();
                for (int i = 0; i <= 20; i++)
                {
                    if (i == 0)
                    {
                        grdNumeros.Rows.Add(new string[] { i.ToString(), "", sem.getValorSemilla().ToString(), "" });
                    }
                    else
                    {
                        sem.sumarIteracion();
                        double axic = (sem.getValorSemilla() * a) + c;
                        double siguienteSemilla = axic % m;
                        double valorAleatorioGenerado = siguienteSemilla / (m - 1);
                        valorAleatorioGenerado = Math.Truncate(valorAleatorioGenerado * 10000)/10000;
                        grdNumeros.Rows.Add(new string[] { sem.getIteracion().ToString(), axic.ToString(), siguienteSemilla.ToString(), valorAleatorioGenerado.ToString() });
                        sem.setValorSemilla(siguienteSemilla);
                    }
                }
                btnProximo.Enabled = true;
                
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
            grdNumeros.Rows.Add(new string[] { sem.getIteracion().ToString(), axic.ToString(), siguienteSemilla.ToString(), valorAleatorioGenerado.ToString() });
            sem.setValorSemilla(siguienteSemilla);
        }
    }
}
