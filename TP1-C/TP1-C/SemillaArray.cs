using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_C
{
    class SemillaArray
    {
        private int initialCapacity;
        private int count;
        Semilla[] arraySemilla;

        public SemillaArray(int initialCapacity)
        {
            if (initialCapacity == 0)
            {
                initialCapacity = 20;
            }
            arraySemilla = new Semilla[initialCapacity];
            this.initialCapacity = initialCapacity;
            this.count = 0;
        }

        public void ensureCapacity(int minCapacity)
        {
            if (minCapacity == arraySemilla.Length) return;
            if (minCapacity < count) return;
            Semilla[] temp = new Semilla[minCapacity];
            Array.Copy(arraySemilla, 0, temp, 0, count);
            arraySemilla = temp;
        }

        public Boolean add (Semilla s)
        {
            if (s == null) return false;
            if (count == arraySemilla.Length) this.ensureCapacity(arraySemilla.Length * 2);
            arraySemilla[count] = s;
            count++;
            return true;
        }

        public void clear()
        {
            arraySemilla = new Semilla[initialCapacity];
            count = 0;
        }

        public Semilla get(int index)
        {
            return arraySemilla[index];
        }

        public int size()
        {
            return this.count;
        }

        public double getRandom(int index)
        {
            return arraySemilla[index].getValorAleatorioGenerado();
        }

    }
}
