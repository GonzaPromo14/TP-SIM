using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3.DataLayer
{
    class GestorPruebas
    {

        public int cantIntervalos = 10; //Pongo uno por defecto así grafica
        public int cantNuevaIntervalos = 0;

        public List<double[]> intervalos;// matriz de intervalos
        public double[] frecuenciasObservadas;
        public double[] frecuenciasEsperadas;
        public double[] probEsperadas;
        public double[] probObservadas;
        public double[] acumProbEsperada;
        public double[] acumProbObservada;
        public double[] c;
        public double[] cAcumulada;
        public double[] restaKS;
        public double[] KS;
        public int gradosLibertad;
        public double nivelConfianza = 0.05;

        GestorCalculos gCalculos;
        String distribucion;

        public GestorPruebas(GestorCalculos g, String distribucion)
        {
            this.gCalculos = g;
            this.generarNuevosIntervalos(gCalculos);
            this.distribucion = distribucion;
        }

        public void generarNuevosIntervalos(GestorCalculos g)
        {
            cantNuevaIntervalos = 0;
            cantIntervalos = g.cantIntervalos;
            intervalos = new List<double[]>();

            frecuenciasObservadas = new double[cantIntervalos];
            frecuenciasEsperadas = new double[cantIntervalos];

            probObservadas = new double[cantIntervalos];
            probEsperadas = new double[cantIntervalos];

            acumProbEsperada = new double[cantIntervalos];
            acumProbObservada = new double[cantIntervalos];
            c = new double[cantIntervalos];
            cAcumulada = new double[cantIntervalos];

            restaKS = new double[cantIntervalos];
            KS = new double[cantIntervalos];
        }

        public void actualizarIntervalos()//calculo los estadísticos 
        {
            cantNuevaIntervalos = 0;
            int valorIndexPruebas = 0;
            for (int i = 0; i < gCalculos.getCantidadIntervalos(); i++)
            {
                int intervalo = i + 1;
                double li = gCalculos.intervalos[i][0];
                double ls = gCalculos.intervalos[i][1];

                double frecObservadas = gCalculos.frecuenciasObservadas[i];
                double probObservadas = gCalculos.probObservadas[i];
                double acumObservadas = gCalculos.acumProbObservada[i];

                double frecEsperadas = gCalculos.frecuenciasEsperadas[i];
                double probEsperadas = gCalculos.probEsperadas[i];
                double acumEsperadas = gCalculos.acumProbEsperada[i];

                if (frecEsperadas >= 5)
                {
                    double[] filaIntervalo = { li, ls };
                    this.intervalos.Add(filaIntervalo);
                    this.frecuenciasObservadas[valorIndexPruebas] = frecObservadas;
                    this.probObservadas[valorIndexPruebas] = probObservadas;
                    this.acumProbObservada[valorIndexPruebas] = (valorIndexPruebas != 0) ? this.acumProbObservada[valorIndexPruebas - 1] + probObservadas : probObservadas;
                    this.frecuenciasEsperadas[valorIndexPruebas] = frecEsperadas;
                    this.probEsperadas[valorIndexPruebas] = probEsperadas;
                    this.probEsperadas[valorIndexPruebas] = probEsperadas;
                    this.acumProbEsperada[valorIndexPruebas] = (valorIndexPruebas != 0) ? this.acumProbEsperada[valorIndexPruebas - 1] + probEsperadas : probEsperadas;
                    this.cantNuevaIntervalos++;

                }
                else//si la frecuencia esperada es menor a 5
                {
                    if (i + 1 == gCalculos.getCantidadIntervalos())//si estoy en el ultimo intervalo
                    {
                        int nuevoIndice = this.cantNuevaIntervalos - 1; //esto no es lo mismo que i?
                        this.intervalos[nuevoIndice][1] = ls;
                        this.frecuenciasObservadas[nuevoIndice] += frecObservadas;
                        this.probObservadas[nuevoIndice] += probObservadas;
                        this.acumProbObservada[nuevoIndice] = (nuevoIndice != 0) ? this.acumProbObservada[nuevoIndice - 1] + this.probObservadas[nuevoIndice] : this.probObservadas[nuevoIndice];
                        this.frecuenciasEsperadas[nuevoIndice] += frecEsperadas;
                        this.probEsperadas[nuevoIndice] += probEsperadas;
                        this.probEsperadas[nuevoIndice] += probEsperadas;
                        this.acumProbEsperada[nuevoIndice] = (nuevoIndice != 0) ? this.acumProbEsperada[nuevoIndice - 1] + this.probEsperadas[nuevoIndice] : this.probEsperadas[nuevoIndice];
                    }
                    else
                    {
                        int iUltimoAnalizado = i;
                        while (frecEsperadas < 5)
                        {
                            i++;
                            ls = Truncador.Truncar(gCalculos.intervalos[i][1]);//este truncador creo que no va
                            frecObservadas = frecObservadas + gCalculos.frecuenciasObservadas[i];
                            probObservadas = probObservadas + gCalculos.probObservadas[i];
                            acumObservadas = acumObservadas + gCalculos.acumProbObservada[i];

                            frecEsperadas = frecEsperadas + gCalculos.frecuenciasEsperadas[i];
                            probEsperadas = probEsperadas + gCalculos.probEsperadas[i];
                            acumEsperadas = acumEsperadas + gCalculos.acumProbEsperada[i];
                            if (i + 1 == gCalculos.getCantidadIntervalos())
                            {
                                break;
                            }
                        }
                        if (i + 1 == gCalculos.getCantidadIntervalos() && frecEsperadas <= 5)
                        {
                            int nuevoIndice = this.cantNuevaIntervalos - 1;
                            this.intervalos[nuevoIndice][1] = ls;
                            this.frecuenciasObservadas[nuevoIndice] += frecObservadas;
                            this.probObservadas[nuevoIndice] += probObservadas;
                            this.acumProbObservada[nuevoIndice] = (nuevoIndice != 0) ? this.acumProbObservada[nuevoIndice - 1] + this.probObservadas[nuevoIndice] : this.probObservadas[nuevoIndice];
                            this.frecuenciasEsperadas[nuevoIndice] += frecEsperadas;
                            this.probEsperadas[nuevoIndice] += probEsperadas;
                            this.probEsperadas[nuevoIndice] += probEsperadas;
                            this.acumProbEsperada[valorIndexPruebas] = (nuevoIndice != 0) ? this.acumProbEsperada[nuevoIndice - 1] + this.probEsperadas[nuevoIndice] : this.probEsperadas[nuevoIndice];
                        }
                        else
                        {
                            double[] filaIntervalo = { li, ls };
                            this.intervalos.Add(filaIntervalo);
                            this.frecuenciasObservadas[valorIndexPruebas] = frecObservadas;
                            this.probObservadas[valorIndexPruebas] = probObservadas;
                            this.acumProbObservada[valorIndexPruebas] = (valorIndexPruebas != 0) ? this.acumProbObservada[valorIndexPruebas - 1] + probObservadas : probObservadas;
                            this.frecuenciasEsperadas[valorIndexPruebas] = frecEsperadas;
                            this.probEsperadas[valorIndexPruebas] = probEsperadas;
                            this.probEsperadas[valorIndexPruebas] = probEsperadas;
                            this.acumProbEsperada[valorIndexPruebas] = (valorIndexPruebas != 0) ? this.acumProbEsperada[valorIndexPruebas - 1] + probEsperadas : probEsperadas;
                            this.cantNuevaIntervalos++;
                        }

                    }
                }
                //voy calculando ks
                double aux_ks = Math.Abs(this.acumProbObservada[valorIndexPruebas] - this.acumProbEsperada[valorIndexPruebas]);
                restaKS[valorIndexPruebas] = aux_ks;
                KS[valorIndexPruebas] = (valorIndexPruebas) == 0 ? aux_ks : Math.Max(KS[valorIndexPruebas - 1], aux_ks);
                //voy calculando chi
                double calculo = Math.Pow(this.frecuenciasObservadas[valorIndexPruebas] - this.frecuenciasEsperadas[valorIndexPruebas], 2) / this.frecuenciasEsperadas[valorIndexPruebas];
                c[valorIndexPruebas] = calculo;
                cAcumulada[valorIndexPruebas] = (valorIndexPruebas == 0) ? calculo : cAcumulada[valorIndexPruebas - 1] + calculo;
                valorIndexPruebas++;


            }
        }

        public int calcularGradosLibertad()
        {
            switch (distribucion)
            {
                case "Uniforme":
                    this.gradosLibertad = this.cantNuevaIntervalos - 1;
                    break;
                case "Normal":
                    this.gradosLibertad = this.cantNuevaIntervalos - 1 - 2;
                    break;
                default:
                    this.gradosLibertad = this.cantNuevaIntervalos - 1 - 1;
                    break;
            }
            return this.gradosLibertad;
        }
       

    }
}
