using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP3.DataLayer
{
    
    class GestorGraficos
    {
        GestorCalculos gestor;
        public string[] intervMedio;//es lo que aparece en el eje x

        //-------------------------------------------------------------------------------------

        public void calcularEjeX()
        {
            intervMedio = new string[gestor.cantIntervalos]; //para el grafico

            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                intervMedio[i] = "Intervalo "+(i+1);
            }
        }

        public void llenarGrillaFrecuencias(DataGridView grillaFrecuencias)
        {
            grillaFrecuencias.Rows.Clear();

            for (int i = 0; i < gestor.getCantidadIntervalos(); i++)
            {
                int intervalo = i + 1;
                double li = Truncador.Truncar(gestor.intervalos[i][0]);
                double ls = Truncador.Truncar(gestor.intervalos[i][1]);
                double frecObservadas = Truncador.Truncar(gestor.frecuenciasObservadas[i]);
                double probObservadas = Truncador.Truncar(gestor.probObservadas[i]);
                double acumObservadas = Truncador.Truncar(gestor.acumProbObservada[i]);
                
                double frecEsperadas = Truncador.Truncar(gestor.frecuenciasEsperadas[i]);
                double probEsperadas = Truncador.Truncar(gestor.probEsperadas[i]);
                double acumEsperadas = Truncador.Truncar(gestor.acumProbEsperada[i]);                

                grillaFrecuencias.Rows.Add(intervalo, li, ls, frecObservadas,probObservadas,acumObservadas, frecEsperadas, probEsperadas, acumEsperadas);

            }
        }

        //----------------------------GRAFICAR----------------------------------------------//

        public void graficarHistogramaObservado(Chart grafico)
        {
            grafico.Series.Clear();
            grafico.Series.Add("Observado");
            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                string x = intervMedio[i];
                grafico.Series["Observado"].Points.AddXY(x, gestor.frecuenciasObservadas[i]);
            }

        }

        public void graficarHistogramaEsperado(Chart grafico)
        {
            grafico.Series.Add("Esperado");
            for (int i = 0; i < gestor.cantIntervalos; i++)
            {
                grafico.Series["Esperado"].Points.Add(gestor.frecuenciasEsperadas[i]);
            }
        }

        public void graficar(Chart grafico, DataGridView grilla)
        {
            calcularEjeX();
            this.graficarHistogramaObservado(grafico);
            this.graficarHistogramaEsperado(grafico);
            llenarGrillaFrecuencias(grilla);

            //Magia de stackoverflow------------------------------
            double max = Double.MinValue;
            double min = Double.MaxValue;

            Chart tmpChart = (Chart)grafico;

            double leftLimit = tmpChart.ChartAreas[0].AxisX.Minimum;
            double rightLimit = tmpChart.ChartAreas[0].AxisX.Maximum;

            for (int s = 0; s < tmpChart.Series.Count(); s++)
            {
                foreach (DataPoint dp in tmpChart.Series[s].Points)
                {
                    if (dp.XValue >= leftLimit && dp.XValue <= rightLimit)
                    {
                        min = Math.Min(min, dp.YValues[0]);
                        max = Math.Max(max, dp.YValues[0]);
                    }
                }
            }
            tmpChart.ChartAreas[0].AxisY.Maximum = (Math.Ceiling((max / 10)) * 10);
            tmpChart.ChartAreas[0].AxisY.Minimum = (Math.Floor((min / 10)) * 10);

        }
        //---------------------------------------------------------------------------------//

        public GestorGraficos(GestorCalculos gCalculos)
        {
            this.gestor = gCalculos;
        }

        
    }
}

