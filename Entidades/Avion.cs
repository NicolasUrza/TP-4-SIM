using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Avion:IAvion
    {

        public Avion()
        {
            estado = "EP";
            horaLlegada = 0;
        }
        public Avion(string estado, double horaLlegada)
        {
            this.estado = estado;
            this.horaLlegada = horaLlegada;
        }
        public Avion(Avion a)
        {
            estado = a.estado;
            horaLlegada = a.horaLlegada;
        }
       
    }
}
