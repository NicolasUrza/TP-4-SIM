using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Muelle
    {
        public string estado { get; set; }
        public double horaFin { get; set; }

        public IAvion? avionEnMuelle { get; set; }
        public Muelle()
        {
            estado = "Libre";
            horaFin = 0;
            avionEnMuelle = null ;
        }

        public Muelle(Muelle m)
        {
            estado = m.estado;
            horaFin = m.horaFin;
            avionEnMuelle = m.avionEnMuelle;

        }

        public void OcuparMuelle(double horaFin, IAvion avion )
        {
            estado = "Ocupado";
            this.horaFin = Math.Truncate(horaFin * 100)/100;
            this.avionEnMuelle = avion;

        }
        public void LiberarMuelle()
        {
            estado = "Libre";
            horaFin = 0;
            avionEnMuelle = null; 
        }

    }
}
