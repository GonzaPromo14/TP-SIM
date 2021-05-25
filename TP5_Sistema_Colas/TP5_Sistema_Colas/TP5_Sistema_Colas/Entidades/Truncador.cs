using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Sistema_Colas.Entidades
{
    public static class Truncador
    {
        public static double Truncar(double num)
        {
            return Math.Truncate(100 * num) / 100;
        }
    }
}
