using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_Sistema_Colas.Entidades
{
    class Paginador
    {
        int paginaActual;
        int cantPaginas;
        int cantItemsPorPag;
        double[][] datos;
        bool ultimaPagina;
        bool primeraPagina;

        public Paginador(double[][] datos, int cantItemsPorPag)
        {
            this.datos = datos;
            this.cantItemsPorPag = cantItemsPorPag == 0 ? 10 : cantItemsPorPag;
            int cantPaginas = datos.Length / cantItemsPorPag;
            double resto = datos.Length % cantItemsPorPag;
            if (resto != 0)
            {
                cantPaginas++;
                this.cantPaginas = cantPaginas;
            }
            this.cantPaginas = cantPaginas;
            this.paginaActual = 1;
            this.primeraPagina = true;
            this.ultimaPagina = false;
        }

        public void obtenerPaginaActual(DataGridView view)
        {
            int final = this.paginaActual * this.cantItemsPorPag;
            int inicio = final - this.cantItemsPorPag;
            for (int i = inicio; i < final; i++)
            {
                if (i >= datos.Length)
                {
                    break;
                }
                view.Rows.Add(new string[] {
                    datos[i][0].ToString(),
                    Truncador.Truncar(datos[i][1]).ToString(),
                    datos[i][2].ToString(),
                    datos[i][3].ToString(),
                    datos[i][4].ToString(),
                    Truncador.Truncar(datos[i][5]).ToString(),
                    datos[i][6].ToString(),
                    datos[i][7].ToString(),
                    Truncador.Truncar(datos[i][8]).ToString(),
                    Truncador.Truncar(datos[i][9]).ToString(),
                    datos[i][10].ToString(),
                    datos[i][11].ToString(),
                    Truncador.Truncar(datos[i][12]).ToString(),
                    datos[i][13].ToString(),
                    datos[i][14].ToString(),
                    Truncador.Truncar(datos[i][15]).ToString()


                });
            }

        }

        public void obtenerPaginaAnterior(DataGridView view)
        {
            this.setPaginaActual(this.paginaActual - 1);
            this.obtenerPaginaActual(view);
        }

        public void obtenerPaginaSiguiente(DataGridView view)
        {
            this.setPaginaActual(this.paginaActual + 1);
            this.obtenerPaginaActual(view);
        }

        public void setPaginaActual(int pagina)
        {
            this.paginaActual = pagina;
            if (this.paginaActual == cantPaginas)
            {
                this.primeraPagina = false;
                this.ultimaPagina = true;
            }
            else if (this.paginaActual == 1)
            {
                this.primeraPagina = true;
                this.ultimaPagina = false;
            }
            else
            {
                this.primeraPagina = false;
                this.ultimaPagina = false;
            }
        }

        public bool esUltimaPagina()
        {
            return this.ultimaPagina;
        }

        public bool esPaginaPrimera()
        {
            return this.primeraPagina;
        }

        public void irAPagina(DataGridView view, int pagina)
        {
            this.setPaginaActual(pagina);
            this.obtenerPaginaActual(view);
        }

        public int getCantPaginas()
        {
            return this.cantPaginas;
        }

        public int getPaginaActual()
        {
            return this.paginaActual;
        }
    }
}
