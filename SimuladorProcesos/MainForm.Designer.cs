namespace SimuladorProcesos
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProcesos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSuspender = new System.Windows.Forms.Button();
            this.buttonReanudar = new System.Windows.Forms.Button();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.estado});
            this.dataGridViewProcesos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProcesos.Name = "dataGridViewProcesos";
            this.dataGridViewProcesos.Size = new System.Drawing.Size(343, 321);
            this.dataGridViewProcesos.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // buttonSuspender
            // 
            this.buttonSuspender.Location = new System.Drawing.Point(395, 43);
            this.buttonSuspender.Name = "buttonSuspender";
            this.buttonSuspender.Size = new System.Drawing.Size(75, 23);
            this.buttonSuspender.TabIndex = 1;
            this.buttonSuspender.Text = "Suspender";
            this.buttonSuspender.UseVisualStyleBackColor = true;
            // 
            // buttonReanudar
            // 
            this.buttonReanudar.Location = new System.Drawing.Point(395, 88);
            this.buttonReanudar.Name = "buttonReanudar";
            this.buttonReanudar.Size = new System.Drawing.Size(75, 23);
            this.buttonReanudar.TabIndex = 2;
            this.buttonReanudar.Text = "Reanudar";
            this.buttonReanudar.UseVisualStyleBackColor = true;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(395, 133);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(75, 23);
            this.buttonFinalizar.TabIndex = 3;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 345);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonReanudar);
            this.Controls.Add(this.buttonSuspender);
            this.Controls.Add(this.dataGridViewProcesos);
            this.Name = "MainForm";
            this.Text = "Simulador de procesos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Button buttonSuspender;
        private System.Windows.Forms.Button buttonReanudar;
        private System.Windows.Forms.Button buttonFinalizar;
    }
}

