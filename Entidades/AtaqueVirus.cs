using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class AtaqueVirus
    {
        public double rndAtaque { get; set; }
        public string intencionAtaqueVirus { get; set; }
        public double beta { get; set; }
        public double tiempoEntreAtaque { get; set; }
        public double proximoAtaque{ get; set; }
        public double tiempoDetenido { get; set; }
        public double finAtaque { get; set; }
        public double A { get; set; }
        public AtaqueVirus()
        {
            
        }
        public AtaqueVirus(AtaqueVirus av, bool keep = false)
        {
            if (keep)
            {
                this.rndAtaque = av.rndAtaque;
                this.tiempoEntreAtaque = av.tiempoEntreAtaque;
                this.tiempoDetenido = av.tiempoDetenido;
                
                this.beta = av.beta;
            }
            this.intencionAtaqueVirus = av.intencionAtaqueVirus;
            this.A = av.A;
            this.finAtaque = av.finAtaque;
            this.proximoAtaque = av.proximoAtaque;

        }
    }
}
