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
        public Muelle[] muelles { get; set; }
        public FinOperacion()
        {
            muelles = new Muelle[5];
            for (int i = 0; i < 5; i++)
            {
                muelles[i] = new Muelle();
            }
        }
        public FinOperacion(FinOperacion finOperacion, FilaSimulacion filaActual, bool keep = false)
        {
            if (keep)
            {
                rnd = finOperacion.rnd;
                tiempo = finOperacion.tiempo;
            }

            var muelles = new Muelle[5];
            var i = 0;
            foreach (Muelle m in finOperacion.muelles)
            {
                muelles[i] = new Muelle(m, filaActual);
                i++;
            }
            this.muelles = muelles;

        }
        public FinOperacion(double rnd, double tiempo, double mediaMuelle, Muelle[] muelles)
        {
            this.rnd = rnd;
            this.tiempo = tiempo;
            this.muelles = muelles;

        }

        public void calcularSiguienteFin()
        {
            this.tiempo = GeneradorAleatorios.GenerarExponencial(this.rnd, mediaMuelle);
        }

        public bool HayMuelleLibre()
        {
                foreach (Muelle m in muelles)
                {
                    if (m.estado == "Libre")
                    {
                        return true;
                    }
                }
                return false;
        }
        public Muelle BuscarMuelleLibre()
        {
            foreach (var m in muelles)
            {
                if (m.estado == "Libre")
                {
                    return m; 
                }
            }
            return muelles[0];
        }
        public void ocuparMuelle(double rnd, double media, Muelle muelle, IAvion a, double reloj)
        {
            this.rnd = rnd;
            this.mediaMuelle = media;
            a.EnMuelle();
            calcularSiguienteFin();

            muelle.OcuparMuelle(this.tiempo+reloj, a);


        }



        public Muelle BuscarMuelleOcupado(double reloj)
        {
            foreach (Muelle muell in muelles)
            {
                if (muell.horaFin == reloj)
                {
                    return muell;
                }
            }
            return new Muelle();
        }


        public double ProximoFinOperacion()
        {
            double horaFin = this.muelles[0].horaFin;
            for (int i = 1; i < 5; i++)
            {
                if ((muelles[i].horaFin < horaFin && muelles[i].horaFin != 0) || horaFin == 0)
                {
                    horaFin = muelles[i].horaFin;
                }

            }
            return horaFin;
        }





    }
}
