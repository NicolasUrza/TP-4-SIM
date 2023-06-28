using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class IAvion
    {
        public string estado { get; set; }
        public double horaLlegada { get; set; }


        public void MATAR()
        {
            estado = "morido";

        }


        public IAvion()
        {
            
        }
        public IAvion(IAvion a)
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
        public void Interrumpir()
        {
            estado = "CI";
        }

    }
}
