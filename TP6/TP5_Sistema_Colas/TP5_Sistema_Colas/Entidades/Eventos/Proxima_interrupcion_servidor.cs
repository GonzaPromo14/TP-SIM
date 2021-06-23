using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas.Entidades.Eventos
{
    class Proxima_interrupcion_servidor : Evento
    {
        public Proxima_interrupcion_servidor(double tiempo, Zona zona)
        {
            this.zona = zona;
            this.tiempo = tiempo;
        }

        public void ocurrir(ControladorSimulacion controlador)
        {
            controlador.vectorActual[Constantes.colEvento] = "INTERRUPCIÓN (Zona 8)";

            zona.ultimoEstado = zona.estado;
            zona.estado = "Interrumpido";
            controlador.RKPurga.setL(zona.contadorCamiones);

            //cuando la próxima interrupción
            controlador.vectorActual[Constantes.colTiempoFaltanteReparacion] = "-";
            if (controlador.vectorAnterior[Constantes.colProximoFinReparacion + zona.offset] != "-")
                controlador.vectorActual[Constantes.colTiempoFaltanteReparacion] = controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset] - controlador.vectorActual[Constantes.colReloj];
            controlador.vectorActual[Constantes.colEstado + zona.offset] = zona.estado;

            //Generar próximo Fin interrupcion
            controlador.RKPurga.correrRugenKuttaPurga();
            controlador.vectorActual[Constantes.colTiempoPurga] = controlador.RKPurga.vectorActual[Constantes.colTiempo];
            controlador.vectorActual[Constantes.colProximoFinPurga] = controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoPurga];
            Fin_interrupcion proximaFinInterrupcion = new Fin_interrupcion(this.zona, controlador.vectorActual[Constantes.colProximoFinPurga]);
            controlador.eventos.Remove(zona.ultimoServicio);
            controlador.eventos.Enqueue(proximaFinInterrupcion);
        }
    }
}
