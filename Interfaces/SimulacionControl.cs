using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_4_SIM_Aeropuerto.Entidades;

namespace TP_4_SIM_Aeropuerto.Interfaces
{
    public partial class SimulacionControl : UserControl
    {
        private FilaSimulacion[] simulacion;
        public SimulacionControl(FilaSimulacion[] f)
        {
            InitializeComponent();
            this.simulacion = f;
            CargarSimulacion();
        }
        private void CargarSimulacion()
        {
            //programar para cargar la simulacion en un dgv
            //usar el metodo ListaString() de FilaSimulacion() para cargarlas
            
        }
    }
}
