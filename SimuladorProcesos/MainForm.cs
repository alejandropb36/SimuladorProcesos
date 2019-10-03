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
        private Process[] process;
        private LinkedList<Proceso> procesos;

        private Random random;
        private RoundRobin roundRobin;

        public MainForm()
        {
            InitializeComponent();
            procesos = new LinkedList<Proceso>();
            random = new Random();
            process = Process.GetProcesses();
            cargarProcesos();
            buttonBloquear.Hide();
            buttonTerminar.Hide();
        }

        private void cargarProcesos()
        {
            int tiempo;
            int prioridad;
            /* Carga todo lo procesos*/
            //foreach (Process p in process)
            //{
            //    tiempo = random.Next(2, 5);
            //    Proceso proceso = new Proceso(p.Id, p.ProcessName, tiempo);
            //    procesos.AddLast(proceso);
            //    agregarProceso(proceso);
            //}

            /*Carga solo 15*/
            for (int i = 0; i < 5; i++)
            {
                tiempo = random.Next(2, 5);
                prioridad = random.Next(1, 5);
                Proceso proceso = new Proceso(process[i].Id, process[i].ProcessName, tiempo, prioridad);
                procesos.AddLast(proceso);
                agregarProceso(proceso);
            }
        }

        private void agregarProceso(Proceso proceso)
        {
            string id = proceso.Id.ToString();
            string nombre = proceso.Nombre;
            string estado = proceso.Estado;
            string tiempo = proceso.Tiempo.ToString();
            string prioridad = proceso.Prioridad.ToString();
            string[] row = {id, nombre, estado, tiempo, prioridad};
            dataGridViewProcesos.Rows.Add(row);
        }

        private void buttonCorrer_Click(object sender, EventArgs e)
        {
            int quantum = (int)numericUpDownQuantum.Value;
            Proceso[] arrProcesos = procesos.ToArray();

            buttonBloquear.Hide();
            numericUpDownQuantum.Hide();
            labelQuantum.Text += ": " + quantum;

            roundRobin = new RoundRobin(ref dataGridViewProcesos);
            roundRobin.runRoundRobin(ref arrProcesos, quantum, ref labelQuantum);
        }

        private void buttonSuspender_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Luis Alejandro Ponce Brizuela\n\n" +
                "Seminario de sistemas operativos\n\n" +
                "TANENBAUM Andrew - Sistemas Operativos Diseno e Implementacion , pag: 84 - 85\n\n" +
                "Algoritmo de Round Robin");
        }
    }
}
