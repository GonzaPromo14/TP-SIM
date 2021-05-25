using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using TP5_Sistema_Colas.Entidades.Eventos;

namespace TP5_Sistema_Colas.Entidades.Objetos
{
    class Zona
    {
        ControladorSimulacion controlador;
        Camion ocupado_con;
        string estado;
        public string nombre;
        int numero;

        double mediaLlegadas;
        double mediaServicio;
        double desvServicio;

        Random semilla;

        public Zona(int num, string estado, ControladorSimulacion cont, double mediaLlegadas, double mediaServicio, double desvServicio)
        {
            this.controlador = cont;
            this.estado = estado;
            this.nombre = "Zona "+ num.ToString();
            this.mediaLlegadas = mediaLlegadas;
            this.mediaServicio = mediaServicio;
            this.desvServicio = desvServicio;
            this.numero = num;
            this.semilla = new Random();
        }

        public double generarTiempoLlegada()
        {
            double rnd = controlador.vectorAnterior.ElementAt(this.numero)[controlador.colRNDLlegada];
            double tiempoLlegada = Exponential.Sample(semilla, mediaLlegadas);

            return tiempoLlegada;
        }

        public double generarProximaLlegada()
        {
            double reloj = controlador.vectorAnterior.ElementAt(0)[controlador.colReloj]; //busco el tiempo del reloj para sumar
            double tiempo = controlador.vectorAnterior.ElementAt(this.numero)[controlador.colTiempoLlegada];

            return reloj + tiempo;
        }

        public double generarTiempoFinServicio()
        {
            double rnd1 = controlador.vectorAnterior.ElementAt(this.numero)[controlador.colRND1Reparacion];
            double rnd2 = controlador.vectorAnterior.ElementAt(this.numero)[controlador.colRND2Reparacion];
            
            double tiempo = Normal.Sample(semilla, mediaServicio, desvServicio);//esto hay que ver si se cambia

            return tiempo;

        }

        public double generarProximoFinServicio()
        {
            double reloj = controlador.vectorAnterior.ElementAt(0)[controlador.colReloj]; //busco el tiempo del reloj para sumar
            double tiempo = controlador.vectorAnterior.ElementAt(this.numero)[controlador.colTiempoReparacion];

            return reloj + tiempo;
        }


        public dynamic[] iniciarZona()
        {
            dynamic[] vecZona = new dynamic[9];

            vecZona[controlador.colRNDLlegada] = semilla.NextDouble();
            vecZona[controlador.colTiempoLlegada] = Exponential.Sample(semilla, mediaLlegadas); //esto hay que ver si se cambia
            vecZona[controlador.colProximaLlegada] = vecZona[controlador.colTiempoLlegada];

            //creo el camion
            Camion camion = new Camion(vecZona[controlador.colProximaLlegada],"");
            controlador.camiones.Add(camion);

            //creo la primera proxima llegada de la zona
            Evento evento = new Llegada_camion(vecZona[controlador.colProximaLlegada],camion,this);
            controlador.eventos.Enqueue(evento);

            vecZona[controlador.colRND1Reparacion] = "-";
            vecZona[controlador.colRND2Reparacion] = "-";
            vecZona[controlador.colTiempoReparacion] = "-";
            vecZona[controlador.colProximoFinReparacion] = "-";

            vecZona[controlador.colCola] = 0;
            vecZona[controlador.colEstado] = "Libre";

            return vecZona;
        }

    }
}
