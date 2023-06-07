using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class AvionAerolinea:IAvion
    {

        public AvionAerolinea()
        {
            estado = "EP";
            horaLlegada = 0;
        }
        public AvionAerolinea(string estado, double horaLlegada)
        {
            this.estado = estado;
            this.horaLlegada = horaLlegada;
        }
        public AvionAerolinea(AvionAerolinea a)
        {
            estado = a.estado;
            horaLlegada = a.horaLlegada;
        }


    }
}
