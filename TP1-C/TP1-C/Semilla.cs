using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C
{
    class Semilla
    {
        private double valorSemilla;
        private int iteracion;
        private double c;
        private double a;
        private double m;


        public Semilla(double x0, double c, double a, double m)
        {
            this.valorSemilla = x0;
            this.iteracion = 0;
            this.c = c;
            this.a = a;
            this.m = m;
        }

        public double getValorSemilla()
        {
            return this.valorSemilla;
        }

        public void setValorSemilla(double nuevaSemilla)
        {
            this.valorSemilla = nuevaSemilla;
        }

        public int getIteracion()
        {
            return this.iteracion;
        }

        public void sumarIteracion()
        {
            this.iteracion += 1;
        }

        public double getA()
        {
            return this.a;
        }

        public double getC()
        {
            return this.c;
        }

        public double getM()
        {
            return this.m;
        }


    }
}
