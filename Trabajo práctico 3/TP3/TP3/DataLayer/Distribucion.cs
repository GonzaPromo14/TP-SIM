using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.DataLayer
{
    class Distribucion
    {
        private String distribucionElegida;
        private int tamanioMuestra;

        public Distribucion(String distribucionElegida, int tamanioMuestra)
        {
            this.distribucionElegida = distribucionElegida;
            this.tamanioMuestra = tamanioMuestra;
        }

        public String getDistribucionElegida()
        {
            return this.distribucionElegida;
        }

        public void setDistribucionElegida(String distribucionElegida)
        {
            this.distribucionElegida = distribucionElegida;
        }

        public int getTamanioMuestra()
        {
            return this.tamanioMuestra;
        }

        public void setTamanioMuestra(int tamanioMuestra)
        {
            this.tamanioMuestra = tamanioMuestra;
        }

        public double generarNumeroUniforme(double rnd, double A, double B)
        {
            double diferencia = B - A;
            double rnd_generado = A + (rnd * diferencia);
            return Math.Round(rnd_generado, 4);
        }

        public double generarNumeroExponencial(double rnd, double lamda)
        {
            double ln = Math.Log(1 - rnd);
            double division = -1 / lamda;
            return Math.Round(division * ln, 4);
        }

        public double generarNumeroPoisson(Random r, double lamda)
        {
            double p = 1;
            double x = -1;
            double a = Math.Pow(Math.E, lamda * -1);
            double u = 0;
            do
            {
                u = r.NextDouble();
                p = p * u;
                x = x + 1;
            } while (p >= a);
            return x;
        }

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
            return Math.Round((z * desv_estandar) + media, 4);
        }
    }

  
}
