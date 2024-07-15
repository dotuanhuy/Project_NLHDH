using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NLHDH_WinProcess
{
    public partial class storageForm : Form
    {
        public class InstalledAppInfo
        {
            public string Name { get; set; }
            public string Size { get; set; }
        }

        public storageForm()
        {
            InitializeComponent();
        }

        private void storageForm_Load(object sender, EventArgs e)
        {
            // Lấy thông tin về ứng dụng đã cài đặt
            List<InstalledAppInfo> appInfoList = AppInfoRetriever.GetInstalledAppInfo();

            storageDgv.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            nameColumn.Name = "Name";
            storageDgv.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn sizeColumn = new DataGridViewTextBoxColumn();
            sizeColumn.DataPropertyName = "Size";
            sizeColumn.HeaderText = "Size";
            sizeColumn.Name = "Size";
            storageDgv.Columns.Add(sizeColumn);

            storageDgv.DataSource = appInfoList;
        }

        public class AppInfoRetriever
        {
            public static List<InstalledAppInfo> GetInstalledAppInfo()
            {
                // Đường dẫn trong Registry để lấy thông tin về ứng dụng
                string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                string uninstallKeyWow6432Node = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";

                // Danh sách chứa thông tin ứng dụng đã cài đặt
                List<InstalledAppInfo> appInfoList = new List<InstalledAppInfo>();

                // Lấy thông tin từ Registry
                RetrieveAppInfoFromRegistry(uninstallKey, appInfoList);
                RetrieveAppInfoFromRegistry(uninstallKeyWow6432Node, appInfoList);

                return appInfoList;
            }

            private static void RetrieveAppInfoFromRegistry(string uninstallKeyPath, List<InstalledAppInfo> appInfoList)
            {
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(uninstallKeyPath))
                {
                    if (key != null)
                    {
                        string[] subKeyNames = key.GetSubKeyNames();

                        foreach (string subKeyName in subKeyNames)
                        {
                            using (var subKey = key.OpenSubKey(subKeyName))
                            {
                                // Lấy tên hiển thị và kích thước ước tính từ Registry
                                string displayName = subKey.GetValue("DisplayName") as string;
                                object sizeObject = subKey.GetValue("EstimatedSize");

                                if (!string.IsNullOrEmpty(displayName) && sizeObject != null)
                                {
                                    // Chuyển đổi kích thước
                                    long size;
                                    if (long.TryParse(sizeObject.ToString(), out size))
                                    {
                                        string sizeString = FormatSize(size);

                                        // Tạo đối tượng InstalledAppInfo và thêm vào danh sách
                                        InstalledAppInfo appInfo = new InstalledAppInfo
                                        {
                                            Name = displayName,
                                            Size = sizeString
                                        };

                                        appInfoList.Add(appInfo);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            private static string FormatSize(long size)
            {
                string[] suffixes = { "KB", "MB", "GB", "TB" };
                int suffixIndex = 0;
                double formattedSize = size;

                // Quy đổi kích thước
                while (formattedSize >= 1024 && suffixIndex < suffixes.Length - 1)
                {
                    formattedSize /= 1024;
                    suffixIndex++;
                }

                return string.Format("{0} {1}", formattedSize.ToString("0.##"), suffixes[suffixIndex]);
            }
        }
    }
}