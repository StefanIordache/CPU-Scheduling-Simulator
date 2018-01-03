using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Scheduling_Simulator.Models
{
    public enum ProcessStatus
    {
        NotStarted = -1,
        Waiting = 0,
        OnCpu = 1,
        Finished = 2    
    }

    public class Process
    {
        public int Id { get; set; }

        public int Order { get; set; }

        public int ArrivalTime { get; set; }

        public int Duration { get; set; }

        public int RemainingDuration { get; set; }

        public int FinishTime { get; set; }

        public int WaitingTime { get; set; }

        public bool Finished { get; set; }

        public int Priority { get; set; }

        public double CompletedPercentage { get; set; }

        public ProcessStatus Status { get; set; }
    }
}
