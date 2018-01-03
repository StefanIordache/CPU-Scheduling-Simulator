using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduling_Simulator.Models
{
    public class Scheduler
    {
        public SchedulerAlgorithm Algorithm { get; set; }

        public SchedulerStatus Status { get; set; }

        public CpuUtilization CpuUtilization { get; set; }

        public int CurrentTime { get; set; }

        public double AverageWaitingTime { get; set; }

        public double AverageTurnaroundTime { get; set; }

        public double AverageResponseTime { get; set; }

        public virtual ICollection<Process> ProcesesList { get; set; }

        public virtual ICollection<Process> ProcessesQueue { get; set; }
    }

    public enum SchedulerAlgorithm
    {
        FCFS = 1, //First Come First Serve
        RR = 2 //Round Robin
    }

    public enum SchedulerStatus
    {
        On = 0,
        Off = 1
    }

    public enum CpuUtilization
    {
        No = 0,
        Yes = 1
    }


}
