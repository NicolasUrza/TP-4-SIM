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
        public bool intencionCarga;
        public bool intencionMuelle;
        public string intencion;
        
        public Intencion()
        {
            intencionCarga = false;
            intencionMuelle = false;
        }
        public Intencion(double rnd)
        {
            this.rnd = rnd;
            GenerarIntencion(this.rnd);    
        }
        public Intencion(Intencion i, bool keep =false)
        {
            if (keep)
            {
                this.rnd = i.rnd;
                this.intencionCarga = i.intencionCarga;
                this.intencionMuelle = i.intencionMuelle;
                this.intencion = i.intencion;
            }
        }
        public void GenerarIntencion(double rnd)
        {
            if (rnd < 0.40)
            {
                this.intencionCarga = true;
                this.intencion = "Cargar";
            }
            else
            {
                this.intencionMuelle = true;
                this.intencion = "Muelle";
            }
        }
    }
}
