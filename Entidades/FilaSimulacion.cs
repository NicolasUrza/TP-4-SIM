using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class FilaSimulacion
    {
        public string evento { get; set; }
        public double reloj { get; set; }
        public LlegadaAvion llegadaAvion { get; set;}
        public FinAterrizaje finAterrizaje { get; set; }
        public Intencion intencion { get; set; }
        public FinOperacion finOperacion { get; set; }
        public LlegadaAvionAerolinea llegadaAvionAerolinea { get; set; }
        public FinCarga finCarga { get; set; }
        public PuestoCarga puestoCarga {get; set; }
        public Pista pista { get; set; }
        public Acumuladores acumuladores { get; set; }
        
        public Avion[] aviones { get; set; }
        public AvionAerolinea[] avionesAerolinea { get; set; }
        
        public FilaSimulacion()
        {
            //estado inicial
                evento = "";
                reloj = 0;
                llegadaAvion = new LlegadaAvion();
                finAterrizaje = new FinAterrizaje();
                intencion = new Intencion();
                finOperacion = new FinOperacion();
                llegadaAvionAerolinea = new LlegadaAvionAerolinea();
                finCarga = new FinCarga();
                puestoCarga = new PuestoCarga();
                pista = new Pista();
                acumuladores = new Acumuladores();
        }
        public FilaSimulacion(FilaSimulacion f)
        {
            //para copiar una fila simulacion
            this.evento = f.evento;
            this.reloj = f.reloj;
            this.llegadaAvion = new LlegadaAvion(f.llegadaAvion);
            this.pista = new Pista(f.pista);
            this.finCarga = new FinCarga(f.finCarga);
            this.puestoCarga = new PuestoCarga(f.puestoCarga);
            this.acumuladores = new Acumuladores(f.acumuladores);
            this.finAterrizaje = new FinAterrizaje(f.finAterrizaje);
            this.intencion = new Intencion(f.intencion);
            this.llegadaAvionAerolinea = new LlegadaAvionAerolinea(f.llegadaAvionAerolinea);
            this.finOperacion = new FinOperacion(f.finOperacion);
        }

        public (string, double) siguienteEventoyReloj()
        {
            //programar para devolver el evento y el reloj del proximo evento
            return ("", 0);
        }
        
        public string[] ListaString()
        {
            //programar para devolver un vector de string con los datos de la fila
            var str = new string[2];
            return str;
        }



    }
}
