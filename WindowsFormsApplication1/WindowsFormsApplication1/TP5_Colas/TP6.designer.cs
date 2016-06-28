namespace WindowsFormsApplication1.TP5_Colas
{
    partial class TP6
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
            this.dgv_euler = new System.Windows.Forms.DataGridView();
            this._t_tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._T_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._tmas1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_euler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_euler
            // 
            this.dgv_euler.AllowUserToAddRows = false;
            this.dgv_euler.AllowUserToDeleteRows = false;
            this.dgv_euler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_euler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._t_tiempo,
            this._T_,
            this._tmas1});
            this.dgv_euler.Location = new System.Drawing.Point(12, 12);
            this.dgv_euler.Name = "dgv_euler";
            this.dgv_euler.Size = new System.Drawing.Size(316, 709);
            this.dgv_euler.TabIndex = 0;
            // 
            // _t_tiempo
            // 
            this._t_tiempo.HeaderText = "t";
            this._t_tiempo.Name = "_t_tiempo";
            this._t_tiempo.Width = 70;
            // 
            // _T_
            // 
            this._T_.HeaderText = "T";
            this._T_.Name = "_T_";
            // 
            // _tmas1
            // 
            this._tmas1.HeaderText = "dT/dt";
            this._tmas1.Name = "_tmas1";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(257, 727);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // TP6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 792);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dgv_euler);
            this.MaximumSize = new System.Drawing.Size(360, 830);
            this.MinimumSize = new System.Drawing.Size(360, 830);
            this.Name = "TP6";
            this.Text = "Tabla de Euler";
            this.Load += new System.EventHandler(this.TP6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_euler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_euler;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn _t_tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn _T_;
        private System.Windows.Forms.DataGridViewTextBoxColumn _tmas1;
    }
}