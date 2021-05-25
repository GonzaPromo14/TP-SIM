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
        public DataTable datos;
        public Form1()
        {
            InitializeComponent();
            controlador = new ControladorSimulacion(this);

            cargarColumnas();
        }

        public void cargarColumnas()
        {
            //Para que no se muevan las dos primeras
            dgvPrueba.Columns[0].Frozen = true;
            dgvPrueba.Columns[0].Width = 200;
            dgvPrueba.Columns[1].Frozen = true;
            dgvPrueba.Columns[1].DefaultCellStyle.BackColor = Color.LightBlue;

            Color color;
            string pos;
            for (int i= 0; i < 2; i++)
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
                dgvPrueba.Columns.Add(pos, "RND Llegada");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoLlegada" + i.ToString();
                dgvPrueba.Columns.Add(pos, "Tiempo Llegada");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "proximaLlegada" + i.ToString();
                dgvPrueba.Columns.Add(pos, "Proxima llegada");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;
                dgvPrueba.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "RNDRep1" + i.ToString();
                dgvPrueba.Columns.Add(pos, "RND1");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "RNDRep2" + i.ToString();
                dgvPrueba.Columns.Add(pos, "RND2");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoReparacion" + i.ToString();
                dgvPrueba.Columns.Add(pos, "Tiempo reparacion");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "finReparacion" + i.ToString();
                dgvPrueba.Columns.Add(pos, "Proximo fin reparacion");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;
                dgvPrueba.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "cola" + i.ToString();
                dgvPrueba.Columns.Add(pos, "Cola");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "estado" + i.ToString();
                dgvPrueba.Columns.Add(pos, "Estado");
                dgvPrueba.Columns[pos].HeaderCell.Style.BackColor = color;


            }
        }

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPrueba.Rows.Clear();
            controlador.simular();
        }
    }
}
