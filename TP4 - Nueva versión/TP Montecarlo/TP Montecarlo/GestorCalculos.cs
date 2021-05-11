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
        double[] vectorEstadoActual = new double[14];
        double[] vectorEstadoAnterior = new double[14];

        //Atributos de los vectores
        int dia = 0;
        int randomDemanda = 1;
        int demanda = 2;
        int vendidas = 3;
        int stock = 4;
        int sobrante = 5;
        int promedioATirar = 6;
        int randomMulta = 7;
        int multa = 8;
        int gananciaMulta = 9;
        int utilidadMulta = 10;
        int costoPorPermiso = 11;
        int gananciaPermiso = 12;
        int utilidadPermiso = 13;

        //Parámetros para los cálculos
        double costoPorTorta;
        double precioVenta;
        double costoMulta;
        double produccion;
        double costoPermiso = 200;

        //Tabla de probabilidades
        double[][] probabilidadDemandaTortas;
        double[][] probabilidadMultas;

        //Atributos de la tabla de probabilidades
        int valor = 0;
        int probabilidad = 1;
        int probabilidadInferior = 2;
        int probabilidadAcumulada = 3;

        //Cantidad de simulaciones
        int cantidadSimulaciones;


        //Vector para paginacion
        double[][] simulaciones;
        double recorridoVector;
        double desde;
        double hasta;

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

        public void inicializarParametrosCalculos(double costoPorTorta, double precioVenta, double costoMulta, double produccion, int cantidadSimulaciones, double desde, double hasta, long cantidadMostrar)
        {
            this.costoPorTorta = costoPorTorta;
            this.precioVenta = precioVenta;
            this.costoMulta = costoMulta;
            this.produccion = produccion;
            this.setVectorEstadoAnterior(
                new double[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0}
            );
            this.setVectorEstadoActual(0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            this.cantidadSimulaciones = cantidadSimulaciones + 1;
            this.simulaciones = new double[cantidadMostrar + 1][];
            this.simulaciones[0] = new double[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            this.desde = desde;
            this.hasta = hasta;
            this.recorridoVector = 0;
        }

        public void setVectorEstadoActual(
            double dia,
            double randomDemanda,
            double demanda,
            double vendidas,
            double stock,
            double sobrante,
            double promedioATirar,
            double randomMulta,
            double multa,
            double gananciaMulta,
            double utilidadMulta,
            double costoPermiso,
            double gananciaPermiso,
            double utilidadPermiso)
        {
            vectorEstadoActual[this.dia] = dia;
            vectorEstadoActual[this.randomDemanda] = randomDemanda;
            vectorEstadoActual[this.demanda] = demanda;
            vectorEstadoActual[this.vendidas] = vendidas;
            vectorEstadoActual[this.stock] = stock;
            vectorEstadoActual[this.sobrante] = sobrante;
            vectorEstadoActual[this.promedioATirar] = promedioATirar;
            vectorEstadoActual[this.randomMulta] = randomMulta;
            vectorEstadoActual[this.multa] = multa;
            vectorEstadoActual[this.gananciaMulta] = gananciaMulta;
            vectorEstadoActual[this.utilidadMulta] = utilidadMulta;
            vectorEstadoActual[this.costoPorPermiso] = costoPermiso;
            vectorEstadoActual[this.gananciaPermiso] = gananciaPermiso;
            vectorEstadoActual[this.utilidadPermiso] = utilidadPermiso;


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

        public double obtenerMulta(double probabilidad, double sobrante)
        {
            return (probabilidad < this.probabilidadMultas[0][probabilidadAcumulada]) && (sobrante != 0) ? this.costoMulta : 0;
        }

        public void generarSimulacion(int cantidadSimulaciones, DataGridView grd)
        {
            Random r = new Random();
            for (int i = 0; i < cantidadSimulaciones; i++)
            {
                double diaActual = this.vectorEstadoAnterior[this.dia] + 1;
                double rndDemanda = r.NextDouble();
                double demandaNueva = this.obtenerDemanda(rndDemanda);
                double vendidas = demandaNueva > this.produccion ? this.produccion : demandaNueva;
                double sobranteActual = this.produccion - demandaNueva <0 ? 0 : this.produccion - demandaNueva;
                double promedioATirar = (1 / diaActual) * ((diaActual - 1) * vectorEstadoAnterior[this.sobrante] + sobranteActual);
                double rndMulta = r.NextDouble();
                double multaNueva = this.obtenerMulta(rndMulta,sobranteActual);
                double gananciaMulta = vendidas * this.precioVenta - this.produccion * this.costoPorTorta - multaNueva;
                double utilidadMulta =(1/diaActual)*((diaActual-1) * vectorEstadoAnterior[this.utilidadMulta] + gananciaMulta);//utilidad promedio
                double costoPermiso = diaActual % 7 == 0 ? this.costoPermiso : 0;
                double gananciaPermiso = (vendidas*this.precioVenta)-(this.produccion*costoPorTorta)-costoPermiso;
                double utilidadPermiso = (1 / diaActual) * ((diaActual - 1) * vectorEstadoAnterior[this.utilidadPermiso] + gananciaPermiso);//utilidad promedio
                this.setVectorEstadoActual(
                    diaActual,
                    rndDemanda,
                    demandaNueva,
                    vendidas,
                    this.produccion,
                    sobranteActual,
                    promedioATirar,
                    rndMulta,
                    multaNueva,
                    gananciaMulta,
                    utilidadMulta,//cambiar
                    costoPermiso,//cambiar
                    gananciaPermiso,
                    utilidadPermiso
                    );
                if (diaActual >= this.desde && diaActual <= this.hasta)
                {
                    this.simulaciones[long.Parse(recorridoVector.ToString())] = new double[] {
                    diaActual, rndDemanda, demandaNueva,vendidas, this.produccion, sobranteActual, promedioATirar,rndMulta, multaNueva, gananciaMulta,
                    utilidadMulta, costoPermiso, gananciaPermiso, utilidadPermiso};
                    recorridoVector++;
                }
                this.setVectorEstadoAnterior(this.vectorEstadoActual);



                //grd.Rows.Add(
                //    this.vectorEstadoAnterior[this.dia],
                //    this.vectorEstadoAnterior[this.randomDemanda],
                //    this.vectorEstadoAnterior[this.demanda],
                //    this.vectorEstadoAnterior[this.stock],
                //    this.vectorEstadoAnterior[this.sobrante],
                //    this.vectorEstadoAnterior[this.randomMulta],
                //    this.vectorEstadoAnterior[this.multa],
                //    this.vectorEstadoAnterior[this.venta],
                //    this.vectorEstadoAnterior[this.costoTorta],
                //    this.vectorEstadoAnterior[this.total],
                //    this.vectorEstadoAnterior[this.totalAcumulado]
                //    );

            }
        }

        public double[][] getSimulaciones()
        {
            return this.simulaciones;
        }

        public double totalFinal()
        {
            return this.getVectorEstadoActual()[gananciaPermiso];
        }
    }
}
