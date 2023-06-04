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
                var proximoEstado = filaActual.siguienteEventoyReloj();
                // ejecutamos el evento
                // completar con todos los else
                if (proximoEstado.Item1 == "llegada_avion")
                {
                    LlegadaAvion(filaActual);
                }

                //programar
                //guardar la fila actual en el array de resultadosDesde si corresponde

            }



            // calcular las metricas
            var metricas = new Metricas();
            //deovlvemos los resultados al form
            this.principalForm.CargarResultados(resultadosDesde, metricas);

        }
        //Eventos
        //programar lo que pasaria en cada caso
        public FilaSimulacion LlegadaAvion(FilaSimulacion filaActual)
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion FinAterrizaje(FilaSimulacion filaActual)
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion FinCarga(FilaSimulacion filaActual)
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion FinOperaciones(FilaSimulacion filaActual)
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion LlegadaAvionAerolinea(FilaSimulacion filaActual) {

            return new FilaSimulacion();
        }
    

    }
}
