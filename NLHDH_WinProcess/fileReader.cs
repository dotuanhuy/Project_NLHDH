using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace NLHDH_WinProcess
{
    public partial class fileReader : Form
    {
        public fileReader()
        {
            InitializeComponent();
            getAllFileInPath(@"G:\Download\viewForNLHDH"); // đổi tên đường dẫn tới thư mục 
            txtPath.Text = @"G:\Download\viewForNLHDH";
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtPath.Text = folderBrowserDialog.SelectedPath;

                    // Xóa dữ liệu cũ trong DataGridView
                    dgvFileInfo.Rows.Clear();

                    // Lấy thông tin file trong thư mục mới và thêm vào DataGridView
                    getAllFileInPath(txtPath.Text);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string currentFolderPath = txtPath.Text;

            if (!string.IsNullOrWhiteSpace(currentFolderPath) && Directory.Exists(currentFolderPath))
            {
                // lấy các thư mục con
                string[] subdirectories = Directory.GetDirectories(currentFolderPath);

                if (subdirectories.Length > 0)
                {
                    string nextFolderPath = subdirectories[0]; // Lấy thư mục con đầu tiên

                    txtPath.Text = nextFolderPath; // gán đường dẫn mới

                    // Xóa dữ liệu cũ trong DataGridView
                    dgvFileInfo.Rows.Clear();

                    // Lấy thông tin file trong thư mục mới và thêm vào DataGridView
                    getAllFileInPath(nextFolderPath);
                }
                else
                {
                    MessageBox.Show("Không có thư mục con");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thư mục trước");
                btnPickFolder_Click(sender, e);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            string currentFolderPath = txtPath.Text;

            if (!string.IsNullOrWhiteSpace(currentFolderPath) && Directory.Exists(currentFolderPath))
            {
                // lấy đường dẫn thư mục cha
                string parentFolderPath = Directory.GetParent(currentFolderPath)?.FullName;

                if (!string.IsNullOrEmpty(parentFolderPath))
                {
                    txtPath.Text = parentFolderPath;

                    // Xóa dữ liệu cũ trong DataGridView
                    dgvFileInfo.Rows.Clear();

                    // Lấy thông tin trong thư mục mới và thêm vào DataGridView
                    getAllFileInPath(parentFolderPath);
                }
                else
                {
                    MessageBox.Show("Không có thư mục cha");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thư mục trước");
                btnPickFolder_Click(sender, e);
            }
        }

        // Chuyển đổi kích thước file sang định dạng đọc được
        public string ConvertFileSize(long size)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;

            while (size >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                size /= 1024;
                suffixIndex++;
            }

            return $"{size} {suffixes[suffixIndex]}";
        }

        // Load thư mục tương ứng với path
        public void getAllFileInPath(string path)
        {
            // Kiểm tra xem path có phải là đường dẫn tới một thư mục không
            if (Directory.Exists(path))
            {
                // Lấy danh sách các file trong thư mục
                string[] files = Directory.GetFiles(path);
                dgvFileInfo.Rows.Clear();

                // Lấy thông tin về từng file và thêm vào DataGridView
                foreach (string file in files)
                {
                    // sử dụng fileInfo để lấy các thông tin về file
                    FileInfo fileInfo = new FileInfo(file);
                    string fileName = fileInfo.Name;
                    string fileExtension = fileInfo.Extension;
                    long fileSize = fileInfo.Length;
                    string formattedFileSize = ConvertFileSize(fileSize);
                    DateTime fileCreationDate = fileInfo.CreationTime;
                    dgvFileInfo.Rows.Add(fileName, fileExtension, formattedFileSize, fileCreationDate);
                }
            }
            else
            {
                MessageBox.Show("Đường dẫn không hợp lệ");
            }
        }

        private void fileInfoMenu_Opening(object sender, CancelEventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn trong DataGridView hay không
            if (dgvFileInfo.SelectedRows.Count > 0)
            {
                // Hiển thị tùy chọn "Xóa" trong ContextMenu
                xóaToolStripMenuItem.Visible = true;
            }
            else
            {
                // Ẩn tùy chọn "Xóa" trong ContextMenu
                xóaToolStripMenuItem.Visible = false;
            }
        }


        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFileInfo.SelectedRows.Count > 0)
            {
                // Lấy hàng đầu tiên được chọn
                DataGridViewRow selectedRow = dgvFileInfo.SelectedRows[0];

                // Lấy thông tin về tệp tin từ hàng được chọn
                string fileName = selectedRow.Cells["fileName"].Value.ToString();
                string filePath = Path.Combine(txtPath.Text, fileName);

                try
                {
                    // Di chuyển tệp tin vào Recycle Bin
                    FileSystem.DeleteFile(filePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                    dgvFileInfo.Rows.Remove(selectedRow);
                    MessageBox.Show("Xóa file thành công");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi xóa file " + exp.Message);
                }
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPath.Text == "")
            {
                btnPickFolder_Click(sender, e);
            }
            dgvFileInfo.Visible = false;
            txtFileName.Visible = true;
            txtFileContent.Visible = true;
            btnCancelFile.Visible = true;
            btnAddFile.Visible = true;
            txtFileName.Focus();
        }

        private void fileReader_Load(object sender, EventArgs e)
        {
            txtFileName.Visible = false;
            txtFileContent.Visible = false;
            btnAddFile.Visible = false;
            btnCancelFile.Visible = false;
        }

        private void btnCancelFile_Click(object sender, EventArgs e)
        {
            btnCancelFile.Visible = false;
            txtFileName.Visible = false;
            txtFileContent.Visible = false;
            btnAddFile.Visible = false;
            dgvFileInfo.Visible = true;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            string content = txtFileContent.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                // tạo tên file nếu người dùng không nhập tên
                int randomNumber = new Random().Next(1, 1000);
                fileName = "NewFile" + randomNumber.ToString();
            }

            string folderPath = txtPath.Text;
            if (!string.IsNullOrWhiteSpace(folderPath) && Directory.Exists(folderPath))
            {
                // đường dẫn lưu file
                string filePath = Path.Combine(folderPath, fileName + ".txt");

                try
                {
                    // ghi file
                    File.WriteAllText(filePath, content);
                    MessageBox.Show("Tạo tệp tin thành công");
                    txtFileName.Visible = false;
                    txtFileName.Clear();
                    txtFileContent.Visible = false;
                    txtFileContent.Clear();
                    btnAddFile.Visible = false;
                    btnCancelFile.Visible = false;
                    dgvFileInfo.Visible=true;
                    getAllFileInPath(txtPath.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thư mục trước");
                btnPickFolder_Click(sender, e);
            }
        }

        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFileInfo.SelectedRows.Count > 0)
            {
                // combine thành file path
                DataGridViewRow selectedRow = dgvFileInfo.SelectedRows[0];
                string fileName = selectedRow.Cells["fileName"].Value.ToString();
                string filePath = Path.Combine(txtPath.Text, fileName);

                try
                {
                    // lấy định dạng file
                    string fileExtension = Path.GetExtension(filePath);

                    if (fileExtension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        // đọc file và lưu vào biến fileContent
                        string fileContent = File.ReadAllText(filePath);

                        // tạo textbox để hiện thị file
                        TextBox textBox = new TextBox();
                        textBox.Multiline = true;
                        textBox.ScrollBars = ScrollBars.Vertical;
                        textBox.Dock = DockStyle.Fill;
                        textBox.Font = new Font(textBox.Font.FontFamily, 14f, textBox.Font.Style);
                        textBox.Text = fileContent;
                        textBox.ReadOnly = true;

                        // Tạo form mới hiển thị text
                        Form form = new Form();
                        form.Width = 800; // Kích thước chiều rộng
                        form.Height = 600; // Kích thước chiều cao 

                        // Đặt vị trí của form giữa màn hình
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.Text = "File Viewer";
                        form.Controls.Add(textBox);
                        form.ShowDialog();
                    }
                    else if (IsImageFile(fileExtension))
                    {
                        // tạo picturebox để xem ảnh
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox.Image = Image.FromFile(filePath);

                        // Tạo form
                        Form form = new Form();
                        form.Width = 800; // Kích thước chiều rộng 
                        form.Height = 600; // Kích thước chiều cao 

                        // Đặt vị trí của form giữa màn hình
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.Text = "Image Viewer";
                        form.Controls.Add(pictureBox);
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không hỗ trợ xem định dạng này");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file muốn xem");
            }
        }

        // kiểm tra xem có phải file ảnh không
        private bool IsImageFile(string fileExtension)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return imageExtensions.Contains(fileExtension, StringComparer.OrdinalIgnoreCase);
        }
    }

}
