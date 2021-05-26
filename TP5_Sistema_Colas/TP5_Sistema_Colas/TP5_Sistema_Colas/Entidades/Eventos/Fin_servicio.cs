using Medallion.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas.Entidades.Eventos
{
    class Fin_servicio : Evento
    {
        Random rand = new Random();
        public Fin_servicio(double tiempo, Camion camion, Zona zona)
        {
            this.tiempo = tiempo;
            this.camion = camion;
            this.zona = zona;
            this.nombre = "Fin servicio " + "(" + camion.nombre + ")" + "(" + zona.nombre + ")";
          
        }

        public override void ocurrir(ControladorSimulacion controlador)
        {

            controlador.vectorActual[Constantes.colRNDLlegada + zona.offset] = "-";
            controlador.vectorActual[Constantes.colTiempoLlegada + zona.offset] = "-";

            //veo si el camion se va a ir a otra zona
            double prob = rand.NextDouble();
            if (prob >= 0.8 && prob < 1)
            {
                //elijo la proxima zona, viendo que no sea la misma 
                int index = rand.Next(controlador.zonas.Count);
                Zona proximaZona = controlador.zonas[index];

                if(index + 1 == zona.numero)
                {
                    while(index + 1 == zona.numero)
                    {
                        index = rand.Next(controlador.zonas.Count);
                        proximaZona = controlador.zonas[index];
                    }
                }


                //le asigno prioridad al camion para que vaya al principio
                camion.tienePrioridad = true;
                 
                //hago un evento llegada_camion con este camion a la proxima zona y con la hora actual (la llegada es instantanea)
                Evento llegadaCamionZonaNueva = new Llegada_camion(controlador.vectorActual[Constantes.colReloj], camion, proximaZona);
                controlador.eventos.Enqueue(llegadaCamionZonaNueva);

                controlador.vectorActual[Constantes.colSeVaAOtraZona + zona.offset] = camion.nombre+ " se fue a: " + proximaZona.nombre;

            }

            //hago pasar al proximo camion y calculo su proximo fin de servicio, si no hay ninguno asigno null a la zona y eso cambia el estado a libre
            if (zona.quedanCamiones())
            {
                Camion proximoCamion = zona.traerDeCola();

                zona.asignarCamion(proximoCamion);

                zona.generarProximoFinServicio(controlador.vectorActual);

                Evento proximoFin = new Fin_servicio(controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset], proximoCamion, zona);
                controlador.eventos.Enqueue(proximoFin);
            }
            else
            {
                zona.asignarCamion(null);
                //no hay proxima reparacion
                controlador.vectorActual[Constantes.colRND1Reparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colRND2Reparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colTiempoReparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset] = "-";

            }

            //cola y estado
            controlador.vectorActual[Constantes.colCola + zona.offset] = zona.cola.Count();
            controlador.vectorActual[Constantes.colEstado +zona.offset] = zona.getEstado();

        }

        public override string ToString()
        {
            return "Evento: " + nombre + " | Hora:" + Math.Round(tiempo, 2).ToString();
        }
    }
}
