using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static NLHDH_WinProcess.ProcessInfo;

namespace NLHDH_WinProcess
{
    public partial class Algorithm : Form
    {
        public ProcessInfo AlgoInfo;
        List<ProcessInfo> AlgoInfoArr = new List<ProcessInfo>();
        private int txtIndex = 1;
        public Algorithm()
        {
            InitializeComponent();
            lbQuantum.Visible = false;
            txtQuantum.Visible = false;
        }
        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            string processName = txtProcessName.Text;
            int exeTime;
            int arrivalTime;

            if (int.TryParse(txtExeTime.Text, out exeTime) && int.TryParse(txtArrivalTime.Text, out arrivalTime))
            {
                if (!(processName == "" || exeTime < 0 || arrivalTime < 0))
                {
                    txtIndex++;
                    txtProcessName.Text = "P" + txtIndex;
                    tblProcessInfo.Rows.Add(processName,arrivalTime, exeTime);
                    txtExeTime.Clear();
                    txtArrivalTime.Clear();
                    txtArrivalTime.Focus();

                    AlgoInfo = new ProcessInfo(processName, exeTime, arrivalTime);
                    AlgoInfoArr.Add(AlgoInfo);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            List<ProcessInfo>  tmpArr = new List<ProcessInfo>();
            foreach (ProcessInfo info in AlgoInfoArr)
            {
                tmpArr.Add(new ProcessInfo
                {
                    processName = info.processName,
                    executionTime = info.executionTime,
                    arrivalTime = info.arrivalTime
                });
            }
            try
            {
                if(AlgoInfoArr.Count > 0)
                {
                    string typeAlgo = cbTypeAlgo.Text;
                    if(!(txtQuantum.Text == ""))
                    {
                        AlgoView algoView = new AlgoView(typeAlgo, tmpArr, int.Parse(txtQuantum.Text));
                        this.WindowState = FormWindowState.Maximized;
                        algoView.Show();
                    }
                    else
                    {
                        AlgoView algoView = new AlgoView(typeAlgo, tmpArr, 0);
                        this.WindowState = FormWindowState.Maximized;
                        algoView.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Algorithm_Load(object sender, EventArgs e)
        {
            txtProcessName.Text = "P" + txtIndex;
            txtArrivalTime.Focus();
        }

        private void cbTypeAlgo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeAlgo.SelectedItem == "RR")
            {
                lbQuantum.Visible = true;
                txtQuantum.Visible = true;
            }
            else
            {
                lbQuantum.Visible = false;
                txtQuantum.Visible = false;
            }
        }

        private void txtExeTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddProcess_Click(sender, e);
            }
        }
    }
}
