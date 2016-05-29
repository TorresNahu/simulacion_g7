using Simulacion_G7.TP3.Generar_Distribuciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.TP5_Colas;

namespace Simulacion_G7
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btn_tp3_Click_1(object sender, EventArgs e)
        {
            Generar_distribuciones form = new Generar_distribuciones();
            form.Show();
            this.Hide();
        }

        private void btn_tp4_Click_1(object sender, EventArgs e)
        {
            TP4_Montecarlo.EjerTortas form = new TP4_Montecarlo.EjerTortas();
            form.Show();
            this.Hide();
        }

        private void btn_tp5_Click(object sender, EventArgs e)
        {
            Estacionamiento form = new Estacionamiento();
            form.Show();
            this.Hide();
        }
    }
}
