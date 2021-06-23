using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Sistema_Colas.Entidades
{
    public static class Distribuciones
    {

        public static double Exponencial(double rnd, double media)
        {
            return ((-1) * media) * Math.Log(1 - rnd);
        }

        public static double NormalDist(double rnd1, double rnd2, double media, double desvEstandar)
        {
            double raiz = Math.Sqrt((-2) * Math.Log(rnd1));
            double cos = Math.Cos(2 * Math.PI * rnd2);
            return (raiz * cos * desvEstandar) + media;
        }


        public static decimal calculoProximaPurga(decimal alfa, decimal e)
        {
            return alfa * e;
        }

        public static decimal calculoFinPurga(decimal alfa, decimal e)
        {
            return -alfa * e * (decimal)0.5;
        }

    }
}
