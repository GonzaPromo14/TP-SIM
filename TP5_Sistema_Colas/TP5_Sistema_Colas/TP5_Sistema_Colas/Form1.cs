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
    public partial class Form1 : Form
    {
        ControladorSimulacion controlador;
        FormCamiones form2;
        FormZonas form3;
        Paginador p;

        public Form1()
        {
            InitializeComponent();
            controlador = new ControladorSimulacion(this);
            cargarColumnas(dgvFinal);
            cargarColumnas(dgvSimulaciones);


        }

        public void cargarColumnas(DataGridView dgv)
        {
            //Para que no se muevan las dos primeras
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Width = 200;
            dgv.Columns[1].Frozen = true;
            dgv.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;
            dgv.Columns[2].Frozen = true;



            Color color;
            string pos;
            for (int i= 0; i < 8; i++)
            {
      

                if (i % 2 == 0)
                {
                    color = Color.FromArgb(217, 225, 242);
                }
                else
                {
                    color = Color.White;
                }

                pos = "RNDllegada" + i.ToString();
                dgv.Columns.Add(pos, "RND Llegada");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoLlegada" + i.ToString();
                dgv.Columns.Add(pos, "Tiempo Llegada");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "proximaLlegada" + i.ToString();
                dgv.Columns.Add(pos, "Proxima llegada");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;
                dgv.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "RNDRep1" + i.ToString();
                dgv.Columns.Add(pos, "RND1");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "RNDRep2" + i.ToString();
                dgv.Columns.Add(pos, "RND2");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoReparacion" + i.ToString();
                dgv.Columns.Add(pos, "Tiempo reparacion");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "finReparacion" + i.ToString();
                dgv.Columns.Add(pos, "Proximo fin reparacion");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;
                dgv.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "seVaAOtraZona" + i.ToString();
                dgv.Columns.Add(pos, "Se va a otra zona");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "cola" + i.ToString();
                dgv.Columns.Add(pos, "Cola Zona "+(i+1).ToString());
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "estado" + i.ToString();
                dgv.Columns.Add(pos, "Estado Zona "+(i + 1).ToString());
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;
            }

        }


        public bool NoTieneExceso()
        {
            //devuelve true si no hay numero
            return (txtExceso.Text == "-");
        }

        public void cargarExceso()
        {
            
            txtExceso.Text = controlador.vectorActual[Constantes.colReloj].ToString();
        }
        public void cargarLinea(dynamic[] vector, int pos)
        {
            /*
            dynamic[] result = new dynamic[20];
            Array.Copy(vector, 0, result, 0, 20);
*/
            //simulaciones[pos] = vector;
            dgvSimulaciones.Rows.Add(vector);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            txtExceso.Text = "-";

            controlador.iteraciones = int.Parse(txtCantSimulaciones.Text);
            int resultado;
            if (int.TryParse(txtDesde.Text, out resultado) && int.TryParse(txtHasta.Text, out resultado))
            {
                controlador.desde = int.Parse(txtDesde.Text);
                controlador.hasta = int.Parse(txtHasta.Text);

            }
            else
            {
                controlador.desde = 0;
                controlador.hasta = 500;
            }
            dgvSimulaciones.Rows.Clear();
            //inicio simulacion
            controlador.simular();
            p = new Paginador(controlador.getSimulaciones(), 10);
            p.obtenerPaginaActual(controlador.getSimulaciones(), dgvSimulaciones);
            txtCamiones.Text = controlador.contadorCamiones.ToString();

            lblPagina.Text = "Página 1 de " + p.getCantPaginas();
            dgvFinal.Rows.Clear();
            dgvFinal.Rows.Add(controlador.getUltimaSimulacion());

            if (txtExceso.Text == "-") txtExceso.Text = "No se superó la capacidad máxima";
        }

        private void btnCamiones_Click(object sender, EventArgs e)
        {
            form2 = new FormCamiones(controlador);
            form2.Show();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Columns[0].Visible = false;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Rows.Clear();
            p.obtenerPaginaAnterior(controlador.getSimulaciones(), dgvSimulaciones);
            lblPagina.Text = "Página " + p.getPaginaActual() + " de " + p.getCantPaginas();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Rows.Clear();
            p.obtenerPaginaSiguiente(controlador.getSimulaciones(), dgvSimulaciones);
            lblPagina.Text = "Página " + p.getPaginaActual() + " de " + p.getCantPaginas();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3 = new FormZonas(controlador);
            form3.Show();
        }
    }
}
