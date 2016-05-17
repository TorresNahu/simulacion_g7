namespace Simulacion_G7
{
    partial class DistribucionUniforme
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
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.grafico_dist_uniforme = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_intentar_de_nuevo = new System.Windows.Forms.Button();
            this.lbl_limite_superior = new System.Windows.Forms.Label();
            this.cant_a_generar = new System.Windows.Forms.Label();
            this.lbl_limite_inferior = new System.Windows.Forms.Label();
            this.lbl_cant_intervalos = new System.Windows.Forms.Label();
            this.txt_lim_inferior = new System.Windows.Forms.TextBox();
            this.txt_lim_superior = new System.Windows.Forms.TextBox();
            this.txt_cant_a_generar = new System.Windows.Forms.TextBox();
            this.txt_cant_intervalos = new System.Windows.Forms.TextBox();
            this.btn_generar_numeros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pruebaChi = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_uniforme)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Location = new System.Drawing.Point(12, 230);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.Size = new System.Drawing.Size(302, 411);
            this.dgv_numeros.TabIndex = 8;
            // 
            // grafico_dist_uniforme
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico_dist_uniforme.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico_dist_uniforme.Legends.Add(legend1);
            this.grafico_dist_uniforme.Location = new System.Drawing.Point(343, 12);
            this.grafico_dist_uniforme.Name = "grafico_dist_uniforme";
            this.grafico_dist_uniforme.Size = new System.Drawing.Size(669, 629);
            this.grafico_dist_uniforme.TabIndex = 9;
            this.grafico_dist_uniforme.TabStop = false;
            this.grafico_dist_uniforme.Text = "tt";
            // 
            // btn_intentar_de_nuevo
            // 
            this.btn_intentar_de_nuevo.Location = new System.Drawing.Point(38, 176);
            this.btn_intentar_de_nuevo.Name = "btn_intentar_de_nuevo";
            this.btn_intentar_de_nuevo.Size = new System.Drawing.Size(135, 23);
            this.btn_intentar_de_nuevo.TabIndex = 7;
            this.btn_intentar_de_nuevo.Text = "Intentar de Nuevo";
            this.btn_intentar_de_nuevo.UseVisualStyleBackColor = true;
            this.btn_intentar_de_nuevo.Click += new System.EventHandler(this.btn_intentar_de_nuevo_Click);
            // 
            // lbl_limite_superior
            // 
            this.lbl_limite_superior.AutoSize = true;
            this.lbl_limite_superior.Location = new System.Drawing.Point(48, 43);
            this.lbl_limite_superior.Name = "lbl_limite_superior";
            this.lbl_limite_superior.Size = new System.Drawing.Size(74, 13);
            this.lbl_limite_superior.TabIndex = 1;
            this.lbl_limite_superior.Text = "Limite superior";
            // 
            // cant_a_generar
            // 
            this.cant_a_generar.AutoSize = true;
            this.cant_a_generar.Location = new System.Drawing.Point(25, 69);
            this.cant_a_generar.Name = "cant_a_generar";
            this.cant_a_generar.Size = new System.Drawing.Size(97, 13);
            this.cant_a_generar.TabIndex = 2;
            this.cant_a_generar.Text = "Cantidad a generar";
            // 
            // lbl_limite_inferior
            // 
            this.lbl_limite_inferior.AutoSize = true;
            this.lbl_limite_inferior.Location = new System.Drawing.Point(54, 17);
            this.lbl_limite_inferior.Name = "lbl_limite_inferior";
            this.lbl_limite_inferior.Size = new System.Drawing.Size(68, 13);
            this.lbl_limite_inferior.TabIndex = 0;
            this.lbl_limite_inferior.Text = "Limite inferior";
            // 
            // lbl_cant_intervalos
            // 
            this.lbl_cant_intervalos.AutoSize = true;
            this.lbl_cant_intervalos.Location = new System.Drawing.Point(10, 95);
            this.lbl_cant_intervalos.Name = "lbl_cant_intervalos";
            this.lbl_cant_intervalos.Size = new System.Drawing.Size(112, 13);
            this.lbl_cant_intervalos.TabIndex = 2;
            this.lbl_cant_intervalos.Text = "Cantidad de intervalos";
            // 
            // txt_lim_inferior
            // 
            this.txt_lim_inferior.Location = new System.Drawing.Point(128, 14);
            this.txt_lim_inferior.Name = "txt_lim_inferior";
            this.txt_lim_inferior.Size = new System.Drawing.Size(64, 20);
            this.txt_lim_inferior.TabIndex = 1;
            this.txt_lim_inferior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lim_inferior_KeyPress);
            // 
            // txt_lim_superior
            // 
            this.txt_lim_superior.Location = new System.Drawing.Point(128, 40);
            this.txt_lim_superior.Name = "txt_lim_superior";
            this.txt_lim_superior.Size = new System.Drawing.Size(64, 20);
            this.txt_lim_superior.TabIndex = 2;
            this.txt_lim_superior.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lim_superior_KeyPress);
            // 
            // txt_cant_a_generar
            // 
            this.txt_cant_a_generar.Location = new System.Drawing.Point(127, 66);
            this.txt_cant_a_generar.Name = "txt_cant_a_generar";
            this.txt_cant_a_generar.Size = new System.Drawing.Size(65, 20);
            this.txt_cant_a_generar.TabIndex = 3;
            this.txt_cant_a_generar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_a_generar_KeyPress);
            // 
            // txt_cant_intervalos
            // 
            this.txt_cant_intervalos.Location = new System.Drawing.Point(127, 92);
            this.txt_cant_intervalos.Name = "txt_cant_intervalos";
            this.txt_cant_intervalos.Size = new System.Drawing.Size(65, 20);
            this.txt_cant_intervalos.TabIndex = 4;
            this.txt_cant_intervalos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_intervalos_KeyPress);
            // 
            // btn_generar_numeros
            // 
            this.btn_generar_numeros.Location = new System.Drawing.Point(38, 118);
            this.btn_generar_numeros.Name = "btn_generar_numeros";
            this.btn_generar_numeros.Size = new System.Drawing.Size(136, 23);
            this.btn_generar_numeros.TabIndex = 5;
            this.btn_generar_numeros.Text = "Generar Números";
            this.btn_generar_numeros.UseVisualStyleBackColor = true;
            this.btn_generar_numeros.Click += new System.EventHandler(this.btn_generar_numeros_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_pruebaChi);
            this.panel1.Controls.Add(this.btn_generar_numeros);
            this.panel1.Controls.Add(this.btn_intentar_de_nuevo);
            this.panel1.Controls.Add(this.txt_cant_intervalos);
            this.panel1.Controls.Add(this.txt_cant_a_generar);
            this.panel1.Controls.Add(this.txt_lim_superior);
            this.panel1.Controls.Add(this.txt_lim_inferior);
            this.panel1.Controls.Add(this.lbl_cant_intervalos);
            this.panel1.Controls.Add(this.lbl_limite_inferior);
            this.panel1.Controls.Add(this.cant_a_generar);
            this.panel1.Controls.Add(this.lbl_limite_superior);
            this.panel1.Location = new System.Drawing.Point(56, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 212);
            this.panel1.TabIndex = 3;
            // 
            // btn_pruebaChi
            // 
            this.btn_pruebaChi.Location = new System.Drawing.Point(38, 147);
            this.btn_pruebaChi.Name = "btn_pruebaChi";
            this.btn_pruebaChi.Size = new System.Drawing.Size(136, 23);
            this.btn_pruebaChi.TabIndex = 6;
            this.btn_pruebaChi.Text = "Realizar Prueba ";
            this.btn_pruebaChi.UseVisualStyleBackColor = true;
            this.btn_pruebaChi.Click += new System.EventHandler(this.btn_pruebaChi_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(934, 647);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(78, 27);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // DistribucionUniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 688);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.grafico_dist_uniforme);
            this.Controls.Add(this.dgv_numeros);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1049, 749);
            this.MinimumSize = new System.Drawing.Size(1049, 726);
            this.Name = "DistribucionUniforme";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistribucionUniforme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DistribucionUniforme_FormClosing);
            this.Load += new System.EventHandler(this.DistribucionUniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_uniforme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_dist_uniforme;
        private System.Windows.Forms.Button btn_intentar_de_nuevo;
        private System.Windows.Forms.Label lbl_limite_superior;
        private System.Windows.Forms.Label cant_a_generar;
        private System.Windows.Forms.Label lbl_limite_inferior;
        private System.Windows.Forms.Label lbl_cant_intervalos;
        private System.Windows.Forms.TextBox txt_lim_inferior;
        private System.Windows.Forms.TextBox txt_lim_superior;
        private System.Windows.Forms.TextBox txt_cant_a_generar;
        private System.Windows.Forms.TextBox txt_cant_intervalos;
        private System.Windows.Forms.Button btn_generar_numeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_pruebaChi;
    }
}