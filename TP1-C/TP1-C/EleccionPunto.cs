﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_C
{
    public partial class frmEleccionPunto : Form
    {
        public frmEleccionPunto()
        {
            InitializeComponent();
        }

        private void btnNumerosAleatorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }
    }
}
