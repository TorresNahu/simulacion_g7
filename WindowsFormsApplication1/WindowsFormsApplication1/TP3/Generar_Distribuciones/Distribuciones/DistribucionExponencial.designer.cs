namespace Simulacion_G7
{
    partial class DistribucionExponencial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lbl_lambda = new System.Windows.Forms.Label();
            this.cant_a_generar = new System.Windows.Forms.Label();
            this.txt_lambda = new System.Windows.Forms.TextBox();
            this.txt_cant_a_generar = new System.Windows.Forms.TextBox();
            this.btn_generar_numeros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_cant_intervalos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pruebaChi = new System.Windows.Forms.Button();
            this.btn_intentar_de_nuevo = new System.Windows.Forms.Button();
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.grafico_dist_exponencial = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_exponencial)).BeginInit();
            this.SuspendLayout();
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
            // cant_a_generar
            // 
            this.cant_a_generar.AutoSize = true;
            this.cant_a_generar.Location = new System.Drawing.Point(24, 53);
            this.cant_a_generar.Name = "cant_a_generar";
            this.cant_a_generar.Size = new System.Drawing.Size(97, 13);
            this.cant_a_generar.TabIndex = 2;
            this.cant_a_generar.Text = "Cantidad a generar";
            // 
            // txt_lambda
            // 
            this.txt_lambda.Location = new System.Drawing.Point(127, 24);
            this.txt_lambda.Name = "txt_lambda";
            this.txt_lambda.Size = new System.Drawing.Size(64, 20);
            this.txt_lambda.TabIndex = 1;
            this.txt_lambda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lambda_KeyPress);
            // 
            // txt_cant_a_generar
            // 
            this.txt_cant_a_generar.Location = new System.Drawing.Point(126, 50);
            this.txt_cant_a_generar.Name = "txt_cant_a_generar";
            this.txt_cant_a_generar.Size = new System.Drawing.Size(65, 20);
            this.txt_cant_a_generar.TabIndex = 2;
            this.txt_cant_a_generar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_a_generar_KeyPress);
            // 
            // btn_generar_numeros
            // 
            this.btn_generar_numeros.Location = new System.Drawing.Point(55, 102);
            this.btn_generar_numeros.Name = "btn_generar_numeros";
            this.btn_generar_numeros.Size = new System.Drawing.Size(136, 23);
            this.btn_generar_numeros.TabIndex = 4;
            this.btn_generar_numeros.Text = "Generar Números";
            this.btn_generar_numeros.UseVisualStyleBackColor = true;
            this.btn_generar_numeros.Click += new System.EventHandler(this.btn_generar_numeros_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_cant_intervalos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_pruebaChi);
            this.panel1.Controls.Add(this.btn_intentar_de_nuevo);
            this.panel1.Controls.Add(this.btn_generar_numeros);
            this.panel1.Controls.Add(this.txt_cant_a_generar);
            this.panel1.Controls.Add(this.txt_lambda);
            this.panel1.Controls.Add(this.cant_a_generar);
            this.panel1.Controls.Add(this.lbl_lambda);
            this.panel1.Location = new System.Drawing.Point(77, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 195);
            this.panel1.TabIndex = 4;
            // 
            // txt_cant_intervalos
            // 
            this.txt_cant_intervalos.Location = new System.Drawing.Point(126, 76);
            this.txt_cant_intervalos.Name = "txt_cant_intervalos";
            this.txt_cant_intervalos.Size = new System.Drawing.Size(65, 20);
            this.txt_cant_intervalos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad de intervalos\r\n";
            // 
            // btn_pruebaChi
            // 
            this.btn_pruebaChi.Location = new System.Drawing.Point(55, 131);
            this.btn_pruebaChi.Name = "btn_pruebaChi";
            this.btn_pruebaChi.Size = new System.Drawing.Size(136, 23);
            this.btn_pruebaChi.TabIndex = 5;
            this.btn_pruebaChi.Text = "Realizar Prueba ";
            this.btn_pruebaChi.UseVisualStyleBackColor = true;
            this.btn_pruebaChi.Click += new System.EventHandler(this.btn_pruebaChi_Click);
            // 
            // btn_intentar_de_nuevo
            // 
            this.btn_intentar_de_nuevo.Location = new System.Drawing.Point(55, 160);
            this.btn_intentar_de_nuevo.Name = "btn_intentar_de_nuevo";
            this.btn_intentar_de_nuevo.Size = new System.Drawing.Size(136, 23);
            this.btn_intentar_de_nuevo.TabIndex = 6;
            this.btn_intentar_de_nuevo.Text = "Intentar de Nuevo";
            this.btn_intentar_de_nuevo.UseVisualStyleBackColor = true;
            this.btn_intentar_de_nuevo.Click += new System.EventHandler(this.btn_intentar_de_nuevo_Click);
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Location = new System.Drawing.Point(40, 226);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.Size = new System.Drawing.Size(302, 437);
            this.dgv_numeros.TabIndex = 7;
            // 
            // grafico_dist_exponencial
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico_dist_exponencial.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico_dist_exponencial.Legends.Add(legend1);
            this.grafico_dist_exponencial.Location = new System.Drawing.Point(376, 25);
            this.grafico_dist_exponencial.Name = "grafico_dist_exponencial";
            this.grafico_dist_exponencial.Size = new System.Drawing.Size(669, 638);
            this.grafico_dist_exponencial.TabIndex = 8;
            this.grafico_dist_exponencial.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(970, 670);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 9;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // DistribucionExponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 705);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.grafico_dist_exponencial);
            this.Controls.Add(this.dgv_numeros);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1079, 743);
            this.MinimumSize = new System.Drawing.Size(1079, 743);
            this.Name = "DistribucionExponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistribucionExponencial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DistribucionExponencial_FormClosing);
            this.Load += new System.EventHandler(this.DistribucionExponencial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_exponencial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_lambda;
        private System.Windows.Forms.Label cant_a_generar;
        private System.Windows.Forms.TextBox txt_lambda;
        private System.Windows.Forms.TextBox txt_cant_a_generar;
        private System.Windows.Forms.Button btn_generar_numeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_dist_exponencial;
        private System.Windows.Forms.Button btn_intentar_de_nuevo;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_pruebaChi;
        private System.Windows.Forms.TextBox txt_cant_intervalos;
        private System.Windows.Forms.Label label1;
    }
}