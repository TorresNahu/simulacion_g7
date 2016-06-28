namespace Simulacion_G7
{
    partial class Principal
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
            this.btn_tp4 = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_tp3 = new System.Windows.Forms.Button();
            this.btn_tp5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tp4
            // 
            this.btn_tp4.Location = new System.Drawing.Point(48, 85);
            this.btn_tp4.Name = "btn_tp4";
            this.btn_tp4.Size = new System.Drawing.Size(219, 23);
            this.btn_tp4.TabIndex = 2;
            this.btn_tp4.Text = "Ir al Trabajo Práctico N°4";
            this.btn_tp4.UseVisualStyleBackColor = true;
            this.btn_tp4.Click += new System.EventHandler(this.btn_tp4_Click_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(222, 179);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_tp3
            // 
            this.btn_tp3.Location = new System.Drawing.Point(48, 35);
            this.btn_tp3.Name = "btn_tp3";
            this.btn_tp3.Size = new System.Drawing.Size(219, 23);
            this.btn_tp3.TabIndex = 1;
            this.btn_tp3.Text = "Ir al Trabajo Práctico N°3";
            this.btn_tp3.UseVisualStyleBackColor = true;
            this.btn_tp3.Click += new System.EventHandler(this.btn_tp3_Click_1);
            // 
            // btn_tp5
            // 
            this.btn_tp5.Location = new System.Drawing.Point(48, 139);
            this.btn_tp5.Name = "btn_tp5";
            this.btn_tp5.Size = new System.Drawing.Size(219, 23);
            this.btn_tp5.TabIndex = 3;
            this.btn_tp5.Text = "Ir al Trabajo Práctico N°5";
            this.btn_tp5.UseVisualStyleBackColor = true;
            this.btn_tp5.Click += new System.EventHandler(this.btn_tp5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "T.P. N° 3: Variables Aleatorias ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.P. N° 4: Simulacion de Montecarlo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "T.P. N° 5: Modelo de Simulacion Dinamicos (Colas)";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 214);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tp5);
            this.Controls.Add(this.btn_tp4);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_tp3);
            this.MaximumSize = new System.Drawing.Size(325, 252);
            this.MinimumSize = new System.Drawing.Size(325, 252);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumilacion - Grupo 7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tp3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_tp4;
        private System.Windows.Forms.Button btn_tp5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

