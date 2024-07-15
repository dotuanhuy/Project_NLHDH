using NLHDH_WinProcess.Thread;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace NLHDH_WinProcess
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.Start("calc.exe"); 
            }
            catch
            {
                return;
            }
        }


        private void wordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.Start("winword");
            }
            catch
            {
                return;
            }
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.Start("excel");
            }
            catch
            {
                return;
            }
        }

        private void chromeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = Process.Start("chrome");
            }
            catch
            {
                return;
            }

        }

        private void thispcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fileReader fr = new fileReader();
                fr.Show();
            }
            catch
            {
                return;
            }
        }

        private void taskBtn_Click(object sender, EventArgs e)
        {
            TaskForm task = new TaskForm();
            task.Show();
        }
        private void aboutpcBtn_Click(object sender, EventArgs e)
        {
            AboutPcForm about = new AboutPcForm();
            about.Show();
        }

        private void storageBtn_Click(object sender, EventArgs e)
        {
            storageForm storage = new storageForm();
            storage.Show();
        }

        private bool groupBoxVisible = false; // Biến flag để theo dõi trạng thái hiển thị
        private void winactionBtn_Click(object sender, EventArgs e)
        {
            if (groupBoxVisible) // Nếu GroupBox đang hiển thị
            {
                winactionGroup.Visible = false;
                groupBoxVisible = false;
            }
            else
            {
                winactionGroup.Visible = true;
                groupBoxVisible = true;
            }
        }

        // sleep pc
        [DllImport("powrprof.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);
        private void sleepBtn_Click(object sender, EventArgs e)
        {
            SetSuspendState(false, true, false); // set sleep
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe", 
                Arguments = "/C shutdown /r /t 0", // Lệnh restart bằng cmd
                CreateNoWindow = true, 
                UseShellExecute = false 
            };

            
            Process restartProcess = new Process
            {
                StartInfo = psi
            };

            restartProcess.Start(); // chạy cmd
        }

        private void shutdownBtn_Click(object sender, EventArgs e)
        {
            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe", 
                Arguments = "/C shutdown /s /t 0", // Lệnh shutdown bằng cmd
                CreateNoWindow = true,
                UseShellExecute = false 
            };

            Process shutdownProcess = new Process
            {
                StartInfo = psi
            };

            shutdownProcess.Start(); 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAlgo_Click(object sender, EventArgs e)
        {
            Algorithm algorithm = new Algorithm();
            algorithm.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.StartPosition = FormStartPosition.Manual;
            server.Left = 100;
            server.Top = 200;
            ClientChat chat = new ClientChat();
            chat.StartPosition = FormStartPosition.Manual;
            chat.Left = 1000;
            chat.Top = 200;
            server.Show();
            chat.Show();
        }
    }
}