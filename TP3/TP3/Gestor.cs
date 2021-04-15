using System;
using System.Collections.Generic;
using System.Text;
using TP3.Distribuciones;

namespace TP3
{
    /*Esta clase maneja los objetos y variables para los cálculos, genera todo lo que se muestra en la ventana
    los metodos para graficar podrían ir acá o los podemos poner en otra clase
    lo mismo para las pruebas de Chi y KS
    */
    public class Gestor
    {
        // Estas se ingresan en la ventana
        public int n;
        public int cantIntervalos;

        public double a;
        public double b;

        public double sigma;
        public double u;//mu

        public double lambda;

        //----------------------------------

        public double media;
        public double varianza;
        public double desviacion;

        public List<double> muestras;//lista de randoms
        public List<double[]> intervalos;

        public double[] frecuenciasObservadas;
        public double[] frecuenciasEsperadas;
        
        public double[] probEsperadas;
        public double[] probObservadas;

        public string[] marcasDeClase;//para el grafico

        public double[] acumProbEsperada;

        public double[] acumProbObservada;

        public IEstrategia distribucionElegida;

        public Gestor() { }

       
        //acá deberia ir el loop para calcular los valores
        public void generarDatos(int cantidad)
        {

        }
         
        //acá se calcula lo que falta para el grafico y las pruebas de bondad (fo, po, acumuladas, etc)
        //Las frecuencias y probabilidad ESPERADAS se calculan en las estrategias
        public void obtenerFrecuencias()
        {

        }
         
    }
}
