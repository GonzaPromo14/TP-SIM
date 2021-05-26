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
        public int offset; //para las columnas

        string estado;
        public string nombre;
        public int numero;

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

            this.offset = (num - 1) * 9;
        }

        /*
        public void generarProximaLlegada(dynamic[] vecZona)
        {
            double horaReloj = controlador.vectorActual.ElementAt(0)[Constantes.colReloj];

            vecZona[Constantes.colRNDLlegada] = Truncador.Truncar(semilla.NextDouble());
            vecZona[Constantes.colTiempoLlegada] = Truncador.Truncar(Exponential.Sample(semilla, mediaLlegadas)); //esto hay que ver si se cambia
            vecZona[Constantes.colProximaLlegada] = Truncador.Truncar(horaReloj + vecZona[Constantes.colTiempoLlegada]);

        }

        */

        public void generarProximaLlegada(dynamic[] vector)
        {
            double horaReloj = controlador.vectorActual[Constantes.colReloj];

            vector[Constantes.colRNDLlegada + offset] = Truncador.Truncar(semilla.NextDouble());
            vector[Constantes.colTiempoLlegada + offset] = Truncador.Truncar(Exponential.Sample(semilla, mediaLlegadas)); //esto hay que ver si se cambia
            vector[Constantes.colProximaLlegada + offset] = Truncador.Truncar(horaReloj + vector[Constantes.colTiempoLlegada + offset]);

        }
        /*
        public void generarProximoFinServicio(dynamic[] vecZona)
        {
            double horaReloj = controlador.vectorActual.ElementAt(0)[Constantes.colReloj];

            vecZona[Constantes.colRND1Reparacion] = Truncador.Truncar(semilla.NextDouble());
            vecZona[Constantes.colRND2Reparacion] = Truncador.Truncar(semilla.NextDouble());
            vecZona[Constantes.colTiempoReparacion] = Truncador.Truncar(Normal.Sample(semilla,mediaServicio,desvServicio));//esto hay que ver si se cambia
            vecZona[Constantes.colProximoFinReparacion] = horaReloj + vecZona[Constantes.colTiempoReparacion];
        }
        */
        public void generarProximoFinServicio(dynamic[] vector)
        {
            double horaReloj = controlador.vectorActual[Constantes.colReloj];

            vector[Constantes.colRND1Reparacion + offset] = Truncador.Truncar(semilla.NextDouble());
            vector[Constantes.colRND2Reparacion + offset] = Truncador.Truncar(semilla.NextDouble());
            vector[Constantes.colTiempoReparacion + offset] = Truncador.Truncar(Normal.Sample(semilla, mediaServicio, desvServicio));//esto hay que ver si se cambia
            vector[Constantes.colProximoFinReparacion + offset] = horaReloj + vector[Constantes.colTiempoReparacion + offset];
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

        public bool quedanCamiones()
        {
            return this.cola.Count == 0 ? false : true;
        }

        /*
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
        */

        public void iniciarZona(dynamic[] vector)
        {

            generarProximaLlegada(vector);
            //creo el camion
            Camion camion = new Camion(vector[Constantes.colProximaLlegada + offset], "");
            controlador.camiones.Add(camion);

            //creo el primer evento proxima llegada de la zona
            Evento evento = new Llegada_camion(vector[Constantes.colProximaLlegada + offset], camion, this);
            controlador.eventos.Enqueue(evento);

            vector[Constantes.colRND1Reparacion + offset] = "-";
            vector[Constantes.colRND2Reparacion + offset] = "-";
            vector[Constantes.colTiempoReparacion + offset] = "-";
            vector[Constantes.colProximoFinReparacion + offset] = "-";

            vector[Constantes.colCola + offset] = 0;
            vector[Constantes.colEstado + offset] = "Libre";
        }
    }
}
