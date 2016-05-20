using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulacion_G7.TP4_Montecarlo
{
    public partial class EjerTortas : Form
    {
        int cantExp;
        int desde;
        int hasta;

        int sumUtilidadDia = 0;
        int sumTortasNoSurtidas = 0;
        int sumTortasTiradas = 0;

        public EjerTortas()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Principal main = new Principal();
            main.Show();
            Close();
        }

        private void EjerTortas_Load(object sender, EventArgs e)
        {
            txt_cantExperimentos.Focus();
            btn_resultados.Enabled = false;
            btn_tryAgain.Enabled = false;
        }

        private void btn_empezarSim_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                realizarSimulacion();

                btn_resultados.Enabled = true;
                btn_empezarSim.Enabled = false;
                btn_tryAgain.Enabled = true;
                txt_iteracionDesde.Enabled = false;
                txt_iteracionHasta.Enabled = false;
                txt_cantExperimentos.Enabled = false;
            }
        }

        private void realizarSimulacion()
        {
            Montecarlo sim = new Montecarlo();
            Random rnd = new Random();
            double randomDem;
            double randomMulta = 0;

            cantExp = int.Parse(txt_cantExperimentos.Text);
            desde = int.Parse(txt_iteracionDesde.Text);
            hasta = int.Parse(txt_iteracionHasta.Text);

            int cantDemandada;
            int cantComprada = 0;
            int tortasPorDia = 50;
            int multa;
            int utilidadDia;
            int utilidadPorTorta = 20;
            int tortasNoSurtidas = 0;
            int tortasTiradas = 0;
            bool deterMulta = false;
            
            for (int i = 0; i < cantExp; i++)
            {
                randomDem = rnd.NextDouble();
                cantDemandada = sim.determinarDemanda(randomDem);

                if (cantDemandada < tortasPorDia)
                {
                    cantComprada = cantDemandada;
                    randomMulta = rnd.NextDouble();
                    deterMulta = sim.determinarMulta(randomMulta);
                    tortasTiradas = tortasPorDia - cantComprada;
                    sumTortasTiradas += tortasTiradas;
                }
                else if (cantDemandada >= tortasPorDia)
                {
                    randomMulta = 0;
                    cantComprada = tortasPorDia;
                    tortasNoSurtidas = cantDemandada - cantComprada;
                    sumTortasNoSurtidas += tortasNoSurtidas;
                }

                //Utilidad del Dia.
                if (deterMulta == true)
                {
                    multa = 300;
                    utilidadDia = (cantComprada * utilidadPorTorta) - multa;
                    sumUtilidadDia += utilidadDia;
                }
                else
                {
                    utilidadDia = (cantComprada * utilidadPorTorta);
                    sumUtilidadDia += utilidadDia;
                }


                if (i >= (desde - 1) && i <= (hasta - 1)) // iteraciones a mostrar en grilla
                {
                    dgv_vectorEstado.Rows.Add((i + 1), randomDem, cantDemandada, randomMulta, deterMulta, utilidadDia, sumUtilidadDia, tortasNoSurtidas, sumTortasNoSurtidas, tortasTiradas, sumTortasTiradas);

                }

                if (true)
                {
                    tortasNoSurtidas = 0;
                    tortasTiradas = 0;    
                }
                
            }
        }
        
        private Boolean validar()
        {
            if (hasta < desde)
            {
                txt_iteracionDesde.Focus();
                MessageBox.Show("incongruencia en los intervalos", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_cantExperimentos.Text == string.Empty)
            {
                txt_cantExperimentos.Focus();
                MessageBox.Show("Llene los campos por favor", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_iteracionDesde.Text == string.Empty)
            {
                txt_iteracionDesde.Focus();
                MessageBox.Show("Llene los campos por favor", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_iteracionHasta.Text == string.Empty)
            {
                txt_iteracionHasta.Focus();
                MessageBox.Show("Llene los campos por favor", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void EjerTortas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal main = new Principal();
            main.Show();
        }
        private void btn_tryAgain_Click(object sender, EventArgs e)
        {
            tryAgain();

        }
        private void tryAgain()
        {
            txt_cantExperimentos.Focus();
            txt_iteracionDesde.Text = string.Empty;
            txt_iteracionHasta.Text = string.Empty;
            txt_cantExperimentos.Text = string.Empty;

            dgv_vectorEstado.Rows.Clear();

            txt_iteracionDesde.Enabled = true;
            txt_iteracionHasta.Enabled = true;
            txt_cantExperimentos.Enabled = true;

            btn_resultados.Enabled = false;
            btn_empezarSim.Enabled = true;
            btn_tryAgain.Enabled = false;
            desde = 0;
            hasta = 0;
            sumUtilidadDia = 0;
            sumTortasNoSurtidas = 0;
            sumTortasTiradas = 0;
        }

        private void btn_resultados_Click(object sender, EventArgs e)
        {
            resultados();
        }

        private void resultados()
        {
            Montecarlo doncarlo = new Montecarlo();
            string resultado;

            resultado = doncarlo.resultadosSim(cantExp, sumUtilidadDia, sumTortasNoSurtidas, sumTortasTiradas);

            MessageBox.Show(resultado, "Resultados de la Simulacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
