using System;
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
        public double tiempoRemanente;
        public FinCarga()
        {
            
        }
        public FinCarga(double rnd, double mediaCarga, double relojActual)
        {
            this.rnd = rnd;
            this.mediaCarga = mediaCarga;
            GenerarTiempoCarga();
            this.tiempoFinCarga = Math.Truncate((this.tiempoCarga + relojActual) * 100) / 100;
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
            tiempoRemanente = f.tiempoRemanente;

        }
        public void GenerarTiempoCarga()
        {
            this.tiempoCarga = Math.Truncate(GeneradorAleatorios.GenerarExponencial(rnd, mediaCarga) * 100) /100;   
        }


        public void OcuparCarga(double rnd, double mediaCarg, double Reloj )
        {
            this.rnd = rnd;
            mediaCarga = mediaCarg; 
            GenerarTiempoCarga();
            this.tiempoFinCarga = Math.Truncate((tiempoCarga + Reloj) * 100) / 100;

        }

        public void pausarCarga(double relojActual)
        {
            this.tiempoRemanente = tiempoFinCarga!=0? Math.Truncate((tiempoFinCarga - relojActual) * 100) / 100: 0;
            this.tiempoFinCarga = 0;
        }
        public void ReanudarCarga(double relojActual)
        {
            this.tiempoFinCarga = tiempoRemanente + relojActual;
            this.tiempoRemanente = 0;
        }

    }
}
