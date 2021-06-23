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
    public partial class FormTablasRK : Form
    {
        ControladorSimulacion controla;
        public FormTablasRK(ControladorSimulacion controlador)
        {
            InitializeComponent();

            this.controla = controlador;
            for(int i = 0; i < controla.RKInestable.getSimulaciones().Count; i++)
            {
                dgvRKInestale.Rows.Add(controla.RKInestable.getSimulaciones().ElementAt(i));
            }

        }
    }
}
