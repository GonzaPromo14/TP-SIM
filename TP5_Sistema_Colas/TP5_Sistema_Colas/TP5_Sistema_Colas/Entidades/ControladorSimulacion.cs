﻿using System;
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
        Form1 pantalla;
        //Por favor no le muestren esto a la Meles
        //--------------------------------------------------
        public dynamic[] vectorAnterior;
        public dynamic[] vectorActual;


        public Evento evento;
        public PriorityQueue<Evento> eventos;
        public List<Camion> camiones;
        public List<Zona> zonas;

        int iteraciones;
        public int contadorCamiones; //para la capacidad
        int capacidadMAX = 93;
        int desde;
        int hasta;

        public ControladorSimulacion(Form1 pantalla)
        {
            this.pantalla = pantalla;
        }
        //-------------------------------------------------
        public void simular()
        {
            contadorCamiones = 0;
            vectorAnterior = new dynamic[82];
            vectorActual = new dynamic[82];

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

            zona1.iniciarZona(vectorActual);
            zona2.iniciarZona(vectorActual);
            zona3.iniciarZona(vectorActual);
            zona4.iniciarZona(vectorActual);
            zona5.iniciarZona(vectorActual);
            zona6.iniciarZona(vectorActual);
            zona7.iniciarZona(vectorActual);
            zona8.iniciarZona(vectorActual);
            
            //falta agregar la parte de metricas

            pantalla.cargarLinea(vectorActual);
            
            iteraciones = 20;
            vectorAnterior = vectorActual;//esto se hace solo la primera vez para que ande

            //loop principal
            for (int i=1; i<=iteraciones; i++)
            {

                vectorActual = vectorAnterior;

                //saco el evento con tiempo más proximo de la cola
                evento = eventos.Dequeue();

                vectorActual[Constantes.colEvento] = evento.nombre;
                vectorActual[Constantes.colReloj] = evento.tiempo;


                evento.ocurrir(this);

                //cargar vectorActual a grilla

                pantalla.cargarLinea(vectorActual);

                //actualizo vectores
                vectorAnterior = vectorActual;
            }

        }
    }
}
