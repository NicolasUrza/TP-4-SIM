using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Metricas
    {
        public double porcentajeAterrGratis { get; set; }
        public double porcentajeCargaronCombustible { get; set; }
        public double tiempoEsperaPromedioAterrizaje { get; set; }
        public double beneficiosPorHora { get; set; }
        public Metricas()
        {
            
        }
        public Metricas(double pa, double pc, double te, double bph)
        {
                porcentajeAterrGratis = pa;
                porcentajeCargaronCombustible = pc;
                tiempoEsperaPromedioAterrizaje = te;
                beneficiosPorHora = bph;
            
        }
     
    }
}
