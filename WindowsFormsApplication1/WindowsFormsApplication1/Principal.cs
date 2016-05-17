using Simulacion_G7.TP3.Generar_Distribuciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion_G7
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_tp3_Click(object sender, EventArgs e)
        {
            Generar_distribuciones form = new Generar_distribuciones();
            form.Show();
            this.Hide();
        }
        private void btn_tp4_Click(object sender, EventArgs e)
        {
            TP4_Montecarlo.EjerTortas form = new TP4_Montecarlo.EjerTortas();
            form.Show();
            this.Hide();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
