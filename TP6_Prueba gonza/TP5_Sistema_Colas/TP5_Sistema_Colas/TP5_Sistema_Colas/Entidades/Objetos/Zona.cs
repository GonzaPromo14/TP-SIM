using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;
using TP5_Sistema_Colas.Entidades.Eventos;

namespace TP5_Sistema_Colas.Entidades.Objetos
{
    public class Zona
    {
        ControladorSimulacion controlador;
        
        Camion ocupado_con;
        public int offset; //para las columnas

        public List<Camion> cola;
        string estado;
        public string nombre;
        public int numero;
        public int contadorCamiones;


        double mediaLlegadas;
        double mediaServicio;
        double desvServicio;


        public Zona(int num, string estado, ControladorSimulacion cont, double mediaLlegadas, double mediaServicio, double desvServicio)
        {
            this.controlador = cont;
            this.estado = estado;
            this.nombre = "Zona "+ num.ToString();
            this.mediaLlegadas = mediaLlegadas;
            this.mediaServicio = mediaServicio;
            this.desvServicio = desvServicio;
            this.numero = num;
            this.cola = new List<Camion>();
            this.contadorCamiones = 0;


            this.offset = (num - 1) * Constantes.cantidadColumnasZona;
        }

        //actualiza el vector con los random y el tiempo de llegada
        public void generarProximaLlegada(dynamic[] vector)
        {
            double horaReloj = controlador.vectorActual[Constantes.colReloj];
            //semilla = new Random();
            //double rnd = semilla.NextDouble();

            vector[Constantes.colRNDLlegada + offset] = Truncador.Truncar(controlador.semilla.NextDouble());
            vector[Constantes.colTiempoLlegada + offset] = Truncador.Truncar(Distribuciones.Exponencial(vector[Constantes.colRNDLlegada + offset], mediaLlegadas));
            vector[Constantes.colProximaLlegada + offset] = Truncador.Truncar(horaReloj + vector[Constantes.colTiempoLlegada + offset]);

        }

        //actualiza el vector con los random y el tiempo de fin de servicio
        public void generarProximoFinServicio(dynamic[] vector)
        {
            double horaReloj = controlador.vectorActual[Constantes.colReloj];


            vector[Constantes.colRND1Reparacion + offset] = Truncador.Truncar(controlador.semilla.NextDouble());
            vector[Constantes.colRND2Reparacion + offset] = Truncador.Truncar(controlador.semilla.NextDouble());
            double tiempoReparacion = Math.Abs(Truncador.Truncar(Normal.Sample(controlador.semilla, mediaServicio, desvServicio)));
            //vector[Constantes.colTiempoReparacion + offset] = Math.Abs(Truncador.Truncar(Distribuciones.NormalDist(vector[Constantes.colRND1Reparacion + offset], vector[Constantes.colRND2Reparacion + offset], mediaServicio, desvServicio)));
            vector[Constantes.colTiempoReparacion + offset] = tiempoReparacion;//esto hay que ver si se cambia
            vector[Constantes.colProximoFinReparacion + offset] = horaReloj + vector[Constantes.colTiempoReparacion + offset];

            ocupado_con.tiempo_reparacion = tiempoReparacion; 
        }


        public bool estaOcupada()
        {
            return ocupado_con == null ?  false :  true;
        }

        public string getEstado()
        {
            return this.estaOcupada() ? "Ocupada" : "Libre";
        }

        public void asignarCamion(Camion camion)
        {
            this.ocupado_con = camion;
        }

        public bool quedanCamiones()
        {
            return this.cola.Count == 0 ? false : true;
        }

        public void mandarACola(Camion camion)
        {
            if (camion.tienePrioridad) cola.Insert(0, camion); //si tiene prioridad lo agrego al principio de la cola
            else cola.Add(camion);
        }

        public Camion traerDeCola()
        {
            Camion proximo = cola[0];
            cola.RemoveAt(0);

            return proximo;
        }

        public double getMediaLlegadas()
        {
            return this.mediaLlegadas;
        }

        public void aumentarMedia()
        {
            this.mediaLlegadas = mediaLlegadas * 1.0024;

        }

        //Para el vector inicial
        public void iniciarZona(dynamic[] vector)
        {

            generarProximaLlegada(vector);
            //creo el camion
            Camion camion = new Camion(vector[Constantes.colProximaLlegada + offset], "");

            //creo el primer evento proxima llegada de la zona
            Evento evento = new Llegada_camion(vector[Constantes.colProximaLlegada + offset], camion, this);
            controlador.eventos.Enqueue(evento);

            vector[Constantes.colRND1Reparacion + offset] = "-";
            vector[Constantes.colRND2Reparacion + offset] = "-";
            vector[Constantes.colTiempoReparacion + offset] = "-";
            vector[Constantes.colProximoFinReparacion + offset] = "-";

            vector[Constantes.colCola + offset] = 0;
            vector[Constantes.colEstado + offset] = "Libre";
            vector[Constantes.ColTiempoTrabajado + offset] = 0;
        }
    }
}
