using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas.Entidades.Eventos
{
    class Fin_interrupcion : Evento
    {
        public Fin_interrupcion(Zona zona, double tiempo)
        {
            this.zona = zona;
            this.tiempo = tiempo;

        }


        public override void ocurrir(ControladorSimulacion controlador)
        {
            zona.estado = zona.ultimoEstado;
            controlador.vectorActual[Constantes.colEvento] = "FIN INTERRUPCIÓN (Zona 8)";
            if (zona.estado == "Libre" && zona.quedanCamiones())
            {
                Camion proximoCamion = zona.traerDeCola();

                zona.asignarCamion(proximoCamion);
                proximoCamion.setEstado("Siendo reparado");
                //camion.tiempo_espera = controlador.vectorActual[Constantes.colReloj] - camion.hora_llegada;
                proximoCamion.tiempo_espera = controlador.vectorActual[Constantes.colReloj] - proximoCamion.hora_llegada;
                zona.generarProximoFinServicio(controlador.vectorActual);

                Evento proximoFin = new Fin_servicio(controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset], proximoCamion, zona);
                controlador.eventos.Enqueue(proximoFin);
                zona.ultimoServicio = proximoFin;
                zona.estado = "Ocupada";
            }
            else if (zona.estado == "Ocupada" && controlador.vectorActual[Constantes.colTiempoFaltanteReparacion].ToString() != "-")
            {
                Fin_servicio nuevoFinServicio = new Fin_servicio(controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoFaltanteReparacion], zona.ultimoServicio.camion, zona);
                controlador.eventos.Enqueue(nuevoFinServicio);
                zona.ultimoServicio = nuevoFinServicio;
                controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset] = controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoFaltanteReparacion];
            }
            controlador.vectorActual[Constantes.colEstado + zona.offset] = zona.estado;
            controlador.vectorActual[Constantes.colTiempoFaltanteReparacion] = "-";
            controlador.vectorActual[Constantes.colRndRK] = Truncador.Truncar(controlador.semilla.NextDouble());
            controlador.vectorActual[Constantes.colTiempoInestable] = Truncador.Truncar(controlador.RKInestable.valorTRandom(controlador.vectorActual[Constantes.colRndRK]));
            controlador.vectorActual[Constantes.colProximoInestable] = controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoInestable];
            Proxima_interrupcion_servidor proximaInterrupcionServidor = new Proxima_interrupcion_servidor(controlador.vectorActual[Constantes.colProximoInestable], zona);
            controlador.eventos.Enqueue(proximaInterrupcionServidor);
            controlador.vectorActual[Constantes.colProximoFinPurga] = "-";
        }


    }
}
