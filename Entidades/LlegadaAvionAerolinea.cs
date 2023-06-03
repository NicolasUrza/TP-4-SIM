using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class LlegadaAvionAerolinea
    {
        private double rnd;
        private double tiempoEntreLlegadas;
        private double proximaLlegada;
        private int a;
        private int b;
        public LlegadaAvionAerolinea()
        {
            
        }
        public LlegadaAvionAerolinea(double rnd, int a, int b, double relojActual)
        {
            this.rnd = rnd;
            this.a = a;
            this.b = b;
            this.CalcularSiguienteAvion(relojActual);

        }
        public LlegadaAvionAerolinea(LlegadaAvionAerolinea llaa)
        {
            // sirve para clonar un llegada avion aerolinea

            this.rnd = llaa.rnd;
            this.tiempoEntreLlegadas = llaa.tiempoEntreLlegadas;
            this.proximaLlegada = llaa.proximaLlegada;
            this.a = llaa.a;
            this.b = llaa.b;
            
        }
        public void CalcularSiguienteAvion(double relojActual)
        {
            //programar
            //Calcula el siguiente avion con el reloj actual y el generador de aleatorios
        }

    }
}
