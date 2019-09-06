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
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBloqueados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloqueados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.estado,
            this.duracion});
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
            // duracion
            // 
            this.duracion.HeaderText = "Duración";
            this.duracion.Name = "duracion";
            // 
            // dataGridViewBloqueados
            // 
            this.dataGridViewBloqueados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloqueados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewBloqueados.Location = new System.Drawing.Point(12, 334);
            this.dataGridViewBloqueados.Name = "dataGridViewBloqueados";
            this.dataGridViewBloqueados.Size = new System.Drawing.Size(377, 277);
            this.dataGridViewBloqueados.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Duración";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 623);
            this.Controls.Add(this.dataGridViewBloqueados);
            this.Controls.Add(this.buttonTerminar);
            this.Controls.Add(this.buttonBloquear);
            this.Controls.Add(this.buttonEjecutar);
            this.Controls.Add(this.dataGridViewProcesos);
            this.Name = "MainForm";
            this.Text = "Simulador de procesos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloqueados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.Button buttonBloquear;
        private System.Windows.Forms.Button buttonTerminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridView dataGridViewBloqueados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

