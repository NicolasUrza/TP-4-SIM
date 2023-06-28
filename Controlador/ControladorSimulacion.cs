using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_4_SIM_Aeropuerto.Entidades;

namespace TP_4_SIM_Aeropuerto.Controlador
{
    public class ControladorSimulacion
    {
        private Principal principalForm;
        private Parametros parametros;
        private FilaSimulacion[] resultadosDesde;
        private List<RungeKuta> rungeKutas;
        private Random generadorRandom = new Random();
        private bool banderaVirusLlegada = false;
        private bool desdeActivado = false; // para matar no para desligar-destruir 
        private int cantLlegadasAvion = 0;
        private double a = 0;
      

        public ControladorSimulacion( Principal pri, Parametros par)
        {
            this.principalForm = pri;
            this.parametros = par;
            this.rungeKutas = new List<RungeKuta>();
            if (parametros.CantidadDeIteraciones < parametros.Desde + 499)
            {
                resultadosDesde = new FilaSimulacion[parametros.CantidadDeIteraciones - parametros.Desde + 1];
            }
            else
            {
                resultadosDesde = new FilaSimulacion[500];
            }
            

        }

        public void GenerarSimulacion()
        {
            //programar
            //simulacion, usar los parametros de la inicializacion
            var filaActual = new FilaSimulacion();
            var indice = 0;
          
            //hacemos un for hasta la cantidad de iteraciones

            for (int i=0; i< parametros.CantidadDeIteraciones; i++)
            {
                //guardar la fila actual en el array de resultadosDesde si corresponde
                // guardar hasta 500 desde el Parametro.desde
                if (i >= parametros.Desde - 1 & i < parametros.Desde + 499)
                {
                    desdeActivado = true;
                    resultadosDesde[indice] = new FilaSimulacion(filaActual, true);
                    indice++;
                }
                else if (i > parametros.Desde + 499 & desdeActivado)
                {
                    filaActual = new FilaSimulacion(filaActual, true);
                    desdeActivado = false;
                    
                }

                if (i + 1 == this.parametros.CantidadDeIteraciones)
                {
                    break;
                }
                //determinamos el proximo estado y reloj
                //programar este metodo
                var proximo = filaActual.siguienteEventoyReloj();
                var proximoEstado = proximo.Item1;
                var nuevoReloj = proximo.Item2;
                // ejecutamos el evento
                // completar con todos los else
                if (proximoEstado == "llegada_avion")
                {
                    filaActual = LlegadaAvion(filaActual, nuevoReloj);
                }
                else if(proximoEstado == "fin_carga")
                {
                    filaActual = FinCarga(filaActual, nuevoReloj);
                }
                else if (proximoEstado == "fin_operaciones")
                {
                    filaActual = FinOperaciones(filaActual, nuevoReloj);
                }
                else if (proximoEstado == "llegada_avion_aerolinea")
                {
                    filaActual = LlegadaAvionAerolinea(filaActual, nuevoReloj);

                }
                else if (proximoEstado == "fin_aterrizaje")
                {
                    filaActual = FinAterrizaje(filaActual, nuevoReloj);
                }
                else if(proximoEstado == "ataque_virus")
                {
                    banderaVirusLlegada = true;
                    filaActual = AtaqueVirus(filaActual, nuevoReloj);
                }
                else if(proximoEstado == "fin_ataque")
                {
                    banderaVirusLlegada = false;
                    filaActual = FinAtaque(filaActual, nuevoReloj);
                }

               

                

            }

            // calcular las metricas
            var metricas = new Metricas();
            // aca calcular las metricas con los acumuladores que quedaron guardados en la ultima fila
            if (filaActual.acumuladores.totalAvionesAterr > 0)
            {
                metricas.tiempoEsperaPromedioAterrizaje = filaActual.acumuladores.acumTiempoEsperaAterr / filaActual.acumuladores.totalAvionesAterr;

                metricas.porcentajeAterrGratis = (double)((double)filaActual.acumuladores.cantAvionesAterrGratis / (double)filaActual.acumuladores.totalAvionesAterr) *100;

            metricas.porcentajeCargaronCombustible = (double)((double)filaActual.acumuladores.cantAvionesCargaron / (double)filaActual.acumuladores.totalAvionesAterr) * 100;
            }
            else
            {
                metricas.porcentajeAterrGratis = 0;
                metricas.porcentajeCargaronCombustible = 0;
                metricas.tiempoEsperaPromedioAterrizaje = 0;
            }


            metricas.beneficiosPorHora = ((filaActual.acumuladores.cantAvionesAterrDescuento * 3000) + ((filaActual.acumuladores.totalAvionesAterr - filaActual.acumuladores.cantAvionesAterrDescuento - filaActual.acumuladores.cantAvionesAterrGratis) * 6000)) / filaActual.reloj;

            //deovlvemos los resultados al form
            this.principalForm.CargarResultados(resultadosDesde, rungeKutas, metricas);

        }
        //Eventos
        //programar lo que pasaria en cada caso
        public FilaSimulacion LlegadaAvion(FilaSimulacion filaActual,double nuevoReloj)
        {
            
            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }
            var rnd = GenerarRandom();


            nuevaFila.evento = "llegada_avion";
            nuevaFila.reloj = nuevoReloj;

            if (banderaVirusLlegada)
            {
                var nLlegada = new LlegadaAvion(rnd, parametros.MediaLlegadaAvion, nuevoReloj);
                nuevaFila.llegadaAvion = nLlegada;
                
                return nuevaFila;
            }
            //programar

            if (cantLlegadasAvion < 149)
            {
                cantLlegadasAvion++;
                

            }
            else if (cantLlegadasAvion == 149)
            {
                cantLlegadasAvion++;
                this.a = filaActual.reloj;

               AtaqueVirus ataque = new AtaqueVirus();
                ataque = primerAtaque(filaActual);
                nuevaFila.ataqueVirus = ataque;
            }

            var nuevaLlegada = new LlegadaAvion(rnd, parametros.MediaLlegadaAvion, nuevoReloj);
            if (filaActual.buscarAterrizaje())
            {
                var avion = new Avion("EP", nuevoReloj);
                nuevaFila.pista.AumentarCola();
                nuevaFila.aviones.Add(avion);
            }
            else
            {
                //cuando no hay aviones aterrizando
                var rndAterrizaje = GenerarRandom();
                var finAterrizaje = new FinAterrizaje(rndAterrizaje, parametros.MediaAterrizaje, nuevoReloj);
                var avion = new Avion("AT", nuevoReloj);
                nuevaFila.aviones.Add(avion);
                nuevaFila.finAterrizaje = finAterrizaje;
                nuevaFila.pista.OcuparPista();

            }
            nuevaFila.llegadaAvion = nuevaLlegada;

            return nuevaFila;
        }
        public FilaSimulacion FinAterrizaje(FilaSimulacion filaActual, double nuevoReloj)
        {

            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.evento = "fin_aterrizaje";
            nuevaFila.reloj = nuevoReloj;
            nuevaFila.acumuladores.totalAvionesAterr++;
            var avion =  nuevaFila.AvionAterrizaje();
            var rnd = GenerarRandom();
            Intencion nuevaIntencion = new Intencion(rnd, parametros.IntencionCarga, parametros.IntencionMuelle);
            nuevaFila.intencion = nuevaIntencion;
            if(nuevaIntencion.intencion == "Carga")
            {
                
                if (nuevaFila.puestoCarga.EstaLibre())
                {
                    avion.Cargando();
                    nuevaFila.puestoCarga.OcuparPuestoCarga();
                    FinCarga nuevoFinCarga = new FinCarga(GenerarRandom(), parametros.MediaCarga, nuevoReloj);
                    nuevaFila.finCarga = nuevoFinCarga;
                    
                }
                else
                {
                    // hay que sumar al final de la cola
                    nuevaFila.puestoCarga.AumentarCola(avion);

                }
                if (nuevaFila.AterrizarSiguienteAvion())
                {
                    var nuevoFinAterrizaje = new FinAterrizaje(GenerarRandom(), parametros.MediaAterrizaje, nuevoReloj);
                    nuevaFila.finAterrizaje = nuevoFinAterrizaje;
                }
                else
                {
                        nuevaFila.finAterrizaje.proximoFinAterrizaje = 0;
                    nuevaFila.pista.LiberarPista();
                }
                
            }
            else
            {
                if (nuevaFila.finOperacion.HayMuelleLibre())
                {

                    Muelle muelleLibre = nuevaFila.finOperacion.BuscarMuelleLibre();
                    var rndFinOperacion = GenerarRandom();
                    nuevaFila.finOperacion.ocuparMuelle(rndFinOperacion, parametros.MediaMuelle, muelleLibre, avion, nuevoReloj);
                    if (nuevaFila.AterrizarSiguienteAvion())
                    {
                        var nuevoFinAterrizaje = new FinAterrizaje(GenerarRandom(), parametros.MediaAterrizaje, nuevoReloj);
                        nuevaFila.finAterrizaje = nuevoFinAterrizaje;
                    }
                    else
                    {
                        nuevaFila.finAterrizaje.proximoFinAterrizaje = 0;
                        nuevaFila.pista.LiberarPista();
                    }

                }
                else
                {
                    avion.EsperandoMuelle();
                    nuevaFila.acumuladores.AumentarAvionesAterrDescuento();
                    nuevaFila.finAterrizaje.proximoFinAterrizaje = 0;
                }
            }
            
            
            return nuevaFila;
        }

        
        
        public FilaSimulacion FinCarga(FilaSimulacion filaActual, double nuevoReloj)
        {
            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }


            nuevaFila.evento = "fin_carga";
            nuevaFila.reloj = nuevoReloj;
            nuevaFila.acumuladores.AumentarAvionesCargaron();
            
            // mato y libero al puesto de carga y avion 
            
            
            nuevaFila.puestoCarga.LiberarPuestoCarga();
            
            
            IAvion avionAMatar = new IAvion();
            bool banderaSeMatoAvion = false;
           foreach (var avion in nuevaFila.avionesAerolinea)
           {
                if (desdeActivado && avion.estado =="C")
                {
                    avion.MATAR();
                    banderaSeMatoAvion = true;
                    break;
                }
                if (avion.estado =="C")
                {
                    avionAMatar = avion;
                    banderaSeMatoAvion = true;
                    break;
                }

           }
            if (!desdeActivado && banderaSeMatoAvion)
            {
                nuevaFila.avionesAerolinea.Remove((AvionAerolinea)avionAMatar);
            }
            if (!banderaSeMatoAvion) { 
            foreach (var avion in nuevaFila.aviones)
            {
                if (desdeActivado && avion.estado == "C")
                {
                    avion.MATAR();
                    break;
                }
                if (avion.estado == "C")
                {
                    avionAMatar = avion;
                        banderaSeMatoAvion = true;
                        break;
                }


            }
            if (!desdeActivado && banderaSeMatoAvion)
            {
                nuevaFila.aviones.Remove((Avion)avionAMatar);
            }
            }
            // compruevo cola y ocupo servidor, y cambio estado avion
            if (nuevaFila.puestoCarga.HayCola() )
            {
                nuevaFila.puestoCarga.OcuparPuestoCarga();

                IAvion siguienteAvion = nuevaFila.puestoCarga.ReducirCola();
                siguienteAvion.Cargando();
                var rnd = GenerarRandom();

                nuevaFila.finCarga.OcuparCarga(rnd, this.parametros.MediaCarga, nuevoReloj);
            }
            else
            {
                nuevaFila.finCarga.tiempoFinCarga = 0 ;
            }
            

            return  nuevaFila;
        }
        public FilaSimulacion FinOperaciones(FilaSimulacion filaActual, double nuevoReloj)
        {
            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.evento = "fin_operaciones";
            nuevaFila.reloj = nuevoReloj;
            

            /// mato el avion 
            if (!desdeActivado)
            {
                Muelle muelle = nuevaFila.finOperacion.BuscarMuelleOcupado(nuevoReloj);

                var avion = muelle.avionEnMuelle;

                if (avion.GetType() == typeof(Avion))
                {
                    nuevaFila.aviones.Remove((Avion)avion);
                }

                if (avion.GetType() == typeof(AvionAerolinea))
                {
                    nuevaFila.avionesAerolinea.Remove((AvionAerolinea)avion);
                }
            
            /// desocupo el muelle 
                muelle.LiberarMuelle();
            }
            else
            {
                Muelle muelle = nuevaFila.finOperacion.BuscarMuelleOcupado(nuevoReloj);
                var avion = (IAvion) muelle.avionEnMuelle;
                avion.MATAR(); 
                muelle.LiberarMuelle();
            }

            /// creacion del nuevo fin_operacion 
            
            bool banderaPrioritario = false;

            var avionOcupa = new IAvion();
            var rnd = GenerarRandom();
            var muelleOcupar = nuevaFila.finOperacion.BuscarMuelleLibre();

            foreach (var avion in nuevaFila.avionesAerolinea)
                {
                    if (avion.estado == "EM")
                    {
                        avionOcupa = avion;
                        avion.EnMuelle();
                        banderaPrioritario = true;
                        break;
                    }
            }

            if (!banderaPrioritario)
            {
                foreach (var avion in nuevaFila.aviones)
                {
                    if (avion.estado == "EM")
                    {
                        avionOcupa = avion;
                        avion.EnMuelle();
                        banderaPrioritario = true;
                        break;
                    }
                }
            }
            if(banderaPrioritario){
                nuevaFila.finOperacion.ocuparMuelle(rnd, this.parametros.MediaMuelle, muelleOcupar, avionOcupa, nuevoReloj);

            }
            return nuevaFila;
        }




        public FilaSimulacion LlegadaAvionAerolinea(FilaSimulacion filaActual, double nuevoReloj)
        {
            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }
            nuevaFila.evento = "llegada_avion_aerolinea";
            nuevaFila.reloj = nuevoReloj;
            //programar
            if (cantLlegadasAvion < 149)
            {
                cantLlegadasAvion++;


            }
            else if (cantLlegadasAvion == 149)
            {
                cantLlegadasAvion++;
                this.a = filaActual.reloj;

                AtaqueVirus ataque = new AtaqueVirus();
                ataque = primerAtaque(filaActual);
                nuevaFila.ataqueVirus = ataque;
            }



            var rnd = GenerarRandom();


            if (banderaVirusLlegada)
            {
                var nLlegada = new LlegadaAvionAerolinea(rnd, parametros.AerolineaA, parametros.AerolineaB, nuevoReloj);
                nuevaFila.llegadaAvionAerolinea = nLlegada;
                return nuevaFila;
            }

            var nuevaLlegadaAerolinea = new LlegadaAvionAerolinea(rnd, parametros.AerolineaA, parametros.AerolineaB, nuevoReloj);
            if (filaActual.buscarAterrizaje())
            {
                var avionAero = new AvionAerolinea("EP", nuevoReloj);
                nuevaFila.pista.AumentarColaPrioritaria();
                
                nuevaFila.avionesAerolinea.Add(avionAero);
            }
            else
            {
                //cuando no hay aviones aterrizando
                var rndAterrizaje = GenerarRandom();
                var finAterrizaje = new FinAterrizaje(rndAterrizaje, parametros.MediaAterrizaje, nuevoReloj);
                var avionAero = new AvionAerolinea("AT", nuevoReloj);
                nuevaFila.avionesAerolinea.Add(avionAero);
                nuevaFila.finAterrizaje = finAterrizaje;
                nuevaFila.pista.OcuparPista();

            }
            nuevaFila.llegadaAvionAerolinea = nuevaLlegadaAerolinea;

            return nuevaFila;
        }

        public AtaqueVirus primerAtaque(FilaSimulacion filaActual)
        {
            var rndBeta = GenerarRandom();

            var nuevoAtaqueVirus = new AtaqueVirus(rndBeta, filaActual.reloj, this.a);
            this.rungeKutas.Add(nuevoAtaqueVirus.rungeKuta);
            return nuevoAtaqueVirus;
        }

        public FilaSimulacion AtaqueVirus(FilaSimulacion filaActual, double nuevoReloj)
        {

            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }

  
            nuevaFila.evento = "ataque_virus";
            nuevaFila.reloj = nuevoReloj;

            nuevaFila.ataqueVirus.proximoAtaque = 0;
            var rndIntencion = GenerarRandom();

            if (rndIntencion <= 0.34)
            {
                var finAtaque = new FinAtaque(true, nuevoReloj);
                this.rungeKutas.Add(finAtaque.rungeKuta);
                nuevaFila.ataqueVirus.intencionAtaqueVirus = "Detener Llegadas";
                nuevaFila.ataqueVirus.intencionOcultaVirus = "Detener Llegadas";
                nuevaFila.finAtaque = finAtaque;
                
            }
            else
            {
               var finAtaque = new FinAtaque(false,nuevoReloj);

                nuevaFila.ataqueVirus.intencionAtaqueVirus = "Detener Carga";
                nuevaFila.ataqueVirus.intencionOcultaVirus = "Detener Carga";
                this.rungeKutas.Add(finAtaque.rungeKuta);
                nuevaFila.finAtaque = finAtaque;
                nuevaFila.finCarga.pausarCarga(nuevoReloj);
                nuevaFila.puestoCarga.InterrumpirCarga();
                if (nuevaFila.avionCargando() is not null){
                    
                    nuevaFila.avionCargando().Interrumpir();
                }
            }



            return nuevaFila;

        }
        public FilaSimulacion FinAtaque(FilaSimulacion filaActual, double nuevoReloj)
        {
            FilaSimulacion nuevaFila;
            if (desdeActivado)
            {
                nuevaFila = new FilaSimulacion(filaActual);
            }
            else
            {
                nuevaFila = filaActual;
            }


            nuevaFila.evento = "fin_ataque";
            nuevaFila.reloj = nuevoReloj;
            nuevaFila.finAtaque.finAtaque = 0;

            if (nuevaFila.ataqueVirus.intencionOcultaVirus == "Detener Carga")
            {
                nuevaFila.finCarga.ReanudarCarga(nuevoReloj);
                
                if( nuevaFila.avionInterrumpido() is not null)
                {
                    nuevaFila.avionInterrumpido().Cargando();
                    nuevaFila.puestoCarga.OcuparPuestoCarga();
                }
                else
                {
                    if (nuevaFila.puestoCarga.HayCola())
                    {
                        nuevaFila.puestoCarga.OcuparPuestoCarga();

                        IAvion siguienteAvion = nuevaFila.puestoCarga.ReducirCola();
                        siguienteAvion.Cargando();
                        var rnd = GenerarRandom();

                        nuevaFila.finCarga.OcuparCarga(rnd, this.parametros.MediaCarga, nuevoReloj);
                    }
                    else
                    {
                        nuevaFila.finCarga.tiempoFinCarga = 0;
                        nuevaFila.puestoCarga.LiberarPuestoCarga();
                    }
                }
                
            }
            nuevaFila.ataqueVirus = primerAtaque(nuevaFila);
            nuevaFila.ataqueVirus.intencionOcultaVirus = "";
            return nuevaFila;
        }
        public double GenerarRandom()
        {
            return Math.Truncate(generadorRandom.NextDouble()*100)/100;
        }


    }
}
