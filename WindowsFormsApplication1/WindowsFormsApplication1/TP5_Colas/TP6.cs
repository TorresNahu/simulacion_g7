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
    public partial class TP6 : Form
    {
        decimal alfa = 0.01068M;
        decimal t = 0;
        decimal T = 5;
        decimal h = 0.1M;
        decimal dTdt;
        public int fila { get; set; }

        int fila1 = 2158;
        int fila2 = 2598;
        int fila3 = 2807;

        public TP6()
        {
            InitializeComponent();
        }
        private void TP6_Load(object sender, EventArgs e)
        {            
            Euler();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void Euler()
        {
            for (decimal i = T; i <= 101; i = T)
            {
                fila = 0;
                dTdt = alfa * T;
                Math.Round(dTdt, 7);
                cargarGrilla(fila);
                t += h;
                Math.Round(t, 1);
                T = T + (dTdt * h);
                Math.Round(T, 7);
                fila++;
            }
            ColorGrilla();
        }

        protected void cargarGrilla(int fila)
        {
            dgv_euler.Rows.Add(t, T, dTdt);
        }

        protected void ColorGrilla()
        {
            foreach (DataGridViewRow rowp in dgv_euler.Rows)
            {
                int index = rowp.Index;

                if (index == fila1)
                {
                    dgv_euler.Rows[fila1].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if(index == fila2)
                {
                    dgv_euler.Rows[fila2].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (index == fila3)
                {
                    dgv_euler.Rows[fila3].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgv_euler.Rows[index].DefaultCellStyle.BackColor = Color.White;
                }


            }
        }

    }
}
