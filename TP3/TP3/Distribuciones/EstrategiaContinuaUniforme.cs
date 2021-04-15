using System;
using System.Collections.Generic;
using System.Text;

namespace TP3.Distribuciones
{
    class EstrategiaContinuaUniforme
    {
        Random rnd;

        //Calcula frecuencias y probabilidades esperadas y las carga en el gestor
        public void obtenerEsperados(Gestor g)
        {
            for (int i = 0; i < g.intervalos.Count; i++)
            {
                g.frecuenciasEsperadas[i] = g.n / g.intervalos.Count;

                //g.frecuenciasEsperadas[i] = ContinuousUniform.CDF()
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

            double x = g.a + rnd.NextDouble() * (g.b - g.a);
            return x;

        }

        public EstrategiaContinuaUniforme()
        {
            rnd = new Random();
        }
    }
}
