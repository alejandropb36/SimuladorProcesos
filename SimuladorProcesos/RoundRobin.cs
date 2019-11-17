using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimuladorProcesos
{
    public class RoundRobin
    {
        DataGridView dataGridView;
        private List<Proceso> ListProcess = new List<Proceso>();
        private Random random;

        public RoundRobin(ref DataGridView temp_dataGridView)
        {
            dataGridView = temp_dataGridView;
            random = new Random();
        }

        private int[] getMemori(Proceso[] procesos)
        {
            int[] memori = new int[procesos.Length];
            for(int i = 0; i < procesos.Length; i++)
            {
                memori[i] = procesos[i].Memoria;
            }
            return memori;
        }
        
        public void runRoundRobin(ref Proceso[] procesos, int quantum, ref Label labelQuantum, ref ProgressBar progressBarBuffer, ref Chart chartProcesos)
        {
            int prioridad = 1;
            bool reducir;
            int max;
            int temp;
            int i;
            int x;
            int productor;
            int[] memoria;


            foreach (var proceso in procesos)
            {
                proceso.TiempoRestante = proceso.Tiempo;
            }

            i = x = productor = temp = 0;
            memoria = getMemori(procesos);
            while (true)
            {
                max = getMax(procesos);
                if (prioridad > max)
                {
                    break;
                }
                
                reducir = true;
                foreach (var task in procesos)
                {
                    if (task.Prioridad == prioridad)
                    {
                        ListProcess.Add(task);
                    }
                }
                IEnumerable<Proceso> ListProcessOrder = ListProcess.OrderBy(process => process.Tiempo);
                foreach (var proceso in ListProcessOrder)
                {
                    
                    if (temp > 0)
                    {
                        if (progressBarBuffer.Value + temp < 100)
                        {
                            progressBarBuffer.Value += temp;
                            temp = 0;
                        }
                    }
                    else
                    {
                        productor = random.Next(50, 80);
                        if (progressBarBuffer.Value + productor < 100)
                        {
                            progressBarBuffer.Value += productor;
                        }
                        else
                        {
                            temp = productor;
                        }
                    }

                    if (proceso.Prioridad == prioridad)
                    {
                        chartProcesos.Series["Memory"].Points.AddXY(x, memoria[i]);

                        if (proceso.TiempoRestante == 0)
                        {
                            proceso.Estado = "COMPLETED";
                            updateDataGridView(dataGridView, procesos);
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
                                proceso.Prioridad = proceso.Prioridad + 1;

                                //
                                if (progressBarBuffer.Value - proceso.Memoria < 0)
                                {
                                    productor = random.Next(10, 100);
                                    
                                    if (progressBarBuffer.Value + productor > 100)
                                    {
                                        int aux = progressBarBuffer.Value + productor;

                                        while (aux > 100)
                                        {
                                            productor = random.Next(10, 30);
                                            aux = progressBarBuffer.Value + productor;

                                        }
                                    }
                                }

                                progressBarBuffer.Value -= proceso.Memoria;

                                proceso.Estado = "READY";
                                updateDataGridView(dataGridView, procesos);
                            }
                            else
                            {
                                proceso.Estado = "RUNNING";
                                updateDataGridView(dataGridView, procesos);
                                executionTimer(proceso.TiempoRestante);

                                //
                                if (progressBarBuffer.Value - proceso.Memoria < 0)
                                {
                                    productor = random.Next(10, 100);

                                    if (progressBarBuffer.Value + productor > 100)
                                    {
                                        int aux = progressBarBuffer.Value + productor;

                                        while (aux > 100)
                                        {
                                            productor = random.Next(10, 30);
                                            aux = progressBarBuffer.Value + productor;
                                        }
                                    }
                                }

                                progressBarBuffer.Value -= proceso.Memoria;

                                proceso.TiempoRestante = 0;
                            
                                proceso.Estado = "COMPLETED";
                                updateDataGridView(dataGridView, procesos);
                            }  
                        }
                        i++;
                        x++;
                        if (i == procesos.Length)
                        {
                            i = 0;
                        }
                    }
                   
                }
                if (reducir)
                {
                    prioridad = prioridad + 1;
                    
                    quantum = quantum * 2;
                    Console.WriteLine(quantum);
                    labelQuantum.Text =  "Quantum: " + quantum.ToString();
                }
                
            }

            chartProcesos.Series["Memory"].Points.AddXY(x, 0);
            progressBarBuffer.Value = 0;
        }

        private int getMax(Proceso[] procesos)
        {
            int max = procesos[0].Prioridad;
            foreach(Proceso proceso in procesos)
            {
                if (proceso.Prioridad > max)
                {
                    max = proceso.Prioridad;
                }
            }
            return max;
        }
        
        public void updateDataGridView(DataGridView dataGridView, Proceso[] procesos)
        {
            dataGridView.Rows.Clear();
            
            foreach (var proceso in procesos)
            {
                string[] row = { proceso.Id.ToString(), proceso.Nombre, proceso.Estado, proceso.TiempoRestante.ToString(), proceso.Prioridad.ToString(), proceso.Memoria.ToString()};
                dataGridView.Rows.Add(row);
            }
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