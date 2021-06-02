using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Sistema_Colas.Entidades.Objetos
{
    public class Camion
    {
        public static int numeracion = 0;
        public string estado;
        public string nombre;
        public double hora_llegada;
        public double hora_salida;
        public double tiempo_reparacion;
        public double tiempo_espera;
        public bool tienePrioridad;
        public string zonasPasadas = "";

        public Camion(double hora_llegada, string estado)
        {
            this.estado = estado;
            this.nombre = "C";
            this.hora_llegada = hora_llegada;
            this.tienePrioridad = false;
            this.tiempo_espera = 0;
            this.tiempo_reparacion = 0;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }
    }
}
