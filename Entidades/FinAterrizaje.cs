using System;
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
        public FinAterrizaje() {}
        public FinAterrizaje(double rnd, double media, double relojActual)
        {
            //recibe el random y la media y calcula su tiempoEntreAviones y su proxima llegada
            this.rnd = rnd;
            this.media = media;
            GenerarTiempoAterrizaje(relojActual);
        }
        public FinAterrizaje(FinAterrizaje f, bool keep = false)
        {
            // sirve para clonar un fin aterrizaje
            if (keep)
            {
                this.rnd = f.rnd;
                this.media = f.media;
                this.tiempoAterrizaje = f.tiempoAterrizaje;
            }

            this.proximoFinAterrizaje = f.proximoFinAterrizaje;
        }
        public void GenerarTiempoAterrizaje(double relojActual)
        {
            tiempoAterrizaje = GeneradorAleatorios.GenerarExponencial(rnd, media);
            proximoFinAterrizaje = Math.Truncate((tiempoAterrizaje + relojActual)*100)/100;
        }
        public AvionAerolinea AvionAerolineasProximo(double reloj, List<AvionAerolinea> aviones)
        {
            AvionAerolinea valorMasCercano = aviones[0];
            double diferenciaMinima = reloj - valorMasCercano.horaLlegada;

            for (int i = 1; i < aviones.Count; i++)
            {
                double diferenciaActual = reloj - aviones[i].horaLlegada;

                if (diferenciaActual >= 0 && diferenciaActual < diferenciaMinima)
                {
                    diferenciaMinima = diferenciaActual;
                    valorMasCercano = aviones[i];
                }
            }

            return valorMasCercano;
        }
        public Avion AvionProximo(double reloj, List<Avion> aviones)
        {
            Avion valorMasCercano = aviones[0];
            double diferenciaMinima = reloj - valorMasCercano.horaLlegada;

            for (int i = 1; i < aviones.Count; i++)
            {
                double diferenciaActual = reloj - aviones[i].horaLlegada;

                if (diferenciaActual >= 0 && diferenciaActual < diferenciaMinima)
                {
                    diferenciaMinima = diferenciaActual;
                    valorMasCercano = aviones[i];
                }
            }

            return valorMasCercano;
        }
    }
}
