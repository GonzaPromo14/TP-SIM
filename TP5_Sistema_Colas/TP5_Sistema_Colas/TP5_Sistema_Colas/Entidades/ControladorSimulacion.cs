using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades.Objetos;
using Medallion.Collections;
using TP5_Sistema_Colas.Entidades.Eventos;

namespace TP5_Sistema_Colas.Entidades
{
    class ControladorSimulacion
    {
        //Por favor no le muestren esto a la Meles
        //--------------------------------------------------
        public List<dynamic[]> vectorAnterior = new List<dynamic[]>();
        public List<dynamic[]> vectorActual = new List<dynamic[]>();

        public Evento evento;
        public PriorityQueue<Evento> eventos;
        public List<Camion> camiones;

        //-------------------------------------------------
        public void simular(int iteraciones, int desde , int hasta)
        {
            camiones = new List<Camion>();

            Zona zona1 = new Zona(1, "Libre", this, 0.43, 2, 1.1);
            Zona zona2 = new Zona(2, "Libre", this, 0.16, 5.8, 3.1);
            /*
            Zona zona3 = new Zona(3, "Libre", this, 0.14, 6.2, 2.7);
            Zona zona4 = new Zona(4, "Libre", this, 0.1, 6.1, 6.1);
            Zona zona5 = new Zona(5, "Libre", this, 0.09, 10.9, 5.2);
            Zona zona6 = new Zona(6, "Libre", this, 0.08, 11.2, 3.9);
            Zona zona7 = new Zona(7, "Libre", this, 0.05, 9, 5.8);
            Zona zona8 = new Zona(8, "Libre", this, 0.05, 18.7, 13);             
             */

            // inicializacion 
            eventos = new PriorityQueue<Evento>(new Evento());//los eventos se van a ir ordenando por tiempo de menor a mayor
           
            dynamic[] vecEventoReloj = { "INICIALIZACION", 0 };
            vectorAnterior.Add(vecEventoReloj);

            dynamic[] vecZona1 = zona1.iniciarZona();
            dynamic[] vecZona2 = zona2.iniciarZona();
            /*
            dynamic[] vecZona3 = zona3.iniciarZona();
            dynamic[] vecZona4 = zona4.iniciarZona();
            dynamic[] vecZona5 = zona5.iniciarZona();
            dynamic[] vecZona6 = zona6.iniciarZona();
            dynamic[] vecZona7 = zona7.iniciarZona();
            dynamic[] vecZona8 = zona8.iniciarZona();            
             */

            vectorAnterior.Add(vecZona1);
            vectorAnterior.Add(vecZona2);

            //falta agregar la parte de metricas


            iteraciones = 2;

            

            //loop principal
            for(int i=1; i<=iteraciones; i++)
            {

                vectorActual = vectorAnterior;

                //saco el evento con tiempo más proximo de la cola
                evento = eventos.Dequeue();


                vectorActual.ElementAt(0)[0] = evento.nombre;
                vectorActual.ElementAt(0)[1] = evento.tiempo;

                evento.ocurrir(this);
                
                Console.WriteLine(evento.ToString());
                
                //cargar vectorActual a grilla


                //actualizo vectores
                vectorAnterior = vectorActual;
            }

            

        }


    }
}
