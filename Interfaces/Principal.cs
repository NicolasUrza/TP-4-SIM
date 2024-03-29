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
            try{
                var cantIter = double.Parse(txtCantIteraciones.Text);
                var desde = double.Parse(txtDesde.Text);
                double.Parse(txtLlegadaAvion.Text);
                var a = double.Parse(txtAerolineaA.Text);
                var b = double.Parse(txtAerolineaB.Text);
                Convert.ToDouble(txtMediaCarga.Text);
                Convert.ToDouble(txtMediaMuelle.Text);

                if (Convert.ToDouble(txtIntencionCarga.Text) > 1 || Convert.ToDouble(txtIntencionMuelle.Text) > 1)
                {
                    MessageBox.Show("El valor de la intencion de carga debe estar entre 0 y 1");
                    return false;
                }
                if (Convert.ToDouble(txtIntencionCarga.Text) + Convert.ToDouble(txtIntencionMuelle.Text) != 1)
                {
                    MessageBox.Show("La suma de las intenciones debe ser 1");
                    return false;
                }
                if(a > b)
                {
                    MessageBox.Show("El limite Inferior de la llegada de avion de aerolinea no debe superar su limite superior");
                    return false;
                }
                if (desde > cantIter)
                {
                    MessageBox.Show("La cantidad de iteraciones debe ser mayor a la cantidad de iteraciones desde");
                    return false;

                }
                if(desde <= 0)
                {
                    MessageBox.Show("La cantidad de iteraciones desde debe ser mayor 0");
                    return false;
                }
                

            }
            catch (Exception e)
            {
                MessageBox.Show("Verifique los valores ingresados");
                return false;
            }
            //programar


            return true;
        }

        public void CargarResultados(FilaSimulacion[] simulacion, List<RungeKuta> rungeKutas, Metricas metricas)
        {
            //programar
            //el controlador llama a este metodo para mostrar los resultados
            //limpiamos el panel
            this.pnSolucion.Controls.Clear();
            // creamos el control de resultados
            var res = new ResultadosControl(simulacion,rungeKutas, metricas);
            res.Dock = DockStyle.Fill;

            //lo mostramos
            this.pnSolucion.Controls.Add(res);


        }

        private void btnGenerarSimulacion_Click_1(object sender, EventArgs e)
        {


                if (ValidarParametros())
                {
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

                }
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

        private void txtLlegadaAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
           
        }

        private void txtAterrizaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMediaMuelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtMediaCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAerolineaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtAerolineaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }

        private void txtCantIteraciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIntencionCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtIntencionMuelle_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIntencionMuelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void txtIntencionCarga_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}