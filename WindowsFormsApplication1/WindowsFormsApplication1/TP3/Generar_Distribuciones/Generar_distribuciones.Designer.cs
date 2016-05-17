namespace WindowsFormsApplication1.TP3.Generar_Distribuciones
{
    partial class Generar_distribuciones
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dist_normal = new System.Windows.Forms.Button();
            this.btn_dist_poisson = new System.Windows.Forms.Button();
            this.btn_dist_exponencial = new System.Windows.Forms.Button();
            this.btn_dist_uniforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(222, 219);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eliga la Distribucion que desea probar:";
            // 
            // btn_dist_normal
            // 
            this.btn_dist_normal.Location = new System.Drawing.Point(65, 164);
            this.btn_dist_normal.Name = "btn_dist_normal";
            this.btn_dist_normal.Size = new System.Drawing.Size(172, 23);
            this.btn_dist_normal.TabIndex = 10;
            this.btn_dist_normal.Text = "Distribución Normal";
            this.btn_dist_normal.UseVisualStyleBackColor = true;
            this.btn_dist_normal.Click += new System.EventHandler(this.btn_dist_normal_Click);
            // 
            // btn_dist_poisson
            // 
            this.btn_dist_poisson.Location = new System.Drawing.Point(65, 126);
            this.btn_dist_poisson.Name = "btn_dist_poisson";
            this.btn_dist_poisson.Size = new System.Drawing.Size(172, 23);
            this.btn_dist_poisson.TabIndex = 9;
            this.btn_dist_poisson.Text = "Distribución Poisson";
            this.btn_dist_poisson.UseVisualStyleBackColor = true;
            this.btn_dist_poisson.Click += new System.EventHandler(this.btn_dist_poisson_Click);
            // 
            // btn_dist_exponencial
            // 
            this.btn_dist_exponencial.Location = new System.Drawing.Point(65, 86);
            this.btn_dist_exponencial.Name = "btn_dist_exponencial";
            this.btn_dist_exponencial.Size = new System.Drawing.Size(172, 23);
            this.btn_dist_exponencial.TabIndex = 8;
            this.btn_dist_exponencial.Text = "Distribución Exponencial";
            this.btn_dist_exponencial.UseVisualStyleBackColor = true;
            this.btn_dist_exponencial.Click += new System.EventHandler(this.btn_dist_exponencial_Click);
            // 
            // btn_dist_uniforme
            // 
            this.btn_dist_uniforme.Location = new System.Drawing.Point(65, 50);
            this.btn_dist_uniforme.Name = "btn_dist_uniforme";
            this.btn_dist_uniforme.Size = new System.Drawing.Size(172, 23);
            this.btn_dist_uniforme.TabIndex = 7;
            this.btn_dist_uniforme.Text = "Distribución Uniforme";
            this.btn_dist_uniforme.UseVisualStyleBackColor = true;
            this.btn_dist_uniforme.Click += new System.EventHandler(this.btn_dist_uniforme_Click);
            // 
            // Generar_distribuciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 254);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dist_normal);
            this.Controls.Add(this.btn_dist_poisson);
            this.Controls.Add(this.btn_dist_exponencial);
            this.Controls.Add(this.btn_dist_uniforme);
            this.Name = "Generar_distribuciones";
            this.Text = "Generar_distribuciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Generar_distribuciones_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dist_normal;
        private System.Windows.Forms.Button btn_dist_poisson;
        private System.Windows.Forms.Button btn_dist_exponencial;
        private System.Windows.Forms.Button btn_dist_uniforme;
    }
}