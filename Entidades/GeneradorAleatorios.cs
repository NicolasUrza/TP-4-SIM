using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public static class GeneradorAleatorios
    {
        public static double GenerarExponencial(double rnd, double media)
        {
            var lambda = 1 / media;
            var muestra = Math.Truncate((-Math.Log(1 - rnd) / lambda) * 10000) / 10000;
            return muestra; 
        }
        public static double GenerarUniformeAB(double rnd, int a, int b)
        {
            return (Math.Truncate((rnd * (b - a) + a) * 10000) / 10000);
       
        }
        
        
    }
}
