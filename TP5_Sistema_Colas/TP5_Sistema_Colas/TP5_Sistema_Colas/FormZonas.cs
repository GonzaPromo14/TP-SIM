﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP5_Sistema_Colas.Entidades;
using TP5_Sistema_Colas.Entidades.Objetos;

namespace TP5_Sistema_Colas
{
    public partial class FormZonas : Form
    {
        ControladorSimulacion controlador;
        public FormZonas(ControladorSimulacion controlador)
        {
            InitializeComponent();
            this.controlador = controlador;

            cargarGrilla();
        }

        public void cargarGrilla()
        {
            
            DataGridViewProgressColumn columnaPorcentaje = new DataGridViewProgressColumn();
            columnaPorcentaje.HeaderText = "Porcentaje ocupacion actual";
            columnaPorcentaje.Name = "colPorcentaje";

            dgvZonas.Columns.Add(columnaPorcentaje);
            dgvZonas.Columns["colPorcentaje"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            double cantidadCamiones = (double)controlador.contadorCamiones;

            foreach (Zona zona in controlador.zonas)
            {
                double cantCola = (double)controlador.vectorActual[Constantes.colCola + zona.offset];
                if (zona.estaOcupada()) cantCola++;

                double porcentaje = cantCola * 100 / cantidadCamiones;

                object[] linea = { zona.nombre, zona.getEstado(), cantCola,zona.getMediaLlegadas(), zona.contadorCamiones, porcentaje };

                dgvZonas.Rows.Add(linea);
            }

            

        }

        private void dgvZonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class DataGridViewProgressColumn : DataGridViewImageColumn
    {
        public DataGridViewProgressColumn()
        {
            CellTemplate = new DataGridViewProgressCell();
        }
    }

    class DataGridViewProgressCell : DataGridViewImageCell
    {
        // Used to make custom cell consistent with a DataGridViewImageCell
        static Image emptyImage;
        static DataGridViewProgressCell()
        {
            emptyImage = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }
        public DataGridViewProgressCell()
        {
            this.ValueType = typeof(int);
        }
        // Method required to make the Progress Cell consistent with the default Image Cell. 
        // The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
        protected override object GetFormattedValue(object value,
                            int rowIndex, ref DataGridViewCellStyle cellStyle,
                            TypeConverter valueTypeConverter,
                            TypeConverter formattedValueTypeConverter,
                            DataGridViewDataErrorContexts context)
        {
            return emptyImage;
        }
        
        protected override void Paint(System.Drawing.Graphics g, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            try
            {
                int progressVal = Convert.ToInt32(value);
                float percentage = ((float)progressVal / 100.0f); // Need to convert to float before division; otherwise C# returns int which is 0 for anything but 100%.
                Brush backColorBrush = new SolidBrush(cellStyle.BackColor);
                Brush foreColorBrush = new SolidBrush(cellStyle.ForeColor);
                // Draws the cell grid
                base.Paint(g, clipBounds, cellBounds,
                 rowIndex, cellState, value, formattedValue, errorText,
                 cellStyle, advancedBorderStyle, (paintParts & ~DataGridViewPaintParts.ContentForeground));
                if (percentage > 0.0)
                {
                    // Draw the progress bar and the text
                    g.FillRectangle(new SolidBrush(Color.FromArgb(203, 235, 108)), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToInt32((percentage * cellBounds.Width - 4)), cellBounds.Height - 4);
                    g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + (cellBounds.Width / 2) - 5, cellBounds.Y + 2);

                }
                else
                {
                    // draw the text
                    if (this.DataGridView.CurrentRow.Index == rowIndex)
                        g.DrawString(progressVal.ToString() + "%", cellStyle.Font, new SolidBrush(cellStyle.SelectionForeColor), cellBounds.X + 6, cellBounds.Y + 2);
                    else
                        g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, cellBounds.X + 6, cellBounds.Y + 2);
                }
            }
            catch (Exception e) { }

        }
    }
    }
