namespace WindowsFormsApplication1.TP5_Colas
{
    partial class Estacionamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_sim = new System.Windows.Forms.DataGridView();
            this.btn_resultados = new System.Windows.Forms.Button();
            this.btn_tryAgain = new System.Windows.Forms.Button();
            this.btn_empezarSim = new System.Windows.Forms.Button();
            this.gbx_vectorEstado = new System.Windows.Forms.GroupBox();
            this.txt_iteracionDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_iteracionHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cantExperimentos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this._interacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._relojCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tiempo_sig_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prox_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._rnd_demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._demora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fin_estacionamiento_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fin_estacionamiento_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fin_estacionamiento_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fin_estacionamiento_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fin_estacionamiento_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._estado_inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._prox_inspeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fin_inspeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._estado_lugar_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._estado_lugar_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._estado_lugar_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._estado_lugar_4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._estado_lugar_5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._acum_multas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._acum_autos_sin_estacionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).BeginInit();
            this.gbx_vectorEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sim
            // 
            this.dgv_sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._interacion,
            this._relojCola,
            this._tiempo_sig_llegada,
            this._prox_llegada,
            this._rnd_demora,
            this._demora,
            this._fin_estacionamiento_1,
            this._fin_estacionamiento_2,
            this._fin_estacionamiento_3,
            this._fin_estacionamiento_4,
            this._fin_estacionamiento_5,
            this._estado_inspector,
            this._prox_inspeccion,
            this._fin_inspeccion,
            this._estado_lugar_1,
            this._estado_lugar_2,
            this._estado_lugar_3,
            this._estado_lugar_4,
            this._estado_lugar_5,
            this._acum_multas,
            this._acum_autos_sin_estacionar});
            this.dgv_sim.Location = new System.Drawing.Point(12, 143);
            this.dgv_sim.Name = "dgv_sim";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_sim.RowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_sim.Size = new System.Drawing.Size(910, 273);
            this.dgv_sim.TabIndex = 0;
            // 
            // btn_resultados
            // 
            this.btn_resultados.Location = new System.Drawing.Point(626, 71);
            this.btn_resultados.Name = "btn_resultados";
            this.btn_resultados.Size = new System.Drawing.Size(141, 28);
            this.btn_resultados.TabIndex = 11;
            this.btn_resultados.Text = "Ver Resultados";
            this.btn_resultados.UseVisualStyleBackColor = true;
            this.btn_resultados.Click += new System.EventHandler(this.btn_resultados_Click);
            // 
            // btn_tryAgain
            // 
            this.btn_tryAgain.Location = new System.Drawing.Point(474, 71);
            this.btn_tryAgain.Name = "btn_tryAgain";
            this.btn_tryAgain.Size = new System.Drawing.Size(130, 28);
            this.btn_tryAgain.TabIndex = 10;
            this.btn_tryAgain.Text = "Probar otra simulacion";
            this.btn_tryAgain.UseVisualStyleBackColor = true;
            this.btn_tryAgain.Click += new System.EventHandler(this.btn_tryAgain_Click);
            // 
            // btn_empezarSim
            // 
            this.btn_empezarSim.Location = new System.Drawing.Point(474, 23);
            this.btn_empezarSim.Name = "btn_empezarSim";
            this.btn_empezarSim.Size = new System.Drawing.Size(130, 28);
            this.btn_empezarSim.TabIndex = 9;
            this.btn_empezarSim.Text = "Empezar Simulacion";
            this.btn_empezarSim.UseVisualStyleBackColor = true;
            this.btn_empezarSim.Click += new System.EventHandler(this.btn_empezarSim_Click);
            // 
            // gbx_vectorEstado
            // 
            this.gbx_vectorEstado.Controls.Add(this.txt_iteracionDesde);
            this.gbx_vectorEstado.Controls.Add(this.label4);
            this.gbx_vectorEstado.Controls.Add(this.txt_iteracionHasta);
            this.gbx_vectorEstado.Controls.Add(this.label3);
            this.gbx_vectorEstado.Controls.Add(this.txt_cantExperimentos);
            this.gbx_vectorEstado.Controls.Add(this.label1);
            this.gbx_vectorEstado.Location = new System.Drawing.Point(12, 12);
            this.gbx_vectorEstado.Name = "gbx_vectorEstado";
            this.gbx_vectorEstado.Size = new System.Drawing.Size(443, 87);
            this.gbx_vectorEstado.TabIndex = 8;
            this.gbx_vectorEstado.TabStop = false;
            this.gbx_vectorEstado.Text = "Vector de Estado";
            // 
            // txt_iteracionDesde
            // 
            this.txt_iteracionDesde.Location = new System.Drawing.Point(154, 45);
            this.txt_iteracionDesde.Name = "txt_iteracionDesde";
            this.txt_iteracionDesde.Size = new System.Drawing.Size(100, 20);
            this.txt_iteracionDesde.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta:";
            // 
            // txt_iteracionHasta
            // 
            this.txt_iteracionHasta.Location = new System.Drawing.Point(313, 45);
            this.txt_iteracionHasta.Name = "txt_iteracionHasta";
            this.txt_iteracionHasta.Size = new System.Drawing.Size(100, 20);
            this.txt_iteracionHasta.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iteraciones desde:";
            // 
            // txt_cantExperimentos
            // 
            this.txt_cantExperimentos.Location = new System.Drawing.Point(154, 19);
            this.txt_cantExperimentos.Name = "txt_cantExperimentos";
            this.txt_cantExperimentos.Size = new System.Drawing.Size(100, 20);
            this.txt_cantExperimentos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Experimentos: ";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(847, 422);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Location = new System.Drawing.Point(626, 23);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(141, 28);
            this.btn_Info.TabIndex = 13;
            this.btn_Info.Text = "Informacion del Problema";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // _interacion
            // 
            this._interacion.HeaderText = "Iteracion N°";
            this._interacion.Name = "_interacion";
            this._interacion.Width = 50;
            // 
            // _relojCola
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this._relojCola.DefaultCellStyle = dataGridViewCellStyle1;
            this._relojCola.HeaderText = "Reloj";
            this._relojCola.Name = "_relojCola";
            this._relojCola.Width = 75;
            // 
            // _tiempo_sig_llegada
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._tiempo_sig_llegada.DefaultCellStyle = dataGridViewCellStyle2;
            this._tiempo_sig_llegada.HeaderText = "Tiempo Siguiente Llegada";
            this._tiempo_sig_llegada.Name = "_tiempo_sig_llegada";
            // 
            // _prox_llegada
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._prox_llegada.DefaultCellStyle = dataGridViewCellStyle3;
            this._prox_llegada.HeaderText = "Prox Llegada";
            this._prox_llegada.Name = "_prox_llegada";
            // 
            // _rnd_demora
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            this._rnd_demora.DefaultCellStyle = dataGridViewCellStyle4;
            this._rnd_demora.HeaderText = "RND Demora estacionamiento";
            this._rnd_demora.Name = "_rnd_demora";
            // 
            // _demora
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            this._demora.DefaultCellStyle = dataGridViewCellStyle5;
            this._demora.HeaderText = "Demora";
            this._demora.Name = "_demora";
            // 
            // _fin_estacionamiento_1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            this._fin_estacionamiento_1.DefaultCellStyle = dataGridViewCellStyle6;
            this._fin_estacionamiento_1.HeaderText = "Fin Estacionamiento 1";
            this._fin_estacionamiento_1.Name = "_fin_estacionamiento_1";
            // 
            // _fin_estacionamiento_2
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            this._fin_estacionamiento_2.DefaultCellStyle = dataGridViewCellStyle7;
            this._fin_estacionamiento_2.HeaderText = "Fin Estacionamiento 2";
            this._fin_estacionamiento_2.Name = "_fin_estacionamiento_2";
            // 
            // _fin_estacionamiento_3
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            this._fin_estacionamiento_3.DefaultCellStyle = dataGridViewCellStyle8;
            this._fin_estacionamiento_3.HeaderText = "Fin Estacionamiento 3";
            this._fin_estacionamiento_3.Name = "_fin_estacionamiento_3";
            // 
            // _fin_estacionamiento_4
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info;
            this._fin_estacionamiento_4.DefaultCellStyle = dataGridViewCellStyle9;
            this._fin_estacionamiento_4.HeaderText = "Fin Estacionamiento 4";
            this._fin_estacionamiento_4.Name = "_fin_estacionamiento_4";
            // 
            // _fin_estacionamiento_5
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info;
            this._fin_estacionamiento_5.DefaultCellStyle = dataGridViewCellStyle10;
            this._fin_estacionamiento_5.HeaderText = "Fin Estacionamiento 5";
            this._fin_estacionamiento_5.Name = "_fin_estacionamiento_5";
            // 
            // _estado_inspector
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Linen;
            this._estado_inspector.DefaultCellStyle = dataGridViewCellStyle11;
            this._estado_inspector.HeaderText = "Estado Inspector";
            this._estado_inspector.Name = "_estado_inspector";
            this._estado_inspector.Width = 55;
            // 
            // _prox_inspeccion
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Linen;
            this._prox_inspeccion.DefaultCellStyle = dataGridViewCellStyle12;
            this._prox_inspeccion.HeaderText = "Prox Inspeccion";
            this._prox_inspeccion.Name = "_prox_inspeccion";
            // 
            // _fin_inspeccion
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Linen;
            this._fin_inspeccion.DefaultCellStyle = dataGridViewCellStyle13;
            this._fin_inspeccion.HeaderText = "Fin Inspeccion";
            this._fin_inspeccion.Name = "_fin_inspeccion";
            // 
            // _estado_lugar_1
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.PaleGreen;
            this._estado_lugar_1.DefaultCellStyle = dataGridViewCellStyle14;
            this._estado_lugar_1.HeaderText = "Estado Lugar 1";
            this._estado_lugar_1.Name = "_estado_lugar_1";
            this._estado_lugar_1.Width = 50;
            // 
            // _estado_lugar_2
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.PaleGreen;
            this._estado_lugar_2.DefaultCellStyle = dataGridViewCellStyle15;
            this._estado_lugar_2.HeaderText = "Estado Lugar 2";
            this._estado_lugar_2.Name = "_estado_lugar_2";
            this._estado_lugar_2.Width = 50;
            // 
            // _estado_lugar_3
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.PaleGreen;
            this._estado_lugar_3.DefaultCellStyle = dataGridViewCellStyle16;
            this._estado_lugar_3.HeaderText = "Estado Lugar 3";
            this._estado_lugar_3.Name = "_estado_lugar_3";
            this._estado_lugar_3.Width = 50;
            // 
            // _estado_lugar_4
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.PaleGreen;
            this._estado_lugar_4.DefaultCellStyle = dataGridViewCellStyle17;
            this._estado_lugar_4.HeaderText = "Estado Lugar 4";
            this._estado_lugar_4.Name = "_estado_lugar_4";
            this._estado_lugar_4.Width = 50;
            // 
            // _estado_lugar_5
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.PaleGreen;
            this._estado_lugar_5.DefaultCellStyle = dataGridViewCellStyle18;
            this._estado_lugar_5.HeaderText = "Estado Lugar 5";
            this._estado_lugar_5.Name = "_estado_lugar_5";
            this._estado_lugar_5.Width = 50;
            // 
            // _acum_multas
            // 
            this._acum_multas.HeaderText = "Acum Multas";
            this._acum_multas.Name = "_acum_multas";
            // 
            // _acum_autos_sin_estacionar
            // 
            this._acum_autos_sin_estacionar.HeaderText = "Acum Autos Sin Estacionar";
            this._acum_autos_sin_estacionar.Name = "_acum_autos_sin_estacionar";
            // 
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 457);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_resultados);
            this.Controls.Add(this.btn_tryAgain);
            this.Controls.Add(this.btn_empezarSim);
            this.Controls.Add(this.gbx_vectorEstado);
            this.Controls.Add(this.dgv_sim);
            this.MaximumSize = new System.Drawing.Size(950, 495);
            this.MinimumSize = new System.Drawing.Size(950, 495);
            this.Name = "Estacionamiento";
            this.Text = "Estacionamiento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Estacionamiento_FormClosing);
            this.Load += new System.EventHandler(this.Estacionamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).EndInit();
            this.gbx_vectorEstado.ResumeLayout(false);
            this.gbx_vectorEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sim;
        private System.Windows.Forms.Button btn_resultados;
        private System.Windows.Forms.Button btn_tryAgain;
        private System.Windows.Forms.Button btn_empezarSim;
        private System.Windows.Forms.GroupBox gbx_vectorEstado;
        private System.Windows.Forms.TextBox txt_iteracionDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_iteracionHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cantExperimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.DataGridViewTextBoxColumn _interacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _relojCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tiempo_sig_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prox_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn _rnd_demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn _demora;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fin_estacionamiento_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fin_estacionamiento_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fin_estacionamiento_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fin_estacionamiento_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fin_estacionamiento_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _estado_inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn _prox_inspeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fin_inspeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn _estado_lugar_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _estado_lugar_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn _estado_lugar_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn _estado_lugar_4;
        private System.Windows.Forms.DataGridViewTextBoxColumn _estado_lugar_5;
        private System.Windows.Forms.DataGridViewTextBoxColumn _acum_multas;
        private System.Windows.Forms.DataGridViewTextBoxColumn _acum_autos_sin_estacionar;
    }
}