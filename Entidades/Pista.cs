using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Pista
    {
        public string estado { get; set; }
        public int cola { get; set; }
        public int colaPrioritaria { get; set; }
        public Pista()
        {
            estado = "Libre";
            cola = 0;
            colaPrioritaria = 0;
        }
        public Pista(Pista p)
        {
            estado = p.estado;
            cola = p.cola;
            colaPrioritaria = p.colaPrioritaria;
        }
        public Pista(string estado, int cola, int colaPrioritaria)
        {
            this.estado = estado;
            this.cola = cola;
            this.colaPrioritaria = colaPrioritaria;
        }
        public void OcuparPista()
        {
            estado = "Ocupado";
        }
        public void LiberarPista()
        {
            if (cola == 0 && colaPrioritaria == 0)
            {
                estado = "Libre";
            }
            else if (colaPrioritaria > 0)
            {
                colaPrioritaria--;
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
        public void AumentarColaPrioritaria()
        {
            colaPrioritaria++;
        }

    }
}
