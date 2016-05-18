using Simulacion_G7.TP3;
using Simulacion_G7.TP3.Generar_Distribuciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Simulacion_G7
{
    public partial class DistribucionUniforme : Form
    {
        private double[] lista;
        private int lim_inf;
        private int lim_sup;
        private int cantidad_de_numeros;

        int cant_intervalos;

        

        public DistribucionUniforme()
        {
            InitializeComponent();
        }

        private Boolean validar()
        {
            lim_inf = int.Parse(txt_lim_inferior.Text);
            lim_sup = int.Parse(txt_lim_superior.Text);
            cantidad_de_numeros = int.Parse(txt_cant_a_generar.Text);

            //faltan todas las validaciones
            if (lim_inf > lim_sup)
            {
                MessageBox.Show("El límite superior debe ser mayor que el límite inferior", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_lim_inferior.Focus();
                return false;
            }
            if (txt_lim_inferior.Text == string.Empty)
            {
                txt_cant_a_generar.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_lim_superior.Text == string.Empty)
            {
                txt_lim_superior.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_cant_a_generar.Text == string.Empty)
            {
                txt_cant_a_generar.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_cant_intervalos.Text == string.Empty)
            {
                txt_cant_intervalos.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_generar_numeros_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                GenerarDistribuciones actual = new GenerarDistribuciones();

                lista = actual.generar_distibucion_uniforme(lim_inf, lim_sup, cantidad_de_numeros);

                for (int i = 0; i < lista.Length; i++)
                {
                    dgv_numeros.Rows.Add(i + 1, lista[i]);
                }

                graficar_distribucion();

                btn_intentar_de_nuevo.Enabled = true;
                txt_cant_a_generar.Enabled = false;
                txt_cant_intervalos.Enabled = false;
                txt_lim_inferior.Enabled = false;
                txt_lim_superior.Enabled = false;
                btn_generar_numeros.Enabled = false;
            }
        }
        private void graficar_distribucion()
        {
            //titulo del grafico
            grafico_dist_uniforme.Titles.Clear();
            grafico_dist_uniforme.Titles.Add("Distribución uniforme entre " + lim_inf + " y " + lim_sup + ":");
            //definicion de los intervalos
            cant_intervalos = int.Parse(txt_cant_intervalos.Text);
            float ancho_intervalo = (lim_sup - lim_inf) / (float)cant_intervalos;

            int[] frecuencias = new int[cant_intervalos];
            int posicion;

            float int_lim_inf = lim_inf;
            float int_lim_sup = lim_inf;

            string[] intervalos = new string[cant_intervalos];

            double max_valor = lista.Max();
            for (int i = 0; i < lista.Length; i++)
            {
                posicion = (int)((lista[i] - lim_inf) / ancho_intervalo);
                if (posicion == cant_intervalos)
                {
                    posicion = posicion - 1;
                }
                frecuencias[posicion] += 1;
            }
            for (int i = 0; i < cant_intervalos; i++)
            {
                int_lim_inf = int_lim_sup;
                int_lim_sup = int_lim_sup + ancho_intervalo;

                intervalos[i] = int_lim_inf.ToString() + " - " + int_lim_sup.ToString();

            }

            //graficar
            string[] series = intervalos;
            int[] puntos = frecuencias;

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = null;
                serie = grafico_dist_uniforme.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }


        private void DistribucionUniforme_Load(object sender, EventArgs e)
        {
            dgv_numeros.Columns.Add("orden", "Orden");
            dgv_numeros.Columns.Add("numero", "Nro generado");

            //btn_intentar_de_nuevo.Visible = false;
            txt_lim_inferior.Focus();
        }

        private void btn_intentar_de_nuevo_Click(object sender, EventArgs e)
        {
            dgv_numeros.Rows.Clear();
            grafico_dist_uniforme.Series.Clear();
            grafico_dist_uniforme.Titles.Clear();

            btn_intentar_de_nuevo.Enabled = false;
            txt_cant_a_generar.Enabled = true;
            txt_cant_intervalos.Enabled = true;
            txt_lim_inferior.Enabled = true;
            txt_lim_superior.Enabled = true;
            btn_generar_numeros.Enabled = true;

            txt_cant_a_generar.Text = String.Empty;
            txt_cant_intervalos.Text = String.Empty;
            txt_lim_inferior.Text = String.Empty;
            txt_lim_superior.Text = String.Empty;
        }

        private void txt_lim_inferior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Aqui debe ir un numero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_lim_superior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Aqui debe ir un numero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_cant_a_generar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Aqui debe ir un numero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_cant_intervalos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Aqui debe ir un numero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();
            this.Close();
        }

        private void DistribucionUniforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();

        }

        private void btn_pruebaChi_Click(object sender, EventArgs e)
        {
            PruebaChiCuadrado prueba = new PruebaChiCuadrado();
            string hipotesis = prueba.calcularHipotesisUniforme(cant_intervalos, cantidad_de_numeros, lista);
            //Esto era para probar si andaba.
            MessageBox.Show(hipotesis, "Prueba de Chi-Cuadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



    }
}
