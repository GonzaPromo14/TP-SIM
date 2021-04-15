using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.DataLayer
{
    class ArrayRnd
    {
        private int initialCapacity;
        private int count;
        ValorGenerado[] valorGenerado;

        public ArrayRnd(int initialCapacity)
        {
            initialCapacity = initialCapacity == 0 ? 20 : initialCapacity;
            this.valorGenerado = new ValorGenerado[initialCapacity];
            this.initialCapacity = initialCapacity;
            this.count = 0;
        }

        public void ensureCapacity(int minCapacity)
        {
            if (minCapacity == valorGenerado.Length) return;
            if (minCapacity < count) return;
            ValorGenerado[] temp = new ValorGenerado[minCapacity];
            Array.Copy(valorGenerado, 0, temp, 0, count);
            valorGenerado = temp;
        }

        public Boolean add(ValorGenerado v)
        {
            if (v == null) return false;
            if (count == valorGenerado.Length) this.ensureCapacity(valorGenerado.Length * 2);
            valorGenerado[count] = v;
            count++;
            return true;
        }

        public void clear()
        {
            valorGenerado = new ValorGenerado[initialCapacity];
            count = 0;
        }

        public ValorGenerado get(int index)
        {
            return valorGenerado[index];
        }

        public int size()
        {
            return this.count;
        }



    }
}
