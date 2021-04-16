using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.DataLayer
{
    class GestorCalculos
    {
        private double A;
        private double B;
        private double lambda;
        private bool banderaMuller;
        private double media;
        public double varianza;
        private double desvEstandar; //raiz de la varianza
        private int k;
        
        private int tamanioMuestra = 10;
        private Distribucion dist;
        private Random r = new Random();
        private List<ValorGenerado> generacionValores;
        
        public void obtenerMuestras()
        {
            generacionValores = new List<ValorGenerado>();
            generacionValores.Add(new ValorGenerado(0, 0, 0));// para que ande lo de varianza y media

            switch (dist.getDistribucionElegida())
            {
                case "Uniforme":
                    for (int i = 1; i <= tamanioMuestra; i++)
                    {
                        double numero = Math.Round(r.NextDouble(), 4);
                        double numeroGeneradoUniforme = dist.generarNumeroUniforme(numero, A, B);
                        generacionValores.Add(new ValorGenerado(i, numero, numeroGeneradoUniforme));
                        

                    }
                    break;
                case "Exponencial":
                    for (int i = 1; i <= tamanioMuestra; i++)
                    {
                        double numero = Math.Round(r.NextDouble(), 4);
                        double numeroGeneradoExponencial = dist.generarNumeroExponencial(numero, lambda);
                        generacionValores.Add(new ValorGenerado(i, numero, numeroGeneradoExponencial));


                    }
                    break;
                case "Poisson":
                    for (int i = 1; i <= tamanioMuestra; i++)
                    {
                        generacionValores.Add(new ValorGenerado(i, -1, dist.generarNumeroPoisson(r, lambda)));


                    }
                    break;
                case "Normal":
                    if (banderaMuller)
                    {
                        int tam = tamanioMuestra % 2 == 0 ? tamanioMuestra : tamanioMuestra + 1;
                        for (int i = 1; i <= tam; i = i + 2)
                        {
                            double valorGenerado1 = r.NextDouble();
                            double valorGenerado2 = r.NextDouble();
                            double[] valoresGenerados = dist.generarNumeroNormalBoxMuller(valorGenerado1, valorGenerado2, media, desvEstandar);
                            generacionValores.Add(new ValorGenerado(i, valorGenerado1, valoresGenerados[0]));
                            generacionValores.Add(new ValorGenerado(i + 1, valorGenerado2, valoresGenerados[1]));


                        }
                    }
                    else
                    {
                        for (int i = 1; i <= tamanioMuestra; i++)
                        {
                            generacionValores.Add(new ValorGenerado(i, -1, dist.generarNumeroNormalConvolucion(r, k, media, desvEstandar)));

                        }
                    }

                    break;
            }

            //actualizo la desviacion estandar
            //this.desvEstandar = Math.Sqrt(varianza);

        }

        //calcula la media fila por fila
        public void actualizarMedia(int i)
        {
            double mediaAnterior = this.media;

            double mediaNueva = (1 / i) * ((i - 1) * mediaAnterior + generacionValores[i].getValorGenerado());

            this.media = mediaNueva;
        }

        //calcula varianza fila por fila
        public void actualizarVarianza(int i)
        {
            //tiene que ser al menos n=2
            if(i == 1)
            {
                return;
            }
                        
            double varianzaAnterior = this.varianza;

            double aux1 = (i - 2) * varianzaAnterior;
            double aux2 = (i / (i - 1)) * Math.Pow((this.media - generacionValores[i].getValorGenerado()), 2);

            double varianzaNueva = (1 / (i - 1)) * (aux1 + aux2);

            this.varianza = varianzaNueva;

        }

        // SETTERS GETTERS ################################################################

        public void setTamanioMuestra(int n)
        {
            this.tamanioMuestra = n;
        }

        public List<ValorGenerado> getValoresGenerados()
        {
            return this.generacionValores;
        }

        public void setA(double a)
        {
            this.A = a;
        }

        public void setB(double b)
        {
            this.B = b;
        }

        public void setLambda(double lam)
        {
            this.lambda = lam;
        }

        public void setBanderaMuller(bool estado)
        {
            this.banderaMuller = estado;
        }

        public void setMedia(double med)
        {
            this.media = med;
        }

        public void setDesviacion(double des)
        {
            this.desvEstandar = des;
        }

        public void setK(int k)
        {
            this.k = k;
        }

        public void setDistribucion(Distribucion dist)
        {
            this.dist = dist;
        }
    }
}
