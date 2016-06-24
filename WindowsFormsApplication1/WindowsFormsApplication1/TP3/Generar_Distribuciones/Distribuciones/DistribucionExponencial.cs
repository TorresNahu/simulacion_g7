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
    public partial class DistribucionExponencial : Form
    {
        private float lambda; //Dato empirico
        private int cantidad_intervalos;
        private int cantidad_a_generar;
        private double[] lista;

        int datosEmpiricos = 1;
        int cant_intervalos;
        //int[] frecuencias;
        float ancho_intervalo;
        float max_valor_rnd;
        float min_valor_rnd;
        public int min_int;
        public int max_int;

        public DistribucionExponencial()
        {
            InitializeComponent();
        }
        private void DistribucionExponencial_Load(object sender, EventArgs e)
        {
            dgv_numeros.Columns.Add("orden", "Orden");
            dgv_numeros.Columns.Add("nro_generado", "Nro Generado");
        }
        private void btn_generar_numeros_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                lambda = float.Parse(txt_lambda.Text);
                cantidad_intervalos = int.Parse(txt_cant_intervalos.Text);
                cantidad_a_generar = int.Parse(txt_cant_a_generar.Text);

                //genero distribucion
                GenerarDistribuciones actual = new GenerarDistribuciones();
                lista = actual.generar_distribucion_exponencial(lambda, cantidad_a_generar);

                //muestro la distribucion en la grilla
                for (int i = 0; i < lista.Length; i++)
                {
                    dgv_numeros.Rows.Add(i + 1, lista[i]);
                }
                //grafico la distribucion
                graficar_distribucion();

                btn_intentar_de_nuevo.Visible = true;
                txt_cant_a_generar.Enabled = false;
                txt_cant_intervalos.Enabled = false;
                txt_lambda.Enabled = false;
                btn_generar_numeros.Enabled = false;
            }
        }
        private bool validar()
        {
            //todas las validaciones aca
            if (txt_lambda.Text == string.Empty)
            {
                txt_lambda.Focus();
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
        private void graficar_distribucion()
        {
            //titulo del grafico
            grafico_dist_exponencial.Titles.Clear();
            grafico_dist_exponencial.Titles.Add("Distribución Exponencial");

            //definicion de los intervalos
            cant_intervalos = int.Parse(txt_cant_intervalos.Text);
            for (int i = 0; i < cantidad_a_generar; i++)
            {
                if (i == 0)
                {
                    min_valor_rnd = (float)lista[i];
                }
                else if (min_valor_rnd > lista[i])
                {
                    min_valor_rnd = (float)lista[i];
                }
            }
            for (int i = 0; i < cantidad_a_generar; i++)
            {
                if (i == 0)
                {
                    max_valor_rnd = (float)lista[i];
                }
                else if (max_valor_rnd < lista[i])
                {
                    max_valor_rnd = (float)lista[i];
                }
            }

            min_int = (int)Math.Floor(min_valor_rnd);
            max_int = (int)Math.Ceiling(max_valor_rnd);

            ancho_intervalo = (max_int - min_int) / (float) cant_intervalos;

            int[] frecuencias = new int[cant_intervalos];
            
            string[] intervalos = new string[cant_intervalos];

            float int_lim_inf = min_int;
            float int_lim_sup = min_int;

            for (int i = 0; i < cant_intervalos; i++)
            {
                int_lim_inf = int_lim_sup;
                int_lim_sup = int_lim_sup + ancho_intervalo;

                intervalos[i] = int_lim_inf.ToString() + " - " + int_lim_sup.ToString();
            }
            int_lim_inf = min_int;
            int_lim_sup = min_int + ancho_intervalo;
            for (int i = 0; i < cantidad_intervalos; i++)
            {                
                for (int j = 0; j < lista.Length; j++)
                {
                    if (lista[j] > int_lim_inf && lista[j] <= int_lim_sup)
                    {
                        frecuencias[i]++;
                    }
                }
                int_lim_inf = int_lim_sup;
                int_lim_sup = int_lim_inf + ancho_intervalo;
            }
            

            //graficar
            string[] series = intervalos;
            int[] puntos = frecuencias;

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = null;
                serie = grafico_dist_exponencial.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
        private void btn_intentar_de_nuevo_Click(object sender, EventArgs e)
        {
            dgv_numeros.Rows.Clear();
            grafico_dist_exponencial.Series.Clear();
            grafico_dist_exponencial.Titles.Clear();

            btn_intentar_de_nuevo.Visible = false;
            txt_cant_a_generar.Enabled = true;
            txt_cant_intervalos.Enabled = true;
            txt_lambda.Enabled = true;
            btn_generar_numeros.Enabled = true;

            txt_cant_a_generar.Text = string.Empty;
            txt_cant_intervalos.Text = string.Empty;
            txt_lambda.Text = string.Empty;
            txt_lambda.Focus();

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();
            this.Close();
        }

        private void txt_lambda_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsDigit(e.KeyChar) == true)
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
            }*/
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
        private void DistribucionExponencial_FormClosing(object sender, FormClosingEventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();
        }

        private void btn_pruebaChi_Click(object sender, EventArgs e)
        {
            PruebaChiCuadrado prueba = new PruebaChiCuadrado();
            string hipotesis = prueba.calcularHipotesisExponencial(lista, cant_intervalos, cantidad_a_generar, lambda, min_int, max_int);
            MessageBox.Show(hipotesis, "Prueba de Chi-Cuadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
