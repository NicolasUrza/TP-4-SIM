﻿using System;
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
            aviones = new Avion[0];
            avionesAerolinea = new AvionAerolinea[0];

        }
        public FilaSimulacion(FilaSimulacion f, bool keep =false)
        {
            //para copiar una fila simulacion
            this.evento = f.evento;
            this.reloj = f.reloj;
            this.llegadaAvion = new LlegadaAvion(f.llegadaAvion, keep);
            this.pista = new Pista(f.pista);
            this.finCarga = new FinCarga(f.finCarga, keep);
            this.puestoCarga = new PuestoCarga(f.puestoCarga);
            this.acumuladores = new Acumuladores(f.acumuladores);
            this.finAterrizaje = new FinAterrizaje(f.finAterrizaje, keep);
            this.intencion = new Intencion(f.intencion, keep);
            this.llegadaAvionAerolinea = new LlegadaAvionAerolinea(f.llegadaAvionAerolinea, keep);
            this.finOperacion = new FinOperacion(f.finOperacion, keep);
            this.aviones = f.aviones;
            this.avionesAerolinea = f.avionesAerolinea;
        }

        public (string, double) siguienteEventoyReloj()
        {
            //programar para devolver el evento y el reloj del proximo evento
            List<(string, double)> Events = new List<(string,double)>();
            Events.Add(("llegada_avion",this.llegadaAvion.proximaLlegada));

            Events.Add(("fin_carga", this.finCarga.tiempoFinCarga));
            Events.Add(("fin_operaciones", this.finAterrizaje.proximoFinAterrizaje));
            Events.Add(("llegada_avion_aerolinea", this.llegadaAvionAerolinea.proximaLlegada));
            Events.Add(("fin_aterrizaje", this.finAterrizaje.proximoFinAterrizaje));

            double smaller = -1;
            string nextEvent = "";

            for (int i = 0; i < Events.Count; i++)
            {
                if(i == 0)
                {
                    smaller = Events[i].Item2;
                    nextEvent = Events[i].Item1;
                }
                else if (Events[i].Item2 < smaller && Events[i].Item2 != 0)
                {
                    smaller = Events[i].Item2;
                    nextEvent = Events[i].Item1;
                }
            }

            return (nextEvent, smaller);
        }
        
        public string[] ListaString()
        {
            //programar para devolver un vector de string con los datos de la fila
            var str = new string[]
            {
                this.evento,
                this.reloj.ToString(),
                this.llegadaAvion.rnd.ToString(),
                this.llegadaAvion.tiempoEntreAviones.ToString(),
                this.llegadaAvion.proximaLlegada.ToString(),

            };
            return str;
        }

        //busca si hay aviones aterrizando
        public bool buscarAterrizaje()
        {
            foreach(var avion in aviones)
            {
                if(avion.estado == "AT")
                {
                    return true;
                }
            }

            foreach (var avion in avionesAerolinea)
            {
                if (avion.estado == "AT")
                {
                    return true;
                }
            }

            return false;
        }

    }
}
