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
            Console.WriteLine("############# Ocurre llegada  ###########");

            //genero una proxima llegada y un proximo fin de servicio, cambio solo la parte de esta zona
            dynamic[] vecZona = new dynamic[9];


            //vecZona[controlador.colRNDLlegada] =


            // tiempoFin = this.zona.generarProximoFinServicio();

            // proximoFin = new Fin_servicio();

            //veo si hay cola o no para poner el estado del camion



        }

        public override string ToString()
        {
            return "Evento: " + nombre + " | Hora:" + Math.Round(tiempo, 2).ToString();          
        }
    }
}
