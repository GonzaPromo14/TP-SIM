using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.DataLayer
{
    public class Distribucion
    {
        private String distribucionElegida;

        public Distribucion(String distribucionElegida)
        {
            this.distribucionElegida = distribucionElegida;
        }

        public String getDistribucionElegida()
        {
            return this.distribucionElegida;
        }

        public void setDistribucionElegida(String distribucionElegida)
        {
            this.distribucionElegida = distribucionElegida;
        }



        //UNIFORME #####################################################################################################

        public double generarNumeroUniforme(double rnd, double A, double B)
        {
            double diferencia = B - A;
            double rnd_generado = A + (rnd * diferencia);
            return rnd_generado;
        }

        public void obtenerEsperadosUniforme(GestorCalculos g)
        {
            for (int i = 0; i < g.cantIntervalos; i++)
            {
                g.frecuenciasEsperadas[i] = g.getTamanioMuestra() / g.cantIntervalos;
                g.probEsperadas[i] = g.frecuenciasEsperadas[i] / g.getTamanioMuestra();

            }

            //actualizo acumuladores
            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                g.acumProbEsperada[i] = g.acumProbEsperada[i - 1] + g.probEsperadas[i];

            }


        }
        //EXPONENCIAL ##################################################################################################
        public double generarNumeroExponencial(double rnd, double lambda)
        {
            double ln = Math.Log(1 - rnd);
            double division = -1 / lambda;
            return division * ln;
        }


        public void obtenerEsperadosExponencial(GestorCalculos g)
        {

            for (int i = 0; i < g.cantIntervalos; i++)
            {

                double probabilidad = (Exponential.CDF(g.getLambda(), g.intervalos[i][1]) - Exponential.CDF(g.getLambda(), g.intervalos[i][0]));
                g.probEsperadas[i] = probabilidad;
                g.frecuenciasEsperadas[i] = probabilidad * g.getTamanioMuestra();



            }

            //actualizo acumuladores

            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                g.acumProbEsperada[i] = g.acumProbEsperada[i - 1] + g.probEsperadas[i];

            }
        }

        //POISSON ######################################################################################################
        public double generarNumeroPoisson(Random r, double lambda)
        {
            
            double p = 1;
            double x = -1;
            double a = Math.Exp(-lambda);
            double u = 0;
            do
            {
                u = r.NextDouble();
                p = p * u;
                x = x + 1;
            } while (p >= a);
            return x;

        }


        public void obtenerEsperadosPoisson(GestorCalculos g)
        {
            for (int i = 0; i < g.cantIntervalos; i++)
            {
                //g.frecuenciasEsperadas[i] = (Poisson.CDF(g.lambda, g.intervalos[i][1]) - Poisson.CDF(g.lambda, g.intervalos[i][0])) * g.n;
                g.frecuenciasEsperadas[i] = ((Math.Pow(g.getLambda(), i) * Math.Pow(Math.E, -g.getLambda())) / SpecialFunctions.Factorial(i)) * g.getTamanioMuestra();
            }

            //actualizo las probabilidades
            for (int i = 0; i < g.cantIntervalos; i++)
            {
                g.probEsperadas[i] = Poisson.PMF(g.getLambda(), i);
            }
            //actualizo acumuladores
            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                g.acumProbEsperada[i] = Poisson.CDF(g.getLambda(), i);
            }
        }

        //NORMAL ######################################################################################################
        public double[] generarNumeroNormalBoxMuller(double r1, double r2, double media, double desv_estandar)
        {
            double calculo_raiz = Math.Sqrt((-2 * Math.Log(r1)));
            double calculo_2 = 2 * Math.PI * r2;
            double n1 = (((calculo_raiz) * Math.Cos(calculo_2)) * desv_estandar) + media;
            double n2 = (((calculo_raiz) * Math.Sin(calculo_2)) * desv_estandar) + media;
            return new double[] { n1, n2};
        }

        public double generarNumeroNormalConvolucion(Random r, int k, double media, double desv_estandar)
        {
            double sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum = sum + r.NextDouble();
            }

            double z = (sum - k/2) / (Math.Sqrt(k / 12));
            return (z * desv_estandar) + media;
        }

        public void obtenerEsperadosNormal(GestorCalculos g)
        {
            for (int i = 0; i < g.cantIntervalos; i++)
            {
                double probabilidad = (Normal.CDF(g.getMedia(), g.getDesviacion(), g.intervalos[i][1]) - Normal.CDF(g.getMedia(), g.getDesviacion(), g.intervalos[i][0]));
                g.probEsperadas[i] = probabilidad;
                g.frecuenciasEsperadas[i] =  probabilidad* (g.getTamanioMuestra());
            }

            //actualizo acumuladores
            g.acumProbEsperada[0] = g.probEsperadas[0];
            for (int i = 1; i < g.cantIntervalos; i++)
            {
                g.acumProbEsperada[i] = g.acumProbEsperada[i - 1] + g.probEsperadas[i];

            }

        }
    }

  
}
