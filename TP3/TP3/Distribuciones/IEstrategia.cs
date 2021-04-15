using System;
using System.Collections.Generic;
using System.Text;

namespace TP3.Distribuciones
{
    public interface IEstrategia
    {
        // Dependiendo de lo que se elija en la ventana se crea la estrategia, y por polimorfismo se generan los valores
       
        //Calcula frecuencias y probabilidades esperadas y las carga en el gestor
        void obtenerEsperados(Gestor g);

        double generarValor(Gestor g);
    }
}
