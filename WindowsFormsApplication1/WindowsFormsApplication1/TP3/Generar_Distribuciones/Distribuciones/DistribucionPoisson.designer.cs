namespace Simulacion_G7
{
    partial class DistribucionPoisson
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_intentar_de_nuevo = new System.Windows.Forms.Button();
            this.grafico_dist_poisson = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_realizarPrueba = new System.Windows.Forms.Button();
            this.btn_generar_numeros = new System.Windows.Forms.Button();
            this.txt_cant_a_generar = new System.Windows.Forms.TextBox();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.cant_a_generar = new System.Windows.Forms.Label();
            this.lbl_lambda = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_poisson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_intentar_de_nuevo
            // 
            this.btn_intentar_de_nuevo.Location = new System.Drawing.Point(55, 134);
            this.btn_intentar_de_nuevo.Name = "btn_intentar_de_nuevo";
            this.btn_intentar_de_nuevo.Size = new System.Drawing.Size(136, 23);
            this.btn_intentar_de_nuevo.TabIndex = 12;
            this.btn_intentar_de_nuevo.Text = "Intentar de Nuevo";
            this.btn_intentar_de_nuevo.UseVisualStyleBackColor = true;
            this.btn_intentar_de_nuevo.Click += new System.EventHandler(this.btn_intentar_de_nuevo_Click);
            // 
            // grafico_dist_poisson
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico_dist_poisson.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico_dist_poisson.Legends.Add(legend2);
            this.grafico_dist_poisson.Location = new System.Drawing.Point(348, 12);
            this.grafico_dist_poisson.Name = "grafico_dist_poisson";
            this.grafico_dist_poisson.Size = new System.Drawing.Size(669, 588);
            this.grafico_dist_poisson.TabIndex = 11;
            this.grafico_dist_poisson.TabStop = false;
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Location = new System.Drawing.Point(12, 188);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.Size = new System.Drawing.Size(302, 412);
            this.dgv_numeros.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_realizarPrueba);
            this.panel1.Controls.Add(this.btn_intentar_de_nuevo);
            this.panel1.Controls.Add(this.btn_generar_numeros);
            this.panel1.Controls.Add(this.txt_cant_a_generar);
            this.panel1.Controls.Add(this.txt_lambda);
            this.panel1.Controls.Add(this.cant_a_generar);
            this.panel1.Controls.Add(this.lbl_lambda);
            this.panel1.Location = new System.Drawing.Point(45, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 170);
            this.panel1.TabIndex = 9;
            // 
            // btn_realizarPrueba
            // 
            this.btn_realizarPrueba.Location = new System.Drawing.Point(55, 105);
            this.btn_realizarPrueba.Name = "btn_realizarPrueba";
            this.btn_realizarPrueba.Size = new System.Drawing.Size(136, 23);
            this.btn_realizarPrueba.TabIndex = 13;
            this.btn_realizarPrueba.Text = "Realizar Prueba\r\n";
            this.btn_realizarPrueba.UseVisualStyleBackColor = true;
            this.btn_realizarPrueba.Click += new System.EventHandler(this.btn_realizarPrueba_Click);
            // 
            // btn_generar_numeros
            // 
            this.btn_generar_numeros.Location = new System.Drawing.Point(55, 76);
            this.btn_generar_numeros.Name = "btn_generar_numeros";
            this.btn_generar_numeros.Size = new System.Drawing.Size(136, 23);
            this.btn_generar_numeros.TabIndex = 4;
            this.btn_generar_numeros.Text = "Generar Números";
            this.btn_generar_numeros.UseVisualStyleBackColor = true;
            this.btn_generar_numeros.Click += new System.EventHandler(this.btn_generar_numeros_Click);
            // 
            // txt_cant_a_generar
            // 
            this.txt_cant_a_generar.Location = new System.Drawing.Point(126, 50);
            this.txt_cant_a_generar.Name = "txt_cant_a_generar";
            this.txt_cant_a_generar.Size = new System.Drawing.Size(65, 20);
            this.txt_cant_a_generar.TabIndex = 2;
            this.txt_cant_a_generar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_a_generar_KeyPress);
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(127, 24);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(64, 20);
            this.txt_lambda.TabIndex = 1;
            this.txt_lambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lambda_KeyPress);
            // 
            // cant_a_generar
            // 
            this.cant_a_generar.AutoSize = true;
            this.cant_a_generar.Location = new System.Drawing.Point(23, 53);
            this.cant_a_generar.Name = "cant_a_generar";
            this.cant_a_generar.Size = new System.Drawing.Size(97, 13);
            this.cant_a_generar.TabIndex = 2;
            this.cant_a_generar.Text = "Cantidad a generar";
            // 
            // lbl_lambda
            // 
            this.lbl_lambda.AutoSize = true;
            this.lbl_lambda.Location = new System.Drawing.Point(76, 31);
            this.lbl_lambda.Name = "lbl_lambda";
            this.lbl_lambda.Size = new System.Drawing.Size(45, 13);
            this.lbl_lambda.TabIndex = 1;
            this.lbl_lambda.Text = "Lambda";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(942, 614);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // DistribucionPoisson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 649);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.grafico_dist_poisson);
            this.Controls.Add(this.dgv_numeros);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1051, 687);
            this.MinimumSize = new System.Drawing.Size(1051, 687);
            this.Name = "DistribucionPoisson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistribucionPoisson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DistribucionPoisson_FormClosing);
            this.Load += new System.EventHandler(this.DistribucionPoisson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_poisson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_intentar_de_nuevo;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_dist_poisson;
        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_generar_numeros;
        private System.Windows.Forms.TextBox txt_cant_a_generar;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.Label cant_a_generar;
        private System.Windows.Forms.Label lbl_lambda;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_realizarPrueba;
    }
}