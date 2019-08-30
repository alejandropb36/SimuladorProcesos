using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;	
using System.Diagnostics;


namespace SimuladorProcesos
{
    public partial class MainForm : Form
    {
        private Thread thread1;
        private Thread thread2;
        private Process[] process;
        private Queue<Process> colaProcesos;
        int hilo;

        public MainForm()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(prepararProceso));
            thread2 = new Thread(new ThreadStart(prepararProceso));
            colaProcesos = new Queue<Process>();

            process = Process.GetProcesses();
            foreach(Process p in process)
            {
                colaProcesos.Enqueue(p);
            }
            agregarProceso(1);
            agregarProceso(2);
            dataGridViewProcesos.Rows[0].Selected = true;
            dataGridViewProcesos.Select();
        }
        
        private void prepararProceso()
        {
            while (true)
                Thread.Sleep(100);
        }

        private void agregarProceso(int hilo)
        {
            Process process = colaProcesos.Dequeue();
            dataGridViewProcesos.Rows.Add(process.Id, process.ProcessName, System.Threading.ThreadState.Running, hilo.ToString());
        }

        private void correr(Thread thread)
        {
            if(thread.ThreadState == System.Threading.ThreadState.Suspended)
            {
                thread.Resume();
            }
            else if(thread.ThreadState == System.Threading.ThreadState.WaitSleepJoin)
            {
                thread.Resume();
            }
            else
            {
                thread.Start();
            }
        }

        private void suspender(Thread thread)
        {
            if(thread.ThreadState == System.Threading.ThreadState.Running)
            {
                thread.Suspend();
            }
        }

        private void finalizar(ref Thread thread)
        {
            if(thread.ThreadState == System.Threading.ThreadState.Running)
            {
                thread.Abort();
                Console.WriteLine(thread.ThreadState);
                thread = new Thread(new ThreadStart(prepararProceso));
                Console.WriteLine(thread.ThreadState);
                
            }
            else
            {
                // Alerta de que no se puede finalizar  por que no esta corriendo
            }
        }

        private void setHilo()
        {
            if(dataGridViewProcesos.CurrentRow.Cells[3].Value.ToString() != "")
            {
                this.hilo = int.Parse(dataGridViewProcesos.CurrentRow.Cells[3].Value.ToString());
            }
            else
            {
                hilo = 0;
            }
        }
        private void buttonCorrer_Click(object sender, EventArgs e)
        {
            setHilo();
            switch (hilo)
            {
                case 1:
                    correr(thread1);
                    dataGridViewProcesos.CurrentRow.Cells[2].Value = thread1.ThreadState;
                    Console.WriteLine("Hilo 1");
                    break;
                case 2:
                    correr(thread2);
                    dataGridViewProcesos.CurrentRow.Cells[2].Value = thread2.ThreadState;
                    Console.WriteLine("Hilo 2");
                    break;
                default:
                    // Aqui puede ir una alerta de proceso terminado
                    break;
            }
        }

        private void buttonSuspender_Click(object sender, EventArgs e)
        {
            setHilo();
            switch (hilo)
            {
                case 1:
                    suspender(thread1);
                    dataGridViewProcesos.CurrentRow.Cells[2].Value = thread1.ThreadState;
                    Console.WriteLine("Hilo 1");
                    break;
                case 2:
                    suspender(thread2);
                    dataGridViewProcesos.CurrentRow.Cells[2].Value = thread2.ThreadState;
                    Console.WriteLine("Hilo 2");
                    break;
                default:
                    // Aqui puede ir una alerta de proceso terminado
                    break;
            }
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            setHilo();
            switch (hilo)
            {
                case 1:
                    finalizar(ref thread1);
                    dataGridViewProcesos.CurrentRow.Cells[2].Value = thread1.ThreadState;
                    dataGridViewProcesos.CurrentRow.Cells[3].Value = "";
                    agregarProceso(hilo);
                    Console.WriteLine("Hilo 1");
                    break;
                case 2:
                    finalizar(ref thread2);
                    dataGridViewProcesos.CurrentRow.Cells[2].Value = thread2.ThreadState;
                    dataGridViewProcesos.CurrentRow.Cells[3].Value = "";
                    agregarProceso(hilo);
                    Console.WriteLine("Hilo 2");
                    break;
                default:
                    // Aqui puede ir una alerta de proceso terminado
                    break;
            }
        }
    }
}
