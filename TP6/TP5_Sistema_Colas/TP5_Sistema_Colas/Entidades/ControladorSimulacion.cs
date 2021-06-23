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

        public Random semilla = new Random();

        public Evento evento;
        public PriorityQueue<Evento> eventos;
        public List<Camion> camiones;
        public List<Zona> zonas;

        public int iteraciones;
        public int contadorCamiones; //para la capacidad
        int contadorInsInapropiadas;
        public int contadorLlegadas;
        public double tiempoDeAumentar;
        public int semanaActualizar;

        int capacidadMAX = 93;

        public int desde;
        public int hasta;

        //-----------Parámetros zonas -------------------//
        public double mediaLlegada1 = 0.43;
        public double mediaLlegada2 = 0.16;
        public double mediaLlegada3 = 0.14;
        public double mediaLlegada4 = 0.1;
        public double mediaLlegada5 = 0.09;
        public double mediaLlegada6 = 0.08;
        public double mediaLlegada7 = 0.05;
        public double mediaLlegada8 = 0.05;

        public double mediaServicio1 = 2;
        public double mediaServicio2 = 5.8;
        public double mediaServicio3 = 6.2;
        public double mediaServicio4 = 6.1;
        public double mediaServicio5 = 10.9;
        public double mediaServicio6 = 11.2;
        public double mediaServicio7 = 9;
        public double mediaServicio8 = 18.7;

        public double desvServicio1 = 1.1;
        public double desvServicio2 = 3.1;
        public double desvServicio3 = 2.7;
        public double desvServicio4 = 6.1;
        public double desvServicio5 = 5.2;
        public double desvServicio6 = 3.9;
        public double desvServicio7 = 5.8;
        public double desvServicio8 = 13;

        //-----------------------------------------------

        public ControladorSimulacion(Form1 pantalla)
        {
            this.pantalla = pantalla;
        }
        //-------------------------------------------------
        public void simular()
        {
            contadorInsInapropiadas = 0;
            contadorLlegadas = 0;
            tiempoDeAumentar = 0;

            simulaciones = new List<dynamic[]>();
            Constantes.cantidadHorasSemana = 168;

            contadorCamiones = 0;
            vectorAnterior = new dynamic[94];
            vectorActual = new dynamic[94];

            camiones = new List<Camion>();
            zonas = new List<Zona>();
            Camion.numeracion = 1;// reinicia la numeracion de camiones

            //creacion de las zonas

            Zona zona1 = new Zona(1, "Libre", this, mediaLlegada1, mediaServicio1, desvServicio1);
            Zona zona2 = new Zona(2, "Libre", this, mediaLlegada2, mediaServicio2, desvServicio2);
            Zona zona3 = new Zona(3, "Libre", this, mediaLlegada3, mediaServicio3, desvServicio3);
            Zona zona4 = new Zona(4, "Libre", this, mediaLlegada4, mediaServicio4, desvServicio4);
            Zona zona5 = new Zona(5, "Libre", this, mediaLlegada5, mediaServicio5, desvServicio5);
            Zona zona6 = new Zona(6, "Libre", this, mediaLlegada6, mediaServicio6, desvServicio6);
            Zona zona7 = new Zona(7, "Libre", this, mediaLlegada7, mediaServicio7, desvServicio7);
            Zona zona8 = new Zona(8, "Libre", this, mediaLlegada8, mediaServicio8, desvServicio8);

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
            vectorActual[Constantes.colInsInaproiada] ="-";
            zona1.iniciarZona(vectorActual);
            zona2.iniciarZona(vectorActual);
            zona3.iniciarZona(vectorActual);
            zona4.iniciarZona(vectorActual);
            zona5.iniciarZona(vectorActual);
            zona6.iniciarZona(vectorActual);
            zona7.iniciarZona(vectorActual);
            zona8.iniciarZona(vectorActual);


            if (desde == 0) simulaciones.Add(vectorActual.ToArray());

            vectorAnterior = vectorActual;//esto se hace solo la primera vez para que ande

            //loop principal
            for (int i=1; i<=iteraciones; i++)
            {
                if (contadorCamiones > capacidadMAX && pantalla.NoTieneExceso()) pantalla.cargarExceso();

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

                if (contadorCamiones > capacidadMAX)
                {
                    vectorActual[Constantes.colInsInaproiada] = "SI";
                    contadorInsInapropiadas++;
                }
                else
                {
                    vectorActual[Constantes.colInsInaproiada] = "NO";
                }

                //porcentaje de tiempo en el que las instalaciones son inadecuadas

                double porcentaje = contadorInsInapropiadas * 100 / contadorLlegadas;
                if (tiempoDeAumentar == 0 && porcentaje > 20) tiempoDeAumentar = vectorActual[Constantes.colReloj]; 
                vectorActual[Constantes.colPorcentajeInap] = Truncador.Truncar(porcentaje).ToString()+"%";

                //Actualizo cola general

                vectorActual[Constantes.colColaGeneral] = contadorCamiones;



                //actualizo vectores
                vectorActual[Constantes.colNumeroSimulacion] = i;

                if (i>=desde && i<=hasta) simulaciones.Add(vectorActual.ToArray());
                vectorAnterior = vectorActual;

            }
            

        }

        public double obtenerPorcDeSimulacionParaInsInadecuadas()
        {

            return (contadorInsInapropiadas * 100) / iteraciones;
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
