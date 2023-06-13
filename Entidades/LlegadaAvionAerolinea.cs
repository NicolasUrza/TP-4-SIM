using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class LlegadaAvionAerolinea
    {
        public double rnd;
        public double tiempoEntreLlegadas;
        public double proximaLlegada;
        public int a;
        public int b;
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
        public LlegadaAvionAerolinea(LlegadaAvionAerolinea llaa, bool keep =false)
        {
            // sirve para clonar un llegada avion aerolinea
            if (keep)
            {
                this.rnd = llaa.rnd;
                this.tiempoEntreLlegadas = llaa.tiempoEntreLlegadas;
                this.a = llaa.a;
                this.b = llaa.b;
            }
            
            this.proximaLlegada = llaa.proximaLlegada;
          
            
        }
        public void CalcularSiguienteAvion(double relojActual)
        {
            //Calcula el siguiente avion con el reloj actual y el generador de aleatorios
            this.tiempoEntreLlegadas = GeneradorAleatorios.GenerarUniformeAB(rnd, a, b);
            proximaLlegada = Math.Truncate((this.tiempoEntreLlegadas + relojActual)*100)/100;
        }

    }
}
