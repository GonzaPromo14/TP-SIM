using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Montecarlo
{
    public static class Truncador
    {
        public static double Truncar(double num)
        {
            return Math.Truncate(1000 * num) / 1000;
        }
    }
}
