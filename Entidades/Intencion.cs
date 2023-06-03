using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Intencion
    {
        public double rnd;
        public double intencionCarga;
        public double intencionMuelle;
        public string intencion;
        
        public Intencion()
        {
            
        }
        public Intencion(double rnd, double intencionCarga, double IntencionMuelle)
        {
            this.rnd = rnd;
            GenerarIntencion();    
        }
        public Intencion(Intencion i)
        {
                this.rnd = i.rnd;
                this.intencionCarga = i.intencionCarga;
                this.intencionMuelle = i.intencionMuelle;
                this.intencion = i.intencion;
        }
        public void GenerarIntencion()
        {
            //programar para decidir la intencion
        }
        
        
    }
}
