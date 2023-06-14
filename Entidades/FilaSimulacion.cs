using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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
        public List<Avion> aviones { get; set; }
        public List<AvionAerolinea> avionesAerolinea { get; set; }
        
        public FilaSimulacion()
        {
            //estado inicial
                evento = "";
                reloj = 0;
                llegadaAvion = new LlegadaAvion();
            llegadaAvion.proximaLlegada = 1.67;
                finAterrizaje = new FinAterrizaje();
            
                intencion = new Intencion();
                finOperacion = new FinOperacion();

            var ae = new AvionAerolinea("M", 0.0);
            finOperacion.muelles[0].OcuparMuelle(0.2, ae);
            llegadaAvionAerolinea = new LlegadaAvionAerolinea();
            llegadaAvionAerolinea.proximaLlegada = 0.67;
                finCarga = new FinCarga();
                puestoCarga = new PuestoCarga();
                pista = new Pista();
                acumuladores = new Acumuladores();
            aviones = new List<Avion>();
            avionesAerolinea = new List<AvionAerolinea>();
            avionesAerolinea.Add(ae);
        }
        public FilaSimulacion(FilaSimulacion f, bool keep =false)
        {
            //para copiar una fila simulacion
            this.aviones = new List<Avion>();
            foreach (var avion in f.aviones)
            {
                this.aviones.Add(new Avion(avion));
            }
            this.avionesAerolinea = new List<AvionAerolinea>();
            foreach (var avionAerolinea in f.avionesAerolinea)
            {
                this.avionesAerolinea.Add(new AvionAerolinea(avionAerolinea));
            }
            this.evento = f.evento;
            this.reloj = f.reloj;
            this.llegadaAvion = new LlegadaAvion(f.llegadaAvion, keep);
            this.pista = new Pista(f.pista);
            this.finCarga = new FinCarga(f.finCarga,  keep);
            this.puestoCarga = new PuestoCarga(f.puestoCarga, this);
            this.acumuladores = new Acumuladores(f.acumuladores);
            this.finAterrizaje = new FinAterrizaje(f.finAterrizaje, keep);
            this.intencion = new Intencion(f.intencion, keep);
            this.llegadaAvionAerolinea = new LlegadaAvionAerolinea(f.llegadaAvionAerolinea, keep);
            this.finOperacion = new FinOperacion(f.finOperacion,this, keep);
            
            
        }

        public IAvion BuscarAvion(IAvion avionBuscado)
        {
            foreach (var avion in aviones)
            {
                if (avion.estado == avionBuscado.estado && avion.horaLlegada == avionBuscado.horaLlegada)
                {
                    return avion;
                }
            }
            foreach(var avion in avionesAerolinea)
            {
                if (avion.estado == avionBuscado.estado && avion.horaLlegada == avionBuscado.horaLlegada)
                {
                    return avion;
                }
            }
            return new Avion();
        }
        public bool AterrizarSiguienteAvion()
        {
            if (HayAvionesEsperandoAterrizaje())
            {
                IAvion avionAAterrizar = new IAvion();
                var i = 0;
                foreach(IAvion aa in this.avionesAerolinea)
                {
                    if(aa.estado == "EP" && i == 0)
                    {
                        avionAAterrizar = aa;
                        i++;
                    }
                    else if (aa.estado == "EP" && aa.horaLlegada < avionAAterrizar.horaLlegada)
                    {
                        avionAAterrizar = aa;
                        
                    }
                    
                    
                }
                if(i > 0)
                {
                    
                    avionAAterrizar.Aterrizar();
                    this.pista.OcuparPista();
                    this.pista.DisminuirColaPrioritaria();
                    var TiempoEsperaAterrizaje = this.reloj - avionAAterrizar.horaLlegada;
                    this.acumuladores.AumentarAcumTiempoEsperaAterr(TiempoEsperaAterrizaje);
                    if(TiempoEsperaAterrizaje > 20)
                    {
                        this.acumuladores.AumentarAvionesAterrGratis();
                    }
                    return true;
                }
                i = 0;
                foreach(IAvion a in this.aviones)
                {
                    if (a.estado == "EP" && i == 0)
                    {
                        avionAAterrizar = a;
                        i++;
                    }
                    else if (a.estado == "EP" && a.horaLlegada < avionAAterrizar.horaLlegada)
                    {
                        avionAAterrizar = a;

                    }
                }
                if (i > 0)
                {
                    avionAAterrizar.Aterrizar();
                    this.pista.OcuparPista();
                    this.pista.DisminuirCola();
                    var TiempoEsperaAterrizaje = this.reloj - avionAAterrizar.horaLlegada;
                    this.acumuladores.AumentarAcumTiempoEsperaAterr(TiempoEsperaAterrizaje);
                    if (TiempoEsperaAterrizaje > 20)
                    {
                        this.acumuladores.AumentarAvionesAterrGratis();
                    }
                    return true;
                }
            }
            
            return false;
    }


        public (string, double) siguienteEventoyReloj()
        {
            //programar para devolver el evento y el reloj del proximo evento
            List<(string, double)> Events = new List<(string,double)>();
            Events.Add(("llegada_avion",this.llegadaAvion.proximaLlegada));

            Events.Add(("fin_carga", this.finCarga.tiempoFinCarga));
            Events.Add(("fin_operaciones", this.finOperacion.ProximoFinOperacion()));
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
                else if ((smaller == 0 )|| (Events[i].Item2 < smaller && Events[i].Item2 != 0))
                {
                    smaller = Events[i].Item2;
                    nextEvent = Events[i].Item1;
                }
            }

            return (nextEvent, smaller);
        }

        public string[] ListaString( int cantAvionesTotales)
        {
            //programar para devolver un vector de string con los datos de la fila
            var str = new string[]
            {
                this.evento,
                this.reloj.ToString(),
                this.llegadaAvion.rnd != 0? this.llegadaAvion.rnd.ToString(): " ",
                this.llegadaAvion.tiempoEntreAviones!= 0? this.llegadaAvion.tiempoEntreAviones.ToString(): " ",
                this.llegadaAvion.proximaLlegada.ToString(),
                this.finAterrizaje.rnd != 0? this.finAterrizaje.rnd.ToString():  " ",
                this.finAterrizaje.tiempoAterrizaje != 0 ? this.finAterrizaje.tiempoAterrizaje.ToString(): " ",
                this.finAterrizaje.proximoFinAterrizaje !=0 ? this.finAterrizaje.proximoFinAterrizaje.ToString(): " ",
                this.intencion.rnd!=0? this.finAterrizaje.rnd.ToString():" ",
                this.intencion.intencion,
                this.finOperacion.rnd != 0? this.finOperacion.rnd.ToString(): " ",
                this.finOperacion.tiempo != 0? this.finOperacion.tiempo.ToString(): " ",



            };
            foreach (Muelle m in this.finOperacion.muelles)
            {
                str = str.Concat(new string[] { m.estado, m.horaFin.ToString() }).ToArray();
            }
            str = str.Concat(new string[] {
                this.llegadaAvionAerolinea.rnd != 0? this.llegadaAvionAerolinea.rnd.ToString(): " ",
                this.llegadaAvionAerolinea.tiempoEntreLlegadas != 0? this.llegadaAvionAerolinea.tiempoEntreLlegadas.ToString(): " ",
                this.llegadaAvionAerolinea.proximaLlegada.ToString(),
                this.finCarga.rnd != 0? this.finCarga.rnd.ToString(): " ",
                this.finCarga.tiempoCarga != 0? this.finCarga.tiempoCarga.ToString(): " ",
                this.finCarga.tiempoFinCarga !=0? this.finCarga.tiempoFinCarga.ToString(): " ",
                this.puestoCarga.estado,
                this.puestoCarga.cola.ToString(),
                this.pista.estado,
                this.pista.cola.ToString(),
                this.pista.colaPrioritaria.ToString(),
                this.acumuladores.cantAvionesAterrGratis.ToString(),
                this.acumuladores.cantAvionesCargaron.ToString(),
                this.acumuladores.acumTiempoEsperaAterr.ToString(),
                this.acumuladores.totalAvionesAterr.ToString(),
                this.acumuladores.cantAvionesAterrDescuento.ToString(),

            }).ToArray();
            
            foreach (Avion a in this.aviones)
            {
                str = str.Concat(new string[] { a.estado, a.horaLlegada.ToString() }).ToArray();
            }
            for (int i = 0; i< cantAvionesTotales - this.aviones.Count; i++)
            {
                    str = str.Concat(new string[] { " ", " " }).ToArray();
            }
            foreach (AvionAerolinea a in this.avionesAerolinea)
            {
                str = str.Concat(new string[] { a.estado, a.horaLlegada.ToString() }).ToArray();
            }
            return str;
        }

        //busca si hay aviones aterrizando
        public bool buscarAterrizaje()
        {
            foreach(var avion in aviones)
            {
                if(avion.estado == "AT" || avion.estado == "EM")
                {
                    return true;
                }
            }

            foreach (var avion in avionesAerolinea)
            {
                if (avion.estado == "AT" || avion.estado == "EM")
                {
                    return true;
                }
            }

            return false;
        }
        public bool HayAvionesEsperandoAterrizaje()
        {
            foreach (var avion in aviones)
            {
                if (avion.estado == "EP")
                {
                    return true;
                }
            }
            foreach (var avion in avionesAerolinea)
            {
                    if (avion.estado == "EP")
                    {
                        return true;
                    }
            }
            return false;
        }
        public IAvion AvionAterrizaje()
        {
                foreach (var avion in aviones)
                {
                    if (avion.estado == "AT")
                    {
                        return avion;
                    }
                }

                foreach (var avion in avionesAerolinea)
                {
                    if (avion.estado == "AT")
                    {
                        return avion;
                    }
                }

                return null;
        }

    }
}
