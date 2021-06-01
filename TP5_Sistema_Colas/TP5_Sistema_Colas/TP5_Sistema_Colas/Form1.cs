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
        Paginador p;

        public Form1()
        {
            InitializeComponent();
            controlador = new ControladorSimulacion(this);
            cargarColumnas();
            
        }

        public void cargarColumnas()
        {
            //Para que no se muevan las dos primeras
            dgvSimulaciones.Columns[0].Frozen = true;
            dgvSimulaciones.Columns[1].Width = 200;
            dgvSimulaciones.Columns[1].Frozen = true;
            dgvSimulaciones.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;
            dgvSimulaciones.Columns[2].Frozen = true;



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
                dgvSimulaciones.Columns.Add(pos, "RND Llegada");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoLlegada" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Tiempo Llegada");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "proximaLlegada" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Proxima llegada");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;
                dgvSimulaciones.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "RNDRep1" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "RND1");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "RNDRep2" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "RND2");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoReparacion" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Tiempo reparacion");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "finReparacion" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Proximo fin reparacion");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;
                dgvSimulaciones.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "seVaAOtraZona" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Se va a otra zona");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "cola" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Cola");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "estado" + i.ToString();
                dgvSimulaciones.Columns.Add(pos, "Estado");
                dgvSimulaciones.Columns[pos].HeaderCell.Style.BackColor = color;
            }

        }

        /*
        public void cargarLinea(List<dynamic[]> vector)
        {
            
            dynamic[] linea = new dynamic[20];
            
            int pos = 0;
            for (int m = 0; m < vector.Count(); m++)
            {
                for (int n = 0; n < vector[m].Length; n++)
                {
                    linea[pos] = vector[m][n];
                    pos++;
               
                }
            }

            dgvPrueba.Rows.Add(linea);
        }*/

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
            dgvSimulaciones.Rows.Clear();
            controlador.simular();
            p = new Paginador(controlador.getSimulaciones(), 10);
            p.obtenerPaginaActual(controlador.getSimulaciones(), dgvSimulaciones);
            txtCamiones.Text = controlador.contadorCamiones.ToString();
            txtMedia.Text = controlador.zonas[0].getMediaLlegadas().ToString();
            lblPagina.Text = "Página 1 de " + p.getCantPaginas(); 
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
    }
}
