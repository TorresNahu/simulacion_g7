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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sim)).BeginInit();
            this.gbx_vectorEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sim
            // 
            this.dgv_sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sim.Location = new System.Drawing.Point(12, 143);
            this.dgv_sim.Name = "dgv_sim";
            this.dgv_sim.Size = new System.Drawing.Size(1307, 150);
            this.dgv_sim.TabIndex = 0;
            // 
            // btn_resultados
            // 
            this.btn_resultados.Location = new System.Drawing.Point(783, 45);
            this.btn_resultados.Name = "btn_resultados";
            this.btn_resultados.Size = new System.Drawing.Size(130, 28);
            this.btn_resultados.TabIndex = 11;
            this.btn_resultados.Text = "Ver Resultados";
            this.btn_resultados.UseVisualStyleBackColor = true;
            // 
            // btn_tryAgain
            // 
            this.btn_tryAgain.Location = new System.Drawing.Point(633, 45);
            this.btn_tryAgain.Name = "btn_tryAgain";
            this.btn_tryAgain.Size = new System.Drawing.Size(130, 28);
            this.btn_tryAgain.TabIndex = 10;
            this.btn_tryAgain.Text = "Probar otra simulacion";
            this.btn_tryAgain.UseVisualStyleBackColor = true;
            // 
            // btn_empezarSim
            // 
            this.btn_empezarSim.Location = new System.Drawing.Point(480, 45);
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
            this.gbx_vectorEstado.Size = new System.Drawing.Size(443, 85);
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
            // Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 305);
            this.Controls.Add(this.btn_resultados);
            this.Controls.Add(this.btn_tryAgain);
            this.Controls.Add(this.btn_empezarSim);
            this.Controls.Add(this.gbx_vectorEstado);
            this.Controls.Add(this.dgv_sim);
            this.Name = "Estacionamiento";
            this.Text = "Estacionamiento";
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
    }
}