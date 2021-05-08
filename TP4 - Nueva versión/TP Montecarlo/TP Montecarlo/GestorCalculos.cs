using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Montecarlo
{
    class GestorCalculos
    {
        //Vectores estado
        double[] vectorEstadoActual = new double[11];
        double[] vectorEstadoAnterior = new double[11];

        //Atributos de los vectores
        int dia = 0;
        int randomDemanda = 1;
        int demanda = 2;
        int stock = 3;
        int sobrante = 4;
        int randomMulta = 5;
        int multa = 6;
        int venta = 7;
        int costoTorta = 8;
        int total = 9;
        int totalAcumulado = 10;

        //Parámetros para los cálculos
        double costoPorTorta;
        double precioVenta;
        double costoMulta;
        double produccion;

        //Tabla de probabilidades
        double[][] probabilidadDemandaTortas;
        double[][] probabilidadMultas;

        //Atributos de la tabla de probabilidades
        int valor = 0;
        int probabilidad = 1;
        int probabilidadInferior = 2;
        int probabilidadAcumulada = 3;

        public GestorCalculos()
        {
            probabilidadDemandaTortas = new double[7][];
            probabilidadDemandaTortas[0] = new double[] {10, 0.1, 0 ,0.1 };
            probabilidadDemandaTortas[1] = new double[] {20, 0.2, 0.1 ,0.3 };
            probabilidadDemandaTortas[2] = new double[] {25, 0.4, 0.3, 0.7 };
            probabilidadDemandaTortas[3] = new double[] {30, 0.1, 0.7, 0.8 };
            probabilidadDemandaTortas[4] = new double[] {50, 0.1, 0.8, 0.9 };
            probabilidadDemandaTortas[5] = new double[] {70, 0.05, 0.9, 0.95 };
            probabilidadDemandaTortas[6] = new double[] {100, 0.05, 0.95, 1 };
            probabilidadMultas = new double[2][];
            probabilidadMultas[0] = new double[] { 1, 0.25, 0, 0.25 };
            probabilidadMultas[1] = new double[] { 0, 0.75, 0.25, 1 };
        }

        public void llenarGrillas(DataGridView grdDemanda, DataGridView grdMulta)
        {
            for (int i = 0; i<probabilidadDemandaTortas.Length; i++)
            {
                grdDemanda.Rows.Add(new string[] {
                    probabilidadDemandaTortas[i][valor].ToString(),
                    probabilidadDemandaTortas[i][probabilidad].ToString(),
                    probabilidadDemandaTortas[i][probabilidadAcumulada].ToString()
                });
            }
            for (int i = 0; i<probabilidadMultas.Length; i++)
            {
                grdMulta.Rows.Add(new string[] {
                    probabilidadMultas[i][valor] == 1 ? "SI" : "NO",
                    probabilidadMultas[i][probabilidad].ToString(),
                    probabilidadMultas[i][probabilidadAcumulada].ToString() });
            }
        }

        public void inicializarParametrosCalculos(double costoPorTorta, double precioVenta, double costoMulta, double produccion)
        {
            this.costoPorTorta = costoPorTorta;
            this.precioVenta = precioVenta;
            this.costoMulta = costoMulta;
            this.produccion = produccion;
            this.setVectorEstadoAnterior(
                new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            );
            this.setVectorEstadoActual(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }

        public void setVectorEstadoActual(
            double dia,
            double randomDemanda,
            double demanda,
            double stock,
            double sobrante,
            double randomMulta,
            double multa,
            double venta,
            double costoTorta,
            double total,
            double totalAcumulado)
        {
            vectorEstadoActual[this.dia] = dia;
            vectorEstadoActual[this.randomDemanda] = randomDemanda;
            vectorEstadoActual[this.demanda] = demanda;
            vectorEstadoActual[this.stock] = stock;
            vectorEstadoActual[this.sobrante] = sobrante;
            vectorEstadoActual[this.randomMulta] = randomMulta;
            vectorEstadoActual[this.multa] = multa;
            vectorEstadoActual[this.venta] = venta;
            vectorEstadoActual[this.costoTorta] = costoTorta;
            vectorEstadoActual[this.total] = total;
            vectorEstadoActual[this.totalAcumulado] = totalAcumulado;

        }

        public void setVectorEstadoAnterior(double[] vectorActualizar)
        {
            this.vectorEstadoAnterior = vectorActualizar;
        }

        public double[] getVectorEstadoActual()
        {
            return this.vectorEstadoActual;
        }

        public double[] getVectorEstadoAnterior()
        {
            return this.vectorEstadoAnterior;
        }

        public double obtenerDemanda(double probabilidad)
        {
            double demandaGenerada = 0;
            for (int i = 0; i < this.probabilidadDemandaTortas.Length; i++)
            {
                demandaGenerada = probabilidadDemandaTortas[i][valor];
                if (probabilidad < probabilidadDemandaTortas[i][probabilidadAcumulada] && probabilidad > probabilidadDemandaTortas[i][probabilidadInferior])
                {
                    break;
                }

            }
            return demandaGenerada;
        }

        public double obtenerMulta(double probabilidad)
        {
            return probabilidad < this.probabilidadMultas[0][probabilidadAcumulada] ? this.costoMulta : 0;
        }

        public void generarSimulacion(int cantidadSimulaciones, DataGridView grd)
        {
            Random r = new Random();
            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                double rndDemanda = r.NextDouble();
                double rndMulta = r.NextDouble();
                double demandaNueva = this.obtenerDemanda(rndDemanda);
                double sobranteActual = demandaNueva > this.produccion ? 0 : this.produccion - demandaNueva;
                double multaNueva = this.obtenerMulta(rndMulta);
                double venta = (sobranteActual == 0) ? this.produccion * this.precioVenta : (this.produccion - demandaNueva) * this.precioVenta;
                double costoProduccionTorta = this.costoPorTorta * this.produccion;
                double totalActual = venta - multaNueva - costoProduccionTorta;
                double totalAcumuladoActual = vectorEstadoAnterior[this.totalAcumulado] + totalActual;
                this.setVectorEstadoActual(
                    this.vectorEstadoAnterior[this.dia] + 1,
                    rndDemanda,
                    demandaNueva,
                    this.produccion,
                    sobranteActual,
                    rndMulta,
                    multaNueva,
                    venta,
                    costoProduccionTorta,
                    totalActual,
                    totalAcumuladoActual
                    );
                this.setVectorEstadoAnterior(this.vectorEstadoActual);
                grd.Rows.Add(
                    this.vectorEstadoAnterior[this.dia],
                    this.vectorEstadoAnterior[this.randomDemanda],
                    this.vectorEstadoAnterior[this.demanda],
                    this.vectorEstadoAnterior[this.stock],
                    this.vectorEstadoAnterior[this.sobrante],
                    this.vectorEstadoAnterior[this.randomMulta],
                    this.vectorEstadoAnterior[this.multa],
                    this.vectorEstadoAnterior[this.venta],
                    this.vectorEstadoAnterior[this.costoTorta],
                    this.vectorEstadoAnterior[this.total],
                    this.vectorEstadoAnterior[this.totalAcumulado]
                    );

            }
        }

    }
}
