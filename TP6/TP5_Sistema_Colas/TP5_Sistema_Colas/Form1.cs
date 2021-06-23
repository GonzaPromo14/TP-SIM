﻿using System;
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
        FormVariables formVariables;

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
            //Para que no se muevan las primeras
            dgv.Columns[0].Frozen = true;
            dgv.Columns[1].Width = 200;
            dgv.Columns[1].Frozen = true;
            dgv.Columns[2].DefaultCellStyle.BackColor = Color.LightBlue;
            dgv.Columns[2].Frozen = true;
            dgv.Columns[3].Frozen = true;
            dgv.Columns[4].Frozen = true;
            //dgv.Columns[5].Frozen = true;






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
                dgv.Columns.Add(pos, "Proxima llegada Z"+(i+1).ToString());
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
                dgv.Columns.Add(pos, "Proximo fin reparacion Z"+(i+1).ToString());
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;
                dgv.Columns[pos].DefaultCellStyle.BackColor = Color.Yellow;

                pos = "seVaAOtraZona" + i.ToString();
                dgv.Columns.Add(pos, "Se va a otra zona");
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "cola" + i.ToString();
                dgv.Columns.Add(pos, "Cola Z"+(i+1).ToString());
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "estado" + i.ToString();
                dgv.Columns.Add(pos, "Estado Z"+(i + 1).ToString());
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;

                pos = "tiempoTrabajado" + i.ToString();
                dgv.Columns.Add(pos, "Tiempo Trabajado en Zona " + (i + 1).ToString());
                dgv.Columns[pos].HeaderCell.Style.BackColor = color;
                dgv.Columns[pos].DefaultCellStyle.BackColor = Color.LightBlue;
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
            lblPorcInsInadeciadas.Text = controlador.obtenerPorcDeSimulacionParaInsInadecuadas().ToString() + "%";

            lblPagina.Text = "Página 1 de " + p.getCantPaginas();
            dgvFinal.Rows.Clear();
            dgvFinal.Rows.Add(controlador.getUltimaSimulacion());

        

            lblSemana.Text = (controlador.tiempoDeAumentar / 168 < 1 && controlador.tiempoDeAumentar !=0) ? "Antes de la primer semana" : ((int)controlador.tiempoDeAumentar / 168).ToString();



            if (dgvFinal.Rows[0].Cells[3].Value == "NO") dgvFinal.Rows[0].Cells[3].Style.BackColor = Color.LightGreen;
            if (dgvFinal.Rows[0].Cells[3].Value == "SI") dgvFinal.Rows[0].Cells[3].Style.BackColor = Color.LightCoral;

            if (txtExceso.Text == "-") txtExceso.Text = "No se superó la capacidad máxima";
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = (p.getCantPaginas() > 1 && !p.esUltimaPagina()) ? true : false;
            if (txtDesde.Text == "") txtDesde.Text = "0";
            if (txtHasta.Text == "") txtHasta.Text = "500";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Columns[0].Visible = false;
            dgvFinal.Columns[0].Visible = false;

            for(int i =0; i < 8; i++)
            {
                dgvSimulaciones.Columns[Constantes.colTiempoLlegada + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvSimulaciones.Columns[Constantes.colTiempoReparacion + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvSimulaciones.Columns[Constantes.colRNDLlegada + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvSimulaciones.Columns[Constantes.colRND1Reparacion + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvSimulaciones.Columns[Constantes.colRND2Reparacion + i * Constantes.cantidadColumnasZona].Visible = false;


                dgvFinal.Columns[Constantes.colTiempoLlegada + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvFinal.Columns[Constantes.colTiempoReparacion + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvFinal.Columns[Constantes.colRNDLlegada + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvFinal.Columns[Constantes.colRND1Reparacion + i * Constantes.cantidadColumnasZona].Visible = false;
                dgvFinal.Columns[Constantes.colRND2Reparacion + i * Constantes.cantidadColumnasZona].Visible = false;

            }



        }

        private void btnMostrarRnd_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Columns[0].Visible = true;
            dgvFinal.Columns[0].Visible = true;

            for (int i = 0; i < 8; i++)
            {
                dgvSimulaciones.Columns[Constantes.colTiempoLlegada + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvSimulaciones.Columns[Constantes.colTiempoReparacion + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvSimulaciones.Columns[Constantes.colRNDLlegada + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvSimulaciones.Columns[Constantes.colRND1Reparacion + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvSimulaciones.Columns[Constantes.colRND2Reparacion + i * Constantes.cantidadColumnasZona].Visible = true;

                dgvFinal.Columns[Constantes.colTiempoLlegada + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvFinal.Columns[Constantes.colTiempoReparacion + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvFinal.Columns[Constantes.colRNDLlegada + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvFinal.Columns[Constantes.colRND1Reparacion + i * Constantes.cantidadColumnasZona].Visible = true;
                dgvFinal.Columns[Constantes.colRND2Reparacion + i * Constantes.cantidadColumnasZona].Visible = true;

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Rows.Clear();
            p.obtenerPaginaAnterior(controlador.getSimulaciones(), dgvSimulaciones);
            lblPagina.Text = "Página " + p.getPaginaActual() + " de " + p.getCantPaginas();
            btnSiguiente.Enabled = p.getCantPaginas() > 1 ? true : false;
            btnAnterior.Enabled = (p.getCantPaginas() > 1 && !p.esPaginaPrimera()) ? true : false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Rows.Clear();
            p.obtenerPaginaSiguiente(controlador.getSimulaciones(), dgvSimulaciones);
            lblPagina.Text = "Página " + p.getPaginaActual() + " de " + p.getCantPaginas();
            btnAnterior.Enabled = p.getCantPaginas() > 1 ? true : false;
            btnSiguiente.Enabled = (p.getCantPaginas() > 1 && !p.esUltimaPagina()) ? true : false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3 = new FormZonas(controlador);
            form3.Show();
        }


        private void btnCamiones_Click_1(object sender, EventArgs e)
        {
            form2 = new FormCamiones(controlador);
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formVariables = new FormVariables(controlador);
            formVariables.Show();
        }
    }
}