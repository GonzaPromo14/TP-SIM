using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades;

namespace TP5_Sistema_Colas.Entidades.Objetos
{
    public class RugenKutta
    {     
        

        public double tIncial;
        public int eIncial;
        public double tFinal;
        public int eFinal;
        public double h;
        public double alfa;
        //para la ED de purgacion
        public int l;

        public dynamic[] vectorAnterior;
        public dynamic[] vectorActual;
        public List<dynamic[]> simulaciones;

        public double t50;
        private bool encontroT50;
        public double t70;
        private bool encontroT70;
        public double t100;


        public RugenKutta( int eIni, double tFin, int eFin, double ache)
        {
            tIncial = 0;
            eIncial = eIni;
            tFinal = tFin;
            eFinal = eFin;
            alfa = 0.00;
            l = 0;
            h= ache;
        }

        public RugenKutta( int ele, double ache)
        {
            tIncial = 0;
            l = ele;
            eIncial = 0;
            tFinal = 0.00;
            eFinal = 0;
            alfa = 0.00;
            h = ache;
        }

        public void calcularAlfa ()
        {
            //despejamos alfa de la solucion de la ecuacion diferencial
            alfa = Math.Log(eFinal / eIncial) / tFinal;
        }

        public void setAlfa (double alf)
        {
            alfa = alf;
        }

        public void setL(int l)
        {
            this.l = l;
        }
        public double getAlfa()
        {
            return alfa;
        }
        
        public double getHache()
        {
            return h;
        }

        public double usarEDInestable (double e)
        {
            return Truncador.Truncar(alfa * e);
        }

        public double usarEDPurga (int ele)
        {
            return Truncador.Truncar(-alfa * ele * 0.5);
        }

        public List<dynamic[]> getSimulaciones()
        {
            return this.simulaciones;
        }

        public void correrRugenKuttaInestable ()
        {
            
            //INICIALIACION
            vectorAnterior = new dynamic[12];
            vectorActual = new dynamic[12];
            simulaciones = new List<dynamic[]>();
            t50 = 0.00;
            t70 = 0.00;
            t100 = 0.00;
            encontroT50 = false;
            encontroT70 = false;


            vectorActual[Constantes.colTiempo] = tIncial;
            vectorActual[Constantes.colE] = eIncial;
            vectorActual[Constantes.colK1] = usarEDInestable(vectorActual[Constantes.colE]);
            vectorActual[Constantes.colTiempoK2] = vectorActual[Constantes.colTiempo] + (h / 2); 
            vectorActual[Constantes.colEK2] = Truncador.Truncar(eIncial + ((vectorActual[Constantes.colK1]*h)/2));
            vectorActual[Constantes.colK2] = usarEDInestable(vectorActual[Constantes.colEK2]);
            vectorActual[Constantes.colTiempoK3] = vectorActual[Constantes.colTiempo] + (h / 2);
            vectorActual[Constantes.colEK3] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK2] * h) / 2);
            vectorActual[Constantes.colK3] = usarEDInestable(vectorActual[Constantes.colEK2]);
            vectorActual[Constantes.colTiempoK4] = vectorActual[Constantes.colTiempo] + h;
            vectorActual[Constantes.colEK4] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK3]) / 2);
            vectorActual[Constantes.colK4] = usarEDInestable(vectorActual[Constantes.colEK3]);
            simulaciones.Add(vectorActual.ToArray());


            //iteraciones
            do
            {
                vectorAnterior = vectorActual;

                vectorActual[Constantes.colTiempo] = vectorAnterior[Constantes.colTiempoK4];
                vectorActual[Constantes.colE] = Truncador.Truncar(vectorAnterior[Constantes.colE] 
                    + h/6*(vectorAnterior[Constantes.colK1] + 
                           2* vectorAnterior[Constantes.colK2] +
                           2* vectorAnterior[Constantes.colK3] +
                           vectorAnterior[Constantes.colK4]));
                vectorActual[Constantes.colK1] = usarEDInestable(vectorActual[Constantes.colE]);
                vectorActual[Constantes.colTiempoK2] = vectorActual[Constantes.colTiempo] + (h / 2);
                vectorActual[Constantes.colEK2] = Truncador.Truncar(eIncial + ((vectorActual[Constantes.colK1] * h) / 2));
                vectorActual[Constantes.colK2] = usarEDInestable(vectorActual[Constantes.colEK2]);
                vectorActual[Constantes.colTiempoK3] = vectorActual[Constantes.colTiempo] + (h / 2);
                vectorActual[Constantes.colEK3] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK2] * h) / 2);
                vectorActual[Constantes.colK3] = usarEDInestable(vectorActual[Constantes.colEK2]);
                vectorActual[Constantes.colTiempoK4] = vectorActual[Constantes.colTiempo] + h;
                vectorActual[Constantes.colEK4] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK3]) / 2);
                vectorActual[Constantes.colK4] = usarEDInestable(vectorActual[Constantes.colEK3]);
                simulaciones.Add(vectorActual.ToArray());

                if(vectorActual[Constantes.colE] >= 50 && encontroT50 == false)
                {
                    t50 = vectorActual[Constantes.colTiempo];
                    encontroT50 = true;
                }
                if (vectorActual[Constantes.colE] >= 70 && encontroT70 == false)
                {
                    t70 = vectorActual[Constantes.colTiempo];
                    encontroT70 = true;
                }
                


            } while (eFinal > vectorActual[Constantes.colE]);

            t100 = vectorActual[Constantes.colTiempo];

        }


        public void correrRugenKuttaPurga()
        {

            //INICIALIACION
            vectorAnterior = new dynamic[13];
            vectorActual = new dynamic[13];
            simulaciones = new List<dynamic[]>();
            //el valor E se refiere al L
            vectorActual[Constantes.colTiempo] = tIncial;
            vectorActual[Constantes.colE] = l;
            vectorActual[Constantes.colK1] = usarEDPurga(vectorActual[Constantes.colE]);
            vectorActual[Constantes.colTiempoK2] = vectorActual[Constantes.colTiempo] + (h / 2);
            vectorActual[Constantes.colEK2] = Truncador.Truncar(eIncial + ((vectorActual[Constantes.colK1] * h) / 2));
            vectorActual[Constantes.colK2] = usarEDPurga(vectorActual[Constantes.colEK2]);
            vectorActual[Constantes.colTiempoK3] = vectorActual[Constantes.colTiempo] + (h / 2);
            vectorActual[Constantes.colEK3] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK2] * h) / 2);
            vectorActual[Constantes.colK3] = usarEDPurga(vectorActual[Constantes.colEK2]);
            vectorActual[Constantes.colTiempoK4] = vectorActual[Constantes.colTiempo] + h;
            vectorActual[Constantes.colEK4] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK3]) / 2);
            vectorActual[Constantes.colK4] = usarEDPurga(vectorActual[Constantes.colEK3]);
            vectorActual[Constantes.colL1L0] = 1;

            

            //iteraciones
            do
            {
                vectorAnterior = vectorActual;

                vectorActual[Constantes.colTiempo] = vectorAnterior[Constantes.colTiempoK4];
                vectorActual[Constantes.colE] = Truncador.Truncar(vectorAnterior[Constantes.colE]
                    + h / 6 * (vectorAnterior[Constantes.colK1] +
                           2 * vectorAnterior[Constantes.colK2] +
                           2 * vectorAnterior[Constantes.colK3] +
                           vectorAnterior[Constantes.colK4]));
                vectorActual[Constantes.colK1] = usarEDPurga(vectorActual[Constantes.colE]);
                vectorActual[Constantes.colTiempoK2] = vectorActual[Constantes.colTiempo] + (h / 2);
                vectorActual[Constantes.colEK2] = Truncador.Truncar(eIncial + ((vectorActual[Constantes.colK1] * h) / 2));
                vectorActual[Constantes.colK2] = usarEDPurga(vectorActual[Constantes.colEK2]);
                vectorActual[Constantes.colTiempoK3] = vectorActual[Constantes.colTiempo] + (h / 2);
                vectorActual[Constantes.colEK3] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK2] * h) / 2);
                vectorActual[Constantes.colK3] = usarEDPurga(vectorActual[Constantes.colEK2]);
                vectorActual[Constantes.colTiempoK4] = vectorActual[Constantes.colTiempo] + h;
                vectorActual[Constantes.colEK4] = Truncador.Truncar(eIncial + (vectorActual[Constantes.colK3]) / 2);
                vectorActual[Constantes.colK4] = usarEDPurga(vectorActual[Constantes.colEK3]);
                vectorActual[Constantes.colL1L0] = Truncador.Truncar(
                                           vectorActual[Constantes.colE] - vectorAnterior[Constantes.colE]);

            } while (vectorActual[Constantes.colL1L0] > 0.02);



        }

        public double valorTRandom(double rnd)
        {
            if (rnd < 0.50)
            {
                return this.t100;
            }
            if (rnd < 0.80)
            {
                return this.t70;
            }
            return t50;
        }



    }
}
