using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_4_SIM_Aeropuerto.Entidades;

namespace TP_4_SIM_Aeropuerto.Interfaces
{
    public partial class ConclusionControl : UserControl
    {
        private Metricas resultadosSimulacion;
        public ConclusionControl( Metricas m)
        {
            InitializeComponent();
            this.resultadosSimulacion = m;
            CargarConclusion();
        }
        private void CargarConclusion()
        {
            porcAterrFree.Text = (Math.Truncate(resultadosSimulacion.porcentajeAterrGratis*100)/100).ToString() + "%";
            porcCargoComb.Text = (Math.Truncate(resultadosSimulacion.porcentajeCargaronCombustible * 100) / 100).ToString() + "%";
            tiempoMedioAt.Text = (Math.Truncate(resultadosSimulacion.tiempoEsperaPromedioAterrizaje * 100) / 100).ToString() + " minutos";
            benefPorHora.Text = "€ " + (Math.Truncate(resultadosSimulacion.beneficiosPorHora * 100) / 100).ToString();
        }
    }
}
