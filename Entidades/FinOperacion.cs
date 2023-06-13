using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class FinOperacion
    {
        public double rnd { get; set; }
        public double tiempo { get; set; }
        public double mediaMuelle { get; set; }
        public List<Muelle> muelles { get; set; } 
        public FinOperacion()
        {
            muelles = new List<Muelle>();
            for (int i =0; i < 5; i++)
            {
                muelles.Add(new Muelle());
            }
        }
        public FinOperacion(double rnd, double tiempo, double mediaMuelle, List<Muelle> muelles)
        {
            this.rnd = rnd;
            this.tiempo = tiempo;
            this.mediaMuelle = mediaMuelle;
            this.muelles = muelles;
        }
        public FinOperacion(FinOperacion finOperacion, bool keep = false)
        {
            if (keep)
            {
                rnd = finOperacion.rnd;
                tiempo = finOperacion.tiempo;
            }
           
            var muelles = new List<Muelle>();
            finOperacion.muelles.ForEach(muelle =>  muelles.Add(new Muelle(muelle)));
            this.muelles = muelles;
        }
        public void calcularSiguienteFin()
        {
            this.tiempo = GeneradorAleatorios.GenerarExponencial(this.rnd, this.mediaMuelle);
        }
        public void ocuparMuelle(double reloj, IAvion avion)
        {
            this.calcularSiguienteFin();

            var indexItemToUpdate = this.muelles.FindIndex(x => x.estado == "Libre");
            if (indexItemToUpdate != -1)
            {
                this.muelles[indexItemToUpdate].estado = "Ocupado";
                this.muelles[indexItemToUpdate].horaFin = reloj + this.tiempo;
                this.muelles[indexItemToUpdate].avionEnMuelle = avion;
            }
        }
        public Muelle BuscarMuelleOcupado(double reloj)
        {
            foreach (Muelle muell in muelles)
            {
                if (muell.horaFin== reloj)
                {
                    return muell;
                }
            }
            return new Muelle();
        }

        public List<Muelle> BuscarMuellesLibres()
        {
            return muelles.FindAll(x => x.estado == "Libre");
        }

        
    }
}
