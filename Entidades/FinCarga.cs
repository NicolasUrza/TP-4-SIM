﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class FinCarga
    {
        public double rnd;
        public double tiempoFinCarga;
        public double tiempoCarga;
        public double mediaCarga;
        public FinCarga()
        {
            
        }
        public FinCarga(double rnd, double mediaCarga, double relojActual)
        {
            this.rnd = rnd;
            this.mediaCarga = mediaCarga;
            GenerarTiempoCarga(relojActual);
        }
        public FinCarga(FinCarga f, bool keep=false)
        {
            //sirve para clonar un fin de carga
            if (keep)
            {
                rnd = f.rnd;
                tiempoCarga = f.tiempoCarga;
                mediaCarga = f.mediaCarga;

            }
            tiempoFinCarga = f.tiempoFinCarga;

        }
        public void GenerarTiempoCarga(double relojActual)
        {
            //programar
            //calcular el tiempo y el fin carga, con el reloj actual y el generador de aleatorios         
        }
    }
}
