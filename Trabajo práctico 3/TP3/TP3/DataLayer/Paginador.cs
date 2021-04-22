using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3.DataLayer
{
    class Paginador
    {
        int paginaActual;
        int cantPaginas;
        int cantItemsPorPag;
        List <ValorGenerado> valoresGenerados;
        bool ultimaPagina;
        bool primeraPagina;

		public Paginador(List<ValorGenerado> valoresGenerados, int cantItemsPorPag)
        {
            this.valoresGenerados = valoresGenerados;
			this.cantItemsPorPag = cantItemsPorPag == 0 ? 10 : cantItemsPorPag;
            int cantPaginas = valoresGenerados.Count / cantItemsPorPag;
            double resto = valoresGenerados.Count % cantItemsPorPag;
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
				if (i >= valoresGenerados.Count)
                {
                    break;
                }
                view.Rows.Add(valoresGenerados[i].convertirStringData());
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
