using System;
using System.Management;
using System.Windows.Forms;
using System.IO;

namespace NLHDH_WinProcess
{
    public partial class AboutPcForm : Form
    {
        public AboutPcForm()
        {
            InitializeComponent();
        }

        // Lấy tên máy tính
        public string GetComputerName()
        {
            return Environment.MachineName;
        }

        // Lấy tên người dùng
        public string GetUserName()
        {
            return Environment.UserName;
        }

        // Lấy thông tin hệ điều hành
        public string GetOperatingSystem()
        {
            return Environment.OSVersion.VersionString;
        }

        // Lấy thông tin CPU
        public string GetCPU()
        {
            string cpuInfo = string.Empty;
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Name FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuInfo = obj["Name"].ToString();
                    break;
                }
            }
            return cpuInfo;
        }

        // Lấy tổng dung lượng
        public double GetTotalStorage()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            long totalSizeBytes = 0;

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    totalSizeBytes += drive.TotalSize;
                }
            }

            double totalSizeGB = (double)totalSizeBytes / (1024 * 1024 * 1024);
            return totalSizeGB;
        }

        // Lấy thông tin RAM
        public string GetRAM()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    decimal sizeBytes = Convert.ToDecimal(obj["TotalPhysicalMemory"]);
                    decimal sizeGB = sizeBytes / (1024 * 1024 * 1024);
                    return sizeGB.ToString("F2") + " GB";
                }
            }

            return "Unknown";
        }

        // Lấy tên hãng
        public static string GetBrandName()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Manufacturer FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    string manufacturer = obj["Manufacturer"].ToString();
                    return manufacturer;
                }
            }

            return "Unknown";
        }

        // Hiển thị thông tin lên các TextBox trên Form
        public void setInfoToTextBox()
        {
            computerNameTb.Text = GetComputerName();
            usernameTb.Text = GetUserName();
            osTb.Text = GetOperatingSystem();
            cpuTb.Text = GetCPU();
            storageTb.Text = Math.Round(GetTotalStorage()).ToString() + " GB";
            ramTb.Text = GetRAM();
            brandTb.Text = GetBrandName();
        }

        // Sự kiện khi Form được tải
        private void AboutPcForm_Load(object sender, EventArgs e)
        {
            setInfoToTextBox();
        }
    }
}