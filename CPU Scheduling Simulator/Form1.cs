﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPU_Scheduling_Simulator.Helpers;
using CPU_Scheduling_Simulator.Models;
using Process = CPU_Scheduling_Simulator.Models.Process;
using Scheduler = CPU_Scheduling_Simulator.Models.Scheduler;

namespace CPU_Scheduling_Simulator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //Add new process inside our table (list) and Scheduler memory
        private void buttonInput_Click(object sender, EventArgs e)
        {
            var durationString = textBoxDuration.Text;
            var arrivalTimeString = textBoxArrivalTime.Text;
            var priorityString = textBoxPriority.Text;
            var burstTimeString = textBoxBurstTime.Text;
            var ioTimeString = textBoxIOTime.Text;

            string inputErrors = Input.CheckInputErrors(durationString, arrivalTimeString, priorityString, burstTimeString, ioTimeString);
            if (!String.IsNullOrEmpty(inputErrors))
            {
                MessageBox.Show(inputErrors);
            }
            else
            {
                int duration = Int32.Parse(durationString);
                int arrivalTime = Int32.Parse(arrivalTimeString);
                int priority = Int32.Parse(priorityString);
                int burstTime = Int32.Parse(burstTimeString);
                int ioTime = Int32.Parse(ioTimeString);

                Process newProcess = new Process(Global.Scheduler.ProcessesList.Count + 1, duration, arrivalTime, priority, burstTime, ioTime);
                Global.Scheduler.ProcessesList.Add(newProcess);

                Input.AddProcessToTable(dataGridViewProcessesList, newProcess.Id, durationString, arrivalTimeString, priorityString, burstTimeString, ioTimeString);
            }
        }


        //Delete process from table and Scheduler memory
        private void dataGridViewProcessesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int numberOfProcesses = Global.Scheduler.ProcessesList.Count;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex < numberOfProcesses)
            {
                int processToBeDeletedId = e.RowIndex + 1;
                for (int it = processToBeDeletedId; it < numberOfProcesses; it++)
                {
                    senderGrid.Rows[it].Cells[0].Value = (Int32.Parse(senderGrid.Rows[it].Cells[0].Value.ToString()) - 1).ToString();
                }
                senderGrid.Rows.Remove(senderGrid.Rows[e.RowIndex]);
                Global.Scheduler.RemoveProcess(processToBeDeletedId);
            }
        }

        private void buttonStartSimulation_Click(object sender, EventArgs e)
        {
            if (Global.Scheduler.ProcessesList.Count == 0)
            {
                MessageBox.Show("Insert at least one process before starting the simulation.");
            }
            else
            {
                if (radioButtonFCFS.Checked)
                {
                    Global.Scheduler.solveFCFS();
                }
                else if (radioButtonSJF.Checked)
                {
                    Global.Scheduler.solveSJF();
                }
                else if (radioButtonRR.Checked)
                {
                    Global.Scheduler.solveRR();
                }
            }
        }
    }
}
