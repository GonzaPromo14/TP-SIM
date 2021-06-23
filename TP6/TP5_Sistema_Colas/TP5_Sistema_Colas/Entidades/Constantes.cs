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
        public static int colInsInaproiada = 3;
        public static int colCantTotalCamiones = 4;
        public static int colPorcentajeInap = 5;


        //------------- Columnas vector de zonas (hay que aplicar offset para cada zona)

        public static int colRNDLlegada = 6;
        public static int colTiempoLlegada = 7;
        public static int colProximaLlegada = 8;
        public static int colRND1Reparacion = 9;
        public static int colRND2Reparacion = 10;
        public static int colTiempoReparacion = 11;
        public static int colProximoFinReparacion = 12;
        public static int colSeVaAOtraZona = 13;
        public static int colCola = 14;
        public static int colEstado = 15;
        public static int ColTiempoTrabajado = 16;

        //Para purga
        public static int colTiempoFaltanteReparacion = 94;
        public static int colRndRK = 95;
        public static int colTiempoInestable = 96;
        public static int colProximoInestable = 97;
        public static int colTiempoPurga = 98;
        public static int colProximoFinPurga = 99;

        public static int cantidadColumnasZona = 11;

        //------------- Algunos valores esenciales
        public static int cantidadHorasSemana = 168;

        //------------- Columnas Rugen kutta
        public static int colTiempo = 0;
        public static int colE = 1;
        public static int colK1 = 2;
        public static int colTiempoK2 = 3;
        public static int colEK2 = 4;
        public static int colK2 = 5;
        public static int colTiempoK3 = 6;
        public static int colEK3 = 7;
        public static int colK3 = 8;
        public static int colTiempoK4 = 9;
        public static int colEK4 = 10;
        public static int colK4 = 11;
        public static int colL1L0 = 12;

    }
}
