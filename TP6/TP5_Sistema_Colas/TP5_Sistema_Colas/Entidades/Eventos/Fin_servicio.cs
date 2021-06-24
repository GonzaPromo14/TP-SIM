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
          
        }

        public override void ocurrir(ControladorSimulacion controlador)
        {
            bool seFueAOtraZona = false; // para manejar el contador

            camion.zonasPosibles[zona.numero - 1] = 0; //setteo a 0 para decir que ya no puede ir a esa zona
            camion.zonasPosiblesContador--;

            controlador.vectorActual[Constantes.colEvento] = "Fin servicio " + "(" + camion.nombre + ")" + "(" + zona.nombre + ")";
            controlador.vectorActual[Constantes.colRNDLlegada + zona.offset] = "-";
            controlador.vectorActual[Constantes.colTiempoLlegada + zona.offset] = "-";

            if(camion.zonasPosiblesContador != 0)
            {
                //veo si el camion se va a ir a otra zona
                double prob = rand.NextDouble();

                if (prob >= 0.8 && prob < 1)
                {
                    int index = 0;
                    //elijo la proxima zona, viendo que no sea la misma 
                    while (index == 0)
                    {
                        rand = new Random();
                        int i = rand.Next(7);
                        index = camion.zonasPosibles[i];
                    }

                    Zona proximaZona = controlador.zonas[index - 1];

                    //le asigno prioridad al camion para que vaya al principio
                    camion.tienePrioridad = true;

                    //hago un evento llegada_camion con este camion a la proxima zona y con la hora actual (la llegada es instantanea)
                    Evento llegadaCamionZonaNueva = new Llegada_camion(controlador.vectorActual[Constantes.colReloj], camion, proximaZona);
                    controlador.eventos.Enqueue(llegadaCamionZonaNueva);

                    //para que no se cuente este evento como un nuevo camion
                    seFueAOtraZona = true;
                    controlador.contadorCamiones--;
                    zona.contadorCamiones++;
                    controlador.vectorActual[Constantes.colSeVaAOtraZona + zona.offset] = camion.nombre + " se fue a: " + proximaZona.nombre;
                    controlador.vectorActual[Constantes.ColTiempoTrabajado + zona.offset] += camion.tiempo_reparacion;
                    camion.tiempo_reparacion = 0;
                }
            }


            if (!seFueAOtraZona) // si no se fue a otra zona, se fue del predio
            {
                controlador.contadorCamiones--;
                zona.contadorCamiones++;
                camion.hora_salida = controlador.vectorActual[Constantes.colReloj];
                controlador.vectorActual[Constantes.ColTiempoTrabajado + zona.offset] += camion.tiempo_reparacion;
                camion.setEstado("Reparacion Finalizada");
            }

            //hago pasar al proximo camion y calculo su proximo fin de servicio, si no hay ninguno asigno null a la zona y eso cambia el estado a libre
            if (zona.quedanCamiones())
            {
                Camion proximoCamion = zona.traerDeCola();

                zona.asignarCamion(proximoCamion);
                proximoCamion.setEstado("Siendo reparado");
                proximoCamion.tiempo_espera = controlador.vectorActual[Constantes.colReloj] - camion.hora_llegada;
                zona.generarProximoFinServicio(controlador.vectorActual);

                Evento proximoFin = new Fin_servicio(controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset], proximoCamion, zona);
                controlador.eventos.Enqueue(proximoFin);
                zona.ultimoServicio = proximoFin;
            }
            else
            {
                zona.asignarCamion(null);
                zona.estado = "Libre";
                //no hay proxima reparacion
                controlador.vectorActual[Constantes.colRND1Reparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colRND2Reparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colTiempoReparacion + zona.offset] = "-";
                controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset] = "-";
            }

            //cola y estado
            controlador.vectorActual[Constantes.colCola + zona.offset] = zona.cola.Count();
            controlador.vectorActual[Constantes.colEstado +zona.offset] = zona.getEstadoString();
            controlador.vectorActual[Constantes.colRndRK] = "-";
            controlador.vectorActual[Constantes.colTiempoInestable] = "-";
            controlador.vectorActual[Constantes.colTiempoPurga] = "-";

        }

        public override string ToString()
        {
            return "Evento: " + nombre + " | Hora:" + Math.Round(tiempo, 2).ToString();
        }
    }
}
