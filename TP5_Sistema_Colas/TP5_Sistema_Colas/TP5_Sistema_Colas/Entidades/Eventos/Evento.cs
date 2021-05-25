using Medallion.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas.Entidades.Eventos
{
    class Evento : IComparer<Evento>
    {

        public string nombre;
        public double tiempo;
        public Camion camion;
        public Zona zona;

        public int Compare(Evento x, Evento y)
        {
            return x.tiempo.CompareTo(y.tiempo);
        }

        public virtual void ocurrir(ControladorSimulacion controlador) { }


        class EventoComparador : IComparer<Evento>
        {
            public int Compare(Evento x, Evento y)
            {

                return x.tiempo.CompareTo(y.tiempo);
            }
        }
    }
}
