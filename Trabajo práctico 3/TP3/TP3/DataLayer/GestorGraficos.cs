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
                double li = gestor.intervalos[i][0];
                double ls = gestor.intervalos[i][1];
                double frecObservadas = gestor.frecuenciasObservadas[i];
                double probObservadas = gestor.probObservadas[i];
                double acumObservadas = gestor.acumProbObservada[i];
                double frecEsperadas = gestor.frecuenciasEsperadas[i];
                double probEsperadas = gestor.acumProbEsperada[i];
                double acumEsperadas = gestor.acumProbEsperada[i];                

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

        }
        //---------------------------------------------------------------------------------//

        public GestorGraficos(GestorCalculos gCalculos)
        {
            this.gestor = gCalculos;
        }

        
    }
}

