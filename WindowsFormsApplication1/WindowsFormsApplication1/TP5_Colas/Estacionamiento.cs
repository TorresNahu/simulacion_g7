using Simulacion_G7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.TP5_Colas
{
    public partial class Estacionamiento : Form
    {
        public Estacionamiento()
        {
            InitializeComponent();
        }

        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            /*
            dgv_sim.Columns.Add("reloj", "Reloj");
            dgv_sim.Columns.Add("rdn_llegada", "RND Llegada vehiculo");
            dgv_sim.Columns.Add("tiempo_sig_llegada", "Tiempo Siguiente Llegada");
            dgv_sim.Columns.Add("prox_llegada", "Próxima llegada");
            dgv_sim.Columns.Add("rdn_fin_estac", "RND Fin estacionamiento");
            dgv_sim.Columns.Add("tiempo_uso_est", "Tiempo uso estacionamiento");
            dgv_sim.Columns.Add("rdn_demora", "RND Demora estacionamiento");
            dgv_sim.Columns.Add("fin_estacionamiento_1", "Fin estacionamiento 1");
            dgv_sim.Columns.Add("fin_estacionamiento_2", "Fin estacionamiento 2");
            dgv_sim.Columns.Add("fin_estacionamiento_3", "Fin estacionamiento 3");
            dgv_sim.Columns.Add("fin_estacionamiento_4", "Fin estacionamiento 4");
            dgv_sim.Columns.Add("fin_estacionamiento_5", "Fin estacionamiento 5");
            dgv_sim.Columns.Add("estado_lugar_1", "Estado lugar 1");
            dgv_sim.Columns.Add("estado_lugar_2", "Estado lugar 2");
            dgv_sim.Columns.Add("estado_lugar_3", "Estado lugar 3");
            dgv_sim.Columns.Add("estado_lugar_4", "Estado lugar 4");
            dgv_sim.Columns.Add("estado_lugar_5", "Estado lugar 5");
            dgv_sim.Columns.Add("estado_inspector", "Estado inspector");
            dgv_sim.Columns.Add("prox_inspeccion", "Próxima inspeccion");
            dgv_sim.Columns.Add("fin_inspeccion", "Fin inspeccion");
            dgv_sim.Columns.Add("acum_multas", "Acum multas");
            dgv_sim.Columns.Add("acum_autos_sin_estacionar", "Acum autos sin estacionar");
            dgv_sim.Columns.Add("vehiculo_estado", "Estado vehiculo");
            dgv_sim.Columns.Add("hora_inicio_espera", "Hora Inicio Espera");
            */
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

        }

        private bool validar()
        {
            if (int.Parse(txt_iteracionHasta.Text) < int.Parse(txt_iteracionDesde.Text))
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
        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Principal main = new Principal();
            main.Show();
            Close();
        }

        private void Estacionamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal main = new Principal();
            main.Show();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            InfoAboutProblem iap = new InfoAboutProblem();
            iap.Show();
        }
    }
}
