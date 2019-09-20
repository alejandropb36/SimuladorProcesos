﻿using System;
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

        }

        private void cargarProcesos()
        {
            int tiempo;

            /* Carga todo lo procesos*/
            foreach (Process p in process)
            {
                tiempo = random.Next(2, 8);
                Proceso proceso = new Proceso(p.Id, p.ProcessName, tiempo);
                procesos.AddLast(proceso);
                agregarProceso(proceso);
            }

            /*Carga solo 15*/
            //for (int i = 0; i < 15; i++)
            //{
            //    tiempo = random.Next(2, 5);
            //    Proceso proceso = new Proceso(process[i].Id, process[i].ProcessName, tiempo);
            //    procesos.AddLast(proceso);
            //    agregarProceso(proceso);
            //}
        }

        private void agregarProceso(Proceso proceso)
        {
            string id = proceso.Id.ToString();
            string nombre = proceso.Nombre;
            string estado = proceso.Estado;
            string tiempo = proceso.Tiempo.ToString();
            string[] row = {id, nombre, estado, tiempo};
            dataGridViewProcesos.Rows.Add(row);
        }

        private void buttonCorrer_Click(object sender, EventArgs e)
        {
            int quantum = (int)numericUpDownQuantum.Value;
            Proceso[] arrProcesos = procesos.ToArray();

            buttonBloquear.Hide();
            buttonEjecutar.Hide();
            buttonTerminar.Hide();
            numericUpDownQuantum.Hide();
            labelQuantum.Text += ": " + quantum;

            roundRobin = new RoundRobin(ref dataGridViewProcesos);
            roundRobin.runRoundRobin(ref arrProcesos, quantum);
        }

        private void buttonSuspender_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
