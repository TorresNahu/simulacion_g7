using Simulacion_G7;
using System;
using System.Windows.Forms;
using Simulacion_G7.TP3;

namespace WindowsFormsApplication1.TP5_Colas
{
    public partial class Estacionamiento : Form
    {
        float media;
        float desvEstandar;
        int cantIteraciones;
        int desde;
        int hasta;

        double[] rndLista;

        //un string que dice si ..... solo eso
        string si = "Si";

        int autoNro = 1;
        int cantLugarEstacionamiento = 5;

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
        double tpoEntreInspecciones = /*120*/280;
        double tpoInterrupcion = 5;
        string estadoInspector = string.Empty;
        double proxInspeccion;
        double fin_inspeccion;
        double fin_interrupcion;
        int j = 1; //se usa para la hora de la inspeccion. Indica que lugar esta inspeccionando o haciendo boleta
        //Estados de la inspeccion
        string insp_realizandoInspeccion = "RI ";
        string insp_realizandoBoleta = "RB ";
        string insp_ausente = "A";
        string insp_interrumpido = "I";
        string ultimo_estado;

        //Variables de lugar estacionamiento
        int contadorDeLugares;
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
        bool demora_est1 = false;
        bool demora_est2 = false;
        bool demora_est3 = false;
        bool demora_est4 = false;
        bool demora_est5 = false;
        bool recibMulta_lug1 = false;
        bool recibMulta_lug2 = false;
        bool recibMulta_lug3 = false;
        bool recibMulta_lug4 = false;
        bool recibMulta_lug5 = false;
        //Estados de lugar estacionamiento
        string lug_libre = "L";
        string lug_ocupado = "O";

        //Variables de vehiculo   
        Auto auto1 = new Auto();
        Auto auto2 = new Auto();
        Auto auto3 = new Auto();
        Auto auto4 = new Auto();
        Auto auto5 = new Auto();
        Auto autoX = new Auto();

        //Estados de vehiculo
        string auto_estacionado = "E";
        string auto_recibiendoBoleta = "RB";
        string auto_destruccion = "- - -";

        //Acumuladores
        int acMultas;
        int acAutosSinPoderEstacionar;

        //Interrupcion
        double rnd_Interrupcion;
        int tamano_interrupcion;
        double tpo_interrupcion;
        double prox_interrupcion;

        public Estacionamiento()
        {
            InitializeComponent();
        }
        private void Estacionamiento_Load(object sender, EventArgs e)
        {
            btn_tryAgain.Enabled = false;
            btn_resultados.Enabled = false;
            btn_sameConfig.Enabled = false;
            txt_media.Focus();
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
                btn_sameConfig.Enabled = true;
                txt_media.Enabled = false;
                txt_desvEstandar.Enabled = false;
                txt_iteracionDesde.Enabled = false;
                txt_iteracionHasta.Enabled = false;
                txt_cantExperimentos.Enabled = false;
            }
        }

        private void realizarSimulacion()
        {
            Colas cola = new Colas();
            Random rnd = new Random();
            media = float.Parse(txt_media.Text);
            desvEstandar = float.Parse(txt_desvEstandar.Text);


            int columnas = dgv_sim.ColumnCount;
            contadorDeLugares = 0;//estan todos los lugares libres
            cantIteraciones = int.Parse(txt_cantExperimentos.Text);
            desde = int.Parse(txt_iteracionDesde.Text);
            hasta = int.Parse(txt_iteracionHasta.Text);

            double menorTiempo;
            double rnd_Demora = 0;
            string demora = string.Empty;
            //estado_auto = string.Empty;

            acMultas = 0;
            acAutosSinPoderEstacionar = 0;
            GenerarDistribuciones dis = new GenerarDistribuciones();

            rndLista = dis.generar_distribucion_normal(media, desvEstandar, cantIteraciones);

            for (int i = 0; i < cantIteraciones; i++)
            {
                autoX.Estado = null;
                //tpoSigLleg = cola.generarRNDNormal(media, desvEstandar);                
                //tpoSigLlegada = Math.Truncate(tpoSigLleg * 100) / 100;
                //Math.Round(tpoSigLlegada, 2);

                tpoSigLlegada = Math.Round(rndLista[i], 2);

                rnd_Demora = rnd.NextDouble();

                if (i == 0) //Condiciones iniciales
                {
                    reloj = 0;
                    Math.Round(reloj, 2);
                    //tpoSigLlegada = Math.Round(cola.generarRNDNormal(media, desvEstandar),2);
                    proxLlegada = Math.Round(reloj + tpoSigLlegada, 2);

                    rnd_Demora = 0;
                    proxInspeccion = 0;
                    estadoInspector = insp_ausente;
                    proxInspeccion += tpoEntreInspecciones;
                    fin_inspeccion = 0;
                    fin_interrupcion = 0;

                    rnd_Interrupcion = rnd.NextDouble();
                    tamano_interrupcion = cola.determinarTamanoInestabilidad(rnd_Interrupcion);
                    tpo_interrupcion = cola.determinarTiempoInterrupcion(tamano_interrupcion);
                    prox_interrupcion = reloj + tpo_interrupcion;

                    Math.Round(fin_estacionamiento1 = 0, 2);
                    Math.Round(fin_estacionamiento2 = 0, 2);
                    Math.Round(fin_estacionamiento3 = 0, 2);
                    Math.Round(fin_estacionamiento4 = 0, 2);
                    Math.Round(fin_estacionamiento5 = 0, 2);

                    estado_est1 = lug_libre;
                    estado_est2 = lug_libre;
                    estado_est3 = lug_libre;
                    estado_est4 = lug_libre;
                    estado_est5 = lug_libre;

                    acMultas = 0;
                    acAutosSinPoderEstacionar = 0;
                }
                if (i != 0)
                {
                    //proximo evento                    
                    menorTiempo = cola.determinarMenor(proxLlegada, fin_estacionamiento1, fin_estacionamiento2,
                        fin_estacionamiento3, fin_estacionamiento4, fin_estacionamiento5, proxInspeccion,
                        fin_inspeccion, prox_interrupcion, fin_interrupcion);


                    rnd_Interrupcion = 0;
                    tpo_interrupcion = 0;

                    //llegada
                    if (menorTiempo == proxLlegada)
                    {
                        reloj = proxLlegada;
                        //tpoSigLlegada = Math.Round(cola.generarRNDNormal(media, desvEstandar),2);
                        proxLlegada = reloj + tpoSigLlegada;

                        if (contadorDeLugares < cantLugarEstacionamiento)
                        {
                            //rnd_Demora = rnd.NextDouble();
                            demora = cola.determinarDemora(rnd_Demora);

                            //fin estacionamiento 1
                            if (fin_estacionamiento1 == 0)
                            {
                                fin_estacionamiento1 = reloj + tpoEstacionamiento;
                                if (demora == si)
                                {
                                    fin_estacionamiento1 += tpoDemora;
                                    demora_est1 = true;
                                }
                                estado_est1 = lug_ocupado;
                                contadorDeLugares++;

                                string nombre = "_estado_auto" + autoNro;
                                dgv_sim.Columns.Add(nombre, "Estado auto " + autoNro);
                                autoNro++;

                                auto1.Id = i;
                                auto1.Nombre = nombre;
                                auto1.Estado = auto_estacionado;
                                auto1.Fin_estacionamiento = fin_estacionamiento1;

                            }//fin estacionamiento 2
                            else if (fin_estacionamiento2 == 0)
                            {
                                fin_estacionamiento2 = reloj + tpoEstacionamiento;
                                if (demora == si)
                                {
                                    fin_estacionamiento2 += tpoDemora;
                                    demora_est2 = true;
                                }
                                estado_est2 = lug_ocupado;
                                contadorDeLugares++;

                                string nombre = "_estado_auto" + autoNro;
                                dgv_sim.Columns.Add(nombre, "Estado auto " + autoNro);
                                autoNro++;

                                auto2.Id = i;
                                auto2.Nombre = nombre;
                                auto2.Estado = auto_estacionado;
                                auto2.Fin_estacionamiento = fin_estacionamiento2;
                            }//fin estacionamiento 3
                            else if (fin_estacionamiento3 == 0)
                            {
                                fin_estacionamiento3 = reloj + tpoEstacionamiento;
                                if (demora == si)
                                {
                                    fin_estacionamiento3 += tpoDemora;
                                    demora_est3 = true;
                                }
                                estado_est3 = lug_ocupado;
                                contadorDeLugares++;

                                string nombre = "_estado_auto" + autoNro;
                                dgv_sim.Columns.Add(nombre, "Estado auto " + autoNro);
                                autoNro++;

                                auto3.Id = i;
                                auto3.Nombre = nombre;
                                auto3.Estado = auto_estacionado;
                                auto3.Fin_estacionamiento = fin_estacionamiento3;

                            }//fin estacionamiento 4
                            else if (fin_estacionamiento4 == 0)
                            {
                                fin_estacionamiento4 = reloj + tpoEstacionamiento;
                                if (demora == si)
                                {
                                    fin_estacionamiento4 += tpoDemora;
                                    demora_est4 = true;
                                }
                                estado_est4 = lug_ocupado;
                                contadorDeLugares++;

                                string nombre = "_estado_auto" + autoNro;
                                dgv_sim.Columns.Add(nombre, "Estado auto " + autoNro);
                                autoNro++;

                                auto4.Id = i;
                                auto4.Nombre = nombre;
                                auto4.Estado = auto_estacionado;
                                auto4.Fin_estacionamiento = fin_estacionamiento4;
                            }//fin estacionamiento 5
                            else if (fin_estacionamiento5 == 0)
                            {
                                fin_estacionamiento5 = reloj + tpoEstacionamiento;
                                if (demora == si)
                                {
                                    fin_estacionamiento5 += tpoDemora;
                                    demora_est5 = true;
                                }
                                estado_est5 = lug_ocupado;
                                contadorDeLugares++;

                                string nombre = "_estado_auto" + autoNro;
                                dgv_sim.Columns.Add(nombre, "Estado auto " + autoNro);
                                autoNro++;

                                auto5.Id = i;
                                auto5.Nombre = nombre;
                                auto5.Estado = auto_estacionado;
                                auto5.Fin_estacionamiento = fin_estacionamiento5;
                            }
                        }
                        else
                        {
                            string nombre = "_estado_auto" + autoNro;
                            dgv_sim.Columns.Add(nombre, "Estado auto " + autoNro);
                            autoNro++;
                            autoX.Nombre = nombre;
                            autoX.Estado = auto_destruccion;
                            rnd_Demora = 0;
                            demora = string.Empty;
                            acAutosSinPoderEstacionar++;
                        }

                    }//Auto 1 se va
                    else if (menorTiempo == fin_estacionamiento1)
                    {
                        rnd_Demora = 0;
                        if (recibMulta_lug1 == false)
                        {
                            reloj = fin_estacionamiento1;
                            tpoSigLlegada = 0;
                            fin_estacionamiento1 = 0;
                            estado_est1 = lug_libre;
                            demora_est1 = false;
                            contadorDeLugares--;
                            auto1.Estado = auto_destruccion;

                        }
                        else
                        {
                            fin_estacionamiento1 += tpoBoleta;
                            recibMulta_lug1 = false;
                        }
                    }//Auto 2 se va
                    else if (menorTiempo == fin_estacionamiento2)
                    {
                        rnd_Demora = 0;
                        if (recibMulta_lug2 == false)
                        {
                            reloj = fin_estacionamiento2;
                            tpoSigLlegada = 0;
                            fin_estacionamiento2 = 0;
                            estado_est2 = lug_libre;
                            demora_est2 = false;
                            contadorDeLugares--;
                            auto2.Estado = auto_destruccion;
                        }
                        else
                        {
                            fin_estacionamiento2 += tpoBoleta;
                            recibMulta_lug2 = false;
                        }
                    }//Auto 3 se va
                    else if (menorTiempo == fin_estacionamiento3)
                    {
                        rnd_Demora = 0;
                        if (recibMulta_lug3 == false)
                        {
                            reloj = fin_estacionamiento3;
                            tpoSigLlegada = 0;
                            fin_estacionamiento3 = 0;
                            estado_est3 = lug_libre;
                            demora_est3 = false;
                            contadorDeLugares--;
                            auto3.Estado = auto_destruccion;
                        }
                        else
                        {
                            fin_estacionamiento3 += tpoBoleta;
                            recibMulta_lug3 = false;
                        }
                    }//Auto 4 se va
                    else if (menorTiempo == fin_estacionamiento4)
                    {
                        rnd_Demora = 0;
                        if (recibMulta_lug4 == false)
                        {
                            reloj = fin_estacionamiento4;
                            tpoSigLlegada = 0;
                            fin_estacionamiento4 = 0;
                            estado_est4 = lug_libre;
                            demora_est4 = false;
                            contadorDeLugares--;
                            auto4.Estado = auto_destruccion;
                        }
                        else
                        {
                            fin_estacionamiento4 += tpoBoleta;
                            recibMulta_lug4 = false;
                        }
                    }//Auto 5 se va
                    else if (menorTiempo == fin_estacionamiento5)
                    {
                        rnd_Demora = 0;
                        if (recibMulta_lug5 == false)
                        {
                            reloj = fin_estacionamiento5;
                            tpoSigLlegada = 0;
                            fin_estacionamiento5 = 0;
                            estado_est5 = lug_libre;
                            demora_est5 = false;
                            contadorDeLugares--;
                            auto5.Estado = auto_destruccion;
                        }
                        else
                        {
                            fin_estacionamiento5 += tpoBoleta;
                            recibMulta_lug5 = false;
                        }
                    }
                    else if (menorTiempo == proxInspeccion || menorTiempo == fin_inspeccion) //Inspeccion
                    {
                        if (menorTiempo == proxInspeccion)
                        {
                            reloj = proxInspeccion;
                            proxInspeccion += tpoEntreInspecciones;
                            fin_inspeccion = reloj + tpoInspeccion;
                            tpoSigLlegada = 0;
                        }
                        if (menorTiempo == fin_inspeccion)
                        {
                            reloj = fin_inspeccion;
                            fin_inspeccion = reloj + tpoInspeccion;
                            tpoSigLlegada = 0;
                        }
                        estadoInspector = insp_realizandoInspeccion + j;

                        switch (j)
                        {
                            case 1:
                                if (demora_est1 == true)
                                {
                                    recibMulta_lug1 = true;
                                    double aux = fin_estacionamiento1 - reloj;
                                    if (aux <= tpoDemora)
                                    {
                                        auto1.Estado = auto_recibiendoBoleta;
                                        fin_inspeccion += tpoBoleta;
                                        estadoInspector = insp_realizandoBoleta + j;
                                        if (aux == 0 || aux < 1)
                                        {
                                            fin_estacionamiento1 = fin_inspeccion;
                                        }
                                        acMultas++;
                                    }
                                }
                                break;
                            case 2:
                                if (demora_est2 == true)
                                {
                                    recibMulta_lug2 = true;
                                    double aux = fin_estacionamiento2 - reloj;
                                    if (aux <= tpoDemora)
                                    {
                                        auto2.Estado = auto_recibiendoBoleta;
                                        fin_inspeccion += tpoBoleta;
                                        estadoInspector = insp_realizandoBoleta + j;
                                        if (aux == 0 || aux < 1)
                                        {
                                            fin_estacionamiento2 = fin_inspeccion;
                                        }
                                        acMultas++;
                                    }
                                }
                                break;
                            case 3:
                                if (demora_est3 == true)
                                {
                                    recibMulta_lug3 = true;
                                    double aux = fin_estacionamiento3 - reloj;
                                    if (aux <= tpoDemora)
                                    {
                                        auto3.Estado = auto_recibiendoBoleta;
                                        fin_inspeccion += tpoBoleta;
                                        estadoInspector = insp_realizandoBoleta + j;
                                        if (aux == 0 || aux < 1)
                                        {
                                            fin_estacionamiento3 = fin_inspeccion;
                                        }
                                        acMultas++;
                                    }
                                }
                                break;
                            case 4:
                                if (demora_est4 == true)
                                {
                                    recibMulta_lug4 = true;
                                    double aux = fin_estacionamiento4 - reloj;
                                    if (aux <= tpoDemora)
                                    {
                                        auto4.Estado = auto_recibiendoBoleta;
                                        fin_inspeccion += tpoBoleta;
                                        estadoInspector = insp_realizandoBoleta + j;
                                        if (aux == 0 || aux < 1)
                                        {
                                            fin_estacionamiento4 = fin_inspeccion;
                                        }
                                        acMultas++;
                                    }
                                }
                                break;
                            case 5:
                                if (demora_est5 == true)
                                {
                                    recibMulta_lug5 = true;
                                    double aux = fin_estacionamiento5 - reloj;
                                    if (aux <= tpoDemora)
                                    {
                                        auto5.Estado = auto_recibiendoBoleta;
                                        fin_inspeccion += tpoBoleta;
                                        estadoInspector = insp_realizandoBoleta + j;
                                        if (aux == 0 || aux < 1)
                                        {
                                            fin_estacionamiento5 = fin_inspeccion;
                                        }
                                        acMultas++;
                                    }
                                }
                                break;
                                //fin switch
                        }

                        if (j <= cantLugarEstacionamiento)
                        {
                            j++;
                        }
                        else
                        {
                            estadoInspector = insp_ausente;
                            fin_inspeccion = 0;
                            j = 1;
                        }

                    }
                    else if (menorTiempo == prox_interrupcion)
                    {
                        reloj = prox_interrupcion;
                        tpoSigLlegada = 0;
                        rnd_Demora = 0;
                        demora = string.Empty;

                        rnd_Interrupcion = rnd.NextDouble();
                        tamano_interrupcion = cola.determinarTamanoInestabilidad(rnd_Interrupcion);
                        tpo_interrupcion = cola.determinarTiempoInterrupcion(tamano_interrupcion);
                        prox_interrupcion = reloj + tpo_interrupcion;

                        
                        if (estadoInspector.Contains(insp_realizandoBoleta.ToString()) || estadoInspector.Contains(insp_realizandoInspeccion.ToString()))
                        {
                            //Inspector no ausente. Calcula prox interrupcion e interrumpo el estado actual
                            ultimo_estado = estadoInspector.ToString();
                            estadoInspector = insp_interrumpido;

                            fin_inspeccion += tpoInterrupcion;
                            fin_interrupcion = reloj + tpoInterrupcion;
                        }
                    }
                    else if (menorTiempo == fin_interrupcion)
                    {
                        reloj = fin_interrupcion;
                        tpoSigLlegada = 0;
                        rnd_Demora = 0;
                        demora = string.Empty;

                        estadoInspector = ultimo_estado.ToString();
                        fin_interrupcion = 0;
                    }

                }

                if (i >= (desde - 1) && i <= (hasta - 1)) // iteraciones a mostrar en grilla desde la 1 a 22
                {
                    dgv_sim.Rows.Add((i + 1), reloj, tpoSigLlegada, proxLlegada,
                        rnd_Demora, demora,
                        fin_estacionamiento1, fin_estacionamiento2, fin_estacionamiento3, fin_estacionamiento4, fin_estacionamiento5,
                        rnd_Interrupcion, tamano_interrupcion, tpo_interrupcion, prox_interrupcion,
                        proxInspeccion, estadoInspector, fin_inspeccion, fin_interrupcion,
                        estado_est1, estado_est2, estado_est3, estado_est4, estado_est5,
                        acMultas, acAutosSinPoderEstacionar);


                    if (auto1.Fin_estacionamiento != 0)
                    {
                        dgv_sim.Rows[i].Cells[auto1.Nombre].Value = auto1.Estado.ToString();
                    }
                    if (auto2.Fin_estacionamiento != 0)
                    {
                        dgv_sim.Rows[i].Cells[auto2.Nombre].Value = auto2.Estado.ToString();
                    }
                    if (auto3.Fin_estacionamiento != 0)
                    {
                        dgv_sim.Rows[i].Cells[auto3.Nombre].Value = auto3.Estado.ToString();
                    }
                    if (auto4.Fin_estacionamiento != 0)
                    {
                        dgv_sim.Rows[i].Cells[auto4.Nombre].Value = auto4.Estado.ToString();
                    }
                    if (auto5.Fin_estacionamiento != 0)
                    {
                        dgv_sim.Rows[i].Cells[auto5.Nombre].Value = auto5.Estado.ToString();
                    }
                    if (autoX.Estado != null)
                    {
                        dgv_sim.Rows[i].Cells[autoX.Nombre].Value = autoX.Estado.ToString();
                    }
                }
                tpoSigLlegada = 0;
            }
            btn_tryAgain.Focus();
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
                txt_iteracionHasta.SelectAll();
                MessageBox.Show("Incongruencia en los intervalos de iteracion, 'Hasta' no puede ser menor que 'Desde'", "simulacion_g7", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.Parse(txt_iteracionHasta.Text) > int.Parse(txt_cantExperimentos.Text))
            {
                txt_iteracionHasta.Focus();
                txt_iteracionHasta.SelectAll();
                MessageBox.Show("Hasta tiene que ser menor o igual a la cantidad de experimentos que se desea simular.", "Accion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btn_sameConfig_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < autoNro; i++)
            {
                dgv_sim.Columns.Remove("_estado_auto" + i);
            }

            dgv_sim.Rows.Clear();
            autoNro = 1;

            auto1 = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();
            auto4 = new Auto();
            auto5 = new Auto();

            realizarSimulacion();
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

            for (int i = 1; i < autoNro; i++)
            {
                dgv_sim.Columns.Remove("_estado_auto" + i);
            }

            dgv_sim.Rows.Clear();
            autoNro = 1;

            txt_iteracionDesde.Enabled = true;
            txt_iteracionHasta.Enabled = true;
            txt_cantExperimentos.Enabled = true;
            txt_media.Enabled = true;
            txt_desvEstandar.Enabled = true;

            btn_resultados.Enabled = false;
            btn_empezarSim.Enabled = true;
            btn_tryAgain.Enabled = false;
            btn_sameConfig.Enabled = false;

            txt_cantExperimentos.Focus();

            auto1 = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();
            auto4 = new Auto();
            auto5 = new Auto();            
        }
        private void btn_resultados_Click(object sender, EventArgs e)
        {

            string str = "En total, " + acAutosSinPoderEstacionar + " autos no encontraron lugar para estacionar."
                + "\nEl inspector levantó " + acMultas + " infracciones.";

            MessageBox.Show(str, "Resultados de la Simulacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btn_euler_Click(object sender, EventArgs e)
        {
            TP6 euler = new TP6();
            euler.Show();
        }

        
    }
}
