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
        private Random generadorRandom = new Random();
        private bool desdeActivado = false; // para matar no para desligar-destruir 


        public ControladorSimulacion( Principal pri, Parametros par)
        {
            this.principalForm = pri;
            this.parametros = par;
            if(parametros.CantidadDeIteraciones < parametros.Desde + 499)
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
                else if (i > parametros.Desde + 499)
                {
                    desdeActivado = false;
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


                //programar
               

                

            }

            // calcular las metricas
            var metricas = new Metricas();
            // aca calcular las metricas con los acumuladores que quedaron guardados en la ultima fila

            metricas.tiempoEsperaPromedioAterrizaje = filaActual.acumuladores.totalAvionesAterr >0? filaActual.acumuladores.acumTiempoEsperaAterr / filaActual.acumuladores.totalAvionesAterr:0;

            metricas.porcentajeAterrGratis = filaActual.acumuladores.totalAvionesAterr >0 ? (filaActual.acumuladores.cantAvionesAterrGratis / filaActual.acumuladores.totalAvionesAterr) * 100: 0;

            metricas.porcentajeCargaronCombustible = filaActual.acumuladores.totalAvionesAterr > 0? (filaActual.acumuladores.cantAvionesCargaron / filaActual.acumuladores.totalAvionesAterr) * 100 :0;

            metricas.beneficiosPorHora = ((filaActual.acumuladores.cantAvionesAterrDescuento * 3000) + (filaActual.acumuladores.totalAvionesAterr * 6000)) / filaActual.reloj;

            //deovlvemos los resultados al form
            this.principalForm.CargarResultados(resultadosDesde, metricas);

        }
        //Eventos
        //programar lo que pasaria en cada caso
        public FilaSimulacion LlegadaAvion(FilaSimulacion filaActual,double nuevoReloj)
        {
            var nuevaFila = new FilaSimulacion(filaActual);
            nuevaFila.evento = "llegada_avion";
            nuevaFila.reloj = nuevoReloj;
            //programar

            return new FilaSimulacion();
        }
        public FilaSimulacion FinAterrizaje(FilaSimulacion filaActual, double nuevoReloj)
        {
 
            var nuevaFila = new FilaSimulacion(filaActual);
            nuevaFila.evento = "fin_aterrizaje";
            nuevaFila.reloj = nuevoReloj;
            // programar

            return new FilaSimulacion();
        }
        public FilaSimulacion FinCarga(FilaSimulacion filaActual, double nuevoReloj)
        {
            var nuevaFila = new FilaSimulacion(filaActual);
            nuevaFila.evento = "fin_carga";
            nuevaFila.reloj = nuevoReloj;
            // mato y libero al puesto de cargga y avion 
            nuevaFila.puestoCarga.LiberarPuestoCarga();
           
           foreach (var avion in nuevaFila.avionesAerolinea)
           {
                if (desdeActivado && avion.estado =="C")
                {
                    avion.MATAR();
                    break;
                }
                if (!desdeActivado && avion.estado =="C")
                {
                    nuevaFila.avionesAerolinea.Remove(avion);
                }

           }
           foreach (var avion in nuevaFila.aviones)
            {
                if (desdeActivado && avion.estado == "C")
                {
                    avion.MATAR();
                    break;
                }
                if (!desdeActivado && avion.estado == "C")
                {
                    nuevaFila.aviones.Remove(avion);
                }

            }

           // compruevo cola y ocupo servidor, y cambio estado avion
            if (nuevaFila.puestoCarga.cola != 0 )
            {
                nuevaFila.puestoCarga.OcuparPuestoCarga();

                var banderaPrioridad = false;

                foreach (var avion in nuevaFila.avionesAerolinea)
                {
                    if (avion.estado == "EC")
                    {
                        avion.Cargando();
                        banderaPrioridad = true;
                        break;
                    }

                }

                if (!banderaPrioridad)
                {
                    foreach (var a in nuevaFila.aviones)
                    {
                        if (a.estado == "EC")
                        {
                            a.Cargando();

                            break;
                        }
                    }
                }


            }
            var rnd = GenerarRandom();

            nuevaFila.finCarga.OcuparCarga(rnd, this.parametros.MediaCarga, nuevoReloj); 

            return  nuevaFila;
        }
        public FilaSimulacion FinOperaciones(FilaSimulacion filaActual, double nuevoReloj)
        {
            var nuevaFila = new FilaSimulacion(filaActual);
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

            nuevaFila.finOperacion.ocuparMuelle(rnd, this.parametros.MediaMuelle, muelleOcupar, avionOcupa, nuevoReloj);
            return nuevaFila;
        }




        public FilaSimulacion LlegadaAvionAerolinea(FilaSimulacion filaActual, double nuevoReloj)
        {
            var nuevaFila = new FilaSimulacion(filaActual);
            nuevaFila.evento = "llegada_avion_aerolinea";
            nuevaFila.reloj = nuevoReloj;
            //programar
            var rnd = GenerarRandom();
            var nuevaLlegadaAerolinea = new LlegadaAvionAerolinea(rnd, parametros.AerolineaA, parametros.AerolineaB, nuevoReloj);
            if (filaActual.buscarAterrizaje())
            {
                var avionAero = new AvionAerolinea("EP", nuevoReloj);
                nuevaFila.pista.AumentarColaPrioritaria();
                nuevaFila.avionesAerolinea.Append(avionAero);
            }
            else
            {
                //cuando no hay aviones aterrizando
                var rndAterrizaje = generadorRandom.NextDouble();
                var finAterrizaje = new FinAterrizaje(rnd, parametros.MediaAterrizaje, nuevoReloj);
                var avionAero = new AvionAerolinea("AT", nuevoReloj);
                nuevaFila.avionesAerolinea.Add(avionAero);
                nuevaFila.finAterrizaje = finAterrizaje;

            }
            nuevaFila.llegadaAvionAerolinea = nuevaLlegadaAerolinea;

            return nuevaFila;
        }

        public double GenerarRandom()
        {
            return Math.Truncate(generadorRandom.NextDouble()*100)/100;
        }


    }
}
