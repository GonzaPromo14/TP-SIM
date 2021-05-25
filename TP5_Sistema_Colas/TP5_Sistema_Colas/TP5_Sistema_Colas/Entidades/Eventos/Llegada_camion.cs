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
            this.nombre = "Llegada camion " + "(" + camion.nombre + ")" + "(" + zona.nombre + ")";
            
            this.zona = zona;
            this.camion = camion;
        }

        public override void ocurrir(ControladorSimulacion controlador)
        {
            dynamic[] vecZona = new dynamic[9];

            zona.generarProximaLlegada(vecZona);

            //creo el proximo camion y guardo el evento
            Camion proximoCamion = new Camion(vecZona[Constantes.colProximaLlegada], "");
            controlador.camiones.Add(proximoCamion);

            Evento proximaLlegada = new Llegada_camion(vecZona[Constantes.colProximaLlegada], proximoCamion, zona);
            controlador.eventos.Enqueue(proximaLlegada);

            //si la zona está ocupada mando el camion a la cola sino lo atiendo
            if (zona.estaOcupada()) zona.cola.Enqueue(camion);
            else
            {
                zona.asignarCamion(camion);
                //si el camion llega y pasa a ser atendido creo el proximo fin de servicio y guardo el evento
                zona.generarProximoFinServicio(vecZona);

                Evento proximoFin = new Fin_servicio(vecZona[Constantes.colTiempoReparacion], camion, zona);
                controlador.eventos.Enqueue(proximoFin);
            }

            vecZona[Constantes.colRND1Reparacion] = "-";
            vecZona[Constantes.colRND2Reparacion] = "-";
            vecZona[Constantes.colTiempoReparacion] = "-";
            vecZona[Constantes.colProximoFinReparacion] = "-";



            //cola y estado
            vecZona[Constantes.colCola] = zona.cola.Count();
            vecZona[Constantes.colEstado] = zona.getEstado();

            //actualizo vector
            controlador.vectorActual[zona.numero] = vecZona;
        }

        public override string ToString()
        {
            return "Evento: " + nombre + " | Hora:" + Math.Round(tiempo, 2).ToString();          
        }
    }
}
