using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.TP3.Generar_Distribuciones
{
    public partial class Generar_distribuciones : Form
    {
        public Generar_distribuciones()
        {
            InitializeComponent();
        }

        private void btn_dist_uniforme_Click(object sender, EventArgs e)
        {
            DistribucionUniforme actual = new DistribucionUniforme();
            actual.Show();
            this.Hide();
        }

        private void btn_dist_exponencial_Click(object sender, EventArgs e)
        {
            DistribucionExponencial actual = new DistribucionExponencial();
            actual.Show();
            this.Hide();
        }

        private void btn_dist_poisson_Click(object sender, EventArgs e)
        {
            DistribucionPoisson actual = new DistribucionPoisson();
            actual.Show();
            this.Hide();
        }

        private void btn_dist_normal_Click(object sender, EventArgs e)
        {
            DistribucionNormal actual = new DistribucionNormal();
            actual.Show();
            this.Hide();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Principal main = new Principal();
            main.Show();
            Close();
        }

        private void Generar_distribuciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal main = new Principal();
            main.Show();
        }
    }
}
