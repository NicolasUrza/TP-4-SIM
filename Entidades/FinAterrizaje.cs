﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class FinAterrizaje
    {
        public double rnd { get; set; }
        public double media { get; set; }
        public double tiempoAterrizaje { get; set; }
        public double proximoFinAterrizaje { get; set; }
        public FinAterrizaje()
        {
        }
        public FinAterrizaje(double rnd, double media, double relojActual)
        {
            //recibe el random y la media y calcula su tiempoEntreAviones y su proxima llegada
            this.rnd = rnd;
            this.media = media;
            GenerarTiempoAterrizaje(relojActual);
        }
        public FinAterrizaje(FinAterrizaje f, bool keep =false)
        {
            // sirve para clonar un fin aterrizaje
            if (keep)
            {
                this.rnd = f.rnd;
                this.media = f.media;
                this.tiempoAterrizaje = f.tiempoAterrizaje;
            }
                
                this.proximoFinAterrizaje =Math.Truncate( f.proximoFinAterrizaje*100)/100;
        }
        public void GenerarTiempoAterrizaje(double relojActual)
        {
            //programar
            //usar el generador con el random y la media
            this.tiempoAterrizaje = Math.Truncate(GeneradorAleatorios.GenerarExponencial(rnd, media) * 100) / 100;
            this.proximoFinAterrizaje = Math.Truncate((relojActual + tiempoAterrizaje) * 100) / 100;
        }
    }
}
