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
            this.estado = p.estado;
            this.cola = p.cola;
        }
        public PuestoCarga(string estado, int cola)
        {
            this.estado = estado;
            this.cola = cola;
        }
        public void OcuparPuestoCarga()
        {
            this.estado = "Ocupado";
        }
        public void LiberarPuestoCarga()
        {
            if (this.cola == 0)
            {
                this.estado = "Libre";
            }
            else
            {
                this.cola--;
            }
        }

        public void AumentarCola()
        {
            this.cola++;
        }
        public bool EstaLibre()
        {
            return this.estado == "Libre";
        }
    }
}
