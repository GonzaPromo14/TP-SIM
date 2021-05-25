using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Sistema_Colas.Entidades.Objetos
{
    class Camion
    {
        public static int contador = 1;
        public string estado;
        public string nombre;
        public double hora_llegada;
        public double hora_salida;
        public bool tienePrioridad;

        public Camion(double hora_llegada, string estado)
        {
            this.estado = estado;
            this.nombre = "C" + contador.ToString();
            this.hora_llegada = hora_llegada;
            this.tienePrioridad = false;
            contador += 1;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }
    }
}
