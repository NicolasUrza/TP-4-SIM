using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class RungeKuta
    {
      public List<FilaRunge> filasRunge { get; set; }
        public double resultado { get; set; }
        public RungeKuta()
        {
            filasRunge = new List<FilaRunge>();
        }
        public void AñadirFila(FilaRunge filaRunge)
        {
            filasRunge.Add(new FilaRunge(filaRunge));
        }
    }
}
