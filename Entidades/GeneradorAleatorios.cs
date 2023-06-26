using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP_4_SIM_Aeropuerto.Entidades
{
    public static class GeneradorAleatorios
    {
        public static double GenerarExponencial(double rnd, double media)
        {
            var lambda = 1 / media;
            var muestra = Math.Truncate((-Math.Log(1 - rnd) / lambda) * 100) / 100;
            return muestra; 
        }
        public static double GenerarUniformeAB(double rnd, int a, int b)
        {
            return (Math.Truncate((rnd * (b - a) + a) * 100) / 100);
       
        }

        public static RungeKuta GenerarRungeKuta(double H, double Xo, double Yo, double Yf, int Equation)
        {
            int counter = 0;
            RungeKuta solucion = new RungeKuta();
            FilaRunge filaActual = new FilaRunge();

            do
            {
                // Si el counter es cero el x e y seran iguales a los iniciales
                if (counter == 0)
                {
                    filaActual.xi = Xo;
                    filaActual.yi = Yo;

                    // sumo al counter, esto se hara una sola vez porque una sola vez valdra cero para que entre en este if y no gasto recursos sumandole siempre
                    counter++;
                }
                else
                {
                    // Si no es la primera vuelta entonces el valor xi e yi sera igual a los que corresponden a Xsiguiente e Ysiguiente en la fila anterior
                    filaActual.xi = filaActual.nextXi;
                    filaActual.yi = filaActual.nextYi;
                }

                // Obtengo todos los K
                filaActual.k1 = ObtainK1(filaActual.xi, filaActual.yi, Equation);
                filaActual.k2 = ObtainK23(filaActual.xi, filaActual.yi, H, filaActual.k1, Equation);
                filaActual.k3 = ObtainK23(filaActual.xi, filaActual.yi, H, filaActual.k2, Equation);
                filaActual.k4 = ObtainK4(filaActual.xi, filaActual.yi, H, filaActual.k3, Equation);

                // Obtengo los valores siguientes de X e Y
                filaActual.nextXi = ObtainNextX(filaActual.xi, H);
                filaActual.nextYi = ObtainNextY(filaActual.yi, H, filaActual.k1, filaActual.k2, filaActual.k3, filaActual.k4);
                
                // Lo agrego al DGV
                solucion.AñadirFila(filaActual);

                if (filaActual.nextYi - filaActual.yi < 1 && Equation ==1)
                {
                    solucion.resultado = filaActual.nextXi;
                    return solucion;
                }

                // Este while chequea que se haya alcanzado la condicion del ejercicio sino seguimos aplicando metodo runge kutta
            } while (filaActual.yi < Yf && Equation == 0 || filaActual.nextYi - filaActual.yi < 1 && Equation ==1 || filaActual.yi < Yf && Equation == 2);

            // obtengo la solucion que podria ser tiempo por ejemplo en nuestra simulacion
            solucion.resultado = filaActual.xi;
            return solucion; 
        }
        
            private static double calculateK(double x, double y, int Equation)
        {

            if(Equation == 0)
            {
                double k = x * y;
                return k;
            }
            else if (Equation ==1)
            {
                double k =  -(y / (0.8 * (x*x))) - y;
                return k;
            }
            else if (Equation == 2)
            {
                double k = (0.2 * y) + 3 - x;
                return k;
            }


            return 0.1;
        }

       

        private static Tuple<double, double> calculateMidPoint(double x, double y, double h, double k)
        {
            // Con esto calculo los puntos medios para obtener posteriormente k2 y k3
            double xMidPoint = x + (h / 2);
            double yMidPoint = y + (h / 2 * k);

            Tuple<double, double> midPoints = new Tuple<double, double>(xMidPoint, yMidPoint);

            return midPoints;
        }

        private static double ObtainNextX(double x, double h)
        {
            // Siguiente valor de X
            double x1plus1 = x + h;
            return x1plus1;
        }

        private static double ObtainNextY(double y, double h, double k1, double k2, double k3, double k4)
        {
            // Siguiente valor de Y
            double y1plus1 = y + ((h / 6) * (k1 + 2 * k2 + 2 * k3 + k4));
            return y1plus1;
        }



        private static double ObtainK1(double x, double y, int Equation)
        {
            // K1 directamente aplica formula 
            double k1 = calculateK(x, y,Equation);

            return k1;
        }

        private static double ObtainK23(double x, double y, double h, double k , int Equation)
        {
            //K2 y K3 se calculan de la misma forma nomas que varia el k que le estas mandando por eso lo unifique en un solo metodo ObtainK23

            // Calculo el punto medio
            Tuple<double, double> midPoints = calculateMidPoint(x, y, h, k);

            double kx = calculateK(midPoints.Item1, midPoints.Item2, Equation);

            return kx;
        }




        private static double ObtainK4(double x, double y, double h, double k3, int Equation)
        {

            //Obtengo los valores siguientes y los uso para calcular el k4
            double x1plus1 = ObtainNextX(x, h);
            double yplushk3 = y + (h * k3);
            double k4 = calculateK(x1plus1, yplushk3, Equation);
            return k4;
        }

    }
}
