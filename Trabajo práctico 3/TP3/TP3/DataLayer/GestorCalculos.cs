using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.DataLayer
{
    public class GestorCalculos
    {
        private double A;
        private double B;
        private double lambda;
        private bool banderaMuller;
        private double media;
        public double varianza;
        private double desvEstandar; //raiz de la varianza
        private int k = 12;
        
        private int tamanioMuestra = 1000;
        private Distribucion dist;
        private Random r = new Random();
        private List<ValorGenerado> generacionValores;

        public int cantIntervalos = 10; //Pongo uno por defecto así grafica
        public List<double[]> intervalos;// matriz de intervalos
        public double[] frecuenciasObservadas;
        public double[] frecuenciasEsperadas;
        public double[] probEsperadas;
        public double[] probObservadas;
        public double[] acumProbEsperada;
        public double[] acumProbObservada;

        private double min;
        private double max;


        public void actualizarIntervalos(int cant)
        {
            //Inicializo los distintos contadores 

            this.cantIntervalos = (dist.getDistribucionElegida() != "Poisson") ? cant : int.Parse(max.ToString()) - int.Parse(min.ToString());
            intervalos = new List<double[]>();

            frecuenciasObservadas = new double[cantIntervalos];
            frecuenciasEsperadas = new double[cantIntervalos];

            probObservadas = new double[cantIntervalos];
            probEsperadas = new double[cantIntervalos];

            acumProbEsperada = new double[cantIntervalos];
            acumProbObservada = new double[cantIntervalos];


            calcularLimitesIntervalos();
            obtenerFrecuenciasEsperadas();
            obtenerFrecuenciasObservadas();
        }


        public void calcularLimitesIntervalos()
        {
            if (this.dist.getDistribucionElegida() != "Poisson")
            {
                double ancho = (max - min) / cantIntervalos; //calculo el ancho de cada intervalo

                //Primer intervalo
                double[] primero = { min, min + ancho };
                intervalos.Add(primero);

                //calculo rangos
                for (int i = 1; i < cantIntervalos; i++)
                {
                    double inferior = intervalos.ElementAt(i - 1)[1];
                    double superior = (inferior + ancho);
                    double[] filaIntervalo = { inferior, superior };

                    intervalos.Add(filaIntervalo);
                }
            }
            else
            {
                double[] primero = { min, min + 1 };
                intervalos.Add(primero);
                for (int i = 1; i < cantIntervalos; i++)
                {
                    double inferior = intervalos.ElementAt(i - 1)[1];
                    double superior = (inferior + 1);
                    double[] filaIntervalo = { inferior, superior };
                    intervalos.Add(filaIntervalo);
                }
            }
            //Calcula limite superior e inferior para cada intervalo segun el ancho
            

        }

        public void obtenerFrecuenciasEsperadas()
        {
            //obtengo las frecuencias esperadas

            switch (dist.getDistribucionElegida())
            {
                case "Uniforme":
                    //calculo esperados
                    dist.obtenerEsperadosUniforme(this);
                    break;

                case "Exponencial":
                    dist.obtenerEsperadosExponencial(this);
                    break;

                case "Poisson":
                    //calculo esperados
                    dist.obtenerEsperadosPoisson(this);
                    break;

                case "Normal":
                    dist.obtenerEsperadosNormal(this);
                    break;
            }


        }

        public void obtenerFrecuenciasObservadas()
        {
            //calculo frecuencias observadas
            for (int i = 0; i < tamanioMuestra; i++)
            {
                for (int j = 0; j < cantIntervalos; j++)
                {
                    //creo que acá podria comparar solo si es menor al limite superior
                    if (generacionValores[i].getValorGenerado() >= intervalos[j][0] && generacionValores[i].getValorGenerado() < intervalos[j][1])
                    {
                        frecuenciasObservadas[j]++;

                    }
                }
            }

            //calculo probabilidades de Obs
            for (int i = 0; i < cantIntervalos; i++)
            {
                probObservadas[i] = frecuenciasObservadas[i] / tamanioMuestra;

            }
            //probabilidades acumuladas
            acumProbObservada[0] = probObservadas[0];
            for (int i = 1; i < cantIntervalos; i++)
            {
                acumProbObservada[i] = acumProbObservada[i - 1] + probObservadas[i];

            }
        }

        public void obtenerMuestras()
        {
            min = Double.MaxValue;
            max = Double.MinValue;

            generacionValores = new List<ValorGenerado>();
            //generacionValores.Add(new ValorGenerado(0, 0, 0));

            switch (dist.getDistribucionElegida())
            {
                case "Uniforme":
                    //calculo muestras y frecuencias
                    for (int i = 1; i <= tamanioMuestra; i++)
                    {
                        double numero = r.NextDouble();
                        double numeroGeneradoUniforme = dist.generarNumeroUniforme(numero, A, B);
                        generacionValores.Add(new ValorGenerado(i, numero, numeroGeneradoUniforme));
                        
                        //Actualizo maximos y minimos
                        if (numeroGeneradoUniforme < min) { min = numeroGeneradoUniforme; }
                        if (numeroGeneradoUniforme > max) { max = numeroGeneradoUniforme; }
                    }

                    break;
                case "Exponencial":
                    //calculo muestras y frecuencias
                    for (int i = 1; i <= tamanioMuestra; i++)
                    {
                        double numero = r.NextDouble();
                        double numeroGeneradoExponencial = dist.generarNumeroExponencial(numero, lambda);
                        generacionValores.Add(new ValorGenerado(i, numero, numeroGeneradoExponencial));

                        //Actualizo maximos y minimos
                        if (numeroGeneradoExponencial < min) { min = numeroGeneradoExponencial; }
                        if (numeroGeneradoExponencial > max) { max = numeroGeneradoExponencial; }
                    }

                    break;
                case "Poisson":
                    //calculo muestras y frecuencias
                    for (int i = 1; i <= tamanioMuestra; i++)
                    {
                        double numeroGeneradoPoisson = dist.generarNumeroPoisson(r, lambda);
                        generacionValores.Add(new ValorGenerado(i, -1, numeroGeneradoPoisson));

                        //Actualizo maximos y minimos
                        if (numeroGeneradoPoisson < min) { min = numeroGeneradoPoisson; }
                        if (numeroGeneradoPoisson > max) { max = numeroGeneradoPoisson; }
                    }

                    break;
                case "Normal":
                    if (banderaMuller)
                    {
                        //calculo muestras y frecuencias 
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
                            double numeroGeneradoNormal = dist.generarNumeroNormalConvolucion(r, k, media, desvEstandar);
                            generacionValores.Add(new ValorGenerado(i, -1, numeroGeneradoNormal));

                            //Actualizo maximos y minimos
                            if (numeroGeneradoNormal < min) { min = numeroGeneradoNormal; }
                            if (numeroGeneradoNormal > max) { max = numeroGeneradoNormal; }

                        }
                    }
                    break;
            }

            actualizarIntervalos(cantIntervalos);

        }

        // SETTERS GETTERS ################################################################

        public void setTamanioMuestra(int n)
        {
            this.tamanioMuestra = n;
        }

        public int getTamanioMuestra()
        {
            return this.tamanioMuestra;
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

        public double getLambda()
        {
            return this.lambda;
        }

        public void setBanderaMuller(bool estado)
        {
            this.banderaMuller = estado;
        }

        public void setMedia(double med)
        {
            this.media = med;
        }

        public double getMedia()
        {
            return this.media;
        }

        public void setDesviacion(double des)
        {
            this.desvEstandar = des;
        }

        public double getDesviacion()
        {
            return this.desvEstandar;
        }

        public void setK(int k)
        {
            this.k = k;
        }

        public void setDistribucion(Distribucion dist)
        {
            this.dist = dist;
        }


        public int getCantidadIntervalos()
        {
            return this.cantIntervalos;
        }

    }
}
