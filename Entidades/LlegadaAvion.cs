﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class LlegadaAvion
    {
        public double rnd;
        public double media;
        public double tiempoEntreAviones;
        public double proximaLlegada;
        public LlegadaAvion()
        {
            
        }
        
        public LlegadaAvion(double rnd, double media, double relojActual)
        {
            //recibe el random y la media y calcula su tiempoEntreAviones y su proxima llegada
            this.rnd = rnd;
            this.media = media;
            calcularSiguienteAvion(relojActual);
            
        }
        public LlegadaAvion(LlegadaAvion la, bool keep =false)
        {
            // sirve para clonar un llegada avion
            if (keep) { 
            this.rnd = la.rnd;
            this.media = la.media;
            this.tiempoEntreAviones = la.tiempoEntreAviones;
            }
            this.proximaLlegada = la.proximaLlegada;
        }
        public void calcularSiguienteAvion(double relojActual)
        {
            //programar
            //usar el generador con el random y la media
            this.tiempoEntreAviones = Math.Truncate(GeneradorAleatorios.GenerarExponencial(rnd, media) * 100) / 100;
            this.proximaLlegada = Math.Truncate((relojActual + tiempoEntreAviones) * 100) / 100;

        }
    }
}
