using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorProcesos
{
    public class RoundRobin
    {
        DataGridView dataGridView;
        
        public RoundRobin(ref DataGridView temp_dataGridView)
        {
            dataGridView = temp_dataGridView;
        }
        
        public void runRoundRobin(ref Proceso[] procesos, int quantum)
        {
            int prioridad = 4;
            bool reducir;
            foreach (var proceso in procesos)
            {
                proceso.TiempoRestante = proceso.Tiempo;
            }
            while (prioridad > 0)
            {
                reducir = true;
                foreach (var proceso in procesos)
                {
                    if(proceso.Prioridad == prioridad)
                    {
                        if (proceso.TiempoRestante == 0)
                        {
                            proceso.Estado = "COMPLETED";
                            updateDataGridView(dataGridView, procesos);
                            reducir = true;
                        }
                        else if (proceso.TiempoRestante > 0)
                        {
                            reducir = false;
                            if (proceso.TiempoRestante > quantum)
                            {
                                proceso.Estado = "RUNNING";
                                updateDataGridView(dataGridView, procesos);
                                executionTimer(quantum);
                            
                                proceso.TiempoRestante = proceso.TiempoRestante - quantum;
                            
                                proceso.Estado = "READY";
                                updateDataGridView(dataGridView, procesos);
                            }
                            else
                            {
                                proceso.Estado = "RUNNING";
                                updateDataGridView(dataGridView, procesos);
                                executionTimer(proceso.TiempoRestante);
                            
                                proceso.TiempoRestante = 0;
                            
                                proceso.Estado = "COMPLETED";
                                updateDataGridView(dataGridView, procesos);
                            }  
                        }
                    }
                }
                if (reducir)
                {
                    prioridad = prioridad - 1; 
                }
            }
        }
        
        public void updateDataGridView(DataGridView dataGridView, Proceso[] procesos)
        {
            dataGridView.Rows.Clear();
            
            foreach (var proceso in procesos)
            {
                string[] row = { proceso.Id.ToString(), proceso.Nombre, proceso.Estado, proceso.TiempoRestante.ToString(), proceso.Prioridad.ToString()};
                dataGridView.Rows.Add(row);
            }
        }
        
        public void ioExecution(Proceso[] procesos, int id, int interupt)
        {
            foreach (var proceso in procesos)
            {
                if (proceso.Id == id && proceso.Estado != "COMPLETED")
                {
                    proceso.Estado = "WAITING";
                }
            }
            updateDataGridView(dataGridView, procesos);
            
            executionTimer(1);
            
            foreach (var proceso in procesos)
            {
                if (proceso.Id == id && proceso.Estado != "COMPLETED")
                {
                    proceso.Estado = "READY";
                }
            }
            updateDataGridView(dataGridView, procesos);
        }
        
        public void executionTimer(int tempTime)
        {
            int executionTime = tempTime * 1000;
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (executionTime == 0 || executionTime < 0)
            {
                return;
            }
            timer1.Interval = executionTime;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}