namespace Simulacion_G7.TP4_Montecarlo
{
    partial class EjerTortas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cantExperimentos = new System.Windows.Forms.TextBox();
            this.txt_iteracionDesde = new System.Windows.Forms.TextBox();
            this.txt_iteracionHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_vectorEstado = new System.Windows.Forms.GroupBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dgv_vectorEstado = new System.Windows.Forms.DataGridView();
            this.btn_empezarSim = new System.Windows.Forms.Button();
            this.btn_tryAgain = new System.Windows.Forms.Button();
            this.btn_resultados = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidad_por_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum_utilidad_por_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSurtido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum_noSurtido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tortasATirar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum_tortasATirar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multas_acum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbx_vectorEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vectorEstado)).BeginInit();
            this.SuspendLayout();
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
            // txt_cantExperimentos
            // 
            this.txt_cantExperimentos.Location = new System.Drawing.Point(154, 19);
            this.txt_cantExperimentos.Name = "txt_cantExperimentos";
            this.txt_cantExperimentos.Size = new System.Drawing.Size(100, 20);
            this.txt_cantExperimentos.TabIndex = 1;
            // 
            // txt_iteracionDesde
            // 
            this.txt_iteracionDesde.Location = new System.Drawing.Point(154, 45);
            this.txt_iteracionDesde.Name = "txt_iteracionDesde";
            this.txt_iteracionDesde.Size = new System.Drawing.Size(100, 20);
            this.txt_iteracionDesde.TabIndex = 3;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasta:";
            // 
            // gbx_vectorEstado
            // 
            this.gbx_vectorEstado.Controls.Add(this.txt_iteracionDesde);
            this.gbx_vectorEstado.Controls.Add(this.label4);
            this.gbx_vectorEstado.Controls.Add(this.txt_iteracionHasta);
            this.gbx_vectorEstado.Controls.Add(this.label3);
            this.gbx_vectorEstado.Controls.Add(this.txt_cantExperimentos);
            this.gbx_vectorEstado.Controls.Add(this.label1);
            this.gbx_vectorEstado.Location = new System.Drawing.Point(15, 12);
            this.gbx_vectorEstado.Name = "gbx_vectorEstado";
            this.gbx_vectorEstado.Size = new System.Drawing.Size(443, 85);
            this.gbx_vectorEstado.TabIndex = 3;
            this.gbx_vectorEstado.TabStop = false;
            this.gbx_vectorEstado.Text = "Vector de Estado";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1030, 426);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dgv_vectorEstado
            // 
            this.dgv_vectorEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vectorEstado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exp,
            this.rnd_demanda,
            this.demanda,
            this.rnd_multa,
            this.multa,
            this.utilidad_por_dia,
            this.sum_utilidad_por_dia,
            this.noSurtido,
            this.sum_noSurtido,
            this.tortasATirar,
            this.sum_tortasATirar,
            this.multas_acum});
            this.dgv_vectorEstado.Location = new System.Drawing.Point(15, 113);
            this.dgv_vectorEstado.Name = "dgv_vectorEstado";
            this.dgv_vectorEstado.Size = new System.Drawing.Size(1095, 306);
            this.dgv_vectorEstado.TabIndex = 8;
            // 
            // btn_empezarSim
            // 
            this.btn_empezarSim.Location = new System.Drawing.Point(483, 45);
            this.btn_empezarSim.Name = "btn_empezarSim";
            this.btn_empezarSim.Size = new System.Drawing.Size(130, 28);
            this.btn_empezarSim.TabIndex = 5;
            this.btn_empezarSim.Text = "Empezar Simulacion";
            this.btn_empezarSim.UseVisualStyleBackColor = true;
            this.btn_empezarSim.Click += new System.EventHandler(this.btn_empezarSim_Click);
            // 
            // btn_tryAgain
            // 
            this.btn_tryAgain.Location = new System.Drawing.Point(636, 45);
            this.btn_tryAgain.Name = "btn_tryAgain";
            this.btn_tryAgain.Size = new System.Drawing.Size(130, 28);
            this.btn_tryAgain.TabIndex = 6;
            this.btn_tryAgain.Text = "Probar otra simulacion";
            this.btn_tryAgain.UseVisualStyleBackColor = true;
            this.btn_tryAgain.Click += new System.EventHandler(this.btn_tryAgain_Click);
            // 
            // btn_resultados
            // 
            this.btn_resultados.Location = new System.Drawing.Point(786, 45);
            this.btn_resultados.Name = "btn_resultados";
            this.btn_resultados.Size = new System.Drawing.Size(130, 28);
            this.btn_resultados.TabIndex = 7;
            this.btn_resultados.Text = "Ver Resultados";
            this.btn_resultados.UseVisualStyleBackColor = true;
            this.btn_resultados.Click += new System.EventHandler(this.btn_resultados_Click);
            // 
            // exp
            // 
            this.exp.HeaderText = "Exp";
            this.exp.Name = "exp";
            this.exp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.exp.Width = 40;
            // 
            // rnd_demanda
            // 
            this.rnd_demanda.HeaderText = "RND Demanda";
            this.rnd_demanda.Name = "rnd_demanda";
            this.rnd_demanda.Width = 70;
            // 
            // demanda
            // 
            this.demanda.HeaderText = "Demanda";
            this.demanda.Name = "demanda";
            // 
            // rnd_multa
            // 
            this.rnd_multa.HeaderText = "RND Multa";
            this.rnd_multa.Name = "rnd_multa";
            this.rnd_multa.Width = 70;
            // 
            // multa
            // 
            this.multa.HeaderText = "Multa";
            this.multa.Name = "multa";
            // 
            // utilidad_por_dia
            // 
            this.utilidad_por_dia.HeaderText = "Utilidad Por Día";
            this.utilidad_por_dia.Name = "utilidad_por_dia";
            // 
            // sum_utilidad_por_dia
            // 
            this.sum_utilidad_por_dia.HeaderText = "Σ Utilidad Por Día";
            this.sum_utilidad_por_dia.Name = "sum_utilidad_por_dia";
            // 
            // noSurtido
            // 
            this.noSurtido.HeaderText = "Tortas No Surtidas";
            this.noSurtido.Name = "noSurtido";
            // 
            // sum_noSurtido
            // 
            this.sum_noSurtido.HeaderText = "Σ Tortas No Surtidas";
            this.sum_noSurtido.Name = "sum_noSurtido";
            // 
            // tortasATirar
            // 
            this.tortasATirar.HeaderText = "Tortas A Tirar";
            this.tortasATirar.Name = "tortasATirar";
            // 
            // sum_tortasATirar
            // 
            this.sum_tortasATirar.HeaderText = "Σ Tortas A Tirar";
            this.sum_tortasATirar.Name = "sum_tortasATirar";
            // 
            // multas_acum
            // 
            this.multas_acum.HeaderText = "Σ Multas";
            this.multas_acum.Name = "multas_acum";
            this.multas_acum.Width = 60;
            // 
            // EjerTortas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 461);
            this.Controls.Add(this.btn_resultados);
            this.Controls.Add(this.btn_tryAgain);
            this.Controls.Add(this.btn_empezarSim);
            this.Controls.Add(this.dgv_vectorEstado);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gbx_vectorEstado);
            this.Name = "EjerTortas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 15: Tortas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EjerTortas_FormClosing);
            this.Load += new System.EventHandler(this.EjerTortas_Load);
            this.gbx_vectorEstado.ResumeLayout(false);
            this.gbx_vectorEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vectorEstado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cantExperimentos;
        private System.Windows.Forms.TextBox txt_iteracionDesde;
        private System.Windows.Forms.TextBox txt_iteracionHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbx_vectorEstado;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dgv_vectorEstado;
        private System.Windows.Forms.Button btn_empezarSim;
        private System.Windows.Forms.Button btn_tryAgain;
        private System.Windows.Forms.Button btn_resultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidad_por_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum_utilidad_por_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSurtido;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum_noSurtido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tortasATirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum_tortasATirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn multas_acum;
    }
}