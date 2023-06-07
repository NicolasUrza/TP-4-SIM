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
        public ControladorSimulacion( Principal pri, Parametros par)
        {
            this.principalForm = pri;
            this.parametros = par;
            resultadosDesde = new FilaSimulacion[par.CantidadDeIteraciones - par.Desde];

        }

        public void GenerarSimulacion()
        {
            //programar
            //simulacion, usar los parametros de la inicializacion
            var filaActual = new FilaSimulacion();
            //hacemos un for hasta la cantidad de iteraciones
            for(int i=0; i< parametros.CantidadDeIteraciones; i++)
            {
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
                else if(proximoEstado == "fin_de_carga")
                {
                    filaActual = FinCarga(filaActual, nuevoReloj);
                }

                //programar
                //guardar la fila actual en el array de resultadosDesde si corresponde
                // guardar hasta 500 desde el Parametro.desde
                
            }
            
            // calcular las metricas
            var metricas = new Metricas();
            // aca calcular las metricas con los acumuladores que quedaron guardados en la ultima fila
            
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
            //programar
            return new FilaSimulacion();
        }
        public FilaSimulacion FinOperaciones(FilaSimulacion filaActual, double nuevoReloj)
        {
            var nuevaFila = new FilaSimulacion(filaActual);
            nuevaFila.evento = "fin_operaciones";
            nuevaFila.reloj = nuevoReloj;
            //programar
            return new FilaSimulacion();
        }
        public FilaSimulacion LlegadaAvionAerolinea(FilaSimulacion filaActual, double nuevoReloj)
        {
            var nuevaFila = new FilaSimulacion(filaActual);
            nuevaFila.evento = "llegada_avion_aerolinea";
            nuevaFila.reloj = nuevoReloj;
            //programar
            var rnd = generadorRandom.NextDouble();
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
                nuevaFila.avionesAerolinea.Append(avionAero);
                nuevaFila.finAterrizaje = finAterrizaje;
            }

            return nuevaFila;
        }
    

    }
}
