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
            simulacion = new SimulacionControl(f);
            simulacion.Dock = DockStyle.Fill;
            conclusion = new ConclusionControl(m);
            conclusion.Dock = DockStyle.Fill;
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            MostrarSimulacion();



        }

        private void btnConclusion_Click(object sender, EventArgs e)
        {
            //programar para mostrar la conclusion en el panel de resultados
            MostrarConclusion();
        }

        private void MostrarSimulacion()
        {

            pnResultados.Controls.Clear();
            pnResultados.Controls.Add(simulacion);
            // cambiar el backcolor del boton simulacion
            btnSimulacion.BackColor = Color.FromArgb(230, 230, 240);
            btnSimulacion.ForeColor = Color.FromArgb(28, 30, 40);
            // cambiar el backcolor del boton conclusion
            btnConclusion.BackColor = Color.FromArgb(28, 30, 40);
            btnConclusion.ForeColor = Color.FromArgb(230, 230, 240);

        }
        private void MostrarConclusion()
        {
            pnResultados.Controls.Clear();
            pnResultados.Controls.Add(conclusion);
            // cambiar el backcolor del boton simulacion
            btnConclusion.BackColor = Color.FromArgb(230, 230, 240);
            btnConclusion.ForeColor = Color.FromArgb(28, 30, 40);
            // cambiar el backcolor del boton conclusion
            btnSimulacion.BackColor = Color.FromArgb(28, 30, 40);
            btnSimulacion.ForeColor = Color.FromArgb(230, 230, 240);
        }

        private void ResultadosControl_SizeChanged(object sender, EventArgs e)
        {
            btnSimulacion.Width = pnResultados.Width / 2;
            btnConclusion.Width = pnResultados.Width / 2;
            btnConclusion.Location = new Point(btnSimulacion.Width, 0);
        }
    }
}
