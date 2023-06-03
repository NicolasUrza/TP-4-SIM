using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Parametros
    {
        public double MediaLlegadaAvion { get; set; }
        public double MediaAterrizaje { get; set; }
        public double MediaMuelle { get; set; }
        public double MediaCarga { get; set; }
        public double IntencionCarga { get; set; }
        public double IntencionMuelle { get; set; }
        public int AerolineaA { get; set; }
        public int AerolineaB { get; set; }
        public int CantidadDeIteraciones { get; set; }
        public int Desde { get; set; }
    }
}
