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

namespace TP3.GUILayer
{
    public partial class Form2 : Form
    {
        GestorGraficos graficador;
        public Form2(GestorGraficos g)
        {
            InitializeComponent();

            this.graficador = g;

            graficador.llenarGrillaFrecuencias(dataGridFrecuencias);

        }


    }
}
