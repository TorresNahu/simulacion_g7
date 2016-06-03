using Simulacion_G7;
using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1.TP5_Colas
{
    public partial class Estacionamiento : Form
    {
        float media = 7;
        float desv = 1;
        int cantIteraciones;
        int desde;
        int hasta;

        int autoNro = 1;

        //Reloj
        double reloj = 0;

        //Variables de la llegada
        double tpoSigLlegada;
        double proxLlegada;

        //Variables de fin estacionamiento
        double tpoEstacionamiento = 60;
        double tpoDemora = 10;

        //Variables de la inspeccion
        double tpoInspeccion = 1;
        double tpoBoleta = 5;
        double tpoEntreInspecciones = 120;
        string estadoInspector = string.Empty;
        double proxInspeccion;
        double fin_inspeccion;


        //Variables de lugar estacionamiento
        double fin_estacionamiento1;
        double fin_estacionamiento2;
        double fin_estacionamiento3;
        double fin_estacionamiento4;
        double fin_estacionamiento5;
        string estado_est1;
        string estado_est2;
        string estado_est3;
        string estado_est4;
        string estado_est5;


        //Acumuladores
        int acMultas;
        int acAutosSinPoderEstacionar;

        public Estacionamiento()
        {
            InitializeComponent();
        }
        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            txt_cantExperimentos.Focus();
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
            Colas cola = new Colas();
            Random rnd = new Random();
            int columnas = dgv_sim.ColumnCount;

            cantIteraciones = int.Parse(txt_cantExperimentos.Text);
            desde = int.Parse(txt_iteracionDesde.Text);
            hasta = int.Parse(txt_iteracionHasta.Text);

            double menorTiempo;
            double rnd_Demora = 0;
            bool demora = false;

            acMultas = 0;
            acAutosSinPoderEstacionar = 0;


            for (int i = 0; i < cantIteraciones; i++)
            {
                if (i == 0) //Condiciones iniciales
                {
                    tpoSigLlegada = Math.Round(cola.generarRNDNormal(media, desv), 2);
                    proxLlegada = reloj + tpoSigLlegada;

                    estadoInspector = "A";
                    proxInspeccion += tpoEntreInspecciones;

                    fin_estacionamiento1 = 0;
                    fin_estacionamiento2 = 0;
                    fin_estacionamiento3 = 0;
                    fin_estacionamiento4 = 0;
                    fin_estacionamiento5 = 0;

                    fin_inspeccion = 0;

                    estado_est1 = "L";
                    estado_est2 = "L";
                    estado_est3 = "L";
                    estado_est4 = "L";
                    estado_est5 = "L";

                    acMultas = 0;
                    acAutosSinPoderEstacionar = 0;
                }
                if (i != 0)
                {
                    //proximo evento                    
                    menorTiempo = cola.determinarMenor(proxLlegada, fin_estacionamiento1, fin_estacionamiento2, fin_estacionamiento3, fin_estacionamiento4, fin_estacionamiento5, proxInspeccion, fin_inspeccion);

                    //llegada
                    if (menorTiempo == proxLlegada)
                    {
                        reloj = proxLlegada;
                        tpoSigLlegada = Math.Round(cola.generarRNDNormal(media, desv), 2);
                        proxLlegada = reloj + tpoSigLlegada;

                        rnd_Demora = rnd.NextDouble();
                        demora = cola.determinarDemora(rnd_Demora);

                        //fin estacionamiento 1
                        if (fin_estacionamiento1 == 0)
                        {
                            fin_estacionamiento1 = reloj + tpoEstacionamiento;
                            if (demora == true)
                            {
                                fin_estacionamiento1 += tpoDemora;

                            }
                            estado_est1 = "O";
                            
                            
                            dgv_sim.Columns.Add("_estado_auto" + autoNro, "Estado auto " + autoNro);
                            autoNro++;
                            columnas++;
                            //string estado_est = "E";
                            //dgv_sim.Rows[i].Cells[columnas].Value = estado_est;
                            

                        }//fin estacionamiento 2
                        else if (fin_estacionamiento2 == 0)
                        {
                            fin_estacionamiento2 = reloj + tpoEstacionamiento;
                            if (demora == true)
                            {
                                fin_estacionamiento2 += tpoDemora;

                            }
                            estado_est2 = "O";
                            dgv_sim.Columns.Add("_estado_auto" + autoNro, "Estado auto " + autoNro);
                            autoNro++;
                            columnas++;
                        }//fin estacionamiento 3
                        else if (fin_estacionamiento3 == 0)
                        {
                            fin_estacionamiento3 = reloj + tpoEstacionamiento;
                            if (demora == true)
                            {
                                fin_estacionamiento3 += tpoDemora;

                            }
                            estado_est3 = "O";
                            dgv_sim.Columns.Add("_estado_auto" + autoNro, "Estado auto " + autoNro);
                            autoNro++;
                            columnas++;
                        }//fin estacionamiento 4
                        else if (fin_estacionamiento4 == 0)
                        {
                            fin_estacionamiento4 = reloj + tpoEstacionamiento;
                            if (demora == true)
                            {
                                fin_estacionamiento4 += tpoDemora;

                            }
                            estado_est4 = "O";
                            dgv_sim.Columns.Add("_estado_auto" + autoNro, "Estado auto " + autoNro);
                            autoNro++;
                            columnas++;
                        }//fin estacionamiento 5
                        else if (fin_estacionamiento5 == 0)
                        {
                            fin_estacionamiento5 = reloj + tpoEstacionamiento;
                            if (demora == true)
                            {
                                fin_estacionamiento5 += tpoDemora;

                            }
                            estado_est5 = "O";
                            dgv_sim.Columns.Add("_estado_auto" + autoNro, "Estado auto " + autoNro);
                            autoNro++;
                            columnas++;
                        }
                        else
                        {
                            acAutosSinPoderEstacionar++;
                        }


                    }
                    if (menorTiempo == fin_estacionamiento1)
                    {
                        reloj = fin_estacionamiento1;
                        tpoSigLlegada = 0;
                        fin_estacionamiento1 = 0;
                        estado_est1 = "L";
                    }
                    if (menorTiempo == fin_estacionamiento2)
                    {
                        reloj = fin_estacionamiento2;
                        tpoSigLlegada = 0;
                        fin_estacionamiento2 = 0;
                        estado_est2 = "L";
                    }
                    if (menorTiempo == fin_estacionamiento3)
                    {
                        reloj = fin_estacionamiento3;
                        tpoSigLlegada = 0;
                        fin_estacionamiento3 = 0;
                        estado_est3 = "L";
                    }
                    if (menorTiempo == fin_estacionamiento4)
                    {
                        reloj = fin_estacionamiento4;
                        tpoSigLlegada = 0;
                        fin_estacionamiento4 = 0;
                        estado_est4 = "L";
                    }
                    if (menorTiempo == fin_estacionamiento5)
                    {
                        reloj = fin_estacionamiento5;
                        tpoSigLlegada = 0;
                        fin_estacionamiento5 = 0;
                        estado_est5 = "L";
                    }

                }
                if (i >= (desde - 1) && i <= (hasta - 1)) // iteraciones a mostrar en grilla desde la 1 a 22
                {
                    dgv_sim.Rows.Add((i + 1), reloj, tpoSigLlegada, proxLlegada, rnd_Demora, demora,
                        fin_estacionamiento1, fin_estacionamiento2, fin_estacionamiento3, fin_estacionamiento4, fin_estacionamiento5,
                        estadoInspector, proxInspeccion, fin_inspeccion, estado_est1, estado_est2, estado_est3, estado_est4, estado_est5,
                        acMultas, acAutosSinPoderEstacionar);
                }
                //if (fin_estacionamiento1 != 0)
                //{
                //    string estado_est = "E";
                //    dgv_sim.Rows[i].Cells[columnas].Value = estado_est;
                    
                //}

            }
        }

        private bool validar()
        {
            if (txt_cantExperimentos.Text == string.Empty)
            {
                txt_cantExperimentos.Focus();
                MessageBox.Show("El campo 'Cantidad de experimentos' es obligatorio.", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_iteracionDesde.Text == string.Empty)
            {
                txt_iteracionDesde.Focus();
                MessageBox.Show("El campo 'Iteracion desde' es obligatorio.", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txt_iteracionHasta.Text == string.Empty)
            {
                txt_iteracionHasta.Focus();
                MessageBox.Show("El campo 'Iteracion Hasta' es obligatorio.", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.Parse(txt_iteracionHasta.Text) < int.Parse(txt_iteracionDesde.Text))
            {
                txt_iteracionDesde.Focus();
                MessageBox.Show("Incongruencia en los intervalos de iteracion, 'Hasta' no puede ser menor que 'Desde'", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_tryAgain_Click(object sender, EventArgs e)
        {
            tryAgain();
        }
        private void tryAgain()
        {
            txt_cantExperimentos.Text = string.Empty;
            txt_iteracionDesde.Text = string.Empty;
            txt_iteracionHasta.Text = string.Empty;

            dgv_sim.Rows.Clear();

            txt_iteracionDesde.Enabled = true;
            txt_iteracionHasta.Enabled = true;
            txt_cantExperimentos.Enabled = true;

            btn_resultados.Enabled = false;
            btn_empezarSim.Enabled = true;
            btn_tryAgain.Enabled = false;

            txt_cantExperimentos.Focus();
            
        }

        private void btn_resultados_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allahu akbar", "Boooooooooom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
