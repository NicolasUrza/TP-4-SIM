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

        public Muelle()
        {
            estado = "Libre";
            horaFin = 0;
        }
        public void OcuparMuelle(double horaFin)
        {
            estado = "Ocupado";
            this.horaFin = horaFin;
        }
        public void LiberarMuelle()
        {
            estado = "Libre";
            horaFin = 0;
        }
    }
}
