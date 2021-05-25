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
        public Queue<Camion> cola;

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
            this.cola = new Queue<Camion>();
        }

        public void generarProximaLlegada(dynamic[] vecZona)
        {
            vecZona[Constantes.colRNDLlegada] = semilla.NextDouble();
            vecZona[Constantes.colTiempoLlegada] = Exponential.Sample(semilla, mediaLlegadas); //esto hay que ver si se cambia
            vecZona[Constantes.colProximaLlegada] = vecZona[Constantes.colTiempoLlegada];

        }

        public void generarProximoFinServicio(dynamic[] vecZona)
        {
            double horaReloj = controlador.vectorActual.ElementAt(0)[Constantes.colEvento];

            vecZona[Constantes.colRND1Reparacion] = semilla.NextDouble();
            vecZona[Constantes.colRND2Reparacion] = semilla.NextDouble();
            vecZona[Constantes.colTiempoReparacion] = Normal.Sample(semilla,mediaServicio,desvServicio);//esto hay que ver si se cambia
            vecZona[Constantes.colProximoFinReparacion] = horaReloj + vecZona[Constantes.colTiempoReparacion];
        }

        public bool estaOcupada()
        {
            return ocupado_con == null ?  false :  true;
        }

        public string getEstado()
        {
            return this.estaOcupada() ? "Ocupada" : "Libre";
        }

        public void asignarCamion(Camion camion)
        {
            this.ocupado_con = camion;
        }

        public dynamic[] iniciarZona()
        {
            dynamic[] vecZona = new dynamic[9];

            generarProximaLlegada(vecZona);
            //creo el camion
            Camion camion = new Camion(vecZona[Constantes.colProximaLlegada], "");
            controlador.camiones.Add(camion);

            //creo el primer evento proxima llegada de la zona
            Evento evento = new Llegada_camion(vecZona[Constantes.colProximaLlegada], camion, this);
            controlador.eventos.Enqueue(evento);

            vecZona[Constantes.colRND1Reparacion] = "-";
            vecZona[Constantes.colRND2Reparacion] = "-";
            vecZona[Constantes.colTiempoReparacion] = "-";
            vecZona[Constantes.colProximoFinReparacion] = "-";

            vecZona[Constantes.colCola] = 0;
            vecZona[Constantes.colEstado] = "Libre";

            return vecZona;
        }

    }
}
