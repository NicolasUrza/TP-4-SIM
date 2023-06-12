using TP_4_SIM_Aeropuerto.Controlador;
using TP_4_SIM_Aeropuerto.Entidades;
using TP_4_SIM_Aeropuerto.Interfaces;

namespace TP_4_SIM_Aeropuerto
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private static double[] valoresIniciales = new double[] { 10, 6, 48, 5, 0.4, 0.6, 1, 3 };


      
        public bool ValidarParametros()
        {
            //programar
            return true;
        }

        public void CargarResultados(FilaSimulacion[] simulacion, Metricas metricas)
        {
            //programar
            //el controlador llama a este metodo para mostrar los resultados
            //limpiamos el panel
            this.pnSolucion.Controls.Clear();
            // creamos el control de resultados
            var res = new ResultadosControl(simulacion, metricas);
            res.Dock = DockStyle.Fill;

            //lo mostramos
            this.pnSolucion.Controls.Add(res);


        }

        private void btnGenerarSimulacion_Click_1(object sender, EventArgs e)
        {

            // cargamos los parametros
            // se podria poner un ValidarParametros() en lugar del try
            //try
            //{

                var param = new Parametros();
                param.MediaLlegadaAvion = double.Parse(this.txtLlegadaAvion.Text);
                param.MediaAterrizaje = double.Parse(this.txtAterrizaje.Text);
                param.MediaMuelle = double.Parse(this.txtMediaMuelle.Text);
                param.MediaCarga = double.Parse(this.txtMediaCarga.Text);
                param.IntencionCarga = double.Parse(this.txtIntencionCarga.Text);
                param.IntencionMuelle = double.Parse(this.txtIntencionMuelle.Text);
                param.AerolineaA = int.Parse(this.txtAerolineaA.Text);
                param.AerolineaB = int.Parse(this.txtAerolineaB.Text);
                param.CantidadDeIteraciones = int.Parse(this.txtCantIteraciones.Text);
                param.Desde = int.Parse(this.txtDesde.Text);
                var controlador = new ControladorSimulacion(this, param);

                controlador.GenerarSimulacion();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Los parametros ingresados no son validos", "informacion", MessageBoxButtons.OK);
            //    return;
            //}
        }

        private void Principal_Load_1(object sender, EventArgs e)
        {
            this.txtLlegadaAvion.Text = valoresIniciales[0].ToString();
            this.txtAterrizaje.Text = valoresIniciales[1].ToString();
            this.txtMediaMuelle.Text = valoresIniciales[2].ToString();
            this.txtMediaCarga.Text = valoresIniciales[3].ToString();
            this.txtIntencionCarga.Text = valoresIniciales[4].ToString();
            this.txtIntencionMuelle.Text = valoresIniciales[5].ToString();
            this.txtAerolineaA.Text = valoresIniciales[6].ToString();
            this.txtAerolineaB.Text = valoresIniciales[7].ToString();
        }
    }
}