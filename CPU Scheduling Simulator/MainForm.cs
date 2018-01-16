using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        //Add new process inside our table (list) and Scheduler memory
        private void buttonInput_Click(object sender, EventArgs e)
        {
            var durationString = textBoxDuration.Text;
            var arrivalTimeString = textBoxArrivalTime.Text;
            var priorityString = "0";
            //var priorityString = textBoxPriority.Text;
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

                if (ioTime == 0)
                {
                    burstTime = duration;
                    burstTimeString = durationString;
                }

                Process newProcess = new Process(Global.Scheduler.ProcessesList.Count + 1, duration, arrivalTime, priority, burstTime, ioTime);
                Global.Scheduler.ProcessesList.Add(newProcess);
                Global.ProcessesInList.Add(CloneObject.CloneJson(newProcess));

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
                for (int it = 0; it < Global.ProcessesInList.Count; it++)
                {
                    if (Global.ProcessesInList[it].Id == processToBeDeletedId)
                    {
                        Global.ProcessesInList.RemoveAt(it);
                        it = Global.ProcessesInList.Count + 1;
                    }
                }
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
                    Global.Scheduler = new Scheduler();
                    if (Global.ProcessesInList.Count > 0)
                    {
                        Global.Scheduler.ProcessesList = CloneObject.CloneJson(Global.ProcessesInList);
                    }
                    Global.Scheduler.Algorithm = SchedulerAlgorithm.FCFS;
                    Global.Scheduler.solveFCFS();
                    Global.Scheduler.ComputeData();

                    buttonGanttChart.Visible = true;
                }
                else if (radioButtonSJF.Checked)
                {
                    Global.Scheduler = new Scheduler();
                    if (Global.ProcessesInList.Count > 0)
                    {
                        Global.Scheduler.ProcessesList = CloneObject.CloneJson(Global.ProcessesInList);
                    }
                    Global.Scheduler.Algorithm = SchedulerAlgorithm.SJF;
                    Global.Scheduler.solveSJF();
                    Global.Scheduler.ComputeData();

                    buttonGanttChart.Visible = true;
                }
                else if (radioButtonBoth.Checked)
                {
                    //FCFS
                    Global.Scheduler = new Scheduler();
                    if (Global.ProcessesInList.Count > 0)
                    {
                        Global.Scheduler.ProcessesList = CloneObject.CloneJson(Global.ProcessesInList);
                    }
                    Global.Scheduler.Algorithm = SchedulerAlgorithm.FCFS;
                    Global.Scheduler.solveFCFS();
                    Global.Scheduler.ComputeData();

                    cpuChart.Series["Average Response Time"].Points.AddY(Global.Scheduler.AverageResponseTime);
                    cpuChart.Series["Average Waiting Time"].Points.AddY(Global.Scheduler.AverageWaitingTime);
                    cpuChart.Series["Average Turnaround Time"].Points.AddY(Global.Scheduler.AverageTurnaroundTime);
                    cpuChart.Series["Average CPU Utilisation"].Points.AddY(Global.Scheduler.AverageCPUUtilisation);
                    cpuChart.Series["Average No of Waiting Processes"].Points.AddY(Global.Scheduler.AverageWaitingProcesses);

                    //SJF
                    Global.Scheduler = new Scheduler();
                    if (Global.ProcessesInList.Count > 0)
                    {
                        Global.Scheduler.ProcessesList = CloneObject.CloneJson(Global.ProcessesInList);
                    }
                    Global.Scheduler.Algorithm = SchedulerAlgorithm.SJF;
                    Global.Scheduler.solveSJF();
                    Global.Scheduler.ComputeData();

                    buttonGanttChart.Visible = false;
                }

                cpuChart.Series["Average Response Time"].Points.AddY(Global.Scheduler.AverageResponseTime);
                cpuChart.Series["Average Waiting Time"].Points.AddY(Global.Scheduler.AverageWaitingTime);
                cpuChart.Series["Average Turnaround Time"].Points.AddY(Global.Scheduler.AverageTurnaroundTime);
                cpuChart.Series["Average CPU Utilisation"].Points.AddY(Global.Scheduler.AverageCPUUtilisation);
                cpuChart.Series["Average No of Waiting Processes"].Points.AddY(Global.Scheduler.AverageWaitingProcesses);


            }
        }

        private void buttonGanttChart_Click(object sender, EventArgs e)
        {
            new ChartForm().Show();
        }

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            string line;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; 
            dialog.Multiselect = false; 
            if (dialog.ShowDialog() == DialogResult.OK) 
            {
                String path = dialog.FileName; 
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) 
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] bits = line.Split(' ');

                        var priorityString = "0";
                        int duration = Int32.Parse(bits[1]);
                        int arrivalTime = Int32.Parse(bits[0]);
                        int priority = Int32.Parse(priorityString);
                        int burstTime = Int32.Parse(bits[2]);
                        int ioTime = Int32.Parse(bits[3]);

                        if (ioTime == 0)
                        {
                            burstTime = duration;
                            bits[2] = bits[1];
                        }

                        Process newProcess = new Process(Global.Scheduler.ProcessesList.Count + 1, duration, arrivalTime, priority, burstTime, ioTime);
                        Global.Scheduler.ProcessesList.Add(newProcess);
                        Global.ProcessesInList.Add(CloneObject.CloneJson(newProcess));

                        Input.AddProcessToTable(dataGridViewProcessesList, newProcess.Id, bits[1], bits[0], priorityString, bits[2], bits[3]);
                    }
                }
            }
        }
    }
}
