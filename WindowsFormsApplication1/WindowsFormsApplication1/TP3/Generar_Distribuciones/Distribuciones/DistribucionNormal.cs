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
    public partial class DistribucionNormal : Form
    {
        double[] lista;
        float media;
        float desvEstandar;
        int cantidad_a_generar;        
        public int cant_intervalos;
        public int min_int;
        public int max_int;

        public DistribucionNormal()
        {
            InitializeComponent();
            txt_media.Focus();
            btn_intentar_de_nuevo.Enabled = false;
        }

        private void DistribucionNormal_Load(object sender, EventArgs e)
        {
            txt_media.Focus();
            dgv_numeros.Columns.Add("orden", "Orden");
            dgv_numeros.Columns.Add("nro_generado", "Nro Generado");
        }

        private void btn_generar_numeros_Click(object sender, EventArgs e)
        {
            if (validar() == true)
            {
                btn_intentar_de_nuevo.Enabled = true;
                generarNormal();
                graficar_distribucion();
            }
        }

        private void generarNormal()
        {
            media = float.Parse(txt_media.Text);
            desvEstandar = float.Parse(txt_desvEstandar.Text);
            cantidad_a_generar = int.Parse(txt_cant_a_generar.Text);
            cant_intervalos = int.Parse(txt_cantIntervalos.Text);

            GenerarDistribuciones actual = new GenerarDistribuciones();
            lista = actual.generar_distribucion_normal(media, desvEstandar, cantidad_a_generar);

            for (int i = 0; i < lista.Length; i++)
            {
                dgv_numeros.Rows.Add(i + 1, lista[i]);
            }

            btn_intentar_de_nuevo.Visible = true;
            txt_cant_a_generar.Enabled = false;
            txt_media.Enabled = false;
            txt_desvEstandar.Enabled = false;
            txt_cantIntervalos.Enabled = false;
            btn_generar_numeros.Enabled = false;
        }

        private void graficar_distribucion()
        {
            //titulo del grafico
            grafico_dist_normal.Titles.Clear();
            grafico_dist_normal.Titles.Add("Distribución Normal");

            //definicion de los intervalos            
            float max = 0;
            float min = 0;

            for (int i = 0; i < cantidad_a_generar; i++)
            {
                if (i == 0)
                {
                    min = (float)lista[i];
                }
                else if (min > lista[i])
                {
                    min = (float)lista[i];
                }
            }
            for (int i = 0; i < cantidad_a_generar; i++)
            {
                if (i == 0)
                {
                    max = (float)lista[i];
                }
                else if (max < lista[i])
                {
                    max = (float)lista[i];
                }
            }

            min_int = (int)Math.Floor(min);
            max_int = (int)Math.Ceiling(max);
            //cant_intervalos = max_int - min_int;

            float ancho_intervalo = (max_int - min_int) / (float) cant_intervalos;

            int[] frecuencias = new int[cant_intervalos];
            //int posicion;

            //float int_lim_inf = min;
            //float int_lim_sup = min;
            float int_lim_inf = min_int;
            float int_lim_sup = min_int;

            string[] intervalos = new string[cant_intervalos];

            for (int i = 0; i < cant_intervalos; i++)
            {
                int_lim_inf = int_lim_sup;
                int_lim_sup = int_lim_sup + ancho_intervalo;

                intervalos[i] = int_lim_inf.ToString() + " - " + int_lim_sup.ToString();

            }
            int_lim_inf = min_int;
            int_lim_sup = min_int + ancho_intervalo;
            for (int i = 0; i < cant_intervalos; i++)
            {
                //posicion = (int)((lista[i] - min_int) / ancho_intervalo);
                //if (posicion == cant_intervalos)
                //{
                //    posicion = posicion - 1;
                //}                  
                //frecuencias[posicion] += 1;
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
                serie = grafico_dist_normal.Series.Add(series[i]);

                //cantidades
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void btn_realizarPrueba_Click(object sender, EventArgs e)
        {
            PruebaChiCuadrado prueba = new PruebaChiCuadrado();
            string hipotesis = prueba.calcularHipotesisNormal(lista, cant_intervalos, cantidad_a_generar, media, desvEstandar, min_int, max_int);
            MessageBox.Show(hipotesis, "Prueba de Chi-Cuadrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Boolean validar()
        {
            //todas las validaciones aca
            if (txt_media.Text == string.Empty)
            {
                txt_media.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_desvEstandar.Text == string.Empty)
            {
                txt_desvEstandar.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_cant_a_generar.Text == string.Empty)
            {
                txt_cant_a_generar.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_cantIntervalos.Text == string.Empty)
            {
                txt_cantIntervalos.Focus();
                MessageBox.Show("Campo Obligatorio", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_intentar_de_nuevo_Click(object sender, EventArgs e)
        {
            dgv_numeros.Rows.Clear();
            grafico_dist_normal.Series.Clear();
            grafico_dist_normal.Titles.Clear();

            btn_intentar_de_nuevo.Enabled = false;
            txt_cant_a_generar.Enabled = true;
            txt_media.Enabled = true;
            txt_desvEstandar.Enabled = true;
            txt_cantIntervalos.Enabled = true;
            btn_generar_numeros.Enabled = true;

            txt_cant_a_generar.Text = string.Empty;
            txt_media.Text = string.Empty;
            txt_desvEstandar.Text = string.Empty;
            txt_cantIntervalos.Text = string.Empty;

        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();
            this.Close();
        }
        private void txt_media_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (char.IsDigit(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Aqui debe ir un numero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void txt_desvEstandar_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txt_cantIntervalos_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void DistribucionNormal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Generar_distribuciones dis = new Generar_distribuciones();
            dis.Show();
        }

        
    }
}
