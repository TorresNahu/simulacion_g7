﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulacion_G7.TP4_Montecarlo
{
    class Montecarlo
    {
        int cantDemandada;
        bool multa;

        double promedioNoSurtido;
        double promedioTirado;
        double promedioUtilidad;

        private Random rnd = new Random();

        public int determinarDemanda(double rndDemanda)
        {
            if (rndDemanda >= 0.0 && rndDemanda < 0.10)
            {
                cantDemandada = 10;
            }
            else if (rndDemanda >= 0.10 && rndDemanda < 0.30)
            {
                cantDemandada = 20;
            }
            else if (rndDemanda >= 0.30 && rndDemanda < 0.70)
            {
                cantDemandada = 25;
            }
            else if (rndDemanda >= 0.70 && rndDemanda < 0.80)
            {
                cantDemandada = 30;
            }
            else if (rndDemanda >= 0.80 && rndDemanda < 0.90)
            {
                cantDemandada = 50;
            }
            else if (rndDemanda >= 0.90 && rndDemanda < 0.95)
            {
                cantDemandada = 70;
            }
            else if (rndDemanda >= 0.95 && rndDemanda < 1.0)
            {
                cantDemandada = 100;
            }

            return cantDemandada;
        }
        public bool determinarMulta(double rndMulta)
        {

            if (rndMulta >= 0 && rndMulta < 0.25)
            {
                multa = true;
            }
            else if (rndMulta >= 0.25 && rndMulta < 1)
            {
                multa = false;
            }

            return multa;
        }

        private Double calculoPromedioNoSurtido(int cantidadExperimentos, int sumatoriaTortasNoSurtidas)
        {
            promedioNoSurtido = Math.Round(((double)sumatoriaTortasNoSurtidas / cantidadExperimentos), 2);
            return promedioNoSurtido;
        }
        private Double calculoPromedioTirado(int cantidadExperimentos, int sumatoriaTortasTiradas)
        {
            promedioTirado = Math.Round(((double)sumatoriaTortasTiradas / cantidadExperimentos), 2);
            return promedioTirado;
        }
        private Double calculoPromedioUtilidad(int cantidadExperimentos, int sumatoriaUtilidadDia)
        {
            promedioUtilidad = Math.Round(((double)sumatoriaUtilidadDia / cantidadExperimentos), 2);
            return promedioUtilidad;
        }

        public String resultadosSim(int cantidadExperimentos, int sumatoriaUtilidadDia, int sumatoriaTortasNoSurtidas, int sumatoriaTortasTiradas)
        {
            calculoPromedioNoSurtido(cantidadExperimentos, sumatoriaTortasNoSurtidas);
            calculoPromedioTirado(cantidadExperimentos, sumatoriaTortasTiradas);
            calculoPromedioUtilidad(cantidadExperimentos, sumatoriaUtilidadDia);

            string str = "Promedio de tortas no surtidas: " + promedioNoSurtido
                + "\nPromedio de tortas tiradas: " + promedioTirado
                + "\nPromedio de utilidad por dia: " + promedioUtilidad;

            return str;
        }

    }
}
