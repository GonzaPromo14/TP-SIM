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
        ControladorSimulacion controlador;
        public FormCamiones(ControladorSimulacion controlador)
        {
            InitializeComponent();
            this.controlador = controlador;

            dataGridView1.Columns[4].Width = 200;
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

                string[] fila = { camion.nombre, camion.hora_llegada.ToString(), salida, espera, camion.zonasPasadas };
                dataGridView1.Rows.Add(fila);
            }
        }
    }
}
