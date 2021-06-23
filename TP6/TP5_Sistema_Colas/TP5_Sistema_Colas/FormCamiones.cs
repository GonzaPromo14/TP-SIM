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
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas
{
    public partial class FormCamiones : Form
    {
        Paginador pag;
        ControladorSimulacion controlador;
        List<dynamic[]> camionesLista = new List<dynamic[]>();
        public FormCamiones(ControladorSimulacion controlador)
        {
            InitializeComponent();
            this.controlador = controlador;

            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[5].Width = 200;
            
            cargarGrilla();
        }

        public void cargarGrilla()
        {
            foreach(Camion camion in controlador.camiones)
            {
                string espera;
                string salida;

                if (camion.tiempo_espera == 0)
                {
                    espera = "-";
                }
                else espera = camion.tiempo_espera.ToString();

                if (camion.hora_salida == 0)
                {
                    salida = "No salió";
                }
                else salida = camion.hora_salida.ToString();

                string[] fila = { camion.nombre, camion.estado,camion.hora_llegada.ToString(), salida, espera, camion.zonasPasadas };
                this.camionesLista.Add(fila.ToArray());
            }
            dataGridView1.Rows.Clear();
            pag = new Paginador(camionesLista, 10);
            pag.obtenerPaginaActual(camionesLista, dataGridView1);
            lblPaginaCamiones.Text = "Página 1 de " + pag.getCantPaginas();
            btnAnteriorPagina.Enabled = false;
            btnSiguientePagina.Enabled = (pag.getCantPaginas() > 1 && !pag.esUltimaPagina()) ? true : false;

        }

        private void FormCamiones_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguientePagina_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            pag.obtenerPaginaSiguiente(camionesLista, dataGridView1);
            lblPaginaCamiones.Text = "Página " + pag.getPaginaActual() + " de " + pag.getCantPaginas();
            btnAnteriorPagina.Enabled = pag.getCantPaginas() > 1 ? true : false;
            btnSiguientePagina.Enabled = (pag.getCantPaginas() > 1 && !pag.esUltimaPagina()) ? true : false;
        }

        private void btnAnteriorPagina_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            pag.obtenerPaginaAnterior(camionesLista, dataGridView1);
            lblPaginaCamiones.Text = "Página " + pag.getPaginaActual() + " de " + pag.getCantPaginas();
            btnSiguientePagina.Enabled = pag.getCantPaginas() > 1 ? true : false;
            btnAnteriorPagina.Enabled = (pag.getCantPaginas() > 1 && !pag.esPaginaPrimera()) ? true : false;
        }
    }
}
