namespace Simulacion_G7
{
    partial class DistribucionNormal
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.grafico_dist_normal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_numeros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_CantIntervalos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desvEstandar = new System.Windows.Forms.TextBox();
            this.lbl_desvEstandar = new System.Windows.Forms.Label();
            this.btn_intentar_de_nuevo = new System.Windows.Forms.Button();
            this.btn_generar_numeros = new System.Windows.Forms.Button();
            this.txt_cant_a_generar = new System.Windows.Forms.TextBox();
            this.txt_media = new System.Windows.Forms.TextBox();
            this.cant_a_generar = new System.Windows.Forms.Label();
            this.lbl_media = new System.Windows.Forms.Label();
            this.btn_realizarPrueba = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(944, 643);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // grafico_dist_normal
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico_dist_normal.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico_dist_normal.Legends.Add(legend2);
            this.grafico_dist_normal.Location = new System.Drawing.Point(350, 12);
            this.grafico_dist_normal.Name = "grafico_dist_normal";
            this.grafico_dist_normal.Size = new System.Drawing.Size(669, 625);
            this.grafico_dist_normal.TabIndex = 9;
            this.grafico_dist_normal.TabStop = false;
            // 
            // dgv_numeros
            // 
            this.dgv_numeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_numeros.Location = new System.Drawing.Point(14, 231);
            this.dgv_numeros.Name = "dgv_numeros";
            this.dgv_numeros.Size = new System.Drawing.Size(302, 406);
            this.dgv_numeros.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_realizarPrueba);
            this.panel1.Controls.Add(this.txt_CantIntervalos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_desvEstandar);
            this.panel1.Controls.Add(this.lbl_desvEstandar);
            this.panel1.Controls.Add(this.btn_intentar_de_nuevo);
            this.panel1.Controls.Add(this.btn_generar_numeros);
            this.panel1.Controls.Add(this.txt_cant_a_generar);
            this.panel1.Controls.Add(this.txt_media);
            this.panel1.Controls.Add(this.cant_a_generar);
            this.panel1.Controls.Add(this.lbl_media);
            this.panel1.Location = new System.Drawing.Point(47, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 213);
            this.panel1.TabIndex = 0;
            // 
            // txt_CantIntervalos
            // 
            this.txt_CantIntervalos.Location = new System.Drawing.Point(126, 95);
            this.txt_CantIntervalos.Name = "txt_CantIntervalos";
            this.txt_CantIntervalos.Size = new System.Drawing.Size(65, 20);
            this.txt_CantIntervalos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad de Intervalos";
            // 
            // txt_desvEstandar
            // 
            this.txt_desvEstandar.Location = new System.Drawing.Point(126, 43);
            this.txt_desvEstandar.Name = "txt_desvEstandar";
            this.txt_desvEstandar.Size = new System.Drawing.Size(65, 20);
            this.txt_desvEstandar.TabIndex = 2;
            this.txt_desvEstandar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desvEstandar_KeyPress);
            // 
            // lbl_desvEstandar
            // 
            this.lbl_desvEstandar.AutoSize = true;
            this.lbl_desvEstandar.Location = new System.Drawing.Point(40, 46);
            this.lbl_desvEstandar.Name = "lbl_desvEstandar";
            this.lbl_desvEstandar.Size = new System.Drawing.Size(80, 13);
            this.lbl_desvEstandar.TabIndex = 14;
            this.lbl_desvEstandar.Text = "Desv. Estandar";
            // 
            // btn_intentar_de_nuevo
            // 
            this.btn_intentar_de_nuevo.Location = new System.Drawing.Point(55, 179);
            this.btn_intentar_de_nuevo.Name = "btn_intentar_de_nuevo";
            this.btn_intentar_de_nuevo.Size = new System.Drawing.Size(136, 23);
            this.btn_intentar_de_nuevo.TabIndex = 7;
            this.btn_intentar_de_nuevo.Text = "Intentar de Nuevo";
            this.btn_intentar_de_nuevo.UseVisualStyleBackColor = true;
            this.btn_intentar_de_nuevo.Click += new System.EventHandler(this.btn_intentar_de_nuevo_Click);
            // 
            // btn_generar_numeros
            // 
            this.btn_generar_numeros.Location = new System.Drawing.Point(55, 121);
            this.btn_generar_numeros.Name = "btn_generar_numeros";
            this.btn_generar_numeros.Size = new System.Drawing.Size(136, 23);
            this.btn_generar_numeros.TabIndex = 5;
            this.btn_generar_numeros.Text = "Generar Números";
            this.btn_generar_numeros.UseVisualStyleBackColor = true;
            this.btn_generar_numeros.Click += new System.EventHandler(this.btn_generar_numeros_Click);
            // 
            // txt_cant_a_generar
            // 
            this.txt_cant_a_generar.Location = new System.Drawing.Point(126, 69);
            this.txt_cant_a_generar.Name = "txt_cant_a_generar";
            this.txt_cant_a_generar.Size = new System.Drawing.Size(65, 20);
            this.txt_cant_a_generar.TabIndex = 3;
            this.txt_cant_a_generar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cant_a_generar_KeyPress);
            // 
            // txt_media
            // 
            this.txt_media.Location = new System.Drawing.Point(127, 17);
            this.txt_media.Name = "txt_media";
            this.txt_media.Size = new System.Drawing.Size(64, 20);
            this.txt_media.TabIndex = 1;
            this.txt_media.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_media_KeyPress);
            // 
            // cant_a_generar
            // 
            this.cant_a_generar.AutoSize = true;
            this.cant_a_generar.Location = new System.Drawing.Point(24, 72);
            this.cant_a_generar.Name = "cant_a_generar";
            this.cant_a_generar.Size = new System.Drawing.Size(97, 13);
            this.cant_a_generar.TabIndex = 2;
            this.cant_a_generar.Text = "Cantidad a generar";
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.Location = new System.Drawing.Point(76, 20);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(36, 13);
            this.lbl_media.TabIndex = 1;
            this.lbl_media.Text = "Media";
            // 
            // btn_realizarPrueba
            // 
            this.btn_realizarPrueba.Location = new System.Drawing.Point(55, 150);
            this.btn_realizarPrueba.Name = "btn_realizarPrueba";
            this.btn_realizarPrueba.Size = new System.Drawing.Size(136, 23);
            this.btn_realizarPrueba.TabIndex = 6;
            this.btn_realizarPrueba.Text = "Realizar Prueba";
            this.btn_realizarPrueba.UseVisualStyleBackColor = true;
            // 
            // DistribucionNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 678);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.grafico_dist_normal);
            this.Controls.Add(this.dgv_numeros);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1055, 716);
            this.MinimumSize = new System.Drawing.Size(1055, 716);
            this.Name = "DistribucionNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistribucionNormal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DistribucionNormal_FormClosing);
            this.Load += new System.EventHandler(this.DistribucionNormal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico_dist_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_numeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_dist_normal;
        private System.Windows.Forms.DataGridView dgv_numeros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_desvEstandar;
        private System.Windows.Forms.Label lbl_desvEstandar;
        private System.Windows.Forms.Button btn_intentar_de_nuevo;
        private System.Windows.Forms.Button btn_generar_numeros;
        private System.Windows.Forms.TextBox txt_cant_a_generar;
        private System.Windows.Forms.TextBox txt_media;
        private System.Windows.Forms.Label cant_a_generar;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.TextBox txt_CantIntervalos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_realizarPrueba;
    }
}