using System;
using System.Collections.Generic;
using System.Drawing;
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
        //dynamic[][] datos;
        bool ultimaPagina;
        bool primeraPagina;

        public Paginador(List<dynamic[]> datos, int cantItemsPorPag)
        {
            this.cantItemsPorPag = cantItemsPorPag == 0 ? 10 : cantItemsPorPag;
            int cantPaginas = datos.Count / cantItemsPorPag;
            double resto = datos.Count % cantItemsPorPag;
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

        public void obtenerPaginaActual(List<dynamic[]> datos,DataGridView view)
        {
            int final = this.paginaActual * this.cantItemsPorPag;
            int inicio = final - this.cantItemsPorPag;
            int j = 0;
            for (int i = inicio; i < final; i++)
            {
                if (i >= datos.Count)
                {
                    break;
                }
                view.Rows.Add(datos[i]);
                

                if(view.Rows[j].Cells[3].Value == "NO") view.Rows[j].Cells[3].Style.BackColor = Color.LightGreen;
                if(view.Rows[j].Cells[3].Value == "SI") view.Rows[j].Cells[3].Style.BackColor = Color.LightCoral;
                //dgv.Columns[3].DefaultCellStyle.BackColor = Color.LightCoral;

                j++;

            }


            //for (int i = 0; i < 10; i++)
            //{
            //    view.Rows.Add(datos[i]);
            //}

        }

        public void obtenerPaginaAnterior(List<dynamic[]> datos, DataGridView view)
        {
            this.setPaginaActual(this.paginaActual - 1);
            this.obtenerPaginaActual(datos, view);
        }

        public void obtenerPaginaSiguiente(List<dynamic[]> datos, DataGridView view)
        {
            this.setPaginaActual(this.paginaActual + 1);
            this.obtenerPaginaActual(datos, view);
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

        public void irAPagina(List<dynamic[]> datos, DataGridView view, int pagina)
        {
            this.setPaginaActual(pagina);
            this.obtenerPaginaActual(datos, view);
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
