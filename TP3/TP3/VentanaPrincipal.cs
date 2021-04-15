using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class VentanaPrincipal : Form
    {
        Gestor gestor;
        public VentanaPrincipal()
        {
            InitializeComponent();
            //inicializo el Gestor
            this.gestor = new Gestor();
        }

    }
}
