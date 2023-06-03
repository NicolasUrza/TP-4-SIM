using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class AvionAerolinea
    {
        public string estado { get; set; }
        public double horaLlegada { get; set; }

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
        public void Aterrizar()
        {
            estado = "AT";
        }
        public void EsperandoMuelle()
        {
            estado = "EM";


        }
        public void EnMuelle()
        {
            estado = "M";
        }
        public void EsperandoPista()
        {
            estado = "EP";
        }
        public void EsperandoCarga()
        {
            estado = "EC";
        }
        public void Cargando()
        {
            estado = "C";
        }
    }
}
