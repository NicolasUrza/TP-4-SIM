using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public class PuestoCarga
    {
        public string estado { get; set; }
        public Queue<IAvion> cola { get; set; }

        public PuestoCarga()
        {
            estado = "Libre";
            cola = new Queue<IAvion>();
        }
        public PuestoCarga(PuestoCarga p, FilaSimulacion f)
        {
            //sirve para clonar un puesto de carga
                estado = p.estado;
            var c1 = new Queue<IAvion>();
            var c2 = new Queue<IAvion>();
            this.cola = new Queue<IAvion>();
            var n = p.cola.Count;
            for (int i = 0; i < n; i++)
            {
                var avion = p.cola.Dequeue();
                c1.Enqueue(avion);
                c2.Enqueue(avion);
            }
            
           
            for (int j = 0; j < n ; j++)
            {
                p.cola.Enqueue(c1.Dequeue());
                this.cola.Enqueue(f.BuscarAvion(c2.Dequeue()));
            }
        }
        public PuestoCarga(string estado, Queue<IAvion> cola)
        {
            this.estado = estado;
            this.cola = cola;
        }
        public void OcuparPuestoCarga()
        {
            estado = "Ocupado";
        }
        public void LiberarPuestoCarga()
        {

                estado = "Libre";
           
        }
        public void InterrumpirCarga()
        {
            estado = "Interrumpido";
            
        }

        public void AumentarCola(IAvion nuevoAvion)
        {
            cola.Enqueue(nuevoAvion);
            nuevoAvion.EsperandoCarga();
        }
        public bool EstaLibre()
        {
            return estado == "Libre";
        }

        public IAvion ReducirCola()
        {
            return cola.Dequeue();
        }
        public bool HayCola(){
            return cola.Count > 0;
        }
    }
}
