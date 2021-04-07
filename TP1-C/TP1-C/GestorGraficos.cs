using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP1_C
{
    class GestorGraficos
    {

        private int cantidadMuestras;
        private SemillaArray muestras; //de acá saco los numeros aleatorios
        private int cantIntervalos;
        private List<double[]> intervalos;// matriz de intervalos
        private double[] frecuenciasObservadas;
        private double[] frecuenciasEsperadas;
        private double pasos;
        private double min;
        private double max;
        public string[] intervMedio;//es lo que aparece en el eje x

        //-------------------------------------------------------------------------------------


        public void calcularPasos()
        {
            //calculo el ancho de cada intervalo

            double aux = (max - min) / cantIntervalos;
            aux = Math.Truncate(aux * 10000) / 10000;
            this.setPasos(aux);
        }
        

        public void calcularIntervalos()
        {
            //Este método calcula los rangos de cada intervalo a partir de los pasos

            //Primer intervalo
            double[] primero = { Math.Truncate(min*10000)/10000, Math.Truncate(min*10000)/10000 };
            intervalos.Add(primero);

            //calculo rangos
            for (int i = 1; i < cantIntervalos; i++)
            {
                double minimo = Math.Truncate(intervalos.ElementAt(i - 1)[1]*10000)/10000;
                double maximo = Math.Truncate((minimo + pasos)*10000)/10000;
                double[] filaIntervalo = { minimo, maximo };

                intervalos.Add(filaIntervalo);
            }

        }

        public void calcularIntervalosGrafico()
        {
            /*
            for (int i = 0; i < cantIntervalos; i++)
            {
                intervMedio[i] = Convert.ToString(Math.Round((intervalos[i][0] + intervalos[i][1]) / 2, 3));
            }*/
            for(int i=0; i<cantIntervalos; i++)
            {
                intervMedio[i] = Convert.ToString(i+1);
            }
        }

        public void contarFrecuencias()
        {
            //inicializo los contadores de frecuencias
            frecuenciasObservadas = new double[cantIntervalos];
            frecuenciasEsperadas = new double[cantIntervalos];



            //Frecuencias observadas 
            for (int i = 0; i < cantidadMuestras; i++)
            {
                double rand = muestras.getRandom(i);
                //cuento los randoms que aparecen en cada intervalo
                for (int j = 0; j < cantIntervalos; j++)
                {
                    if (rand >= intervalos[j][0] && rand < intervalos[j][1])
                    {
                        frecuenciasObservadas[j]++;
                    }
                }
            }


            //Frecuencias esperadas
            for(int i=0; i < cantIntervalos; i++)
            {
                //depende de la distribucion, en este caso es uniforme siempre
                frecuenciasEsperadas[i] = cantidadMuestras / cantIntervalos;
            }

        }

        public void llenarGrillaFrecuencias(DataGridView grillaFrecuencias)
        {
            grillaFrecuencias.Rows.Clear();

            for(int i=0; i<cantIntervalos; i++)
            {
                int intervalo = i + 1;
                double li = intervalos[i][0];
                double ls = intervalos[i][1];
                double frecObservadas = frecuenciasObservadas[i];
                double frecEsperadas = frecuenciasEsperadas[i];

                grillaFrecuencias.Rows.Add(intervalo, li, ls, frecObservadas, frecEsperadas);

            }
        }

        //----------------------------GRAFICAR----------------------------------------------//

        public void graficarHistograma(Chart grafico)
        {
            grafico.Series.Clear();
            grafico.Series.Add("Observado");
            for (int i = 0; i < cantIntervalos; i++)
            {
                string x = intervMedio[i];
                grafico.Series["Observado"].Points.AddXY(x, frecuenciasObservadas[i]);
            }

        }

        public void graficarHistogramaEsperado(Chart grafico)
        {
            grafico.Series.Add("Esperado");
            for (int i = 0; i < cantIntervalos; i++)
            {
                grafico.Series["Esperado"].Points.Add(frecuenciasEsperadas[i]);
            }
        }

        public void graficar(Chart grafico)
        {
            this.contarFrecuencias();
            this.graficarHistograma(grafico);
            this.graficarHistogramaEsperado(grafico);

        }
        //---------------------------------------------------------------------------------//

        public GestorGraficos()
        {
            this.intervalos = new List<double[]>();
        }

        public void setMax(double max) {
            this.max = max;
        }

        public void setMin(double min) {
            this.min = min;
        }

        public void setPasos(double pasos)
        {
            this.pasos = pasos;
        }

        public void setCantIntervalos(int intervalos)
        {
            this.cantIntervalos = intervalos;
        }

        public void setCantidadMuestras(int cantidad)
        {
            this.cantidadMuestras = cantidad;
        }

        public void setMuestras(SemillaArray randoms)
        {
            this.muestras = randoms;
        }

        public void setIntervMedio()
        {
            this.intervMedio = new string[cantIntervalos];
        }
    }
}
