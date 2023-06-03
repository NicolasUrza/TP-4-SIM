using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class FinOperacion
    {
        public double rnd { get; set; }
        public double tiempo { get; set; }
        public double mediaMuelle { get; set; }
        public Muelle[] muelles { get; set; } 
        public FinOperacion()
        {
                muelles = new Muelle[5];
        }
        public FinOperacion(FinOperacion finOperacion)
        {
            rnd = finOperacion.rnd;
            tiempo = finOperacion.tiempo;
            muelles = finOperacion.muelles;
        }
        public FinOperacion(double rnd, double tiempo, double mediaMuelle, Muelle[] muelles)
        {
            this.rnd = rnd;
            this.tiempo = tiempo;
            this.muelles = muelles;
            
        }
        public Muelle BuscarMuelleLibre()
        {
            //busca un muelle libre en muelles
            //programar
            return muelles[0];
        }
        public void ocuparMuelle(double rnd, double media)
        {
            //ocupa un muelle libre en muelles
            //programar
        }
    }
}
