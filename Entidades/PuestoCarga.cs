using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class PuestoCarga
    {
        public string estado { get; set; }
        public int cola { get; set; }
        public PuestoCarga()
        {
            estado = "Libre";
            cola = 0;
        }
        public PuestoCarga(PuestoCarga p)
        {
            //sirve para clonar un puesto de carga
                estado = p.estado;
                cola = p.cola;
        }
        public PuestoCarga(string estado, int cola)
        {
            this.estado = estado;
            this.cola = cola;
        }
        public void OcuparPuestoCarga()
        {
            estado = "Ocupado";
        }
        public void LiberarPuestoCarga()
        {
            if (cola == 0)
            {
                estado = "Libre";
            }
            else
            {
                cola--;
            }
        }

        public void AumentarCola()
        {
            cola++;
        }
        public bool EstaLibre()
        {
            return estado == "Libre";
        }

        public void ReducirCola()
        {
            cola--;
        }
    }
}
