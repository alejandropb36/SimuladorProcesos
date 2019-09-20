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
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.buttonBloquear = new System.Windows.Forms.Button();
            this.buttonTerminar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericUpDownQuantum = new System.Windows.Forms.NumericUpDown();
            this.labelQuantum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.estado,
            this.tiempo});
            this.dataGridViewProcesos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProcesos.Name = "dataGridViewProcesos";
            this.dataGridViewProcesos.Size = new System.Drawing.Size(377, 277);
            this.dataGridViewProcesos.TabIndex = 0;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Location = new System.Drawing.Point(420, 32);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonEjecutar.TabIndex = 1;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonCorrer_Click);
            // 
            // buttonBloquear
            // 
            this.buttonBloquear.Location = new System.Drawing.Point(420, 79);
            this.buttonBloquear.Name = "buttonBloquear";
            this.buttonBloquear.Size = new System.Drawing.Size(75, 23);
            this.buttonBloquear.TabIndex = 2;
            this.buttonBloquear.Text = "Bloquear";
            this.buttonBloquear.UseVisualStyleBackColor = true;
            this.buttonBloquear.Click += new System.EventHandler(this.buttonSuspender_Click);
            // 
            // buttonTerminar
            // 
            this.buttonTerminar.Location = new System.Drawing.Point(420, 124);
            this.buttonTerminar.Name = "buttonTerminar";
            this.buttonTerminar.Size = new System.Drawing.Size(75, 23);
            this.buttonTerminar.TabIndex = 3;
            this.buttonTerminar.Text = "Terminar";
            this.buttonTerminar.UseVisualStyleBackColor = true;
            this.buttonTerminar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
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
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            // 
            // numericUpDownQuantum
            // 
            this.numericUpDownQuantum.Location = new System.Drawing.Point(439, 205);
            this.numericUpDownQuantum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantum.Name = "numericUpDownQuantum";
            this.numericUpDownQuantum.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownQuantum.TabIndex = 4;
            this.numericUpDownQuantum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelQuantum
            // 
            this.labelQuantum.AutoSize = true;
            this.labelQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantum.Location = new System.Drawing.Point(395, 171);
            this.labelQuantum.Name = "labelQuantum";
            this.labelQuantum.Size = new System.Drawing.Size(82, 20);
            this.labelQuantum.TabIndex = 5;
            this.labelQuantum.Text = "Quantum";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 334);
            this.Controls.Add(this.labelQuantum);
            this.Controls.Add(this.numericUpDownQuantum);
            this.Controls.Add(this.buttonTerminar);
            this.Controls.Add(this.buttonBloquear);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.dataGridViewProcesos);
            this.Name = "MainForm";
            this.Text = "Simulador de procesos Round Robin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.Button buttonBloquear;
        private System.Windows.Forms.Button buttonTerminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantum;
        private System.Windows.Forms.Label labelQuantum;
    }
}

