using Medallion.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas.Entidades.Eventos
{
    class Llegada_camion : Evento
    {

        public Llegada_camion(double tiempo, Camion camion, Zona zona)
        {
            this.tiempo = tiempo;
            this.zona = zona;
            this.camion = camion;
        }

        public override void ocurrir(ControladorSimulacion controlador)
        {
            //actualizo contador y nombre del camion
            if (!camion.tienePrioridad)//si no viene de otra zona, es un camion nuevo, lo agrego a la lista
            {
                camion.hora_llegada = controlador.vectorActual[Constantes.colReloj];
                camion.nombre += Camion.numeracion.ToString();
                
                controlador.camiones.Add(camion);
                controlador.contadorCamiones++;
                Camion.numeracion++;

            }

            controlador.vectorActual[Constantes.colEvento] = "Llegada camion " + "(" + camion.nombre + ")" + "(" + zona.nombre + ")";

            camion.zonasPasadas += "("+zona.nombre+")";


            //actualizo el vector con los tiempos de proxima llegada
            zona.generarProximaLlegada(controlador.vectorActual);

            //creo la proxima llegada
            Camion proximoCamion = new Camion(controlador.vectorActual[Constantes.colProximaLlegada + zona.offset], "");

            Evento proximaLlegada = new Llegada_camion(controlador.vectorActual[Constantes.colProximaLlegada+zona.offset], proximoCamion, zona);
            controlador.eventos.Enqueue(proximaLlegada);

            //si la zona está ocupada mando el camion a la cola, sino lo atiendo
            if (zona.estaOcupada())
            {
                zona.mandarACola(camion);
                controlador.vectorActual[Constantes.colRND1Reparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colRND2Reparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colTiempoReparacion+ zona.offset] = "-";
            }
            else
            {
                zona.asignarCamion(camion);
                //si el camion llega y pasa a ser atendido creo el proximo fin de servicio y guardo el evento
                zona.generarProximoFinServicio(controlador.vectorActual);

                Evento proximoFin = new Fin_servicio(controlador.vectorActual[Constantes.colProximoFinReparacion+zona.offset], camion, zona);
                controlador.eventos.Enqueue(proximoFin);
            }


            controlador.vectorActual[Constantes.colSeVaAOtraZona + zona.offset] = "-";
            //cola y estado
            controlador.vectorActual[Constantes.colCola + zona.offset] = zona.cola.Count();
            controlador.vectorActual[Constantes.colEstado+ zona.offset] = zona.getEstado();
        }

        public override string ToString()
        {
            return "Evento: " + nombre + " | Hora:" + Math.Round(tiempo, 2).ToString();          
        }
    }
}
