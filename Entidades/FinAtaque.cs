﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    
    public class FinAtaque
    {
        public double tiempoDetenido;
        public double finAtaque;
        
        public FinAtaque() { }

        public FinAtaque(bool esDetenimientoLlegada, double relojActual)
        {
            this.tiempoDetenido = calculoTiempo(esDetenimientoLlegada, relojActual);
            this.finAtaque = tiempoDetenido + relojActual;
        }

        public double calculoTiempo(bool esDetenimientoLlegada,double relojActual) {

            if (esDetenimientoLlegada)
            {


                RungeKuta runge = GeneradorAleatorios.GenerarRungeKuta(0.1, 1, relojActual,0,1);

                return runge.resultado * 27;

            }
            else
            {
                double yf = relojActual * 1.5;

                RungeKuta runge = GeneradorAleatorios.GenerarRungeKuta(0.1, 1, relojActual, yf, 2);

                return runge.resultado * 8;
            }

        }

        public FinAtaque(FinAtaque fa, bool keep = false) {

            if (keep)
            {
                
                this.tiempoDetenido = fa.tiempoDetenido;

           
            }
            this.finAtaque = fa.finAtaque;

        }


    }
}