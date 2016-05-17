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
    public partial class DistribucionPoisson : Form
    {
        private float lambda;
        private int cantidad_a_generar;

        private double[] lista;
        int[] puntos;
        string[] series;
        int[] frecuencias;

        public DistribucionPoisson()
        {
            InitializeComponent();
        }

        private void btn_generar_numeros_Click(object sender, EventArgs e)
        {
            //tomo lo que ingreso el usuario
            lambda = float.Parse(txt_lambda.Text);
            cantidad_a_generar = int.Parse(txt_cant_a_generar.Text);


            if (validar() == true)
            {
                //genero distribucion
                GenerarDistribuciones actual = new GenerarDistribuciones();
                lista = actual.generar_distribucion_poisson(lambda, cantidad_a_generar);

                //muestro la distribucion en la lista
                for (int i = 0; i < lista.Length; i++)
                {
                    dgv_numeros.Rows.Add(i + 1, lista[i]);
                }
                graficar();

                btn_intentar_de_nuevo.Visible = true;
                txt_cant_a_generar.Enabled = false;
                txt_lambda.Enabled = false;
                btn_generar_numeros.Enabled = false;
            }
        }

        private Boolean validar()
        {
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
            return true;
        }

        private void graficar()
        {
            //titulo del grafico
            grafico_dist_poisson.Titles.Clear();
            grafico_dist_poisson.Titles.Add("Distribución Poisson");

            frecuencias = new int[lista.Length];

            //genero vector de frecuencias
            int minimo = 0;
            for (int i = 0; i < lista.Length; i++)
            {
                if (i == 0)
                {
                    minimo = (int)lista[i];
                }
                else
                {
                    if (minimo > lista[i])
                    {
                        minimo = (int)lista[i];
                    }
                }

            }

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != 0)
                {
                    frecuencias[(int)lista[i] - minimo] += 1;
                }

            }

            //redimensionar la lista para graficarla
            int contador_ceros = 0;

            for (int i = frecuencias.Length - 1; i >= 0; i--)
            {
                if (frecuencias[i] == 0)
                {
                    contador_ceros++;
                }
                else
                {
                    break;
                }
            }

            int tamaño_actual = lista.Length;
            int nuevo_tamaño = lista.Length - contador_ceros;
            string[] intervalos = new string[nuevo_tamaño];

            //hasta aca la redimension
            for (int i = 0; i < intervalos.Length; i++)
            {
                intervalos[i] = "0";
            }
            for (int i = 0; i < intervalos.Length; i++)
            {
                if (lista[i] != 0)
                {
                    intervalos[i] = i.ToString();

                }
            }

            //graficar
            series = intervalos;
            puntos = frecuencias;
            grafico_dist_poisson.Series.Clear();

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = null;
                serie = grafico_dist_poisson.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }


        private void DistribucionPoisson_Load(object sender, EventArgs e)
        {
            dgv_numeros.Columns.Add("orden", "Orden");
            dgv_numeros.Columns.Add("nro_generado", "Nro Generado");
        }

        private void btn_intentar_de_nuevo_Click(object sender, EventArgs e)
        {
            btn_intentar_de_nuevo.Visible = false;
            txt_cant_a_generar.Enabled = true;
            txt_lambda.Enabled = true;
            btn_generar_numeros.Enabled = true;

            dgv_numeros.Rows.Clear();
            grafico_dist_poisson.Series.Clear();
            grafico_dist_poisson.Titles.Clear();

            lista = null;

            txt_cant_a_generar.Text = string.Empty;
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
            //if (char.IsDigit(e.KeyChar) == true)
            //{
            //    e.Handled = false;
            //}
            //else if (char.IsControl(e.KeyChar) == true)
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Aqui debe ir un numero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        private void DistribucionPoisson_FormClosing(object sender, FormClosingEventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();
        }

        private void btn_realizarPrueba_Click(object sender, EventArgs e)
        {
            /*
            PruebaChiCuadrado prueba = new PruebaChiCuadrado();
            string hipotesis = prueba.calcularHipotesisExponencial(cant_intervalos, cantidad_a_generar, lambda, datosEmpiricos, frecuencias, min_valor_rnd, ancho_intervalo);
            MessageBox.Show(hipotesis, "Prueba de Chi-Cuadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }
    }
}
