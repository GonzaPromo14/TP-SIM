﻿using Medallion.Collections;
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

        public Fin_servicio(double tiempo, Camion camion)
        {

        }

        public override void ocurrir(ControladorSimulacion controlador)
        {
            throw new NotImplementedException();
        }
    }
}
