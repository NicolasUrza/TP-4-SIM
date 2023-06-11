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
    public partial class ResultadosControl : UserControl
    {
        private SimulacionControl simulacion;
        private ConclusionControl conclusion;
        public ResultadosControl(FilaSimulacion[] f, Metricas m)
        {
            InitializeComponent();
            simulacion = new SimulacionControl( f);
            simulacion.Dock = DockStyle.Fill;
            conclusion = new ConclusionControl(m);
            conclusion.Dock = DockStyle.Fill;
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            //programar para mostrar la simulacion en el panel de resultados
            
        }

        private void btnConclusion_Click(object sender, EventArgs e)
        {
            //programar para mostrar la conclusion en el panel de resultados
            pnResultados.Controls.Clear();
            pnResultados.Controls.Add(conclusion);

            conclusion.Dock = DockStyle.Fill;

            conclusion.Show();
        }

        private void pnResultados_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
