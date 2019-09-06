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
        private Queue<Proceso> colaProcesos;
        private Queue<Proceso> colaProcesosListos;
        private Queue<Proceso> colaProcesosBloqueados;
        private Random random;

        public MainForm()
        {
            InitializeComponent();
            colaProcesos = new Queue<Proceso>();
            colaProcesosListos = new Queue<Proceso>();
            colaProcesosBloqueados = new Queue<Proceso>();
            
            random = new Random();

            process = Process.GetProcesses();
            foreach(Process p in process)
            {
                int duracion = random.Next(2,8);
                Proceso proceso = new Proceso(p.Id, p.ProcessName, Proceso.Estado.LISTO, 0, duracion);
                colaProcesos.Enqueue(proceso);
            }
            agregarProceso();
            dataGridViewProcesos.Rows[0].Selected = true;
            dataGridViewProcesos.Select();
            thread1 = new Thread(new ThreadStart(ejecutar));
        }

        private void prepararProceso()
        {
            while (true)
                Thread.Sleep(100);
        }

        private void agregarProceso()
        {
            Proceso proceso = colaProcesos.Dequeue();
            dataGridViewProcesos.Rows.Add(proceso.getId(), proceso.getNombre(), proceso.getEstado(), proceso.getDuracion().ToString());
        }

        private void ejecutar ()
        {
            dataGridViewProcesos.Rows[0].Cells[2].Value = Proceso.Estado.EJECUCION;
            int tiempo = int.Parse(dataGridViewProcesos.Rows[0].Cells[3].Value.ToString());
            tiempo = tiempo * 1000;
            Thread.Sleep(tiempo);
            dataGridViewProcesos.Rows.Remove(dataGridViewProcesos.Rows[0]);
            ejecutar();

        }

        private void bloquear()
        {
            
        }

        private void Terminar()
        {
            
        }

        private void fcfs()
        {
           
        }

        private void buttonCorrer_Click(object sender, EventArgs e)
        {

        }

        private void buttonSuspender_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
