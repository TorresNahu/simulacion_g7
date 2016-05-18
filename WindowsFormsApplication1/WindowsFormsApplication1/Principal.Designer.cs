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
            this.SuspendLayout();
            // 
            // btn_tp4
            // 
            this.btn_tp4.Location = new System.Drawing.Point(45, 57);
            this.btn_tp4.Name = "btn_tp4";
            this.btn_tp4.Size = new System.Drawing.Size(219, 23);
            this.btn_tp4.TabIndex = 5;
            this.btn_tp4.Text = "Trabajo Práctico N°4";
            this.btn_tp4.UseVisualStyleBackColor = true;
            this.btn_tp4.Click += new System.EventHandler(this.btn_tp4_Click_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(222, 219);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_tp3
            // 
            this.btn_tp3.Location = new System.Drawing.Point(45, 28);
            this.btn_tp3.Name = "btn_tp3";
            this.btn_tp3.Size = new System.Drawing.Size(219, 23);
            this.btn_tp3.TabIndex = 4;
            this.btn_tp3.Text = "Trabajo Práctico N°3";
            this.btn_tp3.UseVisualStyleBackColor = true;
            this.btn_tp3.Click += new System.EventHandler(this.btn_tp3_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 254);
            this.Controls.Add(this.btn_tp4);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_tp3);
            this.MaximumSize = new System.Drawing.Size(325, 292);
            this.MinimumSize = new System.Drawing.Size(325, 292);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumilacion - Grupo 7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tp3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_tp4;
    }
}

