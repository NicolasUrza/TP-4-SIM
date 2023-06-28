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
        public string intencionOcultaVirus { get; set; }
        public double beta { get; set; }
        public double tiempoEntreAtaque { get; set; }
        public double proximoAtaque { get; set; }
        public double tiempoDetenido { get; set; }
        public double A { get; set; }
        public RungeKuta rungeKuta {get; set;}
        public AtaqueVirus()
        {
            
        }

        public AtaqueVirus(double rnd, double relojActual, double A)
        {
            this.beta = rnd;
            this.A = A;

            double yf = (this.beta * this.A) * 3;

            
              this.rungeKuta = GeneradorAleatorios.GenerarRungeKuta(0.1,0,this.A,yf,0);

            this.tiempoDetenido = this.rungeKuta.resultado * 30;

            this.proximoAtaque = Math.Truncate((tiempoDetenido + relojActual)*100)/100;

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
            this.A = av.A;
            this.proximoAtaque = av.proximoAtaque;
            this.intencionOcultaVirus = av.intencionOcultaVirus;
            this.intencionAtaqueVirus = av.intencionAtaqueVirus;
        }
    }
}
