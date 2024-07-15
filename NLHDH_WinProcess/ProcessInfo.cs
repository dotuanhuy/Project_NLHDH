using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLHDH_WinProcess
{
    public class ProcessInfo
    {   
        public ProcessInfo(string processName, int executionTime, int arrivalTime) {
            this.processName = processName;
            this.executionTime = executionTime;
            this.arrivalTime = arrivalTime;
        }

        public ProcessInfo(){
        }

        public string processName { get; set; }
        public int executionTime { get; set; }
        public int arrivalTime { get; set; }

    }
}
