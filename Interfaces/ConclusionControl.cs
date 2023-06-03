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
            //programar para mostrar las conclusiones
            
        }
    }
}
