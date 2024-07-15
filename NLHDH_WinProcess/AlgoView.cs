using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace NLHDH_WinProcess
{
    public partial class AlgoView : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<ProcessResult> processResults;
        private int currentIndex;
        private string labelFirst;
        List<ProcessInfo> processInfo;
        List<ProcessInfo> processInfoBackUp;
        List<ProcessInfo> processInfoGantt;
        string algoType;
        List<ProcessRun> runResultList;
        public class ProcessRun
        {
            public string name { get; set; }    
            public int runTime { get; set; }
            public int remainTime { get; set; }
            public int endTime { get; set; }

            public ProcessRun() { }

            public ProcessRun (string name, int runTime, int remainTime)
            {
                this.name = name;
                this.runTime = runTime;
                this.remainTime = remainTime;
            }

            public ProcessRun(string name, int runTime, int remainTime, int endTime)
            {
                this.name = name;
                this.runTime = runTime;
                this.remainTime = remainTime;
                this.endTime = endTime;
            }
        }

        public AlgoView(string typeAlgo, List<ProcessInfo> AlgoInfoArr, int quantum)
        {
            InitializeComponent();
            processInfo = AlgoInfoArr;
            algoType = typeAlgo;
            labelFirst = AlgoInfoArr[0].arrivalTime.ToString();

            processInfoBackUp = new List<ProcessInfo>();
            foreach (ProcessInfo info in processInfo)
            {
                processInfoBackUp.Add(new ProcessInfo
                {
                    processName = info.processName,
                    executionTime = info.executionTime,
                    arrivalTime = info.arrivalTime
                });
            }

            currentIndex = 0;

            if (typeAlgo == "SJF")
            {
                processInfo.Sort((x, y) => x.arrivalTime.CompareTo(y.arrivalTime));
                List<ProcessRun> queueProcess = new List<ProcessRun>();
                int endTimeProcess = processInfo[0].arrivalTime;
                queueProcess.Add(new ProcessRun(processInfo[0].processName, processInfo[0].executionTime, 0, processInfo[0].executionTime + processInfo[0].arrivalTime));
                
                runResultList = new List<ProcessRun>();
                processInfo.RemoveAt(0);
                while (true)
                {
                    ProcessRun MinProcess = queueProcess.OrderBy(p => p.runTime).First();
                    endTimeProcess += MinProcess.runTime;
                    for (int i = 0; i < processInfo.Count; i++)
                    {
                        if (processInfo[i].arrivalTime <= endTimeProcess)
                        {
                            queueProcess.Add(new ProcessRun(processInfo[i].processName, processInfo[i].executionTime, 0, 0));
                            processInfo.RemoveAt(i);
                            i--;
                        }
                    }
                    runResultList.Add(new ProcessRun(MinProcess.name, MinProcess.runTime, 0, endTimeProcess));
                    queueProcess.Remove(MinProcess);
                    if (queueProcess.Count == 0)
                        break;
                }
                processInfo.Clear();
                foreach (ProcessRun PRun in runResultList)
                {
                    processInfo.Add(new ProcessInfo(PRun.name, PRun.runTime, PRun.endTime));
                }
                processInfoGantt = new List<ProcessInfo>();
                foreach (ProcessInfo info in processInfo)
                {
                    processInfoGantt.Add(new ProcessInfo
                    {
                        processName = info.processName,
                        executionTime = info.executionTime,
                        arrivalTime = info.arrivalTime
                    });
                }
            }
            else if(typeAlgo == "FCFS")
            {
                processInfo.Sort((x, y) => x.arrivalTime.CompareTo(y.arrivalTime));

                runResultList = new List<ProcessRun>();
                int sum = processInfo[0].arrivalTime;
                foreach (ProcessInfo PInfo in processInfo)
                {
                    sum += PInfo.executionTime;
                    ProcessRun PRun = new ProcessRun(PInfo.processName, PInfo.executionTime, 0, sum);
                    runResultList.Add(PRun);
                }
                processInfo.Clear();
                foreach(ProcessRun PRun in runResultList)
                {
                    processInfo.Add(new ProcessInfo(PRun.name, PRun.runTime, PRun.endTime));
                }
                processInfoGantt = new List<ProcessInfo>();
                foreach (ProcessInfo info in processInfo)
                {
                    processInfoGantt.Add(new ProcessInfo
                    {
                        processName = info.processName,
                        executionTime = info.executionTime,
                        arrivalTime = info.arrivalTime
                    });
                }
            }
            else if (typeAlgo == "RR")
            {
                processInfo.Sort((x, y) => x.arrivalTime.CompareTo(y.arrivalTime));
                Queue<ProcessRun> queueProcess = new Queue<ProcessRun>();
                runResultList = new List<ProcessRun>();
                queueProcess.Enqueue(new ProcessRun(processInfo[0].processName, 0, processInfo[0].executionTime, 0));
                int sum = processInfo[0].arrivalTime;
                processInfo.Remove(processInfo[0]);
                while (true)
                {
                    ProcessRun processRun = queueProcess.Count > 0 ? queueProcess.Dequeue() : null;
                    if (processRun != null)
                    {
                        processRun.runTime = processRun.remainTime - quantum > 0 ? quantum : processRun.remainTime;
                        processRun.remainTime = processRun.remainTime - quantum > 0 ? processRun.remainTime - quantum : 0;
                        sum += processRun.runTime;
                        processRun.endTime = sum;
                        for (int i = 0; i < processInfo.Count; i++)
                        {
                            if (processInfo[i].arrivalTime <= processRun.endTime)
                            {
                                queueProcess.Enqueue(new ProcessRun(processInfo[i].processName, 0, processInfo[i].executionTime, 0));
                                processInfo.Remove(processInfo[i]);
                                i--;
                            }
                        }
                        if (processRun.remainTime > 0)
                            queueProcess.Enqueue(processRun);
                        runResultList.Add(new ProcessRun(processRun.name, processRun.runTime, processRun.remainTime, processRun.endTime));
                    }
                    else
                    {
                        break;
                    }
                }
                processInfo.Clear();    
                foreach (ProcessRun pInfo in runResultList)
                {
                    processInfo.Add(new ProcessInfo(pInfo.name, pInfo.runTime, pInfo.endTime));
                }
                processInfoGantt = new List<ProcessInfo>();
                foreach (ProcessInfo info in processInfo)
                {
                    processInfoGantt.Add(new ProcessInfo
                    {
                        processName = info.processName,
                        executionTime = info.executionTime,
                        arrivalTime = info.arrivalTime
                    });
                }
            }
            else if (typeAlgo == "SRTN")
            {
                processInfo.Sort((x, y) => x.arrivalTime.CompareTo(y.arrivalTime));               
                List<ProcessRun> lPRun = new List<ProcessRun>();
                
                runResultList = new List<ProcessRun>();
                int check = processInfo[1].arrivalTime;
                int i = 0;
                int sum = processInfo[0].arrivalTime;
                while (true)
                {
                    for (; i < processInfo.Count; i++)
                    {
                        ProcessRun minProcessRun = lPRun.Count > 0 ? lPRun.OrderBy(p => p.remainTime).First() : null;
                        ProcessRun processRun = new ProcessRun();
                        if (i == 0)
                        {
                            processRun = new ProcessRun(processInfo[i].processName, check - sum, processInfo[i].executionTime - 1);
                            sum += processRun.runTime;
                            processRun.endTime = sum;
                            lPRun.Add(new ProcessRun(processRun.name, processRun.runTime, processRun.remainTime, processRun.endTime));
                            runResultList.Add(new ProcessRun(processRun.name, processRun.runTime, processRun.remainTime, processRun.endTime));
                        }
                        else if (processInfo[i].executionTime < minProcessRun.remainTime)
                        {
                            processRun = new ProcessRun(processInfo[i].processName, 1, processInfo[i].executionTime - 1);
                            sum += processRun.runTime;
                            processRun.endTime = sum;
                            if (processRun.remainTime <= 0) 
                                processRun.remainTime = 0;
                            else
                                lPRun.Add(new ProcessRun(processRun.name, processRun.runTime, processRun.remainTime, processRun.endTime));

                            runResultList.Add(new ProcessRun(processRun.name, processRun.runTime, processRun.remainTime, processRun.endTime));
                        }
                        else 
                        {
                            // Xử lý thằng min
                            processRun = new ProcessRun(minProcessRun.name, 1, minProcessRun.remainTime - 1);
                            sum += processRun.runTime;
                            processRun.endTime = sum;
                            if (processRun.remainTime <= 0) {
                                processRun.remainTime = 0;
                                lPRun.Remove(minProcessRun);
                            }
                            else
                                lPRun.Add(processRun);
                            runResultList.Add(processRun);

                            // Thêm thằng thứ i vào list
                            lPRun.Add(new ProcessRun(processInfo[i].processName, 0, processInfo[i].executionTime));
                        }
                    }
                    // Tính những thằng còn lại trong list
                    ProcessRun minPRun = lPRun.Count > 0 ? lPRun.OrderBy(p => p.remainTime).First() : null;
                    ProcessRun pRun = new ProcessRun(minPRun.name, minPRun.remainTime, 0);
                    sum += pRun.runTime;
                    pRun.endTime = sum;
                    runResultList.Add(pRun);
                    lPRun.Remove(minPRun);
                    if (lPRun.Count == 0)
                        break;
                }
                processInfo.Clear();
                foreach (ProcessRun pInfo in runResultList)
                {
                    processInfo.Add(new ProcessInfo(pInfo.name, pInfo.runTime, pInfo.endTime));
                }
                processInfoGantt = new List<ProcessInfo>();
                foreach (ProcessInfo info in processInfo)
                {
                    processInfoGantt.Add(new ProcessInfo
                    {
                        processName = info.processName,
                        executionTime = info.executionTime,
                        arrivalTime = info.arrivalTime
                    });
                }
            }
        }

        public void result()
        {
            processResults = new List<ProcessResult>();
            for (int i = runResultList.Count - 1; i >= 0; i--)
            {
                if (!processResults.Any(x => x.ProcessName == runResultList[i].name))
                {
                    ProcessResult processResult = new ProcessResult();
                    List<ProcessInfo> temp = processInfoBackUp.Where(p => p.processName == runResultList[i].name).ToList();
                    processResult.ProcessName = runResultList[i].name;
                    processResult.SystemTime = runResultList[i].endTime - temp[0].arrivalTime;
                    processResult.WaitingTime = processResult.SystemTime - temp[0].executionTime;

                    processResults.Add(processResult);
                }
            }
        }

        private void AlgoView_Load(object sender, EventArgs e)
        {
            simulate();
        }

        public void setLableText(ProcessInfo processInfo)
        {
            lbProcessName.Text = processInfo.processName;
            lbExeTime.Text = processInfo.executionTime.ToString();
        }
        private void simulate()
        {
            processResults = new List<ProcessResult>();
            tableLayoutPanel.ColumnCount = processInfo.Count;
            tableLayoutPanel.RowCount = 1;

            for (int i = 0; i < processInfo.Count; i++)
            {
                Button btn = new Button();
                btn.Text = processInfo[i].processName;
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(5); 

                tableLayoutPanel.Controls.Add(btn, i, 0);
            }

            tableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < processInfo.Count; i++)
            {
                ColumnStyle columnStyle = new ColumnStyle(SizeType.Percent, 100F / processInfo.Count);
                tableLayoutPanel.ColumnStyles.Add(columnStyle);
            }

            tableLayoutPanel.AutoScroll = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (algoType == "SJF" || algoType == "FCFS" || algoType == "RR" || algoType == "SRTN") 
            {
                // Kiểm tra chỉ số currentIndex có hợp lệ
                if (currentIndex >= 0 && currentIndex < processInfo.Count)
                {
                    ProcessInfo currentProcess = processInfo[currentIndex];

                    lbProcessName.Text = currentProcess.processName;
                    lbExeTime.Text = currentProcess.executionTime.ToString();

                    currentProcess.executionTime--;

                    Button currentButton = tableLayoutPanel.GetControlFromPosition(currentIndex, 0) as Button;
                    currentButton.BackColor = Color.LightGreen; 

                    for (int i = 0; i < processInfo.Count; i++)
                    {
                        if (i != currentIndex)
                        {
                            Button button = tableLayoutPanel.GetControlFromPosition(i, 0) as Button;
                            button.BackColor = SystemColors.Control; 
                        }
                    }

                    if (currentProcess.executionTime == 0)
                    {
                        if (currentIndex >= processInfo.Count - 1)
                        {
                            timer.Stop();
                            if (algoType == "FCFS" || algoType == "SJF")
                            {
                                result();
                                processResults.Sort((x, y) => x.ProcessName.CompareTo(y.ProcessName));
                                float systemAvg = 0;
                                float waitAvg = 0;
                                tblProcessInfo.Rows.Clear();
                                foreach (ProcessResult process in processResults)
                                {
                                    systemAvg += process.SystemTime;
                                    waitAvg += process.WaitingTime;
                                    tblProcessInfo.Rows.Add(process.ProcessName, process.SystemTime, process.WaitingTime);
                                }
                                lbWaitAvg.Text = (waitAvg / processResults.Count).ToString();
                                lbSystemAvg.Text = (systemAvg / processResults.Count).ToString();
                            }
                            else
                            {
                                result();
                                processResults.Sort((x, y) => x.ProcessName.CompareTo(y.ProcessName));
                                float systemAvg = 0;
                                float waitAvg = 0;
                                tblProcessInfo.Rows.Clear();
                                foreach (ProcessResult process in processResults)
                                {
                                    systemAvg += process.SystemTime;
                                    waitAvg += process.WaitingTime;
                                    tblProcessInfo.Rows.Add(process.ProcessName, process.SystemTime, process.WaitingTime);
                                }
                                lbWaitAvg.Text = (waitAvg / processResults.Count).ToString();
                                lbSystemAvg.Text = (systemAvg / processResults.Count).ToString();
                            }
                            drawGanttChart();
                        }
                        currentIndex++;
                    }
                }
            }

        }

        // Lớp lưu kết quả
        public class ProcessResult
        {
            public string ProcessName { get; set; }
            public int SystemTime { get; set; }
            public int WaitingTime { get; set; }

            public ProcessResult()
            {
                this.ProcessName = "";
                this.SystemTime = 0;
                this.WaitingTime = 0;
            }

            public ProcessResult(string name, int s, int w)
            {
                this.ProcessName = name;
                this.SystemTime = s;
                this.WaitingTime = w;
            }
        }
        public void drawGanttChart()
        {
            if (algoType == "SJF" || algoType == "FCFS" || algoType == "RR" || algoType == "SRTN")
            {
                groupBox.Controls.Clear();
                GroupBoxLabel.Controls.Clear();
                groupBox.AutoSize = true;

                int totalExecutionTime = 0;
                foreach (var processInfo in processInfoGantt)
                {
                    totalExecutionTime += processInfo.executionTime;
                }

                int currentLeft = 0;
                int i;
                Label first = new Label();
                first.Text = labelFirst;
                first.ForeColor = Color.Black;
                first.AutoSize = true;
                GroupBoxLabel.Controls.Add(first);

                for (i = 0; i < processInfoGantt.Count; i++)
                {
                    Button btn = new Button();
                    btn.Text = processInfoGantt[i].processName;
                    btn.ForeColor = Color.Black;
                    btn.AutoSize = true;
                    btn.BackColor = SystemColors.ButtonFace;
                    btn.Height = 58;
                    btn.Left = currentLeft;
                    int processWidth = (int)(((float)processInfoGantt[i].executionTime / totalExecutionTime) * groupBox.Width);
                    btn.Width = processWidth;
                    groupBox.Controls.Add(btn);

                    Label lbl = new Label();
                    int total = 0;
                    for (int j = 0; j < i; j++)
                    {
                        total += processInfoGantt[j].executionTime;
                    }
                    lbl.Text = (total + processInfoGantt[i].executionTime).ToString();
                    lbl.ForeColor = Color.Black;
                    lbl.AutoSize = true;
                    if(i == 0)
                    {
                        currentLeft += groupBox.Controls[0].Width;
                        lbl.Left = currentLeft;
                    }
                    else
                    {
                        currentLeft += processWidth; // Tăng giá trị currentLeft để đặt vị trí tiếp theo của button
                        lbl.Left = currentLeft;
                    }
                    GroupBoxLabel.Controls.Add(lbl);
                    MessageBox.Show(processInfoGantt[i].executionTime.ToString());
                }
            }
        }

        private void AlgoView_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }
    }
}
