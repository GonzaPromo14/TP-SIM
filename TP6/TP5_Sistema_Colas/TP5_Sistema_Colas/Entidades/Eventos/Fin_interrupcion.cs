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

        public void ocurrir(ControladorSimulacion controlador)
        {
            zona.estado = zona.ultimoEstado;
            controlador.vectorActual[Constantes.colEvento] = "FIN INTERRUPCIÓN (Zona 8)";
            Fin_servicio nuevoFinServicio = new Fin_servicio(controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoFaltanteReparacion], zona.ultimoServicio.camion, zona);
            controlador.eventos.Enqueue(nuevoFinServicio);
            controlador.vectorActual[Constantes.colTiempoFaltanteReparacion] = "-";
            controlador.vectorActual[Constantes.colRndRK] = Truncador.Truncar(controlador.semilla.NextDouble());
            controlador.vectorActual[Constantes.colTiempoInestable] = controlador.RKInestable.valorTRandom(controlador.vectorActual[Constantes.colRndRK]);
            controlador.vectorActual[Constantes.colProximoInestable] = controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoInestable];
            Proxima_interrupcion_servidor proximaInterrupcionServidor = new Proxima_interrupcion_servidor(controlador.vectorActual[Constantes.colProximoInestable], zona);
            controlador.eventos.Enqueue(proximaInterrupcionServidor);

        }
    }
}
