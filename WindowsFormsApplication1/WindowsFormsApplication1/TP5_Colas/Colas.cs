using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simulacion_G7.TP3;

namespace WindowsFormsApplication1.TP5_Colas
{
    class Colas
    {
        string demora;        
        double min;
        double rnd = 0;

        //TP6
        int tam_Inestabilidad;
        double t_50 = 215.8;
        double t_80 = 259.8;
        double t_100 = 280.7;
        //double alfa = 0.01068;

        public string determinarDemora(double rndDemora)
        {
            if (rndDemora >= 0.0 && rndDemora < 0.20)
            {
                demora = "Si";
            }
            else if (rndDemora >= 0.20 && rndDemora < 1)
            {
                demora = "No";
            }
            return demora;
        }

        public double determinarMenor(double proxLlegada, double fin_est1, double fin_est2, double fin_est3, double fin_est4, double fin_est5, double proxInspeccion, double fin_inspeccion, double proxInterrup)
        {
            double[] lis = new double[] { proxLlegada, fin_est1, fin_est2, fin_est3, fin_est4, fin_est5, proxInspeccion, fin_inspeccion, proxInterrup };
            for (int i = 0; i < lis.Length; i++)
            {
                if (i == 0)
                {
                    min = lis[i];
                }
                if (lis[i] < min && lis[i] != 0)
                {
                    min = lis[i];
                }
            }

            return min;
        }

        public int determinarTamanoInestabilidad(double prob)
        {
            if (prob >= 0.0 && prob < 0.20)
            {
                tam_Inestabilidad = 50;

            }
            else if (prob >= 0.20 && prob < 0.50)
            {
                tam_Inestabilidad = 80;

            }
            else if (prob >= 0.50 && prob < 1)
            {
                tam_Inestabilidad = 100;

            }
            return tam_Inestabilidad;
        }

        public double determinarTiempoInterrupcion(double tamano)
        {
            if (tamano == 50)
            {
                return t_50;
            }
            else if (tamano == 80)
            {
                return t_80;
            }
            else if (tamano == 100)
            {
                return t_100;
            }
            return 0;
        }

    }
}
