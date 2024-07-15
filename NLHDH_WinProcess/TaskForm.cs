using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLHDH_WinProcess
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        // Chuyển đổi kích thước
        public string BytesToReadableValue(long bytes)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB", "PB" };
            int suffixIndex = 0;
            double doubleBytes = bytes;

            while (doubleBytes >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                doubleBytes /= 1024;
                suffixIndex++;
            }
            return $"{doubleBytes:0.##} {suffixes[suffixIndex]}";
        }

        // Lấy danh sách tiến trình
        public async Task GetProcessListAsync()
        {
            loadingBtn.Visible = true;
            taskDgv.Visible = false;

            await Task.Run(() =>
            {
                Process[] processes = Process.GetProcesses();
                Dictionary<string, long> processMemoryDict = new Dictionary<string, long>();

                foreach (Process process in processes)
                {
                    string processName = process.ProcessName;
                    int processId = process.Id;
                    long processMemory = process.WorkingSet64;

                    if (processMemoryDict.ContainsKey(processName))
                    {
                        processMemoryDict[processName] += processMemory;
                    }
                    else
                    {
                        processMemoryDict.Add(processName, processMemory);
                    }
                }
                foreach (var kvp in processMemoryDict)
                {
                    string processName = kvp.Key;
                    int processId = Process.GetProcessesByName(processName).FirstOrDefault()?.Id ?? -1;
                    long processMemory = kvp.Value;
                    bool isResponding = Process.GetProcessesByName(processName).FirstOrDefault()?.Responding ?? false;
                    string status = isResponding ? "Responding" : "Not responding";
                    string memory = BytesToReadableValue(processMemory);

                    taskDgv.Invoke((MethodInvoker)(() =>
                    {
                        taskDgv.Rows.Add(processName, processId, status, memory);
                    }));
                }
            });

            loadingBtn.Visible = false;
            taskDgv.Visible = true;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            await GetProcessListAsync();
        }

        // Sự kiện end task
        private void endtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (taskDgv.SelectedRows.Count > 0)
            {
                int processId = Convert.ToInt32(taskDgv.SelectedRows[0].Cells["pid"].Value);

                try
                {
                    Process process = Process.GetProcessById(processId);
                    process.Kill();
                    taskDgv.Rows.RemoveAt(taskDgv.SelectedRows[0].Index);
                    taskSearch.Clear();
                }
                catch
                {
                    MessageBox.Show("Tiến trình không tồn tại!");
                }
            }
        }

        // Tìm kiếm tiến trình
        private void taskSearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = taskSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập tên tiến trình!");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in taskDgv.Rows)
            {
                if (!row.IsNewRow) // Kiểm tra xem dòng có phải là dòng mới chưa được lưu hay không
                {
                    if (loadingBtn.Visible == false)
                    {
                        var cellValue = row.Cells["processDgv"].Value;
                        if (cellValue != null && cellValue.ToString().ToLower().Contains(searchText))
                        {
                            row.Visible = true;
                            row.Selected = true;
                            taskDgv.FirstDisplayedScrollingRowIndex = row.Index;
                            found = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Không tìm thấy tiến trình!");
            }
        }

        // Tìm kiếm tiến trình
        private void taskSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                taskSearchBtn_Click(sender, e);
                e.SuppressKeyPress = true; 
            }
            else
            {
                return;
            }
        }

        // Cập nhật tiến trình mới
        private async void updateTaskBtn_Click(object sender, EventArgs e)
        {
            taskDgv.Invoke((MethodInvoker)(() =>
            {
                taskDgv.Rows.Clear();
            }));
            await GetProcessListAsync();
        }

        private async void UpdateTimer_Tick(object sender, EventArgs e)
        {
            taskDgv.Rows.Clear();
            await GetProcessListAsync();
        }

        private void taskSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskSearch.Text))
            {
                foreach (DataGridViewRow row in taskDgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = true;
                    }
                }
            }
        }
    }
}