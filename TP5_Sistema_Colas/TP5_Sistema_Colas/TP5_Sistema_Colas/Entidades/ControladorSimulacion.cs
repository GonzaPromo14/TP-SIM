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
    public class ControladorSimulacion
    {
        Form1 pantalla;
        //Por favor no le muestren esto a la Meles
        //--------------------------------------------------
        public dynamic[] vectorAnterior;
        public dynamic[] vectorActual;
        public List<dynamic[]> simulaciones;
        //public List[][] simulaciones;

        public Evento evento;
        public PriorityQueue<Evento> eventos;
        public List<Camion> camiones;
        public List<Zona> zonas;

        public int iteraciones;
        public int contadorCamiones; //para la capacidad
        int capacidadMAX = 93;

        public int desde = 500;
        public int hasta = 700;

        public ControladorSimulacion(Form1 pantalla)
        {
            this.pantalla = pantalla;
        }
        //-------------------------------------------------
        public void simular()
        {
            simulaciones = new List<dynamic[]>();
            //simulaciones = new dynamic[hasta - desde][];
            Constantes.cantidadHorasSemana = 168;

            contadorCamiones = 0;
            vectorAnterior = new dynamic[83];
            vectorActual = new dynamic[83];

            camiones = new List<Camion>();
            zonas = new List<Zona>();
            Camion.numeracion = 1;// reinicia la numeracion de camiones

            //creacion de las zonas

            Zona zona1 = new Zona(1, "Libre", this, 0.43, 2, 1.1);
            Zona zona2 = new Zona(2, "Libre", this, 0.16, 5.8, 3.1);
            Zona zona3 = new Zona(3, "Libre", this, 0.14, 6.2, 2.7);
            Zona zona4 = new Zona(4, "Libre", this, 0.1, 6.1, 6.1);
            Zona zona5 = new Zona(5, "Libre", this, 0.09, 10.9, 5.2);
            Zona zona6 = new Zona(6, "Libre", this, 0.08, 11.2, 3.9);
            Zona zona7 = new Zona(7, "Libre", this, 0.05, 9, 5.8);
            Zona zona8 = new Zona(8, "Libre", this, 0.05, 18.7, 13);

            zonas.Add(zona1);
            zonas.Add(zona2);
            zonas.Add(zona3);
            zonas.Add(zona4);
            zonas.Add(zona5);
            zonas.Add(zona6);
            zonas.Add(zona7);
            zonas.Add(zona8);


            // inicializacion 
            //los eventos se van a ir ordenando por tiempo de menor a mayor, entonces con eventos.Dequeue() siempre tengo el proximo evento
            eventos = new PriorityQueue<Evento>(new Evento());

            vectorActual[Constantes.colEvento] = "INICIALIZACION";
            vectorActual[Constantes.colReloj] = 0;
            vectorActual[Constantes.colNumeroSimulacion] = 0;

            zona1.iniciarZona(vectorActual);
            zona2.iniciarZona(vectorActual);
            zona3.iniciarZona(vectorActual);
            zona4.iniciarZona(vectorActual);
            zona5.iniciarZona(vectorActual);
            zona6.iniciarZona(vectorActual);
            zona7.iniciarZona(vectorActual);
            zona8.iniciarZona(vectorActual);

            //falta agregar la parte de metricas

            //pantalla.cargarLinea(vectorActual, 0);

            if (desde == 0) simulaciones.Add(vectorActual.ToArray());
            //simulaciones.Add(vectorActual.ToArray());
            vectorAnterior = vectorActual;//esto se hace solo la primera vez para que ande

            //loop principal
            for (int i=1; i<=iteraciones; i++)
            {

                vectorActual = vectorAnterior;

                //saco el evento con tiempo más proximo de la cola
                evento = eventos.Dequeue();

                vectorActual[Constantes.colReloj] = evento.tiempo;

                //aumento las medias en 0,24

                if(vectorActual[Constantes.colReloj] >= Constantes.cantidadHorasSemana)
                {
                    Constantes.cantidadHorasSemana += 168;
                    foreach (Zona zona in zonas) zona.aumentarMedia();
                }

                evento.ocurrir(this);

                //cargar vectorActual a grilla

                //pantalla.cargarLinea(vectorActual, i);

                //actualizo vectores
                vectorActual[Constantes.colNumeroSimulacion] = i;
                //if (i >= desde && i<=hasta) simulaciones[i - (hasta-desde) - 1] = vectorActual.ToArray();
                if (i>=desde && i<=hasta) simulaciones.Add(vectorActual.ToArray());
                vectorAnterior = vectorActual;

            }
            

        }

        public List<dynamic[]> getSimulaciones()
        {
            return this.simulaciones;
        }

        public dynamic[] getUltimaSimulacion()
        {
            return this.vectorActual;
        }
    }
}
