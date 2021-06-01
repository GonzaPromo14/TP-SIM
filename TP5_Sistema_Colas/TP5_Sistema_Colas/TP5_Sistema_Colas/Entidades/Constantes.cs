using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Sistema_Colas.Entidades
{
    static class Constantes
    {
        //------------- Columnas vector reloj evento
        public static int colNumeroSimulacion = 0;
        public static int colEvento = 1;
        public static int colReloj = 2;

        //------------- Columnas vector de zonas (hay que aplicar offset para cada zona)

        public static int colRNDLlegada = 3;
        public static int colTiempoLlegada = 4;
        public static int colProximaLlegada = 5;
        public static int colRND1Reparacion = 6;
        public static int colRND2Reparacion = 7;
        public static int colTiempoReparacion = 8;
        public static int colProximoFinReparacion = 9;
        public static int colSeVaAOtraZona = 10;
        public static int colCola = 11;
        public static int colEstado = 12;

        public static int cantidadColumnasZona = 10;

        //------------- Algunos valores esenciales
        public static int cantidadHorasSemana = 168;

        //------------- Columnas Metricas
    }
}
