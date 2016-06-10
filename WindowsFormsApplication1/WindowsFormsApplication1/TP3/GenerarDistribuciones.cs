using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_G7.TP3
{
    class GenerarDistribuciones
    {
        private double nuevo_aleatorio;
        private Random rnd = new Random();
        private double random;

        public double[] generar_distibucion_uniforme(int a, int b, int cantidad_a_generar)
        {
            double[] lista = new double[cantidad_a_generar];
            for (int i = 0; i < cantidad_a_generar; i++)
            {
                random = rnd.NextDouble();
                nuevo_aleatorio = a + random * (b - a);
                lista[i] = nuevo_aleatorio;
            }
            return lista;
        }

        public double[] generar_distribucion_exponencial(float lambda, int cantidad_a_generar)
        {
            double[] lista = new double[cantidad_a_generar];

            for (int i = 0; i < cantidad_a_generar; i++)
            {
                random = rnd.NextDouble();
                nuevo_aleatorio = (-1 / lambda) * Math.Log(1 - random);
                lista[i] = nuevo_aleatorio;
            }
            return lista;
        }

        public double[] generar_distribucion_poisson(float lambda, int cantidad_a_generar)
        {
            double[] lista = new double[cantidad_a_generar];
            double p;
            int x;
            double a;
            //metodo 
            for (int i = 0; i < cantidad_a_generar; i++)
            {
                p = 1;
                x = -1;
                a = Math.Pow((Math.E), -lambda);
                do
                {
                    random = rnd.NextDouble();
                    p = p * random;
                    x = x + 1;
                } while (p >= a);
                lista[i] = x;
            }
            return lista;
        }

        public double[] generar_distribucion_normal(float media, float desviacion_estandar, int cantidad_a_generar)
        {
            if ((cantidad_a_generar%2)!=0)
            {
                cantidad_a_generar++;
            }
            double[] lista = new double[cantidad_a_generar];
            double pi = Math.PI;

            //metodo
            for (int i = 0; i < cantidad_a_generar; i = i + 2)
            {
                double random1 = rnd.NextDouble();
                double random2 = rnd.NextDouble();
                double aux1;
                double aux2;
                //Estos son para N(0,1)
                double x1;
                double x2;
                //Estos son para N(DesvEst, Media)
                double X1;
                double X2;

                aux1 = -2 * Math.Log(random1);
                aux2 = 2 * pi * random2;

                x1 = Math.Sqrt(aux1) * Math.Cos(aux2);
                x2 = Math.Sqrt(aux1) * Math.Sin(aux2);

                X1 = (x1 * desviacion_estandar) + media;
                X2 = (x2 * desviacion_estandar) + media;

                lista[i] = X1;
                lista[i + 1] = X2;
            }

            return lista;
        }
    }
}

