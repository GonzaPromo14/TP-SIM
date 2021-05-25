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
        public Form1()
        {
            InitializeComponent();
            controlador = new ControladorSimulacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.simular(2,0,4);
        }
    }
}
