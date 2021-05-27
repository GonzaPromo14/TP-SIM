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
        public static int colEvento = 0;
        public static int colReloj = 1;

        //------------- Columnas vector de zonas (hay que aplicar offset para cada zona)

        public static int colRNDLlegada = 2;
        public static int colTiempoLlegada = 3;
        public static int colProximaLlegada = 4;
        public static int colRND1Reparacion = 5;
        public static int colRND2Reparacion = 6;
        public static int colTiempoReparacion = 7;
        public static int colProximoFinReparacion = 8;
        public static int colSeVaAOtraZona = 9;
        public static int colCola = 10;
        public static int colEstado = 11;

        public static int cantidadColumnasZona = 10;

        //------------- Algunos valores esenciales
        public static int cantidadHorasSemana = 168;

        //------------- Columnas Metricas
    }
}
