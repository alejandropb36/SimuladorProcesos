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

        //----------------RoundRobin Class Constructor-------------------
        public RoundRobin(ref DataGridView temp_dataGridView)
        {
            dataGridView = temp_dataGridView;
        }

        //----------------Main Round Robin Algorithm Method-------------------
        public void runRoundRobin(ref Proceso[] procesos, int quantum)
        {
            //Assign Each Process Its Execution Time
            foreach (var proceso in procesos)
            {
                proceso.TiempoRestante = proceso.Tiempo;
            }
            while (true)
            {
                bool executionFinished = true;
                
                //Loop through all processes until the loop ends
                foreach (var proceso in procesos)
                {
                    if (proceso.TiempoRestante == 0)
                    {
                        proceso.Estado = "COMPLETED";
                        updateDataGridView(dataGridView, procesos);
                    }
                    //Check if the process has any burst time left
                    else if (proceso.TiempoRestante > 0)
                    {
                        //Continue the loop, as a process is executing now and we need to recheck for others
                        executionFinished = false;

                        //Check if the process remaining time is greater than quantum
                        if (proceso.TiempoRestante > quantum)
                        {
                            //Process Status to Running as its Under Execution
                            proceso.Estado = "RUNNING";
                            updateDataGridView(dataGridView, procesos);
                            executionTimer(quantum);

                            //Remove the quantum time from the remaining time
                            proceso.TiempoRestante = proceso.TiempoRestante - quantum;

                            //Swap Process to Ready State after execution and continue for next
                            proceso.Estado = "READY";
                            updateDataGridView(dataGridView, procesos);
                        }
                        //Only runs when the process is on its last cpu burst cycle
                        else
                        {
                            //Check if the process has an IO left before it finishes its last cpu burst cycle
                            while (proceso.IO > 0)
                            {
                                ioExecution(procesos, proceso.Id, proceso.IO);
                                proceso.IO = proceso.IO - 1;
                            }

                            //Process Status to Running as its Under Execution
                            proceso.Estado = "RUNNING";
                            updateDataGridView(dataGridView, procesos);
                            executionTimer(proceso.TiempoRestante);

                            //Set remaining time to 0, as the last cpu burst ended
                            proceso.TiempoRestante = 0;

                            //Change Process Status to Completed
                            proceso.Estado = "COMPLETED";
                            updateDataGridView(dataGridView, procesos);
                        }  
                    }
                    //Execute Single IO after every CPU burst cycle
                    if (proceso.IO > 0)
                    {
                        ioExecution(procesos, proceso.Id, proceso.IO);
                        proceso.IO = proceso.IO - 1;
                    }
                }

                //When All Processes have completed their execution
                if (executionFinished == true)
                {
                    break;
                }
            }
        }

        //----------------Update Data Grid View Method-------------------------------
        public void updateDataGridView(DataGridView dataGridView, Proceso[] procesos)
        {
            //Remove Current Data Grid Rows and Refresh it
            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            //Add Processes rows again to data grid view with updated values
            foreach (var proceso in procesos)
            {
                string[] row = { proceso.Id.ToString(), proceso.Nombre, proceso.Estado, proceso.TiempoRestante.ToString()};
                dataGridView.Rows.Add(row);
            }
        }

        //----------------Process IO Execution Method
        public void ioExecution(Proceso[] procesos, int id, int interupt)
        {
            //Change Process State to Waiting when it goes to IO
            foreach (var proceso in procesos)
            {
                if (proceso.Id == id && proceso.Estado != "COMPLETED")
                {
                    proceso.Estado = "WAITING";
                }
            }
            updateDataGridView(dataGridView, procesos);

            //Execute the IO for 1 second
            executionTimer(1);

            //Change Process back to Ready State after IO has completed
            foreach (var proceso in procesos)
            {
                if (proceso.Id == id && proceso.Estado != "COMPLETED")
                {
                    proceso.Estado = "READY";
                }
            }
            updateDataGridView(dataGridView, procesos);
        }

        //----------------Process Execution Timer Method
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