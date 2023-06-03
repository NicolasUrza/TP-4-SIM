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
           



            // calcular las metricas
            var metricas = new Metricas();
            //deovlvemos los resultados al form
            this.principalForm.CargarResultados(resultadosDesde, metricas);

        }
        //Eventos
        //programar lo que pasaria en cada caso
        public FilaSimulacion LlegadaAvion()
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion FinAterrizaje()
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion FinCarga()
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion FinOperaciones()
        {
            return new FilaSimulacion();
        }
        public FilaSimulacion LlegadaAvionAerolinea() {

            return new FilaSimulacion();
        }
    

    }
}
