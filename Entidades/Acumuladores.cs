using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class Acumuladores
    {
        public int cantAvionesAterrGratis { get; set; }
        public int cantAvionesCargaron { get; set; }
        public double acumTiempoEsperaAterr { get; set; }
        public int totalAvionesAterr { get; set; }
        public int cantAvionesAterrDescuento { get; set; }
        public Acumuladores()
        {
            cantAvionesAterrGratis = 0;
            cantAvionesCargaron = 0;
            acumTiempoEsperaAterr = 0;
            totalAvionesAterr = 0;
            cantAvionesAterrDescuento = 0;
        }
        public Acumuladores(Acumuladores a)
        {
            cantAvionesAterrGratis = a.cantAvionesAterrGratis;
            cantAvionesCargaron = a.cantAvionesCargaron;
            acumTiempoEsperaAterr = a.acumTiempoEsperaAterr;
            totalAvionesAterr = a.totalAvionesAterr;
            cantAvionesAterrDescuento = a.cantAvionesAterrDescuento;
        }
        public Acumuladores(int cantAvionesAterrGratis, int cantAvionesCargaron, double acumTiempoEsperaAterr, int totalAvionesAterr, int cantAvionesAterrDescuento)
        {
            this.cantAvionesAterrGratis = cantAvionesAterrGratis;
            this.cantAvionesCargaron = cantAvionesCargaron;
            this.acumTiempoEsperaAterr = acumTiempoEsperaAterr;
            this.totalAvionesAterr = totalAvionesAterr;
            this.cantAvionesAterrDescuento = cantAvionesAterrDescuento;
        }
        public void AumentarAvionesAterrGratis(){
            cantAvionesAterrGratis++;
        }
        public void AumentarAvionesCargaron()
        {
            cantAvionesCargaron++;
        }
        public void AumentarAcumTiempoEsperaAterr(double tiempo)
        {
            acumTiempoEsperaAterr += tiempo;
            acumTiempoEsperaAterr = Math.Truncate(acumTiempoEsperaAterr * 100) / 100;
        }
        public void AumentarTotalAvionesAterr()
        {
            totalAvionesAterr++;
        }
        public void AumentarAvionesAterrDescuento()
        {
            cantAvionesAterrDescuento++;
        }

    }
}
