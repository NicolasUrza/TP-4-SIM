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
    public partial class RungeKutaControl : UserControl
    {
        private List<RungeKuta> rungeKutas;
        private int indice;
        public RungeKutaControl()
        {
            InitializeComponent();
        }
        public RungeKutaControl(List<RungeKuta> rg)
        {
            
            InitializeComponent();
            this.rungeKutas = rg;
            this.indice = 0;
            this.btnAnterior.Enabled = false;
            if(rungeKutas.Count == indice + 1)
            {
                this.btnSiguiente.Enabled = false;
            }
            MostrarRunge();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarRunge()
        {
            this.dgvRungeKuta.Rows.Clear();
            foreach (FilaRunge fila in rungeKutas[indice].filasRunge)
            {
                this.dgvRungeKuta.Rows.Add(fila.ListaString());
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.indice--;
            btnSiguiente.Enabled = true;
            if (indice == 0)
            {
                btnAnterior.Enabled = false;
            }
            MostrarRunge();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.indice++;
            btnAnterior.Enabled = true;
            if (indice == rungeKutas.Count - 1)
            {
                btnSiguiente.Enabled = false;
            }

            MostrarRunge();
        }
    }
}
