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

        public Fin_servicio(double tiempo, Camion camion, Zona zona)
        {
            this.tiempo = tiempo;
            this.camion = camion;
            this.zona = zona;
            this.nombre = "Fin servicio " + "(" + camion.nombre + ")" + "(" + zona.nombre + ")";

        }

        public override void ocurrir(ControladorSimulacion controlador)
        {

            dynamic vecZona = controlador.vectorActual[zona.numero];

            vecZona[Constantes.colRNDLlegada] = "-";
            vecZona[Constantes.colTiempoLlegada] = "-";

            //hago pasar al proximo camion si no hay ninguno cambio estado a libre
            if (zona.quedanCamiones())
            {
                Camion proximoCamion = zona.cola.Dequeue();
                zona.asignarCamion(proximoCamion);

                zona.generarProximoFinServicio(vecZona);

                Evento proximoFin = new Fin_servicio(vecZona[Constantes.colProximoFinReparacion], proximoCamion, zona);
                controlador.eventos.Enqueue(proximoFin);
            }
            else
            {
                zona.asignarCamion(null);
                //no hay proxima reparacion
                vecZona[Constantes.colRND1Reparacion] = "-";
                vecZona[Constantes.colRND2Reparacion] = "-";
                vecZona[Constantes.colTiempoReparacion] = "-";
                vecZona[Constantes.colProximoFinReparacion] = "-";

            }

            //cola y estado
            vecZona[Constantes.colCola] = zona.cola.Count();
            vecZona[Constantes.colEstado] = zona.getEstado();

            //veo si tiene que entrar en otra zona

            //actualizo vector
            controlador.vectorActual[zona.numero] = vecZona;
        }

        public override string ToString()
        {
            return "Evento: " + nombre + " | Hora:" + Math.Round(tiempo, 2).ToString();
        }
    }
}
