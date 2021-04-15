using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TP3.Distribuciones
{
    class EstrategiaContinuaNormal
    {
        Random rnd;

        //Calcula frecuencias y probabilidades esperadas y las carga en el gestor
        public void obtenerEsperados(Gestor g)
        {
            for (int i = 0; i < g.intervalos.Count; i++)
            {
                g.frecuenciasEsperadas[i] = (Normal.CDF(g.media, g.desviacion, g.intervalos[i][1]) - Normal.CDF(g.media, g.desviacion, g.intervalos[i][0])) * (g.n);
            }

            //actualizo las probabilidades
            for (int i = 0; i < g.intervalos.Count; i++)
            {
                g.probEsperadas[i] = g.frecuenciasEsperadas[i] / g.n;
            }
            //actualizo acumuladores
            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                g.acumProbEsperada[i] = g.acumProbEsperada[i - 1] + g.probEsperadas[i];

            }

        }

        public double generarValor(Gestor g)
        {
            double r1 = rnd.NextDouble();
            double r2 = rnd.NextDouble();

            double z = Math.Sqrt(-2 * Math.Log(1 - r1)) * Math.Cos(2 * Math.PI * r2);

            double x = g.u + z * g.sigma;

            return x;
        }

        public EstrategiaContinuaNormal()
        {
            rnd = new Random();
        }
    }
}
