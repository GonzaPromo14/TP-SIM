using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C
{
    class Metodo
    {
        private bool lineal;
        private bool hayElegido;

        public Metodo()
        {
            this.hayElegido = true;
        }

        public bool hayMetodoElegido()
        {
            return this.hayElegido;
        }

        public bool isLineal()
        {
            return this.lineal;
        }

        public void setLineal(bool lineal)
        {
            this.hayElegido = true;
            this.lineal = lineal;
        }

    }



}
