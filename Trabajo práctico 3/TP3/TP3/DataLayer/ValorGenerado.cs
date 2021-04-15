using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.DataLayer
{
    class ValorGenerado
    {
        private int muestra;
        private double rnd;
        private double valorGenerado;

        public ValorGenerado(int muestra, double rnd, double valorGenerado)
        {
            this.muestra = muestra;
            this.rnd = rnd;
            this.valorGenerado = valorGenerado;
        }


        public string[] convertirStringData()
        {
            String rnd = this.rnd == -1 ? "-" : this.rnd.ToString();
            return new string[] {this.muestra.ToString(), rnd, this.valorGenerado.ToString()};
        }
        
    }
}
