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
    public partial class FormVariables : Form
    {
        ControladorSimulacion controlador;
        public FormVariables(ControladorSimulacion controlador)
        {
            InitializeComponent();

            this.controlador = controlador;

            txtMediaLlegada1.Text = controlador.mediaLlegada1.ToString();
            txtMediaLlegada2.Text = controlador.mediaLlegada2.ToString();
            txtMediaLlegada3.Text = controlador.mediaLlegada3.ToString();
            txtMediaLlegada4.Text = controlador.mediaLlegada4.ToString();
            txtMediaLlegada5.Text = controlador.mediaLlegada5.ToString();
            txtMediaLlegada6.Text = controlador.mediaLlegada6.ToString();
            txtMediaLlegada7.Text = controlador.mediaLlegada7.ToString();
            txtMediaLlegada8.Text = controlador.mediaLlegada8.ToString();
            
            txtMediaServicio1.Text = controlador.mediaServicio1.ToString();
            txtMediaServicio2.Text = controlador.mediaServicio2.ToString();
            txtMediaServicio3.Text = controlador.mediaServicio3.ToString();
            txtMediaServicio4.Text = controlador.mediaServicio4.ToString();
            txtMediaServicio5.Text = controlador.mediaServicio5.ToString();
            txtMediaServicio6.Text = controlador.mediaServicio6.ToString();
            txtMediaServicio7.Text = controlador.mediaServicio7.ToString();
            txtMediaServicio8.Text = controlador.mediaServicio8.ToString();

            txtDesvServicio1.Text = controlador.desvServicio1.ToString();
            txtDesvServicio2.Text = controlador.desvServicio2.ToString();
            txtDesvServicio3.Text = controlador.desvServicio3.ToString();
            txtDesvServicio4.Text = controlador.desvServicio4.ToString();
            txtDesvServicio5.Text = controlador.desvServicio5.ToString();
            txtDesvServicio6.Text = controlador.desvServicio6.ToString();
            txtDesvServicio7.Text = controlador.desvServicio7.ToString();
            txtDesvServicio8.Text = controlador.desvServicio8.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //-----------------------------------------------------------
            controlador.mediaLlegada1 = Double.Parse(txtMediaLlegada1.Text);
            controlador.mediaLlegada2 = Double.Parse(txtMediaLlegada2.Text);
            controlador.mediaLlegada3 = Double.Parse(txtMediaLlegada3.Text);
            controlador.mediaLlegada4 = Double.Parse(txtMediaLlegada4.Text);
            controlador.mediaLlegada5 = Double.Parse(txtMediaLlegada5.Text);
            controlador.mediaLlegada6 = Double.Parse(txtMediaLlegada6.Text);
            controlador.mediaLlegada7 = Double.Parse(txtMediaLlegada7.Text);
            controlador.mediaLlegada8 = Double.Parse(txtMediaLlegada8.Text);

            controlador.mediaServicio1 = Double.Parse(txtMediaServicio1.Text);
            controlador.mediaServicio2 = Double.Parse(txtMediaServicio2.Text);
            controlador.mediaServicio3 = Double.Parse(txtMediaServicio3.Text);
            controlador.mediaServicio4 = Double.Parse(txtMediaServicio4.Text);
            controlador.mediaServicio5 = Double.Parse(txtMediaServicio5.Text);
            controlador.mediaServicio6 = Double.Parse(txtMediaServicio6.Text);
            controlador.mediaServicio7 = Double.Parse(txtMediaServicio7.Text);
            controlador.mediaServicio8 = Double.Parse(txtMediaServicio8.Text);

            controlador.desvServicio1 = Double.Parse(txtDesvServicio1.Text);
            controlador.desvServicio2 = Double.Parse(txtDesvServicio2.Text);
            controlador.desvServicio3 = Double.Parse(txtDesvServicio3.Text);
            controlador.desvServicio4 = Double.Parse(txtDesvServicio4.Text);
            controlador.desvServicio5 = Double.Parse(txtDesvServicio5.Text);
            controlador.desvServicio6 = Double.Parse(txtDesvServicio6.Text);
            controlador.desvServicio7 = Double.Parse(txtDesvServicio7.Text);
            controlador.desvServicio8 = Double.Parse(txtDesvServicio8.Text);

            this.Close();


        }
    }
}
