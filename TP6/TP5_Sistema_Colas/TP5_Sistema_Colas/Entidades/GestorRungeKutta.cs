using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Sistema_Colas.Entidades
{
    class GestorRungeKutta
    {
        public List<dynamic[]> rk;
        public dynamic[] vectorActual;
        public dynamic[] vectorAnterior;
        public decimal h;
        public decimal alfa;
        public decimal eInicial;
        public decimal eFinal;
        public bool proximaPurga;


        public GestorRungeKutta(decimal h, decimal alfa, decimal eInicial, decimal eFinal, bool proximaPurga)
        {
            vectorActual = new dynamic[8];
            vectorAnterior = new dynamic[8];
            rk = new List<dynamic[]>();
            this.h = h;
            this.alfa = alfa;
            this.eInicial = eInicial;
            this.eFinal = eFinal;
            this.proximaPurga = proximaPurga;
        }
        
        public void cargaRK()
        {
            this.cargaInicial();
            int iteracion = 0;
            while ((decimal)vectorAnterior[Constantes.eProx] < this.eFinal)
            {
                iteracion++;
                decimal yn = (decimal)vectorAnterior[Constantes.eProx];
                decimal k1 = this.proximaPurga ? Distribuciones.calculoProximaPurga(this.alfa, yn) : Distribuciones.calculoFinPurga(this.alfa, yn);
                decimal k2 = this.proximaPurga ? Distribuciones.calculoProximaPurga(this.alfa, yn + ((this.h / 2)*k1)) : Distribuciones.calculoFinPurga(this.alfa, yn + ((this.h / 2) * k1));
                decimal k3 = this.proximaPurga ? Distribuciones.calculoProximaPurga(this.alfa, yn + ((this.h / 2) * k2)) : Distribuciones.calculoFinPurga(this.alfa, yn + ((this.h / 2) * k2));
                decimal k4 = this.proximaPurga ? Distribuciones.calculoProximaPurga(this.alfa, (yn+(this.h * k3))) : Distribuciones.calculoFinPurga(this.alfa, (yn + (this.h * k3)));
                vectorActual[Constantes.tInicial] = vectorAnterior[Constantes.tProx];
                vectorActual[Constantes.eInicial] = yn;
                vectorActual[Constantes.k1] = k1;
                vectorActual[Constantes.k2] = k2;
                vectorActual[Constantes.k3] = k3;
                vectorActual[Constantes.k4] = k4;
                decimal tprox = vectorAnterior[Constantes.tProx] + this.h;
                vectorActual[Constantes.tProx] = tprox;
                vectorActual[Constantes.eProx] = yn + ((h / 6) * (k1 + (2 * k2) + (2 * k3) + k4));
                this.rk.Add(vectorActual.ToArray());
                vectorAnterior = vectorActual;
            }

        }

        public void cargaInicial()
        {
            vectorAnterior[Constantes.tInicial] = "";
            vectorAnterior[Constantes.eInicial] = "";
            vectorAnterior[Constantes.k1] = "";
            vectorAnterior[Constantes.k2] = "";
            vectorAnterior[Constantes.k3] = "";
            vectorAnterior[Constantes.k4] = "";
            vectorAnterior[Constantes.tProx] = (decimal)0;
            vectorAnterior[Constantes.eProx] = (decimal)this.eInicial;
            this.rk.Add(vectorAnterior.ToArray());
        }


        public List<dynamic[]> getRk()
        {
            return this.rk;
        }

        public decimal lastTf()
        {
            return this.vectorActual[Constantes.tInicial];
        }


    }
}
