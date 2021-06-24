﻿using System;
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
        public override void ocurrir(ControladorSimulacion controlador)
        {
            controlador.vectorActual[Constantes.colEvento] = "INTERRUPCIÓN (ZONA 8)";
            zona.ultimoEstado = zona.getEstadoString();
            zona.estado = "Interrumpida";

            controlador.vectorActual[Constantes.colTiempoFaltanteReparacion] = "-";

            if (controlador.vectorAnterior[Constantes.colProximoFinReparacion + zona.offset].ToString() != "-")
            {
                controlador.vectorActual[Constantes.colTiempoFaltanteReparacion] = controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset] - controlador.vectorActual[Constantes.colReloj];
                bool eliminado = controlador.eventos.Remove(zona.ultimoServicio);
                Console.WriteLine(eliminado);
            }
            controlador.vectorActual[Constantes.colEstado + zona.offset] = zona.estado;

            controlador.vectorActual[Constantes.colProximoFinReparacion + zona.offset] = "-";
            controlador.RKPurga.setL(controlador.contadorCamiones);
            controlador.RKPurga.correrRugenKuttaPurga();
            controlador.vectorActual[Constantes.colTiempoPurga] = Truncador.Truncar(controlador.RKPurga.vectorActual[Constantes.colTiempo]);
            controlador.vectorActual[Constantes.colProximoFinPurga] = controlador.vectorActual[Constantes.colReloj] + controlador.vectorActual[Constantes.colTiempoPurga];

            controlador.vectorActual[Constantes.colProximoInestable] = "-";

            //Generar fin de interrupcion
            Fin_interrupcion proximaFinInterrupcion = new Fin_interrupcion(this.zona,controlador.vectorActual[Constantes.colProximoFinPurga]);
            controlador.eventos.Enqueue(proximaFinInterrupcion);

        }

    }
}